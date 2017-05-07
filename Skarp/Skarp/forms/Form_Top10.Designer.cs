namespace Skarp.forms {
    partial class Form_Top10 {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Battlerite" );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "League of Legends" );
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode( "Counter Strike GO" );
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode( "Dota2" );
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode( "Overwatch" );
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode( "Heavy Metal Machine" );
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode( "Paladin" );
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode( "Hearthstone" );
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode( "Orion Prelude" );
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode( "BattleBorn" );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Form_Top10 ) );
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.axWindowsMediaPlayer1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font( "Century Schoolbook" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point( 0 , 0 );
            this.treeView1.Margin = new System.Windows.Forms.Padding( 5 );
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Battlerite";
            treeNode1.Text = "Battlerite";
            treeNode2.Name = "League of Legends";
            treeNode2.Text = "League of Legends";
            treeNode3.Name = "Counter Strike GO";
            treeNode3.Text = "Counter Strike GO";
            treeNode4.Name = "Dota2";
            treeNode4.Text = "Dota2";
            treeNode5.Name = "Overwatch";
            treeNode5.Text = "Overwatch";
            treeNode6.Name = "Heavy Metal Machine";
            treeNode6.Text = "Heavy Metal Machine";
            treeNode7.Name = "Paladin";
            treeNode7.Text = "Paladin";
            treeNode8.Name = "Hearthstone";
            treeNode8.Text = "Hearthstone";
            treeNode9.Name = "Orion Prelude";
            treeNode9.Text = "Orion Prelude";
            treeNode10.Name = "BattleBorn";
            treeNode10.Text = "BattleBorn";
            this.treeView1.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10} );
            this.treeView1.Size = new System.Drawing.Size( 248 , 768 );
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.treeView1_AfterSelect );
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.axWindowsMediaPlayer1 );
            this.panel1.Controls.Add( this.tbDescription );
            this.panel1.Font = new System.Drawing.Font( "Century Schoolbook" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.panel1.Location = new System.Drawing.Point( 245 , 0 );
            this.panel1.Margin = new System.Windows.Forms.Padding( 5 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 761 , 768 );
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler( this.panel1_Leave );
            this.panel1.Leave += new System.EventHandler( this.panel1_Leave );
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.ForeColor = System.Drawing.Color.White;
            this.tbDescription.Location = new System.Drawing.Point( 15 , 582 );
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size( 731 , 155 );
            this.tbDescription.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point( 45 , 12 );
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ( (System.Windows.Forms.AxHost.State) ( resources.GetObject( "axWindowsMediaPlayer1.OcxState" ) ) );
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size( 627 , 542 );
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // Form_Top10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 10F , 20F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 1005 , 768 );
            this.Controls.Add( this.treeView1 );
            this.Controls.Add( this.panel1 );
            this.Font = new System.Drawing.Font( "Century Schoolbook" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding( 5 );
            this.Name = "Form_Top10";
            this.Text = "Form_Create_Organization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler( this.panel1_Leave );
            this.panel1.ResumeLayout( false );
            this.panel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) ( this.axWindowsMediaPlayer1 ) ).EndInit();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDescription;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}