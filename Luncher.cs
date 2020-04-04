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
            InitializeComponent();
            LuncherRP.servisKontrol();
        }

        private void Luncher_Load(object sender, EventArgs e)
        {
            reklamMetni.Text = LuncherRP.ReklamMetni;
            slider_Zaman.Enabled = true;
        }

        private void Luncher_FormClosing(object sender, FormClosingEventArgs e)
        {
           LuncherRP.kapatProgrami();
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
              this.WindowState = FormWindowState.Minimized;
              hileKontrol.Enabled = true;

            //LuncherRP.sunucuyabaglan("İp Numarasi", "PortNo");
            LuncherRP.leyjonrpgiris(); //bunu kullanmanıza gerek yok :)
        }
        private void slider_Zaman_Tick(object sender, EventArgs e)
        {
            if (resimsayisi==LuncherRP.gorseller.Length)
            {
                resimsayisi = 0;
                resimKutusu.ImageLocation = LuncherRP.gorseller[resimsayisi];
               
            }
            else
            {
                resimKutusu.ImageLocation = LuncherRP.gorseller[resimsayisi];
                resimsayisi++;
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
    }
}
    