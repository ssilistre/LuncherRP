using fivemLuncher;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace LeyjonRPLuncher
{
    public partial class Luncher : Form
    {
        lib rp = new lib();
        String serverkey = "5ea5fc0139789";
        String DiscordRCSunucuAD = "Sunucu Adınız";
        String DiscordRCAltMesaj = "AltMesajınız.";
        public Luncher()
        {
            //****************************************
            InitializeComponent();
            //****************************************
        }
        private void Luncher_Load(object sender, EventArgs e)
        {
         
            rp.serverinfos(serverkey); //this command will be check all server infos for online count & ip adress port.
            this.TransparencyKey = Color.LightGreen;
            this.BackColor = Color.LightGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
             
            lblduyurumetni.Text = rp.duyurular; //news
            lblSayi.Text = rp.kisiSayisi; //player count
            lblStatu.Text = rp.sunucuDurum; //server status
            rp.DicordRC(DiscordRCSunucuAD, DiscordRCAltMesaj); //Discord RC
            if (lblStatu.Text=="online")
            {
                lblStatu.ForeColor = Color.Green;
            }
            else
            {
                lblStatu.ForeColor = Color.Red;
            }
            Steamusername.Text = rp.SteamUserName; //Steam name.
        }
        private void Luncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            rp.closeFivem(); // When closing form - close to fivem.
        }
       
       
        private void hileKontrol_Tick(object sender, EventArgs e)
        {
            rp.stopHacks(); //Hack & tools blocked. If find any working hack pls create issue on github.
            //StopHacks kodu hileleri kontrol eden kod bloğu.
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            rp.connectWithOutWhitelist(serverkey); //İf use whitelist panel.fivemcode.com used this block.
            //rp.connectWithOutWhitelist("5ea41ddb8a15b"); //without whitlist use this block.
           // rp.connectFivem("İp Number", "Port Number"); //if just connect server pls use this block.
            hileKontrol.Enabled = true;
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Luncher_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Luncher_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnTS3_Click(object sender, EventArgs e)
        {
            rp.open("ts3server://ipadress");
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            rp.open("discordadresin");
        }

        private void imageLogo_MouseLeave(object sender, EventArgs e)
        {
            logoBuyuk.Visible = false;
         
        }

        private void imageLogo_MouseMove(object sender, MouseEventArgs e)
        {
            logoBuyuk.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rp.connectwithWhiteList(serverkey);
        }
    }
}
    