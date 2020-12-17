using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_ComplessiEQuaternioni
{
    class Quaternioni : Complesso
    {
        private double immaginarioJ;
        private double immaginarioK;

        public void getAttributes(double reale,double immaginarioB,double immaginarioJ,double immaginarioK)
        {
            reale = this.reale;
            immaginarioB = this.immaginario;
            immaginarioJ = this.immaginarioJ;
            immaginarioK = this.immaginarioK;
        }
    }
}
