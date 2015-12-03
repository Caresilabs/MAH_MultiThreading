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

        public Label StatusLabel { get; private set; }

        public Label TruckLimitItemsLabel { get; private set; }

        public Label TruckLimitWeightLabel { get; private set; }

        public Label TruckLimitVolumeLabel { get; private set; }

        public List<FoodItem> TruckStorage { get; private set; }

        public float MaxVolume { get; private set; }

        public float MaxWeight { get; private set; }

        public float MaxItems { get; private set; }

        public bool IsRunning { get; set; }


        public Truck(Storage storage, ListBox deliverList, Label truckStatus, Label truckLimitItems, Label truckLimitWeight, Label truckLimitVolume, float maxVolume, float maxWeight, float maxItems)
        {
            this.DeliverList = deliverList;
            this.TruckStorage = new List<FoodItem>();
            this.Storage = storage;
            this.MaxVolume = maxVolume;
            this.MaxWeight = maxWeight;
            this.MaxItems = maxItems;
            this.StatusLabel = truckStatus;
            this.TruckLimitItemsLabel = truckLimitItems;
            this.TruckLimitVolumeLabel = truckLimitVolume;
            this.TruckLimitWeightLabel = truckLimitWeight;
        }

        /// <summary>
        /// Make the truck ping pong between ICA and the specified storage.
        /// </summary>
        private void Work()
        {
            // Work til sunset.
            while (IsRunning)
            {
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Loading..."; });

                // Keep loading the truck until it is full.
                while (IsRunning)
                {
                    if (IsFull())
                    {
                        StatusLabel.InvokeMain(() => { StatusLabel.Text = "Truck is full!"; });
                        Thread.Sleep(850);
                        break;
                    }

                    FoodItem item;
                    if (Storage.FetchItem(out item))
                    {
                        TruckStorage.Add(item);
                        UpdateLimitLabels();
                    }
                    Thread.Sleep(250);
                }
                if (!IsRunning)
                    break;

                // Deliver all items to ICA
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Delivering..."; });
                Thread.Sleep(1500);
                foreach (var foodItem in TruckStorage)
                {
                    DeliverList.InvokeMain(() => { DeliverList.Items.Add(foodItem); });
                    StatusLabel.InvokeMain(() => { StatusLabel.Text = "Deliver: " + foodItem.Name; });
                    Thread.Sleep(150);
                }

                // Prepare for going to storage again.
                TruckStorage.Clear();
                UpdateLimitLabels();
                StatusLabel.InvokeMain(() => { StatusLabel.Text = "Returning to Storage..."; });
                Thread.Sleep(5000);
            }

            StatusLabel.InvokeMain(() => { StatusLabel.Text = "Waiting..."; });
        }

        /// <summary>
        /// Is the truck full?
        /// </summary>
        /// <returns>Is the truck full?</returns>
        private bool IsFull()
        {
            if (TruckStorage.Sum(x => x.Volume) >= MaxVolume) return true;
            if (TruckStorage.Sum(x => x.Weight) >= MaxWeight) return true;
            if (TruckStorage.Count >= MaxItems) return true;

            return false;
        }

        /// <summary>
        /// Update our display to show the trucks info.
        /// </summary>
        private void UpdateLimitLabels()
        {
            TruckLimitItemsLabel.InvokeMain(() => { TruckLimitItemsLabel.Text = TruckStorage.Count + "/" + MaxItems; });
            TruckLimitWeightLabel.InvokeMain(() => { TruckLimitWeightLabel.Text = TruckStorage.Sum(x => x.Weight) + "/" + MaxWeight; });
            TruckLimitVolumeLabel.InvokeMain(() => { TruckLimitVolumeLabel.Text = TruckStorage.Sum(x => x.Volume) + "/" + MaxVolume; });
        }

        /// <summary>
        /// Start working.
        /// </summary>
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
        /// Stop working.
        /// </summary>
        public bool Stop()
        {
            IsRunning = false;
            return true;
        }

        /// <summary>
        /// Stop working and joing thread.
        /// </summary>
        public bool StopAndJoin()
        {
            IsRunning = false;
            if (Thread != null && Thread.IsAlive)
                Thread.Join();

            return true;
        }
    }
}
