using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarp {

    static class Session {

        static int idUser_;
        static string name_;
        static string firstName_;
        static string email_;
        static string password_;
        static string pseudo_;
        static string language_;        
        static bool isOrganizer_;
        static bool isAdmin_;

        static public int ID {
            get { return idUser_; }
            set { idUser_ = value; }
        }

        static public string name {
            get { return name_;  }
            set { name_ = value; }
        }

        static public string firstname {
            get { return firstName_; }
            set { firstName_ = value; }
        }

        static public string email {
            get { return email_; }
            set { email_ = value; }
        }

        static public string password {
            get { return password_; }
            set { password_ = value; }
        }

        static public string pseudo {
            get { return pseudo_; }
            set { pseudo_ = value; }
        }

        static public string language {
            get { return language_; }
            set { language_ = value;}
        }

        static public bool isOrganizer {
            get { return isOrganizer_; }
            set { isOrganizer_ = value; }
        }

        static public bool isAdmin {
            get { return isAdmin_; }
            set { isAdmin_ = value; }
        }

        static public void clear () {

            Session.ID = -1;
            Session.name = "non défini";
            Session.firstname = "non défini";
            Session.email = "non défini";
            Session.password = "non défini";
            Session.pseudo = "non défini";
            Session.language = "fr";
            Session.isAdmin = false;
            Session.isOrganizer = false;

        }

    }
}
