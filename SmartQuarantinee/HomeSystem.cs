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
    public partial class HomeSystem : Form
    {
        public HomeSystem()
        {
            InitializeComponent();
        }

        private void HomeSystem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bedroom f2 = new Bedroom();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            livingroom f2 = new livingroom();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kitcen f2 = new Kitcen();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bathroom f2 = new Bathroom();
            f2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Entrance en = new Entrance();
            en.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = numericUpDown1.Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            button9.Visible = false;
            label2.Text = "OFF";
        }
    }
}
