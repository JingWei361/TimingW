namespace TimingW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTimer = new Label();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.BackColor = Color.Bisque;
            labelTimer.Font = new Font("Microsoft JhengHei UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(12, 9);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(100, 75);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "60";
            labelTimer.Click += labelTimer_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(12, 87);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 38);
            btnStart.TabIndex = 1;
            btnStart.Text = "開始倒數";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(labelTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTimer;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}
