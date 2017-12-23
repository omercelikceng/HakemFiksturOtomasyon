using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HakemFiksturOtomasyon.Observer
{
    public interface IGozlemci
    {
        void guncelle(Object obje , string lig, string yapilacakİslem);
    }
}
