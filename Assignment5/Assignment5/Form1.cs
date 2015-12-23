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

        /// <summary>
        /// Tasks array
        /// </summary>
        private Task[] tasks;

        public Form1()
        {
            InitializeComponent();
            tasks = new Task[5];
        }

        private void startstopbutton_Click(object sender, EventArgs e)
        {
            if (startstopbutton.Text == "Start")
            {
                if (tasks[0] != null)
                    return;

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

            tasks[0] = Task.Factory.StartNew(carpark.Run);
            tasks[1] = Task.Factory.StartNew(queues[0].Run);
            tasks[2] = Task.Factory.StartNew(queues[1].Run);
            tasks[3] = Task.Factory.StartNew(queues[2].Run);
            tasks[4] = Task.Factory.StartNew(queues[3].Run);
        }

        // Stop the simulation
        private void Stop()
        {
            carpark.Operational = false;
            queues[0].Operational = false;
            queues[1].Operational = false;
            queues[2].Operational = false;
            queues[3].Operational = false;

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].Wait();
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = null;
            }
        }
    }
}
