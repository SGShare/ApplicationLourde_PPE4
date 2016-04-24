namespace ApplicationLourde_PPE4
{
    partial class FormPrincipale
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
            this.gestionDesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesContrevisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::ApplicationLourde_PPE4.Properties.Resources.fond1_320;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesVisitesToolStripMenuItem,
            this.gestionDesContrevisiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesVisitesToolStripMenuItem
            // 
            this.gestionDesVisitesToolStripMenuItem.Name = "gestionDesVisitesToolStripMenuItem";
            this.gestionDesVisitesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestionDesVisitesToolStripMenuItem.Text = "Gestion des visites";
            this.gestionDesVisitesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesVisitesToolStripMenuItem_Click);
            // 
            // gestionDesContrevisiteToolStripMenuItem
            // 
            this.gestionDesContrevisiteToolStripMenuItem.Name = "gestionDesContrevisiteToolStripMenuItem";
            this.gestionDesContrevisiteToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.gestionDesContrevisiteToolStripMenuItem.Text = "Gestion des contres visites";
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationLourde_PPE4.Properties.Resources.fond1_320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 595);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.Text = "FormInsertionBDD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesContrevisiteToolStripMenuItem;
    }
}

