using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fivemLuncher;

namespace Robin_Launcher
{
    public partial class index_1 : Form
    {
        lib rp = new lib();
        string serverkey = "5f953432ea5b467b3370";
        public index_1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
              
            rp.serverinfos(serverkey);
            

        }
        private void index_1_Load(object sender, EventArgs e)
        {
            
            lblDuyuruMetni.Text = rp.duyurular;
            rp.DicordRC("FivemCode", "Panel System", "3.Mesaj");
             
            //Lang Settings;

            Lang.steamhata = "Lütfen Önce Steam Uygulamasını Başlatın"; //Please firt of open steam.
            Lang.hatalimesajbaslik = "Dikkat dikkat !"; //Error Header Message
            Lang.muzikhata = "Müzik Dosyası Bulunamadı"; //Play Music Not Found Error.
            Lang.panelhata = "Panel Sistemi ile iletişime geçilemedi !"; //Panel System ERROR
            Lang.steam64idgirinhatasi = "Lütfen Sadece Steam64 idsini giriniz."; // Steamid errorr
            Lang.cokfazlaistekhatasi = "Çok fazla istek gönderildi."; //To Much Post Request error.
            Lang.uygulamaacmahatasi = "Açmaya çalıştığınız şeyi bulamadık."; //Open Command error
            Lang.internethatasi = "İnternet bağlantınız bulunamadı."; //Internet Connection Errror.

            //////////////////////////
            ///

      
            
           

        }

        private void hileKoruma_Tick(object sender, EventArgs e)
        {
            if (anticheat.IsBusy != true)
            {
                /* Eğer backgroundWorker1 meşgul değilse yani işlem yapmıyorsa, butona bastığımda asenkron olacak bu işlemi başlatsın. 
                 Asenkron işlem başlatmak yeni bir thread açmaktır yani basitçe açıklayacak olursak çalışan hiçbir farklı
                 işlemi beklemeden kullanıcının istediği anda işlemin başlamasıdır. */
                anticheat.RunWorkerAsync();
            }

             
            //backgroundWorker1.RunWorkerAsync();

        }


        private void btnOyna_Click(object sender, EventArgs e)
        {
            hileKoruma.Enabled = true;
                rp.connectWithPanel(serverkey);
             
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            rp.discordopen();
        }

        private void index_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rp.closeFivem();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void anticheat_DoWork(object sender, DoWorkEventArgs e)
        {
            rp.anticheat();
        }
    }
}
