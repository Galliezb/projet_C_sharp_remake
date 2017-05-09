namespace Skarp.forms {
    partial class Form_organisation {
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
            this.tb_nom_organisation = new System.Windows.Forms.TextBox();
            this.dtp_dateCreation = new System.Windows.Forms.DateTimePicker();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.button_sauvegarder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_nom_organisation
            // 
            this.tb_nom_organisation.Location = new System.Drawing.Point(235, 89);
            this.tb_nom_organisation.Name = "tb_nom_organisation";
            this.tb_nom_organisation.Size = new System.Drawing.Size(295, 27);
            this.tb_nom_organisation.TabIndex = 0;
            // 
            // dtp_dateCreation
            // 
            this.dtp_dateCreation.Location = new System.Drawing.Point(239, 400);
            this.dtp_dateCreation.Name = "dtp_dateCreation";
            this.dtp_dateCreation.Size = new System.Drawing.Size(295, 27);
            this.dtp_dateCreation.TabIndex = 1;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(235, 163);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(295, 120);
            this.tb_description.TabIndex = 2;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(239, 325);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(295, 27);
            this.tb_email.TabIndex = 3;
            // 
            // button_sauvegarder
            // 
            this.button_sauvegarder.BackColor = System.Drawing.Color.White;
            this.button_sauvegarder.ForeColor = System.Drawing.Color.Black;
            this.button_sauvegarder.Location = new System.Drawing.Point(239, 462);
            this.button_sauvegarder.Name = "button_sauvegarder";
            this.button_sauvegarder.Size = new System.Drawing.Size(295, 63);
            this.button_sauvegarder.TabIndex = 4;
            this.button_sauvegarder.Text = "Sauvegarder";
            this.button_sauvegarder.UseVisualStyleBackColor = false;
            this.button_sauvegarder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom de l\'organisation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(235, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email du responsable";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(239, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date de création :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_organisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sauvegarder);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.dtp_dateCreation);
            this.Controls.Add(this.tb_nom_organisation);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_organisation";
            this.Text = "Form_organisation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nom_organisation;
        private System.Windows.Forms.DateTimePicker dtp_dateCreation;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button button_sauvegarder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}