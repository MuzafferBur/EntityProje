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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.UrunID,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Durum,
                                            x.Tbl_Kategori.Ad,
                                            x.Fiyat
                                        }).ToList();
        }

        private void BtnIns_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.UrunAd = TxtAd.Text;
            t.Marka = TxtMarka.Text;
            t.Stok = short.Parse(TxtStok.Text);
            t.Kategori = int.Parse(CmbKategori.SelectedValue.ToString());
            t.Fiyat = decimal.Parse(TxtFiyat.Text);
            t.Durum = true;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Successfully");
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Kayit Silindi");
        }

        private void BtnUpd_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.UrunAd = TxtAd.Text;
            urun.Stok = short.Parse(TxtStok.Text);
            urun.Marka = TxtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Kayit Guncellendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               {
                                   x.ID,
                                   x.Ad
                               }
                               ).ToList();
            CmbKategori.ValueMember = "ID";
            CmbKategori.DisplayMember = "AD";
            CmbKategori.DataSource = kategoriler;
        }

        private void BtnCln_Click(object sender, EventArgs e)
        {
            TxtAd.Text = CmbKategori.SelectedValue.ToString();
        }
    }
}
