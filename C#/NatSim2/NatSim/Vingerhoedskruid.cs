using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace NatSim2
{
    class Vingerhoedskruid : Plant
    {
        //
        // initialisatie
        //
        public Vingerhoedskruid()
            : base(4, "Digitalis Purpurea", 4, Bloeiwijze.tros)
        {
            initClass(new Point(0, 0));
        }
        public Vingerhoedskruid(Point locatie)
            : base(4, "Digitalis Purpurea", 4, Bloeiwijze.tros)
        {
            initClass(locatie);
        }

        private void initClass(Point locatie)
        {
            Locatie = locatie;
            // wat hier onder staar is niet goed
            Tekengebied.Afmetingen = new Size(10, 400);
            Kleur = Color.ForestGreen;
        }
    }
}