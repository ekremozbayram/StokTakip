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

    public partial class IsciStok : Form
    {
        public IsciStok()
        {
            InitializeComponent();
        }

        //Stok takip sayfasına yönlendirme.
        private void IStokB_Click(object sender, EventArgs e)
        {
            YonetimStok StokTakip = new YonetimStok();
            StokTakip.Show();
        }

        //Satış sayfasına yönlendirme.
        private void ISatisB_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
        }

        //KAPANDIĞINDA ANASAYFA FORMUNA GEÇİŞ.
        private void IsciStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        //ŞİFRE DEĞİŞTİRME FORMUNA YÖNLENDİRME.
        private void ISifDeB_Click(object sender, EventArgs e)
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
