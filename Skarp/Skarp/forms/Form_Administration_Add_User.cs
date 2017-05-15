using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skarp.classes;


namespace Skarp.forms
{
    public partial class Form_Administration_Add_User : Form
    {
        Users newUser;
        ADConnection ADCo = new ADConnection();
        string result;
        public Form_Administration_Add_User()
        {
            InitializeComponent();
            //ADCo = new ADConnection();
            cbbSelectType.SelectedIndex = 0;
            cbLanguage.Text = Session.language;
        }

       
            

        private void btSubmit_Click_1(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length > 50)
            {
                MessageBox.Show(Traducteur.traduction_[4]);
            }
            else if (tbNameUser.Text.Length > 50)
            {
                MessageBox.Show(Traducteur.traduction_[3]);
            }
            else if (tbMail.Text.Length > 255)
            {
                MessageBox.Show(Traducteur.traduction_[5]);
            }
            else if (tbPwd.Text.Length > 255)
            {
                MessageBox.Show(Traducteur.traduction_[6]);
            }
            else if (tbPwd.Text != textBox1.Text)
            {
                MessageBox.Show(Traducteur.traduction_[57]);
            }
            else if (cbLanguage.SelectedItem.ToString() != "fr" && cbLanguage.SelectedItem.ToString() != "en")
            {
                MessageBox.Show(Traducteur.traduction_[8]);
            }
            else
            {
                /*
                bool done = false;
                if (cbbSelectType.SelectedItem.ToString() == "Administrator")
                {
                    newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, false, true);
                    newUser.insert();
                    done = true;
                }
                else if (cbbSelectType.SelectedItem.ToString() == "Organizer")
                {
                    newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, true, false);
                    newUser.insert();
                    done = true;
                }
                else if (cbbSelectType.SelectedItem.ToString() == "User")
                {
                    newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, false, false);
                    newUser.insert();
                    done = true;
                } else
                {
                    MessageBox.Show("Error : Aucune insertion en BDD");
                }
                */

                if (true) //done
                {
                    // ok donc on sait que tout ce qui arrive ici est correct, go débug plus loin
                    //MessageBox.Show(newUser.pseudo + " " + newUser.name + " " + newUser.firstName + " " + tbPwd.Text + " " + newUser.email + " " + rtbDesc.Text.ToString());
                    
                     result =  ADCo.CreateUserAccount("MAMADOU","SuperMAMA123");
                    // ok ici, il faut vérifier que toutes les valeurs sont ok genre
                    MessageBox.Show("User ajouté à l AD: "+result);

                    // y'a pas d'ajout en BDD ??? Ha merde au dessus :D

                    cbbSelectType.SelectedIndex = 0;
                    tbNameUser.Text = "";
                    tbFirstName.Text = "";
                    tbMail.Text = "";
                    tbPseudo.Text = "";
                    tbPwd.Text = "";
                    cbLanguage.SelectedIndex = 0;
                    rtbDesc.Text = "";
                    textBox1.Text = "";
                }
            }

                

        }

        private void Form_Administration_Add_User_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
