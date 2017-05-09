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
    public partial class Form_Team_Manage : Form
    {
        DataSet dataForGrid = new DataSet();
        Team team= new Team(-1);
        public Form_Team_Manage()
        {
            InitializeComponent();
        }

        private void dg_joueur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //team.get
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            team.update();
        }
    }
}
