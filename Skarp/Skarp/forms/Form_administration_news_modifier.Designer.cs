namespace Skarp.forms {
    partial class Form_administration_news_modifier {
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
            this.button_sauvegarder = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.lb_language = new System.Windows.Forms.Label();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.cb_titre_news = new System.Windows.Forms.ComboBox();
            this.lb_explication = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sauvegarder
            // 
            this.button_sauvegarder.BackColor = System.Drawing.Color.Black;
            this.button_sauvegarder.Location = new System.Drawing.Point(629, 524);
            this.button_sauvegarder.Name = "button_sauvegarder";
            this.button_sauvegarder.Size = new System.Drawing.Size(121, 50);
            this.button_sauvegarder.TabIndex = 4;
            this.button_sauvegarder.Text = Traducteur.traduction_[72];
            this.button_sauvegarder.UseVisualStyleBackColor = false;
            this.button_sauvegarder.Click += new System.EventHandler(this.button_sauvegarder_Click);
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_message.Location = new System.Drawing.Point(50, 77);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(124, 24);
            this.lb_message.TabIndex = 8;
            this.lb_message.Text = Traducteur.traduction_[65];
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(50, 104);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(700, 400);
            this.tb_message.TabIndex = 2;
            // 
            // lb_language
            // 
            this.lb_language.AutoSize = true;
            this.lb_language.Location = new System.Drawing.Point(462, 539);
            this.lb_language.Name = "lb_language";
            this.lb_language.Size = new System.Drawing.Size(74, 20);
            this.lb_language.TabIndex = 6;
            this.lb_language.Text = Traducteur.traduction_[56];
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Items.AddRange(new object[] {
            "fr",
            "en"});
            this.cb_language.Location = new System.Drawing.Point(556, 536);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(56, 28);
            this.cb_language.TabIndex = 3;
            // 
            // cb_titre_news
            // 
            this.cb_titre_news.FormattingEnabled = true;
            this.cb_titre_news.Location = new System.Drawing.Point(50, 46);
            this.cb_titre_news.Name = "cb_titre_news";
            this.cb_titre_news.Size = new System.Drawing.Size(700, 28);
            this.cb_titre_news.TabIndex = 1;
            this.cb_titre_news.SelectedIndexChanged += new System.EventHandler(this.cb_titre_news_SelectedIndexChanged);
            // 
            // lb_explication
            // 
            this.lb_explication.Location = new System.Drawing.Point(50, 10);
            this.lb_explication.Name = "lb_explication";
            this.lb_explication.Size = new System.Drawing.Size(700, 33);
            this.lb_explication.TabIndex = 11;
            this.lb_explication.Text = Traducteur.traduction_[73];
            this.lb_explication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_administration_news_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lb_explication);
            this.Controls.Add(this.cb_titre_news);
            this.Controls.Add(this.button_sauvegarder);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.lb_language);
            this.Controls.Add(this.cb_language);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_administration_news_modifier";
            this.Text = Traducteur.traduction_[74];
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sauvegarder;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label lb_language;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.ComboBox cb_titre_news;
        private System.Windows.Forms.Label lb_explication;
    }
}