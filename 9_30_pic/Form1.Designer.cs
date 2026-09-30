namespace _9_30_pic
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tree_pet = new System.Windows.Forms.TreeView();
            this.cd_original = new System.Windows.Forms.CheckBox();
            this.pb_pet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pet)).BeginInit();
            this.SuspendLayout();
            // 
            // tree_pet
            // 
            this.tree_pet.Location = new System.Drawing.Point(41, 69);
            this.tree_pet.Name = "tree_pet";
            this.tree_pet.Size = new System.Drawing.Size(196, 302);
            this.tree_pet.TabIndex = 0;
            this.tree_pet.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_pet_AfterSelect);
            // 
            // cd_original
            // 
            this.cd_original.AutoSize = true;
            this.cd_original.Location = new System.Drawing.Point(333, 24);
            this.cd_original.Name = "cd_original";
            this.cd_original.Size = new System.Drawing.Size(119, 19);
            this.cd_original.TabIndex = 1;
            this.cd_original.Text = "원본크기보기";
            this.cd_original.UseVisualStyleBackColor = true;
            this.cd_original.CheckedChanged += new System.EventHandler(this.cd_original_CheckedChanged);
            // 
            // pb_pet
            // 
            this.pb_pet.Location = new System.Drawing.Point(285, 69);
            this.pb_pet.Name = "pb_pet";
            this.pb_pet.Size = new System.Drawing.Size(200, 302);
            this.pb_pet.TabIndex = 2;
            this.pb_pet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_pet);
            this.Controls.Add(this.cd_original);
            this.Controls.Add(this.tree_pet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_pet;
        private System.Windows.Forms.CheckBox cd_original;
        private System.Windows.Forms.PictureBox pb_pet;
    }
}

