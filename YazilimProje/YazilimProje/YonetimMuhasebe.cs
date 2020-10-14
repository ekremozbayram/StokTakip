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
    public partial class YonetimMuhasebe : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;

        public YonetimMuhasebe()
        {
            InitializeComponent();
        }

        //DATAGRİDVİEW LERİN DOLDURULMASI. 
        //AS [..] İŞLEMİ GRİDVİEW KOLONLARINA YENİ BAŞLIK VERİR.
        private void YonetimMuhasebe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string komut = "SELECT P.parcaID as [ID],P.parcaAd as [PARÇA AD],G.tarih as [TARİH],G.adet as [ADET],G.tutar as [TUTAR] FROM GELIR G, PARCA P WHERE G.parcaID=P.parcaID";
            baglanti.gridViewDoldur(komut,con,YMGelirDg);
            string komut2 = "SELECT P.parcaID as [ID],P.parcaAd as [PARÇA AD],G.tarih as [TARİH],g.adet as [ADET],g.tutar as [TUTAR] FROM GIDER G, PARCA P WHERE G.parcaID=P.parcaID";
            baglanti.gridViewDoldur(komut2, con, YMGiderDg);
            con.Close();
        }

        //GİDER TABLOSUNA ALIŞ YAPTIĞIMIZ FATURA KALEMLERİNİ EKLEME.
        private void YGEkleB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());
            con.Open();
            string format = "yyyy-MM-dd";
            DateTime tp = YGEkleDtp.Value;
            string tarih = tp.ToString(format);
            SqlCommand komut2 =new SqlCommand( "INSERT INTO GIDER VALUES ("+Convert.ToDouble(YGTutarTb.Text)+",'"+tarih+"',"+YGEkleTb.Text+","+YGAdetTb.Text+")",con);
            SqlDataReader dr = komut2.ExecuteReader();
            dr.Close();
            //EKLEMEDEN SONRA GRİDVİEW İN YENİDEN GÜNCELLENMESİ
            string komut3 = "SELECT P.parcaID as [ID],P.parcaAd as [PARÇA AD],G.tarih as [TARİH],g.adet as [ADET],g.tutar as [TUTAR] FROM GIDER G, PARCA P WHERE G.parcaID=P.parcaID";
            baglanti.gridViewDoldur(komut3, con, YMGiderDg);
            YGEkleTb.Text = "";
            YGAdetTb.Text = "";
            YGTutarTb.Text = "";
            con.Close();
        }

        //GELİR TABLOSUNDAKİ GRİDVİEW İ RAPORLAR.
        private void YMGelirRB_Click(object sender, EventArgs e)
        {
            GelirRaporla gelirR = new GelirRaporla();
            gelirR.ShowDialog();
        }

        //GİDER TABLOSUNDAKİ GRİDVİEW İ RAPORLAR.
        private void YMGiderRB_Click(object sender, EventArgs e)
        {
            GiderRaporla giderR = new GiderRaporla();
            giderR.ShowDialog();
        }
    }
}
