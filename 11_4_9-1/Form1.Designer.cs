namespace _11_4_9_1
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.NumericUpDown();
            this.num_1 = new System.Windows.Forms.NumericUpDown();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(107, 216);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 25);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(262, 216);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 25);
            this.btn_sub.TabIndex = 1;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(393, 216);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(75, 25);
            this.btn_mul.TabIndex = 2;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(531, 216);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 25);
            this.btn_div.TabIndex = 3;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(430, 76);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(176, 25);
            this.num_2.TabIndex = 4;
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(92, 76);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(176, 25);
            this.num_1.TabIndex = 5;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(237, 305);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(231, 25);
            this.tb_result.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "숫자1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "숫자2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.NumericUpDown num_2;
        private System.Windows.Forms.NumericUpDown num_1;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

