using Corona_project;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NederlandsEnEngels
{
    public partial class frmNederlandsEngels : Form
    {
        private Button[] antwoordBtnsArray;
        private string antwoord;
        private int vraagIndex = 0, aantalVragen, aantalAntwoordBtns;
        private EngelsNederlandsVragen engelsvragen = new EngelsNederlandsVragen();
        private NederlandsEngelsVragen nederlandsvragen = new NederlandsEngelsVragen();
        private List<meerkeuzenVraag> vragen;

        public frmNederlandsEngels()
        {
            InitializeComponent();

            antwoordBtnsArray = new Button[] { btnAntwoord1, btnAntwoord2, btnAntwoord3, btnAntwoord4 };

            aantalAntwoordBtns = antwoordBtnsArray.Length;
        }

        private void frmNederlandsEngels_Load(object sender, EventArgs e)
        {
            //Messagebox
            DialogResult doorverbinding = MessageBox.Show("Wil je de Nederlandse doen klik op ja, Wil je Engels doen klik op nee", "Taal", MessageBoxButtons.YesNoCancel);
            if (doorverbinding == DialogResult.Yes)
            {
                // Als je Ja hebt gezegd (Nederlands
                lblTaalModus.Text = "Nederlands naar Engels opdrachten";
                this.Text = "Nederlands";
                vragen = nederlandsvragen.getNederlandsVragen();
                laadVraagKeuze();
            }
            else if (doorverbinding == DialogResult.No)
            {
                // Als er nee is gezegd (Engels)
                lblTaalModus.Text = "Engels naar Nederlands opdrachten";
                this.Text = "Engels opdrachten";
                vragen = engelsvragen.getEngelseVragen();
                laadVraagKeuze();
            }
            else
            {
                //Als er op cancel is gedrukt
                this.Close();
            }

        }

        public void laadVraagKeuze()
        {
            //logica
            aantalVragen = vragen.Count;
            vragen.Shuffle();
            laadVraag();
            progress();
        }

        public void laadVraag()
        {
            try
            {
                if (vraagIndex < aantalVragen)
                {
                    lblVragen.Text = UppercaseFirst(vragen[vraagIndex].getVraag());

                    for (int i = 0; i < aantalAntwoordBtns; i++)
                    {
                        antwoordBtnsArray[i].ForeColor = Color.Black;
                        antwoordBtnsArray[i].Visible = true;
                        antwoordBtnsArray[i].Text = UppercaseFirst(vragen[vraagIndex].getAntwoorden(i));

                        if (antwoordBtnsArray[i].Text == "")
                        {
                            antwoordBtnsArray[i].Visible = false;
                        }
                    }

                    antwoord = UppercaseFirst(vragen[vraagIndex].getCorrectAntwoord());
                }
                else
                {
                    antwoordenFlowPnl.Visible = false;
                    lblProgress.Visible = false;
                    lblVragen.Text = "Je hebt alle vragen beantwoord goed zo!";
                    lblVragen.Font = new Font(lblVragen.Font.FontFamily, 12F, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex);
            }
        }

        public string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void controlleerAntwoord(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < aantalAntwoordBtns; i++)
            {
                antwoordBtnsArray[i].ForeColor = Color.Black;
            }
            if (btn.Text == antwoord)
            {
                vraagIndex++;
                laadVraag();
                progress();
            }
            else
            {
                btn.ForeColor = Color.Red;
            }
        }

        public void progress()
        {
            lblProgress.Text = vraagIndex + 1 + "/" + aantalVragen;
        }
    }
}
