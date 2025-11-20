namespace Proyecto13C_
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
            timeLabel = new Label();
            timeLeftTextBox = new Label();
            plusLeftLabel = new Label();
            plusSign = new Label();
            plusRigthLabel = new Label();
            equalSign = new Label();
            adiccion = new NumericUpDown();
            minusRigthLabel = new Label();
            minusSign = new Label();
            minusLeftLabel = new Label();
            equalSignTwo = new Label();
            difference = new NumericUpDown();
            product = new NumericUpDown();
            equalSignThree = new Label();
            timesRigthLabel = new Label();
            timesSign = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            equalSignFour = new Label();
            divideRigthLabel = new Label();
            divideSign = new Label();
            divideLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)adiccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Old English Text MT", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(680, 8);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(381, 44);
            timeLabel.TabIndex = 0;
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeLeftTextBox
            // 
            timeLeftTextBox.BorderStyle = BorderStyle.FixedSingle;
            timeLeftTextBox.Font = new Font("Old English Text MT", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            timeLeftTextBox.ForeColor = Color.White;
            timeLeftTextBox.Location = new Point(401, 8);
            timeLeftTextBox.Name = "timeLeftTextBox";
            timeLeftTextBox.Size = new Size(204, 34);
            timeLeftTextBox.TabIndex = 1;
            timeLeftTextBox.Text = "Tiempo Restante";
            timeLeftTextBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Old English Text MT", 30F);
            plusLeftLabel.ForeColor = Color.White;
            plusLeftLabel.Location = new Point(171, 54);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(66, 69);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            plusSign.Font = new Font("Old English Text MT", 30F);
            plusSign.ForeColor = Color.White;
            plusSign.Location = new Point(329, 61);
            plusSign.Name = "plusSign";
            plusSign.Size = new Size(66, 69);
            plusSign.TabIndex = 3;
            plusSign.Text = "+";
            plusSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRigthLabel
            // 
            plusRigthLabel.Font = new Font("Old English Text MT", 30F);
            plusRigthLabel.ForeColor = Color.White;
            plusRigthLabel.Location = new Point(467, 61);
            plusRigthLabel.Name = "plusRigthLabel";
            plusRigthLabel.Size = new Size(66, 69);
            plusRigthLabel.TabIndex = 4;
            plusRigthLabel.Text = "?";
            plusRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalSign
            // 
            equalSign.Font = new Font("Old English Text MT", 30F);
            equalSign.ForeColor = Color.White;
            equalSign.Location = new Point(608, 61);
            equalSign.Name = "equalSign";
            equalSign.Size = new Size(66, 69);
            equalSign.TabIndex = 5;
            equalSign.Text = "=";
            equalSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adiccion
            // 
            adiccion.Location = new Point(680, 89);
            adiccion.Name = "adiccion";
            adiccion.Size = new Size(162, 27);
            adiccion.TabIndex = 6;
            adiccion.Enter += Answer_Enter;
            // 
            // minusRigthLabel
            // 
            minusRigthLabel.Font = new Font("Old English Text MT", 30F);
            minusRigthLabel.ForeColor = Color.White;
            minusRigthLabel.Location = new Point(467, 176);
            minusRigthLabel.Name = "minusRigthLabel";
            minusRigthLabel.Size = new Size(66, 69);
            minusRigthLabel.TabIndex = 7;
            minusRigthLabel.Text = "?";
            minusRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            minusRigthLabel.Click += label1_Click_1;
            // 
            // minusSign
            // 
            minusSign.Font = new Font("Old English Text MT", 30F);
            minusSign.ForeColor = Color.White;
            minusSign.Location = new Point(329, 176);
            minusSign.Name = "minusSign";
            minusSign.Size = new Size(66, 69);
            minusSign.TabIndex = 8;
            minusSign.Text = "-";
            minusSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Old English Text MT", 30F);
            minusLeftLabel.ForeColor = Color.White;
            minusLeftLabel.Location = new Point(171, 176);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(66, 69);
            minusLeftLabel.TabIndex = 9;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalSignTwo
            // 
            equalSignTwo.Font = new Font("Old English Text MT", 30F);
            equalSignTwo.ForeColor = Color.White;
            equalSignTwo.Location = new Point(608, 176);
            equalSignTwo.Name = "equalSignTwo";
            equalSignTwo.Size = new Size(66, 69);
            equalSignTwo.TabIndex = 10;
            equalSignTwo.Text = "=";
            equalSignTwo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            difference.Location = new Point(680, 198);
            difference.Name = "difference";
            difference.Size = new Size(162, 27);
            difference.TabIndex = 11;
            difference.Enter += Answer_Enter;
            // 
            // product
            // 
            product.Location = new Point(680, 314);
            product.Name = "product";
            product.Size = new Size(162, 27);
            product.TabIndex = 16;
            product.Enter += Answer_Enter;
            // 
            // equalSignThree
            // 
            equalSignThree.Font = new Font("Old English Text MT", 30F);
            equalSignThree.ForeColor = Color.White;
            equalSignThree.Location = new Point(608, 286);
            equalSignThree.Name = "equalSignThree";
            equalSignThree.Size = new Size(66, 69);
            equalSignThree.TabIndex = 15;
            equalSignThree.Text = "=";
            equalSignThree.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRigthLabel
            // 
            timesRigthLabel.Font = new Font("Old English Text MT", 30F);
            timesRigthLabel.ForeColor = Color.White;
            timesRigthLabel.Location = new Point(467, 286);
            timesRigthLabel.Name = "timesRigthLabel";
            timesRigthLabel.Size = new Size(66, 69);
            timesRigthLabel.TabIndex = 14;
            timesRigthLabel.Text = "?";
            timesRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesSign
            // 
            timesSign.Font = new Font("Old English Text MT", 30F);
            timesSign.ForeColor = Color.White;
            timesSign.Location = new Point(329, 286);
            timesSign.Name = "timesSign";
            timesSign.Size = new Size(66, 69);
            timesSign.TabIndex = 13;
            timesSign.Text = "x";
            timesSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Old English Text MT", 30F);
            timesLeftLabel.ForeColor = Color.White;
            timesLeftLabel.Location = new Point(171, 286);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(66, 69);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Location = new Point(680, 430);
            quotient.Name = "quotient";
            quotient.Size = new Size(162, 27);
            quotient.TabIndex = 21;
            quotient.Enter += Answer_Enter;
            // 
            // equalSignFour
            // 
            equalSignFour.Font = new Font("Old English Text MT", 30F);
            equalSignFour.ForeColor = Color.White;
            equalSignFour.Location = new Point(608, 402);
            equalSignFour.Name = "equalSignFour";
            equalSignFour.Size = new Size(66, 69);
            equalSignFour.TabIndex = 20;
            equalSignFour.Text = "=";
            equalSignFour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divideRigthLabel
            // 
            divideRigthLabel.Font = new Font("Old English Text MT", 30F);
            divideRigthLabel.ForeColor = Color.White;
            divideRigthLabel.Location = new Point(467, 402);
            divideRigthLabel.Name = "divideRigthLabel";
            divideRigthLabel.Size = new Size(66, 69);
            divideRigthLabel.TabIndex = 19;
            divideRigthLabel.Text = "?";
            divideRigthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divideSign
            // 
            divideSign.Font = new Font("Old English Text MT", 30F);
            divideSign.ForeColor = Color.White;
            divideSign.Location = new Point(329, 402);
            divideSign.Name = "divideSign";
            divideSign.Size = new Size(66, 69);
            divideSign.TabIndex = 18;
            divideSign.Text = "/";
            divideSign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divideLeftLabel
            // 
            divideLeftLabel.Font = new Font("Old English Text MT", 30F);
            divideLeftLabel.ForeColor = Color.White;
            divideLeftLabel.Location = new Point(171, 395);
            divideLeftLabel.Name = "divideLeftLabel";
            divideLeftLabel.Size = new Size(66, 69);
            divideLeftLabel.TabIndex = 17;
            divideLeftLabel.Text = "?";
            divideLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.BackColor = Color.DarkMagenta;
            startButton.Font = new Font("Old English Text MT", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(220, 491);
            startButton.Name = "startButton";
            startButton.Size = new Size(587, 73);
            startButton.TabIndex = 22;
            startButton.Text = "Empezar";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1073, 590);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(equalSignFour);
            Controls.Add(divideRigthLabel);
            Controls.Add(divideSign);
            Controls.Add(divideLeftLabel);
            Controls.Add(product);
            Controls.Add(equalSignThree);
            Controls.Add(timesRigthLabel);
            Controls.Add(timesSign);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(equalSignTwo);
            Controls.Add(minusLeftLabel);
            Controls.Add(minusSign);
            Controls.Add(minusRigthLabel);
            Controls.Add(adiccion);
            Controls.Add(equalSign);
            Controls.Add(plusRigthLabel);
            Controls.Add(plusSign);
            Controls.Add(plusLeftLabel);
            Controls.Add(timeLeftTextBox);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)adiccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label timeLabel;
        private Label timeLeftTextBox;
        private Label plusLeftLabel;
        private Label plusSign;
        private Label plusRigthLabel;
        private Label equalSign;
        private NumericUpDown adiccion;
        private Label minusRigthLabel;
        private Label minusSign;
        private Label minusLeftLabel;
        private Label equalSignTwo;
        private NumericUpDown difference;
        private NumericUpDown product;
        private Label equalSignThree;
        private Label timesRigthLabel;
        private Label timesSign;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label equalSignFour;
        private Label divideRigthLabel;
        private Label divideSign;
        private Label divideLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}
