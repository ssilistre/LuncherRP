using DiscordRPC;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fivemLuncher
{

    public class lib
    {
      
        [DllImport("psapi.dll")]
        private static extern bool EmptyWorkingSet(IntPtr hProcess);
        Settings s = new Settings();
        
        public DiscordRpcClient Client { get; private set; }

        void Setup()
        {
            Client = new DiscordRpcClient(jsonClass.discordrc);  
            Client.Initialize();                                 
        }
        void Update()
        {
            //Invoke the events once per-frame. The events will be executed on calling thread.
            Client.Invoke();
        }
        /* Bütün Tanımlamalar ve Ayarlar*/
       
          
         
        public string  duyurular = "";
        long steamnewid =0;
        private string kayitliSteamid = Properties.Settings.Default.steamid;
        private string ts3 = "";
        private string discord = "";
        public string weebhook = "";
        public List<string> list = new List<string>();
        

        /* Bütün Tanımlamalar ve Ayarlar*////
        /*********************************/
        /*********************************/
        /*********************************/
        /*********************************/
        public lib()
        {
             
        }
        /***********************************
        * 
        * 
        * Github: https://github.com/ssilistre/LuncherRP
        * 
        * 
        * ********************************/
        /*********************************/
        /*******Public Olanlar*********/
        /*********************************
        /*********************************/
       
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
                    steamnewid = Steam32ToSteam64(SteamLogin());
                    guncelleme();
                }
                else
                {
                    MessageBox.Show(Lang.internethatasi, Lang.hatalimesajbaslik, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    closeFivem();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       
        public void closeFivem()
        {

            try
            {
                foreach (var process in Process.GetProcessesByName("FiveM"))
                {
                    process.Kill();


                }
            }
            catch (Exception)
            {

                 
            }
        }
        public void connectFivem(string ipNumber ,string portNumber)
        {
          
            open("http://api.fivemcode.com/connect_direct?ip=" + ipNumber + "&port="+ portNumber);
        }
        public void open(string link)
        {
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception)
            {

                MessageBox.Show(Lang.uygulamaacmahatasi,Lang.hatalimesajbaslik);
            }
        }
        public void ts3open()
        {
            try
            {
                    open("ts3server://" + ts3);
      
            }
            catch (Exception)
           {

                MessageBox.Show(Lang.uygulamaacmahatasi, Lang.hatalimesajbaslik);
         }


        }
        public void discordopen()
        {
            try
            {
            open(discord);
            }
            catch (Exception)
            {

                MessageBox.Show(Lang.uygulamaacmahatasi, Lang.hatalimesajbaslik);
            }
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
                MessageBox.Show(Lang.cokfazlaistekhatasi,Lang.hatalimesajbaslik);
            }
        }
        public void DicordRC(string serverName,string secMsg,string thirdMsg)
        {


            try
            {
                Setup();
                Update();
                Client.SetPresence(new RichPresence()
                {
                    Details = serverName.ToString(),
                    State = secMsg.ToString(),
                    Assets = new Assets()
                    {
                        LargeImageKey = jsonClass.discordRCbuyukResim,
                        LargeImageText = thirdMsg.ToString(),
                        SmallImageKey = jsonClass.discordRCkucukResim
                    }
                });
            }
            catch (Exception)
            {

               
            }
          
        }
        public void steamid64(string hexid)
        {
            try
            {
                long sayi = Convert.ToInt64(hexid.Trim());
                String b = Convert.ToString(sayi, 16);
                string c = "steam:" + b;
                Properties.Settings.Default.steamid = c;
                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {

                MessageBox.Show(Lang.steam64idgirinhatasi,Lang.hatalimesajbaslik);
            }
        }     
        public void guncelleme()
        {
            try
            {
                string v = Application.ProductVersion;
                if (v != jsonClass.version)
                {
                    MessageBox.Show(Lang.yeniguncellemeuyarisi.ToString());
                    open(jsonClass.guncellemelink);
                }
            }
            catch (Exception)
            {

                 
            }

        }
        public void anticheat()
        {

            try
            {
                foreach (var item in jsonClass.liste)
                {
                    var process = Process.GetProcesses().Where(x =>
                    x.ProcessName.ToLower().StartsWith(item) ||
                    x.ProcessName.ToLower().Contains(item) ||
                    x.ProcessName.ToLower() == item ||
                    x.MainWindowTitle.ToLower() == item);
                    if (process.Any())
                    {

                        process.ToList().ForEach(x => x.Kill());

                    }
                }
            }
            catch (Exception)
            {

                
            }



        }
        public void connectWithPanel(String serverkey)
        {
            try 
            {
                 
                 
                kayitliSteamid = SteamLogin();
                steamnewid = Steam32ToSteam64(SteamLogin());
                long sayi = Convert.ToInt64(steamnewid);
                String b = Convert.ToString(sayi, 16);
                string value = "steam:" + b;
             
              connectionOutSide.getRegister(s.luncherReg_url, serverkey, value, steamnewid.ToString(), "1");
              System.Diagnostics.Process.Start(s.connect+serverkey);
 

            }
            catch (Exception)
            {
                MessageBox.Show(Lang.panelhata,Lang.hatalimesajbaslik,MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }    
        private string SteamLogin()
        {
            return "U:1:" + Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Valve").OpenSubKey("Steam").OpenSubKey("ActiveProcess").GetValue("ActiveUser").ToString();
        }
        public string steamusername()
        {
            return ""+Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Valve").OpenSubKey("Steam").GetValue("AutoLoginUser").ToString();
        }
        private static byte[] Post(string uri, NameValueCollection pairs)
        {
            using (WebClient webClient = new WebClient())
                return webClient.UploadValues(uri, pairs);
        }
        private static long Steam32ToSteam64(string input)
        {
            long steam32 = Convert.ToInt64(input.Substring(4));
            if (steam32 < 1L || !Regex.IsMatch("U:1:" + steam32.ToString((IFormatProvider)CultureInfo.InvariantCulture), "^U:1:([0-9]{1,10})$"))
            {
                return 0;
            }
            return steam32 + 76561197960265728L;
        }
        public string steamhexid()
        {
            kayitliSteamid = SteamLogin();
            steamnewid = Steam32ToSteam64(SteamLogin());
            long sayi = Convert.ToInt64(steamnewid);
            String b = Convert.ToString(sayi, 16);
            string value = "steam:" + b;

             

            return value;
        }
        
    }

}
 
 
