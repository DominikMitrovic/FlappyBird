namespace FlappyBird
{
    partial class FlappyBird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlappyBird));
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbPipeDown = new System.Windows.Forms.PictureBox();
            this.pbPipeUp = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHS = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.BackColor = System.Drawing.Color.Transparent;
            this.pbBird.Image = ((System.Drawing.Image)(resources.GetObject("pbBird.Image")));
            this.pbBird.InitialImage = null;
            this.pbBird.Location = new System.Drawing.Point(26, 216);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(70, 70);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbPipeDown
            // 
            this.pbPipeDown.BackColor = System.Drawing.Color.Transparent;
            this.pbPipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pbPipeDown.Image")));
            this.pbPipeDown.Location = new System.Drawing.Point(377, -134);
            this.pbPipeDown.Name = "pbPipeDown";
            this.pbPipeDown.Size = new System.Drawing.Size(80, 340);
            this.pbPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeDown.TabIndex = 0;
            this.pbPipeDown.TabStop = false;
            // 
            // pbPipeUp
            // 
            this.pbPipeUp.BackColor = System.Drawing.Color.Transparent;
            this.pbPipeUp.Image = ((System.Drawing.Image)(resources.GetObject("pbPipeUp.Image")));
            this.pbPipeUp.Location = new System.Drawing.Point(558, 335);
            this.pbPipeUp.Name = "pbPipeUp";
            this.pbPipeUp.Size = new System.Drawing.Size(80, 340);
            this.pbPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipeUp.TabIndex = 0;
            this.pbPipeUp.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(96, 9);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(26, 29);
            this.lblScoreValue.TabIndex = 1;
            this.lblScoreValue.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(79, 29);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "score:";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(367, 9);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(249, 44);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = ((System.Drawing.Image)(resources.GetObject("pbGround.Image")));
            this.pbGround.Location = new System.Drawing.Point(-10, 586);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1233, 89);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 2;
            this.pbGround.TabStop = false;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(424, 128);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(136, 22);
            this.tbName.TabIndex = 3;
            this.tbName.Visible = false;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(423, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Enter your name:";
            this.lblName.Visible = false;
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.Location = new System.Drawing.Point(438, 164);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(107, 34);
            this.lblHS.TabIndex = 5;
            this.lblHS.Text = "HIGH SCORES:\r\n \r\n";
            this.lblHS.Visible = false;
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(785, 9);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(185, 20);
            this.lblRestart.TabIndex = 6;
            this.lblRestart.Text = "Press key \"R\" to restart";
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.lblHS);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pbPipeUp);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.pbPipeDown);
            this.Controls.Add(this.pbBird);
            this.Name = "FlappyBird";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipeDown;
        private System.Windows.Forms.PictureBox pbPipeUp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox pbGround;
        public System.Windows.Forms.Label lblScoreValue;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHS;
        private System.Windows.Forms.Label lblRestart;
    }
}

