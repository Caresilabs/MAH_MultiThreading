using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Assignment5
{
    class CarQueue
    {
        /// <summary>
        /// The car queue
        /// </summary>
        private Queue<Car> queue;

        /// <summary>
        /// Number of cars queued
        /// </summary>
        public int Count { get { return queue.Count; } }

        /// <summary>
        /// Name of the queue
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Is the queue operational?
        /// </summary>
        public bool Operational { get; set; }

        /// <summary>
        /// Our lock object
        /// </summary>
        private object LockObject { get; set; }

        /// <summary>
        /// Random object
        /// </summary>
        private Random Random { get; set; }

        /// <summary>
        /// progressbar to update
        /// </summary>
        private ProgressBar progressBar;

        /// <summary>
        /// Create a car queue
        /// </summary>
        /// <param name="name">The name of the queue</param>
        /// <param name="progressBar">progressbar to update</param>
        public CarQueue(string name, ProgressBar progressBar)
        {
            this.Name = name;
            this.progressBar = progressBar;
            this.queue = new Queue<Car>(50);
            this.Random = new Random();
            this.LockObject = new object();
        }

        /// <summary>
        /// Run parking queue simulation
        /// </summary>
        public void Run()
        {
            queue.Clear();
            Operational = true;

            while (Operational)
            {
                // Lock for threadsafity
                lock (LockObject)
                {
                    if (Count < 50)
                    {
                        queue.Enqueue(new Car(Random.Next(600, 2000)));
                        progressBar.Invoke(new MethodInvoker(() => { progressBar.Value = (int)(100 * ((float)Count / 50)); }));
                    }
                }
                Thread.Sleep(Random.Next(100, 400));
            }
        }

        /// <summary>
        /// Take a car from the queue.
        /// </summary>
        /// <returns>Car, may be null</returns>
        public Car Park()
        {
            // Lock for threadsafity
            lock (LockObject)
            {
                if (Count > 0)
                {
                    Car car = queue.Dequeue();
                    progressBar.Invoke(new MethodInvoker(() => { progressBar.Value = (int)(100 * ((float)Count / 50)); }));
                    return car;
                }
                return null;
            }
        }
    }
}
