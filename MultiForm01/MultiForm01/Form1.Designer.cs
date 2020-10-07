namespace MultiForm01
{
    partial class Form1
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
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnApriForm2b = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.txtNomeFM = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEtaFM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(24, 24);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(103, 29);
            this.btnForm2.TabIndex = 0;
            this.btnForm2.Text = "Apri Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnApriForm2b
            // 
            this.btnApriForm2b.Location = new System.Drawing.Point(195, 24);
            this.btnApriForm2b.Name = "btnApriForm2b";
            this.btnApriForm2b.Size = new System.Drawing.Size(103, 29);
            this.btnApriForm2b.TabIndex = 1;
            this.btnApriForm2b.Text = "Apri Form2b";
            this.btnApriForm2b.UseVisualStyleBackColor = true;
            this.btnApriForm2b.Click += new System.EventHandler(this.btnApriForm2b_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(24, 96);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(136, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(195, 94);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(103, 23);
            this.btnPassaTxt.TabIndex = 3;
            this.btnPassaTxt.Text = "Passa TXT a F2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(24, 239);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(136, 29);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "Apri Form Modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // txtNomeFM
            // 
            this.txtNomeFM.Location = new System.Drawing.Point(85, 181);
            this.txtNomeFM.Name = "txtNomeFM";
            this.txtNomeFM.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFM.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(24, 188);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Età:";
            // 
            // txtEtaFM
            // 
            this.txtEtaFM.Location = new System.Drawing.Point(366, 181);
            this.txtEtaFM.Name = "txtEtaFM";
            this.txtEtaFM.Size = new System.Drawing.Size(100, 20);
            this.txtEtaFM.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtaFM);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtNomeFM);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnApriForm2b);
            this.Controls.Add(this.btnForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnApriForm2b;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.Button btnFormModale;
        private System.Windows.Forms.TextBox txtNomeFM;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEtaFM;
    }
}

