namespace Proyecto10C_
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
            hourMinuteLabel = new Label();
            SecondsLabel = new Label();
            DateLabel = new Label();
            WeekLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // hourMinuteLabel
            // 
            hourMinuteLabel.Font = new Font("Old English Text MT", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            hourMinuteLabel.ForeColor = Color.White;
            hourMinuteLabel.Location = new Point(12, 9);
            hourMinuteLabel.Name = "hourMinuteLabel";
            hourMinuteLabel.Size = new Size(434, 117);
            hourMinuteLabel.TabIndex = 0;
            hourMinuteLabel.Text = "19:25";
            hourMinuteLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SecondsLabel
            // 
            SecondsLabel.Font = new Font("Old English Text MT", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SecondsLabel.ForeColor = Color.White;
            SecondsLabel.Location = new Point(474, 9);
            SecondsLabel.Name = "SecondsLabel";
            SecondsLabel.Size = new Size(399, 117);
            SecondsLabel.TabIndex = 1;
            SecondsLabel.Text = "43";
            SecondsLabel.TextAlign = ContentAlignment.MiddleCenter;
            SecondsLabel.Click += label1_Click;
            // 
            // DateLabel
            // 
            DateLabel.Font = new Font("Old English Text MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DateLabel.ForeColor = Color.White;
            DateLabel.Location = new Point(12, 132);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(434, 156);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Jan 03 2023";
            DateLabel.TextAlign = ContentAlignment.MiddleCenter;
            DateLabel.Click += Date_Click;
            // 
            // WeekLabel
            // 
            WeekLabel.Font = new Font("Old English Text MT", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            WeekLabel.ForeColor = Color.White;
            WeekLabel.Location = new Point(474, 152);
            WeekLabel.Name = "WeekLabel";
            WeekLabel.Size = new Size(399, 117);
            WeekLabel.TabIndex = 3;
            WeekLabel.Text = "Tuesday";
            WeekLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(910, 297);
            Controls.Add(WeekLabel);
            Controls.Add(DateLabel);
            Controls.Add(SecondsLabel);
            Controls.Add(hourMinuteLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label hourMinuteLabel;
        private Label SecondsLabel;
        private Label DateLabel;
        private Label WeekLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
