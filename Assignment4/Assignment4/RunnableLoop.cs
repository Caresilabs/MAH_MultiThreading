using System;
using System.Threading;

namespace Assignment4
{
    public class RunnableLoop
    {
        public Thread Thread { get;  private set; }

        public ThreadStart LoopMethod { get; protected set; }

        public bool IsRunning { get; protected set; }

        public void Start()
        {
            if (LoopMethod == null)
                throw new Exception("No delegate was specified! Please set @LoopMethod before calling @Start");

            if ((Thread != null && Thread.IsAlive) || IsRunning)
                return;

            IsRunning = true;
            Thread = new Thread(Start);
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public void StopAndJoin()
        {
            IsRunning = false;

            if (Thread != null && Thread.IsAlive)
                Thread.Join();
        }
    }
}
