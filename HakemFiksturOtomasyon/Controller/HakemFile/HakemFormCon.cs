using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Log;
using System.Data;

namespace HakemFiksturOtomasyon.Controller.HakemFile
{
    class HakemFormCon
    {
        String degisenDegerler = "";
        String hakemAdiTut = "";
        Nullable<int> nullableIntDeger;
        Logger log;
        DataTable dtTypes;

        public HakemFormCon()
        {
            log = Logger.getInstance();
            nullableIntDeger = null;
        }

        public void kaydetHakemDB(Hakem h)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                db.Hakems.InsertOnSubmit(h);
                db.SubmitChanges();
            }
            log.Logla("  Ekleme :  Hakem " + h.adi + " " +h.soyadi+ " Sisteme Başarıyla Eklenmiştir.");
        }


        public void silHakemDB(int idAta)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorgu = from h in db.Hakems 
                            where h.referansHakem == idAta
                            select h;
                foreach (var e in sorgu)                //SingleOrDefault değilde Foreach kullanma
                {                                       //sebebim tek bir tane kayıt gelmeyeceği için
                    e.referansHakem = nullableIntDeger; // tek bir kayıt gelmezse SingleOrDefault'ta hata yeriz.
                }
                Hakem _hkem = db.Hakems.SingleOrDefault(h => h.id == idAta);
                db.Hakems.DeleteOnSubmit(_hkem);
                db.SubmitChanges();
                log.Logla("  Silme :  Hakem " + _hkem.adi + " "+ _hkem.soyadi+ " Sistemden Başarıyla Silinmiştir.");
            }

        }

        public void guncelleHakemDB(int idAta, String ad, String soyad, String tur, String klasman,
            String bolge, Nullable<int> ustHakem)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Hakem hkem = db.Hakems.SingleOrDefault(t => t.id == idAta);
                hakemAdiTut = hkem.adi;
                degisenleriKontrolEt(hkem, ad, soyad, tur, klasman, bolge, ustHakem);
                hkem.adi = ad;
                hkem.soyadi = soyad;
                hkem.turu = tur;
                hkem.klasmani = klasman;
                hkem.bolgesi = bolge;
                hkem.referansHakem = ustHakem;
                db.SubmitChanges();
                log.Logla("  Güncelleme : " + hakemAdiTut + " Hakemindeki Detay Değişiklikler : " 
                    + degisenDegerler + " Olarak Güncellenmiştir.");
            }
        }

        public DataGridView dtGridDoldur(DataGridView dt, String aramaMetni)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorgu = from h in db.Hakems
                            join hk in db.Hakems on h.referansHakem equals hk.id into qt
                            from x in qt.DefaultIfEmpty()
                            where h.adi.StartsWith(aramaMetni) || h.soyadi.StartsWith(aramaMetni)
                            || h.turu.StartsWith(aramaMetni) || h.klasmani.StartsWith(aramaMetni)
                            || h.bolgesi.StartsWith(aramaMetni) || x.adi.StartsWith(aramaMetni)
                            select new
                            {
                                id = h.id,
                                Adi = h.adi,
                                Soyadi = h.soyadi,
                                Türü = h.turu,
                                Klasmanı = h.klasmani,
                                Bölge = h.bolgesi,
                                ÜstHakemi = x.adi ?? "--"
                            };
                dt.DataSource = sorgu;
            }
            return dt;
        }

        public void bosHakemAta()
        {
            dtTypes = new DataTable();
            dtTypes.Columns.Add("id", typeof(int));
            dtTypes.Columns.Add("adi", typeof(string));
            DataRow dtrow = dtTypes.NewRow();
            dtrow[0] = DBNull.Value;
            dtrow[1] = "--";
            dtTypes.Rows.InsertAt(dtrow, 0);
        }

        public ComboBox comboHakemDoldur(ComboBox combo, int id)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorgu = from h in db.Hakems
                            where h.turu == "Orta Hakem" && h.id != id
                            select h;
                bosHakemAta();
                foreach (var s in sorgu)
                    dtTypes.Rows.Add(s.id, s.adi);

                if (dtTypes.Rows.Count > 0)
                {
                    combo.DataSource = dtTypes;
                    combo.DisplayMember = "adi";
                    combo.ValueMember = "id";
                }
            }
            return combo;
        }

        public void degisenleriYazdir(String dbDeger,String yeniDeger)
        {
            if(dbDeger!=yeniDeger)
                degisenDegerler += dbDeger + " = " + yeniDeger +" ,";
        }


        public void degisenleriKontrolEt(Hakem hkem, String ad, String soyad, String tur, String klasman,
                 String bolge, Nullable<int> ustHakem)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                degisenleriYazdir(hkem.adi, ad);
                degisenleriYazdir(hkem.soyadi, soyad);
                degisenleriYazdir(hkem.turu, tur);
                degisenleriYazdir(hkem.klasmani, klasman);
                degisenleriYazdir(hkem.bolgesi, bolge);
                if (hkem.referansHakem != ustHakem && hkem.referansHakem == null)
                {
                    Hakem degisenDeger = db.Hakems.SingleOrDefault(h => h.id == Convert.ToInt32(ustHakem));
                    degisenDegerler += "Üst Hakem Yok İken Yeni Atanan " + degisenDeger.adi + " ";
                }
                if (hkem.referansHakem != ustHakem && ustHakem == null)
                {
                    Hakem ilkDeger = db.Hakems.SingleOrDefault(h => h.id == hkem.referansHakem);
                    degisenDegerler += "Üst Hakem " + ilkDeger.adi + " Yerine Boş Bir Değer Atandı ";
                }
            }

        }

    }
}
