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
        
        public Form_Administration_Add_User()
        {
            InitializeComponent();
            
            cbbSelectType.SelectedIndex = 0;
            cbbSelectType.Items.Clear();
            cbbSelectType.Items.Add( Traducteur.traduction_[58] );
            cbbSelectType.Items.Add( Traducteur.traduction_[59] );
            cbbSelectType.Items.Add( Traducteur.traduction_[60] );
            cbLanguage.Text = Session.language;
        }

       
            

        private void btSubmit_Click_1(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Length > 50)
            {
                MessageBox.Show(Traducteur.traduction_[42]);
            }
            else if (tbNameUser.Text.Length > 50)
            {
                MessageBox.Show(Traducteur.traduction_[43]);
            }
            else if (tbMail.Text.Length > 255)
            {
                MessageBox.Show(Traducteur.traduction_[44]);
            }
            else if (tbPwd.Text.Length > 255)
            {
                MessageBox.Show(Traducteur.traduction_[45]);
            }
            else if (tbPwd.Text != textBox1.Text)
            {
                MessageBox.Show(Traducteur.traduction_[53]);
            }
            else if (tbPwd.Text == tbPseudo.Text)
            {
                MessageBox.Show( Traducteur.traduction_[54] );
            }
            else if (cbLanguage.SelectedItem.ToString() != "fr" && cbLanguage.SelectedItem.ToString() != "en")
            {
                MessageBox.Show(Traducteur.traduction_[46] +" "+ Traducteur.traduction_[40] + " " + Traducteur.traduction_[48] + " " + Traducteur.traduction_[41]);
            }
            else
            {
                
                bool done = false;
                if (cbbSelectType.SelectedItem.ToString() == Traducteur.traduction_[58] )
                {
                    newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, false, true);
                    newUser.insert();
                    done = true;
                }
                else if (cbbSelectType.SelectedItem.ToString() == Traducteur.traduction_[59] )
                {
                    newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, true, false);
                    newUser.insert();
                    done = true;
                }
                else if (cbbSelectType.SelectedItem.ToString() == Traducteur.traduction_[60] )
                {
                    newUser = new Users(-1, tbNameUser.Text, tbFirstName.Text, tbMail.Text, tbPwd.Text, tbPseudo.Text, cbLanguage.Text, false, false);
                    newUser.insert();
                    done = true;
                } else
                {
                    MessageBox.Show( Traducteur.traduction_[3] );
                }
                
                
                if (done) 
                {
                

                    ADCo.CreateUserAccount(tbPseudo.Text.ToString(), tbPwd.Text.ToString());
                    

                    MessageBox.Show( Traducteur.traduction_[55] );

                    

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

        private void Form_Administration_Add_User_Load ( object sender , EventArgs e ) {

        }
    }
    
}
