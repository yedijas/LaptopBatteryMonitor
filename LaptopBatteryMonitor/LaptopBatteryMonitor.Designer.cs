
namespace LaptopBatteryMonitor
{
    partial class LaptopBatteryMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopBatteryMonitor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblRunOn = new System.Windows.Forms.Label();
            this.powerTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Run On:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remaining Power:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remaining Percentage:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(137, 39);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(43, 13);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "percent";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(137, 26);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(36, 13);
            this.lblPower.TabIndex = 4;
            this.lblPower.Text = "power";
            // 
            // lblRunOn
            // 
            this.lblRunOn.AutoSize = true;
            this.lblRunOn.Location = new System.Drawing.Point(137, 13);
            this.lblRunOn.Name = "lblRunOn";
            this.lblRunOn.Size = new System.Drawing.Size(34, 13);
            this.lblRunOn.TabIndex = 5;
            this.lblRunOn.Text = "runon";
            // 
            // powerTimer
            // 
            this.powerTimer.Interval = 300000;
            this.powerTimer.Tick += new System.EventHandler(this.powerTimer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "Adit\'s Battery Monitor";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Adit\'s Battery Monitor";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // LaptopBatteryMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 68);
            this.Controls.Add(this.lblRunOn);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LaptopBatteryMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adit\'s Laptop Battery Monitor";
            this.Load += new System.EventHandler(this.LaptopBatteryMonitor_Load);
            this.Shown += new System.EventHandler(this.LaptopBatteryMonitor_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblRunOn;
        private System.Windows.Forms.Timer powerTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

