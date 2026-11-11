using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _11_11_1
{
    public partial class DeleteForm : Form
    {
        string memberID;
        public DeleteForm(string paraID)
        {
            InitializeComponent();
            this.memberID = paraID;
        }

        string connStr;
        SqlConnection conn;

        SqlCommand cmd;
        SqlDataReader reader;

        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost;Database=CookDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM Member WHERE MemberID = @MemberID";
            reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                MessageBox.Show("해당 아이디는 회원이 아닙니다.");
                this.Close();
            }
            else
            {
                string data1, data2, data3, data4;

                data1 = reader.GetString(0).Trim();
                data2 = reader.GetString(1).Trim();
                data3 = reader.GetString(2).Trim();
                data4 = reader.GetInt32(3).ToString().Trim();

                tb_id.Text = data1;
                tb_name.Text = data2;
                tb_email.Text = data3;
                tb_birth.Text = data4;
                reader.Close();
            }
        }

        private void DeleteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string data1, sql;

            data1 = tb_id.Text.Trim();

            sql = "Delete FROM Member WHERE MemberID = @MemberID";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            MessageBox.Show("회원 탈퇴가 완료되었습니다.");
            this.Close();
        }
    }
}
