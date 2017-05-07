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
    public partial class Form_CreateOrg : Form {

        public Form_CreateOrg () {
            InitializeComponent();
        }

        private void Form_CreateOrg_Load ( object sender , EventArgs e ) {
            /*
            // traduit en français si nécessaire
            if ( Session.language == "fr" ) {

                lbCreateTnm.Text = "Créer un tournoi : ";
                lbNameTnm.Text = " Nom : ";
                lbDateDebutTnm.Text = "Date de début : ";
                lbDateFinTnm.Text = "Date de fin : ";
                lbDescTnm.Text = "Description : ";
                lbMaxPlayerTnm.Text = "Nombre max de joueurs : ";
                btSubmissionTnm.Text = "Soumettre";

                comboBoxType.Items.Clear();
                comboBoxType.Items.Add( "Championnat toute ronde" );
                comboBoxType.Items.Add( "Elimination directe" );
                comboBoxType.Items.Add( "Phase de groupe" );


            }
            */

            comboBoxType.SelectedIndex = 0;

            // mets à jour les dates préselectionnés
            dateTimePickerStartDate.Value = DateTime.Now.AddDays( 1 );
            dateTimePickerEndDate.Value = DateTime.Now.AddDays( 4 );


            // renseigne les valeurs non modifiable dans le nom manager et le mail
            tbManagerName.Text = Session.name;

            // nico
            //panelCreateOrga.Parent = this;
            //panelCreateTnm.Parent = this;

        }

        private void btSubmissionTnm_Click ( object sender , EventArgs e ) {

            Tournament tournoi = new Tournament();

            tournoi.name = tnNameTnm.Text;
            tournoi.typeTournoi = comboBoxType.SelectedText;
            tournoi.startDate = dateTimePickerStartDate.Value;
            tournoi.endDate = dateTimePickerEndDate.Value;
            tournoi.maxPlayer = Convert.ToInt32( tbMaxpPlayerTnm.Text );
            tournoi.Description = rtbDescTnm.Text;

            tournoi.insert();

            this.Refresh();


        }

        private bool isNullOrEmpty ( string str ) {

            if ( str == "" || str == null ) {
                return true;
            } else {
                return false;
            }

        }

        private void btCreateTnm_Click ( object sender , EventArgs e ) {
            panelCreateTnm.Visible = true;
            panelCreateOrga.Visible = false;
        }

        private void btCreateOrga_Click ( object sender , EventArgs e ) {
            panelCreateTnm.Visible = false;
            panelCreateOrga.Visible = true;
        }

        private void panelCreateTnm_Paint ( object sender , PaintEventArgs e ) {

        }

        private void btSubmitOrga_Click ( object sender , EventArgs e ) {

            // create organization

        }
    }
}
