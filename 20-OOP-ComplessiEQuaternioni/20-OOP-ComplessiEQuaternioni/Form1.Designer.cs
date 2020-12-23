namespace _20_OOP_ComplessiEQuaternioni
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
            this.txtReale = new System.Windows.Forms.TextBox();
            this.txtIm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnConiugato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parte reale:";
            // 
            // txtReale
            // 
            this.txtReale.Location = new System.Drawing.Point(80, 27);
            this.txtReale.Name = "txtReale";
            this.txtReale.Size = new System.Drawing.Size(100, 20);
            this.txtReale.TabIndex = 1;
            // 
            // txtIm
            // 
            this.txtIm.Location = new System.Drawing.Point(121, 69);
            this.txtIm.Name = "txtIm";
            this.txtIm.Size = new System.Drawing.Size(100, 20);
            this.txtIm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parte immaginaria:";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(16, 130);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(119, 36);
            this.btnInserisci.TabIndex = 4;
            this.btnInserisci.Text = "Inserisci numero complesso";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(153, 130);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(80, 36);
            this.btnModulo.TabIndex = 5;
            this.btnModulo.Text = "MODULO";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnConiugato
            // 
            this.btnConiugato.Location = new System.Drawing.Point(248, 130);
            this.btnConiugato.Name = "btnConiugato";
            this.btnConiugato.Size = new System.Drawing.Size(80, 36);
            this.btnConiugato.TabIndex = 7;
            this.btnConiugato.Text = "CONIUGATO";
            this.btnConiugato.UseVisualStyleBackColor = true;
            this.btnConiugato.Click += new System.EventHandler(this.btnConiugato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 231);
            this.Controls.Add(this.btnConiugato);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtIm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReale;
        private System.Windows.Forms.TextBox txtIm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnConiugato;
    }
}

