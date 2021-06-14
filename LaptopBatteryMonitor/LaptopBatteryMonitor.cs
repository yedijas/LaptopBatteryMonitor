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
        #region Vars and Initialization
        private readonly Timer minimizeTimer = new Timer();
        public LaptopBatteryMonitor()
        {
            InitializeComponent();

            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.ExitMenu_Click);
        } 
        #endregion

        #region Main Methods
        /// <summary>
        /// This part will force you to close the annoying message box.
        /// </summary>
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
            if (pw.PowerLineStatus.Equals(PowerLineStatus.Offline) && pw.BatteryLifeRemaining > -1 && (percentage <= 10 || minutesRemain <= 10))
            {
                ShowTheForm();
                MessageBox.Show("Please charge the battery.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            // charged and high battery
            else if (pw.PowerLineStatus.Equals(PowerLineStatus.Online) && (percentage >= 99))
            {
                ShowTheForm();
                MessageBox.Show("Battery full.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            lblPower.Text = minutesRemain.ToString() + " minutes";
            lblPercentage.Text = percentage.ToString() + "%";
        }

        /// <summary>
        /// Enforce this form to show up even above your games.
        /// </summary>
        private void ShowTheForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
        }
        #endregion

        #region Events
        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LaptopBatteryMonitor_Load(object sender, EventArgs e)
        {
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
            CheckBatteryStatus();
            if (this.WindowState == FormWindowState.Normal)
            {
                minimizeTimer.Interval = 10000;
                minimizeTimer.Tick += minimizeTimer_Tick;
                minimizeTimer.Start();
            }
        } 
        #endregion
    }
}
