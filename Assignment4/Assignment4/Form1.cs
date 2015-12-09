using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public BoundedBuffer Buffer { get; private set; }

        public Modifier Modifier { get; private set; }

        public Writer Writer { get; private set; }

        public Reader Reader { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void CopyToDestButton_Click(object sender, EventArgs e)
        {
            this.Buffer = new BoundedBuffer(10, SourceTextBox, NotifyCheckBox.Checked, FindTextBox.Text, ReplaceTextBox.Text);
            this.Modifier = new Modifier(Buffer, SourceTextBox.Lines.Length);
            this.Reader = new Reader(OnReadDone, Buffer, DestinationTextBox, NumOfReplacements ,SourceTextBox.Lines.Length);
            this.Writer = new Writer(Buffer, SourceTextBox.Lines.ToList());

            Writer.Start();
            Reader.Start();
            Modifier.Start();

        }

        private void OnReadDone()
        {
            DestinationTab.BeginInvoke(new MethodInvoker(() => { tabControl1.SelectedIndex = 1; }));
            DestinationTextBox.BeginInvoke(new MethodInvoker(() => { DestinationTextBox.Lines = Reader.StringList.ToArray(); }));
            NumOfReplacements.BeginInvoke(new MethodInvoker(() => { NumOfReplacements.Text = Buffer.NumOfReplacements.ToString(); }));
        }

        private void ClearDestinationButton_Click(object sender, EventArgs e)
        {
            DestinationTextBox.Text = string.Empty;
            HighlightText(SourceTextBox, FindTextBox.Text);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            HighlightText(SourceTextBox, FindTextBox.Text);
        }

        public void HighlightText(RichTextBox myRtb, string word)
        {
            myRtb.SelectAll();
            myRtb.SelectionBackColor = Color.White;
            myRtb.SelectionColor = Color.Black;
            myRtb.DeselectAll();

            if (word == "")
            {
                return;
            }

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = Color.White;
                myRtb.SelectionBackColor = Color.Green;

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            myRtb.SelectionColor = Color.Black;
            myRtb.SelectionBackColor = Color.White;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Reader != null)
                Reader.StopAndJoin();

            if (Writer != null)
                Writer.StopAndJoin();

            if (Modifier != null)
                Modifier.StopAndJoin();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                HighlightText(SourceTextBox, FindTextBox.Text);
            }
        }

        private void SourceTextBox_TextChanged(object sender, EventArgs e)
        {
           // HighlightText(SourceTextBox, FindTextBox.Text);
        }
    }
}
