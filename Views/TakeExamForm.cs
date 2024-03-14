using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSys.Views
{
    public partial class TakeExamForm : Form
    {
        private System.Windows.Forms.Timer timer;
        private TimeSpan remainingTime;
        public TakeExamForm()
        {
            InitializeComponent();
            InitializeTimer();
        }
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += ExamTimer_Tick;
            remainingTime = TimeSpan.FromMinutes(10); // Set initial time to 10 minutes
            UpdateTimerLabel();
        }
       
        private void UpdateTimerLabel()
        {
            // Display the elapsed time in HH:mm:ss format
            lblTimer.Text = remainingTime.ToString(@"mm\:ss");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
            }
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimerLabel();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time's up!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
