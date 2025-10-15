namespace test
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnOrderNuoc = new System.Windows.Forms.Button();
            this.btnLichDatSan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDatSan
            // 
            this.btnDatSan.BackgroundImage = global::test.Properties.Resources.pngtree_football_field_icon_trendy_style_isolated_background_png_image_1543639_removebg_preview;
            this.btnDatSan.Location = new System.Drawing.Point(29, 526);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Size = new System.Drawing.Size(75, 23);
            this.btnDatSan.TabIndex = 0;
            this.btnDatSan.Text = "Đặt Sân";
            this.btnDatSan.UseVisualStyleBackColor = true;
            this.btnDatSan.Click += new System.EventHandler(this.btnDatSan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tài Khoảng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrderNuoc
            // 
            this.btnOrderNuoc.Location = new System.Drawing.Point(134, 526);
            this.btnOrderNuoc.Name = "btnOrderNuoc";
            this.btnOrderNuoc.Size = new System.Drawing.Size(97, 23);
            this.btnOrderNuoc.TabIndex = 2;
            this.btnOrderNuoc.Text = "Order Nước";
            this.btnOrderNuoc.UseVisualStyleBackColor = true;
            this.btnOrderNuoc.Click += new System.EventHandler(this.btnOrderNuoc_Click);
            // 
            // btnLichDatSan
            // 
            this.btnLichDatSan.Location = new System.Drawing.Point(264, 526);
            this.btnLichDatSan.Name = "btnLichDatSan";
            this.btnLichDatSan.Size = new System.Drawing.Size(97, 23);
            this.btnLichDatSan.TabIndex = 2;
            this.btnLichDatSan.Text = "Lịch đặt sân";
            this.btnLichDatSan.UseVisualStyleBackColor = true;
            this.btnLichDatSan.Click += new System.EventHandler(this.btnLichDatSan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(508, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLichDatSan);
            this.Controls.Add(this.btnOrderNuoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDatSan);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDatSan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOrderNuoc;
        private System.Windows.Forms.Button btnLichDatSan;
        private System.Windows.Forms.Label label1;
    }
}