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
    public partial class StokRaporlama : Form
    {
        Baglanti baglanti = new Baglanti();
        SqlConnection con;
        public StokRaporlama()
        {
            InitializeComponent();
        }

        private void StokRaporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'YedekParcaOtomasyonuDataSet.PARCA' table. You can move, or remove it, as needed.
            int modID = Convert.ToInt32(YonetimStok.gonder);
            this.PARCATableAdapter.Fill(this.YedekParcaOtomasyonuDataSet.PARCA,modID);
            this.reportViewer1.RefreshReport();
        }
    }
}
