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
    public partial class Form_AddTeam : Form
    {
        
        public Form_AddTeam()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbNameTeam.Text.Length > 50)
            {
                MessageBox.Show( Traducteur.traduction_[43] );
            }
            else
            {
                Team teamToCreate = new Team(-1, tbNameTeam.Text, tbDescription.Text);
                teamToCreate.idCaptain = Session.ID;
                teamToCreate.insert();
            }
        }
    }
}
