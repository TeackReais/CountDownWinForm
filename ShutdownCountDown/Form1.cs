using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutdownCountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetAndSuspend.Text = "Reset";
            ResetAndSuspend.Enabled = false;
            Confirm.Text = "Confirm";
            Number.Maximum = 3600 * 24 * 24;
            Number.Minimum = 0;
        }

        private void CountDownShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Number_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Confirm.Text == "Confirm")
            {
                bool RestartOrShutdown;
                if (Restart.CheckState == CheckState.Checked)
                {
                    RestartOrShutdown = true;
                }
                else if (Restart.CheckState == CheckState.Unchecked && Shutdown.CheckState == CheckState.Unchecked) 
                {
                    MessageBox.Show("Please choose Restart or Shutdown.", "Worning");
                    return;
                }
                else
                {
                    RestartOrShutdown = false;
                }
                Shutdown.Enabled = false;
                Restart.Enabled = false;
                Confirm.Enabled = false;
                Confirm.Text = "Continue";
                ResetAndSuspend.Text = "Suspend";
                ResetAndSuspend.Enabled = true;
                CountDownShow.Items.Clear();
                int AllTime = Convert.ToInt32(Number.Value);
                if (AllTime == 0)
                {
                    Program.Shutdown(RestartOrShutdown);
                }
                CountDownTimer.Interval = AllTime * 1000 / 100;
                output("关机或重启时间百分比倒计时开始！");
                ProgressBarCountDown.Value = 0;
                ProgressBarCountDown.Minimum = 0;
                ProgressBarCountDown.Maximum = 100;
                CountDownTimer.Enabled = true;
            }
            else
            {
                CountDownTimer.Enabled = true;
                ResetAndSuspend.Text = "Suspend";
                Confirm.Enabled = false;
                ResetAndSuspend.Enabled = true;
            }
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            bool RestartOrShutdown;
            if (Restart.CheckState == CheckState.Checked)
            {
                RestartOrShutdown = true;
            }
            else
            {
                RestartOrShutdown = false;
            }
            if (ProgressBarCountDown.Value < ProgressBarCountDown.Maximum)
            {
                ProgressBarCountDown.Value++;
                output("百分比倒计时   [" + ProgressBarCountDown.Value.ToString() + "/" + ProgressBarCountDown.Maximum + "]....");
            }
            else
            {
                output("时间到");
                CountDownTimer.Enabled = false;
                Program.Shutdown(RestartOrShutdown);
                return;
                ResetAndSuspend.Text = "Reset";
                Confirm.Text = "Confirm";
            }
        }
        public void output(string log)
        {
            CountDownShow.Items.Add(DateTime.Now.ToString("HH:mm:ss    " + log + "\r\n"));
        }

        private void ProgressBarCountDown_Click(object sender, EventArgs e)
        {

        }

        private void ResetAndSuspend_Click(object sender, EventArgs e)
        {
            if (ResetAndSuspend.Text == "Suspend")
            {
                CountDownTimer.Enabled = false;
                ResetAndSuspend.Text = "Reset";
                Confirm.Enabled = true;
            }
            else
            {
                ProgressBarCountDown.Value = 0;
                ResetAndSuspend.Enabled = false;
                Confirm.Enabled = true;
                CountDownShow.Items.Clear();
                Shutdown.Enabled = true;
                Restart.Enabled = true;
                Confirm.Text = "Confirm";
            }
        }

        private void Shutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (Restart.CheckState == CheckState.Checked)
            {
                Shutdown.CheckState = CheckState.Unchecked;
//                MessageBox.Show("You can't choose both Shutdown and Restart", "Worning");
                return;
            }
        }

        private void Restart_CheckedChanged(object sender, EventArgs e)
        {
            if (Shutdown.CheckState == CheckState.Checked)
            {
                Restart.CheckState = CheckState.Unchecked;
//                MessageBox.Show("You can't choose both Shutdown and Restart", "Worning");
                return;
            }
        }
    }
}
