using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Form1 that demostrates Reader,Modifier and writer sync.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Our Buffer.
        /// </summary>
        public BoundedBuffer Buffer { get; private set; }

        /// <summary>
        /// Our modifier.
        /// </summary>
        public Modifier Modifier { get; private set; }

        /// <summary>
        /// Our writer.
        /// </summary>
        public Writer Writer { get; private set; }

        /// <summary>
        /// Our reader.
        /// </summary>
        public Reader Reader { get; private set; }

        /// <summary>
        /// Init components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Run all threads! Our main purpose.
        /// </summary>
        private void CopyToDestButton_Click(object sender, EventArgs e)
        {
            this.Buffer = new BoundedBuffer(10, SourceTextBox, NotifyCheckBox.Checked, FindTextBox.Text, ReplaceTextBox.Text);
            this.Modifier = new Modifier(Buffer, SourceTextBox.Lines.Length);
            this.Reader = new Reader(OnReadDone, Buffer, SourceTextBox.Lines.Length);
            this.Writer = new Writer(Buffer, SourceTextBox.Lines.ToList());

            Writer.Start();
            Reader.Start();
            Modifier.Start();

        }

        /// <summary>
        /// Callback function that gets called when reader is done.
        /// </summary>
        private void OnReadDone()
        {
            DestinationTab.BeginInvoke(new MethodInvoker(() => { tabControl1.SelectedIndex = 1; }));
            DestinationTextBox.BeginInvoke(new MethodInvoker(() => { DestinationTextBox.Lines = Reader.StringList.ToArray(); }));
            NumOfReplacements.BeginInvoke(new MethodInvoker(() => { NumOfReplacements.Text = Buffer.NumOfReplacements.ToString(); }));
        }

        /// <summary>
        /// Clear destination text.
        /// </summary>
        private void ClearDestinationButton_Click(object sender, EventArgs e)
        {
            DestinationTextBox.Text = string.Empty;
            HighlightText(SourceTextBox, FindTextBox.Text);
        }

        /// <summary>
        /// Highlight when find text has changed.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            HighlightText(SourceTextBox, FindTextBox.Text);
        }


        /// <summary>
        /// Highlight all words that matches.
        /// </summary>
        /// <param name="myRtb">Source text box</param>
        /// <param name="word">Word to match.</param>
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

        /// <summary>
        /// When form is closing. Join threads.
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Reader != null)
                Reader.StopAndJoin();

            if (Writer != null)
                Writer.StopAndJoin();

            if (Modifier != null)
                Modifier.StopAndJoin();
        }

        /// <summary>
        /// Open menu
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SourceTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                HighlightText(SourceTextBox, FindTextBox.Text);
            }
        }
    }
}
