using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopBatteryMonitor
{
    public partial class LaptopBatteryMonitor : Form
    {
        private Timer minimizeTimer = new Timer();
        public LaptopBatteryMonitor()
        {
            InitializeComponent();
        }

        private void CheckBatteryStatus()
        {
            PowerStatus pw = SystemInformation.PowerStatus;
            float percentage = pw.BatteryLifePercent * 100;
            int minutesRemain = pw.BatteryLifeRemaining / 60;
            switch (pw.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    lblRunOn.Text = "Power outlet";
                    break;
                case PowerLineStatus.Offline:
                    lblRunOn.Text = "Battery";
                    break;
                case PowerLineStatus.Unknown:
                    lblRunOn.Text = "Power ERROR!";
                    break;
            }
            // not charged and low battery
            if (pw.PowerLineStatus.Equals(PowerLineStatus.Offline) && (percentage <= 10 || minutesRemain <= 10))
            {
                this.Show();
                MessageBox.Show("Please charge the battery.");
            }
            // charged and high battery
            else if (pw.PowerLineStatus.Equals(PowerLineStatus.Online) && (percentage >= 98))
            {
                this.Show();
                MessageBox.Show("Battery full.");
            }
            lblPower.Text = minutesRemain.ToString() + " minutes";
            lblPercentage.Text = percentage.ToString();
        }

        private void LaptopBatteryMonitor_Load(object sender, EventArgs e)
        {
            CheckBatteryStatus();
            powerTimer.Enabled = true;
        }

        private void powerTimer_Tick(object sender, EventArgs e)
        {
            CheckBatteryStatus();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void minimizeTimer_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            notifyIcon.Visible = true;
        }

        private void LaptopBatteryMonitor_Shown(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                minimizeTimer.Interval = 5000;
                minimizeTimer.Tick += minimizeTimer_Tick;
                minimizeTimer.Start();
            }
        }
    }
}
