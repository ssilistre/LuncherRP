using fivemLuncher;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LeyjonRPLuncher
{
    public partial class Luncher : MetroForm
    {
        ayarlar LuncherRP = new ayarlar();
        int resimsayisi = 0;
        public Luncher()
        {
            //****************************************
            InitializeComponent();
            LuncherRP.servisKontrol();
            //////////////////////////////////////////////**************************
            /////////////////////////////////////////////////**************************
            /////////////////////////////////////////////////**************************
            LuncherRP._luncherBaslik = LuncherRP.VeriOku("Luncher", "Baslik");   //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._weebHookLink = LuncherRP.VeriOku("WebHook", "DicordWebHookLink"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._discordLink = LuncherRP.VeriOku("Luncher", "DiscordDavet"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
             LuncherRP._ozelsunucuno = LuncherRP.VeriOku("Luncher", "ozelSunucuid"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._oyunip = LuncherRP.VeriOku("Luncher", "Oyunip"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._oyunport = LuncherRP.VeriOku("Luncher", "Oyunport"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._reklamMetni = LuncherRP.VeriOku("Luncher", "ReklamMetni"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._resim1Link = LuncherRP.VeriOku("Gorseller", "Resim1"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._resim2Link = LuncherRP.VeriOku("Gorseller", "Resim2"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            LuncherRP._resim3Link = LuncherRP.VeriOku("Gorseller", "Resim3"); //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            //////////////////////////////////////////////**************************
        }

        private void Luncher_Load(object sender, EventArgs e)
        {
            reklamMetni.Text = LuncherRP.ReklamMetni;
            slider_Zaman.Enabled = true;
            
            this.Text = LuncherRP._luncherBaslik;
             lblSayi.Text= LuncherRP.onlinekackisi(LuncherRP._ozelsunucuno);
           // lblSayi.Text = LuncherRP.onlinekackisi("55e8e4d5cf0408");

        }

        private void Luncher_FormClosing(object sender, FormClosingEventArgs e)
        {
           LuncherRP.kapatProgrami();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (LuncherRP._ozelsunucuno == "0")
            {
                // LuncherRP.luncherozelgiris(LuncherRP._ozelsunucuno);
                LuncherRP.luncherozelgiris("55e8e4d5cf0408");
                hileKontrol.Enabled = true;

                this.WindowState = FormWindowState.Minimized; //bu kod ekranı küçültür.
            }
            else
            {
                LuncherRP.sunucuyabaglan(LuncherRP._oyunip,LuncherRP._oyunport);
            }
          

        }
        private void slider_Zaman_Tick(object sender, EventArgs e)
        {
            try
            {
                if (resimsayisi ==1)
                {
                    resimKutusu.ImageLocation = LuncherRP._resim1Link;
                    resimsayisi = 2;

                }
                else if (resimsayisi == 2)
                {
                    resimKutusu.ImageLocation = LuncherRP._resim2Link;
                    resimsayisi = 3;
                }
                else if (resimsayisi == 3)
                {
                    
                    resimKutusu.ImageLocation = LuncherRP._resim3Link;
                    resimsayisi = 0;
                }
                else
                {
                    resimsayisi = 1;
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void hileKontrol_Tick(object sender, EventArgs e)
        {
            LuncherRP.hileDurdur();
        }

        private void reklamMetni_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LuncherRP.linkac("https://www.fivemtr.net");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //

            
           LuncherRP.steamidgir();
          
            // results in "494809724602834812404472"
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void discord_Click(object sender, EventArgs e)
        {
          LuncherRP.linkac(LuncherRP._discordLink);
        }

        private void resimKutusu_Click(object sender, EventArgs e)
        {

        }
    }
}
    