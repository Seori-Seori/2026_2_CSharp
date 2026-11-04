namespace _11_04_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_birth;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_birth;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ListView list_result;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_birth = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_birth = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.list_result = new System.Windows.Forms.ListView();
            this.SuspendLayout();

            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(38, 30);
            this.label_id.Name = "label_id";
            this.label_id.Text = "아이디";
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(137, 30);
            this.label_name.Name = "label_name";
            this.label_name.Text = "이름";
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(253, 30);
            this.label_email.Name = "label_email";
            this.label_email.Text = "이메일";
            this.label_birth.AutoSize = true;
            this.label_birth.Location = new System.Drawing.Point(373, 30);
            this.label_birth.Name = "label_birth";
            this.label_birth.Text = "출생연도";

            this.tb_id.Location = new System.Drawing.Point(26, 52);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(85, 23);
            this.tb_name.Location = new System.Drawing.Point(120, 52);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(101, 23);
            this.tb_email.Location = new System.Drawing.Point(230, 52);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(130, 23);
            this.tb_birth.Location = new System.Drawing.Point(369, 52);
            this.tb_birth.Name = "tb_birth";
            this.tb_birth.Size = new System.Drawing.Size(70, 23);

            this.btn_insert.Location = new System.Drawing.Point(115, 107);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(83, 28);
            this.btn_insert.Text = "입력";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);

            this.btn_select.Location = new System.Drawing.Point(252, 107);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(83, 28);
            this.btn_select.Text = "조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);

            this.list_result.Location = new System.Drawing.Point(26, 159);
            this.list_result.Name = "list_result";
            this.list_result.Size = new System.Drawing.Size(413, 225);
            this.list_result.TabIndex = 6;
            this.list_result.UseCompatibleStateImageBehavior = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 407);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI 데이터베이스 연결";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
