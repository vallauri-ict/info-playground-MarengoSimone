using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class AnimaleTerrestre : Animale
    {
        public AnimaleTerrestre(string s):base(s)
        {
            //super(s);
        }
        public string vive()
        {
            return "sulla terraferma";
        }

        public string chi_sei()
        {
            return "un animale terrestre";
        }
    }
}
