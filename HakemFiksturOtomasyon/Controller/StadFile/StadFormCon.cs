using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.View.TakimFile;
using HakemFiksturOtomasyon.View.StadFile;
using HakemFiksturOtomasyon.View.HakemFile;
using HakemFiksturOtomasyon.Log;

namespace HakemFiksturOtomasyon.Controller.StadFile
{
    class StadFormCon
    {
        String degisenDegerler = "";
        Logger log;
        String stadAdiTut="";
        public StadFormCon()
        {
            log = Logger.getInstance();
        }
        public void kaydetStadDB(Stadyum s)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                db.Stadyums.InsertOnSubmit(s);
                db.SubmitChanges();
            }
            log.Logla("  Ekleme : " + s.adi + " Stadı Sisteme Başarıyla Eklenmiştir.");
        }

        public void silStadDB(int idAta)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Stadyum _stad = db.Stadyums.SingleOrDefault(s => s.id == idAta);
                db.Stadyums.DeleteOnSubmit(_stad);
                db.SubmitChanges();
                log.Logla("  Silme : " + _stad.adi + " Stadı Sistemden Başarıyla Silinmiştir.");
            }
        }

        public void guncelleStadDB(int idAta, String ad, String sehir, String diger)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Stadyum stad = db.Stadyums.SingleOrDefault(s => s.id == idAta);
                degisenleriKontrolEt(stad, ad, sehir, diger);
                stadAdiTut = stad.adi;
                stad.adi = ad;
                stad.sehirId = Convert.ToInt32(sehir);
                stad.diger = diger;
                db.SubmitChanges();
                log.Logla("  Güncelleme : " + stadAdiTut + " Stadındaki Detay Değişiklikler : " + degisenDegerler + " Olarak Güncellenmiştir.");
            }
        }

        public Object dtGridDoldur(String aramaMetni)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorguAta = (from _stad in db.Stadyums
                                join shir in db.Sehirs
                                   on _stad.sehirId equals shir.id
                                where _stad.adi.StartsWith(aramaMetni)
                                || _stad.diger.StartsWith(aramaMetni)
                                || shir.adi.StartsWith(aramaMetni)
                                select new
                                {
                                    _stad.id,
                                    StadAdi = _stad.adi,
                                    StadSehri =shir.adi,
                                    StadDiger = _stad.diger
                                }).ToList();
                return sorguAta;
            }
        }


        public ComboBox comboSehirDoldur(ComboBox combo)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                combo.DataSource = db.Sehirs;
                combo.DisplayMember = "adi";
                combo.ValueMember = "id";
            }
            return combo;
        }

        public void degisenleriYazdir(String dbDeger, String yeniDeger)
        {
            if (dbDeger != yeniDeger)
                degisenDegerler += dbDeger + " = " + yeniDeger + " , ";
        }

        public void degisenleriKontrolEt(Stadyum std, String _ad, String _sehir, String _diger)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                degisenleriYazdir(std.adi, _ad);
                degisenleriYazdir(std.diger, _diger);
                if (std.sehirId != Convert.ToInt32(_sehir))
                {
                    Sehir ilkDeger = db.Sehirs.SingleOrDefault(s => s.id == std.sehirId);
                    Sehir degisenDeger = db.Sehirs.SingleOrDefault(s => s.id == Convert.ToInt32(_sehir));
                    degisenDegerler += ilkDeger.adi + " = " + degisenDeger.adi + " ";
                }
            }

        }
    }
}
