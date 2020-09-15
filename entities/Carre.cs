using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    class Carre : Rectangle
    {

        

        public override string ToString()
        {
            Largeur = Longueur;
            return string.Format("Un carré a un coté de : {0} \n et {1}", 
                Largeur, base.ToStringMother());
        }




    }
}
