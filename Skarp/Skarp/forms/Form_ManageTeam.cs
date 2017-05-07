using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp {
    public partial class Form_ManageTeam : Form {
        Team team = new Team();

        public Form_ManageTeam () {
            InitializeComponent();
            btUpdate_Team.Visible = false;
            btCreate_Team.Visible = false;
        }

        private void label1_Click ( object sender , EventArgs e ) {

        }

        private void btCreateTeam_Click ( object sender , EventArgs e ) {
            PanelRightCT.Visible = true;
            PanelModifyTeam.Visible = false;
            btCreate_Team.Visible = true;
            btUpdate_Team.Visible = false;
        }

        private void lb_Click ( object sender , EventArgs e ) {

        }

        private void cbbChooseTeam_SelectedIndexChanged ( object sender , EventArgs e ) {
            btUpdate_Team.Visible = true;
            btCreate_Team.Visible = false;

            tbTagCT.Text = "CKC";
            tbAddGameCT.Text = "";
            tbDescriptionCT.Text = "";
            PanelRightCT.Visible = true;
            PanelModifyTeam.Visible = true;
        }

        private void btCreate_Team_Click ( object sender , EventArgs e ) {
            team.name = tbNameCT.Text;
            team.description = lbDescriptionCT.Text;
            MessageBox.Show( team.creationDate.ToString( "yyyy-MM-dd" ) );
            team.insert();
        }

        private void Form_ManageTeam_Load ( object sender , EventArgs e ) {

            if ( Session.language == "fr" ) {

                btCreateTeam.Text = "Créer une équipe";
                lbChooseTeam.Text = "Choisir une team";
            }

        }
    }
}
