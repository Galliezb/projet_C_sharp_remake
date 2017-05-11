namespace Skarp.forms
{
    partial class Form_Team_Add_Player
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
            this.cbb_Player = new System.Windows.Forms.ComboBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.cbb_Team = new System.Windows.Forms.ComboBox();
            this.lb_Expl1 = new System.Windows.Forms.Label();
            this.lb_Expl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_Player
            // 
            this.cbb_Player.FormattingEnabled = true;
            this.cbb_Player.Location = new System.Drawing.Point(12, 261);
            this.cbb_Player.Name = "cbb_Player";
            this.cbb_Player.Size = new System.Drawing.Size(327, 28);
            this.cbb_Player.TabIndex = 0;
            this.cbb_Player.SelectedIndexChanged += new System.EventHandler(this.cbb_Player_SelectedIndexChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Location = new System.Drawing.Point(275, 456);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(250, 32);
            this.btSubmit.TabIndex = 66;
            this.btSubmit.Text = "Ajouter le joueur dans la team";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // cbb_Team
            // 
            this.cbb_Team.FormattingEnabled = true;
            this.cbb_Team.Location = new System.Drawing.Point(451, 261);
            this.cbb_Team.Name = "cbb_Team";
            this.cbb_Team.Size = new System.Drawing.Size(327, 28);
            this.cbb_Team.TabIndex = 0;
            // 
            // lb_Expl1
            // 
            this.lb_Expl1.AutoSize = true;
            this.lb_Expl1.Location = new System.Drawing.Point(12, 238);
            this.lb_Expl1.Name = "lb_Expl1";
            this.lb_Expl1.Size = new System.Drawing.Size(167, 20);
            this.lb_Expl1.TabIndex = 67;
            this.lb_Expl1.Text = "Choisissez le joueur : ";
            // 
            // lb_Expl2
            // 
            this.lb_Expl2.AutoSize = true;
            this.lb_Expl2.Location = new System.Drawing.Point(447, 238);
            this.lb_Expl2.Name = "lb_Expl2";
            this.lb_Expl2.Size = new System.Drawing.Size(153, 20);
            this.lb_Expl2.TabIndex = 68;
            this.lb_Expl2.Text = "Choisissez la team :";
            // 
            // Form_Team_Add_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lb_Expl2);
            this.Controls.Add(this.lb_Expl1);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.cbb_Team);
            this.Controls.Add(this.cbb_Player);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Team_Add_Player";
            this.Text = "Form_Team_Add_Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_Player;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.ComboBox cbb_Team;
        private System.Windows.Forms.Label lb_Expl1;
        private System.Windows.Forms.Label lb_Expl2;
    }
}