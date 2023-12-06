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
    public partial class Frm_Istatistik : Form
    {
        public Frm_Istatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frm_Istatistik_Load(object sender, EventArgs e)
        {
            LblKategori.Text = db.Tbl_Kategori.Count().ToString();
            LblToplam.Text = db.Tbl_Urun.Count().ToString();
            LblAktfM.Text = db.Tbl_Musteri.Count(x => x.Durum == true).ToString();
            LblPsfM.Text = db.Tbl_Musteri.Count(x => x.Durum == false).ToString();
            LblToplamS.Text = db.Tbl_Urun.Sum(x => x.Stok).ToString();
            LblKasa.Text = db.Tbl_Satis.Sum(x=>x.Tbl_Urun.Fiyat).ToString() + "₺";
            LblEnYukF.Text = (from x in db.Tbl_Urun orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            LblEnDusF.Text = (from x in db.Tbl_Urun orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            LblBeyazE.Text = db.Tbl_Urun.Count(x => x.Kategori == 2).ToString();
            LblEnAzStkU.Text = (from x in db.Tbl_Urun orderby x.Stok ascending select x.UrunAd).FirstOrDefault();
            LblSehir.Text = (from x in db.Tbl_Musteri select x.Sehir).Distinct().Count().ToString();
            LblEnFzlaUr.Text = db.markagetir().FirstOrDefault();
        }
    }
}
