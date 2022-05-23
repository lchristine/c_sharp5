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
    public partial class maps : Form
    {

        SMS f1;
        SMS f2;

        public maps(SMS frm1, SMS frm2)
        {
            InitializeComponent();
            this.f1 = frm1;
            this.f2 = frm2;
        }
        /*  station f2; 
          public maps()
          {
              InitializeComponent();
              this.f2 = frm2; 
          }
        */
        private void maps_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            button4.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            if (textBox2.Text != "" && comboBox3.SelectedIndex == 0 && comboBox1.SelectedIndex == 0)
            {
                label10.Visible = true;
                pictureBox1.Visible = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                label8.Visible = true;
                button4.Visible = true;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                label2.Visible = true;
                textBox1.Visible = true;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                label2.Visible = true;
                textBox1.Visible = true;
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                label2.Visible = true;
                textBox1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            coffeeS cS = new coffeeS();
            cS.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
