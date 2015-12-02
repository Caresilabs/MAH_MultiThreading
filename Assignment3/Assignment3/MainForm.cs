using System;
using System.Threading;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        public Truck Truck { get; private set; }
        public Storage Storage { get; private set; }
        public Factory FactoryA { get; private set; }
        public Factory FactoryB { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            this.Storage = new Storage(StorageProgress, StorageProgressLabel);

            this.FactoryA = new Factory(Storage, FactoryAStatus);
            this.FactoryB = new Factory(Storage, FactoryBStatus);

            this.Truck = new Truck(Storage, DeliverList, TruckStatusLabel, 12, 27, 15);
            TruckLimitVolume.Text = "12";
            TruckLimitWeight.Text = "27";
            TruckLimitItems.Text = "15";

        }

        private void StartFactoryA_Click(object sender, EventArgs e)
        {
            if (FactoryA.Start())
            {
                StopFactoryA.Enabled = true;
                StartFactoryA.Enabled = false;
            }
        }

        private void StopFactoryA_Click(object sender, EventArgs e)
        {
            if (FactoryA.Stop())
            {
                StopFactoryA.Enabled = false;
                StartFactoryA.Enabled = true;
            }
        }

        private void StartFactoryB_Click(object sender, EventArgs e)
        {
            if (FactoryB.Start())
            {
                StopFactoryB.Enabled = true;
                StartFactoryB.Enabled = false;
            }
        }

        private void StopFactoryB_Click(object sender, EventArgs e)
        {
            if (FactoryB.Stop())
            {
                StopFactoryB.Enabled = false;
                StartFactoryB.Enabled = true;
            }
        }

        private void StartDeliver_Click(object sender, EventArgs e)
        {
            if (Truck.Start())
            {
                StartDeliver.Enabled = false;
                StopDeliver.Enabled = true;
            }
        }

        private void StopDeliver_Click(object sender, EventArgs e)
        {
            if (Truck.Stop())
            {
                StartDeliver.Enabled = true;
                StopDeliver.Enabled = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FactoryA.StopAndJoin();
            FactoryB.StopAndJoin();
            Truck.StopAndJoin();
        }
    }
}
