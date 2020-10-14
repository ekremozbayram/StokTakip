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
    public partial class GelirRaporla : Form
    {
        public GelirRaporla()
        {
            InitializeComponent();
        }

        private void GelirRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'YedekParcaOtomasyonuDataSet.GELIR' table. You can move, or remove it, as needed.
            this.GELIRTableAdapter.Fill(this.YedekParcaOtomasyonuDataSet.GELIR);
            // TODO: This line of code loads data into the 'YazilimProjeDataSet.GELIR' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }
    }
}
