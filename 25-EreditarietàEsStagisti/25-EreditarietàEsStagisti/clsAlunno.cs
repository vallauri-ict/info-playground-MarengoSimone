using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_EreditarietàEsStagisti
{
    abstract class clsAlunno : clsPersona
    {
        #region Attributi
        protected static int progressivo = 0;
        protected readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;
        #endregion

        public char Classe
        {
            get => classe;
            set => classe = Convert.ToChar(value);
        }
        public string Matricola => matricola;
        public char Sezione
        {
            get => sezione;
            set => sezione = Convert.ToChar(value);
        }
        public string Specializzazione
        {
            get => specializzazione;
            set => specializzazione = value;
        }
        protected clsAlunno(string nome,string cognome,string città) : base(nome,cognome,città)
        {
        }
        public override string visualizza()
        {
            throw new NotImplementedException();
        }


    }
}
