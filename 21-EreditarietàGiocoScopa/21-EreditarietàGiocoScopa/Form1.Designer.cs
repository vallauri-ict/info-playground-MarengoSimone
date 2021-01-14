namespace _21_EreditarietàGiocoScopa
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
            this.btnMazzo = new System.Windows.Forms.Button();
            this.btnPesca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiocatore1 = new System.Windows.Forms.TextBox();
            this.listG1 = new System.Windows.Forms.ListBox();
            this.txtGiocatore2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listG2 = new System.Windows.Forms.ListBox();
            this.listBanco = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMazzo
            // 
            this.btnMazzo.Location = new System.Drawing.Point(254, 99);
            this.btnMazzo.Name = "btnMazzo";
            this.btnMazzo.Size = new System.Drawing.Size(131, 31);
            this.btnMazzo.TabIndex = 0;
            this.btnMazzo.Text = "Nuovo Mazzo";
            this.btnMazzo.UseVisualStyleBackColor = true;
            this.btnMazzo.Click += new System.EventHandler(this.btnMazzo_Click);
            // 
            // btnPesca
            // 
            this.btnPesca.Location = new System.Drawing.Point(510, 99);
            this.btnPesca.Name = "btnPesca";
            this.btnPesca.Size = new System.Drawing.Size(131, 31);
            this.btnPesca.TabIndex = 1;
            this.btnPesca.Text = "Pesca Carta";
            this.btnPesca.UseVisualStyleBackColor = true;
            this.btnPesca.Click += new System.EventHandler(this.btnPesca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome giocatore 1:";
            // 
            // txtGiocatore1
            // 
            this.txtGiocatore1.Location = new System.Drawing.Point(285, 38);
            this.txtGiocatore1.Name = "txtGiocatore1";
            this.txtGiocatore1.Size = new System.Drawing.Size(100, 20);
            this.txtGiocatore1.TabIndex = 3;
            // 
            // listG1
            // 
            this.listG1.FormattingEnabled = true;
            this.listG1.Location = new System.Drawing.Point(70, 181);
            this.listG1.Name = "listG1";
            this.listG1.Size = new System.Drawing.Size(172, 238);
            this.listG1.TabIndex = 4;
            // 
            // txtGiocatore2
            // 
            this.txtGiocatore2.Location = new System.Drawing.Point(541, 38);
            this.txtGiocatore2.Name = "txtGiocatore2";
            this.txtGiocatore2.Size = new System.Drawing.Size(100, 20);
            this.txtGiocatore2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(434, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome giocatore 2:";
            // 
            // listG2
            // 
            this.listG2.FormattingEnabled = true;
            this.listG2.Location = new System.Drawing.Point(610, 181);
            this.listG2.Name = "listG2";
            this.listG2.Size = new System.Drawing.Size(172, 238);
            this.listG2.TabIndex = 7;
            // 
            // listBanco
            // 
            this.listBanco.FormattingEnabled = true;
            this.listBanco.Location = new System.Drawing.Point(360, 219);
            this.listBanco.Name = "listBanco";
            this.listBanco.Size = new System.Drawing.Size(140, 108);
            this.listBanco.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(385, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Carte del banco:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(857, 487);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBanco);
            this.Controls.Add(this.listG2);
            this.Controls.Add(this.txtGiocatore2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listG1);
            this.Controls.Add(this.txtGiocatore1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesca);
            this.Controls.Add(this.btnMazzo);
            this.Name = "Form1";
            this.Text = "Gioco Scopa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMazzo;
        private System.Windows.Forms.Button btnPesca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiocatore1;
        private System.Windows.Forms.ListBox listG1;
        private System.Windows.Forms.TextBox txtGiocatore2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listG2;
        private System.Windows.Forms.ListBox listBanco;
        private System.Windows.Forms.Label label3;
    }
}

