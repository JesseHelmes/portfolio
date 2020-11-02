using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona_project
{
    public partial class frmRekenspel : Form
    {
        string[] rekentekens = { "+", "-", "*", "/" };
        Random random = new Random();
        double antwoord;
        int vraag = 1;
        int goed = 0;
        public frmRekenspel()
        {
            InitializeComponent();
        }

        public void NieuweSom()
        {
            int index = random.Next(rekentekens.Length);
            if(index == 0)
            {
                getal1.Text = random.Next(1,101).ToString();
                getal2.Text = random.Next(1,101).ToString();
                rekenteken.Text = "+";
            }
            else if(index == 1)
            {
                getal1.Text = random.Next(1,101).ToString();
                getal2.Text = random.Next(1,101).ToString();
                rekenteken.Text = "-";
            }
            else if(index == 2)
            {
                getal1.Text = random.Next(1,11).ToString();
                getal2.Text = random.Next(1,11).ToString();
                rekenteken.Text = "X";
            }
            else
            {
                getal1.Text = random.Next(1,11).ToString();
                getal2.Text = random.Next(1,11).ToString();
                rekenteken.Text = "÷";
            }
        }

        private void FrmRekenspel_Load(object sender, EventArgs e)
        {
            NieuweSom();
        }

        private void BtnBeantwoord_Click(object sender, EventArgs e)
        {
            if(rekenteken.Text == "+")
            {
                antwoord = double.Parse(getal1.Text) + double.Parse(getal2.Text);
            }
            else if(rekenteken.Text == "-")
            {
                antwoord = double.Parse(getal1.Text) - double.Parse(getal2.Text);
            }
            else if(rekenteken.Text == "X")
            {
                antwoord = double.Parse(getal1.Text) * double.Parse(getal2.Text);
            }
            else
            {
                antwoord = Math.Round(double.Parse(getal1.Text) / double.Parse(getal2.Text),2);
            }
            if (String.IsNullOrEmpty(txtAntwoord.Text))
            {
                MessageBox.Show("Vul een antwoord in");
            }
            else if (double.Parse(txtAntwoord.Text) == antwoord )
            {
                this.BackColor = Color.FromArgb(0, 255, 0);
                MessageBox.Show("Het antwoord is goed");
                vraag++;
                goed++;
                NieuweSom();
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 0, 0);
                MessageBox.Show("Het antwoord is fout");
                vraag++;
                NieuweSom();
            }
            txtAntwoord.Clear();
            lblVragen.Text = "Vraag " + vraag + "/20";
            if (vraag == 21)
            {
                lblVragen.Text = "Vraag 20/20";
                MessageBox.Show("Je hebt " + goed + " van de 20 vragen goed beantwoord");
            }
        }

        private void TxtAntwoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }
    }
}
