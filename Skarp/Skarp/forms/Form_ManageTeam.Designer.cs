namespace Skarp {
    partial class Form_ManageTeam {
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
            this.btCreateTeam = new System.Windows.Forms.Button();
            this.PanelChooseTeam = new System.Windows.Forms.Panel();
            this.cbbChooseTeam = new System.Windows.Forms.ComboBox();
            this.lbChooseTeam = new System.Windows.Forms.Label();
            this.PanelRightCT = new System.Windows.Forms.Panel();
            this.PanelModifyTeam = new System.Windows.Forms.Panel();
            this.cbbDelPlayer = new System.Windows.Forms.ComboBox();
            this.cbbDelGame = new System.Windows.Forms.ComboBox();
            this.tbNewTag = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.lbDeletePlayer = new System.Windows.Forms.Label();
            this.lbDelGame = new System.Windows.Forms.Label();
            this.lbNewTag = new System.Windows.Forms.Label();
            this.lbChangeName = new System.Windows.Forms.Label();
            this.tbDescriptionCT = new System.Windows.Forms.TextBox();
            this.tbAddGameCT = new System.Windows.Forms.TextBox();
            this.tbTagCT = new System.Windows.Forms.TextBox();
            this.tbNameCT = new System.Windows.Forms.TextBox();
            this.lbTagCT = new System.Windows.Forms.Label();
            this.lbDescriptionCT = new System.Windows.Forms.Label();
            this.lbAddGameCT = new System.Windows.Forms.Label();
            this.lbNameCT = new System.Windows.Forms.Label();
            this.btCreate_Team = new System.Windows.Forms.Button();
            this.btUpdate_Team = new System.Windows.Forms.Button();
            this.PanelChooseTeam.SuspendLayout();
            this.PanelRightCT.SuspendLayout();
            this.PanelModifyTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCreateTeam
            // 
            this.btCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateTeam.Location = new System.Drawing.Point( 131 , 62 );
            this.btCreateTeam.Name = "btCreateTeam";
            this.btCreateTeam.Size = new System.Drawing.Size( 180 , 36 );
            this.btCreateTeam.TabIndex = 0;
            this.btCreateTeam.Text = "Create Team";
            this.btCreateTeam.UseVisualStyleBackColor = true;
            this.btCreateTeam.Click += new System.EventHandler( this.btCreateTeam_Click );
            // 
            // PanelChooseTeam
            // 
            this.PanelChooseTeam.Controls.Add( this.cbbChooseTeam );
            this.PanelChooseTeam.Controls.Add( this.lbChooseTeam );
            this.PanelChooseTeam.Location = new System.Drawing.Point( 131 , 129 );
            this.PanelChooseTeam.Name = "PanelChooseTeam";
            this.PanelChooseTeam.Size = new System.Drawing.Size( 266 , 112 );
            this.PanelChooseTeam.TabIndex = 1;
            // 
            // cbbChooseTeam
            // 
            this.cbbChooseTeam.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.cbbChooseTeam.ForeColor = System.Drawing.Color.White;
            this.cbbChooseTeam.FormattingEnabled = true;
            this.cbbChooseTeam.Location = new System.Drawing.Point( 8 , 47 );
            this.cbbChooseTeam.Name = "cbbChooseTeam";
            this.cbbChooseTeam.Size = new System.Drawing.Size( 218 , 28 );
            this.cbbChooseTeam.TabIndex = 1;
            this.cbbChooseTeam.SelectedIndexChanged += new System.EventHandler( this.cbbChooseTeam_SelectedIndexChanged );
            // 
            // lbChooseTeam
            // 
            this.lbChooseTeam.AutoSize = true;
            this.lbChooseTeam.Location = new System.Drawing.Point( 4 , 4 );
            this.lbChooseTeam.Name = "lbChooseTeam";
            this.lbChooseTeam.Size = new System.Drawing.Size( 121 , 20 );
            this.lbChooseTeam.TabIndex = 0;
            this.lbChooseTeam.Text = "Choose a Team";
            // 
            // PanelRightCT
            // 
            this.PanelRightCT.Controls.Add( this.PanelModifyTeam );
            this.PanelRightCT.Controls.Add( this.tbDescriptionCT );
            this.PanelRightCT.Controls.Add( this.tbAddGameCT );
            this.PanelRightCT.Controls.Add( this.tbTagCT );
            this.PanelRightCT.Controls.Add( this.tbNameCT );
            this.PanelRightCT.Controls.Add( this.lbTagCT );
            this.PanelRightCT.Controls.Add( this.lbDescriptionCT );
            this.PanelRightCT.Controls.Add( this.lbAddGameCT );
            this.PanelRightCT.Controls.Add( this.lbNameCT );
            this.PanelRightCT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRightCT.Location = new System.Drawing.Point( 431 , 0 );
            this.PanelRightCT.Name = "PanelRightCT";
            this.PanelRightCT.Size = new System.Drawing.Size( 558 , 729 );
            this.PanelRightCT.TabIndex = 2;
            this.PanelRightCT.Visible = false;
            // 
            // PanelModifyTeam
            // 
            this.PanelModifyTeam.Controls.Add( this.cbbDelPlayer );
            this.PanelModifyTeam.Controls.Add( this.cbbDelGame );
            this.PanelModifyTeam.Controls.Add( this.tbNewTag );
            this.PanelModifyTeam.Controls.Add( this.tbNewName );
            this.PanelModifyTeam.Controls.Add( this.lbDeletePlayer );
            this.PanelModifyTeam.Controls.Add( this.lbDelGame );
            this.PanelModifyTeam.Controls.Add( this.lbNewTag );
            this.PanelModifyTeam.Controls.Add( this.lbChangeName );
            this.PanelModifyTeam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelModifyTeam.Location = new System.Drawing.Point( 0 , 320 );
            this.PanelModifyTeam.Name = "PanelModifyTeam";
            this.PanelModifyTeam.Size = new System.Drawing.Size( 558 , 409 );
            this.PanelModifyTeam.TabIndex = 20;
            this.PanelModifyTeam.Visible = false;
            // 
            // cbbDelPlayer
            // 
            this.cbbDelPlayer.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.cbbDelPlayer.ForeColor = System.Drawing.Color.White;
            this.cbbDelPlayer.FormattingEnabled = true;
            this.cbbDelPlayer.Location = new System.Drawing.Point( 302 , 207 );
            this.cbbDelPlayer.Name = "cbbDelPlayer";
            this.cbbDelPlayer.Size = new System.Drawing.Size( 232 , 28 );
            this.cbbDelPlayer.TabIndex = 24;
            // 
            // cbbDelGame
            // 
            this.cbbDelGame.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.cbbDelGame.ForeColor = System.Drawing.Color.White;
            this.cbbDelGame.FormattingEnabled = true;
            this.cbbDelGame.Location = new System.Drawing.Point( 302 , 147 );
            this.cbbDelGame.Name = "cbbDelGame";
            this.cbbDelGame.Size = new System.Drawing.Size( 232 , 28 );
            this.cbbDelGame.TabIndex = 23;
            // 
            // tbNewTag
            // 
            this.tbNewTag.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbNewTag.ForeColor = System.Drawing.Color.White;
            this.tbNewTag.Location = new System.Drawing.Point( 302 , 87 );
            this.tbNewTag.Name = "tbNewTag";
            this.tbNewTag.Size = new System.Drawing.Size( 232 , 27 );
            this.tbNewTag.TabIndex = 22;
            // 
            // tbNewName
            // 
            this.tbNewName.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbNewName.ForeColor = System.Drawing.Color.White;
            this.tbNewName.Location = new System.Drawing.Point( 302 , 27 );
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size( 232 , 27 );
            this.tbNewName.TabIndex = 21;
            // 
            // lbDeletePlayer
            // 
            this.lbDeletePlayer.AutoSize = true;
            this.lbDeletePlayer.Location = new System.Drawing.Point( 37 , 210 );
            this.lbDeletePlayer.Name = "lbDeletePlayer";
            this.lbDeletePlayer.Size = new System.Drawing.Size( 134 , 20 );
            this.lbDeletePlayer.TabIndex = 3;
            this.lbDeletePlayer.Text = "Delete a Player : ";
            // 
            // lbDelGame
            // 
            this.lbDelGame.AutoSize = true;
            this.lbDelGame.Location = new System.Drawing.Point( 37 , 150 );
            this.lbDelGame.Name = "lbDelGame";
            this.lbDelGame.Size = new System.Drawing.Size( 124 , 20 );
            this.lbDelGame.TabIndex = 2;
            this.lbDelGame.Text = "Delete a Game :";
            // 
            // lbNewTag
            // 
            this.lbNewTag.AutoSize = true;
            this.lbNewTag.Location = new System.Drawing.Point( 37 , 90 );
            this.lbNewTag.Name = "lbNewTag";
            this.lbNewTag.Size = new System.Drawing.Size( 86 , 20 );
            this.lbNewTag.TabIndex = 1;
            this.lbNewTag.Text = "New Tag : ";
            // 
            // lbChangeName
            // 
            this.lbChangeName.AutoSize = true;
            this.lbChangeName.Location = new System.Drawing.Point( 37 , 30 );
            this.lbChangeName.Name = "lbChangeName";
            this.lbChangeName.Size = new System.Drawing.Size( 97 , 20 );
            this.lbChangeName.TabIndex = 0;
            this.lbChangeName.Text = "New Name :";
            // 
            // tbDescriptionCT
            // 
            this.tbDescriptionCT.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbDescriptionCT.ForeColor = System.Drawing.Color.White;
            this.tbDescriptionCT.Location = new System.Drawing.Point( 302 , 247 );
            this.tbDescriptionCT.Multiline = true;
            this.tbDescriptionCT.Name = "tbDescriptionCT";
            this.tbDescriptionCT.Size = new System.Drawing.Size( 232 , 67 );
            this.tbDescriptionCT.TabIndex = 19;
            // 
            // tbAddGameCT
            // 
            this.tbAddGameCT.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbAddGameCT.ForeColor = System.Drawing.Color.White;
            this.tbAddGameCT.Location = new System.Drawing.Point( 302 , 187 );
            this.tbAddGameCT.Name = "tbAddGameCT";
            this.tbAddGameCT.Size = new System.Drawing.Size( 232 , 27 );
            this.tbAddGameCT.TabIndex = 18;
            // 
            // tbTagCT
            // 
            this.tbTagCT.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbTagCT.ForeColor = System.Drawing.Color.White;
            this.tbTagCT.Location = new System.Drawing.Point( 302 , 127 );
            this.tbTagCT.Name = "tbTagCT";
            this.tbTagCT.Size = new System.Drawing.Size( 232 , 27 );
            this.tbTagCT.TabIndex = 17;
            // 
            // tbNameCT
            // 
            this.tbNameCT.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbNameCT.ForeColor = System.Drawing.Color.White;
            this.tbNameCT.Location = new System.Drawing.Point( 302 , 67 );
            this.tbNameCT.Name = "tbNameCT";
            this.tbNameCT.Size = new System.Drawing.Size( 232 , 27 );
            this.tbNameCT.TabIndex = 16;
            // 
            // lbTagCT
            // 
            this.lbTagCT.AutoSize = true;
            this.lbTagCT.Location = new System.Drawing.Point( 37 , 130 );
            this.lbTagCT.Name = "lbTagCT";
            this.lbTagCT.Size = new System.Drawing.Size( 96 , 20 );
            this.lbTagCT.TabIndex = 15;
            this.lbTagCT.Text = "Team Tag : ";
            // 
            // lbDescriptionCT
            // 
            this.lbDescriptionCT.AutoSize = true;
            this.lbDescriptionCT.Location = new System.Drawing.Point( 37 , 250 );
            this.lbDescriptionCT.Name = "lbDescriptionCT";
            this.lbDescriptionCT.Size = new System.Drawing.Size( 147 , 20 );
            this.lbDescriptionCT.TabIndex = 14;
            this.lbDescriptionCT.Text = "Team Description :";
            // 
            // lbAddGameCT
            // 
            this.lbAddGameCT.AutoSize = true;
            this.lbAddGameCT.Location = new System.Drawing.Point( 37 , 190 );
            this.lbAddGameCT.Name = "lbAddGameCT";
            this.lbAddGameCT.Size = new System.Drawing.Size( 111 , 20 );
            this.lbAddGameCT.TabIndex = 13;
            this.lbAddGameCT.Text = "Add a Game : ";
            // 
            // lbNameCT
            // 
            this.lbNameCT.AutoSize = true;
            this.lbNameCT.Location = new System.Drawing.Point( 37 , 70 );
            this.lbNameCT.Name = "lbNameCT";
            this.lbNameCT.Size = new System.Drawing.Size( 61 , 20 );
            this.lbNameCT.TabIndex = 12;
            this.lbNameCT.Text = "Name :";
            // 
            // btCreate_Team
            // 
            this.btCreate_Team.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreate_Team.Location = new System.Drawing.Point( 163 , 378 );
            this.btCreate_Team.Name = "btCreate_Team";
            this.btCreate_Team.Size = new System.Drawing.Size( 161 , 85 );
            this.btCreate_Team.TabIndex = 3;
            this.btCreate_Team.Text = "Submit";
            this.btCreate_Team.UseVisualStyleBackColor = false;
            this.btCreate_Team.Click += new System.EventHandler( this.btCreate_Team_Click );
            // 
            // btUpdate_Team
            // 
            this.btUpdate_Team.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate_Team.Location = new System.Drawing.Point( 163 , 287 );
            this.btUpdate_Team.Name = "btUpdate_Team";
            this.btUpdate_Team.Size = new System.Drawing.Size( 161 , 85 );
            this.btUpdate_Team.TabIndex = 3;
            this.btUpdate_Team.Text = "Submit";
            this.btUpdate_Team.UseVisualStyleBackColor = false;
            // 
            // Form_ManageTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 10F , 20F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 989 , 729 );
            this.Controls.Add( this.btUpdate_Team );
            this.Controls.Add( this.btCreate_Team );
            this.Controls.Add( this.PanelRightCT );
            this.Controls.Add( this.PanelChooseTeam );
            this.Controls.Add( this.btCreateTeam );
            this.Font = new System.Drawing.Font( "Century Schoolbook" , 12F );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding( 4 );
            this.Name = "Form_ManageTeam";
            this.Text = "Form_ManageTeam";
            this.Load += new System.EventHandler( this.Form_ManageTeam_Load );
            this.PanelChooseTeam.ResumeLayout( false );
            this.PanelChooseTeam.PerformLayout();
            this.PanelRightCT.ResumeLayout( false );
            this.PanelRightCT.PerformLayout();
            this.PanelModifyTeam.ResumeLayout( false );
            this.PanelModifyTeam.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button btCreateTeam;
        private System.Windows.Forms.Panel PanelChooseTeam;
        private System.Windows.Forms.Label lbChooseTeam;
        private System.Windows.Forms.ComboBox cbbChooseTeam;
        private System.Windows.Forms.Panel PanelRightCT;
        private System.Windows.Forms.Panel PanelModifyTeam;
        private System.Windows.Forms.Label lbChangeName;
        private System.Windows.Forms.TextBox tbDescriptionCT;
        private System.Windows.Forms.TextBox tbAddGameCT;
        private System.Windows.Forms.TextBox tbTagCT;
        private System.Windows.Forms.TextBox tbNameCT;
        private System.Windows.Forms.Label lbTagCT;
        private System.Windows.Forms.Label lbDescriptionCT;
        private System.Windows.Forms.Label lbAddGameCT;
        private System.Windows.Forms.Label lbNameCT;
        private System.Windows.Forms.ComboBox cbbDelPlayer;
        private System.Windows.Forms.ComboBox cbbDelGame;
        private System.Windows.Forms.TextBox tbNewTag;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label lbDeletePlayer;
        private System.Windows.Forms.Label lbDelGame;
        private System.Windows.Forms.Label lbNewTag;
        private System.Windows.Forms.Button btCreate_Team;
        private System.Windows.Forms.Button btUpdate_Team;
    }
}