﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Ereditarietà
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            Mostro demone = new Mostro();
            MessageBox.Show("Punti: " + demone.Valore() + "\nVerso: " + demone.Verso(), "Demone");
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro umano = new Mannaro();
            MessageBox.Show("Punti: " + umano.Valore() + "\nVerso: " + umano.Verso(),"Umano");
            umano.Muta();
            MessageBox.Show("Punti: " + umano.Valore() + "\nVerso: " + umano.Verso(), "Umano Mutato");
        }
    }
}
