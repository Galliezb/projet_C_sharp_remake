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
    public partial class Form_Tournament_Delete : Form
    {
        Tournament allTournaments;
        DataSet dataSetAllTournaments;
        int ligneDelete = 0;
        public Form_Tournament_Delete()
        {
            InitializeComponent();
            // chargement datas
            allTournaments = new Tournament();
            dataSetAllTournaments = allTournaments.getTournamentOfTheSession();

            foreach (DataRow rw in dataSetAllTournaments.Tables["tournament"].Rows)
            {

                cb_Name_Tournament.Items.Add(rw["name"].ToString());

            }

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
                ligneDelete++;
            }
        }

        private void button_sauvegarder_Click(object sender, EventArgs e)
        {
            /*           if (allTournaments.delete())
                       {
                           MessageBox.Show(Traducteur.traduction_[66]);
                       }
                       else
                       {
                           MessageBox.Show(Traducteur.traduction_[67]);
                       } 
                       --> tournament.Delete() ne retourne pas de bool, et tu m'as dit qu'on s'en foutait des messagebox */
                                  
            allTournaments.delete();
            ligneDelete = 0;
            cb_Name_Tournament.Items.Remove(cb_Name_Tournament.Text);
            cb_Name_Tournament.Text = "";
            tb_description.Clear();
            tb_Type.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
    }
}
