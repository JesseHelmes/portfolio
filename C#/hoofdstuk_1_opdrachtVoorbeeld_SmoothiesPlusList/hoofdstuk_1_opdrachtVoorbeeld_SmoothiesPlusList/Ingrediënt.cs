namespace hoofdstuk_1_opdrachtVoorbeeld_SmoothiesPlus
{
    class Ingrediënt
    {
        //variabelen
        public string Naam = "";
        public System.Drawing.Color Kleur = System.Drawing.Color.AliceBlue;
        public string LandVanHerkomst = "Nederland";
        public int Calorieën = 0;
        public double PrijsPerKilo = 0;

        //constructor
        public Ingrediënt(string naam, System.Drawing.Color kleur, string landVanHerkomst, int calorieën,
        double prijsPerKilo)
        {
            this.Naam = naam;
            this.Kleur = kleur;
            this.LandVanHerkomst = landVanHerkomst;
            this.Calorieën = calorieën;
            this.PrijsPerKilo = prijsPerKilo;
        }

        // lege constructor die zorgt er voor dat er standart waardes worden aangemaakt
        public Ingrediënt()
        {

        }

        public override string ToString()
        {
            return "Ingrediënt " + Naam +
                " met de kleur " + Kleur +
                ", het aantal calorieën " + Calorieën +
                " en een prijs per kilo van €" + PrijsPerKilo +
                " uit " + LandVanHerkomst;
        }

        // Operatoren
        public static bool operator == (Ingrediënt ingrediënt1, Ingrediënt ingrediënt2)
        {
            // De bewering is waar als alle velden overeenkomen.
            return ingrediënt1.Calorieën == ingrediënt2.Calorieën &&
                ingrediënt1.Kleur == ingrediënt2.Kleur &&
                ingrediënt1.LandVanHerkomst == ingrediënt2.LandVanHerkomst &&
                ingrediënt1.Naam == ingrediënt2.Naam &&
                ingrediënt1.PrijsPerKilo == ingrediënt2.PrijsPerKilo;
        }

        public static bool operator != (Ingrediënt ingrediënt1, Ingrediënt ingrediënt2)
        {
            return !(ingrediënt1 == ingrediënt2);
        }


        public override bool Equals(System.Object obj)
        {
            Ingrediënt ingrediënt = obj as Ingrediënt;

            if((System.Object)ingrediënt == null)
            {
                return false;
            }

            if(obj == null)
            {
                return false;
            }

            return this.Calorieën == ingrediënt.Calorieën &&
                this.Kleur == ingrediënt.Kleur &&
                this.LandVanHerkomst == ingrediënt.LandVanHerkomst &&
                this.Naam == ingrediënt.Naam &&
                this.PrijsPerKilo == ingrediënt.PrijsPerKilo;
        }
    }   
}