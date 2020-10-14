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
    public partial class Form1 : Form
    {
        Baglanti baglanti = new Baglanti();//Sql bağlantısı classdan çekildi.
        SqlConnection con;//Global olarak bağlantı oluşturuldu.

        public Form1()
        {
            InitializeComponent();
        }

        public static string tc;//DİĞER FORMLARDAN ULAŞABİLMEK İÇİN GLOBAL DEĞİŞKEN.
        public static string sifre;

        private void KGirisB_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(baglanti.bagla());//con değişkenine classdan çekilen bağlantı aktarıldı.
            con.Open();
            //Girilen textbox ların eşlemesini sağlayan komut.
            SqlCommand komut = new SqlCommand("SELECT * FROM ISCI WHERE isciID='" + KAdiTb.Text + "' AND sifre='" + KSifreTb.Text + "'", con);
            SqlDataReader dr = komut.ExecuteReader();//Komutun çalıştırılması.
            tc = KAdiTb.Text;
            sifre = KSifreTb.Text;
            while (dr.Read())//Ünvanın durumuna göre veri tabanından girilecek sayfalara yönlendirme.
            {
                if (dr != null && dr.HasRows && Convert.ToInt16(dr["UNVAN"]) == 1)
                {
                    IsciStok iAnasayfa = new IsciStok();
                    iAnasayfa.Show();
                    this.Hide();
                }
                else if (dr != null && dr.HasRows && Convert.ToInt16(dr["UNVAN"]) == 2)
                {
                    Stok yAnasayfa = new Stok();
                    yAnasayfa.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("YETKİNİZ KALDIRILMIŞTIR !!");

            }
            if (dr.Read() == false && dr.HasRows == false)//Hata kontrolü.
            {
                MessageBox.Show("HATALI GİRİŞ!!\nBİLGİLERİNİZİ KONTROL EDİNİZ.");

            }

            dr.Close();
            con.Close();
        }

        //SİSTEMİN TAMAMEN KAPATILMASI
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help hlp = new Help();
            hlp.Show();
        }
    }
}
