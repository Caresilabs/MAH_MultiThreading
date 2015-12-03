using System;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3
{
    public class Factory : Runnable
    {
        public Thread Thread { get; private set; }

        /// <summary>
        /// The Food this factory can produce.
        /// </summary>
        public FoodItem[] FoodBuffer { get; private set; }

        /// <summary>
        /// The storage that the factory will deliver to.
        /// </summary>
        public Storage Storage { get; private set; }

        /// <summary>
        /// The label that will get updated when the factory changes its state.
        /// </summary>
        public Label StatusLabel { get; private set; }

        public bool IsRunning { get; set; }

        public Factory(Storage storage, Label statusLabel)
        {
            this.Storage = storage;
            this.StatusLabel = statusLabel;
            InitFoodItems();
        }

        /// <summary>
        /// Put the factory to work.
        /// </summary>
        private void Work()
        {
            Random rnd = new Random();

            // Produce item until it's time to go home.
            while (IsRunning)
            {
                // Produce item
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Producing..."; });
                FoodItem producedItem = FoodBuffer[rnd.Next(0, FoodBuffer.Length)];
                Thread.Sleep(800);

                // Deliver to storage
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Delivering..."; });
                while (!Storage.DeliverItem(producedItem) && IsRunning) {
                    // Storage is full, wait a bit then try again.
                    StatusLabel.InvokeMain(() => { StatusLabel.Text = "Full waiting..."; });
                    Thread.Sleep(1000);
                }
                if (!IsRunning)
                    break;

                // Rest before we can produce more.
                Thread.Sleep(300);
            }
        }

        /// <summary>
        /// Start the factory.
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            if (IsRunning || (Thread != null && Thread.IsAlive))
                return false;

            IsRunning = true;

            Thread = new Thread(Work);
            Thread.Start();
            return true;
        }

        /// <summary>
        /// Stop the engines!!
        /// </summary>
        public bool Stop()
        {
            IsRunning = false;
            return true;
        }

        /// <summary>
        /// Stop the engines and wait.
        /// </summary>
        /// <returns></returns>
        public bool StopAndJoin()
        {
            IsRunning = false;
            if (Thread != null && Thread.IsAlive)
                Thread.Join();

            return true;
        }

        /// <summary>
        /// Setup the buffer so the workers know what to produce.
        /// </summary>
        public void InitFoodItems()
        {
            FoodBuffer = new FoodItem[10];
            FoodBuffer[0] = new FoodItem("Milk", 1f, 1.2f);
            FoodBuffer[1] = new FoodItem("Apple", .1f, .08f);
            FoodBuffer[2] = new FoodItem("Pear", .2f, .1f);
            FoodBuffer[3] = new FoodItem("Salad", .5f, 1);
            FoodBuffer[4] = new FoodItem("Sushi", 2, 1.5f);
            FoodBuffer[5] = new FoodItem("Bread", 1.2f, 1f);
            FoodBuffer[6] = new FoodItem("Wine", 1.1f, 1f);
            FoodBuffer[7] = new FoodItem("Hotdogs", .7f, 0.7f);
            FoodBuffer[8] = new FoodItem("Butter", 0.3f, 0.4f);
            FoodBuffer[9] = new FoodItem("Cheese", 1.6f, 0.2f);
        }
    }
}
