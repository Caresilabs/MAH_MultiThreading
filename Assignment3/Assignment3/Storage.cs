using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3
{
    /// <summary>
    /// Storage class for storing FoodItems
    /// </summary>
    public class Storage
    {
        private Semaphore StorageLock { get; set; }

        private Mutex StorageMutex { get; set; }

        public Queue<FoodItem> StorageBuffer { get; private set; }

        public ProgressBar ProgressBar { get; private set; }

        public Label CountLabel { get; private set; }

        public int MaxItems { get; private set; }

        public Storage(ProgressBar progressBar, Label countLabel)
        {
            this.MaxItems = 50;
            this.ProgressBar = progressBar;
            this.CountLabel = countLabel;
            this.StorageLock = new Semaphore(2, 2);
            this.StorageMutex = new Mutex();
            this.StorageBuffer = new Queue<FoodItem>(MaxItems);
        }

        /// <summary>
        /// Store an item in the storage.
        /// </summary>
        /// <param name="item">Item to store</param>
        /// <returns>if the storage has room for it</returns>
        public bool DeliverItem(FoodItem item)
        {
            if (StorageBuffer.Count + 1 > MaxItems)
            {
                return false;
            }

            StorageLock.WaitOne();
            StorageMutex.WaitOne();
            ProgressBar.InvokeMain(() => { ProgressBar.Value += (int)((1f / MaxItems) * 100); });
            StorageBuffer.Enqueue(item);
            CountLabel.InvokeMain(() => { CountLabel.Text = (StorageBuffer.Count + "/" + MaxItems); });
            StorageMutex.ReleaseMutex();
            StorageLock.Release();
            return true;
        }

        /// <summary>
        /// Get the first available item in the storage.
        /// </summary>
        /// <param name="item">The first available item</param>
        /// <returns>If the storage found an item</returns>
        public bool FetchItem(out FoodItem item)
        {
            if (StorageBuffer.Count == 0)
            {
                item = default(FoodItem);
                return false;
            }

            StorageLock.WaitOne();
            StorageMutex.WaitOne();
            ProgressBar.InvokeMain(() => { ProgressBar.Value -= (int)((1f / MaxItems) * 100); });
            item = StorageBuffer.Dequeue();
            CountLabel.InvokeMain(() => { CountLabel.Text = (StorageBuffer.Count + "/" + MaxItems); });
            StorageMutex.ReleaseMutex();
            StorageLock.Release();
            return true;
        }
    }
}
