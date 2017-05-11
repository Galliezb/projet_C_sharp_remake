using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp.forms
{
    public partial class Form_Team_Add_Player : Form
    {
        public Form_Team_Add_Player()
        {
            InitializeComponent();
            reloadData();
        }

        private void btSubmit_Click ( object sender , EventArgs e ) {

        }

        private void cb_choisir_equipe_SelectedIndexChanged ( object sender , EventArgs e ) {

            Users listeJoueur = new Users(-1);
            DataSet dataListeJoueur = listeJoueur.getAllUsers();

            Team t = new Team();
            DataSet listTeam = t.getTeamOfTheSession();
            int idTeamSelected = -1;

            foreach ( DataRow rw in listTeam.Tables["userInTeam"].Rows ) {

                if ( cb_choisir_equipe.Text == rw["name"].ToString() ) {
                    idTeamSelected = Convert.ToInt32(rw["idTeam"].ToString());
                    break;
                }

            }

            // recupère les joueurs qui ne sont pas dans la team
            Dictionary<string , int> playerNotInTeam = t.getAllUserNotInTeam( idTeamSelected );

            // recupère les joueurs qui sont dans la team


        }

        private void reloadData () {

            Team t = new Team();
            DataSet listTeam = t.getTeamOfTheSession();

            cb_choisir_equipe.Items.Clear();
            foreach ( DataRow rw in listTeam.Tables["team"].Rows ) {

                cb_choisir_equipe.Items.Add( rw["name"].ToString() );

            }

        }
    }
}
