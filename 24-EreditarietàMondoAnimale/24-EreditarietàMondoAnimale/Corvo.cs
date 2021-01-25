using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class Corvo : AnimaleTerrestre
    {
        public Corvo(string s):base(s)
        {
            //nome = s;
        }
        public string vive()
        {
            return "in un nido su un albero";
        }

        public string chi_sei()
        {
            return "un corvo";
        }
    }
}
