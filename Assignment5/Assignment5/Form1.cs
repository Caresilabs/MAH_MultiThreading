using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// queues into the car park
        /// </summary>
        private CarQueue[] queues;

        /// <summary>
        /// Our car park house
        /// </summary>
        private Carpark carpark;

        public Form1()
        {
            InitializeComponent();
        }

        private void startstopbutton_Click(object sender, EventArgs e)
        {
            if (startstopbutton.Text == "Start")
            {
                startstopbutton.Text = "Stop";
                Start();
            }
            else
            {
                startstopbutton.Text = "Start";
                Stop();
            }
        }

        /// <summary>
        /// Start the simulation
        /// </summary>
        private void Start()
        {
            queues = new CarQueue[4];
            queues[0] = new CarQueue("West", westProgress);
            queues[1] = new CarQueue("East", eastProgress);
            queues[2] = new CarQueue("North", northProgress);
            queues[3] = new CarQueue("South", southProgress);

            carpark = new Carpark(ref queues, carParkProgress, 500);

            Task.Factory.StartNew(carpark.Run);
            Task.Factory.StartNew(queues[0].Run);
            Task.Factory.StartNew(queues[1].Run);
            Task.Factory.StartNew(queues[2].Run);
            Task.Factory.StartNew(queues[3].Run);
        }

        // Stop the simulation
        private void Stop()
        {
            carpark.Operational = false;
            queues[0].Operational = false;
            queues[1].Operational = false;
            queues[2].Operational = false;
            queues[3].Operational = false;
        }
    }
}
