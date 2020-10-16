namespace _04_Preparazione_Verifica
{
    partial class Form2
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
            this.txtEta1 = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnAnnullaInvio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEta1
            // 
            this.txtEta1.Location = new System.Drawing.Point(92, 112);
            this.txtEta1.Margin = new System.Windows.Forms.Padding(4);
            this.txtEta1.Name = "txtEta1";
            this.txtEta1.Size = new System.Drawing.Size(108, 22);
            this.txtEta1.TabIndex = 9;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(16, 116);
            this.lblEta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(33, 17);
            this.lblEta.TabIndex = 8;
            this.lblEta.Text = "Età:";
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(92, 52);
            this.txtNome1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(108, 22);
            this.txtNome1.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 55);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(20, 218);
            this.btnInvia.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(181, 41);
            this.btnInvia.TabIndex = 10;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click_1);
            // 
            // btnAnnullaInvio
            // 
            this.btnAnnullaInvio.Location = new System.Drawing.Point(284, 218);
            this.btnAnnullaInvio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnullaInvio.Name = "btnAnnullaInvio";
            this.btnAnnullaInvio.Size = new System.Drawing.Size(181, 41);
            this.btnAnnullaInvio.TabIndex = 11;
            this.btnAnnullaInvio.Text = "Annulla";
            this.btnAnnullaInvio.UseVisualStyleBackColor = true;
            this.btnAnnullaInvio.Click += new System.EventHandler(this.btnAnnullaInvio_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 464);
            this.Controls.Add(this.btnAnnullaInvio);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtEta1);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txtNome1);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEta1;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnAnnullaInvio;
    }
}