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
    public partial class GiderRaporla : Form
    {
        public GiderRaporla()
        {
            InitializeComponent();
        }

        private void GiderRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'YedekParcaOtomasyonuDataSet.GIDER' table. You can move, or remove it, as needed.
            this.GIDERTableAdapter.Fill(this.YedekParcaOtomasyonuDataSet.GIDER);

            this.reportViewer1.RefreshReport();
        }
    }
}
