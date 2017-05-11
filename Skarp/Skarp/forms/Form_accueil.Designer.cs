namespace Skarp.forms {
    partial class Form_accueil {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.panel_login = new System.Windows.Forms.Panel();
            this.lb_identification = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_createAccount = new System.Windows.Forms.Label();
            this.bt_identification = new System.Windows.Forms.Button();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.panel_create_account = new System.Windows.Forms.Panel();
            this.label_se_connecter = new System.Windows.Forms.Label();
            this.bouton_inscription = new System.Windows.Forms.Button();
            this.cb_choix_langue = new System.Windows.Forms.ComboBox();
            this.tb_pseudo = new System.Windows.Forms.TextBox();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.tb_password1 = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.lb_create_account = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_french = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            this.panel_create_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_french)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.BackgroundImage = global::Skarp.Properties.Resources.fond_login;
            this.panel_login.Controls.Add(this.lb_identification);
            this.panel_login.Controls.Add(this.tb_login);
            this.panel_login.Controls.Add(this.lb_createAccount);
            this.panel_login.Controls.Add(this.bt_identification);
            this.panel_login.Controls.Add(this.tb_pwd);
            this.panel_login.Location = new System.Drawing.Point(575, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(225, 628);
            this.panel_login.TabIndex = 19;
            // 
            // lb_identification
            // 
            this.lb_identification.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold);
            this.lb_identification.Location = new System.Drawing.Point(-2, 387);
            this.lb_identification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_identification.Name = "lb_identification";
            this.lb_identification.Size = new System.Drawing.Size(222, 36);
            this.lb_identification.TabIndex = 5;
            this.lb_identification.Text = "Identification";
            this.lb_identification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.Color.Black;
            this.tb_login.ForeColor = System.Drawing.Color.White;
            this.tb_login.Location = new System.Drawing.Point(12, 438);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(194, 32);
            this.tb_login.TabIndex = 6;
            this.tb_login.Text = "Login";
            // 
            // lb_createAccount
            // 
            this.lb_createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_createAccount.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_createAccount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_createAccount.Location = new System.Drawing.Point(0, 592);
            this.lb_createAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_createAccount.Name = "lb_createAccount";
            this.lb_createAccount.Size = new System.Drawing.Size(222, 36);
            this.lb_createAccount.TabIndex = 9;
            this.lb_createAccount.Text = "Créer un compte";
            this.lb_createAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_createAccount.Click += new System.EventHandler(this.lb_createAccount_Click);
            // 
            // bt_identification
            // 
            this.bt_identification.BackColor = System.Drawing.Color.Black;
            this.bt_identification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_identification.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold);
            this.bt_identification.ForeColor = System.Drawing.Color.White;
            this.bt_identification.Location = new System.Drawing.Point(14, 538);
            this.bt_identification.Name = "bt_identification";
            this.bt_identification.Size = new System.Drawing.Size(194, 50);
            this.bt_identification.TabIndex = 8;
            this.bt_identification.Text = "Go";
            this.bt_identification.UseVisualStyleBackColor = false;
            this.bt_identification.Click += new System.EventHandler(this.bt_identification_Click_1);
            // 
            // tb_pwd
            // 
            this.tb_pwd.BackColor = System.Drawing.Color.Black;
            this.tb_pwd.ForeColor = System.Drawing.Color.White;
            this.tb_pwd.Location = new System.Drawing.Point(11, 489);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(194, 32);
            this.tb_pwd.TabIndex = 7;
            this.tb_pwd.Text = "Password";
            // 
            // panel_create_account
            // 
            this.panel_create_account.BackColor = System.Drawing.Color.Transparent;
            this.panel_create_account.BackgroundImage = global::Skarp.Properties.Resources.fond_login;
            this.panel_create_account.Controls.Add(this.label_se_connecter);
            this.panel_create_account.Controls.Add(this.bouton_inscription);
            this.panel_create_account.Controls.Add(this.cb_choix_langue);
            this.panel_create_account.Controls.Add(this.tb_pseudo);
            this.panel_create_account.Controls.Add(this.tb_password2);
            this.panel_create_account.Controls.Add(this.tb_password1);
            this.panel_create_account.Controls.Add(this.tb_email);
            this.panel_create_account.Controls.Add(this.tb_nom);
            this.panel_create_account.Controls.Add(this.tb_prenom);
            this.panel_create_account.Controls.Add(this.lb_create_account);
            this.panel_create_account.Location = new System.Drawing.Point(575, 0);
            this.panel_create_account.Name = "panel_create_account";
            this.panel_create_account.Size = new System.Drawing.Size(225, 628);
            this.panel_create_account.TabIndex = 20;
            // 
            // label_se_connecter
            // 
            this.label_se_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_se_connecter.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_se_connecter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_se_connecter.Location = new System.Drawing.Point(0, 592);
            this.label_se_connecter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_se_connecter.Name = "label_se_connecter";
            this.label_se_connecter.Size = new System.Drawing.Size(222, 36);
            this.label_se_connecter.TabIndex = 10;
            this.label_se_connecter.Text = "Se connecter";
            this.label_se_connecter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_se_connecter.Click += new System.EventHandler(this.label_se_connecter_Click);
            // 
            // bouton_inscription
            // 
            this.bouton_inscription.BackColor = System.Drawing.Color.Black;
            this.bouton_inscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bouton_inscription.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold);
            this.bouton_inscription.ForeColor = System.Drawing.Color.White;
            this.bouton_inscription.Location = new System.Drawing.Point(14, 538);
            this.bouton_inscription.Name = "bouton_inscription";
            this.bouton_inscription.Size = new System.Drawing.Size(194, 50);
            this.bouton_inscription.TabIndex = 10;
            this.bouton_inscription.Text = "Go";
            this.bouton_inscription.UseVisualStyleBackColor = false;
            this.bouton_inscription.Click += new System.EventHandler(this.bouton_inscription_Click);
            // 
            // cb_choix_langue
            // 
            this.cb_choix_langue.BackColor = System.Drawing.Color.Black;
            this.cb_choix_langue.ForeColor = System.Drawing.Color.White;
            this.cb_choix_langue.FormattingEnabled = true;
            this.cb_choix_langue.Location = new System.Drawing.Point(14, 467);
            this.cb_choix_langue.Name = "cb_choix_langue";
            this.cb_choix_langue.Size = new System.Drawing.Size(194, 31);
            this.cb_choix_langue.TabIndex = 16;
            // 
            // tb_pseudo
            // 
            this.tb_pseudo.BackColor = System.Drawing.Color.Black;
            this.tb_pseudo.ForeColor = System.Drawing.Color.White;
            this.tb_pseudo.Location = new System.Drawing.Point(14, 400);
            this.tb_pseudo.Name = "tb_pseudo";
            this.tb_pseudo.Size = new System.Drawing.Size(194, 32);
            this.tb_pseudo.TabIndex = 15;
            this.tb_pseudo.Text = "Pseudonyme";
            // 
            // tb_password2
            // 
            this.tb_password2.BackColor = System.Drawing.Color.Black;
            this.tb_password2.ForeColor = System.Drawing.Color.White;
            this.tb_password2.Location = new System.Drawing.Point(14, 333);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.Size = new System.Drawing.Size(194, 32);
            this.tb_password2.TabIndex = 14;
            this.tb_password2.Text = "Mot de passe";
            // 
            // tb_password1
            // 
            this.tb_password1.BackColor = System.Drawing.Color.Black;
            this.tb_password1.ForeColor = System.Drawing.Color.White;
            this.tb_password1.Location = new System.Drawing.Point(14, 267);
            this.tb_password1.Name = "tb_password1";
            this.tb_password1.Size = new System.Drawing.Size(194, 32);
            this.tb_password1.TabIndex = 13;
            this.tb_password1.Text = "Mot de passe";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Black;
            this.tb_email.ForeColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(14, 200);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(194, 32);
            this.tb_email.TabIndex = 12;
            this.tb_email.Text = "email";
            // 
            // tb_nom
            // 
            this.tb_nom.BackColor = System.Drawing.Color.Black;
            this.tb_nom.ForeColor = System.Drawing.Color.White;
            this.tb_nom.Location = new System.Drawing.Point(14, 133);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(194, 32);
            this.tb_nom.TabIndex = 11;
            this.tb_nom.Text = "Nom";
            // 
            // tb_prenom
            // 
            this.tb_prenom.BackColor = System.Drawing.Color.Black;
            this.tb_prenom.ForeColor = System.Drawing.SystemColors.Menu;
            this.tb_prenom.Location = new System.Drawing.Point(14, 67);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(194, 32);
            this.tb_prenom.TabIndex = 10;
            this.tb_prenom.Text = "Prénom";
            // 
            // lb_create_account
            // 
            this.lb_create_account.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Bold);
            this.lb_create_account.Location = new System.Drawing.Point(0, 10);
            this.lb_create_account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_create_account.Name = "lb_create_account";
            this.lb_create_account.Size = new System.Drawing.Size(219, 36);
            this.lb_create_account.TabIndex = 10;
            this.lb_create_account.Text = "Créer un compte";
            this.lb_create_account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "News";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_french
            // 
            this.pb_french.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_french.Image = global::Skarp.Properties.Resources.en;
            this.pb_french.Location = new System.Drawing.Point(10, 10);
            this.pb_french.Name = "pb_french";
            this.pb_french.Size = new System.Drawing.Size(50, 33);
            this.pb_french.TabIndex = 9;
            this.pb_french.TabStop = false;
            this.pb_french.WaitOnLoad = true;
            this.pb_french.Click += new System.EventHandler(this.pb_french_Click);
            // 
            // Form_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Skarp.Properties.Resources.dark_souls;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_french);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_create_account);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "accueil_panel";
            this.Load += new System.EventHandler(this.Form_accueil_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_create_account.ResumeLayout(false);
            this.panel_create_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_french)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lb_identification;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_createAccount;
        private System.Windows.Forms.Button bt_identification;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Panel panel_create_account;
        private System.Windows.Forms.Label label_se_connecter;
        private System.Windows.Forms.Button bouton_inscription;
        private System.Windows.Forms.ComboBox cb_choix_langue;
        private System.Windows.Forms.TextBox tb_pseudo;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.TextBox tb_password1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label lb_create_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_french;
    }
}