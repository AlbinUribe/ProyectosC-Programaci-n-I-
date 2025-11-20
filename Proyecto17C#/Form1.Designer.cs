namespace Proyecto17C_
{
    partial class GameForm
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
            PlayGround = new Panel();
            GameOver_Lbl = new Label();
            Points_Lbl = new Label();
            Score_Lbl = new Label();
            Ball = new PictureBox();
            Raquet = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Raquet).BeginInit();
            SuspendLayout();
            // 
            // PlayGround
            // 
            PlayGround.Controls.Add(GameOver_Lbl);
            PlayGround.Controls.Add(Points_Lbl);
            PlayGround.Controls.Add(Score_Lbl);
            PlayGround.Controls.Add(Ball);
            PlayGround.Controls.Add(Raquet);
            PlayGround.Dock = DockStyle.Fill;
            PlayGround.Location = new Point(0, 0);
            PlayGround.Name = "PlayGround";
            PlayGround.Size = new Size(800, 450);
            PlayGround.TabIndex = 0;
            // 
            // GameOver_Lbl
            // 
            GameOver_Lbl.BackColor = SystemColors.Control;
            GameOver_Lbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            GameOver_Lbl.ForeColor = Color.Black;
            GameOver_Lbl.Location = new Point(531, 39);
            GameOver_Lbl.Name = "GameOver_Lbl";
            GameOver_Lbl.Size = new Size(171, 160);
            GameOver_Lbl.TabIndex = 4;
            GameOver_Lbl.Text = "Game over!\r\n\r\nf1 - Reiniciar\r\n\r\nesc - Salir \r\n";
            // 
            // Points_Lbl
            // 
            Points_Lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Points_Lbl.Location = new Point(173, 21);
            Points_Lbl.Name = "Points_Lbl";
            Points_Lbl.Size = new Size(100, 52);
            Points_Lbl.TabIndex = 3;
            Points_Lbl.Text = "0";
            Points_Lbl.Click += label2_Click;
            // 
            // Score_Lbl
            // 
            Score_Lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Score_Lbl.Location = new Point(12, 9);
            Score_Lbl.Name = "Score_Lbl";
            Score_Lbl.Size = new Size(155, 79);
            Score_Lbl.TabIndex = 2;
            Score_Lbl.Text = "Puntos";
            Score_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ball
            // 
            Ball.BackColor = Color.Crimson;
            Ball.Location = new Point(298, 215);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.TabIndex = 1;
            Ball.TabStop = false;
            // 
            // Raquet
            // 
            Raquet.BackColor = Color.Black;
            Raquet.Location = new Point(285, 335);
            Raquet.Name = "Raquet";
            Raquet.Size = new Size(204, 20);
            Raquet.TabIndex = 0;
            Raquet.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PlayGround);
            Name = "GameForm";
            Text = "Ping Pong";
            KeyDown += GameForm_KeyDown;
            PlayGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)Raquet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PlayGround;
        private PictureBox Ball;
        private PictureBox Raquet;
        private Label Points_Lbl;
        private Label Score_Lbl;
        private Label GameOver_Lbl;
        private System.Windows.Forms.Timer timer1;
    }
}
