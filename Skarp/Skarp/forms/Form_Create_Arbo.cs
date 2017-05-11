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
        Team forGettingAllTeams;
        DataSet dataAllTeam;
        public Form_Create_Arbo()
        {
            InitializeComponent();
            
        }

        private void Form_Create_Arbo_Load(object sender, EventArgs e)
        {
            dataAllTeam = forGettingAllTeams.getAllTeam();
            dataAllTeam.Tables[0].Columns["name"].
        }
    }
}
