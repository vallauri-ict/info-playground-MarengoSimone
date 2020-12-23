using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_OOP_ComplessiEQuaternioni
{
    public partial class Form1 : Form
    {
        Complesso c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            c = new Complesso();
            double reale;
            double immaginario; 

            if (txtReale.Text!="" && txtIm.Text!="")
            {
                reale = Convert.ToDouble(txtReale.Text);
                immaginario =  Convert.ToDouble(txtIm.Text);
                //c.getAttributes(ref reale, ref immaginario);
                MessageBox.Show("Caricamento riuscito");
            }
            else
            {
                MessageBox.Show("Inserisci i dati!");
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il modulo del numero complesso vale: " + c.Modulo());
        }

        private void btnConiugato_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Il coniugato del numero complesso vale: " + c.Coniugato());
        }
    }
}
