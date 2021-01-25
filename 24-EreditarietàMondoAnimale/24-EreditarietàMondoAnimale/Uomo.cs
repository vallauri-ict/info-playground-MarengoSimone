using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class Uomo:AnimaleTerrestre
    {
        public Uomo(string s) : base(s)
        {
            //super(s);
        }
        public string vive()
        {
            return "in un condominio";
        }

        public string chi_sei()
        {
            return "un cavallo";
        }
    }
}
