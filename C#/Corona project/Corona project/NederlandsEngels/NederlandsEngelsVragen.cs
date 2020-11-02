using Corona_project;
using System.Collections.Generic;

namespace NederlandsEnEngels
{
    class NederlandsEngelsVragen
    {
        private List<meerkeuzenVraag> vragen = new List<meerkeuzenVraag>
        {
            new meerkeuzenVraag
            (
                "eten in de tegenwoordige tijd",
                "eat",
                "ate",
                "at",
                "et"
            ),

            new meerkeuzenVraag
            (
                "Een appel",
                "an apple",
                "a aple",
                "a apple",
                "an appla"
            ),

            new meerkeuzenVraag
            (
                "Voet",
                "foot",
                "food",
                "vood",
                "voot"
            ),

            new meerkeuzenVraag
            (
                "Boot",
                "boat",
                "bloat",
                "road",
                "rode"
            ),

            new meerkeuzenVraag
            (
                "Basisschool",
                "elementary School",
                "high School",
                "kindergarten"
            ),

            new meerkeuzenVraag
            (
                "Snel",
                "fast",
                "rush",
                "running",
                "ascending"
            ),

            new meerkeuzenVraag
            (
                "Een kopje coffee",
                "a cup of coffee",
                "a cup coffee",
                "an cup of coffee",
                "an cup cofee"
            ),

            new meerkeuzenVraag
            (
                "Helaas",
                "unfortunately",
                "unfortunate",
                "dissapointing",
                "foiling"
            ),

            new meerkeuzenVraag
            (
                "Het einde",
                "the end",
                "end",
                "finish",
                "conclusion"
            ),

            new meerkeuzenVraag
            (
                "Neus",
                "nose",
                "rose",
                "noise",
                "mouse"
            ),

        };

        public List<meerkeuzenVraag> getNederlandsVragen()
        {
            return vragen;
        }
    }
}
