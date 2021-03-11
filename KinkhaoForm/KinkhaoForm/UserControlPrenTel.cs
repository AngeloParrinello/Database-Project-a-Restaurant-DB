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
    public partial class UserControlPrenTel : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControlPrenTel()
        {
            InitializeComponent();
        }

        private void UserControlPrenTel_Load(object sender, EventArgs e)
        {

        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            PRENOTAZIONE prenotazione = new PRENOTAZIONE();
            prenotazione.Numero_Persone = Decimal.Parse(textBox4.Text);
            prenotazione.Numero = Decimal.Parse(textBox3.Text);
            prenotazione.Numero_di_Telefono = Decimal.Parse(textBox1.Text);
            prenotazione.Data_Prenotazione = dateTimePicker1.Value;
            prenotazione.Ora = Decimal.Parse(textBox5.Text);
            db.PRENOTAZIONE.InsertOnSubmit(prenotazione);
            db.SubmitChanges();
        }
    }
}
