using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class AnimaleMarino : Animale
    {

        public AnimaleMarino(string s) : base(s)
        {
            //super(s);
        }

        public string vive()
        {
            return "in mare";
        }

        public string chi_sei()
        {
            return "un animale marino";
        }
    }
}
