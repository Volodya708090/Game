using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Rating_KeyDown);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Rating_Load(object sender, EventArgs e)
        {

        }
        private void Rating_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                this.Close();
            }
        }
    }
}
