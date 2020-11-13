using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Lista
{
    public partial class Form1 : Form
    {
        // list
        public struct Libro
        {
            public int ID;
            public string Titolo;
            public string Autore;
        }
        List<Libro> miaLista = new List<Libro>();

        // obj
        public class book
        {
            public int ID;
            public string title;
            public string autor;
            public book(int a, string b, string c)
            {
                this.ID = a;
                this.title = b;
                this.autor = c;
            }
        }
        List<book> collectionbook = new List<book>();
        List<book> collectionbookAppoggio = new List<book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;

            l.ID = Convert.ToInt32(txtId.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;

            miaLista.Add(l);
            MessageBox.Show("Libro Aggiunto");
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in miaLista)
            {
                s += elemento.Autore + " - " + elemento.Titolo + "\n";
            }
            MessageBox.Show(s,"Libri inseriti");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            book ris = collectionbook.Find(titoloLibro => titoloLibro.title == txtCerca.Text);
            MessageBox.Show(ris.title + " " + ris.autor);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            collectionbookAppoggio = collectionbook.FindAll(autoreLIbri => autoreLIbri.autor == txtCerca.Text);

            string s = "";
            foreach (book libro in collectionbookAppoggio)
            {
                s += libro.title.ToString() + "\n";
            }
            MessageBox.Show(s.ToString());
        }

        private void btnAggiungiOgg_Click(object sender, EventArgs e)
        {
            book b = new book(Convert.ToInt32(txtId.Text), txtTitolo.Text, txtAutore.Text);
            collectionbook.Add(b);
            MessageBox.Show("Libro aggiunto");
        }

        private void btnVisualizzaOgg_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in collectionbook)
            {
                s += elemento.autor + " - " + elemento.title + "\n";
            }
            MessageBox.Show(s, "Libri inseriti");
        }
    }
}
