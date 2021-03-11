namespace KinkhaoForm
{
    partial class FormCosti
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labMail = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labInd = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsDip
            // 
            this.InsDip.AutoSize = true;
            this.InsDip.Font = new System.Drawing.Font("Herculanum", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsDip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.InsDip.Location = new System.Drawing.Point(93, 25);
            this.InsDip.Name = "InsDip";
            this.InsDip.Size = new System.Drawing.Size(715, 42);
            this.InsDip.TabIndex = 70;
            this.InsDip.Text = "TROVARE RICAVI O COSTI DEL MESE";
            this.InsDip.Click += new System.EventHandler(this.InsDip_Click);
            // 
            // butInvia
            // 
            this.butInvia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butInvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInvia.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInvia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butInvia.Location = new System.Drawing.Point(507, 109);
            this.butInvia.Name = "butInvia";
            this.butInvia.Size = new System.Drawing.Size(96, 30);
            this.butInvia.TabIndex = 75;
            this.butInvia.Text = "Costi";
            this.butInvia.UseVisualStyleBackColor = false;
            this.butInvia.Click += new System.EventHandler(this.butInvia_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(360, 113);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(96, 22);
            this.textBox7.TabIndex = 74;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labMail.Location = new System.Drawing.Point(387, 96);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(45, 14);
            this.labMail.TabIndex = 73;
            this.labMail.Text = "Anno";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(229, 113);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 22);
            this.textBox6.TabIndex = 72;
            // 
            // labInd
            // 
            this.labInd.AutoSize = true;
            this.labInd.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labInd.Location = new System.Drawing.Point(263, 96);
            this.labInd.Name = "labInd";
            this.labInd.Size = new System.Drawing.Size(42, 14);
            this.labInd.TabIndex = 71;
            this.labInd.Text = "Mese";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMenu.Location = new System.Drawing.Point(386, 622);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(129, 54);
            this.btnMenu.TabIndex = 93;
            this.btnMenu.Text = "Menu\'";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Herculanum", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(614, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 94;
            this.button1.Text = "Ricavi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 22);
            this.textBox1.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Herculanum", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(416, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 14);
            this.label1.TabIndex = 96;
            this.label1.Text = "Risultato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(218)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.butInvia);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.labMail);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.labInd);
            this.Controls.Add(this.InsDip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCosti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCosti";
            this.Load += new System.EventHandler(this.FormCosti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsDip;
        private System.Windows.Forms.Button butInvia;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labMail;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labInd;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}