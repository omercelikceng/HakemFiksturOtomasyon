using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HakemFiksturOtomasyon.View.AnaFormFile;
using HakemFiksturOtomasyon.View.HakemFile;

namespace HakemFiksturOtomasyon.SingletonXml
{
    class GörselOzellikleriAta
    {
        private Control _control;
        ComponentConfiguration _compo;
        CursorConverter cConverter = new CursorConverter();

        public void bilesenlereOzellikAta(Control con, ComponentConfiguration compo)
        {
            foreach (Control c in con.Controls)
            {
                _control = c;
                _compo = compo;
                if (c is Button)
                    butonaOzellikleriAta();
                if (c is TextBox)
                    textBoxOzellikleriAta();
                if (c is ComboBox)
                    comboBoxOzellikleriAta();
                if (c is Panel)
                    panelOzellikleriAta();
                if (c is DataGridView)
                    dataGridOzellikleriAta();
                if (c.Controls.Count > 0)
                    bilesenlereOzellikAta(c, compo);
            }
        }

        private void dataGridOzellikleriAta()
        {
            _control.Cursor = _compo.dataGridCursor;
        }

        private void panelOzellikleriAta()
        {
            _control.BackColor = _compo.panelBackgroundColor;
        }

        private void comboBoxOzellikleriAta()
        {
            _control.BackColor = _compo.comboBoxBackgroundColor;
            _control.ForeColor = _compo.comboBoxTextColor;
            _control.Font = _compo.comboBoxFont;
            _control.Cursor = _compo.comboBoxCursor;
        }

        private void textBoxOzellikleriAta()
        {
            _control.BackColor = _compo.textBoxBackgroundColor;
            _control.ForeColor = _compo.textBoxTextColor;
            _control.Font = _compo.textBoxFont;
            _control.Cursor = _compo.textBoxCursor;
        }

        private void butonaOzellikleriAta()
        {
            _control.BackColor = _compo.butonBackgroundColor;
            _control.ForeColor = _compo.butonTextColor;
            _control.Font = _compo.butonFont;
            _control.Cursor = _compo.butonCursor;
        }
    }
}
