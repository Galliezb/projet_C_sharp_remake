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
            tb_password.Text = Session.password;
            tb_password2.Text = Session.password;
            tb_prenom.Text = Session.firstname;
            tb_pseudo.Text = Session.pseudo;
            cb_language.SelectedIndex = 0;

        }

        private void btSave_Click ( object sender , EventArgs e )     // lorsqu'on appuie sur le bouton SAVE on met a jour les données de l utilisateur dans la base de données.
        {
            if ( tb_password.Text.ToString() == tb_password2.Text.ToString() ) {
                Player.email = tb_mail.Text.ToString();
                Player.firstName = tb_prenom.Text.ToString();
                Player.name = tb_nom.Text.ToString();
                Player.password = tb_password.Text.ToString();
                Player.pseudo = tb_pseudo.Text.ToString();

                // databaseRequest.updateInfo(Player);
                Player.update();

                //lbNom
                this.ParentForm.Controls["PanelTop"].Controls["lbNom"].Text = Player.name;

                //MessageBox.Show( traduction.display( 2002 ) );

            } else {

                MessageBox.Show( "Mots de passe differents" );

            }
        }
    }
}
