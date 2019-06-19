using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim2
{
    // blz 432 in geval van fouten
    public abstract class Planteneter : Dier
    {
        public Planteneter(int verhoudingTicksJaren, string latijnseNaam, int levensduur, double gewichtMaximaal)
            : base(verhoudingTicksJaren, latijnseNaam, levensduur, gewichtMaximaal) { }
        public override void Eet(Leven leven)
        {
            if (leven.IsPlant)
            {
                //wat doet een planteneter met giftige planten?
                if (WordtVergiftigdDoor.Contains(leven.NederlandseNaam))
                {
                    // normaal eet de planteneter geen giftige planten. behalve als de
                    // planteneter honger heeft. alleen gaat de planteneter dan wel dood.
                    // de planenteter eet een giftige plant en wordt verwijderd.
                    if (Honger())
                    {
                        this.Sterf();
                        leven.Sterf();
                    }
                    else
                    {
                        //als de plant diet eetbaar is, keer dan om
                        SnelheidObject = SnelheidObject.Keerom();
                    }
                }
                //alles wat niet giftig is wordt gewoon opgegeten als er nog plek is
                else if(MaagGevuld < 100)
                {
                    MaagGevuld = MaagGevuld + leven.Voedingswaarde;
                    leven.Sterf();
                }
            }
            //als het leven geen plant is keert de planteneter om.
            else
            {
                SnelheidObject = SnelheidObject.Keerom();
            }
        }
    }
}