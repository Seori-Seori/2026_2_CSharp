namespace _11_11_1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label_update_id;
        private System.Windows.Forms.TextBox tb_update_id;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label_update_id = new System.Windows.Forms.Label();
            this.tb_update_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(50, 18);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(240, 40);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "회원 관리 시스템";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(35, 88);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(110, 35);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "회원 조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(35, 143);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(110, 35);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "신규 회원";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(35, 198);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 35);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "회원 수정";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(35, 253);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 35);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "회원 삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label_update_id
            // 
            this.label_update_id.AutoSize = true;
            this.label_update_id.Location = new System.Drawing.Point(185, 202);
            this.label_update_id.Name = "label_update_id";
            this.label_update_id.Size = new System.Drawing.Size(172, 15);
            this.label_update_id.TabIndex = 1;
            this.label_update_id.Text = "수정 또는 삭제할 아이디";
            // 
            // tb_update_id
            // 
            this.tb_update_id.Location = new System.Drawing.Point(185, 232);
            this.tb_update_id.Name = "tb_update_id";
            this.tb_update_id.Size = new System.Drawing.Size(165, 25);
            this.tb_update_id.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 335);
            this.Controls.Add(this.tb_update_id);
            this.Controls.Add(this.label_update_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label_title);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 관리 시스템";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
