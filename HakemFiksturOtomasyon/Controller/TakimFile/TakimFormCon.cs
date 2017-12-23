using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon;
using HakemFiksturOtomasyon.View.StadFile;
using HakemFiksturOtomasyon.View.TakimFile;
using HakemFiksturOtomasyon.View.HakemFile;
using HakemFiksturOtomasyon.Log;
namespace HakemFiksturOtomasyon.Controller.TakimFile
{
    class TakimFormCon
    {
        StadAnaForm _stadAnaForm;
        HakemAnaForm _hakemAnaForm;
        Logger log;
        String degisenDegerler = "";
        String takimAdiAta="";

        public TakimFormCon()
        {
            log = Logger.getInstance();
        }

        public void kaydetTakimDB(Takim t)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                db.Takims.InsertOnSubmit(t);
                db.SubmitChanges();
            }
            log.Logla("  Ekleme : "+t.adi+" Takımı Sisteme Başarıyla Eklenmiştir.");
        }

        public void silTakimDB(int idAta)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Takim tkim = db.Takims.SingleOrDefault(t => t.id == idAta);
                db.Takims.DeleteOnSubmit(tkim);
                db.SubmitChanges();
                log.Logla("  Silme : " + tkim.adi + " Takımı Sistemden Başarıyla Silinmiştir.");
            }
            
        }

        public void guncelleTakimDB(int idAta, String ad, String lig, String diger)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Takim tkim = db.Takims.SingleOrDefault(t => t.id == idAta);
                degisenleriKontrolEt(tkim, ad, lig, diger);
                takimAdiAta = tkim.adi;
                tkim.adi = ad;
                tkim.ligId = Convert.ToInt32(lig);
                tkim.diger = diger;
                db.SubmitChanges();
                log.Logla("  Güncelleme : " + takimAdiAta + "  Takımındaki Detay Değişiklikler : "+ degisenDegerler+" Olarak Güncellenmiştir.");
            }
        }

        public ComboBox comboLigDoldur(ComboBox combo)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                combo.DataSource = db.Ligs;
                combo.DisplayMember = "adi";
                combo.ValueMember = "id";
            }
            return combo;
        }

        public Object dtGridDoldur(String aramaMetni)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorguAta = (from tkim in db.Takims
                                join lg in db.Ligs
                                    on tkim.ligId equals lg.id
                                where tkim.adi.StartsWith(aramaMetni)
                                || tkim.diger.StartsWith(aramaMetni)
                                || lg.adi.StartsWith(aramaMetni)
                                select new
                                {
                                    tkim.id,
                                    TakimAdi = tkim.adi,
                                    TakimLigi = lg.adi,
                                    TakimDiger = tkim.diger
                                }).ToList();
                return sorguAta;
            }
        }

        public void stadFormunaGec()
        {
            _stadAnaForm = new StadAnaForm();
            _stadAnaForm.Show();
        }

        public void hakemFormunaGec()
        {
            _hakemAnaForm = new HakemAnaForm();
            _hakemAnaForm.Show();
        }

        public void degisenleriKontrolEt(Takim tkim, String ad, String _lig, String diger)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                if (tkim.adi != ad)
                    degisenDegerler += tkim.adi + " = " + ad + ", ";
                if (tkim.diger != diger)
                    degisenDegerler += tkim.diger + " = " + diger + ", ";
                if (tkim.ligId != Convert.ToInt32(_lig))
                {
                    Lig ilkDeger = db.Ligs.SingleOrDefault(l => l.id == tkim.ligId);
                    Lig degisenDeger = db.Ligs.SingleOrDefault(l => l.id == Convert.ToInt32(_lig));
                    degisenDegerler += ilkDeger.adi + " = " + degisenDeger.adi + " ";
                }
            }

        }
    }
}
