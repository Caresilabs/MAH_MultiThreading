using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3
{
    public class Storage
    {
        private Semaphore StorageLock { get; set; }

        public Queue<FoodItem> StorageBuffer { get; private set; }

        public int MaxItems { get; private set; }

        public ProgressBar ProgressBar { get; private set; }

        public Label CountLabel { get; private set; }

        public Storage(ProgressBar progressBar, Label countLabel)
        {
            this.ProgressBar = progressBar;
            this.CountLabel = countLabel;
            this.StorageLock = new Semaphore(1, 1);
            this.StorageBuffer = new Queue<FoodItem>();
            this.MaxItems = 50;
        }

        public bool DeliverItem(FoodItem item)
        {
            if (StorageBuffer.Count + 1 >= MaxItems)
            {
                return false;
            }

            StorageLock.WaitOne();
            ProgressBar.InvokeMain(() => { ProgressBar.Value += (int)((1f / MaxItems) * 100); });
            StorageBuffer.Enqueue(item);
            CountLabel.InvokeMain(() => { CountLabel.Text = (StorageBuffer.Count + "/" + MaxItems); });
            StorageLock.Release();
            return true;
        }

        public bool FetchItem(out FoodItem item)
        {
            if (StorageBuffer.Count == 0)
            {
                item = default(FoodItem);
                return false;
            }

            StorageLock.WaitOne();
            ProgressBar.InvokeMain(() => { ProgressBar.Value -= (int)((1f / MaxItems) * 100); });
            item = StorageBuffer.Dequeue();
            CountLabel.InvokeMain(() => { CountLabel.Text = (StorageBuffer.Count + "/" + MaxItems); });
            StorageLock.Release();
            return true;
        }
    }
}
