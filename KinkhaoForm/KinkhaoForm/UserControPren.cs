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
    public partial class UserControPren : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControPren()
        {
            InitializeComponent();
        }

        private void UserControPren_Load(object sender, EventArgs e)
        {

        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            PRENOTAZIONE pren = new PRENOTAZIONE();
            pren.Data_Prenotazione = DateTime.Today;
            pren.Numero_di_Telefono = 0;
            pren.Numero = Decimal.Parse(textBox3.Text);
            pren.Numero_Persone = Decimal.Parse(textBox4.Text);
            pren.Ora = DateTime.Now.Hour + (decimal) DateTime.Now.Minute/100;
            db.PRENOTAZIONE.InsertOnSubmit(pren);
            db.SubmitChanges();
        }
    }
}
