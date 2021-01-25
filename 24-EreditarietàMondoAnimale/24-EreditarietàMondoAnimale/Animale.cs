﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_EreditarietàMondoAnimale
{
    public abstract class Animale : MondoAnimale
    {
        private string nome;
        protected string verso;

        public Animale(string s)
        {
            nome = s;
        }
        public abstract string si_muove();

        public abstract string vive();

        public abstract string chi_sei();

        public void mostra()
        {
            System.Windows.Forms.MessageBox.Show(nome + ", " + chi_sei() + ", " + verso + ", si muove " + si_muove()
                + " e vive " + vive());
        }
    }
}
