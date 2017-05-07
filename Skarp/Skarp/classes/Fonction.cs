using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Skarp {
    static class Fonction {

        /// <summary>
        /// Centre la fenêtre windows envoyé en paramètre
        /// </summary>
        /// <param name="formToCenter">La fenêtre à centrer</param>
        static public void centerWindows (Form formToCenter) {
            formToCenter.Location = new Point( Screen.FromControl( formToCenter ).Bounds.Width / 2 - formToCenter.Size.Width / 2 ,
                      Screen.FromControl( formToCenter ).Bounds.Height / 2 - formToCenter.Size.Height / 2 );

        }


    }
}
