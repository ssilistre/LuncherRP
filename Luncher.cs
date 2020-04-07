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
            LuncherRP._luncherBaslik = LuncherRP.VeriOku("Luncher", "Baslik");
            LuncherRP._weebHookLink = LuncherRP.VeriOku("WebHook", "DicordWebHookLink");
            LuncherRP._discordLink = LuncherRP.VeriOku("Luncher", "DiscordDavet");
            LuncherRP._oyunip = LuncherRP.VeriOku("Luncher", "Oyunip");
            LuncherRP._oyunport = LuncherRP.VeriOku("Luncher", "Oyunport");
            LuncherRP._ozelsunucuno = LuncherRP.VeriOku("Luncher", "ozelSunucuid");
            LuncherRP._reklamMetni = LuncherRP.VeriOku("Luncher", "ReklamMetni");
            LuncherRP._resim1Link = LuncherRP.VeriOku("Gorseller", "Resim1");
            LuncherRP._resim2Link = LuncherRP.VeriOku("Gorseller", "Resim2");
            LuncherRP._resim3Link = LuncherRP.VeriOku("Gorseller", "Resim3");
            //Ayarlar dosyasından verileri okumak için okumasını istemiyorsanız silebilirsiniz.
            //////////////////////////////////////////////**************************
        }

        private void Luncher_Load(object sender, EventArgs e)
        {
            reklamMetni.Text = LuncherRP.ReklamMetni;
            slider_Zaman.Enabled = true;
            lblSayi.Text = LuncherRP.onlineoyuncusayisi("123");
            this.Text = LuncherRP._luncherBaslik;


        }

        private void Luncher_FormClosing(object sender, FormClosingEventArgs e)
        {
           LuncherRP.kapatProgrami();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
         
              hileKontrol.Enabled = true;
              LuncherRP.sunucuyaozelbaglan(LuncherRP._ozelsunucuno, LuncherRP._oyunip, LuncherRP._oyunport);
              this.WindowState = FormWindowState.Minimized; //bu kod ekranı küçültür.

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
    