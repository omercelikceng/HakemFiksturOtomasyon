using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Controller.FiksturFile;
using HakemFiksturOtomasyon.Observer;
using HakemFiksturOtomasyon.Log;

namespace HakemFiksturOtomasyon.View.FiksturFile
{
    public partial class FiksturForm : Form , IGozlemlenen
    {
        FiksturFormCon _fiksFormCon;
        private List<IGozlemci> gozlemciListesi = new List<IGozlemci>();
        public FiksturForm()
        {
            InitializeComponent();
            _fiksFormCon = new FiksturFormCon();
            gozlemciEkle(Logger.getInstance());
            gozlemciEkle(_fiksFormCon);
        }

        private void FiksturForm_Load(object sender, EventArgs e)
        {
            pickerTarih.Format = DateTimePickerFormat.Custom;
            pickerTarih.CustomFormat = "dd/MM/yy";
            pickerTarih.MinDate = DateTime.Today.AddDays(1);
            comboLig = _fiksFormCon.comboLigDoldur(comboLig);
        }

        private void btnFikstur_Click(object sender, EventArgs e)
        {
            if (_fiksFormCon.kosullariKontrolEt(comboLig.SelectedValue.ToString()))
            {
                _fiksFormCon.takimlariCek(comboLig.SelectedValue.ToString());
                gozlemcilereHaberVer(pickerTarih.Value, comboLig.SelectedValue.ToString(), "FiksturKaydet");//kayıt işlemini yaptırıyoruz
                dtGridFikstur.DataSource = null;
                while (dtGridFikstur.Rows.Count > 0)
                    dtGridFikstur.Rows.RemoveAt(0);
                dtGridFikstur.Refresh();
                _fiksFormCon.dtGridDoldur(dtGridFikstur);
            }
            else
                MessageBox.Show("Gerekli koşullar sağlanamıyor..");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_fiksFormCon.kayitKontrolEt(comboLig.SelectedValue.ToString()))
            {
                gozlemcilereHaberVer(comboLig.SelectedValue.ToString(), comboLig.SelectedValue.ToString(), "FiksturSil");
                dtGridFikstur.DataSource = null;
            }
            else
                MessageBox.Show("Silinemez..Zaten böyle bir fikstür bulunmamakta.");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            _fiksFormCon.ligeGoredtGriddeGoster(comboLig.SelectedValue.ToString(), dtGridFikstur);
        }


        public void gozlemcilereHaberVer(object obje ,string lig ,string yapilacakIslem)
        {
            foreach (IGozlemci gözlemci in gozlemciListesi)
                gözlemci.guncelle(obje,lig, yapilacakIslem);
        }

        public void gozlemciEkle(IGozlemci _gozlemci)
        {
            gozlemciListesi.Add(_gozlemci);
        }

        public void gozlemciSil(IGozlemci _gozlemci)
        {
            gozlemciListesi.Remove(_gozlemci);
        }
    }
}
