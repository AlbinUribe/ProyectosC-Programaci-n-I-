namespace Proyecto2C_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Player = new AxWMPLib.AxWindowsMediaPlayer();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Enabled = true;
            Player.Location = new Point(0, 3);
            Player.Name = "Player";
            Player.OcxState = (AxHost.State)resources.GetObject("Player.OcxState");
            Player.Size = new Size(1069, 365);
            Player.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 337);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.DarkOrchid;
            button1.Font = new Font("Old English Text MT", 36F);
            button1.Location = new Point(12, 374);
            button1.Name = "button1";
            button1.Size = new Size(219, 81);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Old English Text MT", 36F);
            button2.Location = new Point(237, 374);
            button2.Name = "button2";
            button2.Size = new Size(162, 81);
            button2.TabIndex = 3;
            button2.Text = "Play";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.CornflowerBlue;
            button3.Font = new Font("Old English Text MT", 36F);
            button3.Location = new Point(405, 374);
            button3.Name = "button3";
            button3.Size = new Size(203, 81);
            button3.TabIndex = 4;
            button3.Text = "Pausa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.HotPink;
            button4.Font = new Font("Old English Text MT", 36F);
            button4.Location = new Point(626, 374);
            button4.Name = "button4";
            button4.Size = new Size(235, 81);
            button4.TabIndex = 5;
            button4.Text = "Detener";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Old English Text MT", 36F);
            button5.Location = new Point(867, 374);
            button5.Name = "button5";
            button5.Size = new Size(176, 81);
            button5.TabIndex = 6;
            button5.Text = "Salir";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 458);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Player);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private OpenFileDialog openFileDialog1;
    }
}
