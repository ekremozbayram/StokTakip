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
    public partial class YonetimStok : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;
        public YonetimStok()
        {
            InitializeComponent();
        }

        //TEXTBOXLAR BOŞ OLMADIĞI ZAMAN PARÇA TABLOSUNA PARÇA EKLEME.
        private void SEkleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            if (SEPAdTb.Text != string.Empty && SEStokTb.Text != string.Empty && SEAlisTb.Text != string.Empty && SESatisTb.Text != string.Empty && SERafTb.Text != string.Empty && SETedarikTb.Text != string.Empty && SEMIdTb.Text != string.Empty)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO PARCA  VALUES ('" + SEPAdTb.Text + "','" + SEStokTb.Text + "','" + SEAlisTb.Text + "','" + SESatisTb.Text + "','" + SERafTb.Text + "','" + SETedarikTb.Text + "','" + SEMIdTb.Text + "')", con);
                SqlDataReader dr = komut.ExecuteReader();
                MessageBox.Show("PARÇA BAŞARI İLE KAYIT EDİLDİ.");
                dr.Close();

            }
            else
                MessageBox.Show("!! LÜTFEN İLGİLİ ALANLARI DOLDURUNUZ !!");
            con.Close();
            SEPAdTb.Text = "";
            SEStokTb.Text = "";
            SEAlisTb.Text = "";
            SESatisTb.Text = "";
            SERafTb.Text = "";
            SETedarikTb.Text = "";
            SEMIdTb.Text = "";
        }


        private void YonetimStok_Load(object sender, EventArgs e)//Açılırken gerekli yerleri doldurma işlemleri gerçekleşir.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            //Stok görüntülenin marka comboBox ı doldurma
            string komut = "select * from MARKA";
            baglanti.comboDoldur(komut,con,SMarkaCb,"markaID","markaAd");

            //Stok görüntülenin model comboBox ı seçili markaya göre doldurma.
            string komut1 = "select * from MODEL WHERE markaID='" + SMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut1, con, SModelCb, "modelID", "modelAd");

            //Stok görüntülenin parça comboBox ı seçili modele göre doldurma.
            string komut2 = "select * from PARCA WHERE modelID='" + SModelCb.SelectedValue + "'";
            baglanti.comboDoldur(komut2, con, SParcaCb, "parcaID", "parcaAd");

            //stok güncelle marka comboBox ı doldurma
            string komut3 = "select * from MARKA";
            baglanti.comboDoldur(komut3, con, SGMarkaCb, "markaID", "markaAd");

            //Stok güncelle model comboBox ı seçili markaya göre doldurma.
            string komut4 = "select * from MODEL WHERE markaID='" + SGMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut4, con, SGModelCb, "modelID", "modelAd");

            //Stok güncelle parça comboBox ı seçili modele göre doldurma.
            string komut5 = "select * from PARCA WHERE modelID='" + SGModelCb.SelectedValue + "'";
            baglanti.comboDoldur(komut5, con, SGParcaCb, "parcaID", "parcaAd");

            //Raporlama marka comboBox ı doldurma.
            string komut6 = "select * from MARKA";
            baglanti.comboDoldur(komut6, con, SRMarkaCb, "markaID", "markaAd");

            //Raporlama model comboBox ı seçili markaya göre doldurma.
            string komut7 = "select * from MODEL WHERE markaID='" + SRMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut7, con, SRModelCb, "modelID", "modelAd");

            //Raporlama kısmında seçili modele göre gridView doldurma.
            string komut8 = "SELECT parcaID as [ID],parcaAd as [PARCA AD],stok as [STOK],alisFiyat as [ALIŞ FİYAT],satisFiyat as [SATIŞ FİYAT],raf as [RAF KONUMU],tedarikciID as [TEDARİKCİ ID],modelID as [MODEL ID] FROM PARCA where modelID='" + SRModelCb.SelectedValue + "'";
            baglanti.gridViewDoldur(komut8, con, SRaporDg);
            con.Close();
        }

        private void SMarkaCb_SelectedIndexChanged(object sender, EventArgs e)//Marka değiştiği zaman diğer comboBox ları görüntüleme yerinde değiştirme.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            //Stok görüntüle de yeni marka seçilince modeli comboBox ı dodlurma.
            string komut = "select * from MODEL WHERE markaID='" + SMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut, con, SModelCb, "modelID", "modelAd");

            //Stok görüntüle de yeni model seçilince parça comboBox ı doldurma.
            string komut2 = "select * from PARCA WHERE modelID='" + SModelCb.SelectedValue + "'";
            baglanti.comboDoldur(komut2, con, SParcaCb, "parcaID", "parcaAd");
            con.Close();
        }

        private void SModelCb_SelectedIndexChanged(object sender, EventArgs e)//Model değiştiği zaman diğer comboBox ları görüntüleme yerinde değiştirme.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            //Stok görüntülede sadece model değişince parca comboBox ı doldurma.
            string komut = "select * from PARCA WHERE modelID='" + SModelCb.SelectedValue + "'";
            baglanti.comboDoldur(komut,con,SParcaCb,"parcaID","parcaAd");
            con.Close();
        }

        private void SGMarkaCb_SelectedIndexChanged(object sender, EventArgs e)//Marka güncelle değiştiği zaman diğer comboBox ları güncelleme yerinde değiştirme.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            //Stok güncelle de yeni marka seçilince model comboBox ı doldurma.
            string komut = "select * from MODEL WHERE markaID='" + SGMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut, con, SGModelCb, "modelID", "modelAd");

            //Stok güncelle de yeni modele göre parca comboBox ı doldurma.
            string komut2 = "select * from PARCA WHERE modelID='" + SGModelCb.SelectedValue + "'";
            baglanti.comboDoldur(komut2, con, SGParcaCb, "parcaID", "parcaAd");
            con.Close();
        }

        private void SGModelCb_SelectedIndexChanged(object sender, EventArgs e)//Model güncelle değiştiği zaman diğer comboBox ları güncelleme yerinde değiştirme.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            //Stok güncellede sadece model değişince parca comboBox ı doldurma.
            string komut = "select * from PARCA WHERE modelID='" + SGModelCb.SelectedValue + "'";
            baglanti.comboDoldur(komut, con, SGParcaCb, "parcaID", "parcaAd");
            con.Close();
        }

        private void SGorB_Click(object sender, EventArgs e)//Stok görüntülede gridView i seçili parçaya göre doldurma
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut = "SELECT parcaID as [ID],parcaAd as [PARCA AD],stok as [STOK],alisFiyat as [ALIŞ FİYAT],satisFiyat as [SATIŞ FİYAT],raf as [RAF KONUMU],tedarikciID as [TEDARİKCİ ID],modelID as [MODEL ID] FROM PARCA where parcaID='" + SParcaCb.SelectedValue + "'";
            baglanti.gridViewDoldur(komut, con, SParcaGDg);

            con.Close();
        }

        private void SRMarkaCb_SelectedIndexChanged(object sender, EventArgs e)//Raporlama ksımında marka değiştikçe model comboBox ı yenileme.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut = "select * from MODEL WHERE markaID='" + SRMarkaCb.SelectedValue + "'";
            baglanti.comboDoldur(komut, con, SRModelCb, "modelID", "modelAd");
            con.Close();
        }

        private void SGunBt_Click(object sender, EventArgs e)//Güncelleme de comboBox lara göre gridView i doldurma.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM PARCA WHERE parcaID="+SGParcaCb.SelectedValue+"",con);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            SStokTb.Text = dr["stok"].ToString();
            SAlisTb.Text = dr["alisFiyat"].ToString();
            SSatisTb.Text = dr["satisFiyat"].ToString();
            SRafTb.Text = dr["raf"].ToString();
            STedarikTb.Text = dr["tedarikciID"].ToString();
            con.Close();
        }

        private void SRModelCb_SelectedIndexChanged(object sender, EventArgs e)//Model değiştikçe rapor kısmındaki gridView i güncelleme.
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut = "SELECT parcaID as [ID],parcaAd as [PARCA AD],stok as [STOK],alisFiyat as [ALIŞ FİYAT],satisFiyat as [SATIŞ FİYAT],raf as [RAF KONUMU],tedarikciID as [TEDARİKCİ ID],modelID as [MODEL ID] FROM PARCA where modelID='" + SRModelCb.SelectedValue + "'";
            baglanti.gridViewDoldur(komut, con, SRaporDg);
            con.Close();
        }

        public static string gonder;//MODELID Yİ DATASET  İÇİN TUTAR.
        //MODEL ID YE GÖRE PARÇA RAPORLAMA
        private void SRaporB_Click(object sender, EventArgs e)
        {
            gonder = Convert.ToString(SRModelCb.SelectedValue);
            StokRaporlama stokR = new StokRaporlama();
            stokR.ShowDialog();
        }

        //TEXTBOX LARDAKİ YENİ GİRİŞLERE GÖRE BUTON TIKLANINCA VERİLERİ PARCA TABLOSUNDAN GÜNCELLEME.
        //GÜNCELLEME SONRASI GRİDVİEW İ YENİDEN YÜKLEME.
        private void SGuncelleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            if (SAlisTb.Text != string.Empty && SStokTb.Text != string.Empty && SSatisTb.Text != string.Empty && SRafTb.Text != string.Empty && STedarikTb.Text != string.Empty)
            {
                SqlCommand komut = new SqlCommand("UPDATE PARCA SET stok=" + SStokTb.Text + ",alisFiyat=" + SAlisTb.Text + ",satisFiyat=" + SSatisTb.Text + ",raf='" + SRafTb.Text + "',tedarikciID=" + STedarikTb.Text + " where parcaID=" + SGParcaCb.SelectedValue + "", con);
                SqlDataReader dr = komut.ExecuteReader();
                SStokTb.Text = "";
                SAlisTb.Text = "";
                SSatisTb.Text = "";
                SRafTb.Text = "";
                STedarikTb.Text = "";
                MessageBox.Show("GÜNCELLEME İŞLEMİ BAŞARI İLE GERÇEKLEŞMİŞTİR !!");
            }
            else
            {
                MessageBox.Show("LÜTFEN İLGİLİ ALANLARI DOLDURUNUZ !!");
            }
            con.Close();
        }

        //BELİRTİLEN ID DEKİ KAYDI SİLME.
        //GÜNCELLEME SONRASI GRİDVİEW İ YENİDEN YÜKLEME.
        private void SSilB_Click(object sender, EventArgs e)
        {
           con = new SqlConnection(baglanti.bagla());
            con.Open();
            SqlCommand komut = new SqlCommand("UPDATE PARCA SET stok="+0+" where parcaID="+SGParcaCb.SelectedValue+"",con);
            SqlDataReader dr = komut.ExecuteReader();
            MessageBox.Show("STOK SIFIRLAMA İŞLEMİ BAŞARI İLE GERÇEKLEŞMİŞTİR !!");
            con.Close();
        }
    }
}
