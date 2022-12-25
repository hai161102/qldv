
namespace QuanLiDoanVienTruongDHDN
{
    partial class XeploaiDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textMaXL = new System.Windows.Forms.TextBox();
            this.textTenXL = new System.Windows.Forms.TextBox();
            this.textMaDV = new System.Windows.Forms.TextBox();
            this.textChidoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Xếp Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Xếp Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Đoàn Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chi Đoàn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(152, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "XẾP LOẠI ĐOÀN VIÊN";
            // 
            // textMaXL
            // 
            this.textMaXL.Location = new System.Drawing.Point(130, 76);
            this.textMaXL.Name = "textMaXL";
            this.textMaXL.Size = new System.Drawing.Size(100, 20);
            this.textMaXL.TabIndex = 5;
            this.textMaXL.TextChanged += new System.EventHandler(this.textMaXL_TextChanged);
            // 
            // textTenXL
            // 
            this.textTenXL.Location = new System.Drawing.Point(157, 218);
            this.textTenXL.Name = "textTenXL";
            this.textTenXL.Size = new System.Drawing.Size(100, 20);
            this.textTenXL.TabIndex = 6;
            // 
            // textMaDV
            // 
            this.textMaDV.Location = new System.Drawing.Point(437, 137);
            this.textMaDV.Name = "textMaDV";
            this.textMaDV.Size = new System.Drawing.Size(100, 20);
            this.textMaDV.TabIndex = 7;
            // 
            // textChidoan
            // 
            this.textChidoan.Location = new System.Drawing.Point(437, 274);
            this.textChidoan.Name = "textChidoan";
            this.textChidoan.Size = new System.Drawing.Size(100, 20);
            this.textChidoan.TabIndex = 8;
            // 
            // XeploaiDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 393);
            this.Controls.Add(this.textChidoan);
            this.Controls.Add(this.textMaDV);
            this.Controls.Add(this.textTenXL);
            this.Controls.Add(this.textMaXL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XeploaiDV";
            this.Text = "XeploaiDV";
            this.Load += new System.EventHandler(this.XeploaiDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMaXL;
        private System.Windows.Forms.TextBox textTenXL;
        private System.Windows.Forms.TextBox textMaDV;
        private System.Windows.Forms.TextBox textChidoan;
    }
}