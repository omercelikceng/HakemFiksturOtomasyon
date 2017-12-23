using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Controller.TakimFile;
using HakemFiksturOtomasyon.SingletonXml;

namespace HakemFiksturOtomasyon.View.TakimFile
{
    public partial class TakimGuncelleForm : Form
    {
        TakimAnaForm tkimAnaForm;
        TakimFormCon tkimFormCon;
        String aramaMetni;
        GörselOzellikleriAta _ozellikAta;
        ComponentConfiguration compo;
        int id;

        public TakimGuncelleForm(TakimAnaForm _tkimAnaForm)
        {
            InitializeComponent();
            tkimAnaForm = _tkimAnaForm;
            tkimFormCon = new TakimFormCon();
            _ozellikAta = new GörselOzellikleriAta();
        }

        public void bilgileriDoldur(DataGridViewRow row , String _aramaMetni)
        {
            aramaMetni = _aramaMetni;
            txtAd.Text = row.Cells["TakimAdi"].Value.ToString();
            txtDiger.Text = row.Cells["TakimDiger"].Value.ToString();
            comboLig.Text = row.Cells["TakimLigi"].Value.ToString();
            id = (int)row.Cells[0].Value;
        }

        private void TakimGuncelleForm_Load(object sender, EventArgs e)
        {
            comboLig = tkimFormCon.comboLigDoldur(comboLig);
            compo = ComponentConfiguration.getInstance();
            _ozellikAta.bilesenlereOzellikAta(this, compo);
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            int takimId = id;
            tkimFormCon.guncelleTakimDB(takimId, txtAd.Text, comboLig.SelectedValue.ToString(), txtDiger.Text);
            MessageBox.Show("Kayıt düzenleme işlemi başarıyla tamamlandı..");
            this.Visible = false;
            tkimAnaForm.dtGridYenile(aramaMetni); 
        }
    }
}
