using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Skarp {
    public class Organisation {

        int idOrganization_;
        string nameOrganization_;
        int idOrganizer_;
        string mailResponsable_;
        DateTime dateCreation_;
        string description_;
        DatabaseConnection maConnexionMysql = new DatabaseConnection();

        /// <summary>
        /// Constructeur Organisation, sans paramètre = non défini et -1 pour les ints
        /// </summary>
        /// <param name="IdOrga">L'ID de l'organisation</param>
        /// <param name="Name">Le nom de l'organisation</param>
        /// <param name="NameResp">Le nom du responsable de l'organisation</param>
        /// <param name="Mail">LKe mail du responsable</param>
        /// <param name="DateCreation">La date de création de l'organisation</param>
        /// <param name="Description">La description de l'organisation</param>
        public Organisation ( int IdOrga = -1 , string Name = "non défini" , int idOrganizer = -1 , string Mail = "non défini" , DateTime DateCreation = new DateTime() , string Description = "non défini" ) {

            idOrganization_ = IdOrga;
            nameOrganization_ = Name;
            idOrganizer_ = idOrganizer;
            mailResponsable_ = Mail;
            dateCreation_ = DateCreation;
            description_ = Description;


        }
        /// <summary>
        /// Récupère l'ID de l'organisation
        /// </summary>
        public int ID {
            get { return idOrganization_; }
            set { idOrganization_ = value; }
        }
        /// <summary>
        /// Récupère ou modifie le nom de l'organisation
        /// </summary>
        public string Name {
            get { return nameOrganization_; }
            set { nameOrganization_ = value; }
        }



        /// <summary>
        /// Récupère ou modifie le nom du responsable de l'organisation
        /// </summary>
        public int idOrganizer {
            get { return idOrganizer_; }
            set { idOrganizer_ = value; }
        }
        /// <summary>
        /// récupère ou modifie le mail du responsable de l'organisation
        /// </summary>
        public string Mail {
            get { return mailResponsable_; }
            set {mailResponsable_ = value;
            }
        }
        /// <summary>
        /// récupère ou modifie la date de création de l'organisation
        /// </summary>
        public DateTime DateCreation {
            get { return dateCreation_; }
            set {dateCreation_ = value;}
        }


        /// <summary>
        /// récupère ou modifie la description de l'organisation
        /// </summary>
        public string Description {
            get { return description_; }
            set {mailResponsable_ = value;}
        }


        /// <summary>
        /// mets à jours cette organisation en BDD
        /// </summary>
        public void update () {

            if ( idOrganization_ != -1 ) {

                    maConnexionMysql.Laconnexion.Open();
                    string sqlRequest = "UPDATE organization SET nameOrganization= @_nameOrganization , description =@_description, idOrganizer=@_idOrganizer , mailResponsable = @_mailResponsable , creatingDate = @_creatingDate WHERE idOrganization=@_idOrganization;";
                    maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                    maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_nameOrganization" , nameOrganization_ );
                    maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                    maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                    maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_mailResponsable" , mailResponsable_ );
                    maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_creatingDate" , dateCreation_.ToString( "yyyy-MM-dd" ) );



                    maConnexionMysql.Lacommande.CommandText = sqlRequest;

                    //éxécution de la requête
                    maConnexionMysql.Lacommande.ExecuteNonQuery();

                    maConnexionMysql.Lacommande.Parameters.Clear();
                    maConnexionMysql.Laconnexion.Close();

                
            } else {
                MessageBox.Show( Traducteur.traduction_[2] );
            }
        }

        /// <summary>
        /// insert cette organisation dans la BDD
        /// </summary>
        public void insert () {

                maConnexionMysql.Laconnexion.Open();
                string sqlRequest = "INSERT INTO organization SET nameOrganization=@_nameOrganization , description =@_description , idOrganizer = @_idOrganizer , mailResponsable = @_mailResponsable , creatingDate=@_creatingDate;";
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_nameOrganization" , nameOrganization_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idOrganizer" , idOrganizer_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_mailResponsable" , mailResponsable_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_creatingDate" , dateCreation_.ToString( "yyyy-MM-dd" ) );

                maConnexionMysql.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();

                long idReturn = maConnexionMysql.Lacommande.LastInsertedId;

                if ( idReturn > 0 ) {
                    idOrganization_ = Convert.ToInt32( idReturn );
                } else {
                    MessageBox.Show( Traducteur.traduction_[3] );
                }

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

        }


        /// <summary>
        /// supprime cette organisation de la BDD
        /// </summary>
        public void delete () {

            if ( idOrganization_ < 0 ) {

                MessageBox.Show( Traducteur.traduction_[1] );

            } else {
                maConnexionMysql.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM organization WHERE idOrganization=@_idOrganization";

                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                maConnexionMysql.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();
                MessageBox.Show( Traducteur.traduction_[4] );

                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

            }


        }

        public DataSet getAllInfo() {


            string request = "SELECT * FROM organization WHERE idOrganizer="+Session.ID;
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter( request , maConnexionMysql.Laconnexion );

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            DataSet monDataSet = new DataSet();
            monDataAdapter.Fill( monDataSet , "organization" );

            return monDataSet;

        }

        public void update ( DataSet dataSetForUpdate ) {

            string request = "SELECT org.*,user.pseudo FROM organization as org LEFT JOIN user ON user.idUser=org.idOrganizer WHERE idOrganizer=" + Session.ID;
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter( request , maConnexionMysql.Laconnexion );
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder( monDataAdapter );

            monDataAdapter.Update( dataSetForUpdate , "organization" );

        }



    }
}
