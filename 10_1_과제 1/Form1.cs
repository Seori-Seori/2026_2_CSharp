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
           
            if (tb_id.Text == "" || tb_pass.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tb_id.Text == "admin" && tb_pass.Text == "1234")
            {
                MessageBox.Show("로그인 성공!", "로그인 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_id.Clear();
                tb_pass.Clear();
            }
        }
    }
}
