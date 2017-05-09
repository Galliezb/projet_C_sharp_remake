namespace Skarp.forms
{
    partial class Form_Team_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_joueur = new System.Windows.Forms.DataGridView();
            this.lbTeam = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_joueur
            // 
            this.dg_joueur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dg_joueur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_joueur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dg_joueur.Location = new System.Drawing.Point(156, 145);
            this.dg_joueur.Name = "dg_joueur";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dg_joueur.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_joueur.Size = new System.Drawing.Size(485, 300);
            this.dg_joueur.TabIndex = 49;
            this.dg_joueur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_joueur_CellContentClick);
            // 
            // lbTeam
            // 
            this.lbTeam.AutoSize = true;
            this.lbTeam.Location = new System.Drawing.Point(117, 90);
            this.lbTeam.Name = "lbTeam";
            this.lbTeam.Size = new System.Drawing.Size(104, 20);
            this.lbTeam.TabIndex = 50;
            this.lbTeam.Text = "Vos Équipes:";
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Location = new System.Drawing.Point(645, 505);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(143, 83);
            this.btSave.TabIndex = 51;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form_Team_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbTeam);
            this.Controls.Add(this.dg_joueur);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Team_Manage";
            this.Text = "Form_Team_Manage";
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_joueur;
        private System.Windows.Forms.Label lbTeam;
        private System.Windows.Forms.Button btSave;
    }
}