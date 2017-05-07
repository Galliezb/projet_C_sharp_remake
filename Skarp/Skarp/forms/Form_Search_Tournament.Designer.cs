namespace Skarp.forms {
    partial class Form_Search_Tournament {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 0 ) ) ) ) , ( (int) ( ( (byte) ( 122 ) ) ) ) , ( (int) ( ( (byte) ( 204 ) ) ) ) );
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.dataGridView1.Location = new System.Drawing.Point( 12 , 283 );
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size( 981 , 473 );
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 0 ) ) ) ) , ( (int) ( ( (byte) ( 122 ) ) ) ) , ( (int) ( ( (byte) ( 204 ) ) ) ) );
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange( new object[] {
            "Type",
            "Nom",
            "Jour",
            "Mois",
            "Annee"} );
            this.comboBox1.Location = new System.Drawing.Point( 12 , 113 );
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size( 236 , 28 );
            this.comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 0 ) ) ) ) , ( (int) ( ( (byte) ( 122 ) ) ) ) , ( (int) ( ( (byte) ( 204 ) ) ) ) );
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point( 307 , 113 );
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size( 294 , 20 );
            this.textBox1.TabIndex = 2;
            // 
            // Form_Search_Tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 10F , 20F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 66 ) ) ) ) , ( (int) ( ( (byte) ( 96 ) ) ) ) , ( (int) ( ( (byte) ( 154 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 1005 , 768 );
            this.Controls.Add( this.textBox1 );
            this.Controls.Add( this.comboBox1 );
            this.Controls.Add( this.dataGridView1 );
            this.Font = new System.Drawing.Font( "Century Schoolbook" , 12F , System.Drawing.FontStyle.Regular , System.Drawing.GraphicsUnit.Point , ( (byte) ( 0 ) ) );
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding( 5 );
            this.Name = "Form_Search_Tournament";
            this.Text = "Form_Search_Tournament";
            this.Load += new System.EventHandler( this.Form_Search_Tournament_Load );
            ( (System.ComponentModel.ISupportInitialize) ( this.dataGridView1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}