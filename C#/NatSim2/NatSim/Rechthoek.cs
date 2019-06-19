using System.Drawing;

namespace NatSim2
{
    public class Rechthoek
    {
        /* een meetkunde rechthoek bestaat uit 4 punten A, B, C en D
         
        A(10,4----------------B(30, 4)
        |                     |
        |                     |
        C(10,26)--------------D(30,26)

        waarbij:
        - de X-waarde van A gelijk is aan de X-waarde van C (10)
        - de Y-waarde van A gelijk is aan de Y-waarde van B (4)
        - de X-waarde van D gelijk is aan de X-waarde van B (30)
        - de Y-waarde van D gelijk is aan de Y-waarde van C (26)

        het punt A is gelijk aan de locatie waar geklikt wordt.
        de andere punten worden op basis van de gegeven afmetingen
        (breedte en hoogte)

        deze klasse heeft methoden die bepalen of de ene rechthoek
        een andere rechthoek raakt.*/

        // constructor
        public Rechthoek() { }
        public Rechthoek(Point locatie, Size afmetingen)
        {
            Locatie = locatie;
            Afmetingen = afmetingen;
        }

        public Size Afmetingen { get; set; }
        public Point A { get; set; }
        public Point B { get { return new Point(A.X + Breedte, A.Y); } }
        public Point C { get { return new Point(A.X, A.Y + Hoogte); } }
        public Point D { get { return new Point(B.X , C.Y); } }

        // de Locatie vanwaar getekend wordt, is gelijk aan punt A.
        public Point Locatie
        {
            get
            {
                return A;
            }
            set
            {
                A = value;
            }
        }

        public int Breedte
        {
            get { return Afmetingen.Width; }
        }
        public int Hoogte
        {
            get { return Afmetingen.Height; }
        }

        // statische methode om te onderzoeken of 2 objecten van het type rechthoek
        // elkaar raken. deze methode kan statisch zijn omdat alle parameters worden
        // meegegeven aan de methode.
        public static Vlak GrensBereikt(Rechthoek rechthoek1, Rechthoek rechthoek2)
        {
            Vlak vlak = Vlak.Geen;

            // overschrijden linker- of rechterkant
            if(rechthoek1.A.X <= rechthoek2.A.X || rechthoek1.B.X >= rechthoek2.B.X)
            {
                vlak = Vlak.Verticaal;
            }

            // overschrijden onder - of bovenrand
            if(rechthoek1.A.Y <= rechthoek2.A.Y || rechthoek1.C.Y >= rechthoek2.C.Y)
            {
                if(vlak == Vlak.Verticaal)
                {
                    vlak = Vlak.Hoek;
                }
                else
                {
                    vlak = Vlak.Horizontaal;
                }
            }
            return vlak;
        }

        // de volgende methode onderzoekt of een andere rechtoek de huidige instantie
        // van Rechthoek raakt.
        // omdat gebruikgemaakt wordt van de variabelen van de huidige instantie
        // Rechthoek kan deze methode niet statisch zijn.
        public Vlak GrensBereik(Rechthoek Rechthoek2)
        {
            // Rechthoek2 is de huidige instantie van de klasse Rechthoek en deze wordt
            // aangeroepen met het woord this.
            return GrensBereikt(this, Rechthoek2);
        }

        // methode waarmee bepaald wordt of 2 rechthoeken elkaar overlapper:
        public bool Overlap(Rechthoek rechthoek)
        {
            return ((rechthoek.D.X >= A.X && rechthoek.A.X <= D.X) &&
                (rechthoek.D.Y >= A.Y && rechthoek.A.Y <= D.Y));
        }

        // omzetten van het type Rechthoek naar het VisualStudio-type Rectangel:
        public Rectangle ToRectangle()
        {
            return new Rectangle(Locatie, Afmetingen);
        }

        public int Oppervlak()
        {
            return Breedte * Hoogte;
        }
        public int Omtrek()
        {
            return 2 * (Breedte + Hoogte);
        }
    }
}
