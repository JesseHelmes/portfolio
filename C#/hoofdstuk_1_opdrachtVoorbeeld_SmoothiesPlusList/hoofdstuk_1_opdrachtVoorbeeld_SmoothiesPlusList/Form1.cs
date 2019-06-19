using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace hoofdstuk_1_opdrachtVoorbeeld_SmoothiesPlus
{
    public partial class Form1 : Form
    {
        List<Ingrediënt> ingrediënten;
        Ingrediënt ingrediënt = new Ingrediënt();

    
        public Form1()
        {
            InitializeComponent();
        }

        private void fillLivIngrediënten()
        {
            // Deze methode vult de ListView "lsvTelefoons" op basis van de array telefoons

            // Eerst maken we de "lsvTelefoons" leeg
            livIngrediënt.Items.Clear();

            // vervolgens vullen we "lsvTelefoons" met behulp van de Array
            // telefoons

            foreach (var ingrediënt in ingrediënten)
            {
                // eerst maak je een nieuw ListViewItem aan.
                ListViewItem livIngrediëntItem = new ListViewItem(ingrediënt.Naam);

                // tot slot voeg je het nieuwe ListViewItem toe aan de listView
                livIngrediënt.Items.Add(livIngrediëntItem);
                livIngrediëntItem.SubItems.Add(ingrediënt.Kleur.Name);
                livIngrediëntItem.SubItems.Add(ingrediënt.LandVanHerkomst);
                livIngrediëntItem.SubItems.Add(ingrediënt.Calorieën.ToString());
                livIngrediëntItem.SubItems.Add(ingrediënt.PrijsPerKilo.ToString());
            }
        }

        private void opmaakLivIngrediënten()
        {
            livIngrediënt.OwnerDraw = true;
            livIngrediënt.View = View.Details;
            ColumnHeader headerName = livIngrediënt.Columns.Add("Naam", 75);
            ColumnHeader headerKleur = livIngrediënt.Columns.Add("Kleur", 80);
            ColumnHeader headerLandVanHerkomst = livIngrediënt.Columns.Add("Land van herkomst", 150);
            ColumnHeader headerCalorieën = livIngrediënt.Columns.Add("Calorieën", 70);
            ColumnHeader headerPrijsPerKilo = livIngrediënt.Columns.Add("Prijs per kilo", -2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ingrediënten = defaultIngrediëntenList();
            fillLivIngrediënten();
            opmaakLivIngrediënten();
            btnZoek.BackColor = Color.PaleTurquoise;
            btnWisSelectie.BackColor = Color.PaleTurquoise;
            btnWisIngrediënt.BackColor = Color.LightCoral;
            btnDefaultLijst.BackColor = Color.PaleTurquoise;
            btnExit.BackColor = Color.LightCoral;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void livIngrediënt_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            Font headerFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            e.Graphics.FillRectangle(Brushes.Turquoise, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, stringFormat);
        }

        
        private void livIngrediënt_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;

            Font subItemFont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            Brush regelKleur = Brushes.PaleTurquoise;
            if(e.Item.Selected == true)
            {
                regelKleur = Brushes.SteelBlue;
            }
            //if(e.ItemIndex % 2 ==1 ) // oneven getal
            else
            {
                regelKleur = Brushes.WhiteSmoke;
            }
            e.Graphics.FillRectangle(regelKleur, e.Bounds);
            e.Graphics.DrawString(e.SubItem.Text, subItemFont, Brushes.Black, e.Bounds, stringFormat);
        }

        private void txtIngrediënt_TextChanged(object sender, EventArgs e)
        {
            ingrediënt.Naam = txtIngrediënt.Text;
        }

        /*private int zoekIngrediënt(Ingrediënt ingrediënt)
        {
            int index = 0;

            while(index < ingrediënten.Length)
            {
                if(ingrediënten[index] == ingrediënt)
                {
                    break;
                }
                index++;
            }

            if (index == ingrediënten.Length) index = -1;

            return index;
         }*/

        private int voegIngrediëntToe(Ingrediënt ingrediënt)
        {
            /*int grootte = ingrediënten.Length + 1;
            int positie = 0;
            Array.Resize(ref ingrediënten, grootte);
            positie = grootte - 1;
            ingrediënten[positie] = ingrediënt;

            return grootte - 1;*/

            //toevoegen van een nieuw ingrediënt. een element wordt altijd
            // als laaste toegevoegd aan de List
            ingrediënten.Add(ingrediënt);
            return ingrediënten.LastIndexOf(ingrediënt);
        }

        private void selecteerIngrediënt()
        {
            int positie = ingrediënten.IndexOf(ingrediënt);

            if(positie == -1)
            {
                if(MessageBox.Show(ingrediënt.ToString() + " komt niet voor." +
                    Environment.NewLine + Environment.NewLine +
                    "Nieuw ingrediënt " + ingrediënt.Naam + " aanmaken?", "Waarschuwing", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                    , MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    voegIngrediëntToe(ingrediënt);
                    fillLivIngrediënten();
                    selecteerIngrediënt();
                    synchroniseerTextBoxenMetList();
                    ingrediënt = new Ingrediënt();
                }
            }
            else
            {
                livIngrediënt.Items[positie].Selected = true;
                livIngrediënt.Items[positie].Focused = true;
            }
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            selecteerIngrediënt();
        }

        private void deSelecteerIngrediënten()
        {
            for(int i = 0; i < livIngrediënt.Items.Count; i++)
            {
                livIngrediënt.Items[i].Selected = false;
            }
            maakTextBoxenLeeg();
        }

        private void btnWisSelectie_Click(object sender, EventArgs e)
        {
            deSelecteerIngrediënten();
        }

        /*private void verwijderIngrediëntUitIngrediëntenArray(int startPositie)
        {
            int grootte = ingrediënten.Length - 1;
            for(int positie = startPositie; positie < grootte; positie++)
            {
                ingrediënten[positie] = ingrediënten[positie + 1];
            }
            Array.Resize(ref ingrediënten, grootte);
        }*/

        private void verwijderGeselecteerdeIngrediënten()
        {
            for(int i = 0; i < livIngrediënt.Items.Count; i++)
            {
                if(livIngrediënt.Items[i].Selected == true)
                {
                    livIngrediënt.Items[i].Remove();
                    //verwijderIngrediëntUitIngrediëntenArray(i);
                    ingrediënten.RemoveAt(i);
                    i = i - 1;
                }
            }
            this.Refresh();
        }

        private void btnWisIngrediënt_Click(object sender, EventArgs e)
        {
            verwijderGeselecteerdeIngrediënten();
            maakTextBoxenLeeg();
        }

        private List<Ingrediënt> defaultIngrediëntenList()
        {
            List<Ingrediënt> defaultIngrediënten = new List<Ingrediënt>();
            //string[] defaultIngrediënten = { "Meloen", "Apple", "Peer", "Aardbei", "Mandarijn", "Banaan" };
            defaultIngrediënten.Add( new Ingrediënt("Apple", Color.Green, "Nederland", 10, 1.76));
            defaultIngrediënten.Add( new Ingrediënt("Peer", Color.Green, "Luxemburg", 10, 1.71));
            defaultIngrediënten.Add( new Ingrediënt("Meloen", Color.Orange, "België", 15, 2.15));
            defaultIngrediënten.Add( new Ingrediënt("Aardbei", Color.Red, "Israël", 5, 12.50));
            defaultIngrediënten.Add( new Ingrediënt("Framboos", Color.IndianRed, "België", 7, 7.33));  
            defaultIngrediënten.Add( new Ingrediënt("Rode bes", Color.Red, "Frankrijk", 17, 14.10));
            // Teruggeven van de array
            return defaultIngrediënten;
        }

        private void btnDefaultLijst_Click(object sender, EventArgs e)
        {
            ingrediënten = defaultIngrediëntenList();
            fillLivIngrediënten();
        }

        private void livIngrediënt_Click(object sender, EventArgs e)
        {
            synchroniseerTextBoxenMetList();
        }

        private void txtLandVanHerkomst_TextChanged(object sender, EventArgs e)
        {
            ingrediënt.LandVanHerkomst = txtLandVanHerkomst.Text;
        }

        private void txtCalorieën_TextChanged(object sender, EventArgs e)
        {
            // als er iets is ingevoerd in de textbox is de lengte van de tekst > 0
            if(txtCalorieën.Text.Length > 0)
            {
                try
                {
                    ingrediënt.Calorieën = int.Parse(txtCalorieën.Text);
                    errorProvider1.SetError(txtCalorieën, "");
                }
                catch (Exception exception)
                {
                    errorProvider1.SetError(txtCalorieën, exception.Message);
                }
            }
        }

        private void txtPrijsPerKilo_TextChanged(object sender, EventArgs e)
        {
            // als er iets is ingevoerd in de textbox is de lengte van de tekst > 0
            if (txtPrijsPerKilo.Text.Length > 0)
            {
                try
                {
                    ingrediënt.PrijsPerKilo = double.Parse(txtPrijsPerKilo.Text);
                    errorProvider1.SetError(txtPrijsPerKilo, "");
                }
                catch (Exception exception)
                {
                    errorProvider1.SetError(txtPrijsPerKilo, exception.Message);
                }
            }
        }

        private void btnKleurIngrediënt_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ingrediënt.Kleur = colorDialog1.Color;
                btnKleurIngrediënt.BackColor = ingrediënt.Kleur;
                btnKleurIngrediënt.Text = ingrediënt.Kleur.Name;
            }
        }

        private void btnKleurIngrediënt_TextChanged(object sender, EventArgs e)
        {
            ingrediënt.Kleur = Color.FromName(btnKleurIngrediënt.Text);
            btnKleurIngrediënt.BackColor = ingrediënt.Kleur;
        }

        private void synchroniseerTextBoxenMetList()
        {
            // opnieuw initialiseren van de variable ingrediënt
            ingrediënt = new Ingrediënt();

            //synchroniseren van de TextBoxen met de ListView
            txtIngrediënt.Text = livIngrediënt.FocusedItem.SubItems[0].Text;
            btnKleurIngrediënt.Text = livIngrediënt.FocusedItem.SubItems[1].Text;
            btnKleurIngrediënt.BackColor = ingrediënten[livIngrediënt.FocusedItem.Index].Kleur;
            txtLandVanHerkomst.Text = livIngrediënt.FocusedItem.SubItems[2].Text;
            txtCalorieën.Text = livIngrediënt.FocusedItem.SubItems[3].Text;
            txtPrijsPerKilo.Text = livIngrediënt.FocusedItem.SubItems[4].Text;
        }

        private void maakTextBoxenLeeg()
        {
            txtCalorieën.Text = "";
            txtIngrediënt.Clear();
            txtLandVanHerkomst.Clear();
            txtPrijsPerKilo.Text = "";
            btnKleurIngrediënt.Text = "";
        }
    }
}