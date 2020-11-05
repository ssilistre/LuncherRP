using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fivemLuncher
{
    class minecraft
    {
        Settings s = new Settings();

        public DiscordRpcClient Client { get; private set; }

        public string sunucuDurum = "";
        public string duyurular = "";
        public int KisiSayisi = 0;
        private string _serverkey = "";
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

        public void startminecraft(string ip, string port)
        {
            string appData = Environment.GetEnvironmentVariable("APPDATA");

            Process.Start(@"java",
              @"-Xms512m -Xmx1024m -cp """ + appData + @"\.minecraft\bin\*"" -Djava.library.path=""" + appData + @"\.minecraft\bin\natives"" net.minecraft.client.Minecraft");

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
        public void showBalloon(string title, string body)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;

            if (title != null)
            {
                notifyIcon.BalloonTipTitle = title;
            }

            if (body != null)
            {
                notifyIcon.BalloonTipText = body;
            }

            notifyIcon.ShowBalloonTip(30000);
        }
        public void serverinfos(String serverkey)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {

                     connectionOutSide.getPostAsync(s.luncherinfo_url, serverkey);

                  
                    _serverkey = serverkey;
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
    }
}
