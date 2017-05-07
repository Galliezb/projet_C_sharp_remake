namespace Skarp.forms {
    partial class Form_Administration {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add User to DB");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update Informations");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Change Your Informations");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Show Informations");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Promote an User");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Add an Administrator");
            this.tps = new System.Windows.Forms.Timer(this.components);
            this.panelChangeInfo = new System.Windows.Forms.Panel();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.tbNameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSelectType = new System.Windows.Forms.Label();
            this.cbbSelectType = new System.Windows.Forms.ComboBox();
            this.lbPwd = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.lbChooseItem = new System.Windows.Forms.Label();
            this.cbbItems = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateDataGridView = new System.Windows.Forms.Button();
            this.panelUpdateInfo = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelUpdateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tps
            // 
            this.tps.Enabled = true;
            this.tps.Tick += new System.EventHandler(this.tps_Tick);
            // 
            // panelChangeInfo
            // 
            this.panelChangeInfo.Location = new System.Drawing.Point(241, 0);
            this.panelChangeInfo.Name = "panelChangeInfo";
            this.panelChangeInfo.Size = new System.Drawing.Size(762, 768);
            this.panelChangeInfo.TabIndex = 45;
            // 
            // btSubmit
            // 
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Location = new System.Drawing.Point(312, 685);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(99, 32);
            this.btSubmit.TabIndex = 43;
            this.btSubmit.Text = "SUBMIT";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoSize = true;
            this.lbNameUser.Location = new System.Drawing.Point(86, 138);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(61, 20);
            this.lbNameUser.TabIndex = 22;
            this.lbNameUser.Text = "Name :";
            // 
            // tbNameUser
            // 
            this.tbNameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbNameUser.ForeColor = System.Drawing.Color.White;
            this.tbNameUser.Location = new System.Drawing.Point(383, 135);
            this.tbNameUser.Name = "tbNameUser";
            this.tbNameUser.Size = new System.Drawing.Size(232, 27);
            this.tbNameUser.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter the required informations : ";
            // 
            // lbSelectType
            // 
            this.lbSelectType.AutoSize = true;
            this.lbSelectType.Location = new System.Drawing.Point(86, 85);
            this.lbSelectType.Name = "lbSelectType";
            this.lbSelectType.Size = new System.Drawing.Size(243, 20);
            this.lbSelectType.TabIndex = 25;
            this.lbSelectType.Text = "Select the type of the new user : ";
            // 
            // cbbSelectType
            // 
            this.cbbSelectType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cbbSelectType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbSelectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSelectType.ForeColor = System.Drawing.Color.White;
            this.cbbSelectType.FormattingEnabled = true;
            this.cbbSelectType.Items.AddRange(new object[] {
            "Administrator",
            "Organizer",
            "User"});
            this.cbbSelectType.Location = new System.Drawing.Point(383, 82);
            this.cbbSelectType.Name = "cbbSelectType";
            this.cbbSelectType.Size = new System.Drawing.Size(232, 28);
            this.cbbSelectType.TabIndex = 26;
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Location = new System.Drawing.Point(86, 235);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(86, 20);
            this.lbPwd.TabIndex = 27;
            this.lbPwd.Text = "Password :";
            // 
            // tbPwd
            // 
            this.tbPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPwd.ForeColor = System.Drawing.Color.White;
            this.tbPwd.Location = new System.Drawing.Point(383, 226);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(232, 27);
            this.tbPwd.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Confirm :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(383, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 30;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(89, 378);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(51, 20);
            this.lbMail.TabIndex = 33;
            this.lbMail.Text = "Mail :";
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbMail.ForeColor = System.Drawing.Color.White;
            this.tbMail.Location = new System.Drawing.Point(383, 375);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(232, 27);
            this.tbMail.TabIndex = 34;
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Location = new System.Drawing.Point(86, 329);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(74, 20);
            this.lbPseudo.TabIndex = 35;
            this.lbPseudo.Text = "Pseudo : ";
            // 
            // tbPseudo
            // 
            this.tbPseudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbPseudo.ForeColor = System.Drawing.Color.White;
            this.tbPseudo.Location = new System.Drawing.Point(383, 326);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(232, 27);
            this.tbPseudo.TabIndex = 36;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(86, 183);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(94, 20);
            this.lbFirstName.TabIndex = 37;
            this.lbFirstName.Text = "Firstname :";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Location = new System.Drawing.Point(89, 427);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(96, 20);
            this.lbLanguage.TabIndex = 39;
            this.lbLanguage.Text = "Language : ";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(86, 505);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(101, 20);
            this.lbDesc.TabIndex = 41;
            this.lbDesc.Text = "Description :";
            // 
            // rtbDesc
            // 
            this.rtbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.rtbDesc.ForeColor = System.Drawing.Color.White;
            this.rtbDesc.Location = new System.Drawing.Point(383, 502);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(232, 96);
            this.rtbDesc.TabIndex = 42;
            this.rtbDesc.Text = "";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.Location = new System.Drawing.Point(383, 180);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(232, 27);
            this.tbFirstName.TabIndex = 38;
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLanguage.ForeColor = System.Drawing.Color.White;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "fr",
            "en"});
            this.cbLanguage.Location = new System.Drawing.Point(383, 424);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(232, 28);
            this.cbLanguage.TabIndex = 44;
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.cbLanguage);
            this.panelAddUser.Controls.Add(this.tbFirstName);
            this.panelAddUser.Controls.Add(this.rtbDesc);
            this.panelAddUser.Controls.Add(this.lbDesc);
            this.panelAddUser.Controls.Add(this.lbLanguage);
            this.panelAddUser.Controls.Add(this.lbFirstName);
            this.panelAddUser.Controls.Add(this.tbPseudo);
            this.panelAddUser.Controls.Add(this.lbPseudo);
            this.panelAddUser.Controls.Add(this.tbMail);
            this.panelAddUser.Controls.Add(this.lbMail);
            this.panelAddUser.Controls.Add(this.textBox1);
            this.panelAddUser.Controls.Add(this.label1);
            this.panelAddUser.Controls.Add(this.tbPwd);
            this.panelAddUser.Controls.Add(this.lbPwd);
            this.panelAddUser.Controls.Add(this.cbbSelectType);
            this.panelAddUser.Controls.Add(this.lbSelectType);
            this.panelAddUser.Controls.Add(this.label2);
            this.panelAddUser.Controls.Add(this.tbNameUser);
            this.panelAddUser.Controls.Add(this.lbNameUser);
            this.panelAddUser.Controls.Add(this.btSubmit);
            this.panelAddUser.Location = new System.Drawing.Point(241, 0);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(765, 795);
            this.panelAddUser.TabIndex = 4;
            this.panelAddUser.Visible = false;
            // 
            // lbChooseItem
            // 
            this.lbChooseItem.AutoSize = true;
            this.lbChooseItem.Location = new System.Drawing.Point(126, 85);
            this.lbChooseItem.Name = "lbChooseItem";
            this.lbChooseItem.Size = new System.Drawing.Size(134, 20);
            this.lbChooseItem.TabIndex = 0;
            this.lbChooseItem.Text = "Choose the type :";
            // 
            // cbbItems
            // 
            this.cbbItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.cbbItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbItems.ForeColor = System.Drawing.Color.White;
            this.cbbItems.FormattingEnabled = true;
            this.cbbItems.Items.AddRange(new object[] {
            "User",
            "Tournament",
            "Organization",
            "Team"});
            this.cbbItems.Location = new System.Drawing.Point(380, 82);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.Size = new System.Drawing.Size(232, 28);
            this.cbbItems.TabIndex = 1;
            this.cbbItems.SelectedIndexChanged += new System.EventHandler(this.cbbItems_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 135);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(731, 582);
            this.dataGridView1.TabIndex = 2;
            // 
            // updateDataGridView
            // 
            this.updateDataGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDataGridView.Location = new System.Drawing.Point(338, 724);
            this.updateDataGridView.Name = "updateDataGridView";
            this.updateDataGridView.Size = new System.Drawing.Size(99, 32);
            this.updateDataGridView.TabIndex = 45;
            this.updateDataGridView.Text = "UPDATE";
            this.updateDataGridView.UseVisualStyleBackColor = true;
            // 
            // panelUpdateInfo
            // 
            this.panelUpdateInfo.Controls.Add(this.updateDataGridView);
            this.panelUpdateInfo.Controls.Add(this.dataGridView1);
            this.panelUpdateInfo.Controls.Add(this.cbbItems);
            this.panelUpdateInfo.Controls.Add(this.lbChooseItem);
            this.panelUpdateInfo.Location = new System.Drawing.Point(244, 0);
            this.panelUpdateInfo.Name = "panelUpdateInfo";
            this.panelUpdateInfo.Size = new System.Drawing.Size(759, 768);
            this.panelUpdateInfo.TabIndex = 44;
            this.panelUpdateInfo.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "AddUser";
            treeNode1.Text = "Add User to DB";
            treeNode2.Name = "UpdateInfo";
            treeNode2.Text = "Update Informations";
            treeNode3.Name = "ChangeSelfInfo";
            treeNode3.Text = "Change Your Informations";
            treeNode4.Name = "ShowInfo";
            treeNode4.Text = "Show Informations";
            treeNode5.Name = "PromUser";
            treeNode5.Text = "Promote an User";
            treeNode6.Name = "AddAdmin";
            treeNode6.Text = "Add an Administrator";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(235, 768);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form_Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(1005, 768);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panelUpdateInfo);
            this.Controls.Add(this.panelAddUser);
            this.Controls.Add(this.panelChangeInfo);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Administration";
            this.Load += new System.EventHandler(this.Form_Administration_Load);
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelUpdateInfo.ResumeLayout(false);
            this.panelUpdateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tps;
        private System.Windows.Forms.Panel panelChangeInfo;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.TextBox tbNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSelectType;
        private System.Windows.Forms.ComboBox cbbSelectType;
        private System.Windows.Forms.Label lbPwd;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label lbChooseItem;
        private System.Windows.Forms.ComboBox cbbItems;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateDataGridView;
        private System.Windows.Forms.Panel panelUpdateInfo;
        private System.Windows.Forms.TreeView treeView1;
    }
}