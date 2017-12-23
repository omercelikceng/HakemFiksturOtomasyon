using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HakemFiksturOtomasyon.View.StadFile;
using HakemFiksturOtomasyon.View.TakimFile;
using HakemFiksturOtomasyon.View.HakemFile;
using HakemFiksturOtomasyon.View.FiksturFile;

namespace HakemFiksturOtomasyon.Controller.AnaFormFile
{
    class AnaFormCon
    {
        public void takimAnaFormAc()
        {
            TakimAnaForm _tkimAnaForm = new TakimAnaForm();
            _tkimAnaForm.Show();
        }

        public void stadAnaFrmAc()
        {
            StadAnaForm _stadAnaForm = new StadAnaForm();
            _stadAnaForm.Show();
        }

        public void hakemAnaFormAc()
        {
            HakemAnaForm _hakemAnaForm = new HakemAnaForm();
            _hakemAnaForm.Show();
        }

        public void fiksturFormAc()
        {
            FiksturForm _fiksturForm = new FiksturForm();
            _fiksturForm.Show();
        }
    }
}
