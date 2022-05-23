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
    public partial class SMS : Form
    {
        
        public SMS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != null && textBox4.Text != "" &&  textBox2.Text != "" && comboBox1.Text != "" )
            {
                int number = 0;

                if (comboBox1.Text == "1.SMS για ιατρικούς λόγους") 
                {
                    number = 1;
                }
                else if (comboBox1.Text == "2. SMS για αγορά")
                {
                    number = 2;
                }
                else if (comboBox1.Text == "3. SMS για τράπεζα")
                {
                    number = 3;
                }
                else if (comboBox1.Text == "4. SMS για βοήθεια")
                {
                    number = 4;
                }
                else if (comboBox1.Text == "5.SMS για τελετές")
                {
                    number = 5;
                }
                else if (comboBox1.Text == "6.SMS για άθληση")
                {
                    number = 6;
                }
                MessageBox.Show("Το μήνυμα:\n\n" + number + " " + textBox1.Text + " " + textBox4.Text + " " + textBox2.Text + "\n\nθα σταλθεί στο 13033 στις " + numericUpDown1.Text + ", από τον αριθμό " + textBox3.Text);
                this.Hide();
                maps f2 = new maps(this, this);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("δεν έχεις συμπληρώσει όλα τα στοιχεία ");
            } 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            coffeeS f2 = new coffeeS();
            f2.ShowDialog();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //label8.Visible = true;
            //button4.Visible = true;
        }

        private void SMS_Load(object sender, EventArgs e)
        {

        }
    }
}
