namespace ApplicationLourde_PPE4
{
    partial class FormLogin
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelMDP = new System.Windows.Forms.Label();
            this.ValidLogin = new System.Windows.Forms.Button();
            this.tb_idlogin = new System.Windows.Forms.TextBox();
            this.tb_mdplogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(41, 94);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(102, 23);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Identifiant :";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMDP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDP.Location = new System.Drawing.Point(41, 178);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(118, 23);
            this.labelMDP.TabIndex = 1;
            this.labelMDP.Text = "Mot De Passe :";
            // 
            // ValidLogin
            // 
            this.ValidLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidLogin.Location = new System.Drawing.Point(182, 267);
            this.ValidLogin.Name = "ValidLogin";
            this.ValidLogin.Size = new System.Drawing.Size(85, 32);
            this.ValidLogin.TabIndex = 4;
            this.ValidLogin.Text = "Valider";
            this.ValidLogin.UseVisualStyleBackColor = true;
            this.ValidLogin.Click += new System.EventHandler(this.ValidLogin_Click);
            // 
            // tb_idlogin
            // 
            this.tb_idlogin.Location = new System.Drawing.Point(198, 97);
            this.tb_idlogin.Name = "tb_idlogin";
            this.tb_idlogin.Size = new System.Drawing.Size(160, 20);
            this.tb_idlogin.TabIndex = 5;
            // 
            // tb_mdplogin
            // 
            this.tb_mdplogin.Location = new System.Drawing.Point(198, 180);
            this.tb_mdplogin.Name = "tb_mdplogin";
            this.tb_mdplogin.PasswordChar = '*';
            this.tb_mdplogin.Size = new System.Drawing.Size(160, 20);
            this.tb_mdplogin.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationLourde_PPE4.Properties.Resources.fond1_320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 379);
            this.Controls.Add(this.tb_mdplogin);
            this.Controls.Add(this.tb_idlogin);
            this.Controls.Add(this.ValidLogin);
            this.Controls.Add(this.labelMDP);
            this.Controls.Add(this.labelID);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.Button ValidLogin;
        private System.Windows.Forms.TextBox tb_idlogin;
        private System.Windows.Forms.TextBox tb_mdplogin;
    }
}