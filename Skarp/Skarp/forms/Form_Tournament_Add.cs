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
    public partial class Form_Tournament_Add : Form
    {
        public Form_Tournament_Add()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Tournament monTournoi = new Tournament();
            monTournoi.name = tbNom.Text;
            monTournoi.typeTournoi = tbType.Text;
            monTournoi.idOrganizer = Session.ID;
            monTournoi.startDate = dtpStartDate.Value;
            monTournoi.endDate = dtpEndDate.Value;
            monTournoi.Description = rtbDescription.Text;
            monTournoi.maxPlayer = Convert.ToInt32(tbMaxPlayer.Text);
            monTournoi.jeu = tb_Jeu.Text;


            monTournoi.insert();


            tbNom.Clear();
            tbMaxPlayer.Clear();
            tbType.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value =DateTime.Now.AddDays(3);           
            rtbDescription.Clear();
            tb_Jeu.Items.Clear();
          
            
        }
    }
}
