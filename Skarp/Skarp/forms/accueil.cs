﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Skarp.forms {
    public partial class accueil : Form {

        Form affichage;

        public accueil () {

            InitializeComponent();

            if ( Session.isAdmin == false ) {
                menu_general.Items[5].Visible = false;

            }
            if ( Session.isOrganizer == false ) {
                menu_general.Items[4].Visible = false;
                ToolStripItemCollection leMenuTournoi = ( (ToolStripMenuItem) menu_general.Items[1] ).DropDownItems;
                leMenuTournoi[0].Visible = false;
                leMenuTournoi[1].Visible = false;
                leMenuTournoi[2].Visible = false;
                leMenuTournoi[4].Visible = false;

            }

            // centre le formulaire 
            Fonction.centerWindows( this );

        }
        
        private void Form1_Load ( object sender , EventArgs e ) {

            closeAll();
            affichage = new forms.Form_WebService();
            displayForm();

        }

        public void reloadAllData () {

            // défini la langue par défaut au démarrage applicatif
            if ( Session.language == null ) {
                Session.language = "fr";
                MessageBox.Show( "Force session fr" );
            }
            // charge la langue depuis le fichier
            // l'identification avec les infos en BDD a peut-être changer cette valeure, on recharge donc
            Traducteur.traduction_.Clear();
            Traducteur.loadText( Session.language );

            vosÉquipesToolStripMenuItem.Text = Traducteur.traduction_[6];
            ajouterUneÉquipeToolStripMenuItem.Text = Traducteur.traduction_[7];
            gérerVosÉquipesToolStripMenuItem.Text = Traducteur.traduction_[8];
            ajouterUnJoueurToolStripMenuItem.Text = Traducteur.traduction_[9];
            tournoiToolStripMenuItem.Text = Traducteur.traduction_[10];
            créerToolStripMenuItem.Text = Traducteur.traduction_[11];
            modifierToolStripMenuItem1.Text = Traducteur.traduction_[12];
            supprimerToolStripMenuItem1.Text = Traducteur.traduction_[13];
            historiqueToolStripMenuItem.Text = Traducteur.traduction_[14];
            enCoursToolStripMenuItem.Text = Traducteur.traduction_[15];
            historiqueToolStripMenuItem1.Text = Traducteur.traduction_[16];
            voirEnDétailToolStripMenuItem.Text = Traducteur.traduction_[17];
            toolStripMenuItem1.Text = Traducteur.traduction_[18];
            test2ToolStripMenuItem.Text = Traducteur.traduction_[19];
            organisationToolStripMenuItem.Text = Traducteur.traduction_[20];
            fesdfsfsToolStripMenuItem.Text = Traducteur.traduction_[21];
            ajouterUnUtilisateurToolStripMenuItem.Text = Traducteur.traduction_[22];
            gestionBDDToolStripMenuItem.Text = Traducteur.traduction_[23];
            desJoueursToolStripMenuItem.Text = Traducteur.traduction_[24];
            desÉquipesToolStripMenuItem.Text = Traducteur.traduction_[25];
            promouvoirUnUtilisateurToolStripMenuItem.Text = Traducteur.traduction_[26];
            ajouterUnToolStripMenuItem.Text = Traducteur.traduction_[27];
            ajouterToolStripMenuItem.Text = Traducteur.traduction_[28];
            modifierToolStripMenuItem.Text = Traducteur.traduction_[12];
            supprimerToolStripMenuItem.Text = Traducteur.traduction_[13];
            webServiceToolStripMenuItem.Text = Traducteur.traduction_[30];


            closeAll();
            affichage = new forms.Form_Settings_User(this);
            displayForm();

        }

        private void test2ToolStripMenuItem_Click ( object sender , EventArgs e ) {
            
            closeAll();
            affichage = new forms.Form_Settings_User(this);
            displayForm();
            
        }

        private void closeAll() {

            foreach(Form f in this.MdiChildren ) {
                f.Close();
            }

        }

        private void displayForm () {

            // paramètre par défaut de tout enfant du MDI
            affichage.MdiParent = this;
            affichage.FormBorderStyle = FormBorderStyle.None;
            affichage.StartPosition = FormStartPosition.Manual;
            affichage.WindowState = FormWindowState.Maximized;
            affichage.Font = new Font( "Century Schoolbook" , 12 );
            affichage.Location = new Point( 0 , 0 );
            affichage.Size = new Size( 800 , 628 );
            affichage.BackColor = Color.FromArgb(66, 96, 154);
            affichage.ForeColor = Color.White;
            affichage.ShowIcon = false;
            affichage.Show();

        }

        private void ajouterUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Administration_Add_User();
            displayForm();
        }

        private void desJoueursToolStripMenuItem_Click ( object sender , EventArgs e ) {
            closeAll();
            affichage = new forms.Form_administration_voir_joueurs();
            displayForm();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Top10();
            displayForm();
        }

        private void promouvoirUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Administration_Promote_User();
            displayForm();
        }
       

        private void ajouterUnUtilisateurToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Administration_Add_User();
            displayForm();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Top10();
            displayForm();
        }

        private void desJoueursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_administration_voir_joueurs();
            displayForm();
        }

        private void ajouterToolStripMenuItem_Click ( object sender , EventArgs e ) {
            closeAll();
            affichage = new forms.Form_administration_news_ajouter();
            displayForm();
        }

        private void modifierToolStripMenuItem_Click ( object sender , EventArgs e ) {
            closeAll();
            affichage = new forms.Form_administration_news_modifier();
            displayForm();
        }

        private void supprimerToolStripMenuItem_Click ( object sender , EventArgs e ) {
            closeAll();
            affichage = new forms.Form_administration_news_delete();
            displayForm();
        }

        private void ajouterUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_AddTeam();
            displayForm();
        }

        private void gérerVosÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Team_Manage();
            displayForm();
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_Add();
            displayForm();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_Manage();
            displayForm();
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_Delete();
            displayForm();
        }

        private void organisationToolStripMenuItem_Click ( object sender , EventArgs e ) {
            closeAll();
            affichage = new forms.Form_organisation();
            displayForm();
        }

        private void historiqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_List_Ended( this );
            displayForm();
        }

        private void enCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_List_Started();
            displayForm();
        }

        private void ajouterUnJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Team_Add_Player();
            displayForm();
        }

        private void historiqueToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_List_Ended(this);
            displayForm();
        }

        private void enCoursToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Tournament_List_Started();
            displayForm();
        }

        private void voirEnDétailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Create_Arbo();
            displayForm();
        }

        private void desÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Administration_Voir_Equipes();
            displayForm();
        }

        private void webServiceToolStripMenuItem_Click ( object sender , EventArgs e ) {
            closeAll();
            affichage = new forms.Form_WebService();
            displayForm();
        }

        public void voirDetailsTournament ( int idArboToSee) {
            closeAll();
            affichage = new forms.Form_tournament_details_read_only( idArboToSee );
            displayForm();
        }
    }
}
