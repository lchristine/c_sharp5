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
    public partial class Trofima : Form
    {
        public Trofima()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            cafeRestaurant CR = new cafeRestaurant();
            CR.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι παγωτό " + comboBox1.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox2.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι " + comboBox2.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Δεν έχετε επιλέξει τίποτα. Επιλέξτε κάτι για να προστεθεί στο καλάθι");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tost tost = new Tost();
            tost.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Glika glk = new Glika();
            glk.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Trofima_Load(object sender, EventArgs e)
        {

        }
    }
}
