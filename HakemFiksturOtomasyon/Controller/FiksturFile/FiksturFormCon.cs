using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Observer;

namespace HakemFiksturOtomasyon.Controller.FiksturFile
{
    class FiksturFormCon : IGozlemci
    {
        ArrayList takimList;
        ArrayList hakemList;
        ArrayList stadList;
        ArrayList yarHakemList;
        ArrayList dorduncuHakemList;
        DataTable table;
        int takimSayisiTut;
        string[] macSaatleri = new string[] { "12.30", "16.30", "20.30" };
        String _ligAdi = "";

        public void takimlariCek(String ligAdi)
        {
            takimList = new ArrayList();
            using (var db = new HakemOtomasyonDataContext())
            {
                Lig ligs = db.Ligs.SingleOrDefault(l => l.id == Convert.ToInt32(ligAdi));
                _ligAdi = ligs.adi;
                var sorgu = (from t in db.Takims where t.ligId == Convert.ToInt32(ligAdi) select t);
                foreach (var i in sorgu)
                    takimList.Add(i.adi);
            }

        }

        public void ligeGoredtGriddeGoster(String ligAdi, DataGridView dt)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Lig ligs = db.Ligs.SingleOrDefault(l => l.id == Convert.ToInt32(ligAdi));
                var sorgu = from fiks in db.Fiksturs where fiks.lig == ligs.adi select fiks;
                dt.DataSource = sorgu;
            }
        }


        public void ligeGoreFiksturSil(String lig)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Lig ligs = db.Ligs.SingleOrDefault(l => l.id == Convert.ToInt32(lig));
                var sorgu = from fiks in db.Fiksturs where fiks.lig == ligs.adi select fiks;
                db.Fiksturs.DeleteAllOnSubmit(sorgu);
                db.SubmitChanges();
                MessageBox.Show("Fikstür silme işlemi başarıyla tamamlanmıştır.");
            }
        }


        public void stadAtamaIslemi()
        {
            stadList = new ArrayList();
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorgu = (from s in db.Stadyums select s);
                foreach (var i in sorgu)
                    stadList.Add(i.adi);
            }
        }


        public void hakemAtamaIslemi()
        {
            hakemList = new ArrayList();
            yarHakemList = new ArrayList();
            dorduncuHakemList = new ArrayList();
            using (var db = new HakemOtomasyonDataContext())
            {
                var sorgu = (from h in db.Hakems where h.turu == "Orta Hakem" select h);
                foreach (var i in sorgu)
                {
                    hakemList.Add(i.adi);
                    Hakem yarHakem = db.Hakems.SingleOrDefault(h => h.referansHakem == i.id && h.turu == "Yardımcı Hakem");
                    yarHakemList.Add(yarHakem.adi);
                    Hakem dorduncuHakem = db.Hakems.SingleOrDefault(h => h.referansHakem == i.id && h.turu == "4. Hakem");
                    dorduncuHakemList.Add(dorduncuHakem.adi);
                }
            }
        }



        public void dtGridSablonOlustur(DateTime dt)
        {
            table = new DataTable();
            table.Columns.Add("İlk Takım", typeof(string));
            table.Columns.Add("İkinci Takım", typeof(string));
            table.Columns.Add("Tarih", typeof(string));
            table.Columns.Add("Saat", typeof(string));
            table.Columns.Add("Hafta", typeof(string));
            table.Columns.Add("Lig", typeof(string));
            table.Columns.Add("Orta Hakem", typeof(string));
            table.Columns.Add("Yardımcı Hakem", typeof(string));
            table.Columns.Add("4. Hakem", typeof(string));
            table.Columns.Add("Stadyum", typeof(string));
            hakemAtamaIslemi();
            stadAtamaIslemi();
            takimlariEslestir(takimSayisiTut, dt);
        }

        public void dtGridDoldur(DataGridView dt)
        {
            dt.DataSource = table;
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

        public Boolean kosullariKontrolEt(String ligAdi)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                int takimSayisi = (from t in db.Takims where t.ligId == Convert.ToInt32(ligAdi) select t).Count();
                takimSayisiTut = takimSayisi;
                int ortaHakemSayisi = (from h in db.Hakems where h.turu == "Orta Hakem" select h).Count();
                int yarHakemSayisi = (from h in db.Hakems where h.turu == "Yardımcı Hakem" select h).Count();
                int dorduncuHakemSayisi = (from h in db.Hakems where h.turu == "4. Hakem" select h).Count();
                int stadSayisi = (from s in db.Stadyums select s).Count();
                if ((takimSayisi >= 10 && takimSayisi % 2 == 0) && (stadSayisi >= 5) && (ortaHakemSayisi >= 5 &&
                    yarHakemSayisi >= 5 && dorduncuHakemSayisi >= 5))
                    return true;
                else
                    return false;
            }
        }

        public void takimlariEslestir(int takimSayisi, DateTime date)
        {
            int karsilasmaSayisi = takimSayisi - 1;
            int macSayisi = takimSayisi / 2;
            int sayi = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < takimSayisi; i++)
                list.Add(i);
            for (int i = 0; i < karsilasmaSayisi; i++)
            {
                for (int j = 0; j < macSayisi; j++)
                {
                    int firstIndex = j;
                    int secondIndex = (takimSayisi - 1) - j;
                    if (sayi == 3)
                        sayi = 0;
                    table.Rows.Add(takimList[list.ElementAt(firstIndex)],
                        takimList[list.ElementAt(secondIndex)], date.ToShortDateString(), macSaatleri[sayi], (i + 1 + ".Hafta"),
                        _ligAdi, hakemList[j], yarHakemList[j], dorduncuHakemList[j], stadList[j]);
                    fiksturKaydetDB((takimList[list.ElementAt(firstIndex)].ToString()),
                        takimList[list.ElementAt(secondIndex)].ToString(), date.ToShortDateString(), macSaatleri[sayi], (i + 1 + ".Hafta"),
                        _ligAdi, hakemList[j].ToString(), yarHakemList[j].ToString(), dorduncuHakemList[j].ToString(), stadList[j].ToString());
                    sayi += 1;
                    date = date.AddDays(7);

                }
                List<int> newList = new List<int>();
                newList.Add(list.ElementAt(0));
                newList.Add(list.ElementAt(list.Count - 1));
                for (int k = 1; k < list.Count - 1; k++)
                    newList.Add(list.ElementAt(k));
                list = newList;
            }
            MessageBox.Show("Fikstür kayıt işlemi başarıyla tamamlanmıştır.");
        }


        public void fiksturKaydetDB(String ilkTakim, String ikinciTakim, String tarih, String saat,
            String hafta, String lig, String ortaHakem, String yardimciHakem, String dorduncuHakem, String stad)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Fikstur fiks = new Fikstur();
                fiks.ilkTakim = ilkTakim;
                fiks.ikinciTakim = ikinciTakim;
                fiks.tarih = tarih;
                fiks.saat = saat;
                fiks.hafta = hafta;
                fiks.lig = lig;
                fiks.ortaHakem = ortaHakem;
                fiks.yardimciHakem = yardimciHakem;
                fiks.dorduncuHakem = dorduncuHakem;
                fiks.stadyum = stad;
                db.Fiksturs.InsertOnSubmit(fiks);
                db.SubmitChanges();
            }
        }

        public void guncelle(object obje, string islemYapilanLig, string yapilacakIslem)
        {
            if (yapilacakIslem.Equals("FiksturKaydet"))
                dtGridSablonOlustur((DateTime)obje);
            else if (yapilacakIslem.Equals("FiksturSil"))
                ligeGoreFiksturSil((string)obje);
        }

        public bool kayitKontrolEt(String lig)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Lig ligs = db.Ligs.SingleOrDefault(l => l.id == Convert.ToInt32(lig));
                int sayi = (from fiks in db.Fiksturs where fiks.lig == ligs.adi select fiks).Count();
                if (sayi > 0)
                    return true;
            }
            return false;
        }
    }
}
