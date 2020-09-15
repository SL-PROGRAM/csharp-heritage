using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    class Rectangle : Forme
    {
        int largeur;
        int longueur;

               
        public int Largeur { get => largeur; set => largeur = value; }
        public int Longueur { get => longueur; set => longueur = value; }


       
        public override string ToString()
        {
            return string.Format("Un rectangle a une longueur de : {0} " +
                "\n et une largueur {1}" +
                "\n et {2}", Largeur, Longueur, base.ToString());
        }

        public string ToStringMother()
        {
            return base.ToString();
        }

        protected override string CalulerAire()
        {
            Perimetre = 2 * (Longueur + Largeur);
            return Perimetre.ToString();
        }

        protected override string CalculerPerimetre()
        {
            Aire = Longueur * Largeur;
            return Aire.ToString();
        }
    }
}
