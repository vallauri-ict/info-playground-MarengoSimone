using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOP01
{
    class Fattura
    {
        private static int cntFatture = 0;
        public readonly int nFattura;
        public Fattura()
        {
            cntFatture++;
            this.nFattura = cntFatture;
        }

        public static void visualizza()
        {
            System.Windows.Forms.MessageBox.Show("Numero fatture create: " + cntFatture.ToString());
            //System.Windows.Forms.MessageBox.Show("Numero fatture eseguite: " + this.nFattura.ToString());
        }
    }
}
