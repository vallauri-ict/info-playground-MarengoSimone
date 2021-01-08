using System;
using System.Windows.Forms;

namespace _20_OOP_ComplessiEQuaternioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (txtReale.Text == "" && txtImmaginario.Text != "")
            {
                Complesso c = new Complesso(Convert.ToDouble(txtImmaginario.Text));
                MessageBox.Show("Il modulo del numero complesso vale: " + c.Modulo().ToString());
            }
            else if (txtReale.Text != "" && txtImmaginario.Text != "")
            {
                Complesso c = new Complesso(Convert.ToDouble(txtReale.Text), Convert.ToDouble(txtImmaginario.Text));
                MessageBox.Show("Il modulo del numero complesso vale: " + c.Modulo().ToString());
            }
            else if (txtReale.Text == "" && txtImmaginario.Text == "")
            {
                Complesso c = new Complesso();
                MessageBox.Show("Il modulo del numero complesso vale: " + c.Modulo().ToString());
            }
            else
            {
                MessageBox.Show("Dati mancanti per il complesso");
            }


        }

        private void btnModuloQuaternione_Click(object sender, EventArgs e)
        {
            Quaternioni q = new Quaternioni(Convert.ToDouble((txtReale.Text != "") ? txtReale.Text : "0")
                                           , Convert.ToDouble((txtImmaginario.Text != "") ? txtImmaginario.Text : "0"),
                                           Convert.ToDouble((txtImmaginarioC.Text != "") ? txtImmaginarioC.Text : "0")
                                           , Convert.ToDouble((txtImmaginarioD.Text != "") ? txtImmaginarioD.Text : "0"));
            MessageBox.Show("Il modulo del quaternione vale: " + q.Modulo().ToString());
        }
    }
}
