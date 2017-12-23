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
using HakemFiksturOtomasyon.View.StadFile;
using HakemFiksturOtomasyon.Controller.AnaFormFile;
using HakemFiksturOtomasyon.SingletonXml;

namespace HakemFiksturOtomasyon.View.TakimFile
{
    public partial class TakimAnaForm : Form
    {
        TakimFormCon _tkimFormCon;
        TakimGuncelleForm _tkimGuncelleForm;
        AnaFormCon _anaFormCon;
        GörselOzellikleriAta _ozellikAta;
        ComponentConfiguration compo;

        public TakimAnaForm()
        {
            InitializeComponent();
            _tkimFormCon = new TakimFormCon();
            _anaFormCon = new AnaFormCon();
            _ozellikAta = new GörselOzellikleriAta();
        }

        private void TakimAnaForm_Load(object sender, EventArgs e)
        {
            compo = ComponentConfiguration.getInstance();
            _ozellikAta.bilesenlereOzellikAta(this, compo);
            comboLig = _tkimFormCon.comboLigDoldur(comboLig);
            dtGridYenile(txtArama.Text);
            dtGridTakim.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Takim tkm = new Takim();
            tkm.adi = txtAd.Text;
            tkm.diger = txtDiger.Text;
            tkm.ligId = (int)comboLig.SelectedValue;
            _tkimFormCon.kaydetTakimDB(tkm);
            comboTxtTemizle();
            dtGridYenile("");
            MessageBox.Show("Ekleme işlemi başarıyla tamamlandı..");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dtGridTakim.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                _tkimGuncelleForm = new TakimGuncelleForm(this);
                _tkimGuncelleForm.Show();
                _tkimGuncelleForm.bilgileriDoldur(dtGridTakim.CurrentRow, txtArama.Text);
            }
            else
                MessageBox.Show("Lütfen DataGridview'den bir satır seçiniz..");
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dtGridYenile(txtArama.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtGridTakim.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                DialogResult silOnayAl = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silOnayAl == DialogResult.Yes)
                {
                    int id = (int)dtGridTakim.CurrentRow.Cells[0].Value;
                    _tkimFormCon.silTakimDB(id);
                    dtGridYenile(txtArama.Text);
                }
            }
            else
                MessageBox.Show("Lütfen DataGridview'den bir satır seçiniz");
        }

        private void btnStad_Click(object sender, EventArgs e)
        {
            stadFormunuAc();
        }

        private void btnStad2_Click(object sender, EventArgs e)
        {
            stadFormunuAc();
        }

        public void dtGridYenile(String metin)
        {
            dtGridTakim.DataSource = _tkimFormCon.dtGridDoldur(metin);
        }

        private void btnHakem2_Click(object sender, EventArgs e)
        {
            hakemFormunuAc();
        }

        private void btnHakem_Click(object sender, EventArgs e)
        {
            hakemFormunuAc();
        }

        private void comboTxtTemizle()
        {
            txtAd.Text = "";
            txtDiger.Text = "";
            comboLig.SelectedIndex = 0;
        }

        private void hakemFormunuAc()
        {
            this.Hide();
            _anaFormCon.hakemAnaFormAc();
        }

        private void stadFormunuAc()
        {
            this.Hide();
            _anaFormCon.stadAnaFrmAc();
        }


    }
}
