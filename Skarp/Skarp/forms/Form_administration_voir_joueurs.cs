using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp.forms {
    public partial class Form_administration_voir_joueurs : Form {

        DataSet dataForGrid = new DataSet();
        Users userForDataGrid = new Users(-1);

        public Form_administration_voir_joueurs () {
            InitializeComponent();
        }

        private void Form_administration_voir_joueurs_Load ( object sender , EventArgs e ) {

            dataForGrid = userForDataGrid.getAllUsers();
            dg_joueur.DataSource = dataForGrid;
            dg_joueur.DataMember = "user";

            dg_joueur.Columns["idUser"].Visible = false;
            dg_joueur.Columns["isAdmin"].Visible = false;
            dg_joueur.Columns["isorganizer"].Visible = false;

            int taille = 135;
            dg_joueur.Columns["name"].Width = taille;
            dg_joueur.Columns["firstName"].Width = taille;
            dg_joueur.Columns["email"].Width = taille;
            dg_joueur.Columns["password"].Width = taille;
            dg_joueur.Columns["pseudo"].Width = taille;
            dg_joueur.Columns["language"].Width = taille;

        }

        /// <summary>
        /// Mets à jours la BDD depuis le dataset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click ( object sender , EventArgs e ) {

            userForDataGrid.update( dataForGrid );

        }

    }
}
