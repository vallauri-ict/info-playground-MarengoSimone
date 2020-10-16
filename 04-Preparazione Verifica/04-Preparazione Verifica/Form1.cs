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
    public partial class Form1 : Form
    {
        public FormFiglia ff;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Applicazione Avviata";
        }

        private void loadTool_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Appliczione Avviata/Load";
        }

        private void saveTool_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Applicazione Avviata/Save";
        }

        private void exitTool_Click(object sender, EventArgs e)
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

        private void formSecondaria_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtEta, txtNome, toolStripStatusLabel);
            toolStripStatusLabel.Text = "Aperta Form Secondaria";
            f2.Text = "Form 2 da design";
            f2.Show();
        }

        private void formMDI_Click(object sender, EventArgs e)
        {
            FormMDI fm = new FormMDI();
            toolStripStatusLabel.Text = "Aperta Form MDI";
            fm.Text = "Form MDI Aperta";
            fm.Show();
        }

        private void formDinamica_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Form Dinamica";
            f2b.BackColor = Color.Aquamarine;
            toolStripStatusLabel.Text = "Aperta Form Dinamica";
            Button btn = new Button();
            btn.Text = "BUTTON";
            btn.Name = "btnProva";
            btn.Width = 210;
            btn.Height = 50;
            btn.Visible = true;
            btn.Top = 60;
            btn.Left = 20;
            f2b.Controls.Add(btn);
            f2b.Show();
        }

        private void infoToolStrip_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Visualizzazione Info Autore";
            MessageBox.Show("**** Autore: Marengo Simone - Classe: 4^B INFO ****");
        }

        private void formFiglia_Click(object sender, EventArgs e)
        {
            ff = new FormFiglia(txtModifica);
            ff.Show();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ff.TxtValue = txtModifica.Text; 
        }
    }
}
