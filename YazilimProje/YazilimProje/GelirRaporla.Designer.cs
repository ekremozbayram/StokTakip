namespace YazilimProje
{
    partial class GelirRaporla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirRaporla));
            this.GELIRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YedekParcaOtomasyonuDataSet = new YazilimProje.YedekParcaOtomasyonuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GELIRTableAdapter = new YazilimProje.YedekParcaOtomasyonuDataSetTableAdapters.GELIRTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GELIRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YedekParcaOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GELIRBindingSource
            // 
            this.GELIRBindingSource.DataMember = "GELIR";
            this.GELIRBindingSource.DataSource = this.YedekParcaOtomasyonuDataSet;
            // 
            // YedekParcaOtomasyonuDataSet
            // 
            this.YedekParcaOtomasyonuDataSet.DataSetName = "YedekParcaOtomasyonuDataSet";
            this.YedekParcaOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GELIRBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YazilimProje.GelirR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(596, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // GELIRTableAdapter
            // 
            this.GELIRTableAdapter.ClearBeforeFill = true;
            // 
            // GelirRaporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 313);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GelirRaporla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GelirRaporla";
            this.Load += new System.EventHandler(this.GelirRaporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GELIRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YedekParcaOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GELIRBindingSource;
        private YedekParcaOtomasyonuDataSet YedekParcaOtomasyonuDataSet;
        private YedekParcaOtomasyonuDataSetTableAdapters.GELIRTableAdapter GELIRTableAdapter;
    }
}