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

        }
    }
}
