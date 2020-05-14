namespace BasicLuancher
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hileKoruma = new System.Windows.Forms.Timer(this.components);
            this.lblv = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnGuncellemeDenetle = new System.Windows.Forms.Button();
            this.pictureCloseSettings = new System.Windows.Forms.PictureBox();
            this.btnCacheTemizleme = new System.Windows.Forms.Button();
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.pictureSettings = new System.Windows.Forms.PictureBox();
            this.lblOnlineKisi = new System.Windows.Forms.Label();
            this.lblSunucuKacKisi = new System.Windows.Forms.Label();
            this.pictureDurum = new System.Windows.Forms.PictureBox();
            this.lblSunuDurum = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.PictureBox();
            this.lblBaslikYazisi = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDuyuruMetni = new System.Windows.Forms.Label();
            this.lblDuyuruBaslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOyna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBaslik)).BeginInit();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hileKoruma
            // 
            this.hileKoruma.Interval = 5000;
            this.hileKoruma.Tick += new System.EventHandler(this.hileKoruma_Tick);
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Location = new System.Drawing.Point(98, 370);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(16, 17);
            this.lblv.TabIndex = 18;
            this.lblv.Text = "0";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(9, 370);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 17);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "Sürüm Bilgisi:";
            // 
            // btnGuncellemeDenetle
            // 
            this.btnGuncellemeDenetle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncellemeDenetle.ForeColor = System.Drawing.Color.White;
            this.btnGuncellemeDenetle.Location = new System.Drawing.Point(13, 105);
            this.btnGuncellemeDenetle.Name = "btnGuncellemeDenetle";
            this.btnGuncellemeDenetle.Size = new System.Drawing.Size(135, 50);
            this.btnGuncellemeDenetle.TabIndex = 16;
            this.btnGuncellemeDenetle.Text = "Güncelleme Denetle";
            this.btnGuncellemeDenetle.UseVisualStyleBackColor = true;
            this.btnGuncellemeDenetle.Click += new System.EventHandler(this.btnGuncellemeDenetle_Click);
            // 
            // pictureCloseSettings
            // 
            this.pictureCloseSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureCloseSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCloseSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureCloseSettings.Image")));
            this.pictureCloseSettings.Location = new System.Drawing.Point(268, 17);
            this.pictureCloseSettings.Name = "pictureCloseSettings";
            this.pictureCloseSettings.Size = new System.Drawing.Size(21, 21);
            this.pictureCloseSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseSettings.TabIndex = 15;
            this.pictureCloseSettings.TabStop = false;
            this.pictureCloseSettings.Click += new System.EventHandler(this.pictureCloseSettings_Click);
            // 
            // btnCacheTemizleme
            // 
            this.btnCacheTemizleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCacheTemizleme.ForeColor = System.Drawing.Color.White;
            this.btnCacheTemizleme.Location = new System.Drawing.Point(13, 64);
            this.btnCacheTemizleme.Name = "btnCacheTemizleme";
            this.btnCacheTemizleme.Size = new System.Drawing.Size(135, 35);
            this.btnCacheTemizleme.TabIndex = 15;
            this.btnCacheTemizleme.Text = "Cache Temizle";
            this.btnCacheTemizleme.UseVisualStyleBackColor = true;
            this.btnCacheTemizleme.Click += new System.EventHandler(this.btnCacheTemizleme_Click);
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.AutoSize = true;
            this.lblAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.lblAyarlar.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblAyarlar.Location = new System.Drawing.Point(17, 6);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(111, 43);
            this.lblAyarlar.TabIndex = 14;
            this.lblAyarlar.Text = "Ayarlar";
            // 
            // pictureSettings
            // 
            this.pictureSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSettings.BackgroundImage")));
            this.pictureSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureSettings.Image")));
            this.pictureSettings.Location = new System.Drawing.Point(661, 9);
            this.pictureSettings.Name = "pictureSettings";
            this.pictureSettings.Size = new System.Drawing.Size(21, 21);
            this.pictureSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSettings.TabIndex = 28;
            this.pictureSettings.TabStop = false;
            this.pictureSettings.Click += new System.EventHandler(this.pictureSettings_Click);
            // 
            // lblOnlineKisi
            // 
            this.lblOnlineKisi.AutoSize = true;
            this.lblOnlineKisi.BackColor = System.Drawing.Color.Transparent;
            this.lblOnlineKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnlineKisi.ForeColor = System.Drawing.Color.White;
            this.lblOnlineKisi.Image = ((System.Drawing.Image)(resources.GetObject("lblOnlineKisi.Image")));
            this.lblOnlineKisi.Location = new System.Drawing.Point(614, 26);
            this.lblOnlineKisi.Name = "lblOnlineKisi";
            this.lblOnlineKisi.Size = new System.Drawing.Size(13, 13);
            this.lblOnlineKisi.TabIndex = 26;
            this.lblOnlineKisi.Text = "..";
            // 
            // lblSunucuKacKisi
            // 
            this.lblSunucuKacKisi.AutoSize = true;
            this.lblSunucuKacKisi.BackColor = System.Drawing.Color.Transparent;
            this.lblSunucuKacKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSunucuKacKisi.ForeColor = System.Drawing.Color.White;
            this.lblSunucuKacKisi.Image = ((System.Drawing.Image)(resources.GetObject("lblSunucuKacKisi.Image")));
            this.lblSunucuKacKisi.Location = new System.Drawing.Point(529, 24);
            this.lblSunucuKacKisi.Name = "lblSunucuKacKisi";
            this.lblSunucuKacKisi.Size = new System.Drawing.Size(89, 13);
            this.lblSunucuKacKisi.TabIndex = 25;
            this.lblSunucuKacKisi.Text = "Online Kişi Sayısı:";
            // 
            // pictureDurum
            // 
            this.pictureDurum.BackColor = System.Drawing.Color.Yellow;
            this.pictureDurum.Location = new System.Drawing.Point(616, 7);
            this.pictureDurum.Name = "pictureDurum";
            this.pictureDurum.Size = new System.Drawing.Size(15, 15);
            this.pictureDurum.TabIndex = 24;
            this.pictureDurum.TabStop = false;
            // 
            // lblSunuDurum
            // 
            this.lblSunuDurum.AutoSize = true;
            this.lblSunuDurum.BackColor = System.Drawing.Color.Transparent;
            this.lblSunuDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSunuDurum.ForeColor = System.Drawing.Color.White;
            this.lblSunuDurum.Image = ((System.Drawing.Image)(resources.GetObject("lblSunuDurum.Image")));
            this.lblSunuDurum.Location = new System.Drawing.Point(531, 9);
            this.lblSunuDurum.Name = "lblSunuDurum";
            this.lblSunuDurum.Size = new System.Drawing.Size(86, 13);
            this.lblSunuDurum.TabIndex = 23;
            this.lblSunuDurum.Text = "Sunucu Durumu:";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(688, 9);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(21, 21);
            this.btnKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKapat.TabIndex = 17;
            this.btnKapat.TabStop = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBaslikYazisi
            // 
            this.lblBaslikYazisi.AutoSize = true;
            this.lblBaslikYazisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslikYazisi.ForeColor = System.Drawing.Color.White;
            this.lblBaslikYazisi.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslikYazisi.Image")));
            this.lblBaslikYazisi.Location = new System.Drawing.Point(12, 12);
            this.lblBaslikYazisi.Name = "lblBaslikYazisi";
            this.lblBaslikYazisi.Size = new System.Drawing.Size(168, 20);
            this.lblBaslikYazisi.TabIndex = 16;
            this.lblBaslikYazisi.Text = "FivemCode Luancher";
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblBaslik.BackgroundImage")));
            this.lblBaslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(722, 43);
            this.lblBaslik.TabIndex = 15;
            this.lblBaslik.TabStop = false;
            this.lblBaslik.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBaslik_MouseDown);
            this.lblBaslik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblBaslik_MouseMove);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.DimGray;
            this.panelSettings.Controls.Add(this.lblv);
            this.panelSettings.Controls.Add(this.lblVersion);
            this.panelSettings.Controls.Add(this.btnGuncellemeDenetle);
            this.panelSettings.Controls.Add(this.pictureCloseSettings);
            this.panelSettings.Controls.Add(this.btnCacheTemizleme);
            this.panelSettings.Controls.Add(this.lblAyarlar);
            this.panelSettings.Location = new System.Drawing.Point(0, 40);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(292, 398);
            this.panelSettings.TabIndex = 27;
            this.panelSettings.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 5);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // lblDuyuruMetni
            // 
            this.lblDuyuruMetni.BackColor = System.Drawing.Color.Transparent;
            this.lblDuyuruMetni.Location = new System.Drawing.Point(12, 128);
            this.lblDuyuruMetni.Name = "lblDuyuruMetni";
            this.lblDuyuruMetni.Size = new System.Drawing.Size(289, 192);
            this.lblDuyuruMetni.TabIndex = 21;
            this.lblDuyuruMetni.Text = "....";
            // 
            // lblDuyuruBaslik
            // 
            this.lblDuyuruBaslik.AutoSize = true;
            this.lblDuyuruBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblDuyuruBaslik.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuyuruBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblDuyuruBaslik.Location = new System.Drawing.Point(8, 80);
            this.lblDuyuruBaslik.Name = "lblDuyuruBaslik";
            this.lblDuyuruBaslik.Size = new System.Drawing.Size(204, 43);
            this.lblDuyuruBaslik.TabIndex = 20;
            this.lblDuyuruBaslik.Text = "Son Gelişmeler;";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.Transparent;
            this.btnOyna.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOyna.BackgroundImage")));
            this.btnOyna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOyna.FlatAppearance.BorderSize = 0;
            this.btnOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyna.ForeColor = System.Drawing.Color.White;
            this.btnOyna.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOyna.Location = new System.Drawing.Point(507, 364);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(202, 65);
            this.btnOyna.TabIndex = 18;
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 434);
            this.Controls.Add(this.pictureSettings);
            this.Controls.Add(this.lblOnlineKisi);
            this.Controls.Add(this.lblSunucuKacKisi);
            this.Controls.Add(this.pictureDurum);
            this.Controls.Add(this.lblSunuDurum);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblBaslikYazisi);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDuyuruMetni);
            this.Controls.Add(this.lblDuyuruBaslik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOyna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBaslik)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer hileKoruma;
        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnGuncellemeDenetle;
        private System.Windows.Forms.PictureBox pictureCloseSettings;
        private System.Windows.Forms.Button btnCacheTemizleme;
        private System.Windows.Forms.Label lblAyarlar;
        private System.Windows.Forms.PictureBox pictureSettings;
        private System.Windows.Forms.Label lblOnlineKisi;
        private System.Windows.Forms.Label lblSunucuKacKisi;
        private System.Windows.Forms.PictureBox pictureDurum;
        private System.Windows.Forms.Label lblSunuDurum;
        private System.Windows.Forms.PictureBox btnKapat;
        private System.Windows.Forms.Label lblBaslikYazisi;
        private System.Windows.Forms.PictureBox lblBaslik;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDuyuruMetni;
        private System.Windows.Forms.Label lblDuyuruBaslik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOyna;
    }
}

