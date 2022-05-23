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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            cafeRestaurant CR = new cafeRestaurant();
            CR.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SMS SMS = new SMS();
            SMS.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thermometro thrm = new Thermometro();
            thrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeSystem onf = new HomeSystem();
            onf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Elderly elder = new Elderly();
            elder.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Για την αποστολή μηνύματος\nμε σκοπό την μετακίνηση εκτός σπιτιού\nκαι την εμφάνιση χάρτη της διαδρομής.";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Προσομοίωση αλληλεπίδρασης με τις\nδιάφορες συσκευές του σπιτιού των κατοίκων\nκαθώς εκείνοι θα δουλεύουν με τηλε-εργασία\nώστε οι ένοικοι να μην ενοχλούν ο ένας\nτον άλλον κατά τη διάρκεια των\n τηλεδιασκέψεών τους.  ";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Προσομοίωση ηλεκτρονικού θερμομέτρου\nγια την θερμομέτρηση των επισκεπτών\nπριν την είσοδο τους στο σπίτι";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Προσομοίωση αλληλεπίδρασης ηλικιωμένων\n κατοίκων με τους υπαλλήλους της κοινωνικής\nυπηρεσίας του Δήμου.";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "On-line σύστημα παραγγελιών από καφετέρια-\nεστιατόριο ή ηλεκτρονικό κατάστημα\n(παραγγελία και πληρωμή με πιστωτική κάρτα).";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filename = "teliki.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}
