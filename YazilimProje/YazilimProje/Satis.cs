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
    public partial class Satis : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;
        public Satis()
        {
            InitializeComponent();
        }

        //FORMDAKİ COMBOBOXLARI BİRBİRİNE BAĞLI OLARAK DOLDURUP, PARÇANIN SATIŞ FİYATINI TEXTBOX A DOLDURMA.
        private void Satis_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut1 = "SELECT * FROM MARKA";
            baglanti.comboDoldur(komut1,con,SaMarkaCb,"markaID","markaAd");
            string komut2 = "SELECT * FROM MODEL WHERE markaID=" + SaMarkaCb.SelectedValue + "";
            baglanti.comboDoldur(komut2, con, SaModelCb, "modelID", "modelAd");
            string komut3 = "SELECT * FROM PARCA WHERE modelID=" + SaModelCb.SelectedValue + " and stok>"+0+"";
            baglanti.comboDoldur(komut3,con,SaParcaCb,"parcaID","parcaAd");
            con.Close();
            //TEXTBOX A SATIŞ FİYATI ÇEKME.
            con.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM PARCA WHERE parcaID=" + SaParcaCb.SelectedValue + "", con);
            SqlDataReader dr4 = komut4.ExecuteReader();
            dr4.Read();
            SaFiyatTb.Text = dr4["satisFiyat"].ToString();
            dr4.Close();
            con.Close();
        }

        //MARKA COMBOBOX A GÖRE DİĞER BÖLÜMLERİ YENİDEN DOLDURMA.
        private void SaMarkaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut2 = "SELECT * FROM MODEL WHERE markaID='" + SaMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut2, con, SaModelCb, "modelID", "modelAd");
            string komut3 = "SELECT * FROM PARCA WHERE modelID='" + SaModelCb.SelectedValue + "'and stok>" + 0 + "";
            baglanti.comboDoldur(komut3, con, SaParcaCb, "parcaID", "parcaAd");
            con.Close();
            con.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM PARCA WHERE parcaID='" + SaParcaCb.SelectedValue + "'", con);
            SqlDataReader dr = komut4.ExecuteReader();
            dr.Read();
            SaFiyatTb.Text = dr["satisFiyat"].ToString();
            dr.Close();
            con.Close();
        }

        //MODEL COMBOBOX A GÖRE DİĞER BÖLÜMLERİ YENİDEN DOLDURMA.
        private void SaModelCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut3 = "SELECT * FROM PARCA WHERE modelID='" + SaModelCb.SelectedValue + "' and stok>" + 0 + "";
            baglanti.comboDoldur(komut3, con, SaParcaCb, "parcaID", "parcaAd");
            con.Close();
            con.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM PARCA WHERE parcaID='" + SaParcaCb.SelectedValue + "'", con);
            SqlDataReader dr = komut4.ExecuteReader();
            dr.Read();
            SaFiyatTb.Text = dr["satisFiyat"].ToString();
            dr.Close();
            con.Close();
        }

        //GELİR TABLOSUNA COMBOBOXDAN SEÇİLEN PARÇANIN, İSTENİLEN ADET VE O GÜNÜN TARİHİNE GÖRE KAYIT EDİLMESİ.
        private void SaSatisB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            if (SaAdetTb.Text != string.Empty)
            {
                double tutar = Convert.ToDouble(SaFiyatTb.Text) * Convert.ToInt64(SaAdetTb.Text);//ADET İLE SEÇİLİNİN SATIŞ FİYATINDAN TOPLAM TUTARIN BULUNMASI.
                DateTime zaman = DateTime.Now.Date;
                string format = "yyyy-MM-dd";//TARİHİN FORMATLANIP VERİ TABANINA YOLLANMASI.
                string zamanim = zaman.ToString(format);
                SqlCommand komut = new SqlCommand("insert into GELIR values('" + tutar + "','" + zamanim + "','" + SaParcaCb.SelectedValue + "',"+SaAdetTb.Text+")", con);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Close();
                SaAdetTb.Text = "";
                MessageBox.Show("SATIŞ İŞLEMi BAŞARI İLE GERÇEKLEŞTİ");
            }
            else
                MessageBox.Show("İLGİLİ ALANI DOLDURUNUZ!!");
            con.Close();
        }

        //PARÇA COMBOBOX I ÜZERİNDE SEÇİLİ PARÇANIN SATIŞ FİYATINI TEXTBOX A YOLLAR.
        private void SaParcaCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM PARCA WHERE parcaID='" + SaParcaCb.SelectedValue + "'", con);
            SqlDataReader dr = komut4.ExecuteReader();
            dr.Read();
            SaFiyatTb.Text = dr["satisFiyat"].ToString();
            dr.Close();
            con.Close();
        }

    }
}
