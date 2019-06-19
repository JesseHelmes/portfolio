using System.Collections.Generic;
using System.Drawing;
using System.Timers;
//using System.Windows.Forms;

namespace NatSim2
{
    public class Venijnboom2
    {

        //
        // initialisatie
        //

            //naam en kleur laten zitten dat wordt gebruikt in conctructor
        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            //Naam = naam;
            //Kleur = kleur;
            Verouder.Start();
        }

        public Venijnboom2()
        {
            initClass(new Point(0, 0), "", Kleur);
        }

        public Venijnboom2(Point locatie)
        {
            initClass(locatie, "", Kleur);
        }

        /*public Venijnboom(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }*/

        //deze vind ik zelf vijner ik weet dan wat ik moet toe voegen, ik kan namelijk de sneller werken omdat ik alles kan zien
        //
        // egenschappen
        //
        public double AantalKubiekeMetersHout { get; set; }
        public int Leeftijd { get; set; }
        
        //
        // grafische eigenschappen
        //
        public Point Locatie { get; set; }
        
        //
        // ReadOnly-eigenschappen specifiek voor de klasse koe
        //
        private Size _afmetingen = new Size(10, 400);
        private Bloeiwijze _bloeiwijzePlant = Bloeiwijze.kegel;
        private List<string> _geneesmiddelVoor = new List<string>() { "longkanker", "borstkanker" };
        private Color _kleur = Color.ForestGreen;
        private string _latijnseNaam = "Taxus bacatta";
        private int _levensduur = 2200;
        private int _maximaleGrootte = 20000;
        private string _nerderlandseNaam = "Venijnboom";
        private Timer _verouder = new Timer(1000);
        private bool _verwijderd = false;
        private int _voedingswaarde = 0;

        public Size Afmetingen { get { return _afmetingen; } }
        public Bloeiwijze BloeiwijzePlant { get { return _bloeiwijzePlant; } }
        public List<string> GeneesmiddelVoor { get { return _geneesmiddelVoor; } }
        public Color Kleur { get { return _kleur; } }
        public string LatijnseNaam { get { return _latijnseNaam; } }
        public int Levensduur { get { return _levensduur; } }
        public int MaximaleGrootte { get { return _maximaleGrootte; } }
        public string NederlandseNaam { get { return _nerderlandseNaam; } }
        public Timer Verouder { get { return _verouder; } }
        public bool Verwijderd { get { return _verwijderd; } }
        public int Voedingswaarde { get { return _voedingswaarde; } }

        //
        // methoden
        //

        public void Verwijder()
        {
            _verwijderd = true;
        }

        public void Teken(Graphics graphics)
        {
            // het teken van een kader op de locatie van het object mat de afmetigen
            // van het object.
            Pen pen = new Pen(Color.Black, 2);
            // omdat Windows de hoogte van boven naar beneden berekent en een rechthoek
            // ook van boven naar beneden wordt getekend, maar het voor de gebruiker
            // natuurlijker aanvoelt om van beneden naar boven te tekenen gebruiken we een
            // variabele die een nieuwe starthoogte berekent om vandaar de rechthoek te tekenen.
            int startHoogte = Locatie.Y - Afmetingen.Height;
            // Tekenen van de rechthoek
            graphics.DrawRectangle(pen, Locatie.X, startHoogte, Afmetingen.Width, Afmetingen.Height);
            // met dispose verwijder je de variaele direct uit het geheugen en maak je ruimte vrij
            pen.Dispose();

            //het vullen van de rechthoek op de locatie van het object met de afmetigen
            // van het object.
            SolidBrush kwast = new SolidBrush(Kleur);
            graphics.FillRectangle(kwast, Locatie.X, startHoogte, Afmetingen.Width, Afmetingen.Height);
            // het direct vrijgeven van het geheugen van een gebruikt object.
            kwast.Dispose();
        }
    }
}
