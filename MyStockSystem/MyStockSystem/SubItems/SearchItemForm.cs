using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyStockSystem.SubItems
{
    public partial class SearchItemForm : MetroForm
    {
        public SearchItemForm()
        {
            InitializeComponent();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {
            DgvSearchItems.Font = new Font("NanumGothic", 10, FontStyle.Regular);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm searchItem = new MainForm();
            searchItem.Location = this.Location;
            searchItem.ShowDialog();

            this.Close();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1");
            str.Append("?serviceKey=g3WYtEP8jFs365eer9YZS7bzG1TK8V7773NBlAUtbhKFHQeUq3KVeig6x71WUumuc%2FCIvBFQRA64VJSjmYyHEg%3D%3D");
            str.Append($"&secnNm={TxtSearchItem.Text}"); // 발인회사명 = 종목명, 검색
            str.Append("&pageNo=1");    // 페이지 수
            str.Append("&numOfRows=200"); // 읽어올 데이터 수
            str.Append("&martTpcd=11");  // 주식시장종류 : 11은 유가증권시장

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            DgvSearchItems.Rows.Clear();
            foreach (XmlNode item in items)
            {
                DgvSearchItems.Rows.Add(item["isin"].InnerText, // 종목 번호
                    item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText, // 발행일
                    item["korSecnNm"].InnerText, // 한국 종목 명
                    item["secnKacdNm"].InnerText, // 주식 종류
                    item["shotnIsin"].InnerText); // 단축코드
            }

            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void TxtSearchItem_Click(object sender, EventArgs e)
        {

        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) // enter
            {
                metroButton1_Click(sender, new EventArgs());
            }

        }
    }
}



