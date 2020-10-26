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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                AnaEkran anaEkran = new AnaEkran();
                anaEkran._isim = textBox1.Text;
                anaEkran._durum = "Aktif";
                anaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("İsmin olmadan katılamayacığını biliyorsun dostum !", "İsimsiz Kullanıcı Tespit Edildi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris_Click(btnGiris, new EventArgs());
            }
        }
    }
}
