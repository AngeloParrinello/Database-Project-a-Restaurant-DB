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
    public partial class FormDip : Form
    {
        Form MainMenu;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FormDip(Form menu)
        {
            this.MainMenu = menu;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userControlDip1.Show();
            userControlDip1.BringToFront();
            userControlDip_Contratto1.Hide();
            
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsDip_Click(object sender, EventArgs e)
        {

        }

        private void userControlDip1_Load(object sender, EventArgs e)
        {

        }

        private void btnDip_Click(object sender, EventArgs e)
        {
            userControlDip1.Show();
            userControlDip1.BringToFront();
            userControlDip_Contratto1.Hide();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            userControlDip_Contratto1.Show();
            userControlDip_Contratto1.BringToFront();
            userControlDip1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = (from c in db.CAMERIERE
                      join d in db.GRADIMENTO on c.Codice_Fiscale equals d.Codice_Fiscale
                      group d by new {d.Codice_Fiscale, c.Nome, c.Cognome} into tab
                      orderby tab.Average(d => d.Livello_di_Gradimento) descending
                      select new {tab.Key.Nome, tab.Key.Cognome, tab.Key.Codice_Fiscale, AvgGrad = tab.Average(d => d.Livello_di_Gradimento)}).Take(1);

            this.dataGridView1.DataSource = res;
            
                      
        }

        private void userControlDip_Contratto1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = (from c in db.CONTRATTO
                      where (c.Cameriere_Codice_Fiscale == textBox13.Text
                            || c.Cassiere_Codice_Fiscale == textBox13.Text
                            || c.Cuoco_Codice_Fiscale == textBox13.Text)
                            && (c.Data_Fine == null
                            || c.Data_Fine > dateTimePicker1.Value)
                      select c).ToList();
            foreach(var c in res)
            { 
                    c.Data_Fine = dateTimePicker1.Value;
                
            }
            db.SubmitChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}
