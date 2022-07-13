using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace vericekme10
{
    public partial class Form1 : Form
    {
        string Link = "https://www.isyatirim.com.tr/tr-tr/analiz/hisse/Sayfalar/default.aspx";
        string Xpath = "/html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[position()>0]";
        //html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[1]/td[1]/a
        //html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[1]/td[2]
        //html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[1]/td[3]/span
        //html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[1]/td[4]
        //html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[1]/td[5]
        //html/body/form/div[4]/div/div[2]/div/div/div[1]/div/div[3]/div[1]/div[1]/div/div[1]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr[1]/td[6]

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBorsaYukle();
        }


        void BorsaYukle()
        {
            var Borsalar = new List<Borsa>();

            var Web = new HtmlWeb();

            var Dock = Web.Load(Link);

            var Nodes = Dock.DocumentNode.SelectNodes(Xpath);

            foreach (var Node in Nodes)
            {
                try
                {
                    var Borsa = new Borsa
                    {
                        hisse = Node.SelectSingleNode("td[1]/a").InnerText,
                        sonfiyat = Node.SelectSingleNode("td[2]").InnerText,
                        degisim1 = Node.SelectSingleNode("td[3]/span").InnerText,
                        degisim2 = Node.SelectSingleNode("td[4]").InnerText,
                        hacim1 = Node.SelectSingleNode("td[5]").InnerText,
                        hacim2 = Node.SelectSingleNode("td[6]").InnerText,

                    };

                    Borsalar.Add(Borsa);
                }
                catch { }
            }

            foreach (var Borsa in Borsalar)
            {
                dataGridView1.Rows.Add(Borsa.hisse, Borsa.sonfiyat, Borsa.degisim1, Borsa.degisim2, Borsa.hisse, Borsa.hacim2);
            }





        }


        class Borsa
        {
            public string hisse { get; set; }

            public string sonfiyat { get; set; }

            public string degisim1 { get; set; }

            public string degisim2 { get; set; }

            public string hacim1 { get; set; }

            public string hacim2 { get; set; }

        }
    }
}
