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

        private void testToolStripMenuItem_Click ( object sender , EventArgs e ) {
            
            closeAll();
            affichage = new forms.Form_Administration();
            affichage.MdiParent = this;
            affichage.Location = new Point( 0 , 0 );
            affichage.Show();
            
        }

        private void test2ToolStripMenuItem_Click ( object sender , EventArgs e ) {
            
            closeAll();
            affichage = new forms.Form_Settings_User();
            displayForm( affichage );
            
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

        private void displayForm ( Form fefe ) {

            fefe.MdiParent = this;
            fefe.StartPosition = FormStartPosition.Manual;
            fefe.WindowState = FormWindowState.Maximized;
            fefe.Location = new Point( 0 , 0 );
            fefe.Size = new Size( 800 , 628 );
            fefe.FormBorderStyle = FormBorderStyle.None;
            fefe.BackColor = Color.Black;
            fefe.ForeColor = Color.White;
            fefe.Font = new Font( "Century Schoolbook" , 12 );
            fefe.ShowIcon = false;
            fefe.Show();

        }
    }
}
