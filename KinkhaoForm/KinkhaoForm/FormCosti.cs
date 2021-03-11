using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace KinkhaoForm
{
    public partial class FormCosti : Form
    {
        Form MainMenu;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormCosti(Form menu)
        {
            this.MainMenu = menu;
            InitializeComponent();
        }

        private void FormCosti_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void butInvia_Click(object sender, EventArgs e)
        {
            int anno = int.Parse(textBox7.Text);
            int mese = int.Parse(textBox6.Text);
            if (mese < 1 || mese > 12)
            {
                textBox1.Text = "####,##";
            }
            else
            {
                DateTime dataInizio = new DateTime(anno, mese, 1);
                if (int.Parse(textBox6.Text) == 12)
                {
                    anno = anno + 1;
                    mese = 1;
                }
                else
                {
                    mese = mese + 1;
                }
                DateTime dataFine = new DateTime(anno, mese, 1);
                var res = from f in db.FATTURA
                          where (f.Data_Fattura > dataInizio && f.Data_Fattura < dataFine && f.Pagata == "si")
                          select new { f.Importo_Netto, f.IVA };
                var res1 = from c in db.CONTRATTO
                           where c.Data_Inizio < dataFine && (c.Data_Fine > dataInizio || c.Data_Fine == null)
                           select new { c.Stipendio };
                decimal meraviglia = 0;
                if (res.Count() != 0)
                {
                    meraviglia += res.Select(f => f.Importo_Netto + f.IVA).Sum();
                }
                if (res1.Count() != 0)
                {
                    meraviglia += res1.Select(c => c.Stipendio).Sum();
                }
                textBox1.Text = meraviglia.ToString();
            }
                      

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anno = int.Parse(textBox7.Text);
            int mese = int.Parse(textBox6.Text);
            if (mese < 1 || mese > 12)
            {
                textBox1.Text = "####,##";
            }
            else
            {
                DateTime dataInizio = new DateTime(anno, mese, 1);
                if (int.Parse(textBox6.Text) == 12)
                {
                    anno = anno + 1;
                    mese = 1;
                }
                else
                {
                    mese = mese + 1;
                }
                DateTime dataFine = new DateTime(anno, mese, 1);
                var res = from s in db.SCONTRINO
                          where s.Data_Scontrino <= dataFine && s.Data_Scontrino >= dataInizio
                          select new { s.Totale };
                decimal tot = 0;
                if(res.Count() != 0)
                {
                    tot = res.Select(s => s.Totale).Sum();
                }
                textBox1.Text = tot.ToString();

            }
        }

        private void InsDip_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
