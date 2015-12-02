using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3
{
    public class Truck : Runnable
    {
        public Thread Thread { get; private set; }

        public Storage Storage { get; private set; }

        public ListBox DeliverList { get; private set; }

        public Label StatusLabel { get; set; }

        public List<FoodItem> TruckStorage { get; private set; }

        public float MaxVolume { get; private set; }

        public float MaxWeight { get; private set; }

        public float MaxItems { get; private set; }

        public bool IsRunning { get; set; }


        public Truck(Storage storage, ListBox deliverList, Label truckStatus, float maxVolume, float maxWeight, float maxItems)
        {
            this.DeliverList = deliverList;
            this.StatusLabel = truckStatus;
            this.TruckStorage = new List<FoodItem>();
            this.Storage = storage;
            this.MaxVolume = maxVolume;
            this.MaxWeight = maxWeight;
            this.MaxItems = maxItems;
        }

        public void Work()
        {
            while (IsRunning)
            {
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Loading..."; });

                while (!IsFull() && IsRunning)
                {
                    FoodItem item;
                    if (Storage.FetchItem(out item))
                    {
                        TruckStorage.Add(item);
                    }
                    Thread.Sleep(250);
                }

                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Delivering..."; });
                Thread.Sleep(800);
                foreach (var foodItem in TruckStorage)
                {
                    DeliverList.InvokeMain(() => { DeliverList.Items.Add(foodItem); });
                    StatusLabel.InvokeMain(() => { StatusLabel.Text = "Deliver: " + foodItem.Name; });
                    Thread.Sleep(150);
                }

                TruckStorage.Clear();
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Returning to Storage..."; });
                Thread.Sleep(5000);
            }

            StatusLabel.InvokeMain(() => { StatusLabel.Text = "Waiting..."; });
        }

        private bool IsFull()
        {
            if (TruckStorage.Sum(x => x.Volume) >= MaxVolume) return true;
            if (TruckStorage.Sum(x => x.Weight) >= MaxWeight) return true;
            if (TruckStorage.Count >= MaxItems) return true;

            return false;
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
