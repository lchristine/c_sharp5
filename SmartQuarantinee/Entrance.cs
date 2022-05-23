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
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.eisidos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.eisidosOff;
        }
        int timeLeft = 10;
        private void button5_Click(object sender, EventArgs e)
        {
            if (timeLeft == -1)
            {
                timeLeft = 10;
            }
            pictureBox1.Image = Properties.Resources.thermometroOn;
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSystem HS = new HomeSystem();
            HS.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            if (timeLeft < 0)
            {
                timer1.Stop();
                pictureBox1.Image = Properties.Resources.thermometroOff;
            }
        }
    }
}
