using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19__OOP_PersoneStudenti
{
    public partial class Form1 : Form
    {
        Studente s;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            s = new Studente();
            if (txtCognome.Text != "" && txtNome.Text != "" && txtSesso.Text != "" && txtEta.Text != "")
            {
                s.setAttributes(txtCognome.Text, txtNome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
                MessageBox.Show("Caricamento riuscito");
            }
        }

        private void btnVoto_Click(object sender, EventArgs e)
        {
            if(txtVoto.Text!="")
            {
                int voto = Convert.ToInt32(txtVoto.Text);
                s.aggiungiVoto(voto);
                MessageBox.Show("Voto aggiunto correttamente");
            }
            else
                MessageBox.Show("Inserisci il voto!");
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La media generale è: " + s.Media().ToString());
        }
    }
}
