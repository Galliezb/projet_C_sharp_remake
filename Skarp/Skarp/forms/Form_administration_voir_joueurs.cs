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

            dg_joueur.Columns[0].Visible = false;

        }

        /// <summary>
        /// Mets à jours la BDD depuis le dataset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click ( object sender , EventArgs e ) {

            userForDataGrid.update( dataForGrid );

        }

        private void dg_joueur_CellContentClick ( object sender , DataGridViewCellEventArgs e ) {

            dg_joueur.Columns["idUser"].Visible = false;

        }
    }
}
