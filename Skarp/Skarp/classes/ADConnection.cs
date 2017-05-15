﻿using System;
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
                DirectoryEntry connectionAD = new DirectoryEntry("LDAP://192.168.1.54/ CN=groupeUtilisateurs,OU=nosUtilisateurs,DC=BNN,DC=BE","Administrateur","Password1");

               
                connectionAD.Properties["member"].Add("CN=" + user + ",OU=nosUtilisateurs,DC=BNN,DC=be");
                connectionAD.CommitChanges();
                connectionAD.Close();
            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                MessageBox.Show(E.Message.ToString());

            }
        }
        public string CreateUserAccount(string userName, string userPassword)
        {
            string guid_utilisateur = string.Empty;
            try
            {
               
                // on se connecte
                
                DirectoryEntry connectionAD = new DirectoryEntry("LDAP://192.168.1.54/ OU=nosUtilisateurs,DC=BNN,DC=be", "Administrateur","Password1");

               
                // crée un nouveau membre
                DirectoryEntry newUser = connectionAD.Children.Add("CN=" + userName, "user");
                // on définit ses proprité
                newUser.Properties["samAccountName"].Value = userName; // son nom de compte
                 
                // on enregistre les infos
                newUser.CommitChanges();

                guid_utilisateur = newUser.Guid.ToString();
                
                newUser.Invoke("SetPassword", userPassword);
                newUser.CommitChanges();

                newUser.Properties["userAccountControl"].Value = 0x0200; // user compte normal 
                newUser.CommitChanges();
                AddToGroup(userName);
                
                connectionAD.Close();
                newUser.Close();
               

            }
            catch (System.DirectoryServices.DirectoryServicesCOMException E)
            {
                MessageBox.Show("erreur try "+E.Message.ToString());
                
            }
            return guid_utilisateur;
        }

    }
}
