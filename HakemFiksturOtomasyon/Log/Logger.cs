using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HakemFiksturOtomasyon.Observer;

namespace HakemFiksturOtomasyon.Log
{
    class Logger :IGozlemci
    {
        private static Logger _instance;
        private static object kilitObjesi = new object();

        private Logger() { }

        public static Logger getInstance()
        {
            if(_instance == null)
            {
                lock(kilitObjesi)
                {
                    if (_instance == null)
                        _instance = new Logger();
                }
            }
            return _instance;
        }

        public void Logla(String dbMesaji)
        {
            var tarihCek = DateTime.Now;
            using (StreamWriter writer = new StreamWriter("..\\..\\Log\\sistem.log",true))
                writer.WriteLine(tarihCek + " "+dbMesaji);
        }

        public String ligAdi(String ligId)
        {
            using (var db = new HakemOtomasyonDataContext())
            {
                Lig ligs = db.Ligs.SingleOrDefault(l => l.id == Convert.ToInt32(ligId));
                return ligs.adi;
            }
        }

        public void guncelle(object obje, string lig , string yapilacakIslem)
        {
            if (yapilacakIslem.Equals("FiksturKaydet"))
                Logla(ligAdi(lig) + " fikstürü oluşturuldu.");
            else if (yapilacakIslem.Equals("FiksturSil"))
                Logla(ligAdi(lig) + " fikstürü silindi.");
        }
    }
}
