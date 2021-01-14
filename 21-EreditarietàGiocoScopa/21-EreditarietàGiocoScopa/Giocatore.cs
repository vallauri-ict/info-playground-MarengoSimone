using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EreditarietàGiocoScopa
{
    class Giocatore
    {
        private string nome;
        private Mano mano;
        List<Carta> prese = new List<Carta>();

        public Giocatore(string nome)
        {
            this.nome = nome;
            mano = new Mano();
            prese.Clear();
        }

        public Mano Lettura()
        {
            return mano;
        }

        public List<Carta> Prese()
        {
            return prese;
        }

        public void Gioca(int indice)
        {
            Carta c = mano.Gioca(indice);
        }
    }
}
