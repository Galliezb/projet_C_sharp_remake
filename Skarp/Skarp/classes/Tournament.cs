using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp {
    class Tournament {

        int idTournament_;
        int idOrganizer_;
        string name_;
        string description_;
        DateTime startDate_;
        DateTime endDate_;
        string type_;
        int maxPlayer_;
        DatabaseConnection dbConnect = new DatabaseConnection();


        public Tournament () { }

        public Tournament ( int idTournament = -1, int idOrganizer = -1, string name ="indéfini", string description="indéfini", DateTime startDate = new DateTime(), DateTime endDate = new DateTime() , string type ="indéfini", int maxPlayer = -1) {

            idTournament_ = idTournament;
            idOrganizer_ = idOrganizer;
            name_ = name;
            description_ = description;
            startDate_ = startDate;
            endDate_ = endDate;
            type_ = type;
            maxPlayer_ = maxPlayer;

        }

        public Tournament ( Tournament tournoi ) {

            idTournament_ = tournoi.idTournament;
            idOrganizer_ = tournoi.idOrganizer;
            name_ = tournoi.name;
            description_ = tournoi.Description;
            startDate_ = tournoi.startDate;
            endDate_ = tournoi.endDate;
            type_ = tournoi.typeTournoi;
            maxPlayer_ = maxPlayer;

        }

        public int idTournament {

            get { return idTournament_; }

        }

        public int idOrganizer {

            get { return idOrganizer_; }

        }

        public string name {
            get { return this.name_; }
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[32] );
                } else {
                    name_ = value;
                }

            }
        }

        public string Description {
            get { return this.description_; }
            set {
                if ( value.Length < 10 ) {
                    MessageBox.Show( Traducteur.traduction_[33] );
                } else {
                    description_ = value;
                }
                
            }
        }

        public DateTime startDate {
            get { return startDate_; }
            set {
                if ( DateTime.Compare(value,DateTime.Now) < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[34] );
                } else {
                    startDate_ = value;
                }
                
            }
        }

        public DateTime endDate {
            get { return endDate_; }
            set {
                if ( DateTime.Compare( startDate_ , DateTime.Now ) < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[35] );
                } else if ( DateTime.Compare( value , startDate_.AddDays(3) ) < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[36] );
                } else {
                    endDate_ = value;
                }
            }
        }

        public string typeTournoi {
            get { return type_;  }
            set {
                // All - play - all
                //Deathmatch
                //Pool phase
                //comboBoxType.Items.Add( "Championnat toute ronde" );
                //comboBoxType.Items.Add( "Elimination directe" );
                //comboBoxType.Items.Add( "Phase de groupe" );
                

                if ( value == Traducteur.traduction_[37] ||
                     value == Traducteur.traduction_[38] ||
                     value == Traducteur.traduction_[39]
                    ) {

                    type_ = value;

                } else {
                    MessageBox.Show( Traducteur.traduction_[40] );
                }
            }
        }

        public int maxPlayer {
            get { return maxPlayer_; }
            set {
                if ( value < 12 ) {
                    MessageBox.Show( Traducteur.traduction_[41] );
                } else {
                    maxPlayer_ = value;
                }
            }
        }

        public void update () {

            if ( idTournament_ != -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer WHERE idTournament = @_idTournament ";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                // format date requis pour la BDD : YYYY-MM-JJ
                dbConnect.Lacommande.Parameters.AddWithValue( "@startDate" , startDate_.ToString( "yyyy-MM-dd" ) );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_endDate" , endDate_.ToString( "yyyy-MM-dd" ) );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_type" , type_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_maxPlayer" , maxPlayer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );

                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            } else {
                MessageBox.Show( Traducteur.traduction_[42] );
            }

        }


        public void insert () {

            dbConnect.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "INSERT INTO tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer";
            dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@startDate" , startDate_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_endDate" , endDate_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_type" , type_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_maxPlayer" , maxPlayer_ );

            dbConnect.Lacommande.CommandText = sqlRequest;

            // exécute la requête
            dbConnect.Lacommande.ExecuteNonQuery();

            long idReturn = dbConnect.Lacommande.LastInsertedId;

            if ( idReturn > 0 ) {
                idTournament_ = Convert.ToInt32( idReturn );
            } else {
                MessageBox.Show( Traducteur.traduction_[43] );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();

        }

        public void delete( ) {

            if ( idTournament_ < 0 ) {
                MessageBox.Show( Traducteur.traduction_[44] );
            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM tournament WHERE idTournament=@_idTournament";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();
                MessageBox.Show( Traducteur.traduction_[45] );

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }


        }

    }
}
