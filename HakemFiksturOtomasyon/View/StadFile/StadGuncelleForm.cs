using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Controller.StadFile;
using HakemFiksturOtomasyon.SingletonXml;

namespace HakemFiksturOtomasyon.View.StadFile
{
    public partial class StadGuncelleForm : Form
    {
        StadFormCon _stadFormCon;
        StadAnaForm stdAnaForm;
        String aramaMetni;
        int id;
        ComponentConfiguration compo;
        GörselOzellikleriAta _ozellikAta;

        public StadGuncelleForm(StadAnaForm _stadAnaForm)
        {
            InitializeComponent();
            stdAnaForm = _stadAnaForm;
            _stadFormCon = new StadFormCon();
            _ozellikAta = new GörselOzellikleriAta();
        }

        public void bilgileriDoldur(DataGridViewRow row, String _aramaMetni)
        {
            aramaMetni = _aramaMetni;
            txtAd.Text = row.Cells["StadAdi"].Value.ToString();
            txtDiger.Text = row.Cells["StadDiger"].Value.ToString();
            comboSehir.Text = row.Cells["StadSehri"].Value.ToString();
            id = (int)row.Cells[0].Value;
        }

        private void StadGuncelleForm_Load(object sender, EventArgs e)
        {
            comboSehir =_stadFormCon.comboSehirDoldur(comboSehir);
            compo = ComponentConfiguration.getInstance();
            _ozellikAta.bilesenlereOzellikAta(this, compo);
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            int stadId = id;
            _stadFormCon.guncelleStadDB(stadId, txtAd.Text, comboSehir.SelectedValue.ToString(), txtDiger.Text);
            MessageBox.Show("Kayıt düzenleme işlemi başarıyla tamamlandı..");
            this.Visible = false;
            stdAnaForm.dtGridYenile(aramaMetni); 
        }
    }
}
