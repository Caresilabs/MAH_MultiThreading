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

        public Storage(ProgressBar progressBar)
        {
            this.ProgressBar = progressBar;
            this.StorageLock = new Semaphore(1, 1);
            this.StorageBuffer = new Queue<FoodItem>();
            this.MaxItems = 100;
        }

        public bool DeliverItem(FoodItem item)
        {
            if (StorageBuffer.Count + 1 >= MaxItems)
            {
                return false;
            }

            StorageLock.WaitOne();
            ProgressBar.InvokeMain(() => { ProgressBar.Value += 1; });
            StorageBuffer.Enqueue(item);
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
            ProgressBar.InvokeMain(() => { ProgressBar.Value -= 1; });
            item = StorageBuffer.Dequeue();
            StorageLock.Release();
            return true;
        }
    }
}
