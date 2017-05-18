namespace Skarp.forms
{
    partial class Form_Administration_Promote_User
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
            this.btPromote1 = new System.Windows.Forms.Button();
            this.btPromote2 = new System.Windows.Forms.Button();
            this.btPromote3 = new System.Windows.Forms.Button();
            this.btPromote4 = new System.Windows.Forms.Button();
            this.btPromote5 = new System.Windows.Forms.Button();
            this.dg_joueur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).BeginInit();
            this.SuspendLayout();
            // 
            // btPromote1
            // 
            this.btPromote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote1.Location = new System.Drawing.Point(629, 466);
            this.btPromote1.Name = "btPromote1";
            this.btPromote1.Size = new System.Drawing.Size(143, 83);
            this.btPromote1.TabIndex = 46;
            this.btPromote1.Text = Traducteur.traduction_[75];
            this.btPromote1.UseVisualStyleBackColor = true;
            this.btPromote1.Click += new System.EventHandler(this.btPromote1_Click);
            // 
            // btPromote2
            // 
            this.btPromote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote2.Location = new System.Drawing.Point(629, 158);
            this.btPromote2.Name = "btPromote2";
            this.btPromote2.Size = new System.Drawing.Size(143, 83);
            this.btPromote2.TabIndex = 46;
            this.btPromote2.Text = Traducteur.traduction_[76];
            this.btPromote2.UseVisualStyleBackColor = true;
            this.btPromote2.Visible = false;
            this.btPromote2.Click += new System.EventHandler(this.btPromote2_Click);
            // 
            // btPromote3
            // 
            this.btPromote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote3.Location = new System.Drawing.Point(308, 12);
            this.btPromote3.Name = "btPromote3";
            this.btPromote3.Size = new System.Drawing.Size(143, 83);
            this.btPromote3.TabIndex = 46;
            this.btPromote3.Text = Traducteur.traduction_[77];
            this.btPromote3.UseVisualStyleBackColor = true;
            this.btPromote3.Visible = false;
            this.btPromote3.Click += new System.EventHandler(this.btPromote3_Click);
            // 
            // btPromote4
            // 
            this.btPromote4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote4.Location = new System.Drawing.Point(83, 414);
            this.btPromote4.Name = "btPromote4";
            this.btPromote4.Size = new System.Drawing.Size(143, 83);
            this.btPromote4.TabIndex = 46;
            this.btPromote4.Text = Traducteur.traduction_[78];
            this.btPromote4.UseVisualStyleBackColor = true;
            this.btPromote4.Visible = false;
            this.btPromote4.Click += new System.EventHandler(this.btPromote4_Click);
            // 
            // btPromote5
            // 
            this.btPromote5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote5.Location = new System.Drawing.Point(46, 195);
            this.btPromote5.Name = "btPromote5";
            this.btPromote5.Size = new System.Drawing.Size(143, 83);
            this.btPromote5.TabIndex = 46;
            this.btPromote5.Text = Traducteur.traduction_[79];
            this.btPromote5.UseVisualStyleBackColor = true;
            this.btPromote5.Visible = false;
            this.btPromote5.Click += new System.EventHandler(this.btPromote5_Click);
            // 
            // dg_joueur
            // 
            this.dg_joueur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.dg_joueur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_joueur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dg_joueur.Location = new System.Drawing.Point(263, 124);
            this.dg_joueur.Name = "dg_joueur";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dg_joueur.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_joueur.Size = new System.Drawing.Size(250, 300);
            this.dg_joueur.TabIndex = 48;
            // 
            // Form_Administration_Promote_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dg_joueur);
            this.Controls.Add(this.btPromote5);
            this.Controls.Add(this.btPromote4);
            this.Controls.Add(this.btPromote3);
            this.Controls.Add(this.btPromote2);
            this.Controls.Add(this.btPromote1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Administration_Promote_User";
            this.Text = Traducteur.traduction_[80];
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Administration_Promote_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_joueur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPromote1;
        private System.Windows.Forms.Button btPromote2;
        private System.Windows.Forms.Button btPromote3;
        private System.Windows.Forms.Button btPromote4;
        private System.Windows.Forms.Button btPromote5;
        private System.Windows.Forms.DataGridView dg_joueur;
    }
}