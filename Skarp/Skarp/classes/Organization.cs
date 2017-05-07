using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Skarp {
    public class Organisation {

        int idOrganization_;
        string nameOrganization_;
        string nameResponsable_;
        string mailResponsable_;
        DateTime dateCreation_;
        string description_;
        DatabaseConnection dbConnect = new DatabaseConnection();

        /// <summary>
        /// Constructeur Organisation, sans paramètre = non défini et -1 pour les ints
        /// </summary>
        /// <param name="IdOrga">L'ID de l'organisation</param>
        /// <param name="Name">Le nom de l'organisation</param>
        /// <param name="NameResp">Le nom du responsable de l'organisation</param>
        /// <param name="Mail">LKe mail du responsable</param>
        /// <param name="DateCreation">La date de création de l'organisation</param>
        /// <param name="Description">La description de l'organisation</param>
        public Organisation ( int IdOrga = -1 , string Name = "non défini" , string NameResp = "non défini" , string Mail = "non défini" , DateTime DateCreation = new DateTime() , string Description = "non défini" ) {

            idOrganization_ = IdOrga;
            nameOrganization_ = Name;
            nameResponsable_ = NameResp;
            mailResponsable_ = Mail;
            dateCreation_ = DateCreation;
            description_ = Description;


        }
        /// <summary>
        /// Récupère l'ID de l'organisation
        /// </summary>
        public int ID {
            get { return idOrganization_; }
        }
        /// <summary>
        /// Récupère ou modifie le nom de l'organisation
        /// </summary>
        public string Name {
            get { return nameOrganization_; }
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[14] );
                } else {
                    nameOrganization_ = value;

                }
            }
        }



        /// <summary>
        /// Récupère ou modifie le nom du responsable de l'organisation
        /// </summary>
        public string Nameresp {
            get { return nameResponsable_; }
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[15] );
                } else {

                    nameResponsable_ = value;

                }

            }
        }
        /// <summary>
        /// récupère ou modifie le mail du responsable de l'organisation
        /// </summary>
        public string Mail {
            get { return mailResponsable_; }
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[16] );
                } else {

                    mailResponsable_ = value;

                }
            }
        }
        /// <summary>
        /// récupère ou modifie la date de création de l'organisation
        /// </summary>
        public DateTime DateCreation {
            get { return dateCreation_; }
            set {
                if ( DateTime.Compare( value , DateTime.Now ) < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[17] );
                } else {
                    dateCreation_ = value;

                }
            }
        }


        /// <summary>
        /// récupère ou modifie la description de l'organisation
        /// </summary>
        public string Description {
            get { return description_; }
            set {
                if ( value.Length > 255 ) {
                    MessageBox.Show( Traducteur.traduction_[18] );
                } else {

                    mailResponsable_ = value;

                }
            }
        }


        /// <summary>
        /// mets à jours cette organisation en BDD
        /// </summary>
        public void update () {

            if ( idOrganization_ != -1 ) {

                    dbConnect.Laconnexion.Open();
                    string sqlRequest = "UPDATE team SET name= @_idOrganization , 	nameOrganization=@_nameOrganization , description =@_description , NameResponsable = @_NameResponsable , mailResponsable = @_mailResponsable , creatingDate = @_creatingDate;";
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_nameOrganization" , nameOrganization_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_NameResponsable" , nameResponsable_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_mailResponsable" , mailResponsable_ );
                    dbConnect.Lacommande.Parameters.AddWithValue( "@_creatingDate" , dateCreation_.ToString( "yyyy-MM-dd" ) );



                    dbConnect.Lacommande.CommandText = sqlRequest;

                    //éxécution de la requête
                    dbConnect.Lacommande.ExecuteNonQuery();

                    dbConnect.Lacommande.Parameters.Clear();
                    dbConnect.Laconnexion.Close();

                
            } else {
                MessageBox.Show( Traducteur.traduction_[19] );
            }
        }

        /// <summary>
        /// insert cette organisation dans la BDD
        /// </summary>
        public void insert () {

                dbConnect.Laconnexion.Open();
                string sqlRequest = "INSERT INTO team SET name= @_idOrganization , 	nameOrganization=@_nameOrganization , description =@_description , NameResponsable = @_NameResponsable , mailResponsable = @_mailResponsable , creatingDate=@_creatingDate;";
                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_nameOrganization" , nameOrganization_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_description" , description_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_NameResponsable" , nameResponsable_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_mailResponsable" , mailResponsable_ );
                dbConnect.Lacommande.Parameters.AddWithValue( "@_creatingDate" , dateCreation_.ToString( "yyyy-MM-dd" ) );

                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                long idReturn = dbConnect.Lacommande.LastInsertedId;

                if ( idReturn > 0 ) {
                    idOrganization_ = Convert.ToInt32( idReturn );
                } else {
                    MessageBox.Show( Traducteur.traduction_[20] );
                }

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

        }


        /// <summary>
        /// supprime cette organisation de la BDD
        /// </summary>
        public void delete () {

            if ( idOrganization_ < 0 ) {

                MessageBox.Show( Traducteur.traduction_[21] );

            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM team WHERE idOrganization=@_idOrganization";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idOrganization" , idOrganization_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();
                MessageBox.Show( Traducteur.traduction_[22] );

                // clear commande et ferme la connection
                dbConnect.Lacommande.Parameters.Clear();
                dbConnect.Laconnexion.Close();

            }


        }



    }
}
