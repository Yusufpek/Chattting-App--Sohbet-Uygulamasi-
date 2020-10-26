namespace sohbet_uygulamasi
{
    partial class AnaEkran
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIsimDegistir = new System.Windows.Forms.Label();
            this.tBoxIsimDegistir = new System.Windows.Forms.TextBox();
            this.lblDurumDegistir = new System.Windows.Forms.Label();
            this.tBoxDurumDegistir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDurum = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelKullanicilar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lBoxDurum = new System.Windows.Forms.ListBox();
            this.lBoxIsim = new System.Windows.Forms.ListBox();
            this.panelSohbetAlani = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxMesaj = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMesajlar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panelKullanicilar.SuspendLayout();
            this.panelSohbetAlani.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lblIsimDegistir);
            this.panel2.Controls.Add(this.tBoxIsimDegistir);
            this.panel2.Controls.Add(this.lblDurumDegistir);
            this.panel2.Controls.Add(this.tBoxDurumDegistir);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lblKullaniciAdi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDurum);
            this.panel2.Controls.Add(this.lblDurum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 183);
            this.panel2.TabIndex = 1;
            // 
            // lblIsimDegistir
            // 
            this.lblIsimDegistir.AutoSize = true;
            this.lblIsimDegistir.Location = new System.Drawing.Point(67, 77);
            this.lblIsimDegistir.Name = "lblIsimDegistir";
            this.lblIsimDegistir.Size = new System.Drawing.Size(78, 20);
            this.lblIsimDegistir.TabIndex = 13;
            this.lblIsimDegistir.Text = "Yeni İsim:";
            this.lblIsimDegistir.Visible = false;
            // 
            // tBoxIsimDegistir
            // 
            this.tBoxIsimDegistir.Location = new System.Drawing.Point(151, 74);
            this.tBoxIsimDegistir.Name = "tBoxIsimDegistir";
            this.tBoxIsimDegistir.Size = new System.Drawing.Size(134, 26);
            this.tBoxIsimDegistir.TabIndex = 12;
            this.tBoxIsimDegistir.Visible = false;
            // 
            // lblDurumDegistir
            // 
            this.lblDurumDegistir.AutoSize = true;
            this.lblDurumDegistir.Location = new System.Drawing.Point(865, 74);
            this.lblDurumDegistir.Name = "lblDurumDegistir";
            this.lblDurumDegistir.Size = new System.Drawing.Size(97, 20);
            this.lblDurumDegistir.TabIndex = 11;
            this.lblDurumDegistir.Text = "Yeni Durum:";
            this.lblDurumDegistir.Visible = false;
            // 
            // tBoxDurumDegistir
            // 
            this.tBoxDurumDegistir.Location = new System.Drawing.Point(964, 71);
            this.tBoxDurumDegistir.Name = "tBoxDurumDegistir";
            this.tBoxDurumDegistir.Size = new System.Drawing.Size(134, 26);
            this.tBoxDurumDegistir.TabIndex = 10;
            this.tBoxDurumDegistir.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1111, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(111, 74);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(97, 20);
            this.lblKullaniciAdi.TabIndex = 8;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(555, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "By Yusuf";
            // 
            // btnDurum
            // 
            this.btnDurum.BackColor = System.Drawing.Color.Teal;
            this.btnDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurum.Location = new System.Drawing.Point(935, 110);
            this.btnDurum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(112, 35);
            this.btnDurum.TabIndex = 5;
            this.btnDurum.Text = "Değiştir";
            this.btnDurum.UseVisualStyleBackColor = false;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(944, 74);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(61, 20);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(438, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOHBET UYGULAMASI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(107, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelKullanicilar
            // 
            this.panelKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelKullanicilar.Controls.Add(this.label2);
            this.panelKullanicilar.Controls.Add(this.lBoxDurum);
            this.panelKullanicilar.Controls.Add(this.lBoxIsim);
            this.panelKullanicilar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKullanicilar.Location = new System.Drawing.Point(0, 183);
            this.panelKullanicilar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKullanicilar.Name = "panelKullanicilar";
            this.panelKullanicilar.Size = new System.Drawing.Size(288, 459);
            this.panelKullanicilar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcılar ve Durumlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // lBoxDurum
            // 
            this.lBoxDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lBoxDurum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxDurum.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBoxDurum.FormattingEnabled = true;
            this.lBoxDurum.ItemHeight = 23;
            this.lBoxDurum.Location = new System.Drawing.Point(185, 33);
            this.lBoxDurum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lBoxDurum.Name = "lBoxDurum";
            this.lBoxDurum.Size = new System.Drawing.Size(103, 414);
            this.lBoxDurum.TabIndex = 1;
            // 
            // lBoxIsim
            // 
            this.lBoxIsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lBoxIsim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxIsim.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxIsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lBoxIsim.FormattingEnabled = true;
            this.lBoxIsim.ItemHeight = 23;
            this.lBoxIsim.Location = new System.Drawing.Point(0, 33);
            this.lBoxIsim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lBoxIsim.Name = "lBoxIsim";
            this.lBoxIsim.Size = new System.Drawing.Size(196, 414);
            this.lBoxIsim.TabIndex = 0;
            // 
            // panelSohbetAlani
            // 
            this.panelSohbetAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSohbetAlani.Controls.Add(this.panelMesajlar);
            this.panelSohbetAlani.Controls.Add(this.panel3);
            this.panelSohbetAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSohbetAlani.Location = new System.Drawing.Point(288, 183);
            this.panelSohbetAlani.Name = "panelSohbetAlani";
            this.panelSohbetAlani.Size = new System.Drawing.Size(899, 459);
            this.panelSohbetAlani.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tBoxMesaj);
            this.panel3.Controls.Add(this.btnGonder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 78);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mesaj:";
            // 
            // tBoxMesaj
            // 
            this.tBoxMesaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxMesaj.Location = new System.Drawing.Point(112, 32);
            this.tBoxMesaj.Name = "tBoxMesaj";
            this.tBoxMesaj.Size = new System.Drawing.Size(636, 27);
            this.tBoxMesaj.TabIndex = 0;
            this.tBoxMesaj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxMesaj_KeyDown);
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGonder.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(759, 26);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(128, 34);
            this.btnGonder.TabIndex = 1;
            this.btnGonder.Text = "Gönder Gelsin";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMesajlar
            // 
            this.panelMesajlar.AutoScroll = true;
            this.panelMesajlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesajlar.Location = new System.Drawing.Point(0, 0);
            this.panelMesajlar.Name = "panelMesajlar";
            this.panelMesajlar.Size = new System.Drawing.Size(899, 381);
            this.panelMesajlar.TabIndex = 3;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1187, 642);
            this.Controls.Add(this.panelSohbetAlani);
            this.Controls.Add(this.panelKullanicilar);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sohbet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaEkran_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelKullanicilar.ResumeLayout(false);
            this.panelSohbetAlani.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelKullanicilar;
        private System.Windows.Forms.ListBox lBoxDurum;
        private System.Windows.Forms.ListBox lBoxIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDurum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDurumDegistir;
        private System.Windows.Forms.TextBox tBoxDurumDegistir;
        private System.Windows.Forms.Label lblIsimDegistir;
        private System.Windows.Forms.TextBox tBoxIsimDegistir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSohbetAlani;
        public System.Windows.Forms.FlowLayoutPanel panelMesajlar;
        private System.Windows.Forms.TextBox tBoxMesaj;
    }
}

