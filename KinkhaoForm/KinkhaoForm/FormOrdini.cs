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
    public partial class FormOrdini : Form
    {
        Form MainMenu;
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FormOrdini(Form menu)
        {
            this.MainMenu = menu;
            InitializeComponent();
        }

        private void FormOrdini_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            ORDINE ordine = new ORDINE();
            ordine.Codice_Fiscale = textBox4.Text;
            ordine.Codice_Ingrediente = textBox8.Text;
            ordine.Codice_Ordine = Decimal.Parse(textBox1.Text);
            ordine.Quantità = Decimal.Parse(textBox2.Text);
            ordine.Prezzo_Unitario = Decimal.Parse(textBox3.Text);
            ordine.Data_Ordine = dateTimePicker1.Value;
            db.ORDINE.InsertOnSubmit(ordine);
            db.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = from d in db.DDT
                      where d.Numero == textBox16.Text
                      && d.P_IVA == textBox15.Text
                      && d.Anno == textBox14.Text
                      select new { d.Luogo_partenza, d.Data_consegna, d.Data_partenza, d.Corriere };

            dataGridView1.DataSource = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = from o in db.ORDINE
                      where o.Anno == null
                      && o.P_IVA == null
                      && o.Numero == null
                      select new { o.Codice_Ordine, o.Codice_Ingrediente, o.Prezzo_Unitario, o.Quantità, o.Codice_Fiscale };

            dataGridView1.DataSource = res;
        }
    }
}
