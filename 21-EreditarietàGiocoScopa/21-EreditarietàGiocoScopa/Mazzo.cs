using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EreditarietàGiocoScopa
{
    class Mazzo
    {
        List<Carta> mazzo = new List<Carta>();
        Random rnd = new Random();
        
        public Mazzo()
        {
            // generazione del mazzo
            for (int i = 1; i <= 10; i++)
            {
                Carta card = new Carta("♦", i);
                mazzo.Add(card);
            }
            for (int i = 1; i <= 10; i++)
            {
                Carta card = new Carta("♣", i);
                mazzo.Add(card);
            }
            for (int i = 1; i <= 10; i++)
            {
                Carta card = new Carta("♠", i);
                mazzo.Add(card);
            }
            for (int i = 1; i <= 10; i++)
            {
                Carta card = new Carta("♥", i);
                mazzo.Add(card);
            }
        }
        public void Mescola()
        {
            Carta app;
            int length = mazzo.Count;
            for (int i = 0; i < length; i++)
            {
                app = mazzo.First();
                mazzo.Remove(mazzo.First());
                mazzo.Insert(rnd.Next(1, length), app);
            }
        }

        public Carta Estrai()
        {
            Carta aus = mazzo.First();
            mazzo.RemoveAt(0);
            return aus;
        }
    }
}
