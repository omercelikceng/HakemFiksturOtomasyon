using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HakemFiksturOtomasyon.Observer;

namespace HakemFiksturOtomasyon.Observer
{
    public interface IGozlemlenen
    {
        void gozlemcilereHaberVer(Object obje, string lig , string yapilacakİslem);
        void gozlemciEkle(IGozlemci gozlemci);
        void gozlemciSil(IGozlemci gozlemci);
    }
}
