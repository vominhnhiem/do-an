namespace DuAnSanBong
{
    partial class frmHome
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
            this.btnDatSan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatNuoc = new System.Windows.Forms.Button();
            this.btnTaiKhoang = new System.Windows.Forms.Button();
            this.btnGiaiDau = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnLichSan = new System.Windows.Forms.Button();
            this.pnlHienThi = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDatSan
            // 
            this.btnDatSan.Location = new System.Drawing.Point(82, 92);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Size = new System.Drawing.Size(75, 23);
            this.btnDatSan.TabIndex = 1;
            this.btnDatSan.Text = "Đặt sân";
            this.btnDatSan.UseVisualStyleBackColor = true;
            this.btnDatSan.Click += new System.EventHandler(this.btnDatSan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDatNuoc);
            this.panel1.Controls.Add(this.btnTaiKhoang);
            this.panel1.Controls.Add(this.btnGiaiDau);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnLichSan);
            this.panel1.Controls.Add(this.btnDatSan);
            this.panel1.Location = new System.Drawing.Point(-28, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 149);
            this.panel1.TabIndex = 2;
            // 
            // btnDatNuoc
            // 
            this.btnDatNuoc.Location = new System.Drawing.Point(198, 92);
            this.btnDatNuoc.Name = "btnDatNuoc";
            this.btnDatNuoc.Size = new System.Drawing.Size(75, 23);
            this.btnDatNuoc.TabIndex = 1;
            this.btnDatNuoc.Text = "Đặt Nước";
            this.btnDatNuoc.UseVisualStyleBackColor = true;
            this.btnDatNuoc.Click += new System.EventHandler(this.btnDatNuoc_Click);
            // 
            // btnTaiKhoang
            // 
            this.btnTaiKhoang.Location = new System.Drawing.Point(846, 92);
            this.btnTaiKhoang.Name = "btnTaiKhoang";
            this.btnTaiKhoang.Size = new System.Drawing.Size(152, 23);
            this.btnTaiKhoang.TabIndex = 1;
            this.btnTaiKhoang.Text = "Tài Khoảng AD";
            this.btnTaiKhoang.UseVisualStyleBackColor = true;
            // 
            // btnGiaiDau
            // 
            this.btnGiaiDau.Location = new System.Drawing.Point(503, 92);
            this.btnGiaiDau.Name = "btnGiaiDau";
            this.btnGiaiDau.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiDau.TabIndex = 1;
            this.btnGiaiDau.Text = "Giải Đấu";
            this.btnGiaiDau.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(680, 92);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnLichSan
            // 
            this.btnLichSan.Location = new System.Drawing.Point(341, 92);
            this.btnLichSan.Name = "btnLichSan";
            this.btnLichSan.Size = new System.Drawing.Size(75, 23);
            this.btnLichSan.TabIndex = 1;
            this.btnLichSan.Text = "Lịch Sân";
            this.btnLichSan.UseVisualStyleBackColor = true;
            this.btnLichSan.Click += new System.EventHandler(this.btnLichSan_Click);
            // 
            // pnlHienThi
            // 
            this.pnlHienThi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHienThi.Location = new System.Drawing.Point(-1, 90);
            this.pnlHienThi.Name = "pnlHienThi";
            this.pnlHienThi.Size = new System.Drawing.Size(1016, 497);
            this.pnlHienThi.TabIndex = 3;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 582);
            this.Controls.Add(this.pnlHienThi);
            this.Controls.Add(this.panel1);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatSan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDatNuoc;
        private System.Windows.Forms.Button btnTaiKhoang;
        private System.Windows.Forms.Button btnGiaiDau;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnLichSan;
        private System.Windows.Forms.Panel pnlHienThi;
    }
}

