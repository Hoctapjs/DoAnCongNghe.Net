﻿namespace GUI_QL_TRASUA
{
    partial class SanPham
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_topping = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.cbo_kichthuoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Black;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_username.Location = new System.Drawing.Point(12, 19);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(63, 25);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "label1";
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_masp.Location = new System.Drawing.Point(970, 77);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.PlaceholderText = "Mã sản phẩm";
            this.txt_masp.Size = new System.Drawing.Size(183, 32);
            this.txt_masp.TabIndex = 1;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tensp.Location = new System.Drawing.Point(970, 125);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.PlaceholderText = "Tên sản phẩm";
            this.txt_tensp.Size = new System.Drawing.Size(183, 32);
            this.txt_tensp.TabIndex = 2;
            // 
            // txt_topping
            // 
            this.txt_topping.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_topping.Location = new System.Drawing.Point(970, 265);
            this.txt_topping.Name = "txt_topping";
            this.txt_topping.PlaceholderText = "Topping";
            this.txt_topping.Size = new System.Drawing.Size(183, 32);
            this.txt_topping.TabIndex = 5;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.Orange;
            this.btn_them.Location = new System.Drawing.Point(970, 312);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 38);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.Orange;
            this.btn_xoa.Location = new System.Drawing.Point(970, 365);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 38);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Orange;
            this.btn_sua.Location = new System.Drawing.Point(970, 418);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 38);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Black;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat.ForeColor = System.Drawing.Color.Orange;
            this.btn_thoat.Location = new System.Drawing.Point(970, 471);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(183, 38);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Location = new System.Drawing.Point(12, 77);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 51;
            this.dataGridView_SanPham.RowTemplate.Height = 29;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(938, 441);
            this.dataGridView_SanPham.TabIndex = 10;
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_gia.Location = new System.Drawing.Point(970, 173);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.PlaceholderText = "Giá";
            this.txt_gia.Size = new System.Drawing.Size(183, 32);
            this.txt_gia.TabIndex = 3;
            // 
            // cbo_kichthuoc
            // 
            this.cbo_kichthuoc.FormattingEnabled = true;
            this.cbo_kichthuoc.Items.AddRange(new object[] {
            "Lớn",
            "Vừa",
            "Nhỏ"});
            this.cbo_kichthuoc.Location = new System.Drawing.Point(970, 221);
            this.cbo_kichthuoc.Name = "cbo_kichthuoc";
            this.cbo_kichthuoc.Size = new System.Drawing.Size(183, 28);
            this.cbo_kichthuoc.TabIndex = 11;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QL_TRASUA.Properties.Resources.Layer_111;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.cbo_kichthuoc);
            this.Controls.Add(this.dataGridView_SanPham);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_topping);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.lbl_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_username;
        private TextBox txt_masp;
        private TextBox txt_tensp;
        private TextBox txt_topping;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_thoat;
        private DataGridView dataGridView_SanPham;
        private TextBox txt_gia;
        private ComboBox cbo_kichthuoc;
    }
}