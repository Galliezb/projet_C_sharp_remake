namespace Skarp.forms
{
    partial class Form_Tournament_List_Started
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_EndDate = new System.Windows.Forms.Label();
            this.lb_StartDate = new System.Windows.Forms.Label();
            this.tb_Type = new System.Windows.Forms.TextBox();
            this.lb_Type = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_Description = new System.Windows.Forms.Label();
            this.lb_explication = new System.Windows.Forms.Label();
            this.cb_Name_Tournament = new System.Windows.Forms.ComboBox();
            this.lbJeu = new System.Windows.Forms.Label();
            this.tb_Jeu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(516, 359);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 27);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(516, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 27);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // lb_EndDate
            // 
            this.lb_EndDate.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_EndDate.Location = new System.Drawing.Point(46, 362);
            this.lb_EndDate.Name = "lb_EndDate";
            this.lb_EndDate.Size = new System.Drawing.Size(124, 24);
            this.lb_EndDate.TabIndex = 49;
            this.lb_EndDate.Text = "Date de fin : ";
            this.lb_EndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_StartDate
            // 
            this.lb_StartDate.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_StartDate.Location = new System.Drawing.Point(50, 316);
            this.lb_StartDate.Name = "lb_StartDate";
            this.lb_StartDate.Size = new System.Drawing.Size(124, 24);
            this.lb_StartDate.TabIndex = 48;
            this.lb_StartDate.Text = "Date de début :";
            this.lb_StartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Type
            // 
            this.tb_Type.Location = new System.Drawing.Point(516, 272);
            this.tb_Type.Multiline = true;
            this.tb_Type.Name = "tb_Type";
            this.tb_Type.ReadOnly = true;
            this.tb_Type.Size = new System.Drawing.Size(238, 24);
            this.tb_Type.TabIndex = 47;
            // 
            // lb_Type
            // 
            this.lb_Type.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_Type.Location = new System.Drawing.Point(50, 272);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.Size = new System.Drawing.Size(124, 24);
            this.lb_Type.TabIndex = 46;
            this.lb_Type.Text = "Type :";
            this.lb_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(50, 155);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(700, 97);
            this.tb_description.TabIndex = 45;
            // 
            // lb_Description
            // 
            this.lb_Description.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lb_Description.Location = new System.Drawing.Point(50, 128);
            this.lb_Description.Name = "lb_Description";
            this.lb_Description.Size = new System.Drawing.Size(124, 24);
            this.lb_Description.TabIndex = 44;
            this.lb_Description.Text = "Description :";
            this.lb_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_explication
            // 
            this.lb_explication.Location = new System.Drawing.Point(50, 46);
            this.lb_explication.Name = "lb_explication";
            this.lb_explication.Size = new System.Drawing.Size(700, 33);
            this.lb_explication.TabIndex = 43;
            this.lb_explication.Text = "Choisissez un tournoi (en cours) à oberver :";
            this.lb_explication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_Name_Tournament
            // 
            this.cb_Name_Tournament.FormattingEnabled = true;
            this.cb_Name_Tournament.Location = new System.Drawing.Point(54, 82);
            this.cb_Name_Tournament.Name = "cb_Name_Tournament";
            this.cb_Name_Tournament.Size = new System.Drawing.Size(700, 28);
            this.cb_Name_Tournament.TabIndex = 42;
            this.cb_Name_Tournament.SelectedIndexChanged += new System.EventHandler(this.cb_Name_Tournament_SelectedIndexChanged);
            // 
            // lbJeu
            // 
            this.lbJeu.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.lbJeu.Location = new System.Drawing.Point(46, 407);
            this.lbJeu.Name = "lbJeu";
            this.lbJeu.Size = new System.Drawing.Size(124, 24);
            this.lbJeu.TabIndex = 52;
            this.lbJeu.Text = "Jeu :";
            this.lbJeu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Jeu
            // 
            this.tb_Jeu.Location = new System.Drawing.Point(516, 406);
            this.tb_Jeu.Multiline = true;
            this.tb_Jeu.Name = "tb_Jeu";
            this.tb_Jeu.ReadOnly = true;
            this.tb_Jeu.Size = new System.Drawing.Size(238, 24);
            this.tb_Jeu.TabIndex = 53;
            // 
            // Form_Tournament_List_Started
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tb_Jeu);
            this.Controls.Add(this.lbJeu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_EndDate);
            this.Controls.Add(this.lb_StartDate);
            this.Controls.Add(this.tb_Type);
            this.Controls.Add(this.lb_Type);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_Description);
            this.Controls.Add(this.lb_explication);
            this.Controls.Add(this.cb_Name_Tournament);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Tournament_List_Started";
            this.Text = "Form_Tournament_List_Started";
            this.Load += new System.EventHandler(this.Form_Tournament_List_Started_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_EndDate;
        private System.Windows.Forms.Label lb_StartDate;
        private System.Windows.Forms.TextBox tb_Type;
        private System.Windows.Forms.Label lb_Type;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_Description;
        private System.Windows.Forms.Label lb_explication;
        private System.Windows.Forms.ComboBox cb_Name_Tournament;
        private System.Windows.Forms.Label lbJeu;
        private System.Windows.Forms.TextBox tb_Jeu;
    }
}