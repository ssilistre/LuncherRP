namespace LuancherFivemcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblOyna = new System.Windows.Forms.PictureBox();
            this.lblKucult = new System.Windows.Forms.PictureBox();
            this.lblKapat = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btndiscord = new System.Windows.Forms.PictureBox();
            this.btnts3 = new System.Windows.Forms.PictureBox();
            this.lblDuyuru = new System.Windows.Forms.Label();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblonline = new System.Windows.Forms.Label();
            this.lblSunucuDurumu = new System.Windows.Forms.Label();
            this.sunucuDurum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblOyna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnts3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunucuDurum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOyna
            // 
            this.lblOyna.BackColor = System.Drawing.Color.Transparent;
            this.lblOyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOyna.Image = ((System.Drawing.Image)(resources.GetObject("lblOyna.Image")));
            this.lblOyna.Location = new System.Drawing.Point(827, 498);
            this.lblOyna.Name = "lblOyna";
            this.lblOyna.Size = new System.Drawing.Size(116, 32);
            this.lblOyna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblOyna.TabIndex = 0;
            this.lblOyna.TabStop = false;
            this.lblOyna.Click += new System.EventHandler(this.lblOyna_Click);
            // 
            // lblKucult
            // 
            this.lblKucult.BackColor = System.Drawing.Color.Transparent;
            this.lblKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKucult.Image = ((System.Drawing.Image)(resources.GetObject("lblKucult.Image")));
            this.lblKucult.Location = new System.Drawing.Point(861, 12);
            this.lblKucult.Name = "lblKucult";
            this.lblKucult.Size = new System.Drawing.Size(37, 36);
            this.lblKucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblKucult.TabIndex = 1;
            this.lblKucult.TabStop = false;
            this.lblKucult.Click += new System.EventHandler(this.lblKucult_Click);
            // 
            // lblKapat
            // 
            this.lblKapat.BackColor = System.Drawing.Color.Transparent;
            this.lblKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKapat.Image = ((System.Drawing.Image)(resources.GetObject("lblKapat.Image")));
            this.lblKapat.Location = new System.Drawing.Point(906, 12);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(37, 36);
            this.lblKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblKapat.TabIndex = 2;
            this.lblKapat.TabStop = false;
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(406, 86);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(269, 49);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // btndiscord
            // 
            this.btndiscord.BackColor = System.Drawing.Color.Transparent;
            this.btndiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiscord.Image = ((System.Drawing.Image)(resources.GetObject("btndiscord.Image")));
            this.btndiscord.Location = new System.Drawing.Point(12, 498);
            this.btndiscord.Name = "btndiscord";
            this.btndiscord.Size = new System.Drawing.Size(116, 32);
            this.btndiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btndiscord.TabIndex = 4;
            this.btndiscord.TabStop = false;
            this.btndiscord.Click += new System.EventHandler(this.btndiscord_Click);
            // 
            // btnts3
            // 
            this.btnts3.BackColor = System.Drawing.Color.Transparent;
            this.btnts3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnts3.Image = ((System.Drawing.Image)(resources.GetObject("btnts3.Image")));
            this.btnts3.Location = new System.Drawing.Point(134, 498);
            this.btnts3.Name = "btnts3";
            this.btnts3.Size = new System.Drawing.Size(116, 32);
            this.btnts3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnts3.TabIndex = 5;
            this.btnts3.TabStop = false;
            this.btnts3.Click += new System.EventHandler(this.btnts3_Click);
            // 
            // lblDuyuru
            // 
            this.lblDuyuru.BackColor = System.Drawing.Color.Transparent;
            this.lblDuyuru.Location = new System.Drawing.Point(406, 138);
            this.lblDuyuru.Name = "lblDuyuru";
            this.lblDuyuru.Size = new System.Drawing.Size(272, 184);
            this.lblDuyuru.TabIndex = 6;
            this.lblDuyuru.Text = "...";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKisiSayisi.ForeColor = System.Drawing.Color.White;
            this.lblKisiSayisi.Location = new System.Drawing.Point(672, 498);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(54, 13);
            this.lblKisiSayisi.TabIndex = 7;
            this.lblKisiSayisi.Text = "Kişi Saysı:";
            // 
            // lblonline
            // 
            this.lblonline.AutoSize = true;
            this.lblonline.BackColor = System.Drawing.Color.Transparent;
            this.lblonline.ForeColor = System.Drawing.Color.White;
            this.lblonline.Location = new System.Drawing.Point(728, 498);
            this.lblonline.Name = "lblonline";
            this.lblonline.Size = new System.Drawing.Size(13, 13);
            this.lblonline.TabIndex = 8;
            this.lblonline.Text = "..";
            // 
            // lblSunucuDurumu
            // 
            this.lblSunucuDurumu.AutoSize = true;
            this.lblSunucuDurumu.BackColor = System.Drawing.Color.Transparent;
            this.lblSunucuDurumu.ForeColor = System.Drawing.Color.White;
            this.lblSunucuDurumu.Location = new System.Drawing.Point(639, 520);
            this.lblSunucuDurumu.Name = "lblSunucuDurumu";
            this.lblSunucuDurumu.Size = new System.Drawing.Size(87, 13);
            this.lblSunucuDurumu.TabIndex = 9;
            this.lblSunucuDurumu.Text = "Sunucu Durumu:";
            // 
            // sunucuDurum
            // 
            this.sunucuDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sunucuDurum.Location = new System.Drawing.Point(731, 520);
            this.sunucuDurum.Name = "sunucuDurum";
            this.sunucuDurum.Size = new System.Drawing.Size(21, 13);
            this.sunucuDurum.TabIndex = 10;
            this.sunucuDurum.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.sunucuDurum);
            this.Controls.Add(this.lblSunucuDurumu);
            this.Controls.Add(this.lblonline);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.lblDuyuru);
            this.Controls.Add(this.btnts3);
            this.Controls.Add(this.btndiscord);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.lblKucult);
            this.Controls.Add(this.lblOyna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lblOyna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnts3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunucuDurum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblOyna;
        private System.Windows.Forms.PictureBox lblKucult;
        private System.Windows.Forms.PictureBox lblKapat;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox btndiscord;
        private System.Windows.Forms.PictureBox btnts3;
        private System.Windows.Forms.Label lblDuyuru;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label lblonline;
        private System.Windows.Forms.Label lblSunucuDurumu;
        private System.Windows.Forms.PictureBox sunucuDurum;
    }
}

