namespace _11_Lista
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAggiungiOgg = new System.Windows.Forms.Button();
            this.btnVisualizzaOgg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(106, 72);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(106, 119);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autore:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(106, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(15, 182);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(120, 29);
            this.btnAggiungi.TabIndex = 6;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(175, 182);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(120, 29);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "Visualizza";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titolo/Autore:";
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(152, 307);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(100, 20);
            this.txtCerca.TabIndex = 9;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(175, 366);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(120, 29);
            this.btnFindAll.TabIndex = 10;
            this.btnFindAll.Text = "FindAll";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(15, 366);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 29);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAggiungiOgg
            // 
            this.btnAggiungiOgg.Location = new System.Drawing.Point(15, 233);
            this.btnAggiungiOgg.Name = "btnAggiungiOgg";
            this.btnAggiungiOgg.Size = new System.Drawing.Size(120, 29);
            this.btnAggiungiOgg.TabIndex = 12;
            this.btnAggiungiOgg.Text = "Aggiungi in obj";
            this.btnAggiungiOgg.UseVisualStyleBackColor = true;
            this.btnAggiungiOgg.Click += new System.EventHandler(this.btnAggiungiOgg_Click);
            // 
            // btnVisualizzaOgg
            // 
            this.btnVisualizzaOgg.Location = new System.Drawing.Point(175, 233);
            this.btnVisualizzaOgg.Name = "btnVisualizzaOgg";
            this.btnVisualizzaOgg.Size = new System.Drawing.Size(120, 29);
            this.btnVisualizzaOgg.TabIndex = 13;
            this.btnVisualizzaOgg.Text = "Visualizza obj";
            this.btnVisualizzaOgg.UseVisualStyleBackColor = true;
            this.btnVisualizzaOgg.Click += new System.EventHandler(this.btnVisualizzaOgg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 443);
            this.Controls.Add(this.btnVisualizzaOgg);
            this.Controls.Add(this.btnAggiungiOgg);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "List e object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAggiungiOgg;
        private System.Windows.Forms.Button btnVisualizzaOgg;
    }
}

