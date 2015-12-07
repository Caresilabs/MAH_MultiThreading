using System.Collections.Generic;

namespace Assignment4
{
    public class Reader : RunnableLoop
    {
        public BoundedBuffer Buffer { get; private set; }

        public int Count { get; private set; }

        public ICollection<string> StringList { get; private set; }

        public Reader(BoundedBuffer buffer, int numOfStrings)
        {
            this.Buffer = buffer;
            this.Count = numOfStrings;
            base.LoopMethod = ReadLoop;
        }

        public void ReadLoop()
        {

        }
    }
}
