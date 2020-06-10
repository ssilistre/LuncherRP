using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fivemLuncher;

namespace Robin_Launcher
{
    public partial class index_1 : Form
    {
        lib rp = new lib();
        string serverkey = "5ed2c4571b902";
        public index_1()
        {
            InitializeComponent();
            rp.serverinfos(serverkey);
            rp.takeonlinelist(serverkey);

        }
        private void index_1_Load(object sender, EventArgs e)
        {
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

            foreach (var result in rp.list)
            {
                lstOyunListesi.Items.Add(result.ToString());
            }

            foreach (var liste in rp.list)
            {

            }

            lblOyuncuSayisi.Text = rp.KisiSayisi.ToString();
            lblDuyuruMetni.Text = rp.duyurular;
            rp.update();
            //rp.cacheDelete(); cache silmek için.

        }

        private void hileKoruma_Tick(object sender, EventArgs e)
        {
            rp.stopHacks();
        }
        private void travisoynat_Tick(object sender, EventArgs e)
        {
            int width = this.Width; // get the width of Form.

            if (travis.Location.X > width - travis.Width) //to check condition if pic box is touch the boundroy of form width
            {
                travis.Location = new Point(1, travis.Location.Y); // pic box is set to the new point. here 1 is indicate of X coordinate.
            }
            else
            {
                travis.Location = new Point(travis.Location.X -1, travis.Location.Y); // to move picture box from x coordinate by 100 Point.
            }



            if (travis.Location.X==750)
            {
                travisoynat2.Enabled = true;
                travisoynat.Enabled = false;
            }
        }

        private void travisoynat2_Tick(object sender, EventArgs e)
        {
            int width = this.Width; // get the width of Form.

            if (travis.Location.X > width - travis.Width) //to check condition if pic box is touch the boundroy of form width
            {
                travis.Location = new Point(1, travis.Location.Y); // pic box is set to the new point. here 1 is indicate of X coordinate.
            }
            else
            {
                travis.Location = new Point(travis.Location.X + 1, travis.Location.Y); // to move picture box from x coordinate by 100 Point.
            }



            if (travis.Location.X == 799)
            {
                travisoynat.Enabled = true;
                travisoynat2.Enabled = false;
            }
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            try
            {
                rp.connectWithPanel(serverkey);
                hileKoruma.Enabled = true;
               // rp.ts3open("ts3server://ipadresin"); TS3 Açtırma komutu kullanmak isterseniz başındaki // kaldırınız.

            }
            catch (Exception)
            {

                rp.backupSystem("Sunucu ip adresin", "port adresin genelde 30120");
                hileKoruma.Enabled = true;
            }
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            rp.discordopen("davet linki");
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
            if (this.WindowState== FormWindowState.Minimized)
            {
                travisoynat.Enabled = false;
                travisoynat2.Enabled = false;
            }
        }
    }
}
