using System.Collections.Generic;

namespace Assignment4
{
    public class Writer : RunnableLoop
    {
        public List<string> TextToWrite { get; private set; }

        public BoundedBuffer Buffer { get; private set; }

        public Writer(BoundedBuffer buffer, List<string> textToWrite)
        {
            this.TextToWrite = textToWrite;
            this.Buffer = buffer;
            base.LoopMethod = WriteLoop;
        }

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
