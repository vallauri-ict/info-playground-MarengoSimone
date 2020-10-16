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
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void btnApriFiglio_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Figlia MDI";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual; // Serve per far funzionare il location
            f.Location = new Point(0, 60);
            f.Show();
        }
    }
}
