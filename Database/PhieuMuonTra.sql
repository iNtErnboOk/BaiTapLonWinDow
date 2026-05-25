USE QuanLyThuVien;
GO

-- =======================================================
-- 1. THÊM DỮ LIỆU CHO BẢNG PHIẾU MƯỢN
-- Định dạng Ngày: YYYY-MM-DD
-- =======================================================
INSERT INTO PhieuMuon (MaPhieuMuon, MaDG, NgayMuon, NgayTra)
VALUES 
    ('PM001', 'DG001', '2023-10-01', '2023-10-15'),
    ('PM002', 'DG002', '2023-10-05', '2023-10-20'),
    ('PM003', 'DG005', '2023-11-01', '2023-11-10'),
    ('PM004', 'DG008', '2023-11-15', '2023-11-30'),
    ('PM005', 'DG010', '2023-12-01', '2023-12-15');
GO

-- =======================================================
-- 2. THÊM DỮ LIỆU CHO BẢNG CHI TIẾT PHIẾU MƯỢN
-- Lưu ý: MaPhieuMuon và MaSach phải tồn tại ở bảng cha
-- =======================================================
INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, SoLuong)
VALUES 
    -- Phiếu mượn PM001 (Độc giả Nguyễn Văn Minh mượn 2 sách)
    ('PM001', 'S001', 1), -- Mượn 1 cuốn Lập Trình C# Cơ Bản
    ('PM001', 'S002', 2), -- Mượn 2 cuốn Cấu Trúc Dữ Liệu

    -- Phiếu mượn PM002 (Độc giả Trần Thị Bình mượn 1 sách)
    ('PM002', 'S005', 1), -- Mượn 1 cuốn Lập trình ReactJS thực chiến
    
    -- Phiếu mượn PM003 (Độc giả Vũ Trọng Hùng mượn 3 sách văn học/tâm lý)
    ('PM003', 'S009', 1), -- Mượn 1 cuốn Nhà giả kim
    ('PM003', 'S010', 1), -- Mượn 1 cuốn Đắc nhân tâm
    ('PM003', 'S011', 1), -- Mượn 1 cuốn Lược sử loài người

    -- Phiếu mượn PM004 (Độc giả Bùi Tuấn Anh mượn 2 sách)
    ('PM004', 'S006', 2), -- Mượn 2 cuốn Python Cơ bản và Ứng dụng
    ('PM004', 'S008', 1), -- Mượn 1 cuốn Xác suất thống kê

    -- Phiếu mượn PM005 (Độc giả Hồ Chí Kiên mượn 1 sách)
    ('PM005', 'S003', 1); -- Mượn 1 cuốn Giáo trình Toán rời rạc
GO