using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace fivemLuncher
{
    class connectionOutSide
    {
        internal static void getPostAsync(String url, String serverkey)
        {
            var link = url + serverkey;
            
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(link);
                    jsonClass _json = JsonConvert.DeserializeObject<jsonClass>(json);
                    // Now parse with JSON.Net
                }
          
            
             /*
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(link);
                jsonClass _json = JsonConvert.DeserializeObject<jsonClass>(json);
            }

            */
            
                     
        }

        internal static void getRegister(String url, String serverkey, String value, String steamnewid, String Durum)
        {


            try
            {
                var link = url + serverkey + "&steamhexid=" + value + "&steam64id=" + steamnewid + "&online=0&durum=" + Durum;
                using (WebClient wc = new WebClient())
                {
                    var json1 = wc.DownloadString(link);
                   
                    // Now parse with JSON.Net
                }
                
                
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.ToString());
            }

        }


    }
}
