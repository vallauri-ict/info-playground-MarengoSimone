using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ClasseIndexata
{
    class MyIndexClass
    {
        private string[] element;

        public MyIndexClass(int elementNumber)   // costruttore
        {
            element = new string[elementNumber];
            for (int i = 0; i < element.Length; i++)
            {
                element[i] = "empty";
            }
        }

        // Iteratore
        public string this[int pos]    // viene richiamato quando faccio per esempio: vet[1] = "pippo"
        {
            get { return element[pos]; }
            set { element[pos] = value; }
        }

        public int length()  // imposto la lunghezza del vettore così posso vederla e usarla nel Form 1
        {
            return element.Length;
        }
    }
}
