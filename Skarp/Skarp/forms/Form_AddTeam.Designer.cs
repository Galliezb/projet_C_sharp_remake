namespace Skarp.forms
{
    partial class Form_AddTeam
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
            this.tbNameTeam = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbNameTeam = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNameTeam
            // 
            this.tbNameTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbNameTeam.ForeColor = System.Drawing.Color.White;
            this.tbNameTeam.Location = new System.Drawing.Point(444, 172);
            this.tbNameTeam.Name = "tbNameTeam";
            this.tbNameTeam.Size = new System.Drawing.Size(253, 27);
            this.tbNameTeam.TabIndex = 66;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point(444, 242);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(253, 120);
            this.tbDescription.TabIndex = 66;
            // 
            // lbNameTeam
            // 
            this.lbNameTeam.AutoSize = true;
            this.lbNameTeam.Location = new System.Drawing.Point(233, 175);
            this.lbNameTeam.Name = "lbNameTeam";
            this.lbNameTeam.Size = new System.Drawing.Size(57, 20);
            this.lbNameTeam.TabIndex = 67;
            this.lbNameTeam.Text = "Name:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(233, 245);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(97, 20);
            this.lbDescription.TabIndex = 67;
            this.lbDescription.Text = "Description:";
            // 
            // Form_AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbNameTeam);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbNameTeam);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_AddTeam";
            this.Text = "Form_AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNameTeam;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbNameTeam;
        private System.Windows.Forms.Label lbDescription;
    }
}