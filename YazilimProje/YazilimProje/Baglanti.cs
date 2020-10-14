using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimProje
{
    class Baglanti
    {
        public string bagla()//Bağlantının tek yerden yapılması.
        {
            return "Server = DESKTOP-MO69B0G; Database = YedekParcaOtomasyonu; Integrated Security = SSPI";
        }

        //BÜTÜN FORMLARDAKİ COMBOBOXLARI PARAMETRE OLARAK ALIP TEK ELDEN DOLDURMAYA YARAR.
        public void comboDoldur(string komut,SqlConnection con,ComboBox cb,string id,string ad)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(komut, con);
            da2.Fill(dt2);
            cb.ValueMember = id;
            cb.DisplayMember = ad;
            cb.DataSource = dt2;
        }

        //BÜTÜN FORMLARDAKİ GRİDVİEW LERİ PARA METRE OLARAK ALIP TEK ELDEN DOLDURMAYA YARAR.
        public void gridViewDoldur(string komut,SqlConnection con,DataGridView dt)
        {
            SqlDataAdapter da8 = new SqlDataAdapter(komut, con);
            SqlCommandBuilder cc = new SqlCommandBuilder(da8);
            DataTable dt8 = new DataTable();
            da8.Fill(dt8);
            dt.DataSource = dt8;
        }
    }
}
