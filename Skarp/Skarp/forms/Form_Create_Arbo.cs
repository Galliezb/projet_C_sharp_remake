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
        int rowSelected = 0;
        int idTournament = -1;
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

            // on affiche le bouton SUBMIT PAR DEFAUT et a la selection on vérifie
            button_update.Visible = false;
            btSubmit.Visible = true;

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
                    idTournament = Convert.ToInt32( rw["idTournament"] );
                    break;
                }
                rowSelected++;

            }


            cbR1T1.Items.Clear();
            cbR1T2.Items.Clear();
            cbR1T3.Items.Clear();
            cbR1T4.Items.Clear();
            cbR1T5.Items.Clear();
            cbR1T6.Items.Clear();
            cbR1T7.Items.Clear();
            cbR1T8.Items.Clear();

            dataAllTeam = forGettingAllTeams.getAllTeam();

            foreach (DataRow r in dataAllTeam.Tables["team"].Rows)
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

            // vérifie si déjà fait, si c'est le cas, on réaffiche
            Arbo arborescence = new Arbo();
            List<string> liste = arborescence.getRow( idTournament );
            // la BDD retourne une liste si une ligne est présente, sinon rien donc liste = 0
            if ( liste.Count > 0 ) {

                cbR1T1.Text = liste[0];
                cbR1T2.Text = liste[1];
                cbR1T3.Text = liste[2];
                cbR1T4.Text = liste[3];
                cbR1T5.Text = liste[4];
                cbR1T6.Text = liste[5];
                cbR1T7.Text = liste[6];
                cbR1T8.Text = liste[7];
                cbR2T1.Text = liste[8];
                cbR2T2.Text = liste[9];
                cbR2T3.Text = liste[10];
                cbR2T4.Text = liste[11];
                cbR3T1.Text = liste[12];
                cbR3T2.Text = liste[13];
                cbwinner.Text = liste[14];
                // on affiche le bouton UPATE
                button_update.Visible = true;
                btSubmit.Visible = false;

            } else {
                cbR1T1.Text = "";
                cbR1T2.Text = "";
                cbR1T3.Text = "";
                cbR1T4.Text = "";
                cbR1T5.Text = "";
                cbR1T6.Text = "";
                cbR1T7.Text = "";
                cbR1T8.Text = "";
                cbR2T1.Text = "";
                cbR2T2.Text = "";
                cbR2T3.Text = "";
                cbR2T4.Text = "";
                cbR3T1.Text = "";
                cbR3T2.Text = "";
                cbwinner.Text = "";

                // on affiche le bouton SUBMIT
                button_update.Visible = false;
                btSubmit.Visible = true;
            }

        }

        private void btSubmit_Click ( object sender , EventArgs e ) {

            Arbo arborescence = new Arbo();

            arborescence.IDtournament = Convert.ToInt32( dataSetAllTournaments.Tables["tournament"].Rows[rowSelected]["idTournament"]);
            arborescence.R1T1 = cbR1T1.Text;
            arborescence.R1T2 = cbR1T2.Text;
            arborescence.R1T3 = cbR1T3.Text;
            arborescence.R1T4 = cbR1T4.Text;
            arborescence.R1T5 = cbR1T5.Text;
            arborescence.R1T6 = cbR1T6.Text;
            arborescence.R1T7 = cbR1T7.Text;
            arborescence.R1T8 = cbR1T8.Text;
            arborescence.R2T1 = cbR2T1.Text;
            arborescence.R2T2 = cbR2T2.Text;
            arborescence.R2T3 = cbR2T3.Text;
            arborescence.R2T4 = cbR2T4.Text;
            arborescence.R3T1 = cbR3T1.Text;
            arborescence.R3T2 = cbR3T2.Text;
            arborescence.vainqueur = cbwinner.Text;

            if ( arborescence.insert() ) {
                MessageBox.Show( Traducteur.traduction_[5] );
            }

        }

        private void r1t1r1t2SelectionChanged ( object sender , EventArgs e ) {

            cbR2T1.Items.Clear();
            cbR2T1.Items.Add(cbR1T1.Text);
            cbR2T1.Items.Add(cbR1T2.Text);

        }

        private void r1t3r1t4SelectionChanged ( object sender , EventArgs e ) {

            cbR2T2.Items.Clear();
            cbR2T2.Items.Add( cbR1T3.Text );
            cbR2T2.Items.Add( cbR1T4.Text );

        }

        private void r1t5r1t6SelectionChanged ( object sender , EventArgs e ) {

            cbR2T3.Items.Clear();
            cbR2T3.Items.Add( cbR1T5.Text );
            cbR2T3.Items.Add( cbR1T6.Text );

        }

        private void r1t7r1t8SelectionChanged ( object sender , EventArgs e ) {

            cbR2T4.Items.Clear();
            cbR2T4.Items.Add( cbR1T7.Text );
            cbR2T4.Items.Add( cbR1T8.Text );

        }

        private void r2t1r2t2SelectionChanged ( object sender , EventArgs e ) {

            cbR3T1.Items.Clear();
            cbR3T1.Items.Add( cbR2T1.Text );
            cbR3T1.Items.Add( cbR2T2.Text );

        }

        private void r2t3r2t4SelectionChanged ( object sender , EventArgs e ) {

            cbR3T2.Items.Clear();
            cbR3T2.Items.Add( cbR2T3.Text );
            cbR3T2.Items.Add( cbR2T4.Text );

        }

        private void r3t1r3t2SelectionChanged ( object sender , EventArgs e ) {

            cbwinner.Items.Clear();
            cbwinner.Items.Add( cbR3T1.Text );
            cbwinner.Items.Add( cbR3T2.Text );

        }

        private void button_update_Click ( object sender , EventArgs e ) {
            Arbo arborescence = new Arbo();

            arborescence.IDtournament = Convert.ToInt32( dataSetAllTournaments.Tables["tournament"].Rows[rowSelected]["idTournament"] );
            arborescence.R1T1 = cbR1T1.Text;
            arborescence.R1T2 = cbR1T2.Text;
            arborescence.R1T3 = cbR1T3.Text;
            arborescence.R1T4 = cbR1T4.Text;
            arborescence.R1T5 = cbR1T5.Text;
            arborescence.R1T6 = cbR1T6.Text;
            arborescence.R1T7 = cbR1T7.Text;
            arborescence.R1T8 = cbR1T8.Text;
            arborescence.R2T1 = cbR2T1.Text;
            arborescence.R2T2 = cbR2T2.Text;
            arborescence.R2T3 = cbR2T3.Text;
            arborescence.R2T4 = cbR2T4.Text;
            arborescence.R3T1 = cbR3T1.Text;
            arborescence.R3T2 = cbR3T2.Text;
            arborescence.vainqueur = cbwinner.Text;

            if ( arborescence.update() ){
                MessageBox.Show( Traducteur.traduction_[5] );
            }
        }
    }
}
