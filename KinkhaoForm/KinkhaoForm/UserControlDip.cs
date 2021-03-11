using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinkhaoForm
{
    public partial class UserControlDip : UserControl
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControlDip()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void labNas_Click(object sender, EventArgs e)
        {

        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "cameriere":
                    CAMERIERE dipendente = new CAMERIERE();
                    dipendente.Data_di_Nascita = dateTimePicker1.Value;
                    dipendente.E_Mail = textBox7.Text;
                    dipendente.Genere = textBox4.Text.ElementAt(0);
                    dipendente.Indirizzo = textBox6.Text;
                    dipendente.Nome = textBox2.Text;
                    dipendente.Codice_Fiscale = textBox1.Text;
                    dipendente.Cognome = textBox3.Text;
                    dipendente.Telefono = Decimal.Parse(textBox5.Text);
                    db.CAMERIERE.InsertOnSubmit(dipendente);
                    db.SubmitChanges();
                    break;
                case "cassiere":
                    CASSIERE dipendente1 = new CASSIERE();
                    dipendente1.Data_di_Nascita = dateTimePicker1.Value;
                    dipendente1.E_Mail = textBox7.Text;
                    dipendente1.Genere = textBox4.Text.ElementAt(0);
                    dipendente1.Indirizzo = textBox6.Text;
                    dipendente1.Nome = textBox2.Text;
                    dipendente1.Codice_Fiscale = textBox1.Text;
                    dipendente1.Cognome = textBox3.Text;
                    dipendente1.Telefono = Decimal.Parse(textBox5.Text);
                    db.CASSIERE.InsertOnSubmit(dipendente1);
                    db.SubmitChanges();
                    break;
                case "cuoco":
                    CUOCO dipendente2 = new CUOCO();
                    dipendente2.Data_di_Nascita = dateTimePicker1.Value;
                    dipendente2.E_Mail = textBox7.Text;
                    dipendente2.Genere = textBox4.Text.ElementAt(0);
                    dipendente2.Indirizzo = textBox6.Text;
                    dipendente2.Nome = textBox2.Text;
                    dipendente2.Codice_Fiscale = textBox1.Text;
                    dipendente2.Cognome = textBox3.Text;
                    dipendente2.Telefono = Decimal.Parse(textBox5.Text);
                    db.CUOCO.InsertOnSubmit(dipendente2);
                    db.SubmitChanges();
                    break;
            }
        }

        private void labMail_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void labInd_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void labTel_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labGen_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCog_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labNome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodFis_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
