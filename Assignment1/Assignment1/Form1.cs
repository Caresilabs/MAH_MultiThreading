using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private MusicPlayer     musicPlayer;
        private Thread          triangleThread;
        private Thread          displayThread;
        private Triangle        triangle;
        private DisplayText     display;
        private bool            runTriangle;
        private bool            runDisplay;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.musicPlayer = new MusicPlayer();
            this.triangle = new Triangle(50);
            this.display = new DisplayText("Hello Thread!");
            this.runDisplay = false;
            this.runTriangle = false;
            this.DoubleBuffered = true;
        }

        private void openMusicButton_Click(object sender, EventArgs e)
        {

            if (openMusicDialog.ShowDialog() == DialogResult.OK)
            {
                musicFilePathLabel.Text = openMusicDialog.FileName;
            }
        }

        private void startMusicButton_Click(object sender, EventArgs e)
        {
            musicPlayer.open(openMusicDialog.FileName);
            musicPlayer.play();
        }

        private void stopMusicButton_Click(object sender, EventArgs e)
        {
            musicPlayer.stop();
        }

        private void startDisplayButton_Click(object sender, EventArgs e)
        {
            if (runDisplay || (displayThread != null && displayThread.IsAlive))
                return;

            runDisplay = true;
            var graphics = displayPanel.CreateGraphics();
            (displayThread = new Thread(() => {

                while (runDisplay)
                {
                    Thread.Sleep(200);
                    DrawDisplay(graphics);
                }

            })).Start();
        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawDisplay(e.Graphics);
        }

        private void DrawDisplay(Graphics g)
        {
            g.Clear(Color.Gray);
            display.Draw(g);
        }

        private void stopDisplayButton_Click(object sender, EventArgs e)
        {
            runDisplay = false;
        }

        private void startTriangleButton_Click(object sender, EventArgs e)
        {
            if (runTriangle || (triangleThread != null && triangleThread.IsAlive))
                return;

            runTriangle = true;
            var graphics = trianglePanel.CreateGraphics();
            (triangleThread = new Thread(() => {
              
                while (runTriangle)
                {
                    Thread.Sleep(10);
                    DrawTriangle(graphics);
                }

            })).Start();
        }


        private void trianglePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawTriangle(e.Graphics);
        }

        private void DrawTriangle(Graphics g)
        {
            g.Clear(Color.Gray);
            triangle.Draw(g);
        }

        private void stopTriangleButton_Click(object sender, EventArgs e)
        {
            runTriangle = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (runDisplay)
            {
                runDisplay = false;
                displayThread.Join();
            }

            if (runTriangle)
            {
                runTriangle = false;
                triangleThread.Join();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
