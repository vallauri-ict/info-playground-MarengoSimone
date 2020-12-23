using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_ComplessiEQuaternioni
{
    class Complesso
    {
        private double reale = 0;
        private double immaginario = 0;

        public Complesso() : this(1)
        {
            // 0 parametri
        }

        public Complesso(double b) :this(1,b)
        {
            // 1 parametro
        }

        public Complesso(double a, double b)
        {
            // 2 parametri
            Reale = a;
            Immaginario = b;
        }

        public double Reale { get => reale; set => reale = value; }
        public double Immaginario { get => immaginario; set => immaginario = value; }
        public double Modulo()
        {
            double modulo = Math.Sqrt(Math.Pow(reale, 2) + Math.Pow(immaginario, 2));
            return modulo;
        }

        public void Coniugato()
        {
            Immaginario = -Immaginario;
        }
    }
}
