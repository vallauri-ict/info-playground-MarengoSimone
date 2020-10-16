namespace _04_Preparazione_Verifica
{
    partial class FormMDI
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
            this.btnApriFiglio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApriFiglio
            // 
            this.btnApriFiglio.Location = new System.Drawing.Point(12, 24);
            this.btnApriFiglio.Name = "btnApriFiglio";
            this.btnApriFiglio.Size = new System.Drawing.Size(100, 33);
            this.btnApriFiglio.TabIndex = 1;
            this.btnApriFiglio.Text = "Apri Figlio";
            this.btnApriFiglio.UseVisualStyleBackColor = true;
            this.btnApriFiglio.Click += new System.EventHandler(this.btnApriFiglio_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 352);
            this.Controls.Add(this.btnApriFiglio);
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApriFiglio;
    }
}