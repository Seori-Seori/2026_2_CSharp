using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace w10_hw_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = naverDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            list_result.View = View.Details;
            list_result.GridLines = true;
            int listWidth = list_result.Width;
            list_result.Columns.Add("아이디", (int)(listWidth * 0.2));
            list_result.Columns.Add("이름", (int)(listWidth * 0.3));
            list_result.Columns.Add("이메일", (int)(listWidth * 0.3));
            list_result.Columns.Add("출생연도", (int)(listWidth * 0.2));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
            MessageBox.Show("DB 연결을 종료합니다~");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string data1, data2, data3, data4, sql;

            data1 = tb_id.Text;
            data2 = tb_name.Text;
            data3 = tb_email.Text;
            data4 = tb_birth.Text;

            sql = "INSERT INTO userTable VALUES('" + data1 + "','" + data2 + "','" + data3 + "'," + data4 + ")";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string data1, data2, data3, data4;
            cmd.CommandText = "SELECT * FROM userTable";
            SqlDataReader reader = cmd.ExecuteReader();

            list_result.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                data1 = reader.GetString(0);          // 아이디
                data2 = reader.GetString(1);          // 이름
                data3 = reader.GetString(2);          // 이메일
                data4 = reader.GetInt32(3).ToString();// 출생연도

                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);
                item.SubItems.Add(data4);

                list_result.Items.Add(item);
            }
            reader.Close();
        }
    }
}
