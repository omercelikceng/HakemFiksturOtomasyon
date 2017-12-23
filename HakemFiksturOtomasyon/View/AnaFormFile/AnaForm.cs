using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Controller.AnaFormFile;
using HakemFiksturOtomasyon.SingletonXml;
namespace HakemFiksturOtomasyon.View.AnaFormFile
{
    public partial class AnaForm : Form
    {
        AnaFormCon _anaFormCon;
        GörselOzellikleriAta _ozellikAta;
        ComponentConfiguration compo;

        public AnaForm()
        {
            InitializeComponent();
            _anaFormCon = new AnaFormCon();
            _ozellikAta = new GörselOzellikleriAta();
            compo = ComponentConfiguration.getInstance();
        }

        private void btnTakim_Click(object sender, EventArgs e)
        {
            _anaFormCon.takimAnaFormAc();
            this.Hide();
        }

        private void btnStad_Click(object sender, EventArgs e)
        {
            _anaFormCon.stadAnaFrmAc();
            this.Hide();
        }

        private void btnHakem_Click(object sender, EventArgs e)
        {
            _anaFormCon.hakemAnaFormAc();
            this.Hide();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            compo.xmlOku("birinci");
            _ozellikAta.bilesenlereOzellikAta(this, compo);
        }

        private void btnFikstur_Click(object sender, EventArgs e)
        {
            _anaFormCon.fiksturFormAc();
            this.Hide();
        }
    }
}
