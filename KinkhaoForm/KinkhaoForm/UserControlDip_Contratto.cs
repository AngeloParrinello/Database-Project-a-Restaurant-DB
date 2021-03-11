using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace KinkhaoForm
{
    public partial class UserControlDip_Contratto : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControlDip_Contratto()
        {
            InitializeComponent();
        }

        private void UserControlDip_Contratto_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString()) {
                case "cameriere":
                    CONTRATTO contratto = new CONTRATTO();
                    contratto.Cameriere_Codice_Fiscale = textBox1.Text;
                    contratto.Codice_Contratto = Decimal.Parse(textBox9.Text);
                    contratto.Data_Inizio = dateTimePicker2.Value;
                    if (dateTimePicker1.Enabled)
                    {
                        contratto.Data_Fine = dateTimePicker1.Value;
                    } else
                    {
                        contratto.Data_Fine = null;
                    }
                    contratto.Stipendio = Decimal.Parse(textBox3.Text);
                    db.CONTRATTO.InsertOnSubmit(contratto);
                    db.SubmitChanges();
                    break;
                case "cassiere":
                    CONTRATTO contratto1 = new CONTRATTO();
                    contratto1.Cassiere_Codice_Fiscale = textBox1.Text;
                    contratto1.Codice_Contratto = Decimal.Parse(textBox9.Text);
                    contratto1.Data_Inizio = dateTimePicker2.Value;
                    if (dateTimePicker1.Enabled)
                    {
                        contratto1.Data_Fine = dateTimePicker1.Value;
                    }
                    else
                    {
                        contratto1.Data_Fine = null;
                    }
                    contratto1.Stipendio = Decimal.Parse(textBox3.Text);
                    db.CONTRATTO.InsertOnSubmit(contratto1);
                    db.SubmitChanges();
                    break;
                case "cuoco":
                    CONTRATTO contratto2 = new CONTRATTO();
                    contratto2.Cuoco_Codice_Fiscale = textBox1.Text;
                    contratto2.Codice_Contratto = Decimal.Parse(textBox9.Text);
                    contratto2.Data_Inizio = dateTimePicker2.Value;
                    if (dateTimePicker1.Enabled)
                    {
                        contratto2.Data_Fine = dateTimePicker1.Value;
                    }
                    else
                    {
                        contratto2.Data_Fine = null;
                    }
                    contratto2.Stipendio = Decimal.Parse(textBox3.Text);
                    db.CONTRATTO.InsertOnSubmit(contratto2);
                    db.SubmitChanges();
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            } else
            {
                dateTimePicker1.Enabled = true;
            }
        }
    }
}
