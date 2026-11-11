namespace _11_11_1
{
    partial class SelectForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ListView list_member;
        private System.Windows.Forms.Button btn_sel_update;
        private System.Windows.Forms.Button btn_sel_delete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.list_member = new System.Windows.Forms.ListView();
            this.btn_sel_update = new System.Windows.Forms.Button();
            this.btn_sel_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(104, 17);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(143, 40);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "회원 조회";
            // 
            // list_member
            // 
            this.list_member.HideSelection = false;
            this.list_member.Location = new System.Drawing.Point(30, 75);
            this.list_member.Name = "list_member";
            this.list_member.Size = new System.Drawing.Size(315, 200);
            this.list_member.TabIndex = 2;
            this.list_member.UseCompatibleStateImageBehavior = false;
            // 
            // btn_sel_update
            // 
            this.btn_sel_update.Location = new System.Drawing.Point(40, 291);
            this.btn_sel_update.Name = "btn_sel_update";
            this.btn_sel_update.Size = new System.Drawing.Size(135, 35);
            this.btn_sel_update.TabIndex = 1;
            this.btn_sel_update.Text = "선택 회원 수정";
            this.btn_sel_update.UseVisualStyleBackColor = true;
            this.btn_sel_update.Click += new System.EventHandler(this.btn_sel_update_Click);
            // 
            // btn_sel_delete
            // 
            this.btn_sel_delete.Location = new System.Drawing.Point(200, 291);
            this.btn_sel_delete.Name = "btn_sel_delete";
            this.btn_sel_delete.Size = new System.Drawing.Size(135, 35);
            this.btn_sel_delete.TabIndex = 0;
            this.btn_sel_delete.Text = "선택 회원 삭제";
            this.btn_sel_delete.UseVisualStyleBackColor = true;
            this.btn_sel_delete.Click += new System.EventHandler(this.btn_sel_delete_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 351);
            this.Controls.Add(this.btn_sel_delete);
            this.Controls.Add(this.btn_sel_update);
            this.Controls.Add(this.list_member);
            this.Controls.Add(this.label_title);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원 조회";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectForm_FormClosed);
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
