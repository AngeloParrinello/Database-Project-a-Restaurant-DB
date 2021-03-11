namespace KinkhaoForm
{
    partial class FormDip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMenu = new System.Windows.Forms.Button();
            this.InsDip = new System.Windows.Forms.Label();
            this.LicDip = new System.Windows.Forms.Label();
            this.CamGrad = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labFin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnDip = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.userControlDip_Contratto1 = new KinkhaoForm.UserControlDip_Contratto();
            this.userControlDip1 = new KinkhaoForm.UserControlDip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenu.Location = new System.Drawing.Point(405, 634);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(129, 54);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu\'";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // InsDip
            // 
            this.InsDip.AutoSize = true;
            this.InsDip.Font = new System.Drawing.Font("Herculanum", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsDip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.InsDip.Location = new System.Drawing.Point(349, 9);
            this.InsDip.Name = "InsDip";
            this.InsDip.Size = new System.Drawing.Size(237, 48);
            this.InsDip.TabIndex = 1;
            this.InsDip.Text = "INSERISCI";
            this.InsDip.Click += new System.EventHandler(this.InsDip_Click);
            // 
            // LicDip
            // 
            this.LicDip.AutoSize = true;
            this.LicDip.Font = new System.Drawing.Font("Herculanum", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicDip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LicDip.Location = new System.Drawing.Point(218, 296);
            this.LicDip.Name = "LicDip";
            this.LicDip.Size = new System.Drawing.Size(496, 32);
            this.LicDip.TabIndex = 2;
            this.LicDip.Text = "LICENZIAMENTO DIPENDENTE";
            // 
            // CamGrad
            // 
            this.CamGrad.AutoSize = true;
            this.CamGrad.Font = new System.Drawing.Font("Herculanum", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamGrad.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CamGrad.Location = new System.Drawing.Point(258, 399);
            this.CamGrad.Name = "CamGrad";
            this.CamGrad.Size = new System.Drawing.Size(422, 32);
            this.CamGrad.TabIndex = 3;
            this.CamGrad.Text = "CAMERIERE MAX GRADITO";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(248, 358);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(96, 22);
            this.textBox13.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(245, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Codice Fiscale";
            // 
            // labFin
            // 
            this.labFin.AutoSize = true;
            this.labFin.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labFin.Location = new System.Drawing.Point(379, 341);
            this.labFin.Name = "labFin";
            this.labFin.Size = new System.Drawing.Size(77, 14);
            this.labFin.TabIndex = 30;
            this.labFin.Text = "Data Fine";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(224, 478);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(490, 150);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCont.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCont.Location = new System.Drawing.Point(465, 65);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(144, 43);
            this.btnCont.TabIndex = 51;
            this.btnCont.Text = "Contratto";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnDip
            // 
            this.btnDip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDip.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDip.Location = new System.Drawing.Point(312, 65);
            this.btnDip.Name = "btnDip";
            this.btnDip.Size = new System.Drawing.Size(147, 43);
            this.btnDip.TabIndex = 52;
            this.btnDip.Text = "Dipendente";
            this.btnDip.UseVisualStyleBackColor = false;
            this.btnDip.Click += new System.EventHandler(this.btnDip_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(592, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 56;
            this.button1.Text = "Invia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(408, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 35);
            this.button2.TabIndex = 57;
            this.button2.Text = "Invia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(375, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // userControlDip_Contratto1
            // 
            this.userControlDip_Contratto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.userControlDip_Contratto1.Location = new System.Drawing.Point(41, 114);
            this.userControlDip_Contratto1.Name = "userControlDip_Contratto1";
            this.userControlDip_Contratto1.Size = new System.Drawing.Size(830, 176);
            this.userControlDip_Contratto1.TabIndex = 55;
            this.userControlDip_Contratto1.Load += new System.EventHandler(this.userControlDip_Contratto1_Load);
            // 
            // userControlDip1
            // 
            this.userControlDip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.userControlDip1.Location = new System.Drawing.Point(41, 114);
            this.userControlDip1.Name = "userControlDip1";
            this.userControlDip1.Size = new System.Drawing.Size(830, 176);
            this.userControlDip1.TabIndex = 54;
            // 
            // FormDip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControlDip_Contratto1);
            this.Controls.Add(this.userControlDip1);
            this.Controls.Add(this.btnDip);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labFin);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CamGrad);
            this.Controls.Add(this.LicDip);
            this.Controls.Add(this.InsDip);
            this.Controls.Add(this.btnMenu);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dipendenti";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label InsDip;
        private System.Windows.Forms.Label LicDip;
        private System.Windows.Forms.Label CamGrad;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labFin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnDip;
        private UserControlDip userControlDip1;
        private UserControlDip_Contratto userControlDip_Contratto1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}