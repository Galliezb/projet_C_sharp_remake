namespace Skarp.forms {
    partial class Form_administration_voir_joueurs {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_joueur = new System.Windows.Forms.DataGridView();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_joueur
            // 
            this.dg_joueur.AllowUserToAddRows = false;
            this.dg_joueur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.dg_joueur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_joueur.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_joueur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_joueur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dg_joueur.Location = new System.Drawing.Point(0, 84);
            this.dg_joueur.Name = "dg_joueur";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dg_joueur.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_joueur.Size = new System.Drawing.Size(800, 544);
            this.dg_joueur.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(662, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(126, 67);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Sauvegarder";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btPromote1_Click);
            // 
            // Form_administration_voir_joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dg_joueur);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_administration_voir_joueurs";
            this.Text = "Form_administration_voir_joueurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_administration_voir_joueurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_joueur;
        private System.Windows.Forms.Button btSave;
    }
}