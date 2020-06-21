using fivemLuncher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuancherFivemcode
{
    public partial class Form1 : Form
    {
        lib rp = new lib();
        Point lastPoint;
        string serverkey = "184255ee7be71f2e9e";//https://panel.fivemcode.com Keyinizi yapıştırın.
        public Form1()
        {
            /////////Bu kısmı ellemeyiniz.//////////////////
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray;
            TransparencyKey = Color.Gray;
            rp.serverinfos(serverkey);
            /////////Bu kısmı ellemeyiniz.//////////////////
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblDuyuru.Text = rp.duyurular; // Duyuruları çeken kod.
            lblonline.Text = rp.KisiSayisi.ToString(); ///kişi sayısını çeken kod.

            Lang.steamhata = "Lütfen Önce Steam Uygulamasını Başlatın"; //Please firt of open steam.
            Lang.hatalimesajbaslik = "Dikkat dikkat !"; //Error Header Message
            Lang.muzikhata = "Müzik Dosyası Bulunamadı"; //Play Music Not Found Error.
            Lang.panelhata = "Panel Sistemi ile iletişime geçilemedi !"; //Panel System ERROR
            Lang.steam64idgirinhatasi = "Lütfen Sadece Steam64 idsini giriniz."; // Steamid errorr
            Lang.cokfazlaistekhatasi = "Çok fazla istek gönderildi."; //To Much Post Request error.
            Lang.uygulamaacmahatasi = "Açmaya çalıştığınız şeyi bulamadık."; //Open Command error
            Lang.internethatasi = "İnternet bağlantınız bulunamadı."; //Internet Connection Errror.

            rp.DicordRC("Sunucu Adınız", "İkinci Mesajınız", "Üçüncü Mesajınız");

            if (rp.sunucuDurum=="online")
            {
                sunucuDurum.BackColor = Color.Green;
            }
            else
            {
                sunucuDurum.BackColor = Color.Red;
            }
        }

        private void lblKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Prograı Küçülten Kod.
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            this.Close(); // Programı kapatan kod.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rp.closeFivem();
            rp.open("https://panel.fivemcode.com/tesekkurler.php"); //Bu kod internet sitesi açmak için örnek olarak eklenmiştir.
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblOyna_Click(object sender, EventArgs e)
        {
            try
            {
                rp.connectWithPanel(serverkey); // bu panel bağlantılı şekilde sunucunuzu açan kod.
            }
            catch (Exception)
            {

                rp.backupSystem("ip adresin", "30120"); // Yedekleme sistemi ip adresini ve portunu yazıyorsun.
            }
        }

        private void btndiscord_Click(object sender, EventArgs e)
        {
            try
            {
                rp.discordopen("discord davet linkin"); /// discordu açar.
            }
            catch (Exception)
            {

                rp.open("discord davet linkin"); // buda ne olur ne olmaz discordu açan kod.
            }
        }

        private void btnts3_Click(object sender, EventArgs e)
        {
            rp.ts3open("ip adresin"); // ts3 açıpbaşlatır.
        }
    }
}
