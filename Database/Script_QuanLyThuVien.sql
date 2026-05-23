-- =======================================================
-- SCRIPT KHỞI TẠO CƠ SỞ DỮ LIỆU QUẢN LÝ THƯ VIỆN
-- =======================================================

-- 1. Tạo cơ sở dữ liệu (Nếu chạy báo lỗi đã có DB thì có thể bôi đen chạy từ dòng USE trở xuống)
CREATE DATABASE QuanLyThuVien;
GO

-- 2. Chỉ định thao tác trên Database vừa tạo
USE QuanLyThuVien;
GO

-- XÓA BẢNG CŨ NẾU ĐÃ TỒN TẠI (Để tránh lỗi There is already an object...)
IF OBJECT_ID('Sach', 'U') IS NOT NULL 
BEGIN
    DROP TABLE Sach;
END
GO

-- 3. Tạo bảng Sách mới
CREATE TABLE Sach (
    MaSach NVARCHAR(50) PRIMARY KEY,       
    TenSach NVARCHAR(255) NOT NULL,        
    TacGia NVARCHAR(150),
    NamXB INT,                             
    TheLoai NVARCHAR(100),
    SoLuong INT,                           
    TrangThai NVARCHAR(50),                
    HinhAnh NVARCHAR(MAX)                  
);
GO

-- 4. Thêm dữ liệu mẫu 
INSERT INTO Sach (MaSach, TenSach, TacGia, NamXB, TheLoai, SoLuong, TrangThai, HinhAnh)
VALUES 
('S001', N'Lập Trình C# Cơ Bản', N'Nguyễn Văn A', 2023, N'Giáo trình', 15, N'Còn sách', 'S001.png'),
('S002', N'Cấu Trúc Dữ Liệu', N'Trần Thị B', 2021, N'Tài liệu tham khảo', 5, N'Còn sách', 'S002.png'),
('S003', N'Giáo trình Toán rời rạc', N'Kenneth H. Rosen', 2020, N'Toán học - Thống kê', 12, N'Còn sách', 'S003.png'),
('S004', N'Giáo trình Kinh tế chính trị Mác - Lênin', N'Bộ Giáo dục và Đào tạo', 2021, N'Triết học - Kinh tế chính trị', 20, N'Còn sách', 'S004.png'),
('S005', N'Lập trình ReactJS thực chiến', N'Nguyễn Hải', 2023, N'Công nghệ thông tin - Lập trình', 8, N'Còn sách', 'S005.png'),
('S006', N'Python Cơ bản và Ứng dụng', N'Mark Lutz', 2022, N'Công nghệ thông tin - Lập trình', 15, N'Còn sách', 'S006.png'),
('S007', N'Tư duy Thuật toán với C++', N'Lê Minh', 2021, N'Công nghệ thông tin - Lập trình', 10, N'Còn sách', 'S007.png'),
('S008', N'Xác suất thống kê', N'Đào Trọng Thi', 2019, N'Toán học - Thống kê', 5, N'Còn sách', 'S008.png'),
('S009', N'Nhà giả kim', N'Paulo Coelho', 2020, N'Văn học - Tiểu thuyết', 30, N'Còn sách', 'S009.png'),
('S010', N'Đắc nhân tâm', N'Dale Carnegie', 2022, N'Tâm lý - Kỹ năng sống', 25, N'Còn sách', 'S010.png'),
('S011', N'Lược sử loài người', N'Yuval Noah Harari', 2021, N'Lịch sử - Địa lý', 18, N'Còn sách', 'S011.png'),
('S012', N'Clean Code - Mã sạch', N'Robert C. Martin', 2018, N'Công nghệ thông tin - Lập trình', 0, N'Hết sách', 'S012.png');
GO