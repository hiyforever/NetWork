using System;
using System.Drawing;
using System.Windows.Forms;

namespace NetWork
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Timer timer1;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.label1 = new Label();
            this.label2 = new Label();
            this.timer1 = new Timer(this.components);
            this.SuspendLayout();
            int taskBarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            this.label1.Location = new Point(0, taskBarHeight / 2);
            this.label1.Name = "label1";
            this.label1.Size = new Size(75, taskBarHeight / 2);
            this.label1.TabIndex = 0;
            this.label1.Text = "0k/s";
            this.label1.TextAlign = ContentAlignment.MiddleRight;
            this.label2.Location = new Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(75, taskBarHeight / 2);
            this.label2.TabIndex = 1;
            this.label2.Text = "0k/s";
            this.label2.TextAlign = ContentAlignment.MiddleRight;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.Timer1_Tick);
            this.AutoScaleDimensions = new SizeF(9f, 15f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = Color.Black;
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)134);
            this.Name = "UserControl1";
            this.Size = new Size(75, taskBarHeight);
            this.ResumeLayout(false);
        }

        #endregion
    }
}