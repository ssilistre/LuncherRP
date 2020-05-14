using fivemLuncher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicLuancher
{
    public partial class Form1 : Form
    {
        lib rp = new lib();
        Point lastPoint;
        string serverkey = "5ebce9ea26180";
        public Form1()
        {
 
            InitializeComponent();
            rp.serverinfos(serverkey);
            this.TransparencyKey = Color.LightGreen;
            this.BackColor = Color.LightGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblv.Text = Application.ProductVersion;
            string sunucudurumum = rp.sunucuDurum;
            lblOnlineKisi.Text = rp.KisiSayisi.ToString();
            lblDuyuruMetni.Text = rp.duyurular;
            if (sunucudurumum == "online")
            {
                pictureDurum.BackColor = Color.Green;
            }
            else
            {
                pictureDurum.BackColor = Color.Red;
            }

            //rp.discordMsg("web hook linki", "Mesajın");
            rp.DicordRC("Sunucu Adı", "Sunucu Metini", "Allah ne verdiğğğğse");
        }

        private void pictureSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            rp.closeFivem();
        }

        private void pictureCloseSettings_Click(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
        }

        private void hileKoruma_Tick(object sender, EventArgs e)
        {
            rp.stopHacks();
        }

        private void btnCacheTemizleme_Click(object sender, EventArgs e)
        {
            rp.cacheDelete();
        }

        private void btnGuncellemeDenetle_Click(object sender, EventArgs e)
        {
            rp.update();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rp.open("discord davet linki");
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            hileKoruma.Enabled = true;

            rp.connectWithPanel(serverkey);
        }

        private void lblBaslik_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void lblBaslik_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
