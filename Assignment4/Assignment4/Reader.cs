using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment4
{
    public class Reader : RunnableLoop
    {
        public BoundedBuffer Buffer { get; private set; }

        public int Count { get; private set; }

        public List<string> StringList { get; private set; }

        public RichTextBox DestinationBox { get; private set; }

        public Label NumOfReplacementsLabel { get; set; }

        public delegate void OnReadDone();

        private OnReadDone onDone;

        public Reader(OnReadDone onDone, BoundedBuffer buffer, RichTextBox destinationBox, Label numOfReplacementsLabel, int numOfStrings)
        {
            this.onDone = onDone;
            this.DestinationBox = destinationBox;
            this.NumOfReplacementsLabel = numOfReplacementsLabel;
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
                while (!Buffer.ReadData(out data)) ;

                StringList.Add(data);
            }

            onDone();
        }
    }
}
