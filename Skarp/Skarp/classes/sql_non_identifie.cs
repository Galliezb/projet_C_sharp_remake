using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Skarp {
    class Sql_non_identifie
    {

        DataSet ds = new DataSet();
        //int Identifianttotaux = 2;
        DatabaseConnection maConnexionMysql;
        //MySqlDataAdapter maConnexionAdapteur;//=new MySqlDataAdapter();

        public Sql_non_identifie()
        {

            maConnexionMysql = new DatabaseConnection();

        }

        /*
         
         EXEMPLE DE LECTURE DE TOUS LES CHAMPS ET TOUTES LES LIGNES D'UNE BDD

        public void test()
        {

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM user";
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read()) {


                MessageBox.Show("id : " + monReaderMysql.GetInt32(0).ToString());
                MessageBox.Show("Name : " + monReaderMysql.GetString(1).ToString());
                MessageBox.Show("firstName : " + monReaderMysql.GetString(2).ToString());
                MessageBox.Show("Email : " + monReaderMysql.GetString(3).ToString());
                MessageBox.Show("PWD : " + monReaderMysql.GetString(4).ToString());
            }

            maConnexionMysql.Laconnexion.Close();

        }
        */

        public string test2(string namedd,string ValueType)
        {

            maConnexionMysql.Laconnexion.Open();
            // creation requête et ajout à la commande
            string sqlRequest = "SELECT * FROM user";
            //maConnexionMysql.Lacommande.Parameters.AddWithValue("@namedd", namedd);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            string result;
            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();

            while (monReaderMysql.Read())
            {

               /*MessageBox.Show("id : " + monReaderMysql.GetInt32(0).ToString());
                MessageBox.Show("Name : " + monReaderMysql.GetString(1).ToString());
                MessageBox.Show("firstName : " + monReaderMysql.GetString(2).ToString());
                MessageBox.Show("Email : " + monReaderMysql.GetString(3).ToString());
                MessageBox.Show("PWD : " + monReaderMysql.GetString(4).ToString());*/
                if ( ValueType == "password")
                {
                    if (monReaderMysql.GetString(1).ToString() == namedd)
                    {
                        
                        result=monReaderMysql.GetString(4).ToString();
                        maConnexionMysql.Laconnexion.Close();
                        return result;
                    }
                }

            }
            maConnexionMysql.Laconnexion.Close();
            MessageBox.Show( "Identifiants incorrects" );
            return "NONE";



        }

        public void majBDD()
        {

        }
        public void ajoutCompte(string name, string pass)
        {

            maConnexionMysql.Laconnexion.Open();
           
            maConnexionMysql.Lacommande.CommandText = "INSERT INTO user (name,password) VALUES (@name,@pass );";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@name", name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@pass", pass);
            maConnexionMysql.Lacommande.ExecuteNonQuery();
            
            maConnexionMysql.Laconnexion.Close();
        }

        public string getMailUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            //string sqlRequest = "SELECT email FROM user where name = @nameuser; ";
            string sqlRequest = "SELECT email FROM user where name = @nameusermail; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameusermail", name);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read())
            {
                string result = monReaderMysql["email"].ToString();
                maConnexionMysql.Laconnexion.Close();
                return result;
               
            }
            
                maConnexionMysql.Laconnexion.Close();
                return "NONE";
          
            
        }

        public string getFirstnameUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT firstName FROM user where name = @nameuserfn; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuserfn", name);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read())
            {
                string result = monReaderMysql["firstName"].ToString();
                maConnexionMysql.Laconnexion.Close();
                return result;

            }
            
                maConnexionMysql.Laconnexion.Close();
                return "NONE";
            
            
        }

        public string getPWDUser(string name)
        {
            //string returnedValue="";

            maConnexionMysql.Laconnexion.Open();

            // creation requête et ajout à la commande
            string sqlRequest = "SELECT password FROM user where name = @nameuserpwd; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuserpwd", name);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;

            MySqlDataReader monReaderMysql = maConnexionMysql.Lacommande.ExecuteReader();
            while (monReaderMysql.Read())
            {
                string result = monReaderMysql["password"].ToString();
                maConnexionMysql.Laconnexion.Close();
                return result;

            }
            
                maConnexionMysql.Laconnexion.Close();
                return "NONE";
            

        }
        //////////////

        public void VerifiyLogin(string login, string password)
        {

        }
        public void updateInfo(Users o,string PreviousName)
        {
            maConnexionMysql.Laconnexion.Open();
            string sqlRequest = "UPDATE user SET name = @nameupdate, email =@emailupdate, firstName = @firstNameupdate, password= @passwordupdate where name = @nameuserupdate; ";
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameuserupdate", PreviousName);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@emailupdate", o.email);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@firstNameupdate", o.firstName);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@nameupdate", o.name);
            maConnexionMysql.Lacommande.Parameters.AddWithValue("@passwordupdate", o.password);
            maConnexionMysql.Lacommande.CommandText = sqlRequest;
            maConnexionMysql.Lacommande.ExecuteNonQuery();

            maConnexionMysql.Laconnexion.Close();

        }
    }

}
