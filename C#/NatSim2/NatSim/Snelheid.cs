using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim2
{
    public enum Vlak
    {
        Horizontaal,
        Verticaal,
        Hoek,
        Geen
    }
    public struct Snelheid
    {
        // Initialisatie
        public Snelheid(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        // Eigenschappen
        public int X { get; set; }
        public int Y { get; set; }

        //methoden
        // Keerom: het object gaat deelfde weg terug.
        public Snelheid Keerom()
        {
            X = -1 * X;
            Y = -1 * Y;
            return new Snelheid(X, Y);
        }

        public Snelheid Stuiter(Vlak vlak)
        {
            /* Stuiter: als een object tegen een horizontaal vlak, boven of beneden,
             botst, wordt de y-component van de snelheid omgedraaid.
             als een object tegen een verticale vlak, links of rechts,
             botst, wordt de x-componennt van de snelheid omgedraaid.
             bij een botsing precies in een hoek, worden beide componenten omgedraaid. */
            switch (vlak)
            {
                case Vlak.Horizontaal:
                    Y = -1 * Y;
                    break;
                case Vlak.Verticaal:
                    X = -1 * X;
                    break;
                case Vlak.Hoek:
                    X = -1 * X;
                    Y = -1 * Y;
                    break;
            }
            return new Snelheid(X, Y);
        }
    }
}