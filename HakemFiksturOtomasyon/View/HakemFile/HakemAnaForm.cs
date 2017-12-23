using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.Controller.HakemFile;
using HakemFiksturOtomasyon.Controller.AnaFormFile;
using HakemFiksturOtomasyon.SingletonXml;

namespace HakemFiksturOtomasyon.View.HakemFile
{
    public partial class HakemAnaForm : Form
    {
        HakemFormCon _hakemFormCon;
        HakemGuncelleForm _hakemGuncelleForm;
        AnaFormCon _anaFormCon;
        GörselOzellikleriAta _ozellikAta;
        ComponentConfiguration compo;
        Nullable<int> i = null;

        public HakemAnaForm()
        {
            InitializeComponent();
            _hakemFormCon = new HakemFormCon();
            _anaFormCon = new AnaFormCon();
            _ozellikAta = new GörselOzellikleriAta();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hakem hkem = new Hakem();
            hkem.adi = txtAd.Text;
            hkem.soyadi = txtSoyad.Text;
            hkem.turu = comboTuru.SelectedItem.ToString();
            hkem.klasmani = comboKlasman.SelectedItem.ToString();
            hkem.bolgesi = comboBolge.SelectedItem.ToString();
            if (hkem.turu != "Orta Hakem")
                hkem.referansHakem =  string.IsNullOrEmpty(comboOrtaHakem.SelectedValue.ToString()) ?
                    i : (int)(comboOrtaHakem.SelectedValue);
            _hakemFormCon.kaydetHakemDB(hkem);
            comboOrtaHakemYenile();
            comboTxtTemizle();
            dtGridYenile("");
            MessageBox.Show("Ekleme işlemi başarıyla tamamlandı..");
        }

        private void HakemAnaForm_Load(object sender, EventArgs e)
        {
            compo = ComponentConfiguration.getInstance();
            _ozellikAta.bilesenlereOzellikAta(this, compo);
            defaultDegerleriAta();
            comboOrtaHakemYenile();
            dtGridYenile(txtArama.Text);
            dtGridHakem.Columns[0].Visible = false;
        }

        private void comboTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboTuru.SelectedItem.Equals("Orta Hakem"))
                panel2.Enabled = true;
            else
                panel2.Enabled = false;
        }

        public void dtGridYenile(String metin)
        {
            dtGridHakem = _hakemFormCon.dtGridDoldur(dtGridHakem, metin);
        }

        public void comboOrtaHakemYenile()
        {
            comboOrtaHakem = _hakemFormCon.comboHakemDoldur(comboOrtaHakem, 0);
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dtGridYenile(txtArama.Text);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dtGridHakem.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                _hakemGuncelleForm = new HakemGuncelleForm(this);
                _hakemGuncelleForm.Show();
                _hakemGuncelleForm.bilgileriDoldur(dtGridHakem.CurrentRow, txtArama.Text, comboOrtaHakem);
            }
            else
                MessageBox.Show("Lütfen DataGridview'den bir satır seçiniz..");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtGridHakem.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                DialogResult silOnayAl = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silOnayAl == DialogResult.Yes)
                {
                    int id = (int)dtGridHakem.CurrentRow.Cells[0].Value;
                    _hakemFormCon.silHakemDB(id);
                    dtGridYenile(txtArama.Text);
                }
            }
            else
                MessageBox.Show("Lütfen DataGridview'den bir satır seçiniz..");
        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            takimFormunuAc();
        }

        private void btnTakim_Click(object sender, EventArgs e)
        {
            takimFormunuAc();
        }

        private void btnStad_Click(object sender, EventArgs e)
        {
            stadFormunuAc();
        }

        private void btnStad2_Click(object sender, EventArgs e)
        {
            stadFormunuAc();
        }

        private void comboTxtTemizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            comboBolge.SelectedIndex = 0;
            comboKlasman.SelectedIndex = 0;
            comboTuru.SelectedIndex = 0;
        }

        public void defaultDegerleriAta()
        {
            comboKlasman.SelectedIndex = 0;
            comboTuru.SelectedIndex = 0;
            comboBolge.SelectedIndex = 0;
        }

        private void takimFormunuAc()
        {
            this.Hide();
            _anaFormCon.takimAnaFormAc();
        }

        private void stadFormunuAc()
        {
            this.Hide();
            _anaFormCon.stadAnaFrmAc();
        }



    }
}
