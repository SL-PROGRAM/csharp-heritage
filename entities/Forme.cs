using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    public abstract class Forme
    {
        double aire;
        double perimetre;

        public double Aire { get => aire; set => aire = value; }
        public double Perimetre { get => perimetre; set => perimetre = value; }

        protected abstract string CalulerAire();
        protected abstract string CalculerPerimetre();

        public override string ToString()
        {
            return string.Format("une aire de : {0} et un périmètre de : {1}", CalulerAire(), CalculerPerimetre());
        }
        
    }
}
