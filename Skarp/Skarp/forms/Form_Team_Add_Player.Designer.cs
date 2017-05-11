namespace Skarp.forms
{
    partial class Form_Team_Add_Player
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_sauvegarder = new System.Windows.Forms.Button();
            this.lb_choix_equipe = new System.Windows.Forms.Label();
            this.listbox_joueur_equipe = new System.Windows.Forms.ListBox();
            this.listbox_joueurs = new System.Windows.Forms.ListBox();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.lb_equipe_joueur = new System.Windows.Forms.Label();
            this.lb_les_joueurs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // button_sauvegarder
            // 
            this.button_sauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sauvegarder.Location = new System.Drawing.Point(287, 529);
            this.button_sauvegarder.Name = "button_sauvegarder";
            this.button_sauvegarder.Size = new System.Drawing.Size(249, 49);
            this.button_sauvegarder.TabIndex = 66;
            this.button_sauvegarder.Text = "Sauvegarder";
            this.button_sauvegarder.UseVisualStyleBackColor = true;
            this.button_sauvegarder.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lb_choix_equipe
            // 
            this.lb_choix_equipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_choix_equipe.Location = new System.Drawing.Point(209, 47);
            this.lb_choix_equipe.Name = "lb_choix_equipe";
            this.lb_choix_equipe.Size = new System.Drawing.Size(327, 34);
            this.lb_choix_equipe.TabIndex = 67;
            this.lb_choix_equipe.Text = "Choisissez une équipe";
            // 
            // listbox_joueur_equipe
            // 
            this.listbox_joueur_equipe.FormattingEnabled = true;
            this.listbox_joueur_equipe.ItemHeight = 23;
            this.listbox_joueur_equipe.Location = new System.Drawing.Point(50, 166);
            this.listbox_joueur_equipe.Name = "listbox_joueur_equipe";
            this.listbox_joueur_equipe.Size = new System.Drawing.Size(300, 326);
            this.listbox_joueur_equipe.Sorted = true;
            this.listbox_joueur_equipe.TabIndex = 2;
            // 
            // listbox_joueurs
            // 
            this.listbox_joueurs.FormattingEnabled = true;
            this.listbox_joueurs.ItemHeight = 23;
            this.listbox_joueurs.Location = new System.Drawing.Point(450, 166);
            this.listbox_joueurs.Name = "listbox_joueurs";
            this.listbox_joueurs.Size = new System.Drawing.Size(300, 326);
            this.listbox_joueurs.Sorted = true;
            this.listbox_joueurs.TabIndex = 5;
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(356, 346);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(79, 46);
            this.button_supprimer.TabIndex = 68;
            this.button_supprimer.Text = ">>>>>";
            this.button_supprimer.UseVisualStyleBackColor = true;
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(356, 266);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(79, 46);
            this.button_ajouter.TabIndex = 69;
            this.button_ajouter.Text = "<<<<<";
            this.button_ajouter.UseVisualStyleBackColor = true;
            // 
            // lb_equipe_joueur
            // 
            this.lb_equipe_joueur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_equipe_joueur.Location = new System.Drawing.Point(46, 129);
            this.lb_equipe_joueur.Name = "lb_equipe_joueur";
            this.lb_equipe_joueur.Size = new System.Drawing.Size(304, 34);
            this.lb_equipe_joueur.TabIndex = 70;
            this.lb_equipe_joueur.Text = "Les joueurs de l\'équipe";
            // 
            // lb_les_joueurs
            // 
            this.lb_les_joueurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_les_joueurs.Location = new System.Drawing.Point(446, 129);
            this.lb_les_joueurs.Name = "lb_les_joueurs";
            this.lb_les_joueurs.Size = new System.Drawing.Size(304, 34);
            this.lb_les_joueurs.TabIndex = 71;
            this.lb_les_joueurs.Text = "Joueurs disponible";
            // 
            // Form_Team_Add_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lb_les_joueurs);
            this.Controls.Add(this.lb_equipe_joueur);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.listbox_joueurs);
            this.Controls.Add(this.listbox_joueur_equipe);
            this.Controls.Add(this.lb_choix_equipe);
            this.Controls.Add(this.button_sauvegarder);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_Team_Add_Player";
            this.Text = "Form_Team_Add_Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_sauvegarder;
        private System.Windows.Forms.Label lb_choix_equipe;
        private System.Windows.Forms.ListBox listbox_joueur_equipe;
        private System.Windows.Forms.ListBox listbox_joueurs;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label lb_equipe_joueur;
        private System.Windows.Forms.Label lb_les_joueurs;
    }
}