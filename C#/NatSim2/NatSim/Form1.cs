using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSim2
{
    public partial class FrmNatSim2 : Form
    {
        // blz 435 de fout met timer moet je negeren dat wordt later opgelost er is dus niks aan de hand
        // als er een fout in constructor zit bij gras en venijnboom lees dan blz 393 onderaan

        //
        // initialisatie
        //
        Graphics papier;

        public FrmNatSim2()
        {
            InitializeComponent();
            papier = pbWereld.CreateGraphics();
        }


        private void ResizePictureBox()
        {
            // dezze method zorgt ervoor dat, zodra de groote van het
            // formulier wijzigt, de groote van de PictureBox pbWereld zo
            // wordt aangepast dat het formulier optimaal gevuld wordt
            int margeBreedte = 40;
            int margeHoogte = 64;
            pbWereld.Width = this.Width - grbDieren.Width - grbPlanten.Width - margeBreedte;
            pbWereld.Height = this.Height - margeHoogte;
            papier = pbWereld.CreateGraphics();
        }

        private void ResizeLblInformatie()
        {
            // dezze method zorgt ervoor dat, zodra de groote van het
            // formulier wijzigt, de groote van de informatieLabel lblInfo zo
            // wordt aangepast dat het formulier optimaal gevuld wordt
            int margeHoogte = 88;
            lblInformatie.Height = this.Height - margeHoogte - pnlKoppen.Height;
        }

        private void FrmNatSim_Resize(object sender, EventArgs e)
        {
            // het event Resize dat afgevuurd (getriggerd) wordt:
            ResizePictureBox();
            ResizeLblInformatie();
        }

        private void pbWereld_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)
            {
                TekenDier(e.Location);
            }

            if (e.Button == MouseButtons.Right)
            {
                TekenGroen(e.Location);
            }
        }

        private void TekenDier(Point positie)
        {
            if(rdbKonijn.Checked == true)
            {
                Konijn konijn01 = new Konijn(positie, "Flappie", Color.Brown);
                konijn01.Teken(pbWereld.CreateGraphics());
            }

            if (rdbKoe.Checked == true)
            {
                Koe koe01 = new Koe(positie, "melk fabriek", Color.Black);
                koe01.Teken(pbWereld.CreateGraphics());
            }
        }

        private void TekenGroen(Point positie)
        {
            if(rdbGras.Checked == true)
            {
                Gras gras01 = new Gras(positie);
                gras01.Teken(pbWereld.CreateGraphics());
            }

            if(rdbVenijnboom.Checked == true)
            {
                Venijnboom2 venijnboom01 = new Venijnboom2(positie);
                venijnboom01.Teken(pbWereld.CreateGraphics());
            }
        }
    }
}