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
    public partial class Form_Team_Add_Player : Form
    {
        Users allUsers, playerSelected;
        DataSet dataSetAllUsers;
        Team allTeams, teamSelected;
        DataSet dataSetAllTeams;
        public Form_Team_Add_Player()
        {

            InitializeComponent();
            allUsers = new Users();
            dataSetAllUsers = allUsers.getAllUsers();
            allTeams = new Team();
            dataSetAllTeams = allTeams.getTeamOfTheSession();

            foreach (DataRow rw in dataSetAllUsers.Tables["user"].Rows)
            {

                cbb_Player.Items.Add(rw["pseudo"].ToString());

            }
            foreach (DataRow rw in dataSetAllTeams.Tables["team"].Rows)
            {

                cbb_Team.Items.Add(rw["name"].ToString());

            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void cbb_Player_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerSelected = new Users();
            teamSelected = new Team();
            foreach (DataRow rw in dataSetAllUsers.Tables["user"].Rows)
            {

                if (rw["name"].ToString() == cbb_Player.Text)
                {

                    playerSelected.ID = Convert.ToInt32(rw["idUser"]);
                    break;
                }

            }
            foreach (DataRow rw in dataSetAllTeams.Tables["team"].Rows)
            {

                if (rw["name"].ToString() == cbb_Team.Text)
                {

                    teamSelected.idTeam = Convert.ToInt32(rw["idTeam"]);
                    break;
                }

            }
            MessageBox.Show(teamSelected.idTeam.ToString());
        }
    }
}
