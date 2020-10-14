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
    public partial class TedarikciRaporla : Form
    {
        public TedarikciRaporla()
        {
            InitializeComponent();
        }

        private void TedarikciRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'YedekParcaOtomasyonuDataSet.TEDARIKCI' table. You can move, or remove it, as needed.
            this.TEDARIKCITableAdapter.Fill(this.YedekParcaOtomasyonuDataSet.TEDARIKCI);
            this.reportViewer1.RefreshReport();
        }
    }
}
