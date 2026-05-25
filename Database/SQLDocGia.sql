USE quanlydocgia;
GO

-- 1. Xóa bảng cũ nếu nó đã tồn tại
IF OBJECT_ID('DocGia', 'U') IS NOT NULL 
    DROP TABLE DocGia;
GO

-- 2. Tạo lại bảng mới
CREATE TABLE DocGia (
    MaDG VARCHAR(20) PRIMARY KEY,
    TenDocGia NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15),
    Email VARCHAR(100),
    DiaChi NVARCHAR(255),
    NamSinh INT,
    GioiTinh NVARCHAR(10)
);
GO

-- 3. Thêm dữ liệu ngay sau khi tạo
INSERT INTO DocGia (MaDG, TenDocGia, SDT, Email, DiaChi, NamSinh, GioiTinh)
VALUES 
    ('DG001', N'Nguyễn Văn A', '0987654321', 'nva@gmail.com', N'Hà Nội', 1995, N'Nam'),
    ('DG002', N'Trần Thị B', '0912345678', 'ttb@gmail.com', N'Hồ Chí Minh', 1998, N'Nữ'),
    ('DG003', N'Lê Hoàng C', '0909112233', 'lhc@yahoo.com', N'Đà Nẵng', 2000, N'Nam');
GO