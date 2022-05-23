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
    public partial class paggos : Form
    {
        public paggos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitcen f2 = new Kitcen();
            f2.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (timeLeft2 < 20)
            {
                timeLeft2 = 20;
            }
            pictureBox3.Image = Properties.Resources.air3;
            timer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timeLeft1 < 10)
            {
                timeLeft1 = 10;
            }
            pictureBox1.Image = Properties.Resources.kafetiera;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.kafetieraOf;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = null;
        }
        int timeLeft1 = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft1 -= 1;

            if (timeLeft1 < 0)
            {
                timer1.Stop();
                pictureBox1.Image = Properties.Resources.kafetieraOf;
            }
        }
        int timeLeft2 = 20;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLeft2 -= 1;

            if (timeLeft2 < 0)
            {
                timer2.Stop();
                pictureBox3.Image = null;
            }
        }
    }
}
