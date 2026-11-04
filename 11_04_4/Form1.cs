using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _11_04_4
{
    public partial class Form1 : Form
    {
        private readonly string connStr =
            @"Server=localhost\SQLEXPRESS;Database=naverDB;Integrated Security=True;Connect Timeout=5;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text.Trim();
            string name = tb_name.Text.Trim();
            string email = tb_email.Text.Trim();
            int year;

            if (id.Length < 1 || id.Length > 4 || name.Length < 1 ||
                name.Length > 15 || email.Length < 1 || email.Length > 15 ||
                !int.TryParse(tb_birth.Text.Trim(), out year) ||
                year < 1 || year > 9999)
            {
                MessageBox.Show("아이디 1~4자, 이름·이메일 1~15자, 출생연도 숫자를 입력하세요.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(
                    @"IF NOT EXISTS (SELECT 1 FROM dbo.userTable WHERE id = @id)
                      INSERT INTO dbo.userTable (id, userName, email, birthYear)
                      VALUES (@id, @name, @email, @year);", conn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Char, 4).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.Char, 15).Value = name;
                    cmd.Parameters.Add("@email", SqlDbType.Char, 15).Value = email;
                    cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
                    conn.Open();
                    MessageBox.Show(cmd.ExecuteNonQuery() > 0 ?
                        "입력 완료" : "이미 존재하는 ID입니다.");
                }
                LoadMembers();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server 오류: " + ex.Message);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            try
            {
                list_result.Items.Clear();
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT id, userName, email, birthYear FROM dbo.userTable ORDER BY id;", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader.GetString(0).Trim());
                            item.SubItems.Add(reader.GetString(1).Trim());
                            item.SubItems.Add(reader.GetString(2).Trim());
                            item.SubItems.Add(reader.GetInt32(3).ToString());
                            list_result.Items.Add(item);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("조회 오류: " + ex.Message);
            }
        }
    }
}
