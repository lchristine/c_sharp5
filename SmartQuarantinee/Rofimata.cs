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
    public partial class Rofimata : Form
    {
        public Rofimata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Coffee cafe = new Coffee();
            cafe.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            cafeRestaurant CR = new cafeRestaurant();
            CR.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι χυμός " + comboBox1.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox2.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι " + comboBox2.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox3.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι " + comboBox3.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox4.SelectedItem != null)
            {
                string water = "";
                if (comboBox4.SelectedIndex == 0)
                {
                     water = "0,5L";
                }
                else if (comboBox4.SelectedIndex == 0)
                {
                    water = "1,5L";
                }
                else if (comboBox4.SelectedIndex == 0)
                {
                    water = "Ανθρακούχο";
                }
                MessageBox.Show("Η παραγγελία σας είναι " + water + " νερό και έχει προστεθεί στο καλάθι");
            }
            if (comboBox5.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι milkshake " + comboBox5.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox6.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι σοκολάτα " + comboBox6.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox7.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι smoothie " + comboBox7.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox8.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι γρανίτα " + comboBox8.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }
            if (comboBox9.SelectedItem != null)
            {
                MessageBox.Show("Η παραγγελία σας είναι μπύρα " + comboBox9.SelectedItem + " και έχει προστεθεί στο καλάθι");
            }

            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null && comboBox3.SelectedItem == null && comboBox4.SelectedItem == null && comboBox5.SelectedItem == null && comboBox6.SelectedItem == null && comboBox7.SelectedItem == null && comboBox8.SelectedItem == null && comboBox9.SelectedItem == null)
            {
                MessageBox.Show("Δεν έχετε επιλέξει κάτι για να προστεθεί στο κλάθι σας.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
