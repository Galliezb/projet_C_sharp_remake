using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
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
        string jeu_;


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
            set { idTournament_ = value; }

        }

        public int idOrganizer {

            get { return idOrganizer_; }
            set { idOrganizer_ = value; }

        }

        public string name {
            get { return this.name_; }
            set {name_ = value;}
         }

        public string Description {
            get { return this.description_; }
            set {description_ = value;}
         }

        public DateTime startDate {
            get { return startDate_; }
            set {startDate_ = value;}
        }

        public DateTime endDate {
            get { return endDate_; }
            set { endDate_ = value;}
        }

        public string typeTournoi {
            get { return type_;  }
            set { type_ = value; }
        }

        public int maxPlayer {
            get { return maxPlayer_; }
            set { maxPlayer_ = value;}
            
        }
        public string jeu
        {
            get { return jeu_; }
            set { jeu_ = value; }
        }

        public void update () {

            if ( idTournament_ != -1 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer, jeu=@_jeu WHERE idTournament = @_idTournament ";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                // format date requis pour la BDD : YYYY-MM-JJ
                dbConnect.Lacommande.Parameters.AddWithValue( "@startDate" , startDate_.ToString( "yyyy-MM-dd" ) );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_endDate" , endDate_.ToString( "yyyy-MM-dd" ) );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_type" , type_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_maxPlayer" , maxPlayer_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_jeu" , jeu_ );

                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            } else {
                MessageBox.Show( Traducteur.traduction_[3] );
            }

        }


        public void insert () {

            dbConnect.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "INSERT INTO tournament SET idOrganizer=@_idOrganizer , name=@_name , description=@_description , startDate = @_startDate , endDate = @_endDate , type=@_type , maxPlayer=@_maxPlayer, jeu=@_jeu";
            dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_startDate" , startDate_.ToString("yyyy-MM-dd"));
            dbConnect.Lacommande.Parameters.AddWithValue( "@_endDate" , endDate_.ToString("yyyy-MM-dd"));
            dbConnect.Lacommande.Parameters.AddWithValue( "@_type" , type_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_maxPlayer" , maxPlayer_ );
            dbConnect.Lacommande.Parameters.AddWithValue("@_jeu", jeu_);


            dbConnect.Lacommande.CommandText = sqlRequest;

            // exécute la requête
            dbConnect.Lacommande.ExecuteNonQuery();

            long idReturn = dbConnect.Lacommande.LastInsertedId;

            if ( idReturn > 0 ) {
                idTournament_ = Convert.ToInt32( idReturn );
            } else {
                MessageBox.Show( Traducteur.traduction_[3] );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();

        }

        public void delete( ) {

            if ( idTournament_ < 0 ) {
                MessageBox.Show( Traducteur.traduction_[1] );
            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM tournament WHERE idTournament=@_idTournament";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();
                MessageBox.Show( Traducteur.traduction_[4] );

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }


        }

        public DataSet getTournamentOfTheSession()
        {


            string request = "SELECT * FROM tournament WHERE idOrganizer =  " + Session.ID;

            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter(request, dbConnect.Laconnexion);

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(monDataAdapter);

            DataSet monDataSet = new DataSet();
            monDataAdapter.Fill(monDataSet, "tournament");

            return monDataSet;

        }

        public void update(DataSet dataSetForUpdate)
        {

            string request = "SELECT * FROM tournament";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter(request, dbConnect.Laconnexion);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(monDataAdapter);

            monDataAdapter.Update(dataSetForUpdate, "tournament");

        }



    }
}
