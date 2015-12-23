using System;
using System.Threading;
using System.Windows.Forms;

namespace Assignment5
{
    class Carpark
    {
        /// <summary>
        /// Status enum.
        /// </summary>
        public enum Status { EMPTY, FILLED }

        /// <summary>
        /// Is the carpark operational
        /// </summary>
        public bool Operational { get; set; }

        /// <summary>
        /// Count of cars in the house
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Random object
        /// </summary>
        private Random Random { get; set; }

        /// <summary>
        /// Parking buffer
        /// </summary>
        private Car[] parkedCars;

        /// <summary>
        /// 4 queues.
        /// </summary>
        private CarQueue[] queues;

        /// <summary>
        /// Status buffer
        /// </summary>
        private Status[] status;

        /// <summary>
        /// Progressbar to update
        /// </summary>
        private ProgressBar progressBar;

        /// <summary>
        /// Creates a carpark
        /// </summary>
        public Carpark(ref CarQueue[] queues, ProgressBar progressBar, int slots)
        {
            this.queues = queues;
            this.progressBar = progressBar;
            this.Random = new Random();
            this.status = new Status[slots];
            this.parkedCars = new Car[slots];
        }

        /// <summary>
        /// Run the carpark simulation.
        /// </summary>
        public void Run()
        {
            this.Operational = true;

            while (Operational)
            {
                int next = GetAvailableSpace();
                if (next != -1)
                {
                    int queue = Random.Next(0, 4);
                    Car car = queues[queue].Park();
                    if (car != null)
                    {
                        status[next] = Status.FILLED;
                        parkedCars[next] = car;
                        Count++;
                        progressBar.Invoke(new MethodInvoker(() => { progressBar.Value = (int)(100 * ((float)Count / parkedCars.Length)); }));
                    }
                }
                CheckCars();
                Thread.Sleep(20);
            }
        }

        /// <summary>
        /// Update all cars.
        /// </summary>
        private void CheckCars()
        {
            for (int i = 0; i < parkedCars.Length; i++)
            {
                if (status[i] == Status.FILLED)
                {
                    if (parkedCars[i].Tick())
                    {
                        status[i] = Status.EMPTY;
                        parkedCars[i] = null;
                        Count--;
                        progressBar.Invoke(new MethodInvoker(() => { progressBar.Value = (int)(100 * ((float)Count / parkedCars.Length)); }));
                    }
                }
            }
        }

        /// <summary>
        /// Get next availabe car space index.
        /// </summary>
        /// <returns>index of free space, -1 for none</returns>
        private int GetAvailableSpace()
        {
            for (int i = 0; i < parkedCars.Length; i++)
            {
                if (status[i] == Status.EMPTY)
                    return i;
            }
            return -1;
        }
    }
}
