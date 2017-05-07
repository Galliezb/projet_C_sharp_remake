using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Skarp {

    public static class Traducteur {

        static public List<string> traduction_ = new List<string>();
        /*
        public string traduction{
            get { }
            set { }
        }
        */
        static public void loadText(string language ) {

            traduction_.Clear();
            traduction_ = File.ReadAllLines( @"..\..\language\"+ language +".txt" ).ToList();

            // permet de voir combien de lignes ont été chargé et le dernier élément
            // MessageBox.Show( traduction_.Count.ToString() );
            //MessageBox.Show( traduction_[traduction_.Count-1].ToString() );

        }
        
    }
}
