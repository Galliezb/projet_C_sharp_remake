using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace Skarp.forms {
    public partial class Form_accueil : Form {

        News allNews;
        DataSet dataSetAllNews;
        Label[] lb_news = new Label[5];

        public Form_accueil () {

            InitializeComponent();
            Session.language = "fr";


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
                MessageBox.Show(Traducteur.traduction_[1]);
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
                newUser.pseudo = tb_pseudo.Text;

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

        private void Form_accueil_Load ( object sender , EventArgs e ) {

            Fonction.centerWindows( this );
            loadData();

        }

        private void pb_french_Click ( object sender , EventArgs e ) {

            this.Controls.Remove( lb_news[0] );
            this.Controls.Remove( lb_news[1] );
            this.Controls.Remove( lb_news[2] );
            this.Controls.Remove( lb_news[3] );
            this.Controls.Remove( lb_news[4] );

            if ( Session.language == "fr" ) {

                Session.language = "en";
                pb_french.Image = Properties.Resources.fr;

            } else {

                Session.language = "fr";
                pb_french.Image = Properties.Resources.en;

            }

            loadData();

        }

        public void loadData () {
            

            Traducteur.loadText( "fr" );
            

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

            allNews = new News();

            int maxNews = 0;
            dataSetAllNews = allNews.getAllNews();

            foreach ( DataRow rw in dataSetAllNews.Tables["News"].Rows ) {

                if ( rw["language"].ToString() == Session.language ) {

                    if ( maxNews == 5 ) {
                        break;
                    } else {
                        /*
                        PictureBox pct = new PictureBox();
                        pct.Size = new Size( 565 , 75 );
                        pct.Location = new Point( 4 , 100 + maxNews * 125 );
                        pct.Image = Properties.Resources.pixel_transparent;
                        pct.BorderStyle = BorderStyle.None;
                        this.Controls.Add( pct );
                        */

                        lb_news[maxNews] = new Label();
                        lb_news[maxNews].AutoSize = false;
                        lb_news[maxNews].Size = new Size( 565 , 50 );
                        lb_news[maxNews].Location = new Point( 4 , 100 + maxNews * 125 );
                        lb_news[maxNews].BorderStyle = BorderStyle.None;
                        lb_news[maxNews].ForeColor = Color.White;
                        lb_news[maxNews].BackColor = Color.Transparent;
                        lb_news[maxNews].Padding = new Padding( 5 );
                        lb_news[maxNews].Image = Properties.Resources.fond_news;
                        lb_news[maxNews].Text = rw["auteur"].ToString() + " : \n" + rw["message"].ToString();
                        this.Controls.Add( lb_news[maxNews] );

                        maxNews++;
                    }

                }

            }

        }
    }
}
