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
    public partial class coffeeS : Form
    {

        public coffeeS()
        {
            InitializeComponent();
        }

        private void station_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked != false || radioButton2.Checked != false || radioButton3.Checked != false || radioButton4.Checked != false || radioButton5.Checked != false || radioButton6.Checked != false || radioButton7.Checked != false)
            {
                RadioButton rb = null;

                if (radioButton1.Checked == true)
                {
                    rb = radioButton1;
                }
                else if (radioButton2.Checked == true)
                {
                    rb = radioButton2;
                }
                else if (radioButton3.Checked == true)
                {
                    rb = radioButton3;
                }
                else if (radioButton4.Checked == true)
                {
                    rb = radioButton4;
                }
                else if (radioButton5.Checked == true)
                {
                    rb = radioButton5;
                }
                else if (radioButton6.Checked == true)
                {
                    rb = radioButton6;
                }
                else if (radioButton7.Checked == true)
                {
                    rb = radioButton7;
                }
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Διαλέξτε ποσότητα ζάχαρης");
                }
                else
                {
                    if (checkBox1.Checked == false)
                    {
                        MessageBox.Show("Η παραγκελία σας είναι: " + rb.Text + " " + comboBox1.Text + " χωρίς " + checkBox1.Text + " και έχει προστεθεί στο καλάθι");
                    }
                    else
                    {
                        MessageBox.Show("Η παραγκελία σας είναι: " + rb.Text + " " + comboBox1.Text + " με " + checkBox1.Text + " και έχει προστεθεί στο καλάθι");
                    }
                }
            }
            else
            {
                MessageBox.Show("Διαλέξτε κάποιο προϊόν για να το προσθέσετε στο καλάθι");
            }
        }
    }
}
