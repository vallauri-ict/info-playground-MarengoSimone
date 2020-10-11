using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_FormMDI_con_funzionalità_es_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int n;
        private TextBox txt1;

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }
        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }

        private void leggiValore_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Valore = " + n);
        }

        private void apriFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            this.AddOwnedForm(f);
            f.BackColor = Color.Goldenrod;
            f.Show();
        }

        private void inviaAForm_Click(object sender, EventArgs e)
        {
            txt1.Text = txtForm2.Text;
        }
    }
}
