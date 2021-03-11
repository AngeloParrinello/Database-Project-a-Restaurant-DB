using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinkhaoForm
{
    public partial class MainMenu : Form
    {
        Form dipendenti;
        Form turni;
        Form ordini;
        Form costi;
        Form prenotazioni;
        public MainMenu()
        {
            costi = new FormCosti(this);
            ordini = new FormOrdini(this);
            dipendenti = new FormDip(this);
            turni = new FormTurn(this);
            prenotazioni = new FormPrenotaz(this);
            InitializeComponent();
        }

        private void btnDip_Click(object sender, EventArgs e)
        {
            dipendenti.Show();
            this.Hide();
        }

        private void btnOrd_Click(object sender, EventArgs e)
        {
            ordini.Show();
            this.Hide();
        }

        private void btnPren_Click(object sender, EventArgs e)
        {
            prenotazioni.Show();
            this.Hide();
        }

        private void btnCosti_Click(object sender, EventArgs e)
        {
            costi.Show();
            this.Hide();

        }

        private void btnTurni_Click(object sender, EventArgs e)
        {
            turni.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
