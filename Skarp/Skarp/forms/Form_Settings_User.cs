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
    public partial class Form_Settings_User : Form {

        Users Player = new Users( -1 );

        public Form_Settings_User () {
            InitializeComponent();

            tb_mail.Text = Session.email;
            tb_nom.Text = Session.name;
            tb_password.Clear();
            tb_password2.Clear();
            tb_prenom.Text = Session.firstname;
            tb_pseudo.Text = Session.pseudo;
            cb_language.SelectedIndex = 0;

        }

        private void btSave_Click ( object sender , EventArgs e ) {

            if ( tb_password.Text.ToString() == tb_password2.Text.ToString() ) {

                Player.ID = Session.ID;
                Player.email = tb_mail.Text.ToString();
                Player.firstName = tb_prenom.Text.ToString();
                Player.name = tb_nom.Text.ToString();
                Player.password = tb_password.Text.ToString();
                Player.pseudo = tb_pseudo.Text.ToString();
                if ( cb_language.SelectedItem.ToString() == Traducteur.traduction_[55] ) {
                    Player.language = "fr";
                } else if ( cb_language.SelectedItem.ToString() == Traducteur.traduction_[56] ) {
                    Player.language = "en";
                }
                Player.isAdmin = Session.isAdmin;
                Player.isOrganizer = Session.isOrganizer;

                Player.update();
                MessageBox.Show( "Informations mises à jours" );

            } else {

                MessageBox.Show( "Mots de passe differents" );

            }
        }
    }
}
