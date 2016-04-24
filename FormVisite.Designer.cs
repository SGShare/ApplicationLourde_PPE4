namespace ApplicationLourde_PPE4
{
    partial class FormVisite
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
            this.cbdepartement = new System.Windows.Forms.ComboBox();
            this.DGV_visite = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_debutperiode = new System.Windows.Forms.ComboBox();
            this.cb_finperiode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_visite)).BeginInit();
            this.SuspendLayout();
            // 
            // cbdepartement
            // 
            this.cbdepartement.FormattingEnabled = true;
            this.cbdepartement.Location = new System.Drawing.Point(335, 26);
            this.cbdepartement.Name = "cbdepartement";
            this.cbdepartement.Size = new System.Drawing.Size(189, 21);
            this.cbdepartement.TabIndex = 0;
            // 
            // DGV_visite
            // 
            this.DGV_visite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_visite.Location = new System.Drawing.Point(172, 122);
            this.DGV_visite.Name = "DGV_visite";
            this.DGV_visite.Size = new System.Drawing.Size(315, 210);
            this.DGV_visite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion par departement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Debut pèriode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fin pèriode :";
            // 
            // cb_debutperiode
            // 
            this.cb_debutperiode.FormattingEnabled = true;
            this.cb_debutperiode.Location = new System.Drawing.Point(172, 78);
            this.cb_debutperiode.Name = "cb_debutperiode";
            this.cb_debutperiode.Size = new System.Drawing.Size(121, 21);
            this.cb_debutperiode.TabIndex = 5;
            // 
            // cb_finperiode
            // 
            this.cb_finperiode.FormattingEnabled = true;
            this.cb_finperiode.Location = new System.Drawing.Point(454, 78);
            this.cb_finperiode.Name = "cb_finperiode";
            this.cb_finperiode.Size = new System.Drawing.Size(121, 21);
            this.cb_finperiode.TabIndex = 6;
            // 
            // FormVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationLourde_PPE4.Properties.Resources.fond1_320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.cb_finperiode);
            this.Controls.Add(this.cb_debutperiode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_visite);
            this.Controls.Add(this.cbdepartement);
            this.Name = "FormVisite";
            this.Text = "FormVisite";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_visite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbdepartement;
        private System.Windows.Forms.DataGridView DGV_visite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_debutperiode;
        private System.Windows.Forms.ComboBox cb_finperiode;
    }
}