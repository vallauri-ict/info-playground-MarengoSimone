using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Preparazione_Verifica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private TextBox txt1;
        private TextBox txt2;
        private ToolStripStatusLabel toolStrip;
        public Form2(TextBox txtNome,TextBox txtEta, ToolStripStatusLabel toolStripStatusLabel)
        {
            InitializeComponent();
            txt1 = txtNome;
            txt2 = txtEta;
            toolStrip = toolStripStatusLabel;
        }
        private void btnAnnullaInvio_Click(object sender, EventArgs e)
        {
            toolStrip.Text = "";
            toolStrip.Text = "Operazione Annullata";
            MessageBox.Show("Operazione Annullata");
        }

        private void btnInvia_Click_1(object sender, EventArgs e)
        {
            toolStrip.Text = "";
            toolStrip.Text = "Dati inviati al Form 1";
            MessageBox.Show(txtNome1.Text + " " + txtEta1.Text);
            txt1.Text = txtNome1.Text;
            txt2.Text = txtEta1.Text;
        }
    }
}
