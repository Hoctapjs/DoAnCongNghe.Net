namespace GUI_QL_TRASUA
{
    partial class NhanVien
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
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_quyen = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
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
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_manv.Location = new System.Drawing.Point(970, 77);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.PlaceholderText = "Mã nhân viên";
            this.txt_manv.Size = new System.Drawing.Size(183, 32);
            this.txt_manv.TabIndex = 1;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tennv.Location = new System.Drawing.Point(970, 124);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.PlaceholderText = "Tên nhân viên";
            this.txt_tennv.Size = new System.Drawing.Size(183, 32);
            this.txt_tennv.TabIndex = 2;
            // 
            // txt_quyen
            // 
            this.txt_quyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_quyen.Location = new System.Drawing.Point(970, 171);
            this.txt_quyen.Name = "txt_quyen";
            this.txt_quyen.PlaceholderText = "Quyền";
            this.txt_quyen.Size = new System.Drawing.Size(183, 32);
            this.txt_quyen.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_username.Location = new System.Drawing.Point(970, 218);
            this.txt_username.Name = "txt_username";
            this.txt_username.PlaceholderText = "Username";
            this.txt_username.Size = new System.Drawing.Size(183, 32);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_password.Location = new System.Drawing.Point(970, 265);
            this.txt_password.Name = "txt_password";
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.Size = new System.Drawing.Size(183, 32);
            this.txt_password.TabIndex = 5;
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
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(12, 77);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.RowHeadersWidth = 51;
            this.dataGridView_NhanVien.RowTemplate.Height = 29;
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(938, 441);
            this.dataGridView_NhanVien.TabIndex = 10;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QL_TRASUA.Properties.Resources.Layer_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.dataGridView_NhanVien);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_quyen);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.lbl_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_NhanVien;
        private Button btn_thoat;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private TextBox txt_password;
        private TextBox txt_username;
        private TextBox txt_quyen;
        private TextBox txt_tennv;
        private TextBox txt_manv;
        private Label lbl_username;
    }
}