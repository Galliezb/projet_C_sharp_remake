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
            this.btPromote1 = new System.Windows.Forms.Button();
            this.btPromote2 = new System.Windows.Forms.Button();
            this.btPromote3 = new System.Windows.Forms.Button();
            this.btPromote4 = new System.Windows.Forms.Button();
            this.btPromote5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btPromote1
            // 
            this.btPromote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote1.Location = new System.Drawing.Point(629, 466);
            this.btPromote1.Name = "btPromote1";
            this.btPromote1.Size = new System.Drawing.Size(143, 83);
            this.btPromote1.TabIndex = 46;
            this.btPromote1.Text = "Promote";
            this.btPromote1.UseVisualStyleBackColor = true;
            this.btPromote1.Click += new System.EventHandler(this.btPromote1_Click);
            // 
            // btPromote2
            // 
            this.btPromote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote2.Location = new System.Drawing.Point(380, 466);
            this.btPromote2.Name = "btPromote2";
            this.btPromote2.Size = new System.Drawing.Size(143, 83);
            this.btPromote2.TabIndex = 46;
            this.btPromote2.Text = "Really ?";
            this.btPromote2.UseVisualStyleBackColor = true;
            this.btPromote2.Visible = false;
            this.btPromote2.Click += new System.EventHandler(this.btPromote2_Click);
            // 
            // btPromote3
            // 
            this.btPromote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote3.Location = new System.Drawing.Point(510, 364);
            this.btPromote3.Name = "btPromote3";
            this.btPromote3.Size = new System.Drawing.Size(143, 83);
            this.btPromote3.TabIndex = 46;
            this.btPromote3.Text = "One Admin more ?";
            this.btPromote3.UseVisualStyleBackColor = true;
            this.btPromote3.Visible = false;
            this.btPromote3.Click += new System.EventHandler(this.btPromote3_Click);
            // 
            // btPromote4
            // 
            this.btPromote4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote4.Location = new System.Drawing.Point(117, 422);
            this.btPromote4.Name = "btPromote4";
            this.btPromote4.Size = new System.Drawing.Size(143, 83);
            this.btPromote4.TabIndex = 46;
            this.btPromote4.Text = "Are you dumb ?";
            this.btPromote4.UseVisualStyleBackColor = true;
            this.btPromote4.Visible = false;
            this.btPromote4.Click += new System.EventHandler(this.btPromote4_Click);
            // 
            // btPromote5
            // 
            this.btPromote5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPromote5.Location = new System.Drawing.Point(316, 364);
            this.btPromote5.Name = "btPromote5";
            this.btPromote5.Size = new System.Drawing.Size(143, 83);
            this.btPromote5.TabIndex = 46;
            this.btPromote5.Text = "Failure Detected Click to fix";
            this.btPromote5.UseVisualStyleBackColor = true;
            this.btPromote5.Visible = false;
            this.btPromote5.Click += new System.EventHandler(this.btPromote5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(591, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "Administrator";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form_Administration_Promote_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btPromote5);
            this.Controls.Add(this.btPromote4);
            this.Controls.Add(this.btPromote3);
            this.Controls.Add(this.btPromote2);
            this.Controls.Add(this.btPromote1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form_Administration_Promote_User";
            this.Text = "Form_Administration_Promote_User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPromote1;
        private System.Windows.Forms.Button btPromote2;
        private System.Windows.Forms.Button btPromote3;
        private System.Windows.Forms.Button btPromote4;
        private System.Windows.Forms.Button btPromote5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}