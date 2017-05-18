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
    public partial class Form_Top10 : Form {
        public Form_Top10 () {
            InitializeComponent();
            axShockwaveFlash1.Visible = false;
            tbDescription.ForeColor = Color.White;
        }

        private void GameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameList.SelectedItem.ToString() == "League of Legends")
            {

                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/fjrfYZsZLJA";

                tbDescription.Text = Traducteur.traduction_[105];
            }
            if (GameList.SelectedItem.ToString() == "Battlerite")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/f5Q041c0Sis";
                //
                tbDescription.Text = Traducteur.traduction_[106];

            }
            if (GameList.SelectedItem.ToString() == "BattleBorn")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/7G4jIm5Dj8Y";
                //
                tbDescription.Text = Traducteur.traduction_[107];
            }
            if (GameList.SelectedItem.ToString() == "Counter Strike GO")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/edYCtaNueQY";
                //
                tbDescription.Text = Traducteur.traduction_[108];
            }
            if (GameList.SelectedItem.ToString() == "Dota2")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/Ii_EjA7bqYw";

                tbDescription.Text = Traducteur.traduction_[109];
            }
            if (GameList.SelectedItem.ToString() == "Overwatch")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/FqnKB22pOC0";

                tbDescription.Text = Traducteur.traduction_[110];
            }
            if (GameList.SelectedItem.ToString() == "Heavy Metal Machine")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/eNhNj9klFss";

                tbDescription.Text = Traducteur.traduction_[111];
            }
            if (GameList.SelectedItem.ToString() == "Paladin")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/dEwEC2MKgeQ";

                tbDescription.Text = Traducteur.traduction_[112];
            }
            if (GameList.SelectedItem.ToString() == "Hearthstone")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/MG3nb7Oam4k";

                tbDescription.Text = Traducteur.traduction_[113];
            }
            if (GameList.SelectedItem.ToString() == "Orion Prelude")
            {
                axShockwaveFlash1.Visible = true;
                axShockwaveFlash1.Movie = "https://www.youtube.com/v/Rt6tM72XSYM";

                tbDescription.Text = Traducteur.traduction_[114];
            }
        }
    }
}
