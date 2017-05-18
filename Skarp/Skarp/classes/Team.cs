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
    public class Team {
        int idTeam_;
        string name_;
        DateTime creationDate_;
        
        int idCaptain_;
        DatabaseConnection dbConnect = new DatabaseConnection();
        string description_;

        public Team ( int idTeam = -1 , string name = "non défini" , string description = "" ) {
            idTeam_ = idTeam;
            creationDate_ = DateTime.Now;
            name_ = name;
            description_ = description;

        }
        public Team ( Team team ) {
            idTeam_ = team.idTeam_;
            name_ = team.name_;
            creationDate_ = team.creationDate_;
            description_ = team.description_;
        }


        public string name {
            get { return name_; }
            set {name_ = value;}
        }


        public int idCaptain {
            get { return idCaptain_; }
            set {idCaptain_ = value;}
        }


        public int idTeam {
            get { return idTeam_; }
            set {idTeam_ = value;}
        }


        public string description {
            get { return description_; }
            set { description_ = value;}
        }


        public DateTime creationDate {

            get { return creationDate_; }
            set {creationDate_ = value;}
        }

        public void update () {
            if ( idTeam_ != -1 ) {
                dbConnect.Laconnexion.Open();
                string sqlRequest = "UPDATE team SET idTeam= @_idTeam , name= @_name , description=@_description , captain =@_captain , dateCreation = @_dateCreation;";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_captain" , idCaptain_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_dateCreation" , creationDate_.ToString( "yyyy-MM-dd" ) );



                dbConnect.Lacommande.CommandText = sqlRequest;

                //éxécution de la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();
            } else {
                MessageBox.Show( Traducteur.traduction_[5] );
            }
        }

        public void insert () {

            dbConnect.Laconnexion.Open();
            string sqlRequest = "INSERT INTO team SET name= @_name , description=@_description , captain =@_captain , dateCreation = @_dateCreation;";
            dbConnect.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_captain" , idCaptain_ );
            dbConnect.Lacommande.Parameters.AddWithValue( "@_dateCreation" , creationDate_.ToString( "yyyy-MM-dd" ) );

            dbConnect.Lacommande.CommandText = sqlRequest;

            // exécute la requête
            dbConnect.Lacommande.ExecuteNonQuery();
            

            long idReturn = dbConnect.Lacommande.LastInsertedId;

            if ( idReturn > 0 ) {

                idTeam_ = Convert.ToInt32( idReturn );

            } else {
                MessageBox.Show( Traducteur.traduction_[3] );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();


        }
        public void delete () {

            if ( idTeam_ < 0 ) {
                MessageBox.Show( Traducteur.traduction_[1] );
            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM team WHERE idTournament=@_idTeam";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                MessageBox.Show( Traducteur.traduction_[5] );

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }


        }

        /// <summary>
        /// Permet de récupérer une dataset contenant toutes les informations des team correspondant a l'ID connecté
        /// </summary>
        /// <returns></returns>
        public DataSet getTeamOfTheSession()
        {


            string request = "SELECT * FROM team WHERE captain =  " + Session.ID ;

            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter(request, dbConnect.Laconnexion);
  
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(monDataAdapter);
            
            DataSet monDataSet = new DataSet();
            monDataAdapter.Fill(monDataSet, "team");

            return monDataSet;

        }

        public DataSet getAllTeam () {


            string request = "SELECT * FROM team";

            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter( request , dbConnect.Laconnexion );

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            DataSet monDataSet = new DataSet();
            monDataAdapter.Fill( monDataSet , "team" );

            return monDataSet;

        }

        public void update(DataSet dataSetForUpdate)
        {

            string request = "SELECT * FROM team";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter(request, dbConnect.Laconnexion);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(monDataAdapter);

            monDataAdapter.Update(dataSetForUpdate, "team");

        }

        public Dictionary<int , string> getAllUserInTeam ( int idTeam ) {

            dbConnect.Laconnexion.Open();
            // creation requête et ajout à la commande                       gauche              DROIT
            string sqlRequest = "SELECT user.pseudo, userInTeam.idUser FROM userInTeam LEFT JOIN user ON user.idUser=userInTeam.idUser WHERE userInTeam.idTeam=@_idTeam";
            // Bruno du passé, merci d'éviter les requêtes tordues basé sur des concepts du LEFT JOIN quand un IN simple suffit, merci !
            // celle-ci aurait été tellement plus simple et compréhensible ! Dommage... Je t'ai connu meilleur
            ///string sqlRequest = "SELECT pseudo, idUser FROM user WHERE idUser IN (SELECT idUser FROM userInTeam WHERE idTeam=" + idTeam + ")";

            dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam );
            dbConnect.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = dbConnect.Lacommande.ExecuteReader();

            Dictionary<int , string> dictonnary = new Dictionary<int , string>();

            while ( monReaderMysql.Read() ) {
                dictonnary.Add( Convert.ToInt32( monReaderMysql["idUser"].ToString() ) , monReaderMysql["pseudo"].ToString() );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();

            return dictonnary;

        }

        public Dictionary<int,string> getAllUserNotInTeam ( int idTeam ) {

            dbConnect.Laconnexion.Open();
            // creation requête et ajout à la commande                                (15,24)
            string sqlRequest = "SELECT pseudo, idUser FROM user WHERE idUser NOT IN (SELECT idUser FROM userInTeam WHERE idTeam="+idTeam+")";
            dbConnect.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = dbConnect.Lacommande.ExecuteReader();

            Dictionary<int , string> dictonnary = new Dictionary<int , string>();

            while ( monReaderMysql.Read() ) {
                dictonnary.Add( Convert.ToInt32( monReaderMysql["idUser"].ToString()), monReaderMysql["pseudo"].ToString() );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();

            return dictonnary;

        }


        public bool addUserInTeam ( int idTeam, int idUser ) {

            if ( idTeam > 0 && idUser > 0 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "INSERT INTO userInTeam SET idUser=@_idUser,idTeam=@_idTeam";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idUser" , idUser );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

                return true;

            } else {
                return false;
            }

        }
        public bool delUserInTeam ( int idTeam , int idUser ) {

            if ( idTeam > 0 && idUser > 0 ) {

                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM userInTeam WHERE idUser=@_idUser && idTeam=@_idTeam";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idUser" , idUser );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

                return true;

            } else {
                return false;
            }

        }

    }
}
