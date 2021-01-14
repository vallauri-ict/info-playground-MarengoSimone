using System;
using System.Windows.Forms;

namespace _21_EreditarietàGiocoScopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Mazzo mazzo;
        string giocatore1, giocatore2;
        bool generato = false;
        int turno = 1;
        int cnt1 = 0, cnt2 = 0;

        private void btnMazzo_Click(object sender, EventArgs e)
        {
            generato = true;
            mazzo = new Mazzo();
            MessageBox.Show("Nuovo mazzo generato");
            generaBanco();
            btnMazzo.Enabled = false;
        }

        private void btnPesca_Click(object sender, EventArgs e)
        {
            if (generato == true)
            {
                if (txtGiocatore1.Text != "" && txtGiocatore2.Text != "")
                {
                    giocatore1 = txtGiocatore1.Text;
                    giocatore2 = txtGiocatore2.Text;

                    if (turno == 1)
                    {
                        string seme = "";
                        int valore = 0;
                        mazzo.Mescola();
                        Carta carta = mazzo.Estrai();
                        carta.Lettura(ref seme, ref valore);
                        listG1.Items.Add(valore + seme);
                        MessageBox.Show("Carta: " + valore + " di " + seme, "Pescata da " + giocatore1);
                        cnt1++;
                        turno = 2;
                    }
                    else if(turno==2)
                    {
                        string seme = "";
                        int valore = 0;
                        mazzo.Mescola();
                        Carta carta = mazzo.Estrai();
                        carta.Lettura(ref seme, ref valore);
                        listG2.Items.Add(valore + seme);
                        MessageBox.Show("Carta: " + valore + " di " + seme, "Pescata da " + giocatore2);
                        cnt2++;
                        turno = 1;
                    }
                    check();
                }
                else
                    MessageBox.Show("Devi inserire i nomi!");
            }
            else
                MessageBox.Show("Devi prima generare un mazzo!");

        }

        private void check()
        {
            if(cnt1==18 && cnt2==18)
                MessageBox.Show("La partita è finita");
        }

        private void reset()
        {
            btnMazzo.Enabled = true;
            txtGiocatore1.Text = "";
            txtGiocatore2.Text = "";
            listG1.ClearSelected();
            listG2.ClearSelected();
            listBanco.ClearSelected();
        }

        private void generaBanco()
        {
            Mazzo mazzoB = new Mazzo();
            for (int i = 0; i < 4; i++)
            {
                mazzoB.Mescola();
                string seme = "";
                int valore = 0;
                Carta carta = mazzoB.Estrai();
                carta.Lettura(ref seme, ref valore);
                listBanco.Items.Add(valore + seme);
            }
            MessageBox.Show("Generato il banco");
        }
    }
}
