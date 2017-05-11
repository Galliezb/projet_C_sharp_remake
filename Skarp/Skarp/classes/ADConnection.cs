using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;

namespace Skarp.classes
{
    class ADConnection
    {
        public ADConnection() { }
       
        public void createUser(string fullname, string name, string firstname, string pass,string mail,string description)
        {
            try
            {
                
                DirectoryEntry Ldap = new DirectoryEntry("LDAP://192.168.1.54", "Administrateur", "Password1");
                DirectoryEntry userADCreated = Ldap.Children.Add("cn=" + fullname, "user");

                userADCreated.Properties["SAMAccountName"].Add(fullname);

                userADCreated.Properties["sn"].Add(firstname);

                userADCreated.Properties["givenName"].Add(name);
                userADCreated.Properties["mail"].Add(mail);
                userADCreated.Properties["description"].Add(description);


                // On envoie les modifications au serveur

                userADCreated.CommitChanges();



                // On va maintenant lui définir son password. L'utilisateur doit avoir été créé

                // et sauvé avant de pouvoir faire cette étape
                userADCreated.CommitChanges();
                userADCreated.Invoke("SetPassword", new object[] { pass });

                // On va maintenant activer le compte : ADS_UF_NORMAL_ACCOUNT

                userADCreated.Properties["userAccountControl"].Value = 0x0200;

                /* foreach ( PropertyCollection p in userADCreated.Properties.PropertyNames ) {
                     MessageBox.Show(p.Values.ToString()) ;
                 }*/


                // On envoie les modifications au serveur
                userADCreated.CommitChanges();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }

  
}
