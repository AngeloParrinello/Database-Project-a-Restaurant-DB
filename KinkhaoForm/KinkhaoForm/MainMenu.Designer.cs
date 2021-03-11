namespace KinkhaoForm
{
    partial class MainMenu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrd = new System.Windows.Forms.Button();
            this.btnPren = new System.Windows.Forms.Button();
            this.btnCosti = new System.Windows.Forms.Button();
            this.btnTurni = new System.Windows.Forms.Button();
            this.btnDip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrd
            // 
            this.btnOrd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.btnOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrd.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrd.Location = new System.Drawing.Point(371, 180);
            this.btnOrd.Name = "btnOrd";
            this.btnOrd.Size = new System.Drawing.Size(166, 69);
            this.btnOrd.TabIndex = 1;
            this.btnOrd.Text = "Ordini e Fornitori";
            this.btnOrd.UseVisualStyleBackColor = false;
            this.btnOrd.Click += new System.EventHandler(this.btnOrd_Click);
            // 
            // btnPren
            // 
            this.btnPren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.btnPren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPren.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPren.Location = new System.Drawing.Point(371, 302);
            this.btnPren.Name = "btnPren";
            this.btnPren.Size = new System.Drawing.Size(166, 69);
            this.btnPren.TabIndex = 2;
            this.btnPren.Text = "Prenotazioni";
            this.btnPren.UseVisualStyleBackColor = false;
            this.btnPren.Click += new System.EventHandler(this.btnPren_Click);
            // 
            // btnCosti
            // 
            this.btnCosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCosti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.btnCosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosti.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosti.Location = new System.Drawing.Point(371, 424);
            this.btnCosti.Name = "btnCosti";
            this.btnCosti.Size = new System.Drawing.Size(166, 69);
            this.btnCosti.TabIndex = 3;
            this.btnCosti.Text = "Costi e Ricavi";
            this.btnCosti.UseVisualStyleBackColor = false;
            this.btnCosti.Click += new System.EventHandler(this.btnCosti_Click);
            // 
            // btnTurni
            // 
            this.btnTurni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTurni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.btnTurni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurni.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurni.Location = new System.Drawing.Point(371, 546);
            this.btnTurni.Name = "btnTurni";
            this.btnTurni.Size = new System.Drawing.Size(166, 69);
            this.btnTurni.TabIndex = 4;
            this.btnTurni.Text = "Turni";
            this.btnTurni.UseVisualStyleBackColor = false;
            this.btnTurni.Click += new System.EventHandler(this.btnTurni_Click);
            // 
            // btnDip
            // 
            this.btnDip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.btnDip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDip.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDip.Location = new System.Drawing.Point(371, 68);
            this.btnDip.Name = "btnDip";
            this.btnDip.Size = new System.Drawing.Size(166, 69);
            this.btnDip.TabIndex = 5;
            this.btnDip.Text = "Dipendenti";
            this.btnDip.UseVisualStyleBackColor = false;
            this.btnDip.Click += new System.EventHandler(this.btnDip_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::KinkhaoForm.Properties.Resources.KinkhaoBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnDip);
            this.Controls.Add(this.btnTurni);
            this.Controls.Add(this.btnCosti);
            this.Controls.Add(this.btnPren);
            this.Controls.Add(this.btnOrd);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KinkhaoDB";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrd;
        private System.Windows.Forms.Button btnPren;
        private System.Windows.Forms.Button btnCosti;
        private System.Windows.Forms.Button btnTurni;
        private System.Windows.Forms.Button btnDip;
    }
}

