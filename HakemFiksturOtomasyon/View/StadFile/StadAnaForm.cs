using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon;
using HakemFiksturOtomasyon.Controller.StadFile;
using HakemFiksturOtomasyon.Controller.AnaFormFile;
using HakemFiksturOtomasyon.SingletonXml;

namespace HakemFiksturOtomasyon.View.StadFile
{
    public partial class StadAnaForm : Form
    {
        StadFormCon _stadFormCon;
        StadGuncelleForm _stadGuncelleForm;
        AnaFormCon _anaFormCon;
        GörselOzellikleriAta _ozellikAta;
        ComponentConfiguration compo;

        public StadAnaForm()
        {
            InitializeComponent();
            _stadFormCon = new StadFormCon();
            _anaFormCon = new AnaFormCon();
            _ozellikAta = new GörselOzellikleriAta();
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            Stadyum stad = new Stadyum();
            stad.adi = txtAd.Text;
            stad.diger = txtDiger.Text;
            stad.sehirId = (int)comboSehir.SelectedValue;
            _stadFormCon.kaydetStadDB(stad);
            comboTxtTemizle();
            dtGridYenile(txtArama.Text);
            MessageBox.Show("Ekleme işlemi başarıyla tamamlandı..");
        }

        private void StadAnaForm_Load(object sender, EventArgs e)
        {
            compo = ComponentConfiguration.getInstance();
            _ozellikAta.bilesenlereOzellikAta(this, compo);
            comboSehir = _stadFormCon.comboSehirDoldur(comboSehir);
            dtGridYenile(txtArama.Text);
            dtGridStad.Columns[0].Visible = false;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dtGridYenile(txtArama.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtGridStad.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                DialogResult silOnayAl = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silOnayAl == DialogResult.Yes)
                {
                    int id = (int)dtGridStad.CurrentRow.Cells[0].Value;
                    _stadFormCon.silStadDB(id);
                    dtGridYenile(txtArama.Text);
                }
            }
            else
                MessageBox.Show("Lütfen DataGridview'den bir satır seçiniz..");
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dtGridStad.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                _stadGuncelleForm = new StadGuncelleForm(this);
                _stadGuncelleForm.Show();
                _stadGuncelleForm.bilgileriDoldur(dtGridStad.CurrentRow, txtArama.Text);
            }
            else
                MessageBox.Show("Lütfen DataGridview'den bir satır seçiniz..");
        }

        public void dtGridYenile(String metin)
        {
            dtGridStad.DataSource = _stadFormCon.dtGridDoldur(metin);
        }

        private void comboTxtTemizle()
        {
            txtAd.Text = "";
            comboSehir.SelectedIndex = 0;
            txtDiger.Text = "";
        }

        private void takimFormunuAc()
        {
            this.Hide();
            _anaFormCon.takimAnaFormAc();
        }

        private void hakemFormunuAc()
        {
            this.Hide();
            _anaFormCon.hakemAnaFormAc();
        }

        private void btnTakim_Click(object sender, EventArgs e)
        {
            takimFormunuAc();
        }

        private void btnTakim2_Click(object sender, EventArgs e)
        {
            takimFormunuAc();
        }

        private void btnHakem2_Click(object sender, EventArgs e)
        {
            hakemFormunuAc();
        }

        private void btnHakem_Click(object sender, EventArgs e)
        {
            hakemFormunuAc();
        }

    }
}
