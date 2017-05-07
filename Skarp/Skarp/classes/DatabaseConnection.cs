using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Skarp {
    class DatabaseConnection {

        // connector Mysql
        static MySqlConnection laConnexion_;
        static MySqlCommand laCommande_;

        public DatabaseConnection () {

            laCommande_ = new MySqlCommand();

            try {

                // connection au serveur Kimsufi OVH
                laConnexion_ = new MySqlConnection( Skarp.Properties.Settings.Default.kimsufiOvh );

                // envoi la connexion dans la commande
                laCommande_.Connection = laConnexion_;


            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message.ToString() );
            }

        }

        public MySqlConnection Laconnexion {
            get { return laConnexion_; }
        }

        public MySqlCommand Lacommande {
            get { return laCommande_; }
            set { laCommande_ = value; }
        }


    }
}
