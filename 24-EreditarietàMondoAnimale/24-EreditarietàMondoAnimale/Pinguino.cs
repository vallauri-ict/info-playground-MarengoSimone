using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class Pinguino:AnimaleAcquatico
    {
        public Pinguino(string s) : base(s)
        {
            //super(s);
        }
        public string vive()
        {
            return "in un nido su un albero";
        }

        public string chi_sei()
        {
            return "un pinguino";
        }
    }
}
