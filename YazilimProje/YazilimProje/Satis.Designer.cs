namespace YazilimProje
{
    partial class Satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaSatisB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaAdetTb = new System.Windows.Forms.TextBox();
            this.SaFiyatTb = new System.Windows.Forms.TextBox();
            this.SaParcaCb = new System.Windows.Forms.ComboBox();
            this.SaModelCb = new System.Windows.Forms.ComboBox();
            this.SaMarkaCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = global::YazilimProje.Properties.Resources.logoSatis;
            this.panel1.Controls.Add(this.SaSatisB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SaAdetTb);
            this.panel1.Controls.Add(this.SaFiyatTb);
            this.panel1.Controls.Add(this.SaParcaCb);
            this.panel1.Controls.Add(this.SaModelCb);
            this.panel1.Controls.Add(this.SaMarkaCb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 347);
            this.panel1.TabIndex = 0;
            // 
            // SaSatisB
            // 
            this.SaSatisB.BackColor = System.Drawing.Color.White;
            this.SaSatisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaSatisB.Location = new System.Drawing.Point(558, 178);
            this.SaSatisB.Name = "SaSatisB";
            this.SaSatisB.Size = new System.Drawing.Size(107, 43);
            this.SaSatisB.TabIndex = 10;
            this.SaSatisB.Text = "SATIŞ";
            this.SaSatisB.UseVisualStyleBackColor = false;
            this.SaSatisB.Click += new System.EventHandler(this.SaSatisB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(229, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SATIŞ ADEDİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(248, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FİYAT";
            // 
            // SaAdetTb
            // 
            this.SaAdetTb.Location = new System.Drawing.Point(345, 179);
            this.SaAdetTb.Name = "SaAdetTb";
            this.SaAdetTb.Size = new System.Drawing.Size(122, 20);
            this.SaAdetTb.TabIndex = 1;
            // 
            // SaFiyatTb
            // 
            this.SaFiyatTb.Enabled = false;
            this.SaFiyatTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaFiyatTb.Location = new System.Drawing.Point(345, 140);
            this.SaFiyatTb.Name = "SaFiyatTb";
            this.SaFiyatTb.Size = new System.Drawing.Size(122, 20);
            this.SaFiyatTb.TabIndex = 6;
            // 
            // SaParcaCb
            // 
            this.SaParcaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaParcaCb.FormattingEnabled = true;
            this.SaParcaCb.Location = new System.Drawing.Point(459, 71);
            this.SaParcaCb.Name = "SaParcaCb";
            this.SaParcaCb.Size = new System.Drawing.Size(150, 21);
            this.SaParcaCb.TabIndex = 5;
            this.SaParcaCb.SelectedIndexChanged += new System.EventHandler(this.SaParcaCb_SelectedIndexChanged);
            // 
            // SaModelCb
            // 
            this.SaModelCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaModelCb.FormattingEnabled = true;
            this.SaModelCb.Location = new System.Drawing.Point(256, 71);
            this.SaModelCb.Name = "SaModelCb";
            this.SaModelCb.Size = new System.Drawing.Size(150, 21);
            this.SaModelCb.TabIndex = 4;
            this.SaModelCb.SelectedIndexChanged += new System.EventHandler(this.SaModelCb_SelectedIndexChanged);
            // 
            // SaMarkaCb
            // 
            this.SaMarkaCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaMarkaCb.FormattingEnabled = true;
            this.SaMarkaCb.Location = new System.Drawing.Point(51, 71);
            this.SaMarkaCb.Name = "SaMarkaCb";
            this.SaMarkaCb.Size = new System.Drawing.Size(150, 21);
            this.SaMarkaCb.TabIndex = 3;
            this.SaMarkaCb.SelectedIndexChanged += new System.EventHandler(this.SaMarkaCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(513, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PARÇA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(309, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MODEL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MARKA";
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(721, 347);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ";
            this.Load += new System.EventHandler(this.Satis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SaFiyatTb;
        private System.Windows.Forms.ComboBox SaParcaCb;
        private System.Windows.Forms.ComboBox SaModelCb;
        private System.Windows.Forms.ComboBox SaMarkaCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaSatisB;
        private System.Windows.Forms.TextBox SaAdetTb;
    }
}