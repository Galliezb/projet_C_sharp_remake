using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Skarp {
    class Arbo {

        int idTournament_ = -1;
        string r1t1_, r1t2_, r1t3_, r1t4_, r1t5_, r1t6_, r1t7_, r1t8_, r2t1_, r2t2_, r2t3_, r2t4_, r3t1_, r3t2_, vainqueur_;
        DatabaseConnection maConnexionMysql = new DatabaseConnection();


        public Arbo () {}

        public string R1T1 {
            get { return r1t1_; }
            set { r1t1_ = value; }
        }
        public string R1T2 {
            get { return r1t2_; }
            set { r1t2_ = value; }
        }
        public string R1T3 {
            get { return r1t3_; }
            set { r1t3_ = value; }
        }
        public string R1T4 {
            get { return r1t4_; }
            set { r1t4_ = value; }
        }
        public string R1T5 {
            get { return r1t5_; }
            set { r1t5_ = value; }
        }

        public string R1T6 {
            get { return r1t6_; }
            set { r1t6_ = value; }
        }
        public string R1T7 {
            get { return r1t7_; }
            set { r1t7_ = value; }
        }
        public string R1T8 {
            get { return r1t8_; }
            set { r1t8_ = value; }
        }
        public string R2T1 {
            get { return r2t1_; }
            set { r2t1_ = value; }
        }
        public string R2T2 {
            get { return r2t2_; }
            set { r2t2_ = value; }
        }
        public string R2T3 {
            get { return r2t3_; }
            set { r2t3_ = value; }
        }
        public string R2T4 {
            get { return r2t4_; }
            set { r2t4_ = value; }
        }

        public string R3T1 {
            get { return r3t1_; }
            set { r3t1_ = value; }
        }
        public string R3T2 {
            get { return r3t2_; }
            set { r3t2_ = value; }
        }
        public string vainqueur {
            get { return vainqueur_; }
            set { vainqueur_ = value; }
        }

        public int IDtournament {
            get { return idTournament_; }
            set { idTournament_ = value; }
        }

        public bool insert () {

            bool result;

            maConnexionMysql.Laconnexion.Open();
            string sqlRequest = "INSERT INTO arbo SET idTournament=@_idTournament,r1t1=@_r1t1,r1t2=@_r1t2,r1t3=@_r1t3,r1t4=@_r1t4,r1t5=@_r1t5,r1t6=@_r1t6,r1t7=@_r1t7,r1t8=@_r1t8,r2t1=@_r2t1,r2t2=@_r2t2,r2t3=@_r2t3,r2t4=@_r2t4,r3t1=@_r3t1,r3t2=@_r3t2,vainqueur=@_vainqueur";
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t1" , r1t1_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t2" , r1t2_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t3" , r1t3_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t4" , r1t4_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t5" , r1t5_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t6" , r1t6_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t7" , r1t7_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t8" , r1t8_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t1" , r2t1_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t2" , r2t2_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t3" , r2t3_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t4" , r2t4_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r3t1" , r3t1_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r3t2" , r3t2_ );
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_vainqueur" , vainqueur_ );

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

            if ( idTournament_ == -1 ) {
                return false;
            } else {

                string sqlRequest = "DELETE FROM arbo WHERE idTournament=@_idTournament";



                maConnexionMysql.Laconnexion.Open();
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
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

            // si l'idUser est défini alors on update
            if ( idTournament_ == -1 ) {
                return false;
            } else {

                maConnexionMysql.Laconnexion.Open();
                string sqlRequest = "UPDATE arbo SET r1t1=@_r1t1,r1t2=@_r1t2,r1t3=@_r1t3,r1t4=@_r1t4,r1t5=@_r1t5,r1t6=@_r1t6,r1t7=@_r1t7,r1t8=@_r1t8,r2t1=@_r2t1,r2t2=@_r2t2,r2t3=@_r2t3,r2t4=@_r2t4,r3t1=@_r3t1,r3t2=@_r3t2,vainqueur=@_vainqueur WHERE idTournament=@_idTournament";
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t1" , r1t1_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t2" , r1t2_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t3" , r1t3_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t4" , r1t4_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t5" , r1t5_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t6" , r1t6_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t7" , r1t7_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r1t8" , r1t8_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t1" , r2t1_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t2" , r2t2_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t3" , r2t3_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r2t4" , r2t4_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r3t1" , r3t1_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_r3t2" , r3t2_ );
                maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_vainqueur" , vainqueur_ );

                maConnexionMysql.Lacommande.CommandText = sqlRequest;

                // exécute la requête
                maConnexionMysql.Lacommande.ExecuteNonQuery();
                
                // clear commande et ferme la connection
                maConnexionMysql.Lacommande.Parameters.Clear();
                maConnexionMysql.Laconnexion.Close();

                return true;
            }

        }

        public List<string> getRow(int idTournament ) {

            List<string> result = new List<string>();
            maConnexionMysql.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM arbo WHERE idTournament=@_idTournament LIMIT 1";
            maConnexionMysql.Lacommande.Parameters.AddWithValue( "@_idTournament" , idTournament );
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();

            // y'a une ligne go dans session sinon fail
            if ( monReaderMysql.HasRows ) {

                // lire la ligen retournée
                monReaderMysql.Read();

                result.Add( monReaderMysql["r1t1"].ToString() );
                result.Add( monReaderMysql["r1t2"].ToString() );
                result.Add( monReaderMysql["r1t3"].ToString() );
                result.Add( monReaderMysql["r1t4"].ToString() );
                result.Add( monReaderMysql["r1t5"].ToString() );
                result.Add( monReaderMysql["r1t6"].ToString() );
                result.Add( monReaderMysql["r1t7"].ToString() );
                result.Add( monReaderMysql["r1t8"].ToString() );
                result.Add( monReaderMysql["r2t1"].ToString() );
                result.Add( monReaderMysql["r2t2"].ToString() );
                result.Add( monReaderMysql["r2t3"].ToString() );
                result.Add( monReaderMysql["r2t4"].ToString() );
                result.Add( monReaderMysql["r3t1"].ToString() );
                result.Add( monReaderMysql["r3t2"].ToString() );
                result.Add( monReaderMysql["vainqueur"].ToString() );


            }

            maConnexionMysql.Lacommande.Parameters.Clear();
            maConnexionMysql.Laconnexion.Close();

            return result;



        }


    }
}
