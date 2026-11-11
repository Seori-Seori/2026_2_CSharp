using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _11_11_1
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        private void SelectForm_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=CookDB;Trusted_Connection=true;";
            conn = new SqlConnection(connStr);
            conn.Open();

            list_member.View = View.Details;
            list_member.GridLines = true;
            int listWidth = list_member.Width;
            list_member.Columns.Add("아이디", (int)(listWidth * 0.2));
            list_member.Columns.Add("이름", (int)(listWidth * 0.3));
            list_member.Columns.Add("이메일", (int)(listWidth * 0.3));
            list_member.Columns.Add("출생년도", (int)(listWidth * 0.2));

            string data1, data2, data3, data4;

            cmd.CommandText = "SELECT * FROM member";

            SqlDataReader reader = cmd.ExecuteReader();

            list_member.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                data1 = reader.GetString(0);
                data2 = reader.GetString(1);
                data3 = reader.GetString(2);
                data4 = reader.GetInt32(3).ToString();
                item = new ListViewItem(data1);
                item.SubItems.Add(data2);
                item.SubItems.Add(data3);
                item.SubItems.Add(data4);
                list_member.Items.Add(item);
            }
            reader.Close();

        }

        private void btn_sel_delete_Click(object sender, EventArgs e)
        {
            if(list_member.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 아이디를 먼저 선택하세요");
                return;
            }
            DeleteForm subForm = new DeleteForm();
            subForm.ShowDialog();
            this.Close();
        }

        private void btn_sel_update_Click(object sender, EventArgs e)
        {
            if (list_member.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 아이디를 먼저 선택하세요");
                return;
            }
            UpdateForm subForm = new UpdateForm();
            subForm.ShowDialog();
            this.Close();
        }

        private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
