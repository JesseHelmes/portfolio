using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eindopdracht_periode_4_museum_applicatie
{
    public partial class FrmMainMenu : Form
    {

        public FrmMainMenu()
        {
            InitializeComponent();
        }
  
        private void btnHome_Click(object sender, EventArgs e)
        {
            showPanel(sender, e);
        }

        private void brnSchilderij_Click(object sender, EventArgs e)
        {
            showPanel(sender, e);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            showPanel(sender, e);
        }

        private void btnArcheologischeVondsten_Click(object sender, EventArgs e)
        {
            showPanel(sender, e);
        }

        private void btnStandbeeld_Click(object sender, EventArgs e)
        {
            showPanel(sender, e);
        }

        private void showPanel(object sender, EventArgs e)
        {
            // haal de knop op waar op geklikt is.
            Button btn = (Button)sender;
            // pak de naam van de button zonder de "btn" afkorting
            string buttonName = btn.Name.Substring(3);
            // zoek alle controls met de naam pnl en de naam van de knop.
            Control[] controls = Controls.Find("pnl" + buttonName, true);
            // haal het Panel uit de lijst met gevonden controls. Kan er maar 1 zijn, dus 0.
            Panel p = (Panel)controls[0];
            //breng het bijbehorende paneel naar voren.
            p.BringToFront();
            // past de breedte zo aan dat het zelfde is als de button
            pnlCurrent.Width = btn.Width;
            // verplaats de gele strip naar de onderkant van de knop waar op geklikt is
            pnlCurrent.Location = new Point(btn.Location.X, pnlCurrent.Location.Y);
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            showPanel(btnHome, e);
        }
    }
}
