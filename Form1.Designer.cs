namespace ApplicationLourde_PPE4
{
    partial class FormInsertionBDD
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉtoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommentaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertionToolStripMenuItem,
            this.inspecteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertionToolStripMenuItem
            // 
            this.insertionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.insertionToolStripMenuItem.Name = "insertionToolStripMenuItem";
            this.insertionToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.insertionToolStripMenuItem.Text = "BDD";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // inspecteurToolStripMenuItem
            // 
            this.inspecteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVisiteToolStripMenuItem,
            this.gestionÉtoileToolStripMenuItem,
            this.gestionCommentaireToolStripMenuItem});
            this.inspecteurToolStripMenuItem.Name = "inspecteurToolStripMenuItem";
            this.inspecteurToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.inspecteurToolStripMenuItem.Text = "Inspecteur";
            // 
            // gestionVisiteToolStripMenuItem
            // 
            this.gestionVisiteToolStripMenuItem.Name = "gestionVisiteToolStripMenuItem";
            this.gestionVisiteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gestionVisiteToolStripMenuItem.Text = "Gestion visite";
            // 
            // gestionÉtoileToolStripMenuItem
            // 
            this.gestionÉtoileToolStripMenuItem.Name = "gestionÉtoileToolStripMenuItem";
            this.gestionÉtoileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gestionÉtoileToolStripMenuItem.Text = "Gestion étoile";
            // 
            // gestionCommentaireToolStripMenuItem
            // 
            this.gestionCommentaireToolStripMenuItem.Name = "gestionCommentaireToolStripMenuItem";
            this.gestionCommentaireToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gestionCommentaireToolStripMenuItem.Text = "Gestion commentaire";
            // 
            // FormInsertionBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 434);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInsertionBDD";
            this.Text = "FormInsertionBDD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionÉtoileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCommentaireToolStripMenuItem;
    }
}

