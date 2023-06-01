using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class AboutTheGame : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public AboutTheGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Luck_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer();
            a.URL = "C:\\Users\\Вольдемар\\Desktop\\Создание игры\\Музыка для игры\\бегу к тебе привет пупсик. (256  kbps).mp3";
            a.controls.play();
            this.pictureBox1.BringToFront();
            this.pictureBox1.Visible = true;
            this.pictureBox1.Width = 1920;
            this.pictureBox1.Height = 1080;
            this.WindowState = FormWindowState.Maximized;
            


        }
    }
}
