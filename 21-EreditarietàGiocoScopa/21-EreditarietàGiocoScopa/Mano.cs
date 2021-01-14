using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EreditarietàGiocoScopa
{
    class Mano
    {
        List<Carta> mano = new List<Carta>();

        public Mano()
        {
            mano.Clear();
        }
        public Carta Gioca(int indice)
        {
            Carta aus = mano.ElementAt(indice);
            mano.RemoveAt(indice);
            return aus;
        }

        public List<Carta> Lettura()
        {
            return mano;
        }
    }
}
