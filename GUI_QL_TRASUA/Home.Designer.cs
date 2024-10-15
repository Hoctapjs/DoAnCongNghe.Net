namespace GUI_QL_TRASUA
{
    partial class Home
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
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_donhang = new System.Windows.Forms.Button();
            this.btn_chitietdh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_khach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_soluongkh = new System.Windows.Forms.Label();
            this.lbl_tongdt_nam = new System.Windows.Forms.Label();
            this.lbl_soluongsp = new System.Windows.Forms.Label();
            this.lbl_soluongdh = new System.Windows.Forms.Label();
            this.lbl_tongdt_ngay = new System.Windows.Forms.Label();
            this.lbl_tongdt_thang = new System.Windows.Forms.Label();
            this.cbo_ngay = new System.Windows.Forms.ComboBox();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.cbo_nam = new System.Windows.Forms.ComboBox();
            this.btn_tongdoanthu = new System.Windows.Forms.Button();
            this.dataGridView_NV_QUYEN = new System.Windows.Forms.DataGridView();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_quyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV_QUYEN)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.BackColor = System.Drawing.Color.Black;
            this.btn_sanpham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanpham.ForeColor = System.Drawing.Color.Orange;
            this.btn_sanpham.Location = new System.Drawing.Point(971, 375);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(183, 71);
            this.btn_sanpham.TabIndex = 6;
            this.btn_sanpham.Text = "Sản Phẩm";
            this.btn_sanpham.UseVisualStyleBackColor = false;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_donhang
            // 
            this.btn_donhang.BackColor = System.Drawing.Color.Black;
            this.btn_donhang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_donhang.ForeColor = System.Drawing.Color.Orange;
            this.btn_donhang.Location = new System.Drawing.Point(971, 108);
            this.btn_donhang.Name = "btn_donhang";
            this.btn_donhang.Size = new System.Drawing.Size(183, 71);
            this.btn_donhang.TabIndex = 7;
            this.btn_donhang.Text = "Đơn Hàng";
            this.btn_donhang.UseVisualStyleBackColor = false;
            this.btn_donhang.Click += new System.EventHandler(this.btn_donhang_Click);
            // 
            // btn_chitietdh
            // 
            this.btn_chitietdh.BackColor = System.Drawing.Color.Black;
            this.btn_chitietdh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_chitietdh.ForeColor = System.Drawing.Color.Orange;
            this.btn_chitietdh.Location = new System.Drawing.Point(971, 197);
            this.btn_chitietdh.Name = "btn_chitietdh";
            this.btn_chitietdh.Size = new System.Drawing.Size(183, 71);
            this.btn_chitietdh.TabIndex = 8;
            this.btn_chitietdh.Text = "Chi Tiết DH";
            this.btn_chitietdh.UseVisualStyleBackColor = false;
            this.btn_chitietdh.Click += new System.EventHandler(this.btn_chitietdh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Black;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.ForeColor = System.Drawing.Color.Orange;
            this.btn_thoat.Location = new System.Drawing.Point(971, 480);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(183, 38);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.Color.Black;
            this.btn_nhanvien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_nhanvien.ForeColor = System.Drawing.Color.Orange;
            this.btn_nhanvien.Location = new System.Drawing.Point(971, 286);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Size = new System.Drawing.Size(183, 71);
            this.btn_nhanvien.TabIndex = 11;
            this.btn_nhanvien.Text = "Nhân Viên";
            this.btn_nhanvien.UseVisualStyleBackColor = false;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_khach
            // 
            this.btn_khach.BackColor = System.Drawing.Color.Black;
            this.btn_khach.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_khach.ForeColor = System.Drawing.Color.Orange;
            this.btn_khach.Location = new System.Drawing.Point(971, 19);
            this.btn_khach.Name = "btn_khach";
            this.btn_khach.Size = new System.Drawing.Size(183, 71);
            this.btn_khach.TabIndex = 12;
            this.btn_khach.Text = "Khách Hàng";
            this.btn_khach.UseVisualStyleBackColor = false;
            this.btn_khach.Click += new System.EventHandler(this.btn_khach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số lượng khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(65)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số lượng sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(65)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng đơn hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(65)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 35);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tổng doanh thu theo ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(65)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 35);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tổng doanh thu theo tháng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(65)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 35);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tổng doanh thu theo năm:";
            // 
            // lbl_soluongkh
            // 
            this.lbl_soluongkh.AutoSize = true;
            this.lbl_soluongkh.BackColor = System.Drawing.Color.Black;
            this.lbl_soluongkh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soluongkh.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_soluongkh.Location = new System.Drawing.Point(273, 90);
            this.lbl_soluongkh.Name = "lbl_soluongkh";
            this.lbl_soluongkh.Size = new System.Drawing.Size(28, 35);
            this.lbl_soluongkh.TabIndex = 19;
            this.lbl_soluongkh.Text = "0";
            // 
            // lbl_tongdt_nam
            // 
            this.lbl_tongdt_nam.AutoSize = true;
            this.lbl_tongdt_nam.BackColor = System.Drawing.Color.Black;
            this.lbl_tongdt_nam.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tongdt_nam.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_tongdt_nam.Location = new System.Drawing.Point(564, 416);
            this.lbl_tongdt_nam.Name = "lbl_tongdt_nam";
            this.lbl_tongdt_nam.Size = new System.Drawing.Size(28, 35);
            this.lbl_tongdt_nam.TabIndex = 20;
            this.lbl_tongdt_nam.Text = "0";
            // 
            // lbl_soluongsp
            // 
            this.lbl_soluongsp.AutoSize = true;
            this.lbl_soluongsp.BackColor = System.Drawing.Color.Black;
            this.lbl_soluongsp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soluongsp.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_soluongsp.Location = new System.Drawing.Point(273, 155);
            this.lbl_soluongsp.Name = "lbl_soluongsp";
            this.lbl_soluongsp.Size = new System.Drawing.Size(28, 35);
            this.lbl_soluongsp.TabIndex = 21;
            this.lbl_soluongsp.Text = "0";
            // 
            // lbl_soluongdh
            // 
            this.lbl_soluongdh.AutoSize = true;
            this.lbl_soluongdh.BackColor = System.Drawing.Color.Black;
            this.lbl_soluongdh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soluongdh.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_soluongdh.Location = new System.Drawing.Point(273, 220);
            this.lbl_soluongdh.Name = "lbl_soluongdh";
            this.lbl_soluongdh.Size = new System.Drawing.Size(28, 35);
            this.lbl_soluongdh.TabIndex = 22;
            this.lbl_soluongdh.Text = "0";
            // 
            // lbl_tongdt_ngay
            // 
            this.lbl_tongdt_ngay.AutoSize = true;
            this.lbl_tongdt_ngay.BackColor = System.Drawing.Color.Black;
            this.lbl_tongdt_ngay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tongdt_ngay.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_tongdt_ngay.Location = new System.Drawing.Point(564, 288);
            this.lbl_tongdt_ngay.Name = "lbl_tongdt_ngay";
            this.lbl_tongdt_ngay.Size = new System.Drawing.Size(28, 35);
            this.lbl_tongdt_ngay.TabIndex = 23;
            this.lbl_tongdt_ngay.Text = "0";
            // 
            // lbl_tongdt_thang
            // 
            this.lbl_tongdt_thang.AutoSize = true;
            this.lbl_tongdt_thang.BackColor = System.Drawing.Color.Black;
            this.lbl_tongdt_thang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_tongdt_thang.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_tongdt_thang.Location = new System.Drawing.Point(564, 352);
            this.lbl_tongdt_thang.Name = "lbl_tongdt_thang";
            this.lbl_tongdt_thang.Size = new System.Drawing.Size(28, 35);
            this.lbl_tongdt_thang.TabIndex = 24;
            this.lbl_tongdt_thang.Text = "0";
            // 
            // cbo_ngay
            // 
            this.cbo_ngay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_ngay.FormattingEnabled = true;
            this.cbo_ngay.Location = new System.Drawing.Point(358, 290);
            this.cbo_ngay.Name = "cbo_ngay";
            this.cbo_ngay.Size = new System.Drawing.Size(175, 33);
            this.cbo_ngay.TabIndex = 25;
            // 
            // cbo_thang
            // 
            this.cbo_thang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Location = new System.Drawing.Point(358, 354);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(175, 33);
            this.cbo_thang.TabIndex = 26;
            // 
            // cbo_nam
            // 
            this.cbo_nam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.Location = new System.Drawing.Point(358, 418);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(175, 33);
            this.cbo_nam.TabIndex = 27;
            // 
            // btn_tongdoanthu
            // 
            this.btn_tongdoanthu.BackColor = System.Drawing.Color.Black;
            this.btn_tongdoanthu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tongdoanthu.ForeColor = System.Drawing.Color.Orange;
            this.btn_tongdoanthu.Location = new System.Drawing.Point(358, 90);
            this.btn_tongdoanthu.Name = "btn_tongdoanthu";
            this.btn_tongdoanthu.Size = new System.Drawing.Size(179, 165);
            this.btn_tongdoanthu.TabIndex = 28;
            this.btn_tongdoanthu.Text = "Tính tổng doanh thu";
            this.btn_tongdoanthu.UseVisualStyleBackColor = false;
            this.btn_tongdoanthu.Click += new System.EventHandler(this.btn_tongdoanthu_Click);
            // 
            // dataGridView_NV_QUYEN
            // 
            this.dataGridView_NV_QUYEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NV_QUYEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NV_QUYEN.Location = new System.Drawing.Point(564, 19);
            this.dataGridView_NV_QUYEN.Name = "dataGridView_NV_QUYEN";
            this.dataGridView_NV_QUYEN.RowHeadersWidth = 51;
            this.dataGridView_NV_QUYEN.RowTemplate.Height = 29;
            this.dataGridView_NV_QUYEN.Size = new System.Drawing.Size(382, 236);
            this.dataGridView_NV_QUYEN.TabIndex = 29;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Black;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_username.Location = new System.Drawing.Point(12, 34);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(127, 35);
            this.lbl_username.TabIndex = 30;
            this.lbl_username.Text = "Username";
            // 
            // lbl_quyen
            // 
            this.lbl_quyen.AutoSize = true;
            this.lbl_quyen.BackColor = System.Drawing.Color.Black;
            this.lbl_quyen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_quyen.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_quyen.Location = new System.Drawing.Point(358, 34);
            this.lbl_quyen.Name = "lbl_quyen";
            this.lbl_quyen.Size = new System.Drawing.Size(87, 35);
            this.lbl_quyen.TabIndex = 31;
            this.lbl_quyen.Text = "Quyền";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QL_TRASUA.Properties.Resources.Layer_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.lbl_quyen);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.dataGridView_NV_QUYEN);
            this.Controls.Add(this.btn_tongdoanthu);
            this.Controls.Add(this.cbo_nam);
            this.Controls.Add(this.cbo_thang);
            this.Controls.Add(this.cbo_ngay);
            this.Controls.Add(this.lbl_tongdt_thang);
            this.Controls.Add(this.lbl_tongdt_ngay);
            this.Controls.Add(this.lbl_soluongdh);
            this.Controls.Add(this.lbl_soluongsp);
            this.Controls.Add(this.lbl_tongdt_nam);
            this.Controls.Add(this.lbl_soluongkh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_khach);
            this.Controls.Add(this.btn_nhanvien);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_chitietdh);
            this.Controls.Add(this.btn_donhang);
            this.Controls.Add(this.btn_sanpham);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NV_QUYEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_thoat;
        private Button btn_chitietdh;
        private Button btn_donhang;
        private Button btn_sanpham;
        private Button btn_nhanvien;
        private Button btn_khach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_soluongkh;
        private Label lbl_tongdt_nam;
        private Label lbl_soluongsp;
        private Label lbl_soluongdh;
        private Label lbl_tongdt_ngay;
        private Label lbl_tongdt_thang;
        private ComboBox cbo_ngay;
        private ComboBox cbo_thang;
        private ComboBox cbo_nam;
        private Button btn_tongdoanthu;
        private DataGridView dataGridView_NV_QUYEN;
        private Label lbl_username;
        private Label lbl_quyen;
    }
}