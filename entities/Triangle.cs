using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities
{
    class Triangle : Forme
    {
        double a;
        double b;
        double c;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        protected override string CalculerPerimetre()
        {
            Perimetre = A + B + C;
            return Perimetre.ToString();
        }

        protected override string CalulerAire()
        {
            double p = (A + B + C) / 2;
            Aire = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Aire.ToString();
            
        }

        public override string ToString()
        {
            return string.Format("Le Triangle a un coté A de : {0}," +
                "\n un coté B de : {1}, " +
                "\n un coté C de : {2} " +
                "\n et {3}", A, B, C, base.ToString());
        }

    }
}
