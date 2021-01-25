using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class Quadrupede:AnimaleTerrestre
    {
        public Quadrupede(string s) : base(s)
        {
            //super(s);
        }
        public string vive()
        {
            return "sulla terraferma";
        }

        public string chi_sei()
        {
            return "un quadrupede";
        }
    }
}
