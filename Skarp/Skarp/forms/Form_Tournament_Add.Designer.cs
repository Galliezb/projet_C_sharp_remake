namespace Skarp.forms
{
    partial class Form_Tournament_Add
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbMaxPlayer = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbMaxPlayer = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lb_Jeu = new System.Windows.Forms.Label();
            this.tb_Jeu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(100, 105);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(56, 20);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = Traducteur.traduction_[49];
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(100, 145);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(54, 20);
            this.lbType.TabIndex = 1;
            this.lbType.Text = Traducteur.traduction_[115];
            // 
            // lbMaxPlayer
            // 
            this.lbMaxPlayer.AutoSize = true;
            this.lbMaxPlayer.Location = new System.Drawing.Point(100, 185);
            this.lbMaxPlayer.Name = "lbMaxPlayer";
            this.lbMaxPlayer.Size = new System.Drawing.Size(117, 20);
            this.lbMaxPlayer.TabIndex = 2;
            this.lbMaxPlayer.Text = Traducteur.traduction_[116];
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(100, 225);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(119, 20);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = Traducteur.traduction_[87];
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(100, 265);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(97, 20);
            this.lbEndDate.TabIndex = 4;
            this.lbEndDate.Text = Traducteur.traduction_[88];
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(100, 345);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(101, 20);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = Traducteur.traduction_[49];
            // 
            // btSubmit
            // 
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Location = new System.Drawing.Point(350, 473);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(99, 32);
            this.btSubmit.TabIndex = 65;
            this.btSubmit.Text = Traducteur.traduction_[52];
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(443, 102);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(259, 27);
            this.tbNom.TabIndex = 66;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(443, 142);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(259, 27);
            this.tbType.TabIndex = 67;
            // 
            // tbMaxPlayer
            // 
            this.tbMaxPlayer.Location = new System.Drawing.Point(443, 182);
            this.tbMaxPlayer.Name = "tbMaxPlayer";
            this.tbMaxPlayer.Size = new System.Drawing.Size(259, 27);
            this.tbMaxPlayer.TabIndex = 68;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(443, 220);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(259, 27);
            this.dtpStartDate.TabIndex = 69;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(443, 260);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(259, 27);
            this.dtpEndDate.TabIndex = 70;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(443, 345);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(259, 96);
            this.rtbDescription.TabIndex = 71;
            this.rtbDescription.Text = "";
            // 
            // lb_Jeu
            // 
            this.lb_Jeu.AutoSize = true;
            this.lb_Jeu.Location = new System.Drawing.Point(100, 305);
            this.lb_Jeu.Name = "lb_Jeu";
            this.lb_Jeu.Size = new System.Drawing.Size(44, 20);
            this.lb_Jeu.TabIndex = 72;
            this.lb_Jeu.Text = Traducteur.traduction_[117];
            // 
            // tb_Jeu
            // 
            this.tb_Jeu.ForeColor = System.Drawing.Color.Black;
            this.tb_Jeu.FormattingEnabled = true;
            this.tb_Jeu.Items.AddRange(new object[] {
            "Battlerite",
            "League of Legends",
            "Counter Strike GO",
            "Dota2",
            "Overwatch",
            "Heavy Metal Machine",
            "Paladin",
            "Hearthstone",
            "Orion Prelude",
            "BattleBorn"});
            this.tb_Jeu.Location = new System.Drawing.Point(443, 302);
            this.tb_Jeu.Name = "tb_Jeu";
            this.tb_Jeu.Size = new System.Drawing.Size(259, 28);
            this.tb_Jeu.TabIndex = 73;
            // 
            // Form_Tournament_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tb_Jeu);
            this.Controls.Add(this.lb_Jeu);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.tbMaxPlayer);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbEndDate);
            this.Controls.Add(this.lbStartDate);
            this.Controls.Add(this.lbMaxPlayer);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbNom);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Tournament_Add";
            this.Text = "Form_Tournament_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbMaxPlayer;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbMaxPlayer;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lb_Jeu;
        private System.Windows.Forms.ComboBox tb_Jeu;
    }
}