using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_ComplessiEQuaternioni
{
    class Complesso
    {
        protected double reale;
        protected double immaginario;

        public Complesso()
        {
            // 0 parametri
            this.reale = 0;
            this.immaginario = 0;
        }

        public Complesso(double a)
        {
            // 1 parametro
            this.reale = a;
            this.immaginario = 0;
        }

        public Complesso(double a, double b)
        {
            // 2 parametri
            this.reale = a;
            this.immaginario = b;
        }

        public void getAttributes(ref double reale, ref double immaginario)
        {
            reale = this.reale;
            immaginario = this.immaginario;
        }

        private double getReale()
        {
            return this.reale;
        }

        private double getImmaginario()
        {
            return this.immaginario;
        }

        public double Modulo()
        {
            double reale = 0;
            double immaginario = 0;
            getAttributes(ref reale, ref immaginario);
            double modulo = Math.Sqrt(Math.Pow(reale, 2) + Math.Pow(immaginario, 2));
            return modulo;
        }

        public double Coniugato()
        {
            double immaginario = getImmaginario();
            return -immaginario;
        }
    }
}
