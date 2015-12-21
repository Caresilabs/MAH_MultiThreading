using System;
using System.Threading;

namespace Assignment4
{
    /// <summary>
    /// Helper base class for managing a working thread.
    /// </summary>
    public abstract class RunnableLoop
    {
        /// <summary>
        /// The thread that it uses.
        /// </summary>
        public Thread Thread { get;  private set; }

        /// <summary>
        /// The Work function to start.
        /// </summary>
        public ThreadStart LoopMethod { get; protected set; }

        /// <summary>
        /// Is the object in running state
        /// </summary>
        public bool IsRunning { get; protected set; }

        /// <summary>
        /// Start working
        /// </summary>
        public void Start()
        {
            if (LoopMethod == null)
                throw new Exception("No delegate was specified! Please set @LoopMethod before calling @Start");

            if ((Thread != null && Thread.IsAlive) || IsRunning)
                return;

            IsRunning = true;
            Thread = new Thread(LoopMethod);
            Thread.Start();
        }

        /// <summary>
        /// Stop Working
        /// </summary>
        public void Stop()
        {
            IsRunning = false;
        }

        /// <summary>
        /// Stop working and join the thread.
        /// </summary>
        public void StopAndJoin()
        {
            IsRunning = false;

            if (Thread != null && Thread.IsAlive)
                Thread.Join();
        }
    }
}
