namespace Skarp.forms {
    partial class Form_CreateOrg {
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
            this.lbCreateTnm = new System.Windows.Forms.Label();
            this.panelCreateTnm = new System.Windows.Forms.Panel();
            this.rtbDescTnm = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lbNameTnm = new System.Windows.Forms.Label();
            this.tnNameTnm = new System.Windows.Forms.TextBox();
            this.btSubmissionTnm = new System.Windows.Forms.Button();
            this.lbDescTnm = new System.Windows.Forms.Label();
            this.tbMaxpPlayerTnm = new System.Windows.Forms.TextBox();
            this.lbMaxPlayerTnm = new System.Windows.Forms.Label();
            this.lbDateFinTnm = new System.Windows.Forms.Label();
            this.lbDateDebutTnm = new System.Windows.Forms.Label();
            this.lbTypeTnm = new System.Windows.Forms.Label();
            this.btCreateOrga = new System.Windows.Forms.Button();
            this.btCreateTnm = new System.Windows.Forms.Button();
            this.panelCreateOrga = new System.Windows.Forms.Panel();
            this.btSubmitOrga = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbManagerName = new System.Windows.Forms.TextBox();
            this.tbNameOrga = new System.Windows.Forms.TextBox();
            this.lbNameOrg = new System.Windows.Forms.Label();
            this.lbManagerName = new System.Windows.Forms.Label();
            this.panelCreateTnm.SuspendLayout();
            this.panelCreateOrga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCreateTnm
            // 
            this.lbCreateTnm.AutoSize = true;
            this.lbCreateTnm.Font = new System.Drawing.Font("Century Schoolbook", 20F, System.Drawing.FontStyle.Underline);
            this.lbCreateTnm.Location = new System.Drawing.Point(43, 45);
            this.lbCreateTnm.Name = "lbCreateTnm";
            this.lbCreateTnm.Size = new System.Drawing.Size(484, 33);
            this.lbCreateTnm.TabIndex = 0;
            this.lbCreateTnm.Text = "> Create Organisation / Tournament";
            // 
            // panelCreateTnm
            // 
            this.panelCreateTnm.Controls.Add(this.rtbDescTnm);
            this.panelCreateTnm.Controls.Add(this.dateTimePickerEndDate);
            this.panelCreateTnm.Controls.Add(this.dateTimePickerStartDate);
            this.panelCreateTnm.Controls.Add(this.comboBoxType);
            this.panelCreateTnm.Controls.Add(this.lbNameTnm);
            this.panelCreateTnm.Controls.Add(this.tnNameTnm);
            this.panelCreateTnm.Controls.Add(this.btSubmissionTnm);
            this.panelCreateTnm.Controls.Add(this.lbDescTnm);
            this.panelCreateTnm.Controls.Add(this.tbMaxpPlayerTnm);
            this.panelCreateTnm.Controls.Add(this.lbMaxPlayerTnm);
            this.panelCreateTnm.Controls.Add(this.lbDateFinTnm);
            this.panelCreateTnm.Controls.Add(this.lbDateDebutTnm);
            this.panelCreateTnm.Controls.Add(this.lbTypeTnm);
            this.panelCreateTnm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCreateTnm.Location = new System.Drawing.Point(1, 198);
            this.panelCreateTnm.Name = "panelCreateTnm";
            this.panelCreateTnm.Size = new System.Drawing.Size(1003, 570);
            this.panelCreateTnm.TabIndex = 0;
            // 
            // rtbDescTnm
            // 
            this.rtbDescTnm.Location = new System.Drawing.Point(643, 261);
            this.rtbDescTnm.Name = "rtbDescTnm";
            this.rtbDescTnm.Size = new System.Drawing.Size(222, 85);
            this.rtbDescTnm.TabIndex = 35;
            this.rtbDescTnm.Text = "";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(643, 161);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(222, 27);
            this.dateTimePickerEndDate.TabIndex = 34;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(643, 111);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(222, 27);
            this.dateTimePickerStartDate.TabIndex = 33;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "All-play-all",
            "Deathmatch",
            "Pool phase"});
            this.comboBoxType.Location = new System.Drawing.Point(643, 61);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(222, 28);
            this.comboBoxType.TabIndex = 32;
            // 
            // lbNameTnm
            // 
            this.lbNameTnm.AutoSize = true;
            this.lbNameTnm.Location = new System.Drawing.Point(155, 11);
            this.lbNameTnm.Name = "lbNameTnm";
            this.lbNameTnm.Size = new System.Drawing.Size(61, 20);
            this.lbNameTnm.TabIndex = 16;
            this.lbNameTnm.Text = "Name :";
            // 
            // tnNameTnm
            // 
            this.tnNameTnm.Location = new System.Drawing.Point(643, 11);
            this.tnNameTnm.Name = "tnNameTnm";
            this.tnNameTnm.Size = new System.Drawing.Size(222, 27);
            this.tnNameTnm.TabIndex = 17;
            // 
            // btSubmissionTnm
            // 
            this.btSubmissionTnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmissionTnm.Location = new System.Drawing.Point(390, 423);
            this.btSubmissionTnm.Name = "btSubmissionTnm";
            this.btSubmissionTnm.Size = new System.Drawing.Size(180, 51);
            this.btSubmissionTnm.TabIndex = 30;
            this.btSubmissionTnm.Text = "SUBMIT";
            this.btSubmissionTnm.UseVisualStyleBackColor = true;
            // 
            // lbDescTnm
            // 
            this.lbDescTnm.AutoSize = true;
            this.lbDescTnm.Location = new System.Drawing.Point(155, 261);
            this.lbDescTnm.Name = "lbDescTnm";
            this.lbDescTnm.Size = new System.Drawing.Size(101, 20);
            this.lbDescTnm.TabIndex = 28;
            this.lbDescTnm.Text = "Description :";
            // 
            // tbMaxpPlayerTnm
            // 
            this.tbMaxpPlayerTnm.Location = new System.Drawing.Point(643, 211);
            this.tbMaxpPlayerTnm.Name = "tbMaxpPlayerTnm";
            this.tbMaxpPlayerTnm.Size = new System.Drawing.Size(222, 27);
            this.tbMaxpPlayerTnm.TabIndex = 27;
            // 
            // lbMaxPlayerTnm
            // 
            this.lbMaxPlayerTnm.AutoSize = true;
            this.lbMaxPlayerTnm.Location = new System.Drawing.Point(155, 211);
            this.lbMaxPlayerTnm.Name = "lbMaxPlayerTnm";
            this.lbMaxPlayerTnm.Size = new System.Drawing.Size(167, 20);
            this.lbMaxPlayerTnm.TabIndex = 26;
            this.lbMaxPlayerTnm.Text = "Max. Players/Teams :";
            // 
            // lbDateFinTnm
            // 
            this.lbDateFinTnm.AutoSize = true;
            this.lbDateFinTnm.Location = new System.Drawing.Point(155, 161);
            this.lbDateFinTnm.Name = "lbDateFinTnm";
            this.lbDateFinTnm.Size = new System.Drawing.Size(70, 20);
            this.lbDateFinTnm.TabIndex = 24;
            this.lbDateFinTnm.Text = "End on :";
            // 
            // lbDateDebutTnm
            // 
            this.lbDateDebutTnm.AutoSize = true;
            this.lbDateDebutTnm.Location = new System.Drawing.Point(155, 111);
            this.lbDateDebutTnm.Name = "lbDateDebutTnm";
            this.lbDateDebutTnm.Size = new System.Drawing.Size(56, 20);
            this.lbDateDebutTnm.TabIndex = 22;
            this.lbDateDebutTnm.Text = "Date : ";
            // 
            // lbTypeTnm
            // 
            this.lbTypeTnm.AutoSize = true;
            this.lbTypeTnm.Location = new System.Drawing.Point(155, 61);
            this.lbTypeTnm.Name = "lbTypeTnm";
            this.lbTypeTnm.Size = new System.Drawing.Size(58, 20);
            this.lbTypeTnm.TabIndex = 20;
            this.lbTypeTnm.Text = "Type : ";
            // 
            // btCreateOrga
            // 
            this.btCreateOrga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateOrga.Location = new System.Drawing.Point(159, 105);
            this.btCreateOrga.Name = "btCreateOrga";
            this.btCreateOrga.Size = new System.Drawing.Size(230, 55);
            this.btCreateOrga.TabIndex = 2;
            this.btCreateOrga.Text = "Organisation";
            this.btCreateOrga.UseVisualStyleBackColor = true;
            this.btCreateOrga.Click += new System.EventHandler(this.btCreateOrga_Click);
            // 
            // btCreateTnm
            // 
            this.btCreateTnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateTnm.Location = new System.Drawing.Point(579, 105);
            this.btCreateTnm.Name = "btCreateTnm";
            this.btCreateTnm.Size = new System.Drawing.Size(230, 55);
            this.btCreateTnm.TabIndex = 3;
            this.btCreateTnm.Text = "Tournament";
            this.btCreateTnm.UseVisualStyleBackColor = true;
            this.btCreateTnm.Click += new System.EventHandler(this.btCreateTnm_Click);
            // 
            // panelCreateOrga
            // 
            this.panelCreateOrga.Controls.Add(this.btSubmitOrga);
            this.panelCreateOrga.Controls.Add(this.richTextBox1);
            this.panelCreateOrga.Controls.Add(this.lbDesc);
            this.panelCreateOrga.Controls.Add(this.tbMail);
            this.panelCreateOrga.Controls.Add(this.lbMail);
            this.panelCreateOrga.Controls.Add(this.tbManagerName);
            this.panelCreateOrga.Controls.Add(this.tbNameOrga);
            this.panelCreateOrga.Controls.Add(this.lbNameOrg);
            this.panelCreateOrga.Controls.Add(this.lbManagerName);
            this.panelCreateOrga.Location = new System.Drawing.Point(1, 198);
            this.panelCreateOrga.Name = "panelCreateOrga";
            this.panelCreateOrga.Size = new System.Drawing.Size(1003, 570);
            this.panelCreateOrga.TabIndex = 4;
            // 
            // btSubmitOrga
            // 
            this.btSubmitOrga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmitOrga.Location = new System.Drawing.Point(390, 372);
            this.btSubmitOrga.Name = "btSubmitOrga";
            this.btSubmitOrga.Size = new System.Drawing.Size(180, 53);
            this.btSubmitOrga.TabIndex = 10;
            this.btSubmitOrga.Text = "SUBMIT";
            this.btSubmitOrga.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(643, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 147);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(155, 163);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(105, 20);
            this.lbDesc.TabIndex = 8;
            this.lbDesc.Text = "Description  :";
            // 
            // tbMail
            // 
            this.tbMail.Enabled = false;
            this.tbMail.Location = new System.Drawing.Point(643, 111);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(222, 27);
            this.tbMail.TabIndex = 5;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(155, 111);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(51, 20);
            this.lbMail.TabIndex = 4;
            this.lbMail.Text = "Mail :";
            // 
            // tbManagerName
            // 
            this.tbManagerName.Enabled = false;
            this.tbManagerName.Location = new System.Drawing.Point(643, 61);
            this.tbManagerName.Name = "tbManagerName";
            this.tbManagerName.Size = new System.Drawing.Size(222, 27);
            this.tbManagerName.TabIndex = 3;
            // 
            // tbNameOrga
            // 
            this.tbNameOrga.Location = new System.Drawing.Point(643, 11);
            this.tbNameOrga.Name = "tbNameOrga";
            this.tbNameOrga.Size = new System.Drawing.Size(222, 27);
            this.tbNameOrga.TabIndex = 1;
            // 
            // lbNameOrg
            // 
            this.lbNameOrg.AutoSize = true;
            this.lbNameOrg.Location = new System.Drawing.Point(155, 11);
            this.lbNameOrg.Name = "lbNameOrg";
            this.lbNameOrg.Size = new System.Drawing.Size(61, 20);
            this.lbNameOrg.TabIndex = 0;
            this.lbNameOrg.Text = "Name :";
            // 
            // lbManagerName
            // 
            this.lbManagerName.AutoSize = true;
            this.lbManagerName.Location = new System.Drawing.Point(155, 64);
            this.lbManagerName.Name = "lbManagerName";
            this.lbManagerName.Size = new System.Drawing.Size(132, 20);
            this.lbManagerName.TabIndex = 2;
            this.lbManagerName.Text = "Manager Name :";
            // 
            // Form_CreateOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1005, 768);
            this.Controls.Add(this.panelCreateTnm);
            this.Controls.Add(this.btCreateTnm);
            this.Controls.Add(this.btCreateOrga);
            this.Controls.Add(this.lbCreateTnm);
            this.Controls.Add(this.panelCreateOrga);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_CreateOrg";
            this.Text = "Form_CreateOrg";
            this.Load += new System.EventHandler(this.Form_CreateOrg_Load);
            this.panelCreateTnm.ResumeLayout(false);
            this.panelCreateTnm.PerformLayout();
            this.panelCreateOrga.ResumeLayout(false);
            this.panelCreateOrga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreateTnm;
        private System.Windows.Forms.Panel panelCreateTnm;
        private System.Windows.Forms.Button btSubmissionTnm;
        private System.Windows.Forms.Label lbDescTnm;
        private System.Windows.Forms.TextBox tbMaxpPlayerTnm;
        private System.Windows.Forms.Label lbMaxPlayerTnm;
        private System.Windows.Forms.Label lbDateFinTnm;
        private System.Windows.Forms.Label lbDateDebutTnm;
        private System.Windows.Forms.Label lbTypeTnm;
        private System.Windows.Forms.TextBox tnNameTnm;
        private System.Windows.Forms.Label lbNameTnm;
        private System.Windows.Forms.Button btCreateOrga;
        private System.Windows.Forms.Button btCreateTnm;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Panel panelCreateOrga;
        private System.Windows.Forms.Button btSubmitOrga;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbManagerName;
        private System.Windows.Forms.TextBox tbNameOrga;
        private System.Windows.Forms.Label lbNameOrg;
        private System.Windows.Forms.Label lbManagerName;
        private System.Windows.Forms.RichTextBox rtbDescTnm;
    }
}