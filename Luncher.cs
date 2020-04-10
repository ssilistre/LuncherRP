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
            //****************************************
        }
        private void Luncher_Load(object sender, EventArgs e)
        {
            reklamMetni.Text = LuncherRP.ReklamMetni;
            slider_Zaman.Enabled = true;
            
            lblSayi.Text=LuncherRP.onlinekackisi("55e90ad9a6defa"); //Bu kaç kişi olduğunu yazar.
            LuncherRP.DicordRC("Sunucu adi buraya yaziniz.", ""); //Discord durumunu değiştirmenize yarar ikinci "" tırnağı boş bırakırsı
            LuncherRP.guncellemekontrolet();

        }
        private void Luncher_FormClosing(object sender, FormClosingEventArgs e)
        {
           LuncherRP.kapatProgrami();
        }
        private void btnOyna_Click(object sender, EventArgs e)
        {
                 LuncherRP.luncherozelgiris("55e90ad9a6defa");
                //LuncherRP.sunucuyabaglan(LuncherRP._oyunip, LuncherRP._oyunport);
                hileKontrol.Enabled = true;
                LuncherRP.optimizeYap();//Bilgisayarınızı optimize eder.
        }
        private void slider_Zaman_Tick(object sender, EventArgs e)
        {
            try
            {
                if (resimsayisi ==1)
                {
                    resimKutusu.ImageLocation = "Resim adresi 1";
                    resimsayisi = 2;

                }
                else if (resimsayisi == 2)
                {
                    resimKutusu.ImageLocation = "Resim adresi 2";
                    resimsayisi = 3;
                }
                else if (resimsayisi == 3)
                {
                    
                    resimKutusu.ImageLocation = "Resim adresi 3";
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
           LuncherRP.steamidgirformu();    //formu görmek istemiyorsanız.
            //kendi kodlamınızı yapıp şu komutu kullanabilirsiniz.
              //  LuncherRP.steamidgir("64ID buraya gelmeli kullanıcan steam64 id istemeyi size bırakıyorum.");
            //Yapmak istemezeniz LuncherRP.steamidgirformu(); kullanınız.

        }
        private void button2_Click(object sender, EventArgs e)
        {
          
        }
        private void discord_Click(object sender, EventArgs e)
        {
          LuncherRP.linkac("discord davet linkini buraya ekle.");
        }
        private void resimKutusu_Click(object sender, EventArgs e)
        {

        }

        private void btnSorunGider_Click(object sender, EventArgs e)
        {
            LuncherRP.DizinSec();
        }
    }
}
    