using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuarantinee
{
    public partial class Bathroom : Form
    {
        public Bathroom()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSystem HS = new HomeSystem();
            HS.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.banio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.banioOff;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.air2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }
    }
}
