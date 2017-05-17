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
    public partial class Form_Team_Manage : Form
    {
        DataSet dataForGrid = new DataSet();
        Team team= new Team(-1);
        public Form_Team_Manage()
        {
            InitializeComponent();
            
        }

        private void dg_joueur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            team.update(dataForGrid);
        }

        private void Form_Team_Manage_Load(object sender, EventArgs e)
        {
            dataForGrid = team.getTeamOfTheSession();
            dg_team.DataSource = dataForGrid;
            dg_team.DataMember = "team";
            dg_team.Columns["dateCreation"].Width = 115;
            dg_team.Columns["name"].Width = 240;
            dg_team.Columns[4].Width = 400;
            for (int i = 0; i < 4; i++)
            {
                if (i != 0 && i != 2 )
                {
                    dg_team.Columns[i].Visible = true;
                }
                else
                {
                    dg_team.Columns[i].Visible = false;
                }
            }
        }
    }
}
