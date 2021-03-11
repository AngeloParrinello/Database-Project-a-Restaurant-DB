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
    public partial class FormPrenotaz : Form
    {
        Form MainMenu;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormPrenotaz(Form menu)
        {
            this.MainMenu = menu;
            InitializeComponent();
        }

        private void FormPrenotaz_Load(object sender, EventArgs e)
        {
            userControlPrenTel1.Hide();
            userControPren1.Show();
            userControPren1.BringToFront();
        }

        private void InsDip_Click(object sender, EventArgs e)
        {

        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            userControPren1.Show();
            userControPren1.BringToFront();
            userControlPrenTel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControlPrenTel1.Show();
            userControlPrenTel1.BringToFront();
            userControPren1.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TO TEST
            var res = from p in db.PRENOTAZIONE
                      where p.Data_Prenotazione == this.dateTimePicker1.Value
                      orderby p.Ora
                      select new { p.Numero, p.Ora, p.Numero_Persone };

                dataGridView1.DataSource = res;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TO TEST
            var toDelete = from p in db.PRENOTAZIONE
                           where p.Numero == Decimal.Parse(textBox1.Text)
                           && p.Data_Prenotazione == dateTimePicker2.Value
                           && p.Ora == Decimal.Parse(textBox14.Text)
                           select p;
            foreach(var p in toDelete)
            {
                db.PRENOTAZIONE.DeleteOnSubmit(p);
            }
            db.SubmitChanges();
        }
    }
}
