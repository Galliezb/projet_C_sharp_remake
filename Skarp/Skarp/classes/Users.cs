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
    public class Users {
        int IDUser_;
        string name_;
        string firstName_;
        string email_;
        string pass_;
        string pseudo_;
        string language_;
        bool isOrganizer_;
        bool isAdmin_;
        DatabaseConnection maConnexionMysql = new DatabaseConnection();

        /// <summary>
        /// Constructeur d'instance de Player
        /// </summary>
        /// <param name="idUser">L'id de l'utilisateur ( chiffre uniquement )</param>
        /// <param name="name">Le nom de l'utilisateur ( max 50 caractères )</param>
        /// <param name="firstName">le prénom de l'utilisateur ( max 50 caractères )</param>
        /// <param name="email">L'email de l'utilisateur ( max 255 caractères )</param>
        /// <param name="password">le mot de passe non crypté de l'utilisateur ( max 50 caractères )</param>
        /// <param name="pseudo">le pseudonyme de l'utilisateur ( visible par les autres personnes )</param>
        /// <param name="language">La langue par défaut de l'utilisation ( 'fr' ou 'en' uniquement )</param>
        /// <param name="isOrganizer">L'utilisateur est-il Organisateur de tournoi ( booléen uniquement )</param>
        /// <param name="isAdmin">L'utilisateur est-il administrateur du logiciel  ( booléen uniquement )</param>
        public Users ( int idUser = -1 , string name = "non défini" , string firstName = "non défini" , string email = "non défini" , string password = "non défini" , string pseudo = "non défini" , string language = "non défini" , bool isOrganizer = false , bool isAdmin = false ) {

            IDUser_ = idUser;
            name_ = name;
            firstName_ = firstName;
            email_ = email;
            pass_ = password;
            pseudo_ = pseudo;
            language_ = language;
            isOrganizer_ = isOrganizer;
            isAdmin_ = isAdmin;

        }

        /// <summary>
        /// Pour l'identification
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="pseudo"></param>
        /// <param name="language"></param>
        /// <param name="isOrganizer"></param>
        /// <param name="isAdmin"></param>
        public Users ( string pseudo = "non défini" , string password = "non défini" ) {

            IDUser_ = -1;
            name_ = "non défini";
            firstName_ = "non défini";
            email_ = "non défini";
            pass_ = password;
            pseudo_ = pseudo;
            language_ = "fr";
            isOrganizer_ = false;
            isAdmin_ = false;

        }

        /// <summary>
        /// Récupère ou définit l'ID de l'utilisateur ( chiffre > 1 uniquement )
        /// </summary>
        public int ID {
            get { return IDUser_; }
            set {
                if ( value < 1 ) {
                    MessageBox.Show( Traducteur.traduction_[2] );
                } else {
                    IDUser_ = value;
                }
            }
        }


        /// <summary>
        /// récupèrer ou modifier le nom de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string name {
            get { return name_; }
            set {

                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[3] );
                } else {
                    name_ = value;
                }

            }
        }


        /// <summary>
        /// Récupèrer ou modifier le prénom de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string firstName {
            get { return firstName_; }
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[4] );
                } else {
                    firstName_ = value;
                }

            }
        }

        /// <summary>
        /// Récupère ou modifie l'email de l'utlisateur ( max 255 caractères )
        /// </summary>
        public string email {
            get { return email_; }
            set {

                if ( value.Length > 255 ) {
                    MessageBox.Show( Traducteur.traduction_[5] );
                } else {
                    email_ = value;
                }

            }
        }


        /// <summary>
        /// récupère ou modifie le mot de passe non crypté de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string password {
            get { return pass_; }
            set {
                if ( value.Length > 255 ) {
                    MessageBox.Show( Traducteur.traduction_[6] );
                } else {
                    pass_ = value;
                }
            }
        }


        /// <summary>
        /// Récupère ou défini le pseudo de l'utilisateur ( max 50 caractères )
        /// </summary>
        public string pseudo {
            get { return pseudo_; }
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[7] );
                } else {
                    pseudo_ = value;
                }
            }
        }


        /// <summary>
        /// récupère ou défini la langue utilisateur ( 'fr' ou 'en' uniquement )
        /// </summary>
        public string language {
            get { return language_; }
            set {

                if ( value.ToString() == "fr" || value.ToString() == "en" ) {
                    language_ = value;
                } else {

                    MessageBox.Show( Traducteur.traduction_[8] );

                }
            }
        }


        /// <summary>
        /// récupère ou Défini sur l'utilisateur est un organisateur ou non ( booléen )
        /// </summary>
        public bool isOrganizer {
            get { return isOrganizer_; }
            set {
                if ( value == true || value == false ) {
                    isOrganizer_ = value;
                } else {
                    MessageBox.Show( Traducteur.traduction_[9] );
                }
            }
        }


        /// <summary>
        /// Récupère ou défini si l'utilisateur est administrateur ou non ( booléen )
        /// </summary>
        public bool isAdmin {
            get { return isAdmin_; }
            set {
                if ( value == true || value == false ) {
                    isAdmin_ = value;
                } else {
                    MessageBox.Show( Traducteur.traduction_[10] );
                }
            }
        }



        /// <summary>
        /// Mets à jours les informations de l'instance dans la BDD ou insert si nécessaire
        /// </summary>
        public void update () {
            
            // si l'idUser est défini alors on update et toutes les données sont correctes
            if ( IDUser_ != -1 ) {

                maConnexionMysql.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "UPDATE user SET name=@_name , firstName=@_firstName , email=@_email , password = @_pass , pseudo = @_pseudo , language=@_language , isOrganizer=@_isOrganizer , isAdmin = @_isAdmin WHERE idUser = @_idUser ";
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_firstName" , firstName_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_email" , email_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_pass" , pass_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_pseudo" , pseudo_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_isOrganizer" , isOrganizer_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_isAdmin" , isAdmin_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idUser" , IDUser_ );
                maConnexionMysql.Lacommande.CommandText = sqlRequest;


                // mets à jour la session du connecté si c'est lui
                if ( IDUser_ == Session.ID ) {
                    
                    Session.ID = IDUser_;
                    Session.name = name_;
                    Session.firstname = firstName_;
                    Session.email = email_;
                    Session.password = pass_;
                    Session.pseudo = pseudo_;
                    Session.language = language_;
                    Session.isAdmin = isAdmin_;
                    Session.isOrganizer = isOrganizer_;
                }

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

                // sinon on l'insert
            }

        }


        /// <summary>
        /// Insert l'user dans la base de donnée
        /// </summary>
        public void insert () {

            maConnexionMysql.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "INSERT INTO user SET name=@_name , firstName=@_firstName , email=@_email , password = @_pass , pseudo = @_pseudo , language=@_language , isOrganizer=@_isOrganizer , isAdmin = @_isAdmin";
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_name" , name_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_firstName" , firstName_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_email" , email );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_pass" , pass_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_pseudo" , pseudo_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_language" , language_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_isOrganizer" , isOrganizer_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_isAdmin" , isAdmin_ );
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            // exécute la requête
            maConnexionMysql.Lacommande.ExecuteNonQuery();

            // clear commande et ferme la connection
            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();
        }


        /// <summary>
        /// Mets à jours la BDD depuis une liste d'instance PLayerlcass
        /// </summary>
        /// <param name="listPlayer"></param>
        public void update ( List<Users> listPlayer ) {

            if ( listPlayer.Count < 1 ) {
                MessageBox.Show( Traducteur.traduction_[11] ); ;
            } else {

                foreach ( Users player in listPlayer ) {
                    player.update();
                }

            }
        }


        /// <summary>
        /// Supprime l'instance de la BDD ( ID doit être différent de -1 )
        /// </summary>
        public void delete () {

            // si l'id existe on supprime
            if ( IDUser_ != -1 ) {

                maConnexionMysql.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM user WHERE idUser = @_idUser ";

                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idUser" , IDUser_ );
                maConnexionMysql.Lacommande.CommandText = sqlRequest;


                // mets à jour la session du connecté si c'est lui
                if ( IDUser_ == Session.ID ) {
                    Session.clear();
                }

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

                // sinon on préviens de l'erreur
            } else {
                MessageBox.Show( Traducteur.traduction_[12] );
            }

        }


        /// <summary>
        ///  Supprime de la BDD depuis une liste d'instance de Users
        /// </summary>
        /// <param name="listPlayer"></param>
        public void delete ( List<Users> listPlayer ) {

            if ( listPlayer.Count < 1 ) {
                MessageBox.Show( Traducteur.traduction_[13] );
            } else {

                string sqlRequest = "DELETE FROM user WHERE idUser IN(";

                foreach ( Users player in listPlayer ) {

                    if ( player.ID != -1 ) {
                        sqlRequest += player.ID + ",";
                    }

                }
                // valeur final attentdu => DELETE FROM user WHERE idUser IN (13,14,15,16)
                sqlRequest = sqlRequest.Substring( 0 , sqlRequest.Length - 1 ) + ")";


                maConnexionMysql.Laconnexion.Open();
                maConnexionMysql.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();


            }


        }

        /// <summary>
        /// demande à la BDD de retourner tous les users dans le dataset
        /// </summary>
        /// <returns>récupère le dataset avec toutes les informations en bases de donnée user</returns>
        public DataSet getAllUsers () {

            
            string request = "SELECT * FROM user";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter(request,maConnexionMysql.Laconnexion);

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            DataSet monDataSet = new DataSet();
            monDataAdapter.Fill( monDataSet , "user" );

            return monDataSet;

        }

        /// <summary>
        /// Mettre à jour la table user, depuis le dataset pour le datagrid
        /// </summary>
        /// <param name="dataSetForUpdate"></param>
        public void update ( DataSet dataSetForUpdate ) {

            string request = "SELECT * FROM user";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter( request, maConnexionMysql.Laconnexion );
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            monDataAdapter.Update(dataSetForUpdate,"user");

        }

        public bool identification () {

            bool result;

            maConnexionMysql.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM user where pseudo = @_pseudo && password =@_password ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_pseudo" , pseudo_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_password" , pass_ );
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            
            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();

            // y'a une ligne go dans session sinon fail
            if ( monReaderMysql.HasRows ) {

                // lire la ligen retournée
                monReaderMysql.Read();

                // update session
                Session.ID = Convert.ToInt32(monReaderMysql["idUser"]) ;
                Session.name = monReaderMysql["name"].ToString();
                Session.firstname = monReaderMysql["firstname"].ToString();
                Session.email = monReaderMysql["email"].ToString();
                Session.password = monReaderMysql["password"].ToString();
                Session.pseudo = monReaderMysql["pseudo"].ToString();
                Session.language = monReaderMysql["language"].ToString();
                Session.isAdmin = Convert.ToBoolean( monReaderMysql["idUser"] ); ;
                Session.isOrganizer = Convert.ToBoolean( monReaderMysql["idUser"] ); ;

                // on préviens qu'on a su trouver un joueur avec ce mot de passe
                result = true;

            } else {
                result = false;
            }

            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();

            return result;

        }

    }
}
