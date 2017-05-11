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
    public partial class Form_Tournament_List_Started : Form
    {
        Tournament allTournaments;
        DataSet dataSetAllTournaments;
        public Form_Tournament_List_Started()
        {
            InitializeComponent();
            // chargement datas
            allTournaments = new Tournament();
            dataSetAllTournaments = allTournaments.getTournamentOfTheSession();

            foreach (DataRow rw in dataSetAllTournaments.Tables["tournament"].Rows)
            {
                DateTime check = Convert.ToDateTime(rw["startDate"]);
                if (DateTime.Now >= check)
                {
                    cb_Name_Tournament.Items.Add(rw["name"].ToString());
                }

            }
        }

        private void Form_Tournament_List_Started_Load(object sender, EventArgs e)
        {

        }

        private void cb_Name_Tournament_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow rw in dataSetAllTournaments.Tables["tournament"].Rows)
            {

                if (rw["name"].ToString() == cb_Name_Tournament.Text)
                {

                    allTournaments.idTournament = Convert.ToInt32(rw["idTournament"]);
                    tb_description.Text = rw["description"].ToString();
                    dateTimePicker1.Text = rw["startDate"].ToString();
                    dateTimePicker2.Text = rw["endDate"].ToString();
                    tb_Type.Text = rw["type"].ToString();
                    break;

                }

            }
        }
    }
}
