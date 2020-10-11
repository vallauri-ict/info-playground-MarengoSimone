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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
            toolStripStatusLabel.Text = "Premuto tasto esci";
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire?";
            if (f.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel.Text = "";
                toolStripStatusLabel.Text = "Sto chiudendo l'applicazione...";
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Applicazione Avviata";
        }

        private void apriForm2b_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Aperta form 2b ";
            Form Figlia2b = new Form();
            Figlia2b.Text = "Aperta Form Figlia 2b Dinamica";
            Figlia2b.BackColor = Color.Bisque;
            Figlia2b.MdiParent = this;
            Figlia2b.Size = new Size(330, 200);
            Figlia2b.StartPosition = FormStartPosition.Manual; // Serve per far funzionare il location
            Figlia2b.Location = new Point(700, 40);
            Figlia2b.Show();
        }

        private void apriForm2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Aperta form 2";
            Form2 f2 = new Form2();
            f2.Text = "Form 2";
            f2.MdiParent = this;
            f2.Size = new Size(330, 200);
            f2.StartPosition = FormStartPosition.Manual; // Serve per far funzionare il location
            f2.Location = new Point(0, 40);
            f2.Show();

            toolStripStatusLabel.Text = "Aperta form 2";
            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da design con passaggio parametri";
            f2b.MdiParent = this;
            f2b.Size = new Size(330, 200);
            f2b.StartPosition = FormStartPosition.Manual; // Serve per far funzionare il location
            f2b.Location = new Point(340, 40);
            f2b.Show();
        }

        private void passaTxtAF2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Passaggio testo a F2";
            Form2 f2 = new Form2(txtPassata);
            f2.Text = "Form 2 con passaggio di TextBox";
            f2.MdiParent = this;
            f2.Size = new Size(330, 200);
            f2.StartPosition = FormStartPosition.Manual; // Serve per far funzionare il location
            f2.Location = new Point(0, 40);
            f2.Show();
        }

        private void toolStripInfo_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Lette finestre figlie aperte";
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + f.Text + " Aperta");
            }
        }
    }
}
