using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void GameCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            StreamReader read = new StreamReader("record.txt");
            while (!read.EndOfStream)
            {
                rating.textBox1.Text += (read.ReadLine()+ "\r\n");
            }
            
            read.Close();
            rating.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameCar carForm = new GameCar();
            carForm.FormClosed += GameCar_FormClosed;
            carForm.Show();
            this.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutTheGame prod= new AboutTheGame();
            prod.Show();
        }
    }
}
