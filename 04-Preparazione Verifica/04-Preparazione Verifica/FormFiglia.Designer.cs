namespace _04_Preparazione_Verifica
{
    partial class FormFiglia
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
            this.txtModificaForm = new System.Windows.Forms.TextBox();
            this.lblModifica = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModificaForm
            // 
            this.txtModificaForm.Location = new System.Drawing.Point(108, 79);
            this.txtModificaForm.Name = "txtModificaForm";
            this.txtModificaForm.Size = new System.Drawing.Size(111, 20);
            this.txtModificaForm.TabIndex = 0;
            // 
            // lblModifica
            // 
            this.lblModifica.AutoSize = true;
            this.lblModifica.Location = new System.Drawing.Point(40, 82);
            this.lblModifica.Name = "lblModifica";
            this.lblModifica.Size = new System.Drawing.Size(43, 13);
            this.lblModifica.TabIndex = 1;
            this.lblModifica.Text = "Stringa:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "MODIFICA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnModificaForm_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblModifica);
            this.Controls.Add(this.txtModificaForm);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModificaForm;
        private System.Windows.Forms.Label lblModifica;
        private System.Windows.Forms.Button button1;
    }
}