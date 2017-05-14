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
    public partial class Form_Team_Add_Player : Form {

        int idTeamSelected = -1;
        Dictionary<int , string> playerNotInTeam;
        Dictionary<int , string> playerInTeam;



        public Form_Team_Add_Player () {
            InitializeComponent();
            reloadData();
        }

        private void btSubmit_Click ( object sender , EventArgs e ) {

        }

        private void cb_choisir_equipe_SelectedIndexChanged ( object sender , EventArgs e ) {

            Users listeJoueur = new Users( -1 );
            DataSet dataListeJoueur = listeJoueur.getAllUsers();

            Team t = new Team();
            DataSet listTeam = new DataSet();
            listTeam = t.getTeamOfTheSession();

            if ( listTeam.Tables["team"].Rows.Count > 0 ) {
                foreach ( DataRow rw in listTeam.Tables["team"].Rows ) {

                    if ( cb_choisir_equipe.Text == rw["name"].ToString() ) {
                        idTeamSelected = Convert.ToInt32( rw["idTeam"].ToString() );
                        break;
                    }

                }
            }
            // recupère les joueurs qui ne sont pas dans la team
            playerNotInTeam = t.getAllUserNotInTeam( idTeamSelected );

            // Liste tous les joueurs présent dans la team et les affiches
            playerInTeam = t.getAllUserInTeam( idTeamSelected );


            // vide les listesbox des anciennes datas potentielles
            listbox_joueurs.Items.Clear();
            listbox_joueur_equipe.Items.Clear();

            // affiche tous les joueurs non présent dans la team
            foreach ( string str in playerNotInTeam.Values ) {
                listbox_joueurs.Items.Add( str );
            }
            // affiche tous les joueurs présent dans la team
            foreach ( string str in playerInTeam.Values ) {
                listbox_joueur_equipe.Items.Add( str );
            }

        }

        private void reloadData () {

            Team t = new Team();
            DataSet listTeam = t.getTeamOfTheSession();

            cb_choisir_equipe.Items.Clear();
            foreach ( DataRow rw in listTeam.Tables["team"].Rows ) {

                cb_choisir_equipe.Items.Add( rw["name"].ToString() );

            }

        }

        private void button_ajouter_Click ( object sender , EventArgs e ) {

            if ( idTeamSelected != -1 && listbox_joueurs.SelectedItems.Count > 0 ) {

                // récupère le nom
                string nameTransfert = listbox_joueurs.GetItemText(listbox_joueurs.SelectedItem);

                // supprime le nom de la listebox
                listbox_joueurs.Items.RemoveAt( listbox_joueurs.SelectedIndex );

                // ajoute le nom à l'autre listebox
                listbox_joueur_equipe.Items.Add( nameTransfert );

                // Récupère l'id de l'utilisateur dans le dictionnaire
                int idUserToInsert = -1;
                idUserToInsert = playerNotInTeam.FirstOrDefault( x => x.Value == nameTransfert ).Key;
                if ( idUserToInsert != -1 ) {
                    new Team().addUserInTeam( idTeamSelected , idUserToInsert );
                }

                // transfert l'id et le nom d'un dictionnaire à l'autre
                playerInTeam.Add( idUserToInsert , nameTransfert );
                playerNotInTeam.Remove( idUserToInsert );


            }

        }

        private void button_supprimer_Click ( object sender , EventArgs e ) {

            if ( idTeamSelected != -1 && listbox_joueur_equipe.SelectedItems.Count > 0 ) {

                // récupère le nom
                string nameTransfert = listbox_joueur_equipe.GetItemText( listbox_joueur_equipe.SelectedItem );

                // supprime le nom de la listebox
                listbox_joueur_equipe.Items.RemoveAt( listbox_joueur_equipe.SelectedIndex );

                // ajoute le nom à l'autre listebox
                listbox_joueurs.Items.Add( nameTransfert );

                // Récupère l'id de l'utilisateur dans le dictionnaire
                int idUserToInsert = -1;
                idUserToInsert = playerInTeam.FirstOrDefault( x => x.Value == nameTransfert ).Key;
                if ( idUserToInsert != -1 ) {
                    new Team().delUserInTeam( idTeamSelected , idUserToInsert );
                }

                // transfert l'id et le nom d'un dictionnaire à l'autre
                playerNotInTeam.Add( idUserToInsert , nameTransfert );
                playerInTeam.Remove( idUserToInsert );

            }

        }
    }
}
