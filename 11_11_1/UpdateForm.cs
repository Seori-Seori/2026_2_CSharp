using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _11_11_1
{
    public partial class UpdateForm : Form
    {
        string memberID;
        public UpdateForm(string paraID)
        {
            InitializeComponent();
            memberID = paraID;
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            connStr = "Server = localhost\\SQLEXPRESS;Database = CookDB;Trusted_Connection = True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM member WHERE id = '" + memberID + "'";
            reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                reader.Close();
                MessageBox.Show("해당 아이디가 존재하지 않습니다.");
                this.Close();
            }
            else
            {
                string data1, data2, data3, data4;
                data1 = reader.GetString(0).Trim();
                data2 = reader.GetString(1).Trim();
                data3 = reader.GetString(2).Trim();
                data4 = reader.GetInt32(3).ToString().Trim();

                tb_update_id.Text = data1;
                tb_update_name.Text = data2;
                tb_update_email.Text = data3;
                tb_update_birth.Text = data4;
                reader.Close();
            }
        }

        private void UpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string data1, data2, data3, data4,sql;
            data1 = tb_update_id.Text;
            data2 = tb_update_name.Text;
            data3 = tb_update_email.Text;
            data4 = tb_update_birth.Text;

            sql = "UPDATE member SET name = '" + data2 + "', email = '" + data3 + "', birth = " + data4 + " WHERE id = '" + data1 + "'";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            MessageBox.Show("수정되었습니다.");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
