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
    public partial class Form_WebService : Form {
        public Form_WebService () {
            InitializeComponent();
        }

        private void Form_WebService_Load ( object sender , EventArgs e ) {

            Dictionary<string , string> toDsiplay = Fonction.CiaSeeYou();
            
            lbr_ville.Text = toDsiplay["ville"];
            lbr_code_pays.Text = toDsiplay["codePays"];
            lbr_pays.Text = toDsiplay["pays"];
            lbr_region.Text = toDsiplay["region"];
            lbr_latitude.Text = toDsiplay["latitude"];
            lbr_longitude.Text = toDsiplay["longitude"];
            lbr_zone_horaire.Text = toDsiplay["zoneHoraire"];
            lbr_code_postal.Text = toDsiplay["codePostal"];
            
        }
    }
}
