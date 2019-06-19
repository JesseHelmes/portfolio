using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim2
{
    public abstract class Dier : Leven
    {
        //
        // constructor
        //
        public Dier(int verhoudingTicksJaren, string latijnseNaam, int levensduur, double gewichtMaximaal)
            : base(verhoudingTicksJaren, latijnseNaam, levensduur)
        {
            initDier(gewichtMaximaal);
        }

        private void initDier(double gewichtMaximaal)
        {
            _gewichtMaximaal = gewichtMaximaal;
            WordtVergiftigdDoor = new List<string>();
        }

        //
        // private variabelen
        //
        // maximaal gewicht van een dier in kg
        private double _gewichtMaximaal = 0;

        //
        // eigenschappen voor alle dieren
        //
        // van 0 tot 100% (honger tot 75%)
        public int MaagGevuld { get; set; }
        //aantal ticks dat het duurt voordat een maaltijd verteerd is
        public int SpijsverteringsDuur { get; set; }
        // maximaal gewicht van een dier in kg
        public double GewichtMaximaal { get { return _gewichtMaximaal; } }
        public List<string> WordtVergiftigdDoor { get; set; }
        public Snelheid SnelheidObject { get; set; }

        //
        // methoden
        //
        //een kenmerk van dieren is dat ze eten. op dit niveau weten we nog niet wat.
        // een konijn zal geen lynx eten, andersom wel en een lynx zal geen gras eten.
        public abstract void Eet(Leven leven);
        // dieren zullen wel, net als in NatSim, alleen eten als ze honger hebben:
        public bool Honger()
        {
            return (MaagGevuld < 25);
        }
    }
}