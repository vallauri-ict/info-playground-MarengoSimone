using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ClasseAstratta
{
    class Studente
    {
        private List<Studente> lstStudenti = new List<Studente>();

        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        private DateTime dataNascita;
        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
