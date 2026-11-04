namespace _11_04_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tb_id, tb_name, tb_email, tb_birth;
        private System.Windows.Forms.Button btn_insert, btn_select;
        private System.Windows.Forms.ListView list_result;
        private System.Windows.Forms.Label label_id, label_name, label_email, label_birth;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_birth = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.list_result = new System.Windows.Forms.ListView();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_birth = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label_id.Text = "아이디";
            this.label_id.Location = new System.Drawing.Point(20, 20);
            this.label_id.Size = new System.Drawing.Size(100, 20);
            this.label_name.Text = "이름";
            this.label_name.Location = new System.Drawing.Point(150, 20);
            this.label_name.Size = new System.Drawing.Size(100, 20);
            this.label_email.Text = "이메일";
            this.label_email.Location = new System.Drawing.Point(295, 20);
            this.label_email.Size = new System.Drawing.Size(100, 20);
            this.label_birth.Text = "출생연도";
            this.label_birth.Location = new System.Drawing.Point(495, 20);
            this.label_birth.Size = new System.Drawing.Size(100, 20);

            this.tb_id.Name = "tb_id";
            this.tb_id.Location = new System.Drawing.Point(20, 45);
            this.tb_id.Size = new System.Drawing.Size(115, 25);
            this.tb_id.MaxLength = 4;
            this.tb_name.Name = "tb_name";
            this.tb_name.Location = new System.Drawing.Point(150, 45);
            this.tb_name.Size = new System.Drawing.Size(130, 25);
            this.tb_name.MaxLength = 15;
            this.tb_email.Name = "tb_email";
            this.tb_email.Location = new System.Drawing.Point(295, 45);
            this.tb_email.Size = new System.Drawing.Size(185, 25);
            this.tb_email.MaxLength = 15;
            this.tb_birth.Name = "tb_birth";
            this.tb_birth.Location = new System.Drawing.Point(495, 45);
            this.tb_birth.Size = new System.Drawing.Size(95, 25);
            this.tb_birth.MaxLength = 4;

            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Text = "입력";
            this.btn_insert.Location = new System.Drawing.Point(204, 90);
            this.btn_insert.Size = new System.Drawing.Size(90, 30);
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_select.Name = "btn_select";
            this.btn_select.Text = "조회";
            this.btn_select.Location = new System.Drawing.Point(314, 90);
            this.btn_select.Size = new System.Drawing.Size(90, 30);
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);

            this.list_result.Name = "list_result";
            this.list_result.Location = new System.Drawing.Point(20, 139);
            this.list_result.Size = new System.Drawing.Size(575, 280);
            this.list_result.View = System.Windows.Forms.View.Details;
            this.list_result.GridLines = true;
            this.list_result.FullRowSelect = true;
            this.list_result.Columns.Add("아이디", 90);
            this.list_result.Columns.Add("이름", 145);
            this.list_result.Columns.Add("이메일", 215);
            this.list_result.Columns.Add("출생연도", 100);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 439);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_birth);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_birth);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.list_result);
            this.Text = "10주차 SQL 회원 입력·조회";
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
