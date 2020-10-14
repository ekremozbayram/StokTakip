namespace YazilimProje
{
    partial class Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpB = new System.Windows.Forms.Button();
            this.YSifDeB = new System.Windows.Forms.Button();
            this.SatisB = new System.Windows.Forms.Button();
            this.MuhasebeB = new System.Windows.Forms.Button();
            this.YonetimB = new System.Windows.Forms.Button();
            this.StokTakipB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::YazilimProje.Properties.Resources.Sahinler;
            this.panel1.Controls.Add(this.helpB);
            this.panel1.Controls.Add(this.YSifDeB);
            this.panel1.Controls.Add(this.SatisB);
            this.panel1.Controls.Add(this.MuhasebeB);
            this.panel1.Controls.Add(this.YonetimB);
            this.panel1.Controls.Add(this.StokTakipB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 288);
            this.panel1.TabIndex = 0;
            // 
            // helpB
            // 
            this.helpB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpB.Location = new System.Drawing.Point(0, 265);
            this.helpB.Name = "helpB";
            this.helpB.Size = new System.Drawing.Size(64, 23);
            this.helpB.TabIndex = 5;
            this.helpB.Text = "YARDIM";
            this.helpB.UseVisualStyleBackColor = true;
            this.helpB.Click += new System.EventHandler(this.helpB_Click);
            // 
            // YSifDeB
            // 
            this.YSifDeB.BackColor = System.Drawing.Color.Transparent;
            this.YSifDeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YSifDeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YSifDeB.Location = new System.Drawing.Point(418, 145);
            this.YSifDeB.Name = "YSifDeB";
            this.YSifDeB.Size = new System.Drawing.Size(100, 36);
            this.YSifDeB.TabIndex = 4;
            this.YSifDeB.Text = "ŞİFRE DEĞİŞTİR";
            this.YSifDeB.UseVisualStyleBackColor = false;
            this.YSifDeB.Click += new System.EventHandler(this.YSifDeB_Click);
            // 
            // SatisB
            // 
            this.SatisB.BackColor = System.Drawing.Color.White;
            this.SatisB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SatisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatisB.Location = new System.Drawing.Point(151, 3);
            this.SatisB.Name = "SatisB";
            this.SatisB.Size = new System.Drawing.Size(100, 36);
            this.SatisB.TabIndex = 3;
            this.SatisB.Text = "SATIŞ";
            this.SatisB.UseVisualStyleBackColor = false;
            this.SatisB.Click += new System.EventHandler(this.SatisB_Click);
            // 
            // MuhasebeB
            // 
            this.MuhasebeB.BackColor = System.Drawing.Color.White;
            this.MuhasebeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MuhasebeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MuhasebeB.Location = new System.Drawing.Point(409, 3);
            this.MuhasebeB.Name = "MuhasebeB";
            this.MuhasebeB.Size = new System.Drawing.Size(100, 36);
            this.MuhasebeB.TabIndex = 2;
            this.MuhasebeB.Text = "MUHASEBE";
            this.MuhasebeB.UseVisualStyleBackColor = false;
            this.MuhasebeB.Click += new System.EventHandler(this.MuhasebeB_Click);
            // 
            // YonetimB
            // 
            this.YonetimB.BackColor = System.Drawing.Color.White;
            this.YonetimB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YonetimB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetimB.Location = new System.Drawing.Point(289, 3);
            this.YonetimB.Name = "YonetimB";
            this.YonetimB.Size = new System.Drawing.Size(100, 36);
            this.YonetimB.TabIndex = 1;
            this.YonetimB.Text = "YÖNETİM";
            this.YonetimB.UseVisualStyleBackColor = false;
            this.YonetimB.Click += new System.EventHandler(this.YonetimB_Click);
            // 
            // StokTakipB
            // 
            this.StokTakipB.BackColor = System.Drawing.Color.White;
            this.StokTakipB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StokTakipB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokTakipB.Location = new System.Drawing.Point(12, 3);
            this.StokTakipB.Name = "StokTakipB";
            this.StokTakipB.Size = new System.Drawing.Size(100, 36);
            this.StokTakipB.TabIndex = 0;
            this.StokTakipB.Text = "STOK TAKİP";
            this.StokTakipB.UseVisualStyleBackColor = false;
            this.StokTakipB.Click += new System.EventHandler(this.StokTakipB_Click);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::YazilimProje.Properties.Resources.ŞAHİNLER;
            this.ClientSize = new System.Drawing.Size(521, 288);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK TAKİP VE ŞİRKET YÖNETİMİ ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stok_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MuhasebeB;
        private System.Windows.Forms.Button YonetimB;
        private System.Windows.Forms.Button StokTakipB;
        private System.Windows.Forms.Button SatisB;
        private System.Windows.Forms.Button YSifDeB;
        private System.Windows.Forms.Button helpB;
    }
}