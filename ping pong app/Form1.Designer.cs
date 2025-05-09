namespace ping_pong_app
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Computer = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.Image = global::ping_pong_app.Properties.Resources.Solid_white_bordered_svg;
            this.Player.Location = new System.Drawing.Point(12, 151);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 120);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Computer
            // 
            this.Computer.Image = global::ping_pong_app.Properties.Resources.Solid_white_bordered_svg;
            this.Computer.Location = new System.Drawing.Point(758, 151);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(30, 120);
            this.Computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Computer.TabIndex = 0;
            this.Computer.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::ping_pong_app.Properties.Resources.Table_tennis_ball;
            this.ball.Location = new System.Drawing.Point(372, 199);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Player : 0 --- Computer: 0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Computer;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}

