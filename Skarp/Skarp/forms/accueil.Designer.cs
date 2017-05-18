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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accueil));
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
            this.voirEnDétailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.test2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fesdfsfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desJoueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promouvoirUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_general
            // 
            this.menu_general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menu_general.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.menu_general.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_general.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vosÉquipesToolStripMenuItem,
            this.tournoiToolStripMenuItem,
            this.toolStripMenuItem1,
            this.test2ToolStripMenuItem,
            this.organisationToolStripMenuItem,
            this.fesdfsfsToolStripMenuItem,
            this.webServiceToolStripMenuItem});
            this.menu_general.Location = new System.Drawing.Point(0, 0);
            this.menu_general.Name = "menu_general";
            this.menu_general.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_general.Size = new System.Drawing.Size(800, 28);
            this.menu_general.TabIndex = 8;
            this.menu_general.Text = "menuStrip1";
            // 
            // vosÉquipesToolStripMenuItem
            // 
            this.vosÉquipesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneÉquipeToolStripMenuItem,
            this.gérerVosÉquipesToolStripMenuItem,
            this.ajouterUnJoueurToolStripMenuItem});
            this.vosÉquipesToolStripMenuItem.Name = "vosÉquipesToolStripMenuItem";
            this.vosÉquipesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.vosÉquipesToolStripMenuItem.Text = Traducteur.traduction_[6];
            // 
            // ajouterUneÉquipeToolStripMenuItem
            // 
            this.ajouterUneÉquipeToolStripMenuItem.Name = "ajouterUneÉquipeToolStripMenuItem";
            this.ajouterUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.ajouterUneÉquipeToolStripMenuItem.Text = Traducteur.traduction_[7];
            this.ajouterUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneÉquipeToolStripMenuItem_Click);
            // 
            // gérerVosÉquipesToolStripMenuItem
            // 
            this.gérerVosÉquipesToolStripMenuItem.Name = "gérerVosÉquipesToolStripMenuItem";
            this.gérerVosÉquipesToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.gérerVosÉquipesToolStripMenuItem.Text = Traducteur.traduction_[8];
            this.gérerVosÉquipesToolStripMenuItem.Click += new System.EventHandler(this.gérerVosÉquipesToolStripMenuItem_Click);
            // 
            // ajouterUnJoueurToolStripMenuItem
            // 
            this.ajouterUnJoueurToolStripMenuItem.Name = "ajouterUnJoueurToolStripMenuItem";
            this.ajouterUnJoueurToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.ajouterUnJoueurToolStripMenuItem.Text = Traducteur.traduction_[9];
            this.ajouterUnJoueurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnJoueurToolStripMenuItem_Click);
            // 
            // tournoiToolStripMenuItem
            // 
            this.tournoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerToolStripMenuItem,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1,
            this.historiqueToolStripMenuItem,
            this.voirEnDétailToolStripMenuItem});
            this.tournoiToolStripMenuItem.Name = "tournoiToolStripMenuItem";
            this.tournoiToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.tournoiToolStripMenuItem.Text = Traducteur.traduction_[10];
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.créerToolStripMenuItem.Text = Traducteur.traduction_[11];
            this.créerToolStripMenuItem.Click += new System.EventHandler(this.créerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(178, 24);
            this.modifierToolStripMenuItem1.Text = Traducteur.traduction_[12];
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(178, 24);
            this.supprimerToolStripMenuItem1.Text = Traducteur.traduction_[13];
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enCoursToolStripMenuItem,
            this.historiqueToolStripMenuItem1});
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.historiqueToolStripMenuItem.Text = Traducteur.traduction_[14];
            // 
            // enCoursToolStripMenuItem
            // 
            this.enCoursToolStripMenuItem.Name = "enCoursToolStripMenuItem";
            this.enCoursToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.enCoursToolStripMenuItem.Text = Traducteur.traduction_[15];
            this.enCoursToolStripMenuItem.Click += new System.EventHandler(this.enCoursToolStripMenuItem_Click_1);
            // 
            // historiqueToolStripMenuItem1
            // 
            this.historiqueToolStripMenuItem1.Name = "historiqueToolStripMenuItem1";
            this.historiqueToolStripMenuItem1.Size = new System.Drawing.Size(143, 24);
            this.historiqueToolStripMenuItem1.Text = Traducteur.traduction_[16];
            this.historiqueToolStripMenuItem1.Click += new System.EventHandler(this.historiqueToolStripMenuItem1_Click_1);
            // 
            // voirEnDétailToolStripMenuItem
            // 
            this.voirEnDétailToolStripMenuItem.Name = "voirEnDétailToolStripMenuItem";
            this.voirEnDétailToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.voirEnDétailToolStripMenuItem.Text = Traducteur.traduction_[17];
            this.voirEnDétailToolStripMenuItem.Click += new System.EventHandler(this.voirEnDétailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.toolStripMenuItem1.Text = Traducteur.traduction_[18];
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.test2ToolStripMenuItem.Text = Traducteur.traduction_[19];
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // organisationToolStripMenuItem
            // 
            this.organisationToolStripMenuItem.Name = "organisationToolStripMenuItem";
            this.organisationToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.organisationToolStripMenuItem.Text = Traducteur.traduction_[20];
            this.organisationToolStripMenuItem.Click += new System.EventHandler(this.organisationToolStripMenuItem_Click);
            // 
            // fesdfsfsToolStripMenuItem
            // 
            this.fesdfsfsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnUtilisateurToolStripMenuItem,
            this.gestionBDDToolStripMenuItem,
            this.promouvoirUnUtilisateurToolStripMenuItem,
            this.ajouterUnToolStripMenuItem});
            this.fesdfsfsToolStripMenuItem.Name = "fesdfsfsToolStripMenuItem";
            this.fesdfsfsToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.fesdfsfsToolStripMenuItem.Text = Traducteur.traduction_[21];
            // 
            // ajouterUnUtilisateurToolStripMenuItem
            // 
            this.ajouterUnUtilisateurToolStripMenuItem.Name = "ajouterUnUtilisateurToolStripMenuItem";
            this.ajouterUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.ajouterUnUtilisateurToolStripMenuItem.Text = Traducteur.traduction_[22];
            this.ajouterUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnUtilisateurToolStripMenuItem_Click_1);
            // 
            // gestionBDDToolStripMenuItem
            // 
            this.gestionBDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desJoueursToolStripMenuItem,
            this.desÉquipesToolStripMenuItem});
            this.gestionBDDToolStripMenuItem.Name = "gestionBDDToolStripMenuItem";
            this.gestionBDDToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.gestionBDDToolStripMenuItem.Text = Traducteur.traduction_[23];
            // 
            // desJoueursToolStripMenuItem
            // 
            this.desJoueursToolStripMenuItem.Name = "desJoueursToolStripMenuItem";
            this.desJoueursToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.desJoueursToolStripMenuItem.Text = Traducteur.traduction_[24];
            this.desJoueursToolStripMenuItem.Click += new System.EventHandler(this.desJoueursToolStripMenuItem_Click_1);
            // 
            // desÉquipesToolStripMenuItem
            // 
            this.desÉquipesToolStripMenuItem.Name = "desÉquipesToolStripMenuItem";
            this.desÉquipesToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.desÉquipesToolStripMenuItem.Text = Traducteur.traduction_[25];
            this.desÉquipesToolStripMenuItem.Click += new System.EventHandler(this.desÉquipesToolStripMenuItem_Click);
            // 
            // promouvoirUnUtilisateurToolStripMenuItem
            // 
            this.promouvoirUnUtilisateurToolStripMenuItem.Name = "promouvoirUnUtilisateurToolStripMenuItem";
            this.promouvoirUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.promouvoirUnUtilisateurToolStripMenuItem.Text = Traducteur.traduction_[26];
            this.promouvoirUnUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.promouvoirUnUtilisateurToolStripMenuItem_Click);
            // 
            // ajouterUnToolStripMenuItem
            // 
            this.ajouterUnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.ajouterUnToolStripMenuItem.Name = "ajouterUnToolStripMenuItem";
            this.ajouterUnToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.ajouterUnToolStripMenuItem.Text = Traducteur.traduction_[27];
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.ajouterToolStripMenuItem.Text = Traducteur.traduction_[28];
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.modifierToolStripMenuItem.Text = Traducteur.traduction_[13];
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.supprimerToolStripMenuItem.Text = Traducteur.traduction_[14];
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // webServiceToolStripMenuItem
            // 
            this.webServiceToolStripMenuItem.Name = "webServiceToolStripMenuItem";
            this.webServiceToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.webServiceToolStripMenuItem.Text = Traducteur.traduction_[30];
            this.webServiceToolStripMenuItem.Click += new System.EventHandler(this.webServiceToolStripMenuItem_Click);
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(96)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.menu_general);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem voirEnDétailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webServiceToolStripMenuItem;
    }
}

