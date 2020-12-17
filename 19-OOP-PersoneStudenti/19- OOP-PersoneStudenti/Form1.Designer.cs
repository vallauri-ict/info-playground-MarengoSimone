namespace _19__OOP_PersoneStudenti
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
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnVoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(85, 27);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cognome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sesso:";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(85, 114);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 20);
            this.txtSesso.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Età:";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(85, 161);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 6;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(15, 208);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(170, 31);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(219, 208);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(170, 31);
            this.btnMedia.TabIndex = 9;
            this.btnMedia.Text = "Media Studente";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Voto:";
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(289, 85);
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(100, 20);
            this.txtVoto.TabIndex = 10;
            // 
            // btnVoto
            // 
            this.btnVoto.Location = new System.Drawing.Point(235, 117);
            this.btnVoto.Name = "btnVoto";
            this.btnVoto.Size = new System.Drawing.Size(154, 35);
            this.btnVoto.TabIndex = 12;
            this.btnVoto.Text = "Aggiungi Voto";
            this.btnVoto.UseVisualStyleBackColor = true;
            this.btnVoto.Click += new System.EventHandler(this.btnVoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 276);
            this.Controls.Add(this.btnVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Button btnVoto;
    }
}

