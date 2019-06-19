using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim2
{
    public abstract class Plant : Leven
    {
        //
        // initialisatie
        //
        public Plant() { }
        public Plant(int verhoudingTicksJaren, string latijnseNaam, int levensduur, Bloeiwijze bloeiwijzePlant)
            : base(verhoudingTicksJaren, latijnseNaam, levensduur)
        {
            BloeiwijzePlant = bloeiwijzePlant;
        }

        //
        // eigenschapen
        //
        public Bloeiwijze BloeiwijzePlant { get; set; }
    }
}