namespace YazilimProje
{
    partial class YonetimMuhasebe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetimMuhasebe));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.YMGelirRB = new System.Windows.Forms.Button();
            this.YMGelirDg = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.YGAdetTb = new System.Windows.Forms.TextBox();
            this.ADET = new System.Windows.Forms.Label();
            this.YGTutarTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YGEkleB = new System.Windows.Forms.Button();
            this.YGEkleDtp = new System.Windows.Forms.DateTimePicker();
            this.YGEkleTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YMGiderRB = new System.Windows.Forms.Button();
            this.YMGiderDg = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YMGelirDg)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YMGiderDg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.YMGelirRB);
            this.tabPage1.Controls.Add(this.YMGelirDg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GELİR TABLOSU";
            // 
            // YMGelirRB
            // 
            this.YMGelirRB.BackColor = System.Drawing.Color.Transparent;
            this.YMGelirRB.Location = new System.Drawing.Point(601, 334);
            this.YMGelirRB.Name = "YMGelirRB";
            this.YMGelirRB.Size = new System.Drawing.Size(138, 48);
            this.YMGelirRB.TabIndex = 1;
            this.YMGelirRB.Text = "RAPORLA";
            this.YMGelirRB.UseVisualStyleBackColor = false;
            this.YMGelirRB.Click += new System.EventHandler(this.YMGelirRB_Click);
            // 
            // YMGelirDg
            // 
            this.YMGelirDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YMGelirDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YMGelirDg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.YMGelirDg.Location = new System.Drawing.Point(21, 16);
            this.YMGelirDg.Name = "YMGelirDg";
            this.YMGelirDg.Size = new System.Drawing.Size(733, 271);
            this.YMGelirDg.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.YMGiderRB);
            this.tabPage2.Controls.Add(this.YMGiderDg);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GİDER TABLOSU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.YGAdetTb);
            this.groupBox1.Controls.Add(this.ADET);
            this.groupBox1.Controls.Add(this.YGTutarTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.YGEkleB);
            this.groupBox1.Controls.Add(this.YGEkleDtp);
            this.groupBox1.Controls.Add(this.YGEkleTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FATURA EKLE";
            // 
            // YGAdetTb
            // 
            this.YGAdetTb.Location = new System.Drawing.Point(97, 95);
            this.YGAdetTb.Name = "YGAdetTb";
            this.YGAdetTb.Size = new System.Drawing.Size(118, 20);
            this.YGAdetTb.TabIndex = 3;
            // 
            // ADET
            // 
            this.ADET.AutoSize = true;
            this.ADET.Location = new System.Drawing.Point(17, 102);
            this.ADET.Name = "ADET";
            this.ADET.Size = new System.Drawing.Size(36, 13);
            this.ADET.TabIndex = 7;
            this.ADET.Text = "ADET";
            // 
            // YGTutarTb
            // 
            this.YGTutarTb.Location = new System.Drawing.Point(97, 64);
            this.YGTutarTb.Name = "YGTutarTb";
            this.YGTutarTb.Size = new System.Drawing.Size(118, 20);
            this.YGTutarTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TUTAR";
            // 
            // YGEkleB
            // 
            this.YGEkleB.Location = new System.Drawing.Point(168, 160);
            this.YGEkleB.Name = "YGEkleB";
            this.YGEkleB.Size = new System.Drawing.Size(105, 33);
            this.YGEkleB.TabIndex = 5;
            this.YGEkleB.Text = "EKLE";
            this.YGEkleB.UseVisualStyleBackColor = true;
            this.YGEkleB.Click += new System.EventHandler(this.YGEkleB_Click);
            // 
            // YGEkleDtp
            // 
            this.YGEkleDtp.Location = new System.Drawing.Point(97, 122);
            this.YGEkleDtp.Name = "YGEkleDtp";
            this.YGEkleDtp.Size = new System.Drawing.Size(200, 20);
            this.YGEkleDtp.TabIndex = 4;
            // 
            // YGEkleTb
            // 
            this.YGEkleTb.Location = new System.Drawing.Point(97, 25);
            this.YGEkleTb.Name = "YGEkleTb";
            this.YGEkleTb.Size = new System.Drawing.Size(118, 20);
            this.YGEkleTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TARİH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARÇA ID";
            // 
            // YMGiderRB
            // 
            this.YMGiderRB.Location = new System.Drawing.Point(576, 335);
            this.YMGiderRB.Name = "YMGiderRB";
            this.YMGiderRB.Size = new System.Drawing.Size(147, 47);
            this.YMGiderRB.TabIndex = 6;
            this.YMGiderRB.Text = "RAPORLA";
            this.YMGiderRB.UseVisualStyleBackColor = true;
            this.YMGiderRB.Click += new System.EventHandler(this.YMGiderRB_Click);
            // 
            // YMGiderDg
            // 
            this.YMGiderDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.YMGiderDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.YMGiderDg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.YMGiderDg.Location = new System.Drawing.Point(19, 17);
            this.YMGiderDg.Name = "YMGiderDg";
            this.YMGiderDg.Size = new System.Drawing.Size(739, 217);
            this.YMGiderDg.TabIndex = 0;
            // 
            // YonetimMuhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YonetimMuhasebe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUHASEBE";
            this.Load += new System.EventHandler(this.YonetimMuhasebe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.YMGelirDg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YMGiderDg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView YMGelirDg;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button YMGelirRB;
        private System.Windows.Forms.Button YMGiderRB;
        private System.Windows.Forms.DataGridView YMGiderDg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YGEkleB;
        private System.Windows.Forms.DateTimePicker YGEkleDtp;
        private System.Windows.Forms.TextBox YGEkleTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YGTutarTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YGAdetTb;
        private System.Windows.Forms.Label ADET;
    }
}