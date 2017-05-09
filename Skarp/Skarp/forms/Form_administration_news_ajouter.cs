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
    public partial class Form_administration_news_ajouter : Form {
        public Form_administration_news_ajouter () {
            InitializeComponent();

            cb_language.SelectedIndex = 0;

        }

        private void button_sauvegarder_Click ( object sender , EventArgs e ) {

            News newsToInsert = new News();

            newsToInsert.auteur = Session.pseudo;
            newsToInsert.titre = tb_titre.Text;
            newsToInsert.message = tb_message.Text;
            newsToInsert.dateCreation = DateTime.Now;
            newsToInsert.language = cb_language.Text;

            tb_titre.Clear();
            tb_message.Clear();
            cb_language.SelectedIndex = 0;

            if ( newsToInsert.insert() ) {
                MessageBox.Show( Traducteur.traduction_[62] );
            } else {
                MessageBox.Show( Traducteur.traduction_[63] );
            }

        }
    }
}
