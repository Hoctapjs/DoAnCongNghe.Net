CREATE DATABASE QL_TRASUA

USE QL_TRASUA

CREATE TABLE SANPHAM (
    MASP INT PRIMARY KEY IDENTITY(1,1),  -- Mã sản phẩm tự động tăng
    TENSP NVARCHAR(100) NOT NULL,         -- Tên sản phẩm
    GIA DECIMAL(18, 2) NOT NULL,          -- Giá sản phẩm
    KICHTHUOC NVARCHAR(50),               -- Kích thước (nhỏ, vừa, lớn)
    TOPPING NVARCHAR(200)                 -- Các topping đi kèm
);

CREATE TABLE KHACHHANG (
    MAKH INT PRIMARY KEY IDENTITY(1,1),  -- Mã khách hàng tự động tăng
    TENKH NVARCHAR(100) NOT NULL,        -- Tên khách hàng
    SODT NVARCHAR(20) NOT NULL,          -- Số điện thoại
    DIACHI NVARCHAR(200)                 -- Địa chỉ
);

CREATE TABLE DONHANG (
    MADH INT PRIMARY KEY IDENTITY(1,1),     -- Mã hóa đơn (đơn hàng)
    MAKH INT NOT NULL,                      -- Mã khách hàng
    NGAYLAP DATETIME NOT NULL,              -- Ngày lập hóa đơn
    TONGGIA DECIMAL(18, 2) NOT NULL,        -- Tổng giá trị đơn hàng
    FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)  -- Khóa ngoại liên kết với bảng KHÁCHHÀNG
);

CREATE TABLE CHITIETDONHANG (
    MADH INT NOT NULL,                     -- Mã hóa đơn (đơn hàng)
    MASP INT NOT NULL,                     -- Mã sản phẩm
    SOLUONG INT NOT NULL,                  -- Số lượng sản phẩm
    GIA DECIMAL(18, 2) NOT NULL,           -- Giá của sản phẩm trong đơn hàng
    FOREIGN KEY (MADH) REFERENCES DONHANG(MADH),   -- Khóa ngoại liên kết với bảng ĐƠNHÀNG
    FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP)    -- Khóa ngoại liên kết với bảng SẢNPHẨM
);

CREATE TABLE NHANVIEN (
    MANV INT PRIMARY KEY IDENTITY(1,1),    -- Mã nhân viên tự động tăng, làm khóa chính
    TENNV NVARCHAR(100) NOT NULL,          -- Tên nhân viên
    QUYEN NVARCHAR(50) NOT NULL,           -- Quyền quản lý (Admin, Nhân viên)
    USERNAME NVARCHAR(50) NOT NULL,        -- Tên tài khoản
    PASSWORD NVARCHAR(50) NOT NULL         -- Mật khẩu (nên mã hóa)
);

INSERT INTO SANPHAM (TENSP, GIA, KICHTHUOC, TOPPING) VALUES 
(N'Trà sữa trân châu đường đen', 45000, N'Lớn', N'Trân châu, Thạch'),
(N'Trà xanh machiato', 40000, N'Vừa', N'Thạch, Phô mai'),
(N'Hồng trà sữa', 35000, N'Nhỏ', N'Trân châu'),
(N'Trà sữa matcha', 50000, N'Lớn', N'Trân châu, Thạch phô mai'),
(N'Trà đào cam sả', 42000, N'Vừa', N'Cam, Sả, Đào');

INSERT INTO SANPHAM (TENSP, GIA, KICHTHUOC, TOPPING) VALUES 
(N'Trà sữa socola', 48000, N'Lớn', N'Thạch socola, Trân châu đen'),
(N'Trà sữa bạc hà', 47000, N'Lớn', N'Thạch bạc hà, Trân châu trắng'),
(N'Trà sữa khoai môn', 45000, N'Vừa', N'Thạch khoai môn, Trân châu'),
(N'Trà sữa ô long', 40000, N'Nhỏ', N'Trân châu, Thạch'),
(N'Trà sữa Thái xanh', 42000, N'Lớn', N'Thạch phô mai, Trân châu'),
(N'Trà sữa Thái đỏ', 41000, N'Vừa', N'Thạch dừa, Trân châu trắng'),
(N'Trà chanh sả', 35000, N'Nhỏ', N'Chanh, Sả, Trân châu trắng'),
(N'Sữa tươi trân châu đường đen', 55000, N'Lớn', N'Trân châu đường đen'),
(N'Trà vải hương nhài', 39000, N'Vừa', N'Thạch vải, Hương nhài'),
(N'Trà sữa caramel', 46000, N'Lớn', N'Caramel, Thạch caramel, Trân châu');



INSERT INTO KHACHHANG (TENKH, SODT, DIACHI) VALUES 
(N'Nguyễn Văn A', '0987654321', N'Hà Nội'),
(N'Trần Thị B', '0912345678', N'Hồ Chí Minh'),
(N'Phạm Văn C', '0978123456', N'Đà Nẵng'),
(N'Lê Thị D', '0967234561', N'Nha Trang'),
(N'Hoàng Văn E', '0934567890', N'Cần Thơ');

INSERT INTO DONHANG (MAKH, NGAYLAP, TONGGIA) VALUES 
(1, '2024-10-12', 135000),
(2, '2024-10-11', 80000),
(3, '2024-10-10', 105000),
(4, '2024-10-09', 85000),
(5, '2024-10-08', 120000);

INSERT INTO DONHANG (MAKH, NGAYLAP, TONGGIA) VALUES 
(1, '2023-9-12', 135000)

INSERT INTO CHITIETDONHANG (MADH, MASP, SOLUONG, GIA) VALUES 
(1, 1, 2, 45000),
(1, 2, 1, 40000),
(2, 3, 2, 35000),
(3, 4, 1, 50000),
(3, 5, 1, 42000),
(4, 1, 1, 45000),
(4, 3, 1, 35000),
(5, 2, 2, 40000),
(5, 5, 1, 42000);

INSERT INTO CHITIETDONHANG (MADH, MASP, SOLUONG, GIA) VALUES 
(7, 1, 2, 45000),
(7, 2, 1, 40000)

INSERT INTO NHANVIEN (TENNV, QUYEN, USERNAME, PASSWORD) VALUES 
(N'Nguyễn Quản Lý', 'Admin', 'quanly01', 'nhanvien1'),
(N'Trần Bán Hàng', 'Nhân viên', 'nhanvien01', 'nhanvien2'),
(N'Phạm Hỗ Trợ', 'Nhân viên', 'nhanvien02', 'nhanvien3'),
(N'Lê Kế Toán', 'Nhân viên', 'nhanvien03', 'nhanvien4'),
(N'Hoàng Chủ Quán', 'Admin', 'admin01', 'nhanvien5');


-- SELECT
    SELECT * FROM NHANVIEN
    SELECT * FROM KHACHHANG
    SELECT * FROM SANPHAM
    SELECT * FROM DONHANG
    SELECT * FROM CHITIETDONHANG
-- DROP TABLE
    /*     DROP TABLE NHANVIEN
        DROP TABLE KHACHHANG
        DROP TABLE SANPHAM
        DROP TABLE DONHANG
        DROP TABLE CHITIETDONHANG */
-- 
    SELECT COUNT(*) FROM KHACHHANG
--
    SELECT DAY(NGAYLAP) FROM DONHANG
    GROUP BY DAY(NGAYLAP)

    SELECT NGAYLAP FROM DONHANG

    SELECT YEAR(NGAYLAP) FROM DONHANG GROUP BY YEAR(NGAYLAP)



    SELECT * FROM DONHANG WHERE DAY(NGAYLAP) = 12

    SELECT FORMAT(NGAYLAP, 'dd/MM/yyyy') AS NgayThangNam FROM DONHANG;

    SELECT FORMAT(NGAYLAP, 'MM/yyyy') AS ThangNam FROM DONHANG;


    SELECT SUM(TONGGIA) FROM DONHANG

    SELECT SUM(TONGGIA) FROM DONHANG WHERE YEAR(NGAYLAP) = 2024
    SELECT SUM(TONGGIA) FROM DONHANG WHERE MONTH(NGAYLAP) = 10 AND YEAR(NGAYLAP) = YEAR(GETDATE())
    