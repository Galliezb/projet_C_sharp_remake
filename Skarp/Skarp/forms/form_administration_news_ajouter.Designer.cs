namespace Skarp.forms {
    partial class Form_administration_news_ajouter {
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
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.lb_language = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.lb_message = new System.Windows.Forms.Label();
            this.button_sauvegarder = new System.Windows.Forms.Button();
            this.tb_titre = new System.Windows.Forms.TextBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            "fr",
            "en"});
            this.cb_language.Location = new System.Drawing.Point(553, 518);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(56, 28);
            this.cb_language.TabIndex = 3;
            // 
            // lb_language
            // 
            this.lb_language.AutoSize = true;
            this.lb_language.Location = new System.Drawing.Point(459, 521);
            this.lb_language.Name = "lb_language";
            this.lb_language.Size = new System.Drawing.Size(74, 20);
            this.lb_language.TabIndex = 1;
            this.lb_language.Text = "Langue :";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(50, 124);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(700, 362);
            this.tb_message.TabIndex = 2;
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_message.Location = new System.Drawing.Point(54, 98);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(72, 20);
            this.lb_message.TabIndex = 3;
            this.lb_message.Text = "Message";
            // 
            // button_sauvegarder
            // 
            this.button_sauvegarder.BackColor = System.Drawing.Color.Black;
            this.button_sauvegarder.Location = new System.Drawing.Point(629, 506);
            this.button_sauvegarder.Name = "button_sauvegarder";
            this.button_sauvegarder.Size = new System.Drawing.Size(121, 50);
            this.button_sauvegarder.TabIndex = 4;
            this.button_sauvegarder.Text = "Sauvegarder";
            this.button_sauvegarder.UseVisualStyleBackColor = false;
            this.button_sauvegarder.Click += new System.EventHandler(this.button_sauvegarder_Click);
            // 
            // tb_titre
            // 
            this.tb_titre.Location = new System.Drawing.Point(50, 68);
            this.tb_titre.Name = "tb_titre";
            this.tb_titre.Size = new System.Drawing.Size(700, 27);
            this.tb_titre.TabIndex = 1;
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_titre.Location = new System.Drawing.Point(54, 41);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(46, 20);
            this.lb_titre.TabIndex = 6;
            this.lb_titre.Text = "Titre";
            // 
            // Form_administration_news_ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.tb_titre);
            this.Controls.Add(this.button_sauvegarder);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.lb_language);
            this.Controls.Add(this.cb_language);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_administration_news_ajouter";
            this.Text = "form_administration_news_ajouter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Label lb_language;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.Button button_sauvegarder;
        private System.Windows.Forms.TextBox tb_titre;
        private System.Windows.Forms.Label lb_titre;
    }
}