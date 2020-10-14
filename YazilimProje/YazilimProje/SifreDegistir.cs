using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimProje
{
    public partial class SifreDegistir : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;

        public SifreDegistir()
        {
            InitializeComponent();
        }

        //FORM1 ÜZERİNDEN GİRİLEN ID NİN YENİDEN İNT VERSİYONA ÇEVRİLİR.
        public long tc = Convert.ToInt64(Form1.tc);

        //KOŞULLAR SAĞLANIYOR İSE ŞİFRENİN GÜNCELLENMESİ AKSİ HALDE HATA MESAJININ VERİLMESİ.
        private void KSifDeB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            if (Convert.ToString(KSifDeTb.Text) == Convert.ToString(KSifDeTb1.Text)&&KEsDeTb.Text==Form1.sifre)//İKİ TEXTBOX DA YENİLENECEK ŞİFRENİN AYNI OLMASI KOŞULU.
            {
                con.Open();
                SqlCommand komut = new SqlCommand("UPDATE ISCI SET sifre =" + KSifDeTb.Text + " where isciID=" + Form1.tc + "", con);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Close();
                con.Close();
                MessageBox.Show("DEĞİŞİKLİK İŞLEMİ BAŞARI İLE GERÇEKLEŞMİŞTİR");
            }
            else
            {
                MessageBox.Show("LÜTFEN ŞİFRELERİN AYNI OLDUĞUNDAN EMİN OLUNUZ");
            }
            KSifDeTb.Text = "";
            KSifDeTb1.Text = "";
            KEsDeTb.Text = "";
        }

        //LABEL4 ÜN TEXT KISMINA SİSTEME GİRİŞ YAPMIŞ KULLANICININ ADINI SOYADINI YAZDIRMA.
        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            SqlCommand komut = new SqlCommand("Select * from ISCI where isciID="+tc+"",con);
            SqlDataReader dr = komut.ExecuteReader();
            string ad="";
            while (dr.Read())
            {
                ad = dr["adSoyad"].ToString();
            }
            label4.Text = ad;
            dr.Close();
            con.Close();
        }
    }
}
