using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Skarp {
    class News {

        int idNews_ = -1;
        string auteur_ = "Non défini";
        string titre_ = "Non défini";
        string message_ = "non défini";
        DateTime dateCreation_ = DateTime.Now;
        string language_ = "fr";
        DatabaseConnection maConnexionMysql = new DatabaseConnection();

        public News ()  {
        }

        public int ID {
            get { return idNews_; }
            set { idNews_ = value; }
        }

        public string auteur {
            get { return auteur_; }
            set { auteur_ = value; }
        }

        public string titre {
            get { return titre_; }
            set { titre_ = value; }
        }

        public string message {
            get { return message_; }
            set { message_ = value; }
        }

        public DateTime dateCreation {
            get { return dateCreation_; }
            set { dateCreation_ = value; }
        }

        public string language {
            get { return language_; }
            set { language_ = value; }
        }

        public bool insert () {

            bool result;

            maConnexionMysql.Laconnexion.Open();
            string sqlRequest = "INSERT INTO news SET auteur=@_auteur , titre=@_titre, message=@_message , dateCreation = @_dateCreation , language=@_language";
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_auteur" , Session.pseudo );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_titre" , titre_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_message" , message_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_dateCreation" , dateCreation_.ToString( "yyyy-MM-dd" ) );

            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            // exécute la requête
            maConnexionMysql.Lacommande.ExecuteNonQuery();

            long idReturn = maConnexionMysql.Lacommande.LastInsertedId;

            if ( idReturn > 0 ) {
                result = true;
            } else {
                result = false;
            }

            // clear commande et ferme la connection
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();

            return result;

        }

        public bool delete () {

            if ( idNews_ == -1 ) {
                return false;
            } else {

                string sqlRequest = "DELETE FROM news WHERE idNews=@_idNews";



                maConnexionMysql.Laconnexion.Open();
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idNews" , idNews_ );
                maConnexionMysql.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

                return true;

            }


        }

        public bool update () {

            // si l'idUser est défini alors on update et toutes les données sont correctes
            if ( idNews_ == -1 ) {
                return false;
            } else {

                maConnexionMysql.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE news SET titre=@_titre , message=@_message , dateCreation=@_dateCreation , language=@_language WHERE idNews=@_idNews ";
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_titre" , titre_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_message" , message_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_dateCreation" , dateCreation_.ToString( "yyyy-MM-dd" ) );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idNews" , idNews_ );
                maConnexionMysql.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

                return true;
            }

        }

        public DataSet getAllNews () {


            string request = "SELECT * FROM news";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter( request , maConnexionMysql.Laconnexion );

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            DataSet monDataSet = new DataSet();
            monDataAdapter.Fill( monDataSet , "news" );

            return monDataSet;

        }

        public void update ( DataSet dataSetForUpdate ) {

            string request = "SELECT * FROM news";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter( request , maConnexionMysql.Laconnexion );
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            monDataAdapter.Update( dataSetForUpdate , "news" );

        }



    }
}
