using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment4
{
    public class BoundedBuffer
    {
        public enum BufferStatus
        {
            Empty, Checked, New
        }

        public int NumOfReplacements { get; private set; }

        private string[] stringBuffer;
        private BufferStatus[] status;
        private object bufferLock;

        private int max;
        private int writePosition;
        private int readPosition;
        private int findPosition;
        private int linesModified;

        private bool notify;

        private string findString;
        private string replaceString;

        private RichTextBox txtBox;

        public BoundedBuffer(int elements, RichTextBox txtBox, bool notify, string find, string replace)
        {
            this.max = elements;
            this.notify = notify;
            this.txtBox = txtBox;
            this.findString = find;
            this.replaceString = replace;

            this.stringBuffer = new string[max];
            this.status = new BufferStatus[max];
            this.bufferLock = new object();
        }

        public bool Modify()
        {
            if (status[findPosition] != BufferStatus.New)
            {
                return false;
            }

            string replaced = stringBuffer[findPosition];
            if (!string.IsNullOrEmpty(findString))
            {
                int index = 0;
                string currentLine = stringBuffer[findPosition];
                while ((index = replaced.IndexOf(findString, Math.Min(index, currentLine.Length))) != -1)
                {
                   // int startIndex = 0;
                    //txtBox.BeginInvoke(new MethodInvoker(() =>
                    //{
                    //    startIndex = txtBox.GetFirstCharIndexFromLine(linesModified) + index;
                    //}), null);


                    //txtBox.BeginInvoke(new MethodInvoker(() =>
                    //{
                    //    txtBox.Select(startIndex, findString.Length);
                    //    txtBox.SelectionColor = Color.White;
                    //    txtBox.SelectionBackColor = Color.Blue;
                    //}), null);

                    bool shouldReplace = (notify ? (MessageBox.Show("Replace " + findString + " with " + replaceString + "?", "Replace", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes) : true);

                    if (shouldReplace)
                    {
                        replaced = ReplaceAt(replaced, index);
                        NumOfReplacements++;
                    }

                    //txtBox.BeginInvoke(new MethodInvoker(() =>
                    //{
                    //    txtBox.Select(startIndex, findString.Length);
                    //    txtBox.SelectionColor = Color.Black;
                    //    txtBox.SelectionBackColor = Color.Green;
                    //}), null);

                    index += replaceString.Length ;
                }
            }

            lock (bufferLock)
            {
                linesModified++;
                stringBuffer[findPosition] = replaced;
                status[findPosition] = BufferStatus.Checked;
            }

            findPosition = (findPosition + 1) % max;
            return true;
        }

        public bool ReadData(out string data)
        {
            if (status[readPosition] != BufferStatus.Checked)
            {
                data = default(string);
                return false;
            }

            lock (bufferLock)
            {
                data = stringBuffer[readPosition];
                status[readPosition] = BufferStatus.Empty;
            }

            readPosition = (readPosition + 1) % max;
            return true;
        }

        public bool WriteData(string data)
        {
            if (status[writePosition] != BufferStatus.Empty)
                return false;

            lock (bufferLock)
            {
                stringBuffer[writePosition] = data;
                status[writePosition] = BufferStatus.New;
            }

            writePosition = (writePosition + 1) % max;
            return true;
        }

        private string ReplaceAt(string source, int pos)
        {
            return source.Substring(0, pos) + replaceString + source.Substring(pos + findString.Length, source.Length - (pos + findString.Length));
        }

    }
}
