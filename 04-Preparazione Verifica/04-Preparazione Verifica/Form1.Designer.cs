namespace _04_Preparazione_Verifica
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTool = new System.Windows.Forms.ToolStripMenuItem();
            this.formSecondaria = new System.Windows.Forms.ToolStripMenuItem();
            this.formFiglia = new System.Windows.Forms.ToolStripMenuItem();
            this.formDinamica = new System.Windows.Forms.ToolStripMenuItem();
            this.formMDI = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTool = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtModifica = new System.Windows.Forms.TextBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTool,
            this.loadTool,
            this.saveTool,
            this.exitTool});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTool
            // 
            this.newTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formSecondaria,
            this.formFiglia,
            this.formDinamica,
            this.formMDI});
            this.newTool.Name = "newTool";
            this.newTool.Size = new System.Drawing.Size(142, 22);
            this.newTool.Text = "New";
            // 
            // formSecondaria
            // 
            this.formSecondaria.Name = "formSecondaria";
            this.formSecondaria.Size = new System.Drawing.Size(163, 22);
            this.formSecondaria.Text = "Form Second&aria";
            this.formSecondaria.Click += new System.EventHandler(this.formSecondaria_Click);
            // 
            // formFiglia
            // 
            this.formFiglia.Name = "formFiglia";
            this.formFiglia.Size = new System.Drawing.Size(163, 22);
            this.formFiglia.Text = "Form &Figlia";
            this.formFiglia.Click += new System.EventHandler(this.formFiglia_Click);
            // 
            // formDinamica
            // 
            this.formDinamica.Name = "formDinamica";
            this.formDinamica.Size = new System.Drawing.Size(163, 22);
            this.formDinamica.Text = "Form &Dinamica";
            this.formDinamica.Click += new System.EventHandler(this.formDinamica_Click);
            // 
            // formMDI
            // 
            this.formMDI.Name = "formMDI";
            this.formMDI.Size = new System.Drawing.Size(163, 22);
            this.formMDI.Text = "Form &MDI";
            this.formMDI.Click += new System.EventHandler(this.formMDI_Click);
            // 
            // loadTool
            // 
            this.loadTool.Name = "loadTool";
            this.loadTool.Size = new System.Drawing.Size(142, 22);
            this.loadTool.Text = "&Load";
            this.loadTool.Click += new System.EventHandler(this.loadTool_Click);
            // 
            // saveTool
            // 
            this.saveTool.Name = "saveTool";
            this.saveTool.Size = new System.Drawing.Size(142, 22);
            this.saveTool.Text = "&Save";
            this.saveTool.Click += new System.EventHandler(this.saveTool_Click);
            // 
            // exitTool
            // 
            this.exitTool.Name = "exitTool";
            this.exitTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitTool.Size = new System.Drawing.Size(142, 22);
            this.exitTool.Text = "Exit";
            this.exitTool.Click += new System.EventHandler(this.exitTool_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStrip});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStrip
            // 
            this.infoToolStrip.Name = "infoToolStrip";
            this.infoToolStrip.Size = new System.Drawing.Size(95, 22);
            this.infoToolStrip.Text = "&Info";
            this.infoToolStrip.Click += new System.EventHandler(this.infoToolStrip_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 363);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(82, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(69, 117);
            this.txtEta.Name = "txtEta";
            this.txtEta.ReadOnly = true;
            this.txtEta.Size = new System.Drawing.Size(82, 20);
            this.txtEta.TabIndex = 5;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(12, 120);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(26, 13);
            this.lblEta.TabIndex = 4;
            this.lblEta.Text = "Età:";
            // 
            // txtModifica
            // 
            this.txtModifica.Location = new System.Drawing.Point(573, 120);
            this.txtModifica.Name = "txtModifica";
            this.txtModifica.Size = new System.Drawing.Size(100, 20);
            this.txtModifica.TabIndex = 6;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(573, 160);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(100, 32);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtModifica);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTool;
        private System.Windows.Forms.ToolStripMenuItem formSecondaria;
        private System.Windows.Forms.ToolStripMenuItem formFiglia;
        private System.Windows.Forms.ToolStripMenuItem formDinamica;
        private System.Windows.Forms.ToolStripMenuItem formMDI;
        private System.Windows.Forms.ToolStripMenuItem loadTool;
        private System.Windows.Forms.ToolStripMenuItem saveTool;
        private System.Windows.Forms.ToolStripMenuItem exitTool;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtModifica;
        private System.Windows.Forms.Button btnModifica;
    }
}

