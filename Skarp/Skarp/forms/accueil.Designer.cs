namespace Skarp.forms {
    partial class accueil {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent () {
            this.menu_general = new System.Windows.Forms.MenuStrip();
            this.vosÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerVosÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fesdfsfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desJoueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promouvoirUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jajouteunmenutropfacilementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_general
            // 
            this.menu_general.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_general.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.menu_general.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_general.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vosÉquipesToolStripMenuItem,
            this.tournoiToolStripMenuItem,
            this.toolStripMenuItem1,
            this.test2ToolStripMenuItem,
            this.organisationToolStripMenuItem,
            this.fesdfsfsToolStripMenuItem});
            this.menu_general.Location = new System.Drawing.Point(0, 0);
            this.menu_general.Name = "menu_general";
            this.menu_general.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_general.Size = new System.Drawing.Size(800, 31);
            this.menu_general.TabIndex = 8;
            this.menu_general.Text = "menuStrip1";
            this.menu_general.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_general_ItemClicked);
            // 
            // vosÉquipesToolStripMenuItem
            // 
            this.vosÉquipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneÉquipeToolStripMenuItem,
            this.gérerVosÉquipesToolStripMenuItem,
            this.ajouterUnJoueurToolStripMenuItem});
            this.vosÉquipesToolStripMenuItem.Name = "vosÉquipesToolStripMenuItem";
            this.vosÉquipesToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.vosÉquipesToolStripMenuItem.Text = "Équipes";
            // 
            // ajouterUneÉquipeToolStripMenuItem
            // 
            this.ajouterUneÉquipeToolStripMenuItem.Name = "ajouterUneÉquipeToolStripMenuItem";
            this.ajouterUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(291, 28);
            this.ajouterUneÉquipeToolStripMenuItem.Text = "Ajouter une équipe";
            this.ajouterUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneÉquipeToolStripMenuItem_Click);
            // 
            // gérerVosÉquipesToolStripMenuItem
            // 
            this.gérerVosÉquipesToolStripMenuItem.Name = "gérerVosÉquipesToolStripMenuItem";
            this.gérerVosÉquipesToolStripMenuItem.Size = new System.Drawing.Size(291, 28);
            this.gérerVosÉquipesToolStripMenuItem.Text = "Gérer vos équipes";
            this.gérerVosÉquipesToolStripMenuItem.Click += new System.EventHandler(this.gérerVosÉquipesToolStripMenuItem_Click);
            // 
            // ajouterUnJoueurToolStripMenuItem
            // 
            this.ajouterUnJoueurToolStripMenuItem.Name = "ajouterUnJoueurToolStripMenuItem";
            this.ajouterUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(291, 28);
            this.ajouterUnJoueurToolStripMenuItem.Text = "Ajouter un joueur";
            // 
            // tournoiToolStripMenuItem
            // 
            this.tournoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1,
            this.historiqueToolStripMenuItem});
            this.tournoiToolStripMenuItem.Name = "tournoiToolStripMenuItem";
            this.tournoiToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.tournoiToolStripMenuItem.Text = "Tournoi";
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.créerToolStripMenuItem.Text = "Créer";
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(185, 28);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(185, 28);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enCoursToolStripMenuItem,
            this.historiqueToolStripMenuItem1});
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.historiqueToolStripMenuItem.Text = "Lister";
            // 
            // enCoursToolStripMenuItem
            // 
            this.enCoursToolStripMenuItem.Name = "enCoursToolStripMenuItem";
            this.enCoursToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.enCoursToolStripMenuItem.Text = "En cours";
            // 
            // historiqueToolStripMenuItem1
            // 
            this.historiqueToolStripMenuItem1.Name = "historiqueToolStripMenuItem1";
            this.historiqueToolStripMenuItem1.Size = new System.Drawing.Size(167, 28);
            this.historiqueToolStripMenuItem1.Text = "Fini";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 27);
            this.toolStripMenuItem1.Text = "Top 10";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.test2ToolStripMenuItem.Text = "Options";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // organisationToolStripMenuItem
            // 
            this.organisationToolStripMenuItem.Name = "organisationToolStripMenuItem";
            this.organisationToolStripMenuItem.Size = new System.Drawing.Size(143, 27);
            this.organisationToolStripMenuItem.Text = "Organisation";
            this.organisationToolStripMenuItem.Click += new System.EventHandler(this.organisationToolStripMenuItem_Click);
            // 
            // fesdfsfsToolStripMenuItem
            // 
            this.fesdfsfsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnUtilisateurToolStripMenuItem,
            this.gestionBDDToolStripMenuItem,
            this.promouvoirUnUtilisateurToolStripMenuItem,
            this.ajouterUnToolStripMenuItem,
            this.jajouteunmenutropfacilementToolStripMenuItem});
            this.fesdfsfsToolStripMenuItem.Name = "fesdfsfsToolStripMenuItem";
            this.fesdfsfsToolStripMenuItem.Size = new System.Drawing.Size(162, 27);
            this.fesdfsfsToolStripMenuItem.Text = "Administration";
            // 
            // ajouterUnUtilisateurToolStripMenuItem
            // 
            this.ajouterUnUtilisateurToolStripMenuItem.Name = "ajouterUnUtilisateurToolStripMenuItem";
            this.ajouterUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.ajouterUnUtilisateurToolStripMenuItem.Text = "Ajouter des utilisateurs";
            this.ajouterUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnUtilisateurToolStripMenuItem_Click_1);
            // 
            // gestionBDDToolStripMenuItem
            // 
            this.gestionBDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desJoueursToolStripMenuItem});
            this.gestionBDDToolStripMenuItem.Name = "gestionBDDToolStripMenuItem";
            this.gestionBDDToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.gestionBDDToolStripMenuItem.Text = "Afficher la liste";
            // 
            // desJoueursToolStripMenuItem
            // 
            this.desJoueursToolStripMenuItem.Name = "desJoueursToolStripMenuItem";
            this.desJoueursToolStripMenuItem.Size = new System.Drawing.Size(195, 28);
            this.desJoueursToolStripMenuItem.Text = "Des joueurs";
            this.desJoueursToolStripMenuItem.Click += new System.EventHandler(this.desJoueursToolStripMenuItem_Click_1);
            // 
            // promouvoirUnUtilisateurToolStripMenuItem
            // 
            this.promouvoirUnUtilisateurToolStripMenuItem.Name = "promouvoirUnUtilisateurToolStripMenuItem";
            this.promouvoirUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.promouvoirUnUtilisateurToolStripMenuItem.Text = "Promouvoir un utilisateur";
            this.promouvoirUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.promouvoirUnUtilisateurToolStripMenuItem_Click);
            // 
            // ajouterUnToolStripMenuItem
            // 
            this.ajouterUnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.ajouterUnToolStripMenuItem.Name = "ajouterUnToolStripMenuItem";
            this.ajouterUnToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.ajouterUnToolStripMenuItem.Text = "Les nouvelles";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // jajouteunmenutropfacilementToolStripMenuItem
            // 
            this.jajouteunmenutropfacilementToolStripMenuItem.Name = "jajouteunmenutropfacilementToolStripMenuItem";
            this.jajouteunmenutropfacilementToolStripMenuItem.Size = new System.Drawing.Size(327, 28);
            this.jajouteunmenutropfacilementToolStripMenuItem.Text = "Active Directory";
            this.jajouteunmenutropfacilementToolStripMenuItem.Click += new System.EventHandler(this.jajouteunmenutropfacilementToolStripMenuItem_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.menu_general);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_general;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "accueil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_general.ResumeLayout(false);
            this.menu_general.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_general;
        private System.Windows.Forms.ToolStripMenuItem test2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fesdfsfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionBDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promouvoirUnUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jajouteunmenutropfacilementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desJoueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vosÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerVosÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem organisationToolStripMenuItem;
    }
}

