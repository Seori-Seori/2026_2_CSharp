namespace _9_30_mousecont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.tb_action = new System.Windows.Forms.TextBox();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Image = ((System.Drawing.Image)(resources.GetObject("pb_image.Image")));
            this.pb_image.Location = new System.Drawing.Point(205, 57);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(303, 327);
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            this.pb_image.DoubleClick += new System.EventHandler(this.pb_image_DoubleClick);
            this.pb_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_image_MouseDown);
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(54, 57);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(100, 25);
            this.tb_type.TabIndex = 1;
            // 
            // tb_action
            // 
            this.tb_action.Location = new System.Drawing.Point(54, 134);
            this.tb_action.Name = "tb_action";
            this.tb_action.Size = new System.Drawing.Size(100, 25);
            this.tb_action.TabIndex = 2;
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(12, 265);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(49, 25);
            this.tb_x.TabIndex = 3;
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(105, 265);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(49, 25);
            this.tb_y.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.tb_action);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.pb_image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.TextBox tb_action;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_y;
    }
}

