using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_ProntoSoccorso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Paziente
        {
            public string nome;
            public int età;
            public string colore;
            public int temp;
        }

        Queue<Paziente> codRosso = new Queue<Paziente>();
        Queue<Paziente> codGiallo = new Queue<Paziente>();
        Queue<Paziente> codVerde = new Queue<Paziente>();
        Queue<Paziente> codBianco = new Queue<Paziente>();
        int tempMax = -1;
        int tempMin = 45;
        private void btnCarica_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            if(txtEtà.Text!="" && txtNome.Text!="" && cmbColore.Text!="")
            {
                // caricamento dalle textbox
                Paziente p;
                p.nome = txtNome.Text;
                p.età = Convert.ToInt32(txtEtà.Text);
                p.colore = cmbColore.Text;
                p.temp = rnd.Next(33, 41);
                if(p.temp>tempMax)
                {
                    tempMax = p.temp;  
                }
                else if(p.temp < tempMin)
                {
                    tempMin = p.temp;  
                }

                // caricamento nelle code
                switch (cmbColore.Text)
                {
                    case "Rosso":
                        codRosso.Enqueue(p);
                        break;
                    case "Giallo":
                        codGiallo.Enqueue(p);
                        break;
                    case "Verde":
                        codVerde.Enqueue(p);
                        break;
                    case "Bianco":
                        codBianco.Enqueue(p);
                        break;
                    default:
                        break;
                }
                MessageBox.Show("Paziente messo in coda");
                azzera();
            }
            else
            {
                MessageBox.Show("Dati mancanti");
            }
               
        }

        private void azzera()
        {
            txtEtà.Text = "";
            txtNome.Text = "";
            cmbColore.SelectedIndex = -1;
        }

        private void btnDisponibile_Click(object sender, EventArgs e)
        {
            Paziente p;

            if(codRosso.Count > 0)
            {
                p = codRosso.Peek();
                lblPaziente.Text = "Ultimo paziente visitato: " + p.nome + " - " + p.età + " anni - in codice " + p.colore;
                codRosso.Dequeue();
                MessageBox.Show("Il paziente è in visita");
            }
            else if(codGiallo.Count > 0)
            {
                p = codGiallo.Peek();
                lblPaziente.Text = "Ultimo paziente visitato: " + p.nome + " - " + p.età + " anni - in codice " + p.colore;
                codGiallo.Dequeue();
                MessageBox.Show("Il paziente è in visita");
            }
            else if (codVerde.Count > 0)
            {
                p = codVerde.Peek();
                lblPaziente.Text = "Ultimo paziente visitato: " + p.nome + " - " + p.età + " anni - in codice " + p.colore;
                codVerde.Dequeue();
                MessageBox.Show("Il paziente è in visita");
            }
            else if (codBianco.Count > 0)
            {
                p = codBianco.Peek();
                lblPaziente.Text = "Ultimo paziente visitato: " + p.nome + " - " + p.età + " anni - in codice " + p.colore;
                codBianco.Dequeue();
                MessageBox.Show("Il paziente è in visita");
            }
            else
            {
                azzera();
                lblPaziente.Text = "Ultimo paziente visitato: nessun paziente disponibile";
                MessageBox.Show("Nessun paziente in coda");
            }
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            lblMax.Text = "Temparatura massima: " + tempMax + " gradi";
            lblMin.Text = "Temparatura minima: " + tempMin + " gradi";
        }
    }
}
