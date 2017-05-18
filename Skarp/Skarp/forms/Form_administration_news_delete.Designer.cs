namespace Skarp.forms {
    partial class Form_administration_news_delete {
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
            this.lb_explication = new System.Windows.Forms.Label();
            this.cb_titre_news = new System.Windows.Forms.ComboBox();
            this.lb_message = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_auteur = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_explication
            // 
            this.lb_explication.Location = new System.Drawing.Point(50, 18);
            this.lb_explication.Name = "lb_explication";
            this.lb_explication.Size = new System.Drawing.Size(700, 33);
            this.lb_explication.TabIndex = 18;
            this.lb_explication.Text = Traducteur.traduction_[69]+ " :";
            this.lb_explication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_titre_news
            // 
            this.cb_titre_news.FormattingEnabled = true;
            this.cb_titre_news.Location = new System.Drawing.Point(50, 54);
            this.cb_titre_news.Name = "cb_titre_news";
            this.cb_titre_news.Size = new System.Drawing.Size(700, 28);
            this.cb_titre_news.TabIndex = 12;
            this.cb_titre_news.SelectedIndexChanged += new System.EventHandler(this.cb_titre_news_SelectedIndexChanged);
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_message.Location = new System.Drawing.Point(50, 85);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(124, 24);
            this.lb_message.TabIndex = 17;
            this.lb_message.Text = Traducteur.traduction_[65]+" :";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(50, 112);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.ReadOnly = true;
            this.tb_message.Size = new System.Drawing.Size(700, 400);
            this.tb_message.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.label1.Location = new System.Drawing.Point(50, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = Traducteur.traduction_[70]+" : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_auteur
            // 
            this.tb_auteur.Location = new System.Drawing.Point(127, 533);
            this.tb_auteur.Name = "tb_auteur";
            this.tb_auteur.ReadOnly = true;
            this.tb_auteur.Size = new System.Drawing.Size(221, 27);
            this.tb_auteur.TabIndex = 20;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(675, 519);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(113, 54);
            this.btSave.TabIndex = 53;
            this.btSave.Text = Traducteur.traduction_[13];
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form_administration_news_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tb_auteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_explication);
            this.Controls.Add(this.cb_titre_news);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.tb_message);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_administration_news_delete";
            this.Text = Traducteur.traduction_[71];
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_explication;
        private System.Windows.Forms.ComboBox cb_titre_news;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_auteur;
        private System.Windows.Forms.Button btSave;
    }
}