using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimProje
{
    public partial class Stok : Form
    {

        public Stok()
        {
            InitializeComponent();
        }

        //Stok takip sayfasına yönlendirme
        private void StokTakipB_Click(object sender, EventArgs e)
        {
            YonetimStok StokTakip = new YonetimStok();
            StokTakip.Show();
        }

        //Yönetim sayfasına yönlendirme.
        private void YonetimB_Click(object sender, EventArgs e)
        {
            YonetimYonetim yonetim = new YonetimYonetim();
            yonetim.Show();
        }

        //Muhasebe sayfasına yönlendirme
        private void MuhasebeB_Click(object sender, EventArgs e)
        {
            YonetimMuhasebe muhasebe = new YonetimMuhasebe();
            muhasebe.Show();
        }

        //Satış sayfasına yönlendirme.
        private void SatisB_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
        }

        //STOK SAYFASI KAPANINCA GİRİŞ SAYFASINA DÖNME.
        private void Stok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
            
        }

        //KULLANICININ ŞİFRE DEĞİŞTİR EKRANINA YÖNLENDİRİLMESİ.
        private void YSifDeB_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreD = new SifreDegistir();
            sifreD.ShowDialog();
        }

        private void helpB_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.Show();
        }
    }
}
