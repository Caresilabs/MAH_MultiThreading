using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public BoundedBuffer Buffer { get; private set; }

        public Modifier Modifier { get; private set; }

        public Writer Writer { get; private set; }

        public Reader Reader { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.Buffer = new BoundedBuffer();
        }

    }
}
