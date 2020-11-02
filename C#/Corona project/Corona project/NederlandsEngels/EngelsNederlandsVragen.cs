using Corona_project;
using System.Collections.Generic;

namespace NederlandsEnEngels
{
    class EngelsNederlandsVragen
    {
        private List<meerkeuzenVraag> vragen = new List<meerkeuzenVraag>
        {
            new meerkeuzenVraag
            (
                "Car",
                "Auto",
                "Fiets",
                "Brommer",
                "Scooter"
            ),

            new meerkeuzenVraag
            (
                "Kitchen",
                "Keuken",
                "Kip",
                "kuiken",
                "Ketchup"
            ),

            new meerkeuzenVraag
            (
                "Corn",
                "Mais",
                "Brood",
                "Tarwe",
                "Aardappel"
            ),

            new meerkeuzenVraag
            (
                "Carrot",
                "wortel",
                "tarwe",
                "bloemkool",
                "spinazie"
            ),

            new meerkeuzenVraag
            (
                "Accident",
                "ongeluk",
                "aankondiging",
                "vallen"
            ),

            new meerkeuzenVraag
            (
                "Niece", //alle andere woorden zijn gewoon de verschillende betekenissen van *nice*
                "nicht",
                "mooi",
                "leuk",
                "fijn"
            ),

            new meerkeuzenVraag
            (
                "To bite",
                "bijten",
                "ontbijten",
                "reisen",
                "verwijten"
            ),

            new meerkeuzenVraag
            (
                "Cow",
                "koe",
                "schaap",
                "lam",
                "roet"
            ),

            new meerkeuzenVraag
            (
                "Farm",
                "boerderij",
                "tuinkas",
                "akker",
                "grasmaaier"
            ),

            new meerkeuzenVraag
            (
                "Biscuit",
                "koekje",
                "beschuitje",
                "schaal",
                "bloem"
            ),
        };

        public List<meerkeuzenVraag> getEngelseVragen()
        {
            return vragen;
        }
    }
}
