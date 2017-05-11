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
            set {
                if ( value.Length > 50 ) {
                    MessageBox.Show( Traducteur.traduction_[23] );
                } else {
                    name_ = value;
                }
            }
        }


        public int idCaptain {
            get { return idCaptain_; }
            set {
                if ( value < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[24] );
                } else {
                    idCaptain_ = value;
                }
            }
        }


        public int idTeam {
            get { return idTeam_; }
            set {
                if ( value < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[25] );
                } else {
                    idTeam_ = value;
                }
            }
        }


        public string description {
            get { return description_; }
            set {
                if ( value.Length > 255 ) {
                    MessageBox.Show( Traducteur.traduction_[26] );
                } else {

                    description_ = value;

                }
            }
        }


        public DateTime creationDate {

            get { return creationDate_; }
            set {
                if ( DateTime.Compare( value , DateTime.Now ) < 0 ) {
                    MessageBox.Show( Traducteur.traduction_[27] );
                } else {

                    creationDate_ = value;

                }


            }
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
                MessageBox.Show( Traducteur.traduction_[28] );
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
                MessageBox.Show( Traducteur.traduction_[29] );
            }

            // clear commande et ferme la connection
            dbConnect.Lacommande.Parameters.Clear();
            dbConnect.Laconnexion.Close();


        }
        public void delete () {

            if ( idTeam_ < 0 ) {
                MessageBox.Show( Traducteur.traduction_[30] );
            } else {
                dbConnect.Laconnexion.Open();
                // creation requête et ajout à la commande
                string sqlRequest = "DELETE FROM team WHERE idTournament=@_idTeam";

                dbConnect.Lacommande.Parameters.AddWithValue( "@_idTeam" , idTeam_ );
                dbConnect.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                dbConnect.Lacommande.ExecuteNonQuery();

                MessageBox.Show( Traducteur.traduction_[31] );

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

        public void update(DataSet dataSetForUpdate)
        {

            string request = "SELECT * FROM team";
            MySqlDataAdapter monDataAdapter = new MySqlDataAdapter(request, dbConnect.Laconnexion);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(monDataAdapter);

            monDataAdapter.Update(dataSetForUpdate, "team");

        }

    }
}
