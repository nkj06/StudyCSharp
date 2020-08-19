using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop.SubItems
{
    public partial class DivMngForm : MetroForm
    {
        readonly string strTBLname = "divtbl";
        public DivMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            using (MySqlConnection conn = new MySqlConnection(common.CONNSTR))
            {
                //쿼리
                string strQuery = $"SELECT Division, Names FROM {strTBLname}";
                conn.Open();
                //커맨드 생성
                MySqlCommand cmd = new MySqlCommand();
                //커멘드에 db 연결
                cmd.Connection = conn;
                //쿼리 연동
                cmd.CommandText = strQuery;

                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "divtbl");

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = strTBLname;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btlNew_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }
    }
}
