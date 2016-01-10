using System.Collections.Generic;

namespace Assignment4
{
    /// <summary>
    /// Simple reader class that reads lines from a buffer.
    /// </summary>
    public class Reader : RunnableLoop
    {
        /// <summary>
        /// The buffer to read from.
        /// </summary>
        public BoundedBuffer Buffer { get; private set; }

        /// <summary>
        /// Number of strings.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Our final read list.
        /// </summary>
        public List<string> StringList { get; private set; }

        /// <summary>
        /// Function to call when the reader is finished.
        /// </summary>
        public delegate void OnReadDone();
        private OnReadDone onDone;

        public Reader(OnReadDone onDone, BoundedBuffer buffer, int numOfStrings)
        {
            this.onDone = onDone;
            this.StringList = new List<string>(Count);
            this.Buffer = buffer;
            this.Count = numOfStrings;
            base.LoopMethod = ReadLoop;
        }

        public void ReadLoop()
        {
            for (int i = 0; i < Count && IsRunning; i++)
            {
                string data;
                Buffer.ReadData(out data);
                StringList.Add(data);
            }

            onDone();
        }
    }
}
