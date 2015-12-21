using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// A circlular buffer to store strings in.
    /// </summary>
    public class BoundedBuffer
    {
        /// <summary>
        /// A state in the buffer.
        /// </summary>
        public enum BufferStatus
        {
            Empty, Checked, New
        }

        /// <summary>
        /// Number of replacements that were done.
        /// </summary>
        public int NumOfReplacements { get; private set; }

        // Buffer status and the actual string buffer.
        private string[] stringBuffer;
        private BufferStatus[] status;

        // ME lock.
        private object bufferLock;

        // Max items
        private int max;

        // Buffer Positions
        private int writePosition;
        private int readPosition;
        private int findPosition;

        // LInes that were modified.
        private int linesModified;

        // Should we ask for every match?
        private bool notify;

        // The replace and find strings.
        private string findString;
        private string replaceString;

        // txtbox for highlighting
        private RichTextBox txtBox;

        /// <summary>
        /// Creates a bounded buffer that holds @elements amount of strings.
        /// </summary>
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

        /// <summary>
        /// Call to modify.
        /// </summary>
        /// <returns>If success.</returns>
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

                // Replace until there is no matches.
                while ((index = replaced.IndexOf(findString, Math.Min(index, currentLine.Length))) != -1)
                {
                    bool shouldReplace = (notify ? (MessageBox.Show("Replace " + findString + " with " + replaceString + "?", "Replace", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes) : true);

                    if (shouldReplace)
                    {
                        replaced = ReplaceAt(replaced, index);
                        NumOfReplacements++;
                    }

                    index += replaceString.Length;
                }
            }

            // Go into CR
            lock (bufferLock)
            {
                linesModified++;
                stringBuffer[findPosition] = replaced;
                status[findPosition] = BufferStatus.Checked;
            }

            findPosition = (findPosition + 1) % max;
            return true;
        }

        /// <summary>
        /// Read data from the buffer.
        /// </summary>
        /// <param name="data">The read data.</param>
        /// <returns>If success.</returns>
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

        /// <summary>
        /// Write data to the buffer.
        /// </summary>
        /// <param name="data">The write data</param>
        /// <returns>If success.</returns>
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

        /// <summary>
        /// Replace at position the replace word.
        /// </summary>
        /// <param name="source">The source text.</param>
        /// <param name="pos">The position to replace</param>
        /// <returns></returns>
        private string ReplaceAt(string source, int pos)
        {
            return source.Substring(0, pos) + replaceString + source.Substring(pos + findString.Length, source.Length - (pos + findString.Length));
        }

    }
}
