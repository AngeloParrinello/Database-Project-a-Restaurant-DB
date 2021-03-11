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
    public partial class FormTurn : Form
    {
        Form MainMenu;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormTurn(Form menu)
        {
            this.MainMenu = menu;
            InitializeComponent();
        }

        private void FormTurn_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            TURNO turno = new TURNO();
            turno.Data_Turno = dateTimePicker1.Value;
            turno.Ora_Inizio = Decimal.Parse(textBox2.Text);
            turno.Ora_Fine = Decimal.Parse(textBox3.Text);
            db.TURNO.InsertOnSubmit(turno);
            db.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res =  from es in db.ESECUZIONE_CUOCO
                       where es.Data_Turno == dateTimePicker2.Value
                       && es.Ora_Fine_Turno == Decimal.Parse(textBox4.Text)
                       && es.Ora_Inizio_Turno == Decimal.Parse(textBox5.Text)
                       join c in db.CUOCO on es.Codice_Fiscale_Cuoco equals c.Codice_Fiscale
                       select new { c.Codice_Fiscale, c.Nome, c.Cognome };

            var res1 = from es in db.ESECUZIONE_CASSIERE
                       where es.Data_Turno == dateTimePicker2.Value
                       && es.Ora_Fine_Turno == Decimal.Parse(textBox4.Text)
                       && es.Ora_Inizio_Turno == Decimal.Parse(textBox5.Text)
                       join c in db.CASSIERE on es.Codice_Fiscale_Cassiere equals c.Codice_Fiscale
                       select new { c.Codice_Fiscale, c.Nome, c.Cognome };

            var res2 = from es in db.ESECUZIONE_CAMERIERE
                       where es.Data_Turno == dateTimePicker2.Value
                       && es.Ora_Fine_Turno == Decimal.Parse(textBox4.Text)
                       && es.Ora_Inizio_Turno == Decimal.Parse(textBox5.Text)
                       join c in db.CAMERIERE on es.Codice_Fiscale_Cameriere equals c.Codice_Fiscale
                       select new { c.Codice_Fiscale, c.Nome, c.Cognome };

            res = res.Concat(res1.Concat(res2));

            dataGridView1.DataSource = res;

        }
    }
}
