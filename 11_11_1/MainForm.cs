using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_11_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            SelectFrom selectForm = new SelectFrom();
            selectForm.ShowDialog();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertForm subForm = new InsertForm();
            subForm.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(tb_update_id.Text == "")
            {
                MessageBox.Show("수정할 아이디를 먼저 입력하세요");
                return;
            }

            UpdateForm subForm = new UpdateForm(tb_update_id.Text);
            subForm.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(tb_delete_id.Text == "")
            {
                MessageBox.Show("삭제할 아이디를 먼저 입력하세요");
                return;
            }
            DeleteForm subForm = new DeleteForm(tb_delete_id.Text);
            subForm.ShowDialog();
        }
    }
}
