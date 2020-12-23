using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOP_ComplessiEQuaternioni
{
    class Quaternioni : Complesso
    {
        private double j;
        private double k;

        public double J { get => j; set => j = value; }
        public double K { get => k; set => k = value; }

        public Quaternioni() : this(1)
        {

        }
        public Quaternioni(double immaginario) : this(1, 1)
        {

        }
        public Quaternioni(double immaginario, double reale) : this(1, 1, 1)
        {

        }
        public Quaternioni(double immaginario, double reale, double j) : this(1, 1, 1, 1)
        {

        }
        public Quaternioni(double immaginario, double reale, double j, double k)
        {

        }
    }
}
