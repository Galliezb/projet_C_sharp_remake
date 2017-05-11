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
    public partial class Form_Create_Arbo : Form
    {
        string game;
        Team forGettingAllTeams;
        DataSet dataAllTeam;
        Tournament allTournaments;
        DataSet dataSetAllTournaments;
        public Form_Create_Arbo()
        {
            InitializeComponent();
            allTournaments = new Tournament();
            dataSetAllTournaments = allTournaments.getTournamentOfTheSession();

            foreach (DataRow rw in dataSetAllTournaments.Tables["tournament"].Rows)
            {

                    cbb_Name_Tournament.Items.Add(rw["name"].ToString());
                

            }


            forGettingAllTeams = new Team();
        }

        private void Form_Create_Arbo_Load(object sender, EventArgs e)
        {
            dataAllTeam = forGettingAllTeams.getAllTeam();
            foreach ( DataRow r in dataAllTeam.Tables[0].Rows)
            {

                cbR1T1.Items.Add(r["name"].ToString());
                cbR1T2.Items.Add(r["name"].ToString());
                cbR1T3.Items.Add(r["name"].ToString());
                cbR1T4.Items.Add(r["name"].ToString());
                cbR1T5.Items.Add(r["name"].ToString());
                cbR1T6.Items.Add(r["name"].ToString());
                cbR1T7.Items.Add(r["name"].ToString());
                cbR1T8.Items.Add(r["name"].ToString());

            }
        }

        private void cbb_Name_Tournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow rw in dataSetAllTournaments.Tables["tournament"].Rows)
            {

                if (rw["name"].ToString() == cbb_Name_Tournament.Text)
                {
                    game = Convert.ToString(rw["jeu"]);
                    break;
                }

            }
            dataAllTeam = forGettingAllTeams.getAllTeam();
            foreach (DataRow r in dataAllTeam.Tables[0].Rows)
            {
                if (r["jeu"].ToString()== game)
                cbR1T1.Items.Add(r["name"].ToString());
                cbR1T2.Items.Add(r["name"].ToString());
                cbR1T3.Items.Add(r["name"].ToString());
                cbR1T4.Items.Add(r["name"].ToString());
                cbR1T5.Items.Add(r["name"].ToString());
                cbR1T6.Items.Add(r["name"].ToString());
                cbR1T7.Items.Add(r["name"].ToString());
                cbR1T8.Items.Add(r["name"].ToString());

            }
        }
    }
}
