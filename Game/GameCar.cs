using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Game
{
    public partial class GameCar : Form
    {
        private Point pos;
        private bool dragging, lose = false;
        private int countCoins;
        public int recordMoney = 0;

        public GameCar()
        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 15;
            bg1.Top += speed;
            bg2.Top += speed;

            int carSpeed = 10;
            enemy1.Top += carSpeed;
            enemy2.Top += carSpeed;

            coin.Top += speed;


            if (bg1.Top >= 485)
            {
                bg1.Top = 0;
                bg2.Top = -485;
            }

            if (coin.Top >= 650)
            {
                coin.Top = -50;
            }

            if (coin.Top >= 485)
            {
                coin.Top = -130;
                Random random = new Random();
                coin.Left = random.Next(150, 560);
            }

            if (enemy1.Top >= 485)
            {
                enemy1.Top = -130;
                Random random = new Random();
                enemy1.Left = random.Next(150, 340);
            }
            if (enemy2.Top >= 485)
            {
                enemy2.Top = -400;
                Random random = new Random();
                enemy2.Left = random.Next(390, 560);
            }

            if (Player.Bounds.IntersectsWith(enemy1.Bounds)
                || Player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
                if (recordMoney < countCoins)
                {
                    recordMoney = countCoins;
                    StreamWriter write = new StreamWriter("record.txt");
                    write.WriteLine("Володя: " + recordMoney.ToString() + " балл");
                    write.Close();
                }
            }

            if (Player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text = "Монеты: " + countCoins.ToString();
                coin.Top = -130;
                Random random = new Random();
                coin.Left = random.Next(150, 560);
            }
        }

        private void bg1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x1 = Player.Location.X;
            int x2 = Player.Location.X + Player.Size.Width;
            int y1 = Player.Location.Y;
            int y2 = Player.Location.Y + Player.Size.Height;
            if (lose) return;

            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Player.Left > 150)
                Player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Player.Right < 700)
                Player.Left += speed;
            if ((e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && (Player.Top > 80 && Player.Top < 500))
            {
                Player.Top -= 10;
            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.Down) && (Player.Top < 340))
            {
                Player.Top += 10;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countCoins = 0;
            labelCoins.Text = "Монеты: 0";
            coin.Top = -500;
        }
    }
}

