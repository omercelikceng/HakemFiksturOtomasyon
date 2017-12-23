using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.View.HakemFile;
using HakemFiksturOtomasyon.Controller.HakemFile;
using HakemFiksturOtomasyon.SingletonXml;

namespace HakemFiksturOtomasyon.View.HakemFile
{
    public partial class HakemGuncelleForm : Form
    {
        Nullable<int> i = null;
        HakemAnaForm _hakemAnaForm;
        HakemFormCon _hakemFormCon;
        String aramaMetni;
        int id;
        GörselOzellikleriAta _ozellikAta;
        ComponentConfiguration compo;

        public HakemGuncelleForm(HakemAnaForm hkemAnaForm)
        {
            InitializeComponent();
            _hakemAnaForm = hkemAnaForm;
            _hakemFormCon = new HakemFormCon();
            _ozellikAta = new GörselOzellikleriAta();
        }

        public void bilgileriDoldur(DataGridViewRow row, String metin, ComboBox combo)
        {
            id = (int)row.Cells["id"].Value;
            aramaMetni = metin;
            txtAd.Text = row.Cells["Adi"].Value.ToString();
            txtSoyad.Text = row.Cells["Soyadi"].Value.ToString();
            comboTuru.Text = row.Cells["Türü"].Value.ToString();
            comboKlasman.Text = row.Cells["Klasmanı"].Value.ToString();
            comboBolge.Text = row.Cells["Bölge"].Value.ToString();
            if (!row.Cells["Türü"].Value.Equals("Orta Hakem"))
            {
                panel2.Enabled = true;
                comboOrtaHakem.Text = row.Cells["ÜstHakemi"].Value.ToString();
            }
        }


        private void comboTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            _hakemFormCon.comboHakemDoldur(comboOrtaHakem, id);
            if (!comboTuru.SelectedItem.Equals("Orta Hakem"))
                panel2.Enabled = true;
            else
                panel2.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int hakemId = id;
            _hakemFormCon.guncelleHakemDB(hakemId, txtAd.Text, txtSoyad.Text, comboTuru.SelectedItem.ToString(),
                comboKlasman.SelectedItem.ToString(), comboBolge.SelectedItem.ToString(),
                string.IsNullOrEmpty(comboOrtaHakem.SelectedValue.ToString()) ? i : (int)(comboOrtaHakem.SelectedValue));
            MessageBox.Show("Kayıt düzenleme işlemi başarıyla tamamlandı..");
            this.Visible = false;
            _hakemAnaForm.dtGridYenile(aramaMetni);
            _hakemAnaForm.comboOrtaHakemYenile();
        }

        private void HakemGuncelleForm_Load(object sender, EventArgs e)
        {
            _hakemFormCon.comboHakemDoldur(comboOrtaHakem, id);
            compo = ComponentConfiguration.getInstance();
            _ozellikAta.bilesenlereOzellikAta(this, compo);
        }
    }
}
