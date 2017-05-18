namespace Skarp.forms {
    partial class Form_Settings_User {
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
            this.btSave = new System.Windows.Forms.Button();
            this.label_password2 = new System.Windows.Forms.Label();
            this.label_password1 = new System.Windows.Forms.Label();
            this.label_pseudo = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.tb_pseudo = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.label_langage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(627, 569);
            this.btSave.Margin = new System.Windows.Forms.Padding(4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(160, 46);
            this.btSave.TabIndex = 27;
            this.btSave.Text = Traducteur.traduction_[67];
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password2.ForeColor = System.Drawing.Color.White;
            this.label_password2.Location = new System.Drawing.Point(193, 300);
            this.label_password2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(100, 20);
            this.label_password2.TabIndex = 21;
            this.label_password2.Text = Traducteur.traduction_[57];
            // 
            // label_password1
            // 
            this.label_password1.AutoSize = true;
            this.label_password1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password1.ForeColor = System.Drawing.Color.White;
            this.label_password1.Location = new System.Drawing.Point(193, 250);
            this.label_password1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password1.Name = "label_password1";
            this.label_password1.Size = new System.Drawing.Size(82, 20);
            this.label_password1.TabIndex = 22;
            this.label_password1.Text = Traducteur.traduction_[35];
            // 
            // label_pseudo
            // 
            this.label_pseudo.AutoSize = true;
            this.label_pseudo.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pseudo.ForeColor = System.Drawing.Color.White;
            this.label_pseudo.Location = new System.Drawing.Point(193, 50);
            this.label_pseudo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pseudo.Name = "label_pseudo";
            this.label_pseudo.Size = new System.Drawing.Size(66, 20);
            this.label_pseudo.TabIndex = 23;
            this.label_pseudo.Text = Traducteur.traduction_[39];
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(193, 200);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(64, 20);
            this.label_email.TabIndex = 24;
            this.label_email.Text = Traducteur.traduction_[38];
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.ForeColor = System.Drawing.Color.White;
            this.label_prenom.Location = new System.Drawing.Point(193, 150);
            this.label_prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(93, 20);
            this.label_prenom.TabIndex = 25;
            this.label_prenom.Text = Traducteur.traduction_[36];
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.ForeColor = System.Drawing.Color.White;
            this.label_nom.Location = new System.Drawing.Point(193, 100);
            this.label_nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(57, 20);
            this.label_nom.TabIndex = 26;
            this.label_nom.Text = Traducteur.traduction_[37];
            // 
            // tb_password2
            // 
            this.tb_password2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tb_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password2.ForeColor = System.Drawing.Color.White;
            this.tb_password2.Location = new System.Drawing.Point(393, 300);
            this.tb_password2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.Size = new System.Drawing.Size(195, 27);
            this.tb_password2.TabIndex = 15;
            // 
            // tb_pseudo
            // 
            this.tb_pseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tb_pseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pseudo.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pseudo.ForeColor = System.Drawing.Color.White;
            this.tb_pseudo.Location = new System.Drawing.Point(393, 50);
            this.tb_pseudo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pseudo.Name = "tb_pseudo";
            this.tb_pseudo.Size = new System.Drawing.Size(195, 27);
            this.tb_pseudo.TabIndex = 16;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(393, 250);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(195, 27);
            this.tb_password.TabIndex = 17;
            // 
            // tb_mail
            // 
            this.tb_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tb_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mail.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.tb_mail.ForeColor = System.Drawing.Color.White;
            this.tb_mail.Location = new System.Drawing.Point(393, 200);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(195, 27);
            this.tb_mail.TabIndex = 18;
            // 
            // tb_prenom
            // 
            this.tb_prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tb_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_prenom.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prenom.ForeColor = System.Drawing.Color.White;
            this.tb_prenom.Location = new System.Drawing.Point(393, 150);
            this.tb_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(195, 27);
            this.tb_prenom.TabIndex = 19;
            // 
            // tb_nom
            // 
            this.tb_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tb_nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nom.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.ForeColor = System.Drawing.Color.White;
            this.tb_nom.Location = new System.Drawing.Point(393, 100);
            this.tb_nom.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(195, 27);
            this.tb_nom.TabIndex = 20;
            // 
            // cb_language
            // 
            this.cb_language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cb_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_language.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_language.ForeColor = System.Drawing.Color.White;
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.cb_language.Location = new System.Drawing.Point(393, 350);
            this.cb_language.Margin = new System.Windows.Forms.Padding(4);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(195, 28);
            this.cb_language.TabIndex = 28;
            // 
            // label_langage
            // 
            this.label_langage.AutoSize = true;
            this.label_langage.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_langage.ForeColor = System.Drawing.Color.White;
            this.label_langage.Location = new System.Drawing.Point(193, 350);
            this.label_langage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_langage.Name = "label_langage";
            this.label_langage.Size = new System.Drawing.Size(100, 20);
            this.label_langage.TabIndex = 29;
            this.label_langage.Text = Traducteur.traduction_[57];
            // 
            // Form_Settings_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.label_langage);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label_password2);
            this.Controls.Add(this.label_pseudo);
            this.Controls.Add(this.label_password1);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.tb_pseudo);
            this.Controls.Add(this.tb_password2);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = Traducteur.traduction_[99];
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.Label label_password1;
        private System.Windows.Forms.Label label_pseudo;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.TextBox tb_pseudo;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Label label_langage;
    }
}