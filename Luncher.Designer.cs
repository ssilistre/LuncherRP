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
            ((System.ComponentModel.ISupportInitialize)(this.resimKutusu)).BeginInit();
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
            // 
            // btnOyna
            // 
            this.btnOyna.AutoEllipsis = true;
            this.btnOyna.BackColor = System.Drawing.Color.Transparent;
            this.btnOyna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyna.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOyna.Location = new System.Drawing.Point(494, 349);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(174, 42);
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
            this.reklamMetni.Location = new System.Drawing.Point(23, 374);
            this.reklamMetni.Name = "reklamMetni";
            this.reklamMetni.Size = new System.Drawing.Size(16, 17);
            this.reklamMetni.TabIndex = 2;
            this.reklamMetni.TabStop = true;
            this.reklamMetni.Text = "..";
            this.reklamMetni.Visible = false;
            this.reklamMetni.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reklamMetni_LinkClicked);
            // 
            // hileKontrol
            // 
            this.hileKontrol.Tick += new System.EventHandler(this.hileKontrol_Tick);
            // 
            // Luncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 404);
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
    }
}