using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sohbet_uygulamasi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        public string _isim ;
        public string _durum;
        public int _id;
        public static int mesajId;
        public int toplamMesaj;
        Kullanici _kullanici = new Kullanici();
        FirebaseIslemleri fbIslemleri = new FirebaseIslemleri();
        public void kullaniciBilgileriAtama()
        {
            _kullanici.isim = _isim;
            _kullanici.durum =_durum;
            lblKullaniciAdi.Text = "İsim: " + _kullanici.isim;
            lblDurum.Text = "Durum: " + _kullanici.durum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
            try
            {
                kullaniciBilgileriAtama();
                fbIslemleri.giris(_kullanici);
                _id = _kullanici.id;
                fbIslemleri.kullanicilariCek(lBoxIsim,lBoxDurum);
                MessageBox.Show("Başarıyla giriş yapıldı !", "Bilgi");
                fbIslemleri.mesajlariOku(_kullanici,mesajId, panelMesajlar);
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata !");
            }
           
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            if (panelKullanicilar.Dock == DockStyle.Left)
            {
                panelKullanicilar.Dock = DockStyle.Right;
            }
            else
            {
                panelKullanicilar.Dock = DockStyle.Left;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lblKullaniciAdi.Visible)
            {
                lblKullaniciAdi.Visible = false;
                lblIsimDegistir.Visible = true;
                tBoxIsimDegistir.Visible = true;
            }
            else
            {
                if (!String.IsNullOrEmpty(tBoxIsimDegistir.Text))
                {
                    _kullanici.isim = tBoxIsimDegistir.Text;
                    fbIslemleri.duzenle(_kullanici);
                    MessageBox.Show("Yeni isim ho ! \n Yakışır dostuma !", "İsim Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblKullaniciAdi.Text = "İsim: " + _kullanici.isim;
                    lblKullaniciAdi.Visible = true;
                    lblIsimDegistir.Visible = false;
                    tBoxIsimDegistir.Visible = false;
                }
                else
                {
                    MessageBox.Show("Durumun boş olsun istemezsin dostum !", "Boş Yapma", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            if (lblDurum.Visible)
            {
                lblDurum.Visible = false;
                lblDurumDegistir.Visible = true;
                tBoxDurumDegistir.Visible = true;
            }
            else
            {
                if (!String.IsNullOrEmpty(tBoxDurumDegistir.Text))
                {
                    _kullanici.durum = tBoxDurumDegistir.Text;
                    fbIslemleri.duzenle(_kullanici);
                    MessageBox.Show("Yeni durum ho !", "Durum Bilgisi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lblDurum.Text = "Durum: " + _kullanici.durum;
                    lblDurum.Visible = true;
                    lblDurumDegistir.Visible = false;
                    tBoxDurumDegistir.Visible = false;
                }
                else
                {
                    MessageBox.Show("Durumun boş olsun istemezsin dostum !", "Boş Yapma" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }
        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            fbIslemleri.cikis(_kullanici);
            timer1.Stop();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tBoxMesaj.Text))
            {
                Mesajlar mesaj = new Mesajlar
                {
                    icerik = tBoxMesaj.Text,
                    kimden = _kullanici.isim,
                    kimdenId = _kullanici.id,
                    zaman = DateTime.Now.ToShortTimeString()
                };
                fbIslemleri.mesajGonder(mesaj);
                MesajKutulari ms = new MesajKutulari();
                tBoxMesaj.Clear();
                timer1.Interval = 10;
            }
            else
            {
                MessageBox.Show("Boş yapma bro ! \n Bir şey yazmadan mesaj mı atılır !","Mesaj Gitmedi Acaba Niye ?",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            fbIslemleri.mesajlariOku(_kullanici, mesajId, panelMesajlar);
        }

        private void tBoxMesaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGonder_Click(btnGonder, new EventArgs());
            }
        }
    }
}
