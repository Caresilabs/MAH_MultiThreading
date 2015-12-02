using System;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3
{
    public class Factory : Runnable
    {
        public Thread Thread { get; private set; }

        public FoodItem[] FoodBuffer { get; private set; }

        public Storage Storage { get; private set; }

        public Label StatusLabel { get; private set; }

        public bool IsRunning { get; set; }

        public Factory(Storage storage, Label statusLabel)
        {
            this.Storage = storage;
            this.StatusLabel = statusLabel;
            InitFoodItems();
        }

        public void Work()
        {
            Random rnd = new Random();

            while (IsRunning)
            {
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Producing..."; });
                Thread.Sleep(800);

                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Delivering..."; });
                while (!Storage.DeliverItem(FoodBuffer[rnd.Next(0, FoodBuffer.Length)]) && IsRunning) {
                    StatusLabel.InvokeMain(() => { StatusLabel.Text = "Full waiting..."; });
                    Thread.Sleep(1000);
                }
                Thread.Sleep(300);
            }
        }

        public void StopWorking()
        {
            IsRunning = false;
        }

        public void InitFoodItems()
        {
            FoodBuffer = new FoodItem[10];
            FoodBuffer[0] = new FoodItem("Milk", 1, 1);
            FoodBuffer[1] = new FoodItem("Apple", 1, 1);
            FoodBuffer[2] = new FoodItem("Pear", 1, 1);
            FoodBuffer[3] = new FoodItem("Salad", 1, 1);
            FoodBuffer[4] = new FoodItem("Sushi", 1, 1);
            FoodBuffer[5] = new FoodItem("Bread", 1, 1);
            FoodBuffer[6] = new FoodItem("Wine", 1, 1);
            FoodBuffer[7] = new FoodItem("Hotdogs", 1, 1);
            FoodBuffer[8] = new FoodItem("Butter", 1, 1);
            FoodBuffer[9] = new FoodItem("Cheese", 1.6f, 0.2f);
        }

        public bool Start()
        {
            if (IsRunning || (Thread != null && Thread.IsAlive))
                return false;

            IsRunning = true;

            Thread = new Thread(Work);
            Thread.Start();
            return true;
        }

        public bool Stop()
        {
            IsRunning = false;
            return true;
        }


        public bool StopAndJoin()
        {
            IsRunning = false;
            if (Thread != null && Thread.IsAlive)
                Thread.Join();

            return true;
        }
    }
}
