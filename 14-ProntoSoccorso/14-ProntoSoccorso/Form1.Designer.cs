namespace _15_ProntoSoccorso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEtà = new System.Windows.Forms.TextBox();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.lblPaziente = new System.Windows.Forms.Label();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnDisponibile = new System.Windows.Forms.Button();
            this.btnTemperatura = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Età:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codice:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEtà
            // 
            this.txtEtà.Location = new System.Drawing.Point(77, 63);
            this.txtEtà.Name = "txtEtà";
            this.txtEtà.Size = new System.Drawing.Size(100, 20);
            this.txtEtà.TabIndex = 4;
            // 
            // cmbColore
            // 
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "Rosso ",
            "Giallo",
            "Verde",
            "Bianco"});
            this.cmbColore.Location = new System.Drawing.Point(77, 102);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(100, 21);
            this.cmbColore.TabIndex = 5;
            // 
            // lblPaziente
            // 
            this.lblPaziente.AutoSize = true;
            this.lblPaziente.Location = new System.Drawing.Point(213, 28);
            this.lblPaziente.Name = "lblPaziente";
            this.lblPaziente.Size = new System.Drawing.Size(199, 13);
            this.lblPaziente.TabIndex = 6;
            this.lblPaziente.Text = "Ultimo Paziente visitato: nessun paziente";
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(12, 166);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(101, 30);
            this.btnCarica.TabIndex = 7;
            this.btnCarica.Text = "Carica Paziente";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnDisponibile
            // 
            this.btnDisponibile.Location = new System.Drawing.Point(141, 166);
            this.btnDisponibile.Name = "btnDisponibile";
            this.btnDisponibile.Size = new System.Drawing.Size(107, 30);
            this.btnDisponibile.TabIndex = 8;
            this.btnDisponibile.Text = "Medico Paziente";
            this.btnDisponibile.UseVisualStyleBackColor = true;
            this.btnDisponibile.Click += new System.EventHandler(this.btnDisponibile_Click);
            // 
            // btnTemperatura
            // 
            this.btnTemperatura.Location = new System.Drawing.Point(269, 166);
            this.btnTemperatura.Name = "btnTemperatura";
            this.btnTemperatura.Size = new System.Drawing.Size(177, 30);
            this.btnTemperatura.TabIndex = 9;
            this.btnTemperatura.Text = "Temperatura massima e minima";
            this.btnTemperatura.UseVisualStyleBackColor = true;
            this.btnTemperatura.Click += new System.EventHandler(this.btnTemperatura_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(213, 70);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(215, 13);
            this.lblMax.TabIndex = 10;
            this.lblMax.Text = "Temperatura massima: nessuna temperatura";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(213, 110);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(207, 13);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "Temperatura minima: nessuna temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 224);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.btnTemperatura);
            this.Controls.Add(this.btnDisponibile);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.lblPaziente);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.txtEtà);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pronto Soccorso con coda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEtà;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Label lblPaziente;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnDisponibile;
        private System.Windows.Forms.Button btnTemperatura;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
    }
}

