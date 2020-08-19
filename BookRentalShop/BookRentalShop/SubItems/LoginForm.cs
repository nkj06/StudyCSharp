using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShop.SubItems
{
    public partial class LoginForm : MetroForm
    {
        private readonly string strConnectionString =
            "Data Source = localhost;Port=3306;Database=bookrentalshop;Uid=root;Password=0000";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LoginProcess(); // Alt + Enter 눌려서 메서드 생성
        }

        // 메서드 생성된게 아래
        private void LoginProcess()
        {

            // if(TxtID.Text == "" || TxtID.Text == null ||
            //    TxtPassword.Text == null || TxtPassword.Text == "")
            // 위 대신 아래
            // 빈값비교 처리
            if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtPassword.Text))
            {
                // MessageBox.Show("아이디나 패스워드를 입력하세요!", "로그인", 
                // 스타일 다름 Metro는 this를 써야함
                MetroMessageBox.Show(this,"아이디나 패스워드를 입력하세요!", "로그인",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtUserID.Focus();
                return;
            }

            // 실제 DB처리
            string resultId = string.Empty; // ""랑 같은 것

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConnectionString)) // 빨간줄 Alt+Enter 필드생성
                {
                    conn.Open(); // 오픈 안되면 에러남
                    // MetroMessageBox.Show(this, $"DB접속성공!!");
                    MySqlCommand cmd = new MySqlCommand(); // MySQL에 명령을 날릴 때 쓰는 객체(인스턴스?)
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT userID FROM usertbl " +
                                      " WHERE userID = @userID " +
                                       "  AND Password = @Password ";

                    MySqlParameter paramUserId = new MySqlParameter("@userID", MySqlDbType.VarChar, 12);
                    paramUserId.Value = TxtUserID.Text.Trim();
                    MySqlParameter paramPassword = new MySqlParameter("@Password", MySqlDbType.VarChar);
                    paramPassword.Value = TxtPassword.Text.Trim();

                    cmd.Parameters.Add(paramUserId);
                    cmd.Parameters.Add(paramPassword);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if(!reader.HasRows)
                    {
                        MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요", "로그인실패",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUserID.Text = TxtPassword.Text = string.Empty;
                        TxtUserID.Focus();
                        return;
                    }
                    else
                    {
                        resultId = reader["userID"] != null ? reader["userID"].ToString() : string.Empty;
                        MetroMessageBox.Show(this, $"{resultId} 로그인성공");
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"DB접속에러 : {ex.Message}", "로그인에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(resultId))
            {
                MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요", "로그인실패",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUserID.Text = TxtPassword.Text = string.Empty;
                TxtUserID.Focus();
                return;
            }
            else // 로그인 성공시
            {
                this.Close(); // 로그인 창 닫음
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // 프로그램 종료
        }

        private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e) // Enter키 누르면 password로 감
        {
            if(e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) // Enter키 누르면 확인 클릭 됨
        {
            if(e.KeyChar == 13)
            {
                BtnOK_Click(sender, new EventArgs());
            }
        }
    }
}
