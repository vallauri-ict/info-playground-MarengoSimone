using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_ComplessiEQuaternioni
{
    class Quaternioni : Complesso
    {
        private double c;
        private double d;

        public double C { get => c; set => c = value; }
        public double D { get => d; set => d = value; }

        public Quaternioni() : this(1)
        {

        }
        public Quaternioni(double immaginario) : base(immaginario)
        {

        }
        public Quaternioni(double immaginario, double reale) : this(reale, immaginario, 0, 0)
        {

        }
        public Quaternioni(double reale, double immaginario, double immaginarioC) : this(reale,immaginario,immaginarioC,0)
        {

        }
        public Quaternioni(double reale, double immaginario, double immaginarioC, double immaginarioD):base(reale,immaginario)
        {
            C = immaginarioC;
            D = immaginarioD;
        }
        public double Modulo()
        {
            double modulo = Math.Pow(Reale, 2) + Math.Pow(Immaginario, 2) + Math.Pow(C, 2) + Math.Pow(D, 2);
            return Math.Sqrt(modulo);
        }
    }
}
