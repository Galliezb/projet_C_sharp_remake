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
    public partial class Form_organisation : Form {

        bool mustBeRegistered = false;
        Organisation monOrg = new Organisation();

        public Form_organisation () {
            InitializeComponent();

            reloadData();

        }

        private void reloadData () {

            DataSet monDataset = monOrg.getAllInfo();

            if ( monDataset.Tables["organization"].Rows.Count > 0 ) {

                //MessageBox.Show( monDataset.Tables["organization"].Rows.Count +" et "+ monDataset.Tables["organization"].Rows[0]["description"].ToString() );

                tb_description.Text = monDataset.Tables["organization"].Rows[0]["description"].ToString();
                tb_email.Text = monDataset.Tables["organization"].Rows[0]["mailResponsable"].ToString();
                tb_nom_organisation.Text = monDataset.Tables["organization"].Rows[0]["nameOrganization"].ToString();
                dtp_dateCreation.Value = Convert.ToDateTime( monDataset.Tables["organization"].Rows[0]["creatingDate"].ToString());

                monOrg.ID = Convert.ToInt32( monDataset.Tables["organization"].Rows[0]["idOrganization"].ToString() );
                monOrg.idOrganizer = Session.ID;
                monOrg.DateCreation = DateTime.Now;
                monOrg.Mail = monDataset.Tables["organization"].Rows[0]["mailResponsable"].ToString();
                monOrg.Name = monDataset.Tables["organization"].Rows[0]["nameOrganization"].ToString();
                monOrg.Description = monDataset.Tables["organization"].Rows[0]["description"].ToString();

            } else {
                mustBeRegistered = true;
            }

        }

        private void button1_Click ( object sender , EventArgs e ) {

            
            
            monOrg.Mail = tb_email.Text;
            monOrg.Name = tb_nom_organisation.Text;
            monOrg.Description = tb_description.Text;
            monOrg.idOrganizer = Session.ID;

            if ( mustBeRegistered ) {

                monOrg.insert();
                mustBeRegistered = false;

            } else {

                monOrg.update();

            }
            MessageBox.Show( Traducteur.traduction_[5] );

        }
    }


}
