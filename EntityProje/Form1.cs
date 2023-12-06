using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db =new DbEntityUrunEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            var categories =db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = categories;
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var ctgr = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(ctgr);
            db.SaveChanges();
            MessageBox.Show("Kayit Silindi!");
        }

        private void BtnIns_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.Ad = TxtAd.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kayit Eklendi!");
        }

        private void BtnUpd_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var ctgr = db.Tbl_Kategori.Find(x);
            ctgr.Ad = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Update Was Successfully!");
        }
    }
}
