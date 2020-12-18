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
        public Form1()
        {
            InitializeComponent();
        }
        List<Studente>lstStudenti = new List<Studente>();
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            if (txtCognome.Text != "" && txtNome.Text != "" && txtSesso.Text != "" && txtEta.Text != "")
            {
                s.setAttributes(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
                lstStudenti.Add(s);
                listStudenti.Items.Add(s.GetCognome());
                MessageBox.Show("Caricamento riuscito");
            }
            else
            {
                MessageBox.Show("Inserire tutti i dati");
            }
        }

        private void btnVoto_Click(object sender, EventArgs e)
        {
            if(txtVoto.Text!="")
            {
                foreach (Studente item in lstStudenti)
                {
                    if (item.GetCognome() == listStudenti.SelectedItems[0].Text)
                    {
                        item.voti.Add(Convert.ToInt32(txtVoto.Text));
                    }
                }
                MessageBox.Show("Voto aggiunto correttamente");
            }
            else
                MessageBox.Show("Inserisci il voto!");
        }
        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud => stud.GetCognome() == listStudenti.SelectedItems[0].Text);
            MessageBox.Show("Lo studente " + s.GetCognome() + " ha la media del " + s.Media());
        }
    }
}
