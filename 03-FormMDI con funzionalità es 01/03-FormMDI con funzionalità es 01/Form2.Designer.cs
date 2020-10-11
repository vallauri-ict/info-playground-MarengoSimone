namespace _03_FormMDI_con_funzionalità_es_01
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
            this.txtForm2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leggiValore = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormFigliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaAForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtForm2
            // 
            this.txtForm2.Location = new System.Drawing.Point(12, 47);
            this.txtForm2.Name = "txtForm2";
            this.txtForm2.Size = new System.Drawing.Size(132, 20);
            this.txtForm2.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leggiValore,
            this.apriFormFigliaToolStripMenuItem,
            this.inviaAForm});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.menùToolStripMenuItem.Text = "&Menù Form 2";
            // 
            // leggiValore
            // 
            this.leggiValore.Name = "leggiValore";
            this.leggiValore.Size = new System.Drawing.Size(180, 22);
            this.leggiValore.Text = "Leggi Valore";
            this.leggiValore.Click += new System.EventHandler(this.leggiValore_Click);
            // 
            // apriFormFigliaToolStripMenuItem
            // 
            this.apriFormFigliaToolStripMenuItem.Name = "apriFormFigliaToolStripMenuItem";
            this.apriFormFigliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriFormFigliaToolStripMenuItem.Text = "Apri Form Figlia";
            this.apriFormFigliaToolStripMenuItem.Click += new System.EventHandler(this.apriFormFiglia_Click);
            // 
            // inviaAForm
            // 
            this.inviaAForm.Name = "inviaAForm";
            this.inviaAForm.Size = new System.Drawing.Size(180, 22);
            this.inviaAForm.Text = "Invia a Form";
            this.inviaAForm.Click += new System.EventHandler(this.inviaAForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 272);
            this.Controls.Add(this.txtForm2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtForm2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leggiValore;
        private System.Windows.Forms.ToolStripMenuItem apriFormFigliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inviaAForm;
    }
}