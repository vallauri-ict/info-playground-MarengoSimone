using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_GestioneContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Container
        {
            public string cod;
            public int peso;
            public int tara;
        }

        Stack<Container> container = new Stack<Container>();

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if(txtTara.Text!="" && txtPeso.Text!="" && txtCodice.Text!="")
            {
                Container c;
                c.cod = txtCodice.Text;
                c.peso = Convert.ToInt32(txtPeso.Text);
                c.tara = Convert.ToInt32(txtTara.Text);
                container.Push(c);
                MessageBox.Show("Container aggiunto in banchina");
            }
            else
            {
                MessageBox.Show("Dati mancanti");
            }
           
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                Container c = container.Pop();
                MessageBox.Show("Container caricato nella stiva: \n" + c.cod + "\n" + c.peso + "\n" + c.tara);
            }
            catch (Exception)
            {
                MessageBox.Show("Non c'è nessun container in porto");
            }
        }
    }
}
