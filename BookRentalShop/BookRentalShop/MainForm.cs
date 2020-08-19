using System;
using System.Windows.Forms;
using BookRentalShop.SubItems;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShop
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) // 실행시킬때 메인폼 위에 로그인 다이얼로그창이 먼저 뜸
        {
            LoginForm Login = new LoginForm();
            Login.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) // 프로그램 종료
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else // 프로그램 종료 안함
            {
                e.Cancel = true;
            }
        }

        private void MnuItemCodeMng_Click(object sender, EventArgs e)
        {
            DivMngForm form = new DivMngForm();
            form.MdiParent = this;
            form.Text = "구분코드 관리";
            form.Dock = DockStyle.Fill;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
