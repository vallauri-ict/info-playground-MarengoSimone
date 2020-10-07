using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm01
{
    public partial class FormModale : Form
    {
        public FormModale()
        {
            InitializeComponent();
        }
        public string nome = "";
        public string eta = "";

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEta.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            eta = "";
            nome = "";
        }
    }
}
