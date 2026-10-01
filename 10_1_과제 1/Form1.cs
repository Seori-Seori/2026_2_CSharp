using System;
using System.Windows.Forms;

namespace _10_1_과제1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_pass.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // TODO: 아이디와 비밀번호가 틀렸는지 확인한다.
            // TODO: 로그인 실패 시 tb_id와 tb_pass의 내용을 지운다.
        }
    }
}
