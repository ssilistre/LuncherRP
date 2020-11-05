using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fivemLuncher
{
    public class mta
    {
        Settings s = new Settings();

        public DiscordRpcClient Client { get; private set; }

        public string sunucuDurum = "";
        public string duyurular = "";
        public int KisiSayisi = 0;
        private string ts3 = "";
        private string discord = "";
        public string weebhook = "";
        private string api = "";
        public List<string> list = new List<string>();

        void Setup()
        {
            Client = new DiscordRpcClient(jsonClass.discordrc);  //Creates the client
            Client.Initialize();                            //Connects the client
        }
        void Update()
        {
            //Invoke the events once per-frame. The events will be executed on calling thread.
            Client.Invoke();
        }

        public void startmta(string ip,string port)
        {
            Process.Start("mtasa://" + ip + ":" + port);

        }

        public void mtapanel()
        {
            System.Diagnostics.Process.Start("mtasa://" + jsonClass.ip + ":" + jsonClass.port);
        }
        public void open(string link)
        {
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception)
            {

                
            }
        }
        public void serverinfos(String serverkey)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {

                   connectionOutSide.getPostAsync(s.luncherinfo_url, serverkey);

                  
                
                    duyurular = jsonClass.duyurular;
                   
                    ts3 = jsonClass.ts3;
                    discord = jsonClass.discord;
                   
                   

                    Update();

                }
                else
                {
                  
                }
            }
            catch (Exception)
            {



            }
        }
        private static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient webClient = new WebClient())
                return webClient.UploadValues(uri, pairs);
        }
        public void discordMsg(string URL, string msg)
        {
            try
            {
                _ = Post(URL, new NameValueCollection()
        {
                { "username",
                   jsonClass.discordbot
                },
                {  "avatar_url",
                    jsonClass.avatarurl

                },
                {
                    "content",
                    msg
                },
            });

            }
            catch (Exception)
            {
                MessageBox.Show(Lang.cokfazlaistekhatasi, Lang.hatalimesajbaslik);
            }
        }
    }
}
