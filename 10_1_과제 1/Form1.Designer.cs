namespace _10_1_과제1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button btn_login;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_id = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(30, 34);
            this.label_id.Text = "아이디";
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(30, 76);
            this.label_pass.Text = "비밀번호";
            this.tb_id.Location = new System.Drawing.Point(110, 30);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(160, 25);
            this.tb_id.TabIndex = 0;
            this.tb_pass.Location = new System.Drawing.Point(110, 72);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(160, 25);
            this.tb_pass.TabIndex = 1;
            this.btn_login.Location = new System.Drawing.Point(292, 30);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(82, 67);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 140);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "10_1_과제 1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
