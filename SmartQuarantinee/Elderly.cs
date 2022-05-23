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
    public partial class Elderly : Form
    {
        public Elderly()
        {
            InitializeComponent();
        }
        int timeLeft = 300;
        private void Elderly_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            timer1.Enabled = true;
            if (timeLeft < 300)
            {
                timeLeft = 300;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            timer1.Stop();
            MessageBox.Show("Πατήσατε το κουμπί όλα καλά, δεν θα ειδοποηθεί κάποιος. Αν κάτι αλλάξει, πατήστε το κουμπί έκτακτης ανάγκης");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = timeLeft.ToString();
            timeLeft -= 1;

            if (timeLeft < 0)
            {
                timer1.Stop();
            }

            if (label6.Text == "0")
            {
                panel1.Visible = false;
                panel2.Visible = true;
                MessageBox.Show("Φαίνεται πως κάτι δεν πάει καλά" + "\n" +
                    "Η βοήθεια είναι καθοδόν, παρακαλώ παραμείνετε ψύχραιμοι");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ειδοποίσαμε το κοντινότερο νοσοκομείο." +
                "Ένας γιατρός θα επικοινωνήσει μαζί σας. " +
                "Αν χρειαστεί ένα να ασθενοφόρο θα έρθει να σας προσφέρει τις πρώτες βοήθειες και να σας μεταφέρει στο νοσομείο αν είναι απαραίτητο.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ειδοποιήσαμε ένα κλιμάκιο να περάσει να σας κανει το τεστ κορωνοϊού." + "\n" +
                "Αν δεν αισθάνεστε καλά σας συμβουλεύουμε να καλέσετε γιατρό για τη μεταφορα σας στο νοσκομειο.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ιατρική βοήθεια είναι καθοδόν, παρακαλώ παραμείνετε ψύχραιμοι." +
                " Έχουμε ειδοποιήσει και τους κοντινότερους συγγενείς σας να έρθουν στο σπίτι σας.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            MessageBox.Show("Η παραγγελία σας:\n\n" + richTextBox1.Text + "\n\nέχει αποσταλεί στο κοντινότερο σουπερμάρκετ.\n\n" +
                "Ένας υπάλληλος θα σας ειδοποιήσει πότε θα αποσταλεί η παραγγελία σας.");
            richTextBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            richTextBox1.Clear();
            MessageBox.Show("Ένας υπάλληλος θα επικοινωνήσει μαζί σας για να του δώσετε τη παραγγελία σας.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            richTextBox1.Clear();
        }
    }
}
