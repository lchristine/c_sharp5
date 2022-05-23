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
    public partial class Bedroom : Form
    {
        public Bedroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.domatiokurio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.domatiokurioOff;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tvOn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tvOff;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSystem f2 = new HomeSystem();
            f2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            button8.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
            label3.Text = "OFF";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            button8.Visible = false;
            label3.Text = numericUpDown1.Value.ToString();
            pictureBox3.Image = Properties.Resources.air;
        }
    }
}
