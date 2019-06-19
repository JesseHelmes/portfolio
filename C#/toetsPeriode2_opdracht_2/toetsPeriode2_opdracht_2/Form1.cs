using System;
using System.Windows.Forms;

namespace toetsPeriode2_opdracht_2
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnBerekenWaarde_Click(object sender, EventArgs e)
        {
            try
            {
                string merk = txtMerk.Text;
                int bouwjaar = int.Parse(txtBouwjaar.Text);
                Auto auto = new Auto(picbAuto, merk, bouwjaar);
                
                auto.inruilwaarde(lblWaarde);
                auto.teken();
            }
            catch (Exception)
            {
                MessageBox.Show("typ de goede waardes in");
            }        
        }
    }
}