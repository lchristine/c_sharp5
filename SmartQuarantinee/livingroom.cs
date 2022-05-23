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
    public partial class livingroom : Form
    {
        public livingroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            BackgroundImage = Properties.Resources.kathistiko;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.kathistikoOff;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSystem f2 = new HomeSystem();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RdioOn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.RdioOff;
        }
    }
}
