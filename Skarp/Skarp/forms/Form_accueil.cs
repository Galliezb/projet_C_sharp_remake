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

                MessageBox.Show( Traducteur.traduction_[31] +" "+ Session.pseudo );

                Form f = new forms.accueil();
                Fonction.centerWindows( f );
                f.Closed += ( s , args ) => this.Close();
                f.ShowDialog();
                this.Hide();

            } else {
                MessageBox.Show(Traducteur.traduction_[32]);
            }


        }
        

        private void bouton_inscription_Click ( object sender , EventArgs e ) {

            if ( tb_prenom.Text.Length > 50 ) {
                MessageBox.Show( Traducteur.traduction_[42] );
            } else if ( tb_nom.Text.Length > 50 ) {
                MessageBox.Show( Traducteur.traduction_[43] );
            } else if ( tb_email.Text.Length > 255 ) {
                MessageBox.Show( Traducteur.traduction_[44] );
            } else if ( tb_password1.Text.Length > 255 ) {
                MessageBox.Show( Traducteur.traduction_[45] );
            } else if ( tb_password1.Text != tb_password2.Text ) {
                MessageBox.Show( Traducteur.traduction_[46] );
            } else if ( cb_choix_langue.SelectedItem.ToString() != Traducteur.traduction_[40] && cb_choix_langue.SelectedItem.ToString() != Traducteur.traduction_[41] ) {
                MessageBox.Show( Traducteur.traduction_[47] +" "+ Traducteur.traduction_[40] + " " + Traducteur.traduction_[48] + " " + Traducteur.traduction_[41] );
            } else {

                // on insert le nouvelle utilisateur en BDD avec les infos du form
                Users newUser = new Users( -1 );

                newUser.firstName = tb_prenom.Text;
                newUser.name = tb_nom.Text;
                newUser.email = tb_email.Text;
                newUser.password = tb_password1.Text;
                newUser.pseudo = tb_pseudo.Text;

                if ( cb_choix_langue.SelectedItem.ToString() == Traducteur.traduction_[40] ) {
                    newUser.language = "fr";
                } else if ( cb_choix_langue.SelectedItem.ToString() == Traducteur.traduction_[41] ) {
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
            

            Traducteur.loadText( Session.language );
            

            // traduction du panel de gauche
            lb_createAccount.Text = Traducteur.traduction_[33];
            tb_login.Text = Traducteur.traduction_[34];
            tb_pwd.Text = Traducteur.traduction_[35];

            // traduction du panel de droite
            tb_prenom.Text = Traducteur.traduction_[36];
            tb_nom.Text = Traducteur.traduction_[37];
            tb_email.Text = Traducteur.traduction_[38];
            tb_password1.Text = Traducteur.traduction_[35];
            tb_password2.Text = Traducteur.traduction_[35];
            tb_pseudo.Text = Traducteur.traduction_[39];

            cb_choix_langue.Items.Clear();
            cb_choix_langue.Items.Add( Traducteur.traduction_[40] );
            cb_choix_langue.Items.Add( Traducteur.traduction_[40] );
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
