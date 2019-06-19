using System.Drawing;
using System.Timers;
//using System.Windows.Forms;

namespace NatSim2
{
    public enum Bloeiwijze
    {
        none,
        hoofdje,
        bloemkoek,
        bloemkluwen,
        aar,
        aartje,
        katje,
        bloeikolf,
        tros,
        schermvormigeTros,
        bundel,
        scherm,
        schijnkrans,
        eentakkigBijscherm,
        schroef,
        sikkel,
        schicht,
        waaier,
        samengesteldScherm,
        samengesteldGevorktScherm,
        samengesteldeAar,
        pluim,
        dichasialePluim,
        tuil,
        dichasialeTuil,
        thyrsus,
        kegel
    }

    public class Gras2
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

        public Gras2()
        {
            initClass(new Point(0, 0), "", Kleur);
        }

        public Gras2(Point locatie)
        {
            initClass(locatie, "", Kleur);
        }

        public Gras2(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }

        // Private variabelen
        //
        // Algemene gegevens
        //
        private string _latijnseNaam = "Gramineae"; // Latijnse naam van de soort

        private string _nederlandseNaam = "Gras";             //naam van de soort

        private Bloeiwijze _bloeiwijzePlant = Bloeiwijze.aar;

        private int _leeftijd;


        //
        // Objectspecifieke gegevens
        //

        private int _levensduur = 4;
        private Timer _verouder = new Timer(1000);
        private int _voedingswaarde = 1;

        //
        // Grafische informatie
        //
        private Size _afmetingen = new Size(2, 4);
        private Color _kleur = Color.LawnGreen;
        private Point _locatie = new Point(0, 0);
        private bool _verwijderd = false;


        //
        // Eigenschappen
        //

        public int Leeftijd
        {
            get { return _leeftijd; }
            set { _leeftijd = value; }
        }

        //
        // Grafische eigenschappen
        //

        public Point Locatie
        {
            get { return _locatie; }
            set { _locatie = value; }
        }


        //
        // Readonly-egenschappen specifiek voor gras
        //

        public string NederlandseNaam
        {
            get { return _nederlandseNaam; }
        }

        public string LatijnseNaam
        {
            get { return _latijnseNaam; }
        }

        public Size Afmetingen
        {
            get { return _afmetingen; }
        }

        public Bloeiwijze BloeiwijzePlant
        {
            get { return _bloeiwijzePlant; }
        }

        public Color Kleur
        {
            get { return _kleur; }
        }

        public int Levensduur
        {
            get { return _levensduur; }
        }

        public Timer Verouder
        {
            get { return _verouder; }
        }

        public bool Verwijderd
        {
            get { return _verwijderd; }
        }

        public int Voedingswaarde
        {
            get { return _voedingswaarde; }
        }

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
