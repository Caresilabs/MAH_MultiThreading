namespace Assignment5
{
    class Car
    {
        /// <summary>
        /// Timer to keep track of our time
        /// </summary>
        private int timer;

        /// <summary>
        /// Create a Car
        /// </summary>
        /// <param name="timer">Time to park</param>
        public Car(int timer)
        {
            this.timer = timer;
        }

        /// <summary>
        /// Tick in simulation
        /// </summary>
        /// <returns>If parking time is over</returns>
        public bool Tick()
        {
            if (timer-- <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
