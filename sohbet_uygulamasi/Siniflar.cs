using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace sohbet_uygulamasi
{

    class Firebase
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            //Kendi veri tabanınızdaki bilgiler ile doldurunuz !!
            AuthSecret = "", 
            BasePath = ""
        };
        public static IFirebaseClient client = new FireSharp.FirebaseClient(config);
    }

    class FirebaseIslemleri
    {
        public static FirebaseResponse response;
        public static IFirebaseClient client = new FireSharp.FirebaseClient(Firebase.config);
        public async void kullanicilariCek(ListBox lboxKadi, ListBox lboxDurum)
        {
            lboxKadi.Items.Clear();
            lboxDurum.Items.Clear();
            response = await client.GetTaskAsync("sayac");
            Sayac sayac = response.ResultAs<Sayac>();
            int i = sayac.deger;
            while (i >= 0)
            {
                i--;
                response = await client.GetTaskAsync("kullanıcılar/"+i.ToString());
                try
                {
                    Kullanici obj = response.ResultAs<Kullanici>();
                    lboxKadi.Items.Add(obj.isim);
                    lboxDurum.Items.Add(obj.durum);
                }
                catch{}
            }
        }
        public async void duzenle(Kullanici kullanici)
        {
            try
            {
                response = await client.UpdateTaskAsync("kullanıcılar/" + kullanici.id, kullanici);
            }
            catch {
                MessageBox.Show("Bro ufak bi sıkıntı oldu düzenleme yapamdık ! \nİnternetini kontrol edip tekrar deneyebilir misin ?","Düzenleme Yapamadım KB!" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public async void giris(Kullanici kullanici)
        {
            response = await client.GetTaskAsync("sayac");
            Sayac sayac = response.ResultAs<Sayac>();
            kullanici.id = sayac.deger;
            sayac.deger++;
            response = await client.SetTaskAsync("sayac", sayac);
            //
            response = await client.SetTaskAsync("kullanıcılar/" + kullanici.id, kullanici);
        }
        public async void cikis(Kullanici kullanici)
        {
            try
            {
                response = await client.DeleteTaskAsync("kullanıcılar/" + kullanici.id.ToString());
            }
            catch { }
        }
        MesajKutulari msj = new MesajKutulari();
        Sifreleme sf = new Sifreleme();
        public async void mesajlariOku(Kullanici kullanici, int id, Panel p)
        {
            try
            {
                response = await client.GetTaskAsync("sayac");
                Sayac sayac = response.ResultAs<Sayac>();
                int sonId = sayac.mesajSayisi;
                int m = id;
                AnaEkran.mesajId = sonId;
                while (m < sonId)
                {
                    try
                    {
                        response = await client.GetTaskAsync("mesajlar/" + m.ToString());
                        Mesajlar mesaj = response.ResultAs<Mesajlar>();
                        mesaj.icerik = sf.SifreCoz(mesaj.icerik);
                        if (mesaj.kimdenId == kullanici.id)
                        {
                            msj.gidenMesajKutusuOlustur(mesaj, p);
                        }
                        else
                        {
                            //onların group box'ı
                            msj.gelenMesajKutusuOlustur(mesaj, p);
                        }
                    }
                    catch { }
                    m++;
                }
            }
            catch { }
        }
        public async void mesajGonder(Mesajlar mesaj)
        {
            try
            {
                response = await client.GetTaskAsync("sayac");
                Sayac sayac = response.ResultAs<Sayac>();
                int _id = sayac.mesajSayisi;
                mesaj.id = _id;
                mesaj.icerik = sf.Sifrele(mesaj.icerik);
                sayac.mesajSayisi++;
                response = await client.SetTaskAsync("mesajlar/" + _id.ToString(), mesaj);
                response = await client.SetTaskAsync("sayac", sayac);
            }
            catch
            {
                MessageBox.Show("Mesaj gönderilemedi bro ! \n İnternet bağlantını bi kontrol edebilir misin sana zahmet !", "Mesaj Gönderilemedi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
    class Kullanici
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string durum { get; set; }
    }
    class Sayac
    {
        public int deger { get; set; }
        public int mesajSayisi { get; set; }
    }
    class Mesajlar
    {
        public int id { get; set; }
        public string icerik { get; set; }
        public string kimden { get; set; }
        public int kimdenId { get; set; }
        public string zaman { get; set; }
    }
    class Sifreleme
    {
        public string Sifrele(string kelime)
        {
            char[] harfler = kelime.ToCharArray();
            string sifreliSozcuk = "";

            for (int i = 0; i < harfler.Length; i++)
            {
                sifreliSozcuk += Convert.ToChar(harfler[i] + 7);
            }
            return sifreliSozcuk;
        }
        public string SifreCoz(string kelime)
        {
            char[] harfler2 = kelime.ToCharArray();
            string cozulmusSozcuk = "";

            for (int i = 0; i < harfler2.Length; i++)
            {
                cozulmusSozcuk += Convert.ToChar(harfler2[i] - 7);
            }
            return cozulmusSozcuk;
        }
    }
    // 
    class MesajKutulari
    {
        public void gelenMesajKutusuOlustur(Mesajlar mesaj, Panel panel)
        {
            GroupBox gelenMesajKutusu = new GroupBox();
            gelenMesajKutusu.Text = mesaj.kimden;
            gelenMesajKutusu.BackColor = Color.FromArgb(0, 64, 64);
            gelenMesajKutusu.ForeColor = Color.White;
            gelenMesajKutusu.Font = new Font("Calibri", 12);
            gelenMesajKutusu.Size = new Size(390, 100);
            panel.Controls.Add(gelenMesajKutusu);
            //
            Label zaman = new Label();
            zaman.Text = mesaj.zaman;
            zaman.Font = new Font("Calibri", 8);
            zaman.Location = new Point(295,15);
            zaman.AutoSize = true;
            gelenMesajKutusu.Controls.Add(zaman);
            //
            RichTextBox icerik = new RichTextBox();
            icerik.Text = mesaj.icerik;
            icerik.BackColor = Color.FromArgb(0, 64, 64);
            icerik.ForeColor = Color.White;
            icerik.Location = new Point(15,30);
            icerik.Size = new Size(360,45);
            icerik.ReadOnly = true;
            icerik.BorderStyle = BorderStyle.None;
            gelenMesajKutusu.Controls.Add(icerik);
            //
            //Bi alt satıra indirmek için
            Label lbl = new Label();
            lbl.Size = new Size(480, 100);
            panel.Controls.Add(lbl);
        }
        public void gidenMesajKutusuOlustur(Mesajlar mesaj, Panel panel)
        {

            //İlk kısmı bo bırakmak için kullanıyorum
            Label lbl = new Label();
            lbl.Size = new Size(480, 100);
            panel.Controls.Add(lbl);
            //
            GroupBox gelenMesajKutusu = new GroupBox();
            gelenMesajKutusu.Text = mesaj.kimden;
            gelenMesajKutusu.BackColor = Color.Teal;
            gelenMesajKutusu.ForeColor = Color.White;
            gelenMesajKutusu.Font = new Font("Calibri", 12);
            gelenMesajKutusu.Size = new Size(390, 100);
            gelenMesajKutusu.RightToLeft = RightToLeft.Yes;
            panel.Controls.Add(gelenMesajKutusu);
            //
            Label zaman = new Label();
            zaman.Text = mesaj.zaman;
            zaman.Font = new Font("Calibri", 8);
            zaman.Location = new Point(295, 15);
            zaman.AutoSize = true;
            gelenMesajKutusu.Controls.Add(zaman);
            //
            RichTextBox icerik = new RichTextBox();
            icerik.Text = mesaj.icerik;
            icerik.BackColor = Color.Teal;
            icerik.ForeColor = Color.White;
            icerik.Location = new Point(15, 30);
            icerik.Size = new Size(360, 45);
            icerik.RightToLeft = RightToLeft.No;
            icerik.ReadOnly = true;
            icerik.BorderStyle = BorderStyle.None;
            gelenMesajKutusu.Controls.Add(icerik);
        }

    }
}
