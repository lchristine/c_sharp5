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
    public partial class Tost : Form
    {
        public Tost()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tost_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι τόστ " + comboBox5.SelectedItem + " και έχει προστεθεί στο καλάθι.");
            }
            else if (radioButton1.Checked == true)
            {
                MessageBox.Show("Η παραγγελία σας είναι " + radioButton1.Text + " και έχει προστεθεί στο καλάθι.");
            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("Η παραγγελία σας είναι " + radioButton2.Text + " και έχει προστεθεί στο καλάθι.");
            }
            else
            {
                MessageBox.Show("Δεν έχετε επιλέξει κάτι για να προστεθεί στο καλάθι.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            cafeRestaurant CR = new cafeRestaurant();
            CR.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
