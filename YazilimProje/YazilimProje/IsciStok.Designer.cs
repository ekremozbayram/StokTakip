namespace YazilimProje
{
    partial class IsciStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsciStok));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpB = new System.Windows.Forms.Button();
            this.ISifDeB = new System.Windows.Forms.Button();
            this.ISatisB = new System.Windows.Forms.Button();
            this.IStokB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::YazilimProje.Properties.Resources.Sahinler;
            this.panel1.Controls.Add(this.helpB);
            this.panel1.Controls.Add(this.ISifDeB);
            this.panel1.Controls.Add(this.ISatisB);
            this.panel1.Controls.Add(this.IStokB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 289);
            this.panel1.TabIndex = 0;
            // 
            // helpB
            // 
            this.helpB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpB.Location = new System.Drawing.Point(0, 266);
            this.helpB.Name = "helpB";
            this.helpB.Size = new System.Drawing.Size(64, 23);
            this.helpB.TabIndex = 3;
            this.helpB.Text = "YARDIM";
            this.helpB.UseVisualStyleBackColor = true;
            this.helpB.Click += new System.EventHandler(this.helpB_Click);
            // 
            // ISifDeB
            // 
            this.ISifDeB.BackColor = System.Drawing.Color.Transparent;
            this.ISifDeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ISifDeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ISifDeB.Location = new System.Drawing.Point(394, 4);
            this.ISifDeB.Name = "ISifDeB";
            this.ISifDeB.Size = new System.Drawing.Size(100, 36);
            this.ISifDeB.TabIndex = 2;
            this.ISifDeB.Text = "ŞİFRE DEĞİŞTİR";
            this.ISifDeB.UseVisualStyleBackColor = false;
            this.ISifDeB.Click += new System.EventHandler(this.ISifDeB_Click);
            // 
            // ISatisB
            // 
            this.ISatisB.BackColor = System.Drawing.Color.White;
            this.ISatisB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ISatisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ISatisB.Location = new System.Drawing.Point(207, 4);
            this.ISatisB.Name = "ISatisB";
            this.ISatisB.Size = new System.Drawing.Size(100, 36);
            this.ISatisB.TabIndex = 1;
            this.ISatisB.Text = "SATIŞ";
            this.ISatisB.UseVisualStyleBackColor = false;
            this.ISatisB.Click += new System.EventHandler(this.ISatisB_Click);
            // 
            // IStokB
            // 
            this.IStokB.BackColor = System.Drawing.Color.White;
            this.IStokB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IStokB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IStokB.Location = new System.Drawing.Point(28, 3);
            this.IStokB.Name = "IStokB";
            this.IStokB.Size = new System.Drawing.Size(100, 36);
            this.IStokB.TabIndex = 0;
            this.IStokB.Text = "STOK TAKİP";
            this.IStokB.UseVisualStyleBackColor = false;
            this.IStokB.Click += new System.EventHandler(this.IStokB_Click);
            // 
            // IsciStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 289);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IsciStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOK TAKİP VE ŞİRKET YÖNETİMİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IsciStok_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ISatisB;
        private System.Windows.Forms.Button IStokB;
        private System.Windows.Forms.Button ISifDeB;
        private System.Windows.Forms.Button helpB;
    }
}