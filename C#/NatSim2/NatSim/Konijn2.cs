using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
//using System.Windows.Forms;

namespace NatSim2
{
    public class Konijn2
    {
        //
        // initialisatie
        //
        //op blz 434 moet ik de code hier verwijderen, dat is zonder dus maak een nieuwe class Konijn aan en verander deze classe naar Konijn0

        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Verouder.Start();
        }

        public Konijn2()
        {
            initClass(new Point(0, 0), "", Kleur);
        }

        public Konijn2(Point locatie)
        {
            initClass(locatie, "", Kleur);
        }

        public Konijn2(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }

        // Private variabelen
        //
        // Algemene gegevens
        //
        private string _latijnseNaam = "Oryctolagus cuniculus"; // Latijnse naam van de soort

        private string _nederlandseNaam = "Konijn";             //naam van de soort
        private double _gewichtMaximaal = 5;                    // Maximaal gewicht van de konijn in kg

        private int _levensduur = 9;                            // De maximale levensduur van een konijn

        private List<string> _wordtVergiftigdDoor =
            new List<string>() { "Venijnboom, Vingerhoedskruid" };// een lijst met planten 
                                                                  // die giftig zijn voor een konijn

        //
        // Objectspecifieke gegevens
        //
        private string _naam = "";                                // de naam van een konijn, bijvoorbeeld Flappie

        private double _gewicht = 3;                              // het gewicht van Flappie
        private int _maagGevuld = 0;                              // voor hoeveel procent is de maag gevuld?
        private int _voedingswaarde = 0;                          // hoeveel voedingswaarde heeft Flappie
        private Timer _verouder = new Timer(1000);                // Flappie wordt ouder:
                                                                  // 1000 ticks = 1 sec = 1 jaar.
        private int _leeftijd = 0;                                // de leeftijd van Flappie
        private DateTime _geboortedatum;                          // de geboortedatum van Flappie
        private DateTime _sterfdatum;                             // de datum dat Flappie gestorven is
        //
        // Grafische informatie
        //
        private Size _afmetingen = new Size(10, 10);                // hoe groot is Flappie op het scherm?
        private bool _verwijderd = false;                         // is Flappie verwijderd?
        private Color _kleur = Color.Brown;                       // de kleur van Flappie
        private Point _locatie = new Point(0, 0);                 // waar bevindt Flappie zich?
        private int _richtingX = 0;                               // in welke X-asrichting beweegt
                                                                  // Flappie zich met welke snelheid?
        private int _richtingY = 0;                               // in welke Y-asrichting beweegt
                                                                  // Flappie zich met welke snelheid?
        
        //
        // Eigenschappen
        //

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Leeftijd
        {
            get { return _leeftijd; }
            set { _leeftijd = value; }
        }

        public double Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }

        public int MaagGevuld
        {
            get { return _maagGevuld; }
            set { _maagGevuld = value; }
        }

        public int Voedingswaarde
        {
            get { return _voedingswaarde; }
            set { _voedingswaarde = value; }
        }

        public DateTime Geboortedatum
        {
            get { return _geboortedatum; }
            set { _geboortedatum = value; }
        }

        public DateTime Sterfdatum
        {
            get { return _sterfdatum; }
            set { _sterfdatum = value; }
        }

        //
        // Grafische eigenschappen
        //

        public Size Afmetingen
        {
            get { return _afmetingen; }
            set { _afmetingen = value;}
        }

        public Color Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        public Point Locatie
        {
            get { return _locatie; }
            set { _locatie = value; }
        }

        public int RichtingX
        {
            get { return _richtingX; }
            set { _richtingX = value; }
        }

        public int RichtingY
        {
            get { return _richtingY; }
            set { _richtingY = value; }
        }

        //
        // Readonly-egenschappen specifiek voor konijnen
        //

        public string NederlandseNaam
        {
            get { return _nederlandseNaam; }
        }

        public string LatijnseNaam
        {
            get { return _latijnseNaam; }
        }

        public double GewichtMaximaal
        {
            get { return _gewichtMaximaal; }
        }

        public int Levensduur
        {
            get { return _levensduur; }
        }

        public bool Verwijderd
        {
            get { return _verwijderd; }
        }

        public List<string> WordtVergiftigdDoor
        {
            get { return _wordtVergiftigdDoor; }
        }

        public Timer Verouder
        {
            get { return _verouder; }
        }

        //
        // methoden
        //

        public void Verwijder()
        {
            _verwijderd = true;
        }

        public void Eet(Object voedsel)
        {
            // bepalen wat voor voedsel het is, gras of venijnboom
            if(voedsel.GetType() == typeof(Gras))
            {
                eetGras((Gras)voedsel);
            }

            else if (voedsel.GetType() == typeof(Venijnboom2))
            {
                eetVenijnBoom((Venijnboom2)voedsel);
            }
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

        //private methoden
        private bool honger()
        {
            return (MaagGevuld < 25);
        }

        private void eetGras(Gras voedsel)
        {
            if (WordtVergiftigdDoor.Contains(voedsel.NederlandseNaam))
            {
                if (honger())
                {
                    Verwijder();
                }
            }

            else if (MaagGevuld < 100)
            {
                // De maag wordt aangevuld met de voedingswaarde van het voedsel
                MaagGevuld = MaagGevuld + voedsel.Voedingswaarde;

                // een maag kan nooit meet dan 100% gevuld zijn
                if (MaagGevuld > 100)
                {
                    MaagGevuld = 100;
                }

                // uiteraard wordt het voedsel na de maaltijd verwijderd uit de simulaties:
                voedsel.Verwijder();
            }
        }

        private void eetVenijnBoom(Venijnboom2 voedsel)
        {
            if (WordtVergiftigdDoor.Contains(voedsel.NederlandseNaam))
            {
                if (honger())
                {
                    Verwijder();
                }
            }

            else if (MaagGevuld < 100)
            {
                // De maag wordt aangevuld met de voedingswaarde van het voedsel
                MaagGevuld = MaagGevuld + voedsel.Voedingswaarde;

                // een maag kan nooit meet dan 100% gevuld zijn
                if (MaagGevuld > 100)
                {
                    MaagGevuld = 100;
                }

                // uiteraard wordt het voedsel na de maaltijd verwijderd uit de simulaties:
                voedsel.Verwijder();
            }
        } 
    }
}