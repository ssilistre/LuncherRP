namespace LeyjonRPLuncher
{
    partial class Luncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Luncher));
            this.resimKutusu = new System.Windows.Forms.PictureBox();
            this.btnOyna = new System.Windows.Forms.Button();
            this.slider_Zaman = new System.Windows.Forms.Timer(this.components);
            this.reklamMetni = new System.Windows.Forms.LinkLabel();
            this.hileKontrol = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.discord = new System.Windows.Forms.PictureBox();
            this.btnSorunGider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resimKutusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discord)).BeginInit();
            this.SuspendLayout();
            // 
            // resimKutusu
            // 
            this.resimKutusu.BackColor = System.Drawing.Color.Transparent;
            this.resimKutusu.ImageLocation = "https://i.hizliresim.com/KT3m45.png";
            this.resimKutusu.Location = new System.Drawing.Point(-2, 76);
            this.resimKutusu.Name = "resimKutusu";
            this.resimKutusu.Size = new System.Drawing.Size(698, 255);
            this.resimKutusu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimKutusu.TabIndex = 0;
            this.resimKutusu.TabStop = false;
            this.resimKutusu.Click += new System.EventHandler(this.resimKutusu_Click);
            // 
            // btnOyna
            // 
            this.btnOyna.AutoEllipsis = true;
            this.btnOyna.BackColor = System.Drawing.Color.Transparent;
            this.btnOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyna.ForeColor = System.Drawing.Color.White;
            this.btnOyna.Location = new System.Drawing.Point(561, 374);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(121, 42);
            this.btnOyna.TabIndex = 1;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // slider_Zaman
            // 
            this.slider_Zaman.Enabled = true;
            this.slider_Zaman.Interval = 10000;
            this.slider_Zaman.Tick += new System.EventHandler(this.slider_Zaman_Tick);
            // 
            // reklamMetni
            // 
            this.reklamMetni.AutoSize = true;
            this.reklamMetni.BackColor = System.Drawing.Color.Transparent;
            this.reklamMetni.Location = new System.Drawing.Point(429, 337);
            this.reklamMetni.Name = "reklamMetni";
            this.reklamMetni.Size = new System.Drawing.Size(16, 17);
            this.reklamMetni.TabIndex = 2;
            this.reklamMetni.TabStop = true;
            this.reklamMetni.Text = "..";
            this.reklamMetni.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reklamMetni_LinkClicked);
            // 
            // hileKontrol
            // 
            this.hileKontrol.Interval = 1000;
            this.hileKontrol.Tick += new System.EventHandler(this.hileKontrol_Tick);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(432, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "SteamID Gir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Online Oyuncu :";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.BackColor = System.Drawing.Color.Transparent;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.ForeColor = System.Drawing.Color.White;
            this.lblSayi.Location = new System.Drawing.Point(123, 334);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(18, 20);
            this.lblSayi.TabIndex = 5;
            this.lblSayi.Text = "0";
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.Transparent;
            this.discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discord.ImageLocation = "https://cdn.icon-icons.com/icons2/1476/PNG/512/discord_101785.png";
            this.discord.Location = new System.Drawing.Point(638, 35);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(44, 38);
            this.discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.discord.TabIndex = 6;
            this.discord.TabStop = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // btnSorunGider
            // 
            this.btnSorunGider.AutoEllipsis = true;
            this.btnSorunGider.BackColor = System.Drawing.Color.Transparent;
            this.btnSorunGider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorunGider.ForeColor = System.Drawing.Color.White;
            this.btnSorunGider.Location = new System.Drawing.Point(10, 374);
            this.btnSorunGider.Name = "btnSorunGider";
            this.btnSorunGider.Size = new System.Drawing.Size(170, 42);
            this.btnSorunGider.TabIndex = 7;
            this.btnSorunGider.Text = "Fivem Harita Düzelt";
            this.btnSorunGider.UseVisualStyleBackColor = false;
            this.btnSorunGider.Click += new System.EventHandler(this.btnSorunGider_Click);
            // 
            // Luncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 423);
            this.Controls.Add(this.btnSorunGider);
            this.Controls.Add(this.discord);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reklamMetni);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.resimKutusu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Luncher";
            this.Resizable = false;
            this.Text = "Fivem Luncher | SSilistre";
            this.Theme = "Dark";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Luncher_FormClosing);
            this.Load += new System.EventHandler(this.Luncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resimKutusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resimKutusu;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Timer slider_Zaman;
        private System.Windows.Forms.LinkLabel reklamMetni;
        private System.Windows.Forms.Timer hileKontrol;
        private string ip_ana;
        private string port_ana;
        private object definedPrograms;
        private object gorseller;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.PictureBox discord;
        private System.Windows.Forms.Button btnSorunGider;
    }
}