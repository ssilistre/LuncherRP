namespace Robin_Launcher
{
    partial class index_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index_1));
            this.btnOyna = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiscord = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.PictureBox();
            this.btnKucult = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOyuncuSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.travis = new System.Windows.Forms.PictureBox();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.hileKoruma = new System.Windows.Forms.Timer(this.components);
            this.travisoynat = new System.Windows.Forms.Timer(this.components);
            this.travisoynat2 = new System.Windows.Forms.Timer(this.components);
            this.lstOyunListesi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDuyuruMetni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnOyna)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKucult)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOyna.Image = ((System.Drawing.Image)(resources.GetObject("btnOyna.Image")));
            this.btnOyna.Location = new System.Drawing.Point(12, 544);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(169, 55);
            this.btnOyna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOyna.TabIndex = 0;
            this.btnOyna.TabStop = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDiscord);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 92);
            this.panel1.TabIndex = 1;
            // 
            // btnDiscord
            // 
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscord.Image")));
            this.btnDiscord.Location = new System.Drawing.Point(1025, 8);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(43, 35);
            this.btnDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDiscord.TabIndex = 3;
            this.btnDiscord.TabStop = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnKapat);
            this.panel8.Controls.Add(this.btnKucult);
            this.panel8.Location = new System.Drawing.Point(1074, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(66, 33);
            this.panel8.TabIndex = 6;
            // 
            // btnKapat
            // 
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(40, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(25, 25);
            this.btnKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKapat.TabIndex = 4;
            this.btnKapat.TabStop = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKucult.Image = ((System.Drawing.Image)(resources.GetObject("btnKucult.Image")));
            this.btnKucult.Location = new System.Drawing.Point(3, 3);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(25, 25);
            this.btnKucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnKucult.TabIndex = 5;
            this.btnKucult.TabStop = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(50)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 5);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Launcher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(277, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fivemcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblOyuncuSayisi);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(198, 549);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 46);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(100)))), ((int)(((byte)(112)))));
            this.label6.Location = new System.Drawing.Point(66, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "/128";
            // 
            // lblOyuncuSayisi
            // 
            this.lblOyuncuSayisi.AutoSize = true;
            this.lblOyuncuSayisi.ForeColor = System.Drawing.Color.White;
            this.lblOyuncuSayisi.Location = new System.Drawing.Point(56, 25);
            this.lblOyuncuSayisi.Name = "lblOyuncuSayisi";
            this.lblOyuncuSayisi.Size = new System.Drawing.Size(13, 13);
            this.lblOyuncuSayisi.TabIndex = 5;
            this.lblOyuncuSayisi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kisi Sayısı :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // travis
            // 
            this.travis.BackColor = System.Drawing.Color.Transparent;
            this.travis.Image = ((System.Drawing.Image)(resources.GetObject("travis.Image")));
            this.travis.Location = new System.Drawing.Point(787, 92);
            this.travis.Name = "travis";
            this.travis.Size = new System.Drawing.Size(351, 526);
            this.travis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.travis.TabIndex = 10;
            this.travis.TabStop = false;
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel1;
            // 
            // hileKoruma
            // 
            this.hileKoruma.Interval = 20000;
            this.hileKoruma.Tick += new System.EventHandler(this.hileKoruma_Tick);
            // 
            // travisoynat
            // 
            this.travisoynat.Enabled = true;
            this.travisoynat.Interval = 30;
            this.travisoynat.Tick += new System.EventHandler(this.travisoynat_Tick);
            // 
            // travisoynat2
            // 
            this.travisoynat2.Interval = 30;
            this.travisoynat2.Tick += new System.EventHandler(this.travisoynat2_Tick);
            // 
            // lstOyunListesi
            // 
            this.lstOyunListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.lstOyunListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOyunListesi.Cursor = System.Windows.Forms.Cursors.No;
            this.lstOyunListesi.Enabled = false;
            this.lstOyunListesi.ForeColor = System.Drawing.Color.White;
            this.lstOyunListesi.FormattingEnabled = true;
            this.lstOyunListesi.Location = new System.Drawing.Point(508, 98);
            this.lstOyunListesi.Name = "lstOyunListesi";
            this.lstOyunListesi.Size = new System.Drawing.Size(258, 507);
            this.lstOyunListesi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(255)))), ((int)(((byte)(95)))));
            this.label5.Location = new System.Drawing.Point(5, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duyurular:";
            // 
            // lblDuyuruMetni
            // 
            this.lblDuyuruMetni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDuyuruMetni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDuyuruMetni.ForeColor = System.Drawing.Color.White;
            this.lblDuyuruMetni.Location = new System.Drawing.Point(12, 153);
            this.lblDuyuruMetni.Name = "lblDuyuruMetni";
            this.lblDuyuruMetni.Size = new System.Drawing.Size(475, 287);
            this.lblDuyuruMetni.TabIndex = 12;
            this.lblDuyuruMetni.Text = "....";
            // 
            // index_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1150, 611);
            this.Controls.Add(this.lblDuyuruMetni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.travis);
            this.Controls.Add(this.lstOyunListesi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOyna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test RP - Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.index_1_FormClosing);
            this.Load += new System.EventHandler(this.index_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnOyna)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnKucult)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnOyna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOyuncuSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnDiscord;
        private System.Windows.Forms.PictureBox travis;
        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btnKapat;
        private System.Windows.Forms.PictureBox btnKucult;
        private System.Windows.Forms.Timer hileKoruma;
        private System.Windows.Forms.Timer travisoynat;
        private System.Windows.Forms.Timer travisoynat2;
        private System.Windows.Forms.ListBox lstOyunListesi;
        private System.Windows.Forms.Label lblDuyuruMetni;
        private System.Windows.Forms.Label label5;
    }
}

