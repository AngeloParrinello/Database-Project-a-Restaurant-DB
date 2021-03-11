namespace KinkhaoForm
{
    partial class FormPrenotaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsDip = new System.Windows.Forms.Label();
            this.butInvia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.labFin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.userControPren1 = new KinkhaoForm.UserControPren();
            this.userControlPrenTel1 = new KinkhaoForm.UserControlPrenTel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InsDip
            // 
            this.InsDip.AutoSize = true;
            this.InsDip.Font = new System.Drawing.Font("Herculanum", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsDip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.InsDip.Location = new System.Drawing.Point(127, 9);
            this.InsDip.Name = "InsDip";
            this.InsDip.Size = new System.Drawing.Size(618, 48);
            this.InsDip.TabIndex = 70;
            this.InsDip.Text = "INSERISCI PRENOTAZIONE";
            this.InsDip.Click += new System.EventHandler(this.InsDip_Click);
            // 
            // butInvia
            // 
            this.butInvia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butInvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInvia.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butInvia.Location = new System.Drawing.Point(254, 60);
            this.butInvia.Name = "butInvia";
            this.butInvia.Size = new System.Drawing.Size(153, 31);
            this.butInvia.TabIndex = 73;
            this.butInvia.Text = "IStantanea";
            this.butInvia.UseVisualStyleBackColor = false;
            this.butInvia.Click += new System.EventHandler(this.butInvia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(470, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 31);
            this.button1.TabIndex = 74;
            this.button1.Text = "Telefonica";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenu.Location = new System.Drawing.Point(387, 634);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(129, 54);
            this.btnMenu.TabIndex = 75;
            this.btnMenu.Text = "Menu\'";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Herculanum", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(233, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 32);
            this.label1.TabIndex = 76;
            this.label1.Text = "ELIMINA PRENOTAZIONE";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(627, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 35);
            this.button2.TabIndex = 81;
            this.button2.Text = "Invia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(507, 331);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(96, 22);
            this.textBox14.TabIndex = 80;
            // 
            // labFin
            // 
            this.labFin.AutoSize = true;
            this.labFin.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labFin.Location = new System.Drawing.Point(533, 313);
            this.labFin.Name = "labFin";
            this.labFin.Size = new System.Drawing.Size(37, 14);
            this.labFin.TabIndex = 79;
            this.labFin.Text = "Ora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(359, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 77;
            this.label4.Text = "Data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 22);
            this.textBox1.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(157, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 82;
            this.label2.Text = "Numero Tavolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Herculanum", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(209, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 32);
            this.label3.TabIndex = 84;
            this.label3.Text = "VISUALIZZA PRENOTAZIONI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 174);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(501, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 35);
            this.button3.TabIndex = 88;
            this.button3.Text = "Invia";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(293, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 86;
            this.label5.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 421);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 89;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // userControPren1
            // 
            this.userControPren1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.userControPren1.Location = new System.Drawing.Point(28, 97);
            this.userControPren1.Name = "userControPren1";
            this.userControPren1.Size = new System.Drawing.Size(830, 176);
            this.userControPren1.TabIndex = 72;
            // 
            // userControlPrenTel1
            // 
            this.userControlPrenTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.userControlPrenTel1.Location = new System.Drawing.Point(28, 97);
            this.userControlPrenTel1.Name = "userControlPrenTel1";
            this.userControlPrenTel1.Size = new System.Drawing.Size(830, 176);
            this.userControlPrenTel1.TabIndex = 71;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(285, 331);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 90;
            // 
            // FormPrenotaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.labFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butInvia);
            this.Controls.Add(this.userControPren1);
            this.Controls.Add(this.userControlPrenTel1);
            this.Controls.Add(this.InsDip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrenotaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrenotaz";
            this.Load += new System.EventHandler(this.FormPrenotaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsDip;
        private UserControlPrenTel userControlPrenTel1;
        private UserControPren userControPren1;
        private System.Windows.Forms.Button butInvia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label labFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}