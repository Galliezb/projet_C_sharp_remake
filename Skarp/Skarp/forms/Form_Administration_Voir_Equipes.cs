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
    public partial class Form_Administration_Voir_Equipes : Form
    {

        DataSet dataForGrid = new DataSet();
        Team teamForDataGrid = new Team( -1 );


        public Form_Administration_Voir_Equipes ()
        {
            InitializeComponent();
        }

        private void Form_Administration_Voir_Equipes_Load(object sender, EventArgs e)
        {
            dataForGrid = teamForDataGrid.getAllTeam();
            dg_team.DataSource = dataForGrid;
            dg_team.DataMember = "team";

            dg_team.Columns["idTeam"].Visible = false;
            dg_team.Columns["captain"].Visible = false;

            dg_team.Columns["name"].Width = 162;
            dg_team.Columns["dateCreation"].Width = 162;
            dg_team.Columns["description"].Width = 550;


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            teamForDataGrid.update( dataForGrid );
            MessageBox.Show( Traducteur.traduction_[5] );
        }
    }
}
