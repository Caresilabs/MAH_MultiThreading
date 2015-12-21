using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// Simple writer class for writing multiple lines into a specific buffer.
    /// </summary>
    public class Writer : RunnableLoop
    {
        /// <summary>
        /// The text to write.
        /// </summary>
        public List<string> TextToWrite { get; private set; }

        /// <summary>
        /// Our buffer.
        /// </summary>
        public BoundedBuffer Buffer { get; private set; }

        /// <summary>
        /// Creates a writer
        /// </summary>
        /// <param name="buffer">The buffer to write to</param>
        /// <param name="textToWrite">The text to write.</param>
        public Writer(BoundedBuffer buffer, List<string> textToWrite)
        {
            this.TextToWrite = textToWrite;
            this.Buffer = buffer;
            base.LoopMethod = WriteLoop;
        }

        /// <summary>
        /// The work loop.
        /// </summary>
        public void WriteLoop()
        {
            while (TextToWrite.Count > 0 && IsRunning)
            {
                string data = TextToWrite[0];
                if (Buffer.WriteData(data))
                {
                    TextToWrite.RemoveAt(0);
                }
            }
        }
    }
}
