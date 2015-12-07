using System.Collections.Generic;

namespace Assignment4
{
    public class Writer : RunnableLoop
    {
        public ICollection<string> TextToWrite { get; private set; }

        public BoundedBuffer Buffer { get; private set; }

        public Writer(BoundedBuffer buffer, ICollection<string> textToWrite)
        {
            this.TextToWrite = textToWrite;
            this.Buffer = buffer;
            base.LoopMethod = WriteLoop;
        }

        public void WriteLoop()
        {

        }
    }
}
