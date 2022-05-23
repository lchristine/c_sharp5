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
    public partial class Thermometro : Form
    {
        public Thermometro()
        {
            InitializeComponent();
        }

        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (timeLeft < 10)
            {
                timeLeft = 10;
            }
            timer1.Enabled = true;
            label5.Visible = true;
            label6.Visible = true;
            label6.Text = "Πραγματοποιείται θερμομέτρηση, παρακαλώ περιμένετε τον\nμηδενισμότου χρονομέτρου και η θερμοκρασία θα εμφανιστεί αυτόματα:";
            label4.Text = "Πραγματοποιείται η θερμομέτρηση,\nπαρακαλώ παραμείνετε ακίνητοι μπροστά στο θερμόμετρο.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η είσοδος απορρίφθηκε");
            label4.Text = "Η είσοοδος απορρίπτεται" + "\n" +
                "Συγγνώμη, δεν μπορείτε να περάσετε";
            panel1.Visible = false;
        }
        int timeLeft = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label5.Text = timeLeft.ToString();
            timeLeft -= 1;
            if (timeLeft == 9 || timeLeft == 5 || timeLeft == 1) 
            {
                pictureBox2.Image = Properties.Resources.green;
                label12.BackColor = Color.LightGreen;
                label12.Text = ".......";
            }
            else if (timeLeft == 8 || timeLeft == 4)
            {
                pictureBox2.Image = Properties.Resources.kitrino;
                label12.BackColor = Color.Yellow;
            }
            else if (timeLeft == 7 || timeLeft == 3 || timeLeft == 0)
            {
                pictureBox2.Image = Properties.Resources.portokali;
                label12.BackColor = Color.Orange;
            }
            else if(timeLeft == 6 || timeLeft == 2)
            {
                pictureBox2.Image = Properties.Resources.kokkino;
                label12.BackColor = Color.Red;
            }
            if (timeLeft < 0)
            {
                timer1.Stop();
                label5.Visible = false;
                label6.Visible = false;
            }
            if (label5.Text == "0")
            {
                double result = GetRandomNumber(36, 40);
                if (result <= 36.6)
                {
                    string tmp = result.ToString("0.0");
                    MessageBox.Show("Η θερμοκρασία του επισκέπτη είναι " + tmp + " βαθμοί Κελσίου.");

                    label4.Text = "Η θερμοκρασία σας είναι " + tmp + " βαθμοί Κελσίου." + "\n" +
                        "Παρακαλώ περιμένετε να εγκριθεί η είσοδος σας στο σπίτι";
                    panel1.Visible = true;
                    pictureBox2.Image = Properties.Resources.green;
                    label12.Text = tmp;
                    label12.BackColor = Color.LightGreen;
                }
                else if (result <= 37.2 && result >= 36.6)
                {
                    string tmp = result.ToString("0.0");
                    MessageBox.Show("Η θερμοκρασία του επισκέπτη είναι " + tmp + " βαθμοί Κελσίου" + "\n" +
                        "Η θερμομέτρηση ήταν ασαφής, συμβουλεύεται ο επισκέπτης να περιμένει μερικά λεπτά για να ξανά θερμομετρηθεί προτού αποφασιστεί αν θα του επιτραπεί η είσοδος ή όχι" +
                        ", η πόρτα δεν θα ανοίξει αυτόματα.");

                    label4.Text = "Η θερμοκρασία σας είναι " + tmp + " βαθμοί Κελσίου." + "\n" +
                        "Η θερμπομέτρηση ήταν ασαφής" + "\n" +
                        "Περιμένεται 5 λεπτά για να ηρεμήσετε και ξαναπροσπαθήστε";
                    pictureBox2.Image = Properties.Resources.kitrino;
                    label12.Text = tmp;
                    label12.BackColor = Color.Yellow;
                }
                else if (result >= 37.2 && result <= 38)
                {
                    string tmp = result.ToString("0.0");
                    MessageBox.Show("Η θερμοκρασία του επισκέπτη είναι " + tmp + " βαθμοί Κελσίου" + "\n" +
                        "Ο επισκέπτης δεν είναι ασφαλής να περάσει στο σπίτι, συνίσταται προσοχή, η πόρτα δεν θα ανοίξει αυτόματα.");

                    label4.Text = "Η θερμοκρασία σας είναι " + tmp + " βαθμοί Κελσίου." + "\n" + 
                        "Η είσοδος απορρίφθηκε" + "\n" +
                        "Δεν μπορείτε να περάσετε" + "\n" +
                        "Συνισταται προσοχή";
                    pictureBox2.Image = Properties.Resources.portokali;
                    label12.Text = tmp;
                    label12.BackColor = Color.Orange;
                }
                else if (result >= 38)
                {
                    string Dcenter = "Τζάνειο νοσοκομείο";
                    string tmp = result.ToString("0.0");
                    MessageBox.Show("Η θερμοκρασία του επισκέπτη είναι " + tmp + " βαθμοί Κελσίου" + "\n" +
                        "Ο επισκέπτης δεν είναι ασφαλής να περάσει στο σπίτι, η πόρτα δεν θα ανοίξει αυτόματα, γίνεται η σύσταση στον επισκέπτη να κάνει τεστ κορωνοϊού.");

                    label4.Text = "Η θερμοκρασία σας είναι " + tmp + " βαθμοί Κελσίου." + "\n" +
                        "Η είσοοδος απορρίφθηκε" + "\n" +
                        "Δεν μπορείτε να περάσετε" + "\n" +
                        "Συνιστάται να γίνει τεστ κορωνοϊού" + "\n" +
                        "Το κοντινότερο διαγνωστικό κέντρο είναι το " + Dcenter;
                    pictureBox2.Image = Properties.Resources.kokkino;
                    label12.Text = tmp;
                    label12.BackColor = Color.Red;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η πόρτα έχει ανοίξει");
            label4.Text = "Μπορείτε να περάσετε" + "\n " +
                "Καλώς Ορίσατε";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Εγκρίνατε την είσοδο του επισκέπτη" + "\n" +
                "Ο επισκέπτης είναι ασφαλής να περάσει στο σπίτι, η πόρτα θα ανοίξει αυτόματα.");

            label4.Text = "Η είσοοδος εγκρίθηκε" + "\n" +
                "Μπορείτε να περάσετε" + "\n" +
                "Καλώς ορίσατε";
            panel1.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Thermometro_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label12.Text = "OFF";
            label12.BackColor = Color.Black;
            label4.Text = " Σταθείτε μπροστα στο θερμόμετρο και χτυπήστε το\nκουδούνι για να ξεκινήσει η θερμομέτρηση.";
            pictureBox2.Image = Properties.Resources.black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
