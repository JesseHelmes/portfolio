using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSim2
{
    public abstract class Leven : GrafischObject
    {
        // initialisatie
        public Leven()
        {
            /* in dit geval wordt iets van het type klasse aangemaakt zonder parameters
              omdat er ook een timer wordt geïnstallerd die het object automatisch
              weer laat verdwijnen, stellen we de levensduur in op de grooste waarde. */
            initClass(1, "", int.MaxValue);
        }
        public Leven(int verhoudingTicksJaren, string latijnseNaam, int levensduur)
        {
            initClass(verhoudingTicksJaren, latijnseNaam, levensduur);
        }

        private void initClass(int verhoudingTicksJaren, string latijnseNaam, int levensduur)
        {
            VerhoudingTicksJaren = verhoudingTicksJaren;
            //instellen ReadOnly-variabelen
            _latijnseNaam = latijnseNaam;
            _levensduur = levensduur;
            _verouder = new Timer();
            _verouder.Interval = _aantalTicksPerSeconde * verhoudingTicksJaren;
        }

        // interne variabelen
        private const int _aantalTicksPerSeconde = 1000;
        private string _latijnseNaam;
        private double _levensduur;
        private Timer _verouder;

        // eigenschappen
        public int Leeftijd { get; set; }
        public int VerhoudingTicksJaren { get; set; }
        public int Voedingswaarde { get; set; }

        //ReadOnly-eigenschappen
        public string LatijnseNaam { get { return _latijnseNaam; } }
        public double Levensduur { get{ return _levensduur; } }
        public string NederlandseNaam { get { return this.ToString().Split('.').Last(); } }
        public Timer Verouder { get { return _verouder; } }

        //methoden
        public void Sterf()
        {
            Verwijder();
        }

        public bool IsPlant
        {
            //deze code kijkt of het type van het object erft van Plant
            // en geeft het resultaat terug.
            // met GetType bepaald je het type van het object.
            // met IsSubClassof bekijk je of deze klazze erft van, in dit geval Plant:
            get { return this.GetType().IsSubclassOf(typeof(Plant)); }
        }

        public bool IsDier
        {
            //deze code kijkt of het type van het object erft van Dier
            // en geeft het resultaat terug.
            get { return this.GetType().IsSubclassOf(typeof(Dier)); }
        }
    }
}