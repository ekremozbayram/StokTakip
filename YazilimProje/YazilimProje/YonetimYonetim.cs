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
    public partial class YonetimYonetim : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;

        public YonetimYonetim()
        {
            InitializeComponent();
        }

        //TABCONTROL İÇİNDEKİ BÜTÜN GRİDVİEW LERİ DOLDURUR VE AS[..] KOLON İSİMLERİNİ DÜZENLER.
        private void YonetimYonetim_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut = "SELECT isciID as [ID],adSoyad as[AD SOYAD],telNo as [İLETİŞİM],adres as [ADRES],maas as [MAAŞ],unvan as [UNVAN] FROM ISCI";
            baglanti.gridViewDoldur(komut, con, YIGorDg);
            string komut1 = "SELECT tedarikciID as [ID],tedarikciAd as [ŞİRKET ADI],telNo as [İLETİŞİM],adres as [ADRES] FROM TEDARIKCI";
            baglanti.gridViewDoldur(komut1, con, YTGorDg);
            string komut2 = "SELECT Isi.isciID AS [ID], ISi.adSoyad AS [AD SOYAD],I.BaslaT AS[BAŞLANGIÇ TARİHİ],I.BitT AS [BİTİŞ TARİHİ] FROM IZIN I, ISCI ISi where I.isciID=ISi.isciID";
            baglanti.gridViewDoldur(komut2, con, YIzGorDg);
            con.Close();
        }
        private static long id;
        //İŞÇİ GÖRÜNTÜLEMEDEKİ TEXTBOXLARI SEÇİLEN GRİDVİEW ÖGESİ İLE DOLDURMA.
        private void YIGorDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = YIGorDg.SelectedCells[0].RowIndex;
            //MessageBox.Show(""+secim);
            id = (long)YIGorDg.Rows[secim].Cells[0].Value;
            YIAdTb1.Text = (string)YIGorDg.Rows[secim].Cells[1].Value.ToString();
            YITelTb1.Text = (string)YIGorDg.Rows[secim].Cells[2].Value.ToString();
            YIAdresTb1.Text = (string)YIGorDg.Rows[secim].Cells[3].Value.ToString();
            YIMaasTb1.Text = (string)YIGorDg.Rows[secim].Cells[4].Value.ToString();
            YIUnvanTb1.Text = (string)YIGorDg.Rows[secim].Cells[5].Value.ToString();
            YISilTb.Text = (string)YIGorDg.Rows[secim].Cells[0].Value.ToString();
        }

        //TEXTBOX ÜZERİNDEKİ YENİ VERİ GİRİŞLERİNE GÖRE İŞÇİ TABLOSUNU GÜNCELLEME VE GRİDVİEW İ GÜNCELLEYİP GÖRÜNTÜLEME.
        private void YIGuncelleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            
            SqlCommand komut = new SqlCommand("UPDATE ISCI SET adSoyad='"+YIAdTb1.Text+"',telNo="+YITelTb1.Text+",adres='"+YIAdresTb1.Text+"',maas="+YIMaasTb1.Text+",unvan="+YIUnvanTb1.Text+" WHERE isciID="+id+ " ",con);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Close();
            string komut2 = "SELECT isciID as [ID],adSoyad as [AD SOYAD],telNo as [İLETİŞİM],adres as [ADRES],maas as [MAAŞ],unvan as [UNVAN] FROM ISCI";
            baglanti.gridViewDoldur(komut2, con, YIGorDg);
            
            YISilTb.Text = " ";
            YIAdTb1.Text = " ";
            YITelTb1.Text = " ";
            YIAdresTb1.Text = " ";
            YIMaasTb1.Text = " ";
            YIUnvanTb1.Text = " ";
            con.Close();
        }

        //GİRİLEN ID YE GÖRE ISCI SİLVE VE GRİDVİEW İ GÜNCELLEYİP GÖRÜNTÜLEME.
        private void YISilB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            if (YISilTb.Text != string.Empty)
            {
                SqlCommand komut = new SqlCommand("UPDATE ISCI SET sifre="+1234+",unvan=" + 0 + " where isciID=" + YISilTb.Text + "", con);
                SqlDataReader dr = komut.ExecuteReader();
                dr.Close();
                string komut2 = "SELECT isciID as [ID],adSoyad as[AD SOYAD],telNo as [İLETİŞİM],adres as [ADRES],maas as [MAAŞ],unvan as [UNVAN] FROM ISCI";
                baglanti.gridViewDoldur(komut2, con, YIGorDg);
                YISilTb.Text = "";
                YIAdTb1.Text = " ";
                YITelTb1.Text = " ";
                YIAdresTb1.Text = " ";
                YIMaasTb1.Text = " ";
                YIUnvanTb1.Text = " ";
                MessageBox.Show("KAYIT ENGELLEME İŞLEMİ BAŞARI İLE GERÇEKLEŞTİ.");
            }
            else
                MessageBox.Show("LÜTFEN SEÇİM YAPINIZ !!");
            con.Close();
        }

        //TEXTBOX LARDAKİ BİLGİLERE GÖRE İŞÇİ TABLOSUNA İŞÇİ EKLEME VE GRİDVİEW İ GÜNCELLEYİP GÖRÜNTÜLEME.
        private void YIEkleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            SqlCommand komut = new SqlCommand("insert into ISCI values ("+YITcTb.Text+",'"+YIAdTb.Text+"',"+YISifreTb.Text+","+YITelTb.Text+",'"+YIAdresTb.Text+"',"+YIMaasTb.Text+","+YIUnvanTb.Text+")", con);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Close();
            string komut2 = "SELECT isciID as [ID],adSoyad as[AD SOYAD],telNo as [İLETİŞİM],adres as [ADRES],maas as [MAAŞ],unvan as [UNVAN] FROM ISCI";
            baglanti.gridViewDoldur(komut2, con, YIGorDg);
            YITcTb.Text = "";
            YIAdTb.Text = "";
            YISifreTb.Text = "";
            YITelTb.Text = "";
            YIAdresTb.Text = "";
            YIMaasTb.Text = "";
            YIUnvanTb.Text = "";
            con.Close();
        }

        //TEXTBOX LARDAKİ VERİLERE GÖRE TEDARİKÇİ EKLEME VE GRİDVİEW İ GÜNCELLEYİP GÖRÜNTÜLEME.
        private void YTEkleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TEDARIKCI VALUES ('" + YTAdTb.Text + "'," + YTTelTb.Text + ",'" + YTAdresTb.Text + "')", con);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Close();
            string komut2 = "SELECT tedarikciID as [ID],tedarikciAd as [ŞİRKET ADI],telNo as [İLETİŞİM],adres as [ADRES] FROM TEDARIKCI"; 
            baglanti.gridViewDoldur(komut2, con, YTGorDg);
            YTAdTb.Text = "";
            YTTelTb.Text = "";
            YTAdresTb.Text = "";
            con.Close();
        }

        //SEÇİLEN DATETİMEPİCKER VERİLERİNE VE TEXTBOX ÜZERİNDEKİ VERİLERE GÖRE İŞÇİ İZİN EKLER.
        //GRİDVİEW İ GÜNCELLER VE GÖRÜNTÜLER.
        private void YIzEkleB_Click(object sender, EventArgs e)
        {
            con=new SqlConnection(baglanti.bagla());
            con.Open();
            string format= "yyyy-MM-dd";
            DateTime tp= YIzBasDtp.Value;
            string tpBas = tp.ToString(format);
            DateTime tp1 = YIzBitDtp.Value;
            string tpBit = tp1.ToString(format);
            SqlCommand komut = new SqlCommand("INSERT INTO IZIN VALUES ('" + tpBas + "','" + tpBit + "','" + YIzTcTb.Text + "')", con);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Close();
            con.Close();
            con.Open();
            string komut2 = "SELECT Isi.isciID AS [ID], ISi.adSoyad AS [AD SOYAD],I.BaslaT AS[BAŞLANGIÇ TARİHİ],I.BitT AS [BİTİŞ TARİHİ] FROM IZIN I, ISCI ISi where I.isciID=ISi.isciID";
            baglanti.gridViewDoldur(komut2, con, YIzGorDg);
            con.Close();
        }

        //TEDARİKÇİ GRİDVİEW İNİ RAPORLAR.
        private void YTRaporB_Click(object sender, EventArgs e)
        {
            TedarikciRaporla tedarikciR = new TedarikciRaporla();
            tedarikciR.ShowDialog();
        }

    }
}
