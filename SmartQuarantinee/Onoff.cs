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
    public partial class Onoff : Form
    {
        int domatiokurio_light = 0, domatiokids_light = 0, kouzina_light = 0, banio_light = 0, kathistiko_light = 0;
        int tv = 0, radio = 0, vrastiras = 0, kafetiera = 0, thermometro = 0, thermosifonas = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Onoff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Τηλεόραση")
            {
                pictureBox2.Image = Properties.Resources.tvOn;
                tv = 1;
            }
            else if (comboBox2.Text == "Ραδιόφωνο")
            {
                pictureBox2.Image = Properties.Resources.RdioOn;
                radio = 1;
            }
            else if (comboBox2.Text == "Βραστήρας")
            {
                pictureBox2.Image = Properties.Resources.vrastirasOn;
                vrastiras = 1;
            }
            else if (comboBox2.Text == "Καφετιέρα")
            {
                pictureBox2.Image = Properties.Resources.kafetieraOn;
                kafetiera = 1;
            }
            else if (comboBox2.Text == "Ηλεκτρονικό θερμόμετρο")
            {
                pictureBox2.Image = Properties.Resources.thermometroOn;
                thermometro = 1;
            }
            else if (comboBox2.Text == "Θερμοσίφωνας")
            {
                pictureBox2.Image = Properties.Resources.thermosifonasOn;
                thermosifonas = 1;
            }
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Τηλεόραση")
            {
                pictureBox2.Image = Properties.Resources.tvOff;
                tv = 0;
            }
            else if (comboBox2.Text == "Ραδιόφωνο")
            {
                pictureBox2.Image = Properties.Resources.RdioOff;
                radio = 0;
            }
            else if (comboBox2.Text == "Βραστήρας")
            {
                pictureBox2.Image = Properties.Resources.vrastirasOff;
                vrastiras = 0;
            }
            else if (comboBox2.Text == "Καφετιέρα")
            {
                pictureBox2.Image = Properties.Resources.kafetieraOff;
                kafetiera = 0;
            }
            else if (comboBox2.Text == "Ηλεκτρονικό θερμόμετρο")
            {
                pictureBox2.Image = Properties.Resources.thermometroOff;
                thermometro = 0;
            }
            else if (comboBox2.Text == "Θερμοσίφωνας")
            {
                pictureBox2.Image = Properties.Resources.thermosifonasOff;
                thermosifonas = 0;
            }
            button4.Enabled = false;
            button3.Enabled = true;
    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Τηλεόραση")
            {
                if (tv == 1)
                {
                    pictureBox2.Image = Properties.Resources.tvOn;
                    button4.Enabled = true;
                }
                else if (tv == 0)
                {
                    pictureBox2.Image = Properties.Resources.tvOff;
                    button3.Enabled = true;
                }
            }
            else if (comboBox2.Text == "Ραδιόφωνο")
            {
                if (radio == 1)
                {
                    pictureBox2.Image = Properties.Resources.RdioOn;
                    button4.Enabled = true;
                }
                else if (radio == 0)
                {
                    pictureBox2.Image = Properties.Resources.RdioOff;
                    button3.Enabled = true;
                }
            }
            else if (comboBox2.Text == "Βραστήρας")
            {
                if (vrastiras == 1)
                {
                    pictureBox2.Image = Properties.Resources.vrastirasOn;
                    button4.Enabled = true;
                }
                else if (vrastiras == 0)
                {
                    pictureBox2.Image = Properties.Resources.vrastirasOff;
                    button3.Enabled = true;
                }
            }
            else if (comboBox2.Text == "Καφετιέρα")
            {
                if (kafetiera == 1)
                {
                    pictureBox2.Image = Properties.Resources.kafetieraOn;
                    button4.Enabled = true;
                }
                else if (kafetiera == 0)
                {
                    pictureBox2.Image = Properties.Resources.kafetieraOff;
                    button3.Enabled = true;
                }
            }
            else if (comboBox2.Text == "Ηλεκτρονικό θερμόμετρο")
            {
                if (thermometro == 1)
                {
                    pictureBox2.Image = Properties.Resources.thermometroOn;
                    button4.Enabled = true;
                }
                else if (thermometro == 0)
                {
                    pictureBox2.Image = Properties.Resources.thermometroOff;
                    button3.Enabled = true;
                }
            }
            else if (comboBox2.Text == "Θερμοσίφωνας")
            {
                if (thermosifonas == 1)
                {
                    pictureBox2.Image = Properties.Resources.thermosifonasOn;
                    button4.Enabled = true;
                }
                else if (thermosifonas == 0)
                {
                    pictureBox2.Image = Properties.Resources.thermosifonasOff;
                    button3.Enabled = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Κρεβατοκάμαρα")
            {
                if (domatiokurio_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.domatiokurio;
                    button2.Enabled = true;
                }
                else if (domatiokurio_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.domatiokurioOff;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Παιδικό δωμάτιο")
            {
                if (domatiokids_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.domatiokids;
                    button2.Enabled = true;
                }
                else if (domatiokids_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.domatiokidsOff;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Κουζίνα")
            {
                if (kouzina_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.kouzina;
                    button2.Enabled = true;
                }
                else if (kouzina_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.kouzinaOff;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Μπάνιο")
            {
                if (banio_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.banio;
                    button2.Enabled = true;
                }
                else if (banio_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.banioOff;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Καθιστικό")
            {
                if (kathistiko_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.kathistiko;
                    button2.Enabled = true;
                }
                else if (kathistiko_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.kathistikoOff;
                    button1.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Κρεβατοκάμαρα")
            {
                pictureBox1.Image = Properties.Resources.domatiokurioOff;
                domatiokurio_light = 0;
            }
            else if (comboBox1.Text == "Παιδικό δωμάτιο")
            {
                pictureBox1.Image = Properties.Resources.domatiokidsOff;
                domatiokids_light = 0;
            }
            else if (comboBox1.Text == "Κουζίνα")
            {
                pictureBox1.Image = Properties.Resources.kouzinaOff;
                kouzina_light = 0;
            }
            else if (comboBox1.Text == "Μπάνιο")
            {
                pictureBox1.Image = Properties.Resources.banioOff;
                banio_light = 0;
            }
            else if (comboBox1.Text == "Καθιστικό")
            {
                pictureBox1.Image = Properties.Resources.kathistikoOff;
                kathistiko_light = 0;
            }
            button2.Enabled = false;
            button1.Enabled = true;
        }

        public Onoff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Κρεβατοκάμαρα")
            {
                pictureBox1.Image = Properties.Resources.domatiokurio;
                domatiokurio_light = 1;
            }
            else if (comboBox1.Text == "Παιδικό δωμάτιο")
            {
                pictureBox1.Image = Properties.Resources.domatiokids;
                domatiokids_light = 1;
            }
            else if (comboBox1.Text == "Κουζίνα")
            {
                pictureBox1.Image = Properties.Resources.kouzina;
                kouzina_light = 1;
            }
            else if (comboBox1.Text == "Μπάνιο")
            {
                pictureBox1.Image = Properties.Resources.banio;
                banio_light = 1;
            }
            else if (comboBox1.Text == "Καθιστικό")
            {
                pictureBox1.Image = Properties.Resources.kathistiko;
                kathistiko_light = 1;
            }
            button1.Enabled = false;
            button2.Enabled = true;
        }
            
    }
}
