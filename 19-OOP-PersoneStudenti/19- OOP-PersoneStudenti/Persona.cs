﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__OOP_PersoneStudenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void setAttributes(string nome,string cognome,string sesso,int eta)
        {
            if (nome != "" && cognome != "" && sesso != "" && eta != 0) 
            {
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome()
        {
            return this.cognome;
        }

        public string GetSesso()
        {
            return this.sesso;
        }

        public int GetEta()
        {
            return this.eta;
        }
    }
}
