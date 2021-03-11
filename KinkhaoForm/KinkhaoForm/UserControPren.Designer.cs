namespace KinkhaoForm
{
    partial class UserControPren
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labGen = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCog = new System.Windows.Forms.Label();
            this.butInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(444, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 22);
            this.textBox4.TabIndex = 41;
            // 
            // labGen
            // 
            this.labGen.AutoSize = true;
            this.labGen.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGen.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labGen.Location = new System.Drawing.Point(433, 32);
            this.labGen.Name = "labGen";
            this.labGen.Size = new System.Drawing.Size(130, 14);
            this.labGen.TabIndex = 40;
            this.labGen.Text = "Numero persone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 22);
            this.textBox3.TabIndex = 39;
            // 
            // labelCog
            // 
            this.labelCog.AutoSize = true;
            this.labelCog.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCog.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelCog.Location = new System.Drawing.Point(268, 32);
            this.labelCog.Name = "labelCog";
            this.labelCog.Size = new System.Drawing.Size(125, 14);
            this.labelCog.TabIndex = 38;
            this.labelCog.Text = "Numero Tavolo";
            // 
            // butInvia
            // 
            this.butInvia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butInvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInvia.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butInvia.Location = new System.Drawing.Point(367, 118);
            this.butInvia.Name = "butInvia";
            this.butInvia.Size = new System.Drawing.Size(96, 30);
            this.butInvia.TabIndex = 52;
            this.butInvia.Text = "Invia Dati";
            this.butInvia.UseVisualStyleBackColor = false;
            this.butInvia.Click += new System.EventHandler(this.butInvia_Click);
            // 
            // UserControPren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.butInvia);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labGen);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelCog);
            this.Name = "UserControPren";
            this.Size = new System.Drawing.Size(830, 176);
            this.Load += new System.EventHandler(this.UserControPren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labGen;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelCog;
        private System.Windows.Forms.Button butInvia;
    }
}
