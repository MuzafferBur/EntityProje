namespace EntityProje
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnIns = new System.Windows.Forms.Button();
            this.BtnUpd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(235, 71);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(178, 40);
            this.TxtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(235, 117);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(178, 40);
            this.TxtAd.TabIndex = 1;
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(94, 201);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(146, 35);
            this.BtnList.TabIndex = 2;
            this.BtnList.Text = "Listele";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(267, 200);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(146, 36);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "Sil";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnIns
            // 
            this.BtnIns.Location = new System.Drawing.Point(94, 251);
            this.BtnIns.Name = "BtnIns";
            this.BtnIns.Size = new System.Drawing.Size(146, 36);
            this.BtnIns.TabIndex = 4;
            this.BtnIns.Text = "Ekle";
            this.BtnIns.UseVisualStyleBackColor = true;
            this.BtnIns.Click += new System.EventHandler(this.BtnIns_Click);
            // 
            // BtnUpd
            // 
            this.BtnUpd.Location = new System.Drawing.Point(267, 250);
            this.BtnUpd.Name = "BtnUpd";
            this.BtnUpd.Size = new System.Drawing.Size(146, 36);
            this.BtnUpd.TabIndex = 5;
            this.BtnUpd.Text = "Guncelle";
            this.BtnUpd.UseVisualStyleBackColor = true;
            this.BtnUpd.Click += new System.EventHandler(this.BtnUpd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 215);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1166, 347);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnUpd);
            this.Controls.Add(this.BtnIns);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnIns;
        private System.Windows.Forms.Button BtnUpd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

