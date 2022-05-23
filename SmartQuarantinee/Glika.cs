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
    public partial class Glika : Form
    {
        public Glika()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            cafeRestaurant CR = new cafeRestaurant();
            CR.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1 == null && radioButton2 == null && radioButton3 == null && radioButton4 == null && radioButton5 == null && radioButton6 == null && radioButton7 == null)
            {
                MessageBox.Show("Δεν έχετε επιλέξει κάποιο προϊόν.");
            }
            if (radioButton1 != null || radioButton2 != null || radioButton4 != null)
            {
                RadioButton rbn = null;

                if (radioButton1.Checked == true)
                {
                    rbn = radioButton1;
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Η παραγγελίας σας είναι " + rbn.Text + " και έχει προστεθεί στο καλάθι");
                    }
                    else
                    {
                        MessageBox.Show("Η παραγγελίας σας είναι " + rbn.Text + " με παγωτό " + comboBox1.Text + " και έχει προστεθεί στο καλάθι");
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    rbn = radioButton2;
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Η παραγγελίας σας είναι " + rbn.Text + " και έχει προστεθεί στο καλάθι");
                    }
                    else
                    {
                        MessageBox.Show("Η παραγγελίας σας είναι " + rbn.Text + " με παγωτό " + comboBox1.Text + " και έχει προστεθεί στο καλάθι");
                    }
                }
                else if (radioButton4.Checked == true)
                {
                    rbn = radioButton4;
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Η παραγγελίας σας είναι " + rbn.Text + " και έχει προστεθεί στο καλάθι");
                    }
                    else
                    {
                        MessageBox.Show("Η παραγγελίας σας είναι " + rbn.Text + " με παγωτό " + comboBox1.Text + " και έχει προστεθεί στο καλάθι");
                    }
                }
            }
             if (radioButton3 != null || radioButton5 != null || radioButton6 != null || radioButton7 != null)
             {
                RadioButton rb = null;
                if (radioButton3.Checked == true)
                {
                    rb = radioButton3;
                    MessageBox.Show("Η παραγγελίας σας είναι " + rb.Text + " και έχει προστεθεί στο καλάθι");
                }
                else if (radioButton5.Checked == true)
                {
                    rb = radioButton5;
                    MessageBox.Show("Η παραγγελίας σας είναι " + rb.Text + " και έχει προστεθεί στο καλάθι");
                }
                else if (radioButton6.Checked == true)
                {
                    rb = radioButton6;
                    MessageBox.Show("Η παραγγελίας σας είναι " + rb.Text + " και έχει προστεθεί στο καλάθι");
                }
                else if (radioButton7.Checked == true)
                {
                    rb = radioButton7;
                    MessageBox.Show("Η παραγγελίας σας είναι " + rb.Text + " και έχει προστεθεί στο καλάθι");
                }
             }
            


            /*if (comboBox1 == null)
                {
                    MessageBox.Show("Η παραγγελίας σας είναι " + rb.Text + " και έχει προστεθεί στο καλάθι");
                }
                else
                {
                    MessageBox.Show("Η παραγγελίας σας είναι " + rb.Text + " με παγωτό" + comboBox1.Text + " και έχει προστεθεί στο καλάθι");
                }
             
             foreach (var item in checkedListBox1.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                int id = row.Field<int>("ID");
                string name = row.Field<string>("Συστατικά: ");
                MessageBox.Show(id + ": " + name);
            } */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
