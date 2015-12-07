using System;

namespace Assignment4
{
    public class Modifier : RunnableLoop
    {
        public BoundedBuffer Buffer { get; private set; }

        public int Count { get; private set; }

        public Modifier(BoundedBuffer buffer, int textLength) 
        {
            this.Buffer = buffer;
            this.Count = textLength;
            base.LoopMethod = ModifierLoop;
        }

        public void ModifierLoop()
        {
            for (int i = 0; i < Count; i++)
            {
                try
                {
                    Buffer.Modify();
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}
