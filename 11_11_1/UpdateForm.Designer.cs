namespace _11_11_1
{
    partial class UpdateForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_birth;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_birth;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_birth = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_birth = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.label_title.Location = new System.Drawing.Point(73, 16);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(195, 37);
            this.label_title.Text = "회원 정보 수정";
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));

            this.label_id.Location = new System.Drawing.Point(30, 77);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(75, 23);
            this.label_id.Text = "아이디";
            this.label_id.AutoSize = true;

            this.label_name.Location = new System.Drawing.Point(30, 119);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(75, 23);
            this.label_name.Text = "이름";
            this.label_name.AutoSize = true;

            this.label_email.Location = new System.Drawing.Point(30, 161);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(75, 23);
            this.label_email.Text = "이메일";
            this.label_email.AutoSize = true;

            this.label_birth.Location = new System.Drawing.Point(30, 203);
            this.label_birth.Name = "label_birth";
            this.label_birth.Size = new System.Drawing.Size(75, 23);
            this.label_birth.Text = "출생연도";
            this.label_birth.AutoSize = true;

            this.tb_id.Location = new System.Drawing.Point(112, 74);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(172, 27);
            this.tb_id.Text = "";
            this.tb_id.ReadOnly = true;

            this.tb_name.Location = new System.Drawing.Point(112, 116);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(172, 27);
            this.tb_name.Text = "";

            this.tb_email.Location = new System.Drawing.Point(112, 158);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(172, 27);
            this.tb_email.Text = "";

            this.tb_birth.Location = new System.Drawing.Point(112, 200);
            this.tb_birth.Name = "tb_birth";
            this.tb_birth.Size = new System.Drawing.Size(172, 27);
            this.tb_birth.Text = "";

            this.btn_ok.Location = new System.Drawing.Point(62, 263);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(85, 33);
            this.btn_ok.Text = "수정";
            this.btn_ok.UseVisualStyleBackColor = true;

            this.btn_cancel.Location = new System.Drawing.Point(177, 263);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 33);
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 331);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_birth);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_birth);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_title);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 정보 수정";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
