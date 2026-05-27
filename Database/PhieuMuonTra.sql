USE QuanLyThuVien;
GO

-- =======================================================
-- 0. TẠO BẢNG (Xóa bảng cũ nếu có để tránh lỗi)
-- =======================================================
IF OBJECT_ID('ChiTietPhieuMuon', 'U') IS NOT NULL DROP TABLE ChiTietPhieuMuon;
IF OBJECT_ID('PhieuMuon', 'U') IS NOT NULL DROP TABLE PhieuMuon;
GO

-- Tạo bảng Phiếu Mượn (Đã bổ sung đầy đủ các cột theo UI phần mềm)
CREATE TABLE PhieuMuon (
    MaPhieuMuon NVARCHAR(50) PRIMARY KEY,
    MaDG VARCHAR(20),
    NgayMuon DATE,
    NgayTra DATE,
    TrangThaiTra NVARCHAR(50), 
    NgayTraThucTe DATE,        -- Thêm cột Ngày trả thực tế
    TienPhat INT,              -- Thêm cột Tiền phạt (kiểu số nguyên)
    FOREIGN KEY (MaDG) REFERENCES DocGia(MaDG)
);
GO

-- Tạo bảng Chi Tiết Phiếu Mượn 
CREATE TABLE ChiTietPhieuMuon (
    MaPhieuMuon NVARCHAR(50),
    MaSach NVARCHAR(50),
    SoLuong INT,
    PRIMARY KEY (MaPhieuMuon, MaSach),
    FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuon(MaPhieuMuon),
    FOREIGN KEY (MaSach) REFERENCES Sach(MaSach)
);
GO

-- =======================================================
-- 1. THÊM DỮ LIỆU CHO BẢNG PHIẾU MƯỢN
-- =======================================================
INSERT INTO PhieuMuon (MaPhieuMuon, MaDG, NgayMuon, NgayTra, TrangThaiTra, NgayTraThucTe, TienPhat)
VALUES 
    -- Các phiếu đã trả (Có ngày trả thực tế và tiền phạt nếu có)
    ('PM001', 'DG001', '2023-10-01', '2023-10-15', N'Đã trả', '2023-10-15', 0),
    ('PM002', 'DG002', '2023-10-05', '2023-10-20', N'Đã trả', '2023-10-22', 10000), -- Trả trễ, phạt 10k
    
    -- Các phiếu chưa trả (Ngày trả thực tế và tiền phạt để NULL hoặc 0)
    ('PM003', 'DG005', '2023-11-01', '2023-11-10', N'Chưa trả', NULL, 0),
    ('PM004', 'DG008', '2023-11-15', '2023-11-30', N'Chưa trả', NULL, 0),
    ('PM005', 'DG010', '2023-12-01', '2023-12-15', N'Chưa trả', NULL, 0);
GO

-- =======================================================
-- 2. THÊM DỮ LIỆU CHO BẢNG CHI TIẾT PHIẾU MƯỢN
-- =======================================================
INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, SoLuong)
VALUES 
    ('PM001', 'S001', 1), 
    ('PM001', 'S002', 2), 
    ('PM002', 'S005', 1), 
    ('PM003', 'S009', 1), 
    ('PM003', 'S010', 1), 
    ('PM003', 'S011', 1), 
    ('PM004', 'S006', 2), 
    ('PM004', 'S008', 1), 
    ('PM005', 'S003', 1); 
GO