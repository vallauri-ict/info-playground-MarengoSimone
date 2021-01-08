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
            this.txtImmaginario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModulo = new System.Windows.Forms.Button();
            this.txtImmaginarioD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImmaginarioC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModuloQuaternione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reale:";
            // 
            // txtReale
            // 
            this.txtReale.Location = new System.Drawing.Point(121, 27);
            this.txtReale.Name = "txtReale";
            this.txtReale.Size = new System.Drawing.Size(100, 20);
            this.txtReale.TabIndex = 1;
            // 
            // txtImmaginario
            // 
            this.txtImmaginario.Location = new System.Drawing.Point(121, 69);
            this.txtImmaginario.Name = "txtImmaginario";
            this.txtImmaginario.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Immaginario:";
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(158, 217);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(104, 36);
            this.btnModulo.TabIndex = 5;
            this.btnModulo.Text = "MODULO COMPLESSO";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // txtImmaginarioD
            // 
            this.txtImmaginarioD.Location = new System.Drawing.Point(121, 154);
            this.txtImmaginarioD.Name = "txtImmaginarioD";
            this.txtImmaginarioD.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginarioD.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Immaginario D:";
            // 
            // txtImmaginarioC
            // 
            this.txtImmaginarioC.Location = new System.Drawing.Point(121, 112);
            this.txtImmaginarioC.Name = "txtImmaginarioC";
            this.txtImmaginarioC.Size = new System.Drawing.Size(100, 20);
            this.txtImmaginarioC.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Immaginario C:";
            // 
            // btnModuloQuaternione
            // 
            this.btnModuloQuaternione.Location = new System.Drawing.Point(16, 217);
            this.btnModuloQuaternione.Name = "btnModuloQuaternione";
            this.btnModuloQuaternione.Size = new System.Drawing.Size(112, 36);
            this.btnModuloQuaternione.TabIndex = 12;
            this.btnModuloQuaternione.Text = "MODULO QUATERNIONE";
            this.btnModuloQuaternione.UseVisualStyleBackColor = true;
            this.btnModuloQuaternione.Click += new System.EventHandler(this.btnModuloQuaternione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 272);
            this.Controls.Add(this.btnModuloQuaternione);
            this.Controls.Add(this.txtImmaginarioD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImmaginarioC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.txtImmaginario);
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
        private System.Windows.Forms.TextBox txtImmaginario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.TextBox txtImmaginarioD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImmaginarioC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModuloQuaternione;
    }
}

