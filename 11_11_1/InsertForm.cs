using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _11_11_1
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlCommand cmd;
        SqlConnection conn;

        SqlDataReader reader;

        private void InsertForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (conn != null)
                conn.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database=CookDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string data1, data2, data3, data4, sql;

            data1 = tb_id.Text;
            data2 = tb_name.Text;
            data3 = tb_email.Text;
            data4 = tb_birth.Text;

            sql = "INSERT INTO Member VALUES('" + data1 + "','" + data2 + "','" + data3 + "'," + data4 + ")";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("회원가입이 완료되었습니다.");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
