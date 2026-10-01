namespace _10_1_과제2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.PictureBox pb_image;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btn_random = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_random
            // 
            this.btn_random.Location = new System.Drawing.Point(30, 25);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(140, 35);
            this.btn_random.TabIndex = 0;
            this.btn_random.Text = "랜덤 동물 사진";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(30, 80);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(300, 260);
            this.pb_image.TabIndex = 1;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 370);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.pb_image);
            this.Name = "Form1";
            this.Text = "10_1_과제 2";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
