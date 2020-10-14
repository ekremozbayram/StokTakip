namespace YazilimProje
{
    partial class StokRaporlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokRaporlama));
            this.PARCABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YedekParcaOtomasyonuDataSet = new YazilimProje.YedekParcaOtomasyonuDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PARCATableAdapter = new YazilimProje.YedekParcaOtomasyonuDataSetTableAdapters.PARCATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PARCABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YedekParcaOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PARCABindingSource
            // 
            this.PARCABindingSource.DataMember = "PARCA";
            this.PARCABindingSource.DataSource = this.YedekParcaOtomasyonuDataSet;
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
            reportDataSource1.Value = this.PARCABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YazilimProje.StokR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(581, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // PARCATableAdapter
            // 
            this.PARCATableAdapter.ClearBeforeFill = true;
            // 
            // StokRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 280);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokRaporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokRaporlama";
            this.Load += new System.EventHandler(this.StokRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PARCABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YedekParcaOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PARCABindingSource;
        private YedekParcaOtomasyonuDataSet YedekParcaOtomasyonuDataSet;
        private YedekParcaOtomasyonuDataSetTableAdapters.PARCATableAdapter PARCATableAdapter;
    }
}