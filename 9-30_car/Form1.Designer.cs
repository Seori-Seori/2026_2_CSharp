namespace _9_30_car
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.rdo_pour = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_pick = new System.Windows.Forms.RadioButton();
            this.rdo_raw = new System.Windows.Forms.RadioButton();
            this.gbox_car = new System.Windows.Forms.GroupBox();
            this.cb_benz = new System.Windows.Forms.CheckBox();
            this.cb_BMW = new System.Windows.Forms.CheckBox();
            this.cb_audi = new System.Windows.Forms.CheckBox();
            this.cb_por = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbox_car.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(88, 275);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(257, 64);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(238, 226);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(96, 43);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "결정하기";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // rdo_pour
            // 
            this.rdo_pour.AutoSize = true;
            this.rdo_pour.Location = new System.Drawing.Point(6, 24);
            this.rdo_pour.Name = "rdo_pour";
            this.rdo_pour.Size = new System.Drawing.Size(88, 19);
            this.rdo_pour.TabIndex = 2;
            this.rdo_pour.TabStop = true;
            this.rdo_pour.Text = "부어먹기";
            this.rdo_pour.UseVisualStyleBackColor = true;
            this.rdo_pour.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_raw);
            this.groupBox1.Controls.Add(this.rdo_pick);
            this.groupBox1.Controls.Add(this.rdo_pour);
            this.groupBox1.Location = new System.Drawing.Point(278, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdo_pick
            // 
            this.rdo_pick.AutoSize = true;
            this.rdo_pick.Location = new System.Drawing.Point(6, 49);
            this.rdo_pick.Name = "rdo_pick";
            this.rdo_pick.Size = new System.Drawing.Size(88, 19);
            this.rdo_pick.TabIndex = 3;
            this.rdo_pick.TabStop = true;
            this.rdo_pick.Text = "찍어먹기";
            this.rdo_pick.UseVisualStyleBackColor = true;
            // 
            // rdo_raw
            // 
            this.rdo_raw.AutoSize = true;
            this.rdo_raw.Location = new System.Drawing.Point(6, 74);
            this.rdo_raw.Name = "rdo_raw";
            this.rdo_raw.Size = new System.Drawing.Size(93, 19);
            this.rdo_raw.TabIndex = 4;
            this.rdo_raw.TabStop = true;
            this.rdo_raw.Text = "그냥 먹기";
            this.rdo_raw.UseVisualStyleBackColor = true;
            // 
            // gbox_car
            // 
            this.gbox_car.Controls.Add(this.cb_por);
            this.gbox_car.Controls.Add(this.cb_audi);
            this.gbox_car.Controls.Add(this.cb_BMW);
            this.gbox_car.Controls.Add(this.cb_benz);
            this.gbox_car.Location = new System.Drawing.Point(22, 57);
            this.gbox_car.Name = "gbox_car";
            this.gbox_car.Size = new System.Drawing.Size(200, 151);
            this.gbox_car.TabIndex = 4;
            this.gbox_car.TabStop = false;
            this.gbox_car.Text = "자동차";
            // 
            // cb_benz
            // 
            this.cb_benz.AutoSize = true;
            this.cb_benz.Location = new System.Drawing.Point(6, 24);
            this.cb_benz.Name = "cb_benz";
            this.cb_benz.Size = new System.Drawing.Size(59, 19);
            this.cb_benz.TabIndex = 5;
            this.cb_benz.Text = "벤츠";
            this.cb_benz.UseVisualStyleBackColor = true;
            // 
            // cb_BMW
            // 
            this.cb_BMW.AutoSize = true;
            this.cb_BMW.Location = new System.Drawing.Point(6, 49);
            this.cb_BMW.Name = "cb_BMW";
            this.cb_BMW.Size = new System.Drawing.Size(65, 19);
            this.cb_BMW.TabIndex = 6;
            this.cb_BMW.Text = "BMW";
            this.cb_BMW.UseVisualStyleBackColor = true;
            this.cb_BMW.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cb_audi
            // 
            this.cb_audi.AutoSize = true;
            this.cb_audi.Location = new System.Drawing.Point(6, 74);
            this.cb_audi.Name = "cb_audi";
            this.cb_audi.Size = new System.Drawing.Size(74, 19);
            this.cb_audi.TabIndex = 7;
            this.cb_audi.Text = "아우디";
            this.cb_audi.UseVisualStyleBackColor = true;
            this.cb_audi.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cb_por
            // 
            this.cb_por.AutoSize = true;
            this.cb_por.Location = new System.Drawing.Point(6, 99);
            this.cb_por.Name = "cb_por";
            this.cb_por.Size = new System.Drawing.Size(74, 19);
            this.cb_por.TabIndex = 8;
            this.cb_por.Text = "포르쉐";
            this.cb_por.UseVisualStyleBackColor = true;
            this.cb_por.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_car);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbox_car.ResumeLayout(false);
            this.gbox_car.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.RadioButton rdo_pour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_raw;
        private System.Windows.Forms.RadioButton rdo_pick;
        private System.Windows.Forms.GroupBox gbox_car;
        private System.Windows.Forms.CheckBox cb_por;
        private System.Windows.Forms.CheckBox cb_audi;
        private System.Windows.Forms.CheckBox cb_BMW;
        private System.Windows.Forms.CheckBox cb_benz;
    }
}

