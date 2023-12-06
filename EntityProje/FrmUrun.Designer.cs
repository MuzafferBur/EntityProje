namespace EntityProje
{
    partial class FrmUrun
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
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnIns = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnCln = new System.Windows.Forms.Button();
            this.BtnUpd = new System.Windows.Forms.Button();
            this.CmbKategori = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(148, 12);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(235, 40);
            this.Txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(148, 58);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(235, 40);
            this.TxtAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "URUN ADI:";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(148, 104);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(235, 40);
            this.TxtMarka.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "MARKA:";
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(148, 193);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(235, 40);
            this.TxtStok.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "STOK:";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(148, 239);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(235, 40);
            this.TxtDurum.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "DURUM:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "KATEGORI:";
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(494, 27);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(142, 40);
            this.BtnList.TabIndex = 22;
            this.BtnList.Text = "LISTELE";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnIns
            // 
            this.BtnIns.Location = new System.Drawing.Point(494, 81);
            this.BtnIns.Name = "BtnIns";
            this.BtnIns.Size = new System.Drawing.Size(142, 40);
            this.BtnIns.TabIndex = 22;
            this.BtnIns.Text = "EKLE";
            this.BtnIns.UseVisualStyleBackColor = true;
            this.BtnIns.Click += new System.EventHandler(this.BtnIns_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(494, 140);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(142, 40);
            this.BtnDel.TabIndex = 22;
            this.BtnDel.Text = "SIL";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnCln
            // 
            this.BtnCln.Location = new System.Drawing.Point(494, 257);
            this.BtnCln.Name = "BtnCln";
            this.BtnCln.Size = new System.Drawing.Size(142, 40);
            this.BtnCln.TabIndex = 22;
            this.BtnCln.Text = "TEMIZLE";
            this.BtnCln.UseVisualStyleBackColor = true;
            this.BtnCln.Click += new System.EventHandler(this.BtnCln_Click);
            // 
            // BtnUpd
            // 
            this.BtnUpd.Location = new System.Drawing.Point(494, 199);
            this.BtnUpd.Name = "BtnUpd";
            this.BtnUpd.Size = new System.Drawing.Size(142, 40);
            this.BtnUpd.TabIndex = 22;
            this.BtnUpd.Text = "GUNCELLE";
            this.BtnUpd.UseVisualStyleBackColor = true;
            this.BtnUpd.Click += new System.EventHandler(this.BtnUpd_Click);
            // 
            // CmbKategori
            // 
            this.CmbKategori.FormattingEnabled = true;
            this.CmbKategori.Location = new System.Drawing.Point(148, 282);
            this.CmbKategori.Name = "CmbKategori";
            this.CmbKategori.Size = new System.Drawing.Size(235, 41);
            this.CmbKategori.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 215);
            this.dataGridView1.TabIndex = 8;
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(148, 150);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(235, 40);
            this.TxtFiyat.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "FIYAT:";
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(647, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmbKategori);
            this.Controls.Add(this.BtnUpd);
            this.Controls.Add(this.BtnCln);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnIns);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDurum);
            this.Controls.Add(this.TxtStok);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.Txtid);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnIns;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnCln;
        private System.Windows.Forms.Button BtnUpd;
        private System.Windows.Forms.ComboBox CmbKategori;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label7;
    }
}