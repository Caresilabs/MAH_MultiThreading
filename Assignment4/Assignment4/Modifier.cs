using System;

namespace Assignment4
{
    /// <summary>
    /// Modifies one line at a time for our buffer.
    /// </summary>
    public class Modifier : RunnableLoop
    {
        /// <summary>
        /// The buffer to modify.
        /// </summary>
        public BoundedBuffer Buffer { get; private set; }

        /// <summary>
        /// Number of strings.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Create a modifier.
        /// </summary>
        /// <param name="buffer">The buffer to modify.</param>
        /// <param name="textLength"> Number of strings.</param>
        public Modifier(BoundedBuffer buffer, int textLength)
        {
            this.Buffer = buffer;
            this.Count = textLength;
            base.LoopMethod = ModifierLoop;
        }

        /// <summary>
        ///  The worker loop.
        /// </summary>
        public void ModifierLoop()
        {
            for (int i = 0; i < Count && IsRunning; i++)
            {
                while (!Buffer.Modify()) ;
            }
        }
    }
}
