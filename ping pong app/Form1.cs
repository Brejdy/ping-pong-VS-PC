using System;
using System.Windows.Forms;
using System.Media;

namespace ping_pong_app
{
    public partial class Form1 : Form
    {
        //initial ball speed 
        int ballXspeed = 4;
        int ballYspeed = 4;

        //initial pc speed
        int speed = 2;

        Random rand = new Random();

        //player going up or down check
        bool goDown, goUp;

        //pc speed change interval
        int computerSpeedChange = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;

        //speed for ball and pc
        int[] i = { 5, 6, 8, 9 };
        int[] j = { 10, 8, 8, 11, 12 };

        //sounds
        SoundPlayer racket = new SoundPlayer("racket.wav");
        SoundPlayer ground = new SoundPlayer("ground.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //ball movement
            ball.Top -= ballYspeed;
            ball.Left -= ballXspeed;

            //score in header
            this.Text = "Player Score: " + playerScore + " --- Computer Score: " + computerScore;

            //bounce off wall
            if (ball.Top < 0 || ball.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;
                ground.Play();
            }

            //player missed
            if (ball.Left < -2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                computerScore++;
            }

            //pc missed
            if (ball.Right > this.ClientSize.Width + 2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                playerScore++;
            }

            //computer cant leave screen
            if (Computer.Top <= 1)
            {
                Computer.Top = 0;
            }
            else if (Computer.Bottom >= this.ClientSize.Height)
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }

            //computer moving up and down
            if (ball.Top < Computer.Top + (Computer.Height / 2) && ball.Left > 300)
            {
                Computer.Top -= speed;
            }
            if (ball.Top > Computer.Top + (Computer.Height / 2) && ball.Left > 300)
            {
                Computer.Top += speed;
            }

            computerSpeedChange -= 1;
            if(computerSpeedChange < 0)
            {
                speed = i[rand.Next(i.Length)];
                computerSpeedChange = 50;
            }

            //player cant leave the screen
            if (goDown && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }

            if (goUp && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }

            //collision control
            CheckCollision(ball, Player, Player.Right + 5);
            CheckCollision(ball, Computer, Computer.Left - 35);


            //game over
            if (computerScore == 5)
            {
                GameOver("Sorry you lost THE GAME");
            }
            if (playerScore == 5)
            {
                GameOver("You won this time!");
            }
        }

        //arrow pressing
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
        }

        //arrow release
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        //2 object colision
        private void CheckCollision(PictureBox picOne, PictureBox picTwo, int offset)
        {
            if (picOne.Bounds.IntersectsWith(picTwo.Bounds))
            {
                picOne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];

                if (ballXspeed < 0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed = -x;
                }

                if (ballYspeed < 0)
                {
                    ballYspeed = -y;
                    racket.Play();
                }
                else
                {
                    ballYspeed = y;
                    racket.Play();
                }

            }
        }

        //Game Over window
        private void GameOver(string Message)
        {
            GameTimer.Stop();
            MessageBox.Show(Message, "Game Says: ");
        }
    }
}
