namespace ShutdownCountDown
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Confirm = new System.Windows.Forms.Button();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarCountDown = new System.Windows.Forms.ProgressBar();
            this.CountDownShow = new System.Windows.Forms.ListBox();
            this.CountDownTime = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.NumericUpDown();
            this.TimeFormTo = new System.Windows.Forms.Label();
            this.ResetAndSuspend = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.CheckBox();
            this.Shutdown = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(339, 245);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "(Confirm)(Continue)";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Tick += new System.EventHandler(this.CountDownTimer_Tick);
            // 
            // ProgressBarCountDown
            // 
            this.ProgressBarCountDown.Location = new System.Drawing.Point(12, 43);
            this.ProgressBarCountDown.Name = "ProgressBarCountDown";
            this.ProgressBarCountDown.Size = new System.Drawing.Size(410, 23);
            this.ProgressBarCountDown.TabIndex = 2;
            this.ProgressBarCountDown.Click += new System.EventHandler(this.ProgressBarCountDown_Click);
            // 
            // CountDownShow
            // 
            this.CountDownShow.FormattingEnabled = true;
            this.CountDownShow.ItemHeight = 12;
            this.CountDownShow.Location = new System.Drawing.Point(12, 95);
            this.CountDownShow.Name = "CountDownShow";
            this.CountDownShow.Size = new System.Drawing.Size(304, 304);
            this.CountDownShow.TabIndex = 3;
            this.CountDownShow.SelectedIndexChanged += new System.EventHandler(this.CountDownShow_SelectedIndexChanged);
            // 
            // CountDownTime
            // 
            this.CountDownTime.AutoSize = true;
            this.CountDownTime.Location = new System.Drawing.Point(339, 95);
            this.CountDownTime.Name = "CountDownTime";
            this.CountDownTime.Size = new System.Drawing.Size(83, 12);
            this.CountDownTime.TabIndex = 4;
            this.CountDownTime.Text = "CountDownTime";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(339, 195);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(81, 21);
            this.Number.TabIndex = 5;
            this.Number.ValueChanged += new System.EventHandler(this.Number_ValueChanged);
            // 
            // TimeFormTo
            // 
            this.TimeFormTo.AutoSize = true;
            this.TimeFormTo.Location = new System.Drawing.Point(339, 145);
            this.TimeFormTo.Name = "TimeFormTo";
            this.TimeFormTo.Size = new System.Drawing.Size(95, 12);
            this.TimeFormTo.TabIndex = 6;
            this.TimeFormTo.Text = "Time(0-2073600)";
            // 
            // ResetAndSuspend
            // 
            this.ResetAndSuspend.Location = new System.Drawing.Point(339, 295);
            this.ResetAndSuspend.Name = "ResetAndSuspend";
            this.ResetAndSuspend.Size = new System.Drawing.Size(75, 23);
            this.ResetAndSuspend.TabIndex = 7;
            this.ResetAndSuspend.Text = "(Reset)(Suspend)";
            this.ResetAndSuspend.UseVisualStyleBackColor = true;
            this.ResetAndSuspend.Click += new System.EventHandler(this.ResetAndSuspend_Click);
            // 
            // Restart
            // 
            this.Restart.AutoSize = true;
            this.Restart.Location = new System.Drawing.Point(339, 383);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(66, 16);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.CheckedChanged += new System.EventHandler(this.Restart_CheckedChanged);
            // 
            // Shutdown
            // 
            this.Shutdown.AutoSize = true;
            this.Shutdown.Location = new System.Drawing.Point(339, 345);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(72, 16);
            this.Shutdown.TabIndex = 9;
            this.Shutdown.Text = "Shutdown";
            this.Shutdown.UseVisualStyleBackColor = true;
            this.Shutdown.CheckedChanged += new System.EventHandler(this.Shutdown_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.ResetAndSuspend);
            this.Controls.Add(this.TimeFormTo);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.CountDownTime);
            this.Controls.Add(this.CountDownShow);
            this.Controls.Add(this.ProgressBarCountDown);
            this.Controls.Add(this.Confirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CountDownAndRestart By QQ1036673441";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.ProgressBar ProgressBarCountDown;
        public System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.ListBox CountDownShow;
        private System.Windows.Forms.Label CountDownTime;
        private System.Windows.Forms.NumericUpDown Number;
        private System.Windows.Forms.Label TimeFormTo;
        private System.Windows.Forms.Button ResetAndSuspend;
        private System.Windows.Forms.CheckBox Restart;
        private System.Windows.Forms.CheckBox Shutdown;
    }
}

