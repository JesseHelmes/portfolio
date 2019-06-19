using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim2
{
    public abstract class GrafischObject
    {
        //
        // constructor
        //
        public GrafischObject()
        {
            initClass();
        }

        //
        // eigenschappen
        //

        public Color Kleur { get; set; }
        public Color KaderKleur { get; set; }
        public Point Locatie
        {
            /*deze eigenschap is eigenlijk een doorgeefluik
              naar de bijbehorende instantie van Rechthoek.
              door deze eigenschap hier op te nemen kan de klasse
              Konijn makkelijker gebruikt worden. */
              get { return Tekengebied.Locatie; }
              set { Tekengebied.Locatie = value; }
        }

        public Graphics Papier
        {
            get { return _papier; }
            set
            {
                _papier = value;
                /* om te bepalen hoe groot het tekengebied is van de control waarop
                 getekend wordt, kun je deze van het grafisch object krijgen.
                 addertje onder het gras is dat de VisibleClipBounds het gebied
                 aangeven wat je ziet. het totale grafische object is veel groter.
                 omdat in uitzonderlijke gevallen een null-waarde kan ontstaan
                 wordt hierop gecheckt om foutmeldingen te voorkomen.*/
                if (value != null)
                {
                    int breedteVenster = (int)Papier.VisibleClipBounds.Width;
                    int hoogteVenster = (int)Papier.VisibleClipBounds.Height;
                    _graphicsVenster = new Rechthoek(new Point(0, 0), new Size(breedteVenster, hoogteVenster));
                }
            }
        }
        public Rechthoek Tekengebied { get; set; }
        public Color Wiskleur { get; set; }
        //
        // ReadOnly-eigenschappen
        //
        public Rechthoek GraphicsVenster { get { return _graphicsVenster; } }
        public Guid ID { get { return _id; } }
        //
        // variablen
        //
        private Guid _id;
        private bool _verwijderd = false;
        private Graphics _papier;
        private Rechthoek _graphicsVenster;
        //
        // methoden
        //
        /* de methoden initClass stelt de standaardwaarde in voor enkele
          eigenschappen. de methode is private omdat deze alleen binnen deze
          klasse gebruikt wordt. deze methode wordt altijd door één of meerdere
          constructors gebruikt. */
          private void initClass()
        {
            KaderKleur = Color.Black;
            Kleur = Color.WhiteSmoke;
            Wiskleur = Color.PaleGoldenrod;

            //grafische instellingen:
            Tekengebied = new Rechthoek();

            /* instellen van de guid. een gud of uuid is een acroniem voor
             'Globalle Unique Indentiefier' (of 'Universally Unique Indentiefier').
             het is een 128-bits integer die gebruikt wordt om objecten te indentificeren */
            _id = Guid.NewGuid();
        }

        public void Verwijder()
        {
            _verwijderd = true;
            Wis();
        }

        public void Wis()
        {
            // door het object opnieuw te tekenen met de Wiskleur, de kleur van
            // het object waarop getekend wordt, wordt een object onzichtbaar:
            Color ouderKleur = Kleur;
            Color oudeKaderKleur = KaderKleur;
            Kleur = Wiskleur;
            KaderKleur = Wiskleur;
            Teken();
            KaderKleur = oudeKaderKleur;
            Kleur = ouderKleur;
        }

        public void Teken(Graphics papier)
        {
            // door het GraphicsObject waarop getekend wordt te bewaren kunnen we een
            // getekend object ook altijd weer uitvegen:
            Papier = papier;
            // het tekenen van een kader op de locatie van het object met de afmetingen van het object:
            Pen pen = new Pen(KaderKleur, 2);

            // het tekenen van de rechthoek
            if (Papier != null)
            {
                Papier.DrawRectangle(pen, Tekengebied.ToRectangle());
            }

            // het direct vrijgeven van het geheugen van een gebruit object:
            pen.Dispose();
        }
        public void Teken()
        {
            Teken(Papier);
        }
    }
}
