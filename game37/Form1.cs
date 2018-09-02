using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game37
{
    public partial class Form1: Form
    {
       
         
        int enemyMove = 5;//initialized value 
        Random rnd = new Random(); //random number generation
        int bulletSpeed = 8;//bullrt movement speed
        bool shooting = false;
        int score = 0;//initialized score
        private int moveLeft;

        public Form1() //Form for input...
        {

            InitializeComponent();
            enemy1.Top = -500;
            enemy2.Top = -900;
            enemy3.Top = -1300;
            bullet.Top = -100; 
            bullet.Left = -100;
        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //Moves the key left
            {
                if (player.Location.X < 0) { moveLeft = 0; } else { moveLeft = -5; }
            }
            else if (e.KeyCode == Keys.Right)//Moves the key to right
            {
                if (player.Location.X > 512)
                {
                    moveLeft = 0;
                }
                else
                {
                    moveLeft = 5;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {

                if (shooting == false)
                {
                    bulletSpeed = 8;
                    bullet.Left = player.Left + 50;
                    bullet.Top = player.Top;
                    shooting = true;
                }
            }

        }

        private void onKeyUp(object sender, KeyEventArgs e)//Function 1 key up
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveLeft = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playTimer_Tick(object sender, EventArgs e)//function play timer
        {
            player.Left += moveLeft;
            bullet.Top -= bulletSpeed;
            enemy1.Top += enemyMove;
            enemy2.Top += enemyMove;
            enemy3.Top += enemyMove;
            scoreText.Text = "" + score;

            if (enemy1.Top == 660 || enemy2.Top == 660 || enemy3.Top == 660)
            {
                gameOver();//if enenmy top is 660 then game over

            }

            if (shooting && bullet.Top < 0)
            {
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;
            }
            enemyHit();//if shooting and bullet top is less than 0 then enemy is hit
        }

        private void enemyHit()
        {
            if (bullet.Bounds.IntersectsWith(enemy1.Bounds))
            {
                score += 1;//adds +1 to score
                enemy1.Top = -500;
                int ranP = rnd.Next(1, 300);
                enemy1.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;

            }
            else if (bullet.Bounds.IntersectsWith(enemy2.Bounds))
            {
                score += 1;
                enemy2.Top = -900;
                int ranP = rnd.Next(1, 400);
                enemy2.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;

            }
            else if (bullet.Bounds.IntersectsWith(enemy3.Bounds))
            {
                score += 1;
                enemy3.Top = -1300;
                int ranP = rnd.Next(1, 500);
                enemy3.Left = ranP;
                shooting = false;
                bulletSpeed = 0;
                bullet.Top = -100;
                bullet.Left = -100;

            }
        }

        private void gameOver()//game over function
        {
            playTimer.Enabled = false;
            MessageBox.Show("You Score = " + score + " Click OK to play Again");
            score = 0;
            scoreText.Text = "0";
            enemy1.Top = -500;
            enemy2.Top = -900;
            enemy3.Top = -1300;
            bullet.Top = -100;
            bullet.Left = -100;
            playTimer.Enabled = true;

        }

        private void enemy2_Click(object sender, EventArgs e)
        {

        }
    }
}

