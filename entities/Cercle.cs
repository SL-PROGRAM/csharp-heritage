using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    public class Cercle : Forme
    {
        int rayon;

      
        public int Rayon { get => rayon; set => rayon = value; }

        protected override string CalculerPerimetre()
        {
            Aire = Math.PI * Rayon * Rayon;
            return Aire.ToString();
        }

        protected override string CalulerAire()
        {
            Perimetre = Math.PI * 2 * Rayon;
            return Perimetre.ToString();
        }

        public override string ToString()
        {
            return string.Format("Le cercle a un rayon de : {0}" +
                "\n et {1}", Rayon, base.ToString());
        }
        
    }


}
