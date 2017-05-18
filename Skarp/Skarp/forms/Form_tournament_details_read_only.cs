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
    public partial class Form_tournament_details_read_only : Form {

        int idArboToSee_;

        public Form_tournament_details_read_only (int idArboToSee) {
            InitializeComponent();
            idArboToSee_ = idArboToSee;
        }

        private void Form_tournament_details_read_only_Load ( object sender , EventArgs e ) {

            Arbo arborescence = new Arbo();
            List<string> liste = arborescence.getRow( idArboToSee_ );

            if ( liste.Count > 0 ) {
                lb_R1T1.Text = liste[0];
                lb_R1T2.Text = liste[1];
                lb_R1T3.Text = liste[2];
                lb_R1T4.Text = liste[3];
                lb_R1T5.Text = liste[4];
                lb_R1T6.Text = liste[5];
                lb_R1T7.Text = liste[6];
                lb_R1T8.Text = liste[7];
                lb_R2T1.Text = liste[8];
                lb_R2T2.Text = liste[9];
                lb_R2T3.Text = liste[10];
                lb_R2T4.Text = liste[11];
                lb_R3T1.Text = liste[12];
                lb_R3T2.Text = liste[13];
                lb_winner.Text = liste[14];
            } else {

                lb_R1T1.Text = "?????";
                lb_R1T2.Text = "?????";
                lb_R1T3.Text = "?????";
                lb_R1T4.Text = "?????";
                lb_R1T5.Text = "?????";
                lb_R1T6.Text = "?????";
                lb_R1T7.Text = "?????";
                lb_R1T8.Text = "?????";
                lb_R2T1.Text = "?????";
                lb_R2T2.Text = "?????";
                lb_R2T3.Text = "?????";
                lb_R2T4.Text = "?????";
                lb_R3T1.Text = "?????";
                lb_R3T2.Text = "?????";
                lb_winner.Text = "?????";

                MessageBox.Show( "Les résultats ne sont pas encore publiés" );


            }
        }
    }
}
