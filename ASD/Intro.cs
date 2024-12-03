using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASD
{
    public partial class Intro : Form
    {

        Timer timer;

        public Intro()
        {
            InitializeComponent();

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 3000;  // Timeout interval in milliseconds (e.g., 5000ms = 5 seconds)
            timer.Tick += Timer_Tick;  // Attach the Tick event handler
            timer.Start();  // Start the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();  // Stop the timer to avoid multiple triggers

            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
