using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp.forms {
    public partial class Form_accueil : Form {
        public Form_accueil () {

            InitializeComponent();

            Traducteur.loadText( "fr" );
            Fonction.centerWindows( this );

            // traduction du panel de gauche
            lb_createAccount.Text = Traducteur.traduction_[0];
            tb_login.Text = Traducteur.traduction_[46];
            tb_pwd.Text = Traducteur.traduction_[47];

            // traduction du panel de droite
            lb_create_account.Text = Traducteur.traduction_[49];
            tb_prenom.Text = Traducteur.traduction_[50];
            tb_nom.Text = Traducteur.traduction_[51];
            tb_email.Text = Traducteur.traduction_[52];
            tb_password1.Text = Traducteur.traduction_[53];
            tb_password2.Text = Traducteur.traduction_[53];
            tb_pseudo.Text = Traducteur.traduction_[54];

            cb_choix_langue.Items.Clear();
            cb_choix_langue.Items.Add( Traducteur.traduction_[55] );
            cb_choix_langue.Items.Add( Traducteur.traduction_[56] );
            cb_choix_langue.SelectedIndex = 0;

        }

        private void bt_identification_Click ( object sender , EventArgs e ) {

            // pour l'identification joueur
            Users userToIdentification = new Users( tb_login.Text , tb_pwd.Text );

            if ( userToIdentification.identification() ) {

                // identification correct, on entre
                MessageBox.Show( this , Traducteur.traduction_[48] + " " + tb_login.Text );

            } else {
                MessageBox.Show( Traducteur.traduction_[1] );
            }

        }

        private void label_se_connecter_Click ( object sender , EventArgs e ) {
            panel_create_account.Visible = false;
            panel_login.Visible = true;
        }

        private void lb_createAccount_Click ( object sender , EventArgs e ) {
            panel_create_account.Visible = true;
            panel_login.Visible = false;
        }

        private void bt_identification_Click_1 ( object sender , EventArgs e ) {
            Users userConnexion = new Users( tb_login.Text , tb_pwd.Text );

            if ( userConnexion.identification() ) {

                Form f = new forms.accueil();
                Fonction.centerWindows( f );
                f.Closed += ( s , args ) => this.Close();
                f.ShowDialog();
                this.Hide();

            } else {
                MessageBox.Show(Traducteur.traduction_[2]);
            }


        }

        private void bouton_inscription_Click ( object sender , EventArgs e ) {

            if ( tb_prenom.Text.Length > 50 ) {
                MessageBox.Show( Traducteur.traduction_[4] );
            } else if ( tb_nom.Text.Length > 50 ) {
                MessageBox.Show( Traducteur.traduction_[3] );
            } else if ( tb_email.Text.Length > 255 ) {
                MessageBox.Show( Traducteur.traduction_[5] );
            } else if ( tb_password1.Text.Length > 255 ) {
                MessageBox.Show( Traducteur.traduction_[6] );
            } else if ( tb_password1.Text != tb_password2.Text ) {
                MessageBox.Show( Traducteur.traduction_[57] );
            } else if ( cb_choix_langue.SelectedItem.ToString() != Traducteur.traduction_[55] && cb_choix_langue.SelectedItem.ToString() != Traducteur.traduction_[56] ) {
                MessageBox.Show( Traducteur.traduction_[58] +" "+ Traducteur.traduction_[55] + " " + Traducteur.traduction_[60] + " " + Traducteur.traduction_[56] );
            } else {

                // on insert le nouvelle utilisateur en BDD avec les infos du form
                Users newUser = new Users( -1 );

                newUser.firstName = tb_prenom.Text;
                newUser.name = tb_nom.Text;
                newUser.email = tb_email.Text;
                newUser.password = tb_password1.Text;
                if ( cb_choix_langue.SelectedItem.ToString() == Traducteur.traduction_[55] ) {
                    newUser.language = "fr";
                } else if ( cb_choix_langue.SelectedItem.ToString() == Traducteur.traduction_[56] ) {
                    newUser.language = "en";
                }

                // insert en BDD
                newUser.insert();
                
                // on rentre dans le programme
                Form f = new forms.accueil();
                Fonction.centerWindows( f );
                f.Closed += ( s , args ) => this.Close();
                f.ShowDialog();
                this.Hide();


            }



        }
    }
}
