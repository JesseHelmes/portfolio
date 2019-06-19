﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim2
{
    public class Konijn : Planteneter
    {
        //
        // initialisatie
        //
        public Konijn()
            : base(_verhoudingTicksJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal)
        {
            initClass(new Point(0, 0), "", Color.Brown);
        }
        public Konijn(Point locatie)
            : base(_verhoudingTicksJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal)
        {
            initClass(locatie, "", Color.Brown);
        }
        public Konijn(Point locatie, string naam, Color kleur)
            : base(_verhoudingTicksJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal)
        {
            initClass(locatie, naam, kleur);
        }
        //
        // hier stel je de kenmerken van een konijn in
        //
        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            Tekengebied.Afmetingen = new Size(10, 10);
            WordtVergiftigdDoor.Add("Vingerhoedskruid");
            WordtVergiftigdDoor.Add("Venijnboom");
            Gewicht = 5;
            Voedingswaarde = 1;
        }
        //voor ieder konijn gelden de volgende waardes. vandaar dat
        // deze in een constante worden opgeslagen: het zijn onveranderlijke variabelen.
        //deze constanten worden weer doorgegeven aan de klassen waarvan geërfd wordt.
        private const string _latijnseNaam = "Oryctolagus cuniculus";
        private const int _leeftijd = 9;
        private const int _verhoudingTicksJaren = 1;
        private const double _gewichtMaximaal = 10;

        //
        // eigenschappen
        //
        public string Naam { get; set; }
        public double Gewicht { get; set; }
        public DateTime Geboortedatum { get; set; }
        public DateTime Sterfdatum { get; set; }
    }
}