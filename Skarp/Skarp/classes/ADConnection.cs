using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Configuration;
namespace Skarp.classes
{
    class ADConnection
    {
        public ADConnection() { }





        public void AddToGroup(string user)
        {
            try
            {
                DirectoryEntry dirEntry = new DirectoryEntry("LDAP://10.11.1.143/ CN=groupe,OU=nosUser,DC=EVILCORP,DC=COM", "Administrateur", "Azer123");
                dirEntry.Properties["member"].Add("CN=" + user + ",OU=nosUser,DC=EVILCORP,DC=com");
                dirEntry.CommitChanges();
                dirEntry.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                Console.Write(E.Message.ToString());

            }
        }
        public string CreateUserAccount(string userName, string userPassword)
        {
            string oGUID = string.Empty;
            try
            {

                string connectionPrefix = "LDAP://192.168.1.54/ OU=nosUtilisateurs,dc=BBN,dc=be";
                DirectoryEntry dirEntry = new DirectoryEntry(connectionPrefix, "Administrateur", "Password1");
                DirectoryEntry newUser = dirEntry.Children.Add("CN=" + userName, "user");

                newUser.Properties["samAccountName"].Value = userName;
                newUser.CommitChanges();

                oGUID = newUser.Guid.ToString();

                newUser.Invoke("SetPassword", new object[] { userPassword });
                newUser.CommitChanges();

                newUser.Properties["userAccountControl"].Value = 0x0200;

                newUser.CommitChanges();
                AddToGroup(userName);
                dirEntry.Close();
                newUser.Close();

            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {


            }
            return oGUID;
        }



        public void createUser(string fullname, string name, string firstname, string pass, string mail, string description)
        {
            try
            {

                DirectoryEntry Ldap = new DirectoryEntry("LDAP://192.168.1.54/", "Administrateur", "Password1");
                DirectoryEntry userADCreated = Ldap.Children.Add("cn=" + fullname, "user");
                //DirectoryEntry group = Ldap.Children.Find("nosUsers");
                userADCreated.Properties["SAMAccountName"].Add(fullname);

                userADCreated.Properties["sn"].Add(firstname);

                userADCreated.Properties["givenName"].Add(name);
                userADCreated.Properties["mail"].Add(mail);
                userADCreated.Properties["description"].Add(description);


                // On envoie les modifications au serveur

                userADCreated.CommitChanges();



                // On va maintenant lui définir son password. L'utilisateur doit avoir été créé

                // et sauvé avant de pouvoir faire cette étape

                userADCreated.Invoke("SetPassword", new object[] { pass });
                userADCreated.Properties["nosUsers"].Add(userADCreated);
                // On va maintenant activer le compte : ADS_UF_NORMAL_ACCOUNT

                userADCreated.Properties["userAccountControl"].Value = 0x0200;
                //  group.Properties["member"].Add(userADCreated);
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





        public void AddToActiveDirectory(string fullname, string name, string firstname, string pass, string mail, string description)// UserName, string login, string password, string Nom, string Prenom, string Societe, string mail)
        {
            try
            {
                MessageBox.Show("Le try fonctionne");
                // ok donc on sait qu'on rentre ici. On va donc s'assurer de la BDD, car on sait qu'elle est fonctionnelle.
                // la BDD c'était plus loin en fait :D


                //string sUserPath = "LDAP://OU=Membres,OU=TestOu,DC=MachineDomain,DC=Fr";
                string sUserPath = System.Configuration.ConfigurationManager.AppSettings["LDAP://192.168.1.54:389/CN=nosUtilisateurs,DC=BNN,DC=be"];

                // on passe les params de login /password d'un compte NT à pouvoir sur AD
                DirectoryEntry entry = new DirectoryEntry(sUserPath,
                     System.Configuration.ConfigurationManager.AppSettings["Administrateur"],
                     System.Configuration.ConfigurationManager.AppSettings["Password1"]);

                // On cré le user avec ses propriétés
                //--------------------------------------------
                DirectoryEntry user = entry.Children.Add("cn=" + fullname, "user");
                user.Properties["sAMAccountName"].Add(fullname);  //compte NT
                user.Properties["sn"].Add(name);
                user.Properties["givenName"].Add(firstname);
                user.Properties["description"].Add("Membre ajouté le " + DateTime.Now.ToLongDateString());

                //propriétés supplémentaires
                //--------------------------------------------
                user.Properties["displayName"].Add(name + " " + firstname);
                user.Properties["userPrincipalName"].Add(string.Format("{0}@{1}", fullname, System.Configuration.ConfigurationManager.AppSettings["BNN.be"]));   // Mail de login
                user.Properties["Mail"].Add(mail);

                // et le try plante certainement ici
                // tu peux le ping sur le port 389 ? tu peux ping un port 
                // c'est ce que je me demande aussi , go goole :D j pene pas
                user.CommitChanges();

                // lui retourne un objet, on va essayer de voir ce qu'il retourne
                // On doiy a rient d'abord sauver l'utilisateur pour ensuite lui affecter un password
                //lol , ouep c'est trop bizarre, il aurait du au moins être vide !
                object tkitoi = user.Invoke("SetPassword", new object[] { pass });
                // mais ? mais ? C'est quoi
                MessageBox.Show("Mon textbox tkitoi : " + tkitoi.ToString());

                // on crée un compte de base et on l'active ADS_UF_NORMAL_ACCOUNT
                user.Properties["userAccountControl"].Value = 0x200;
                user.CommitChanges();

                //On fait une référence au groupe NT
                //string LDAPDomain = "LDAP://192.168.1.54/CN=nosUser,CN=nosUtilisateurs,DC=BNN,DC=be";
                string LDAPDomain = System.Configuration.ConfigurationManager.AppSettings["nosUser"];

                DirectoryEntry Group = new DirectoryEntry(LDAPDomain,
                  System.Configuration.ConfigurationManager.AppSettings["Administrateur"],
                  System.Configuration.ConfigurationManager.AppSettings["Password1"]);

                
                //on ajoute l'utilisateur au groupe
                Group.Invoke("Add", new Object[] { user.Path.ToString() });
                Group.CommitChanges();

                Group.Close();
                user.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
