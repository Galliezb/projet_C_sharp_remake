using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp.forms
{
    public partial class Form_Tournament_Manage : Form
    {
        DataSet dataForGrid = new DataSet();
        Tournament TournamentsForDataGrid = new Tournament(-1);
        public Form_Tournament_Manage()
        {
            InitializeComponent();
        }

        private void Form_Tournament_Manage_Load(object sender, EventArgs e)
        {
            dg_Tournoi.ForeColor = Color.Black;
            dataForGrid = TournamentsForDataGrid.getTournamentOfTheSession();

            dg_Tournoi.DataSource = dataForGrid;
            dg_Tournoi.DataMember = "tournament";

            dg_Tournoi.Columns["idTournament"].Visible = false;
            dg_Tournoi.Columns["idOrganizer"].Visible = false;
            
            int taille = 110;
            dg_Tournoi.Columns["name"].Width = taille;
            dg_Tournoi.Columns["description"].Width = taille;
            dg_Tournoi.Columns["startDate"].Width = taille;
            dg_Tournoi.Columns["endDate"].Width = taille;
            dg_Tournoi.Columns["type"].Width = taille;
            dg_Tournoi.Columns["maxPlayer"].Width = taille;
            dg_Tournoi.Columns["jeu"].Width = taille;
            dg_Tournoi.Columns["jeu"].ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            TournamentsForDataGrid.update(dataForGrid);
        }
    }
}
