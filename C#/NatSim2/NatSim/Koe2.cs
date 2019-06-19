using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;
//using System.Windows.Forms;

namespace NatSim2
{
    public class Koe2
    {
        //
        // initialisatie
        //
        //op blz 434 moet ik de code hier verwijderen, dat is zonder dus maak een nieuwe class Koe aan en verander deze classe naar Koe0

        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Verouder.Start();
        }

        public Koe2()
        {
            initClass(new Point(0, 0), "", Kleur);
        }

        public Koe2(Point locatie)
        {
            initClass(locatie, "", Kleur);
        }

        public Koe2(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }

        //
        // egenschappen
        //
        public string Naam { get; set; }
        public int AantalLitersMelk { get; set; }
        public DateTime Geboortedatum { get; set; }
        public double Gewicht { get; set; }
        public int Leeftijd { get; set; }
        public int MaagGevuld { get; set; }
        public DateTime Sterfdatum { get; set; }
        //
        // grafische eigenschappen
        //
        public Color Kleur { get; set; }
        public Point Locatie { get; set; }
        public int RichtingX { get; set; }
        public int RichtingY { get; set; }
        //
        // ReadOnly-eigenschappen specifiek voor de klasse koe
        //
        private Size _afmetingen = new Size(80, 40);
        private double _gewichtMaximaal = 450;
        private List<string> _wordtVergiftigdDoor = new List<string>() { "Venijnboom", "Vingerhoedskruid" };
        private string _latijnseNaam = "Bos taurus";
        private int _levensduur = 25;
        private string _nederlandseNaam = "Koe";
        private Timer _verouder = new Timer();
        private bool _verwijderd = false;

        public Size Afmetingen { get { return _afmetingen; } }
        public double GewichtMaximaal { get { return _gewichtMaximaal; } }
        public List<string> WordtVergiftigdDoor { get { return _wordtVergiftigdDoor; } }
        public string LatijnseNaam { get { return _latijnseNaam; } }
        public int Levensduur { get { return _levensduur; } }
        public string NederlandseNaam { get { return _nederlandseNaam; } }
        public Timer Verouder { get { return _verouder; } }
        public bool Verwijderd { get { return _verwijderd; } }

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