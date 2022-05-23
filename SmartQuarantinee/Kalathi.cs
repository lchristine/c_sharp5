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
    public partial class Kalathi : Form
    {
        public Kalathi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 && textBox2.TextLength == 0 && textBox3.TextLength == 0 && textBox4.TextLength == 0 && comboBox1.SelectedItem == null && textBox6.TextLength == 0 && textBox7.TextLength == 0)
            {
                MessageBox.Show("Συμπληρωστε όλα τα στοιχεία για να αποσταλεί η παραγγελία σας.");
            }
            else
            {
                MessageBox.Show("Η παραγγελεία σας εστάλει επιτυχώς, σας ευχαριστούμε για την προτίμηση σας");
                this.Hide();
                cafeRestaurant cR = new cafeRestaurant();
                cR.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            cafeRestaurant CR = new cafeRestaurant();
            CR.ShowDialog();
        }
    }
}
