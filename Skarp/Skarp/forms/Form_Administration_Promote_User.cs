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
    public partial class Form_Administration_Promote_User : Form
    {
        DataSet dataForGrid = new DataSet();
        Users userForDataGrid = new Users(-1);
        public Form_Administration_Promote_User()
        {
            InitializeComponent();
        }

        private void btPromote1_Click(object sender, EventArgs e)
        {
            btPromote1.Visible = false;
            btPromote2.Visible = true;
        }

        private void btPromote2_Click(object sender, EventArgs e)
        {
            btPromote2.Visible = false;
            btPromote3.Visible = true;
        }

        private void btPromote3_Click(object sender, EventArgs e)
        {
            btPromote3.Visible = false;
            btPromote4.Visible = true;
        }

        private void btPromote4_Click(object sender, EventArgs e)
        {
            btPromote4.Visible = false;
            btPromote5.Visible = true;
        }

        private void btPromote5_Click(object sender, EventArgs e)
        {
            userForDataGrid.update(dataForGrid);

            btPromote1.Visible = true;
            btPromote5.Visible = false;
        }

        private void Form_Administration_Promote_User_Load(object sender, EventArgs e)
        {
            dg_joueur.Size = new Size(250, 300);
            dataForGrid = userForDataGrid.getAllUsers();
            dg_joueur.DataSource = dataForGrid;
            dg_joueur.DataMember = "user";
            foreach(DataGridViewColumn column in dg_joueur.Columns)
            {
                column.Width = 96;
            }
            for (int i =0; i < 9; i++)
            {
                if (i==1 || i== 8)
                {
                   
                } 
                else
                {
                    dg_joueur.Columns[i].Visible = false;
                }
            }
            
       }

        private void dg_joueur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
