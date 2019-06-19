using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim2
{
    class Venijnboom : Plant
    {
        //
        // initialisatie
        //
        public Venijnboom()
            : base(1, "Taxus baccata", 2000, Bloeiwijze.kegel)
        {
            initClass(new Point(0, 0));
        }
        public Venijnboom(Point locatie)
            : base(1, "Taxus baccata", 2000, Bloeiwijze.kegel)
        {
            initClass(locatie);
        }

        private void initClass(Point locatie)
        {
            Locatie = locatie;
            Tekengebied.Afmetingen = new Size(10, 400);
            Kleur = Color.ForestGreen;
        }

        //
        // variabelen
        //
        private List<string> _geneesmiddelVoor = new List<string> { "Longkanker", "Borstkanker" };
        private int _maximaleGrootte = 20000;

        //
        //ReadOnly-egenschappen
        //
        public List<string> GeneesmiddelVoor { get { return _geneesmiddelVoor; } }
        public int MaximaleGrootte { get { return _maximaleGrootte; } }

        //
        //eigenschappen
        //
        public double AantalKubiekeMetersHout { get; set; }
    }
}