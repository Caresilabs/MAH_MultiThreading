using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// A ThreadSafe Buffer.
    /// </summary>
    /// <typeparam name="T">The data to store</typeparam>
    class SyncBuffer<T> : Buffer<T>
    {
        protected Mutex mutex;

        public SyncBuffer()
        {
            this.mutex = new Mutex();
        }

        public override bool GetData(out T data)
        {
            if (!hasData)
            {
                data = default(T);
                return false;
            }

            // Lock object
            mutex.WaitOne();
            data = this.data;
            hasData = false;
            mutex.ReleaseMutex();
            return true;
        }


        public override bool SetData(T data)
        {
            if (hasData)
                return false;

            mutex.WaitOne();
            this.data = data;
            hasData = true;
            mutex.ReleaseMutex();

            return true;
        }
    }
}
