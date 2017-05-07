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

            // centre le formulaire 
            Fonction.centerWindows( this );

        }
        
        private void Form1_Load ( object sender , EventArgs e ) {

            // défini la langue par défaut au démarrage applicatif
            Session.language = "fr";
            // charge la langue depuis le fichier
            Traducteur.traduction_.Clear();
            Traducteur.loadText( "fr" );
            /*
            Form form = new forms.Form_accueil();
            form.MdiParent = this;
            form.Show();
            */
        }

        private void test2ToolStripMenuItem_Click ( object sender , EventArgs e ) {
            
            closeAll();
            affichage = new forms.Form_Settings_User();
            displayForm();
            
        }

        private void closeAll() {

            foreach(Form f in this.MdiChildren ) {
                int x = 0;
                while ( true ) {
                    f.Location = new Point( x , 0 );
                    x++;
                    if ( x > 800 ) {
                        break;
                    }
                }

                f.Close();
            }

        }

        private void displayForm () {

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
            affichage.MdiParent = this;
            displayForm();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Top10();
            displayForm(affichage);
        }

        private void promouvoirUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeAll();
            affichage = new forms.Form_Administration_Promote_User();
            displayForm(affichage);
        }
    }
}
