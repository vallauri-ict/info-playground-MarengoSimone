using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class AnimaleAcquatico : Animale
    {
        public AnimaleAcquatico(string s):base(s)
        {
           //super(s);
        }

        public string vive()
        {
            return "nell'acqua";
        }

        public string chi_sei()
        {
            return "un animale acquatico";
        }
    }
}
