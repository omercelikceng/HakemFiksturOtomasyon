using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Drawing;

namespace HakemFiksturOtomasyon.SingletonXml
{
    class ComponentConfiguration
    {
        private static ComponentConfiguration _instance;
        private static Object kilitObjesi = new object();
        String tip;
        XmlDocument xdoc;
        CursorConverter curConverter = new CursorConverter();
        private ComponentConfiguration()
        { }

        public static ComponentConfiguration getInstance()
        {
            if (_instance == null)
            {
                lock (kilitObjesi) // Thread Kullanımlarında yeni nesne oluşumunu engellemek için
                {
                    if (_instance == null)
                        _instance = new ComponentConfiguration();

                }
            }
            return _instance;
        }

        public void xmlOku(String _tip)
        {
            tip = _tip;
            xdoc = new XmlDocument();
            xdoc.Load("..\\..\\SingletonXml\\componentsconfig.xml");
            textBoxOzellikAta();
            comboOzellikAta();
            butonOzellikAta();
            panelOzellikAta();
            dtGridOzellikAta();
        }

        private void dtGridOzellikAta()
        {
            XmlNodeList list = xdoc.GetElementsByTagName("datagridview");
            foreach (XmlNode item in list)
            {
                if (item.Attributes["tip"].Value == tip)
                    dataGridCursor =(Cursor)curConverter.ConvertFromString(item["cursor"].InnerText);
            }
        }

        private void panelOzellikAta()
        {
            XmlNodeList list = xdoc.GetElementsByTagName("panel");
            foreach (XmlNode item in list)
            {
                if (item.Attributes["tip"].Value == tip)
                {
                    panelBackgroundColor = Color.FromName(item["bgcolor"].InnerText);
                }
            }
        }

        private void textBoxOzellikAta()
        {
            XmlNodeList list = xdoc.GetElementsByTagName("textbox");
            foreach (XmlNode item in list)
            {
                if (item.Attributes["tip"].Value == tip)
                {
                    textBoxTextColor = Color.FromName(item["textcolor"].InnerText);
                    textBoxBackgroundColor = Color.FromName(item["bgcolor"].InnerText);
                    textBoxFont = new Font(item["font"].InnerText, float.Parse(item["font-size"].InnerText));
                    textBoxCursor =(Cursor)curConverter.ConvertFromString(item["cursor"].InnerText);
                }
            }
        }

        private void comboOzellikAta()
        {
            XmlNodeList list = xdoc.GetElementsByTagName("combobox");
            foreach (XmlNode item in list)
            {
                if (item.Attributes["tip"].Value == tip)
                {
                    comboBoxTextColor = Color.FromName(item["textcolor"].InnerText);
                    comboBoxBackgroundColor = Color.FromName(item["bgcolor"].InnerText);
                    comboBoxFont = new Font(item["font"].InnerText, float.Parse(item["font-size"].InnerText));
                    comboBoxCursor = (Cursor)curConverter.ConvertFromString(item["cursor"].InnerText);
                }
            }
        }

        private void butonOzellikAta()
        {
            XmlNodeList list = xdoc.GetElementsByTagName("button");
            foreach (XmlNode item in list)
            {
                if (item.Attributes["tip"].Value == tip)
                {
                    butonTextColor = Color.FromName(item["textcolor"].InnerText);
                    butonBackgroundColor = Color.FromName(item["bgcolor"].InnerText);
                    butonFont = new Font(item["font"].InnerText, float.Parse(item["font-size"].InnerText));
                    butonCursor = (Cursor)curConverter.ConvertFromString(item["cursor"].InnerText);
                }
            }

        }
        public Color textBoxTextColor { get; set; }
        public Color textBoxBackgroundColor { get; set; }
        public Font textBoxFont { get; set; }
        public Cursor textBoxCursor { get; set; }

        public Color butonTextColor { get; set; }
        public Color butonBackgroundColor { get; set; }
        public Font butonFont { get; set; }
        public Cursor butonCursor { get; set; }

        public Color comboBoxTextColor { get; set; }
        public Color comboBoxBackgroundColor { get; set; }
        public Font comboBoxFont { get; set; }
        public Cursor comboBoxCursor { get; set; }

        public Color panelBackgroundColor { get; set; }

        public Cursor dataGridCursor { get; set; }


    }
}
