using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Web.Script.Serialization;
using System.Web;

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

        /// <summary>
        /// Hash les mots de passes
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        static public string Hash ( string password ) {
            var bytes = new UTF8Encoding().GetBytes( password );
            byte[] hashBytes;
            using ( var algorithm = new System.Security.Cryptography.SHA512Managed() ) {
                hashBytes = algorithm.ComputeHash( bytes );
            }
            return Convert.ToBase64String( hashBytes );
        }

        static public Dictionary<string,string> CiaSeeYou () {

            string ipAddress;
            using ( WebClient client = new WebClient() ) {
                ipAddress = client.DownloadString( "http://ipv4bot.whatismyipaddress.com/" );
            }

            string strQuery;
            string key = "demo";
            HttpWebRequest HttpWReq;
            HttpWebResponse HttpWResp;
            strQuery = "http://api.ip2location.com/?" + "ip=" + ipAddress + "&key=" + key + "&package=WS24&format=json";
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            HttpWReq = (HttpWebRequest) WebRequest.Create( strQuery );
            HttpWReq.Method = "GET";
            HttpWResp = (HttpWebResponse) HttpWReq.GetResponse();
            System.IO.StreamReader reader = new System.IO.StreamReader( HttpWResp.GetResponseStream() );
            string content = reader.ReadToEnd();
            dynamic item = serializer.Deserialize<object>( content );

            //displaying the result
            Dictionary<string , string> toReturn= new Dictionary<string , string>();



            toReturn.Add("ville", item["city_name"] );
            toReturn.Add("codePays", item["country_code"] );
            toReturn.Add("pays", item["country_name"] );
            toReturn.Add("region", item["region_name"] );
            toReturn.Add("latitude", item["latitude"] );
            toReturn.Add("longitude", item["longitude"] );
            toReturn.Add("zoneHoraire", item["time_zone"] );
            toReturn.Add("codePostal", item["zip_code"] );


            return toReturn;
        }


    }

}
