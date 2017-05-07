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
            this.button1 = new System.Windows.Forms.Button();
            this.dg_joueur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_joueur
            // 
            this.dg_joueur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dg_joueur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_joueur.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dg_joueur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dg_joueur.Location = new System.Drawing.Point(0, 84);
            this.dg_joueur.Name = "dg_joueur";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dg_joueur.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_joueur.Size = new System.Drawing.Size(800, 544);
            this.dg_joueur.TabIndex = 1;
            // 
            // Form_administration_voir_joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.dg_joueur);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_joueur;
    }
}