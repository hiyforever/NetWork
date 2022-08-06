
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace NetWork
{
    public partial class UserControl1 : UserControl
    {
        private readonly PerformanceCounterCategory pcc = new PerformanceCounterCategory("Network Interface");
        private readonly Dictionary<string, PerformanceCounter>[] devices;
        private readonly Label[] labels;
        private readonly string[] counterNames;
        private readonly int width;

        public UserControl1()
        {
            this.InitializeComponent();
            this.width = this.Width;
            this.labels = new Label[2] { this.label1, this.label2 };
            this.counterNames = new string[2]
            {
                "Bytes Received/sec",
                "Bytes Sent/sec"
            };
            this.devices = new Dictionary<string, PerformanceCounter>[2]
            {
                new Dictionary<string, PerformanceCounter>(),
                new Dictionary<string, PerformanceCounter>()
            };
            this.timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Left > 0)
            {
                this.Left += this.Width - this.width;
            }
            this.Width = this.width;
            int taskBarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            if (taskBarHeight > 0)
            {
                double scale = taskBarHeight / 50.0;
                this.Height = (int)Math.Round(40 * scale);
                this.label1.Height = this.label2.Height = (int)(17 * scale);
                this.Top = (taskBarHeight - this.Height) / 2;
                this.label1.Top = this.Height - this.label1.Height;
            }
            float[] numArray = new float[this.counterNames.Length];
            foreach (string instanceName in this.pcc.GetInstanceNames())
            {
                for (int index = 0; index < this.counterNames.Length; ++index)
                {
                    if (!this.devices[index].ContainsKey(instanceName))
                        this.devices[index][instanceName] = new PerformanceCounter(this.pcc.CategoryName, this.counterNames[index], instanceName);
                    try
                    {
                        numArray[index] += this.devices[index][instanceName].NextValue() / 1024;
                    }
                    catch
                    {
                        this.devices[index][instanceName].Dispose();
                        this.devices[index].Remove(instanceName);
                    }
                }
            }
            string[] strArray = new string[2] { "k/s", "k/s" };
            for (int index = 0; index < numArray.Length; ++index)
            {
                if (numArray[index] >= 999.5)
                {
                    numArray[index] /= 1024;
                    strArray[index] = "m/s";
                }
                this.labels[index].Text = Convert.ToDouble(numArray[index].ToString(numArray[index] < 0.1 ? "0.00" : (numArray[index] < 10 ? "0.0" : "G3"))).ToString() + strArray[index];
            }
        }
    }
}
