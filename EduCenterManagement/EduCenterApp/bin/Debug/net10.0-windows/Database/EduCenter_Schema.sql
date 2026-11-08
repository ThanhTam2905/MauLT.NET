-- ====================================================================
-- HỆ THỐNG QUẢN LÝ TRUNG TÂM TIẾNG ANH / ĐÀO TẠO (EduCenter)
-- CSDL SQLite kết hợp Navicat for SQLite
-- Dự án: EduCenterManagement
-- ====================================================================

PRAGMA foreign_keys = ON;

-- 1. BẢNG KHÓA HỌC
CREATE TABLE IF NOT EXISTS KhoaHoc (
    MaKhoaHoc TEXT PRIMARY KEY,
    TenKhoaHoc TEXT NOT NULL,
    HocPhi REAL NOT NULL DEFAULT 0,
    SoBuoi INTEGER NOT NULL DEFAULT 0,
    MoTa TEXT
);

-- 2. BẢNG PHÒNG HỌC
CREATE TABLE IF NOT EXISTS PhongHoc (
    MaPhong TEXT PRIMARY KEY,
    TenPhong TEXT NOT NULL,
    SucChua INTEGER NOT NULL DEFAULT 20
);

-- 3. BẢNG GIÁO VIÊN
CREATE TABLE IF NOT EXISTS GiaoVien (
    MaGiaoVien TEXT PRIMARY KEY,
    HoTen TEXT NOT NULL,
    SoDienThoai TEXT,
    Email TEXT,
    ChuyenMon TEXT
);

-- 4. BẢNG HỌC VIÊN
CREATE TABLE IF NOT EXISTS HocVien (
    MaHocVien TEXT PRIMARY KEY,
    HoTen TEXT NOT NULL,
    NgaySinh TEXT,
    SoDienThoai TEXT,
    Email TEXT,
    DiaChi TEXT,
    NgayThamGia TEXT,
    IsHocVienCu INTEGER NOT NULL DEFAULT 0
);

-- 5. BẢNG LỚP HỌC (Có kiểm tra xếp lịch, tránh trùng phòng & trùng GV)
CREATE TABLE IF NOT EXISTS LopHoc (
    MaLop TEXT PRIMARY KEY,
    TenLop TEXT NOT NULL,
    MaKhoaHoc TEXT NOT NULL,
    MaGiaoVien TEXT NOT NULL,
    MaPhong TEXT NOT NULL,
    ThuHoc TEXT NOT NULL,
    CaHoc TEXT NOT NULL,
    GioBatDau TEXT NOT NULL,
    GioKetThuc TEXT NOT NULL,
    SiSoToiDa INTEGER NOT NULL DEFAULT 20,
    NgayKhaiGiang TEXT,
    TrangThai TEXT DEFAULT 'Đang mở',
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien),
    FOREIGN KEY (MaPhong) REFERENCES PhongHoc(MaPhong)
);

-- 6. BẢNG ĐĂNG KÝ & TÍNH HỌC PHÍ (Ưu đãi học viên cũ, ưu đãi nhóm, đợt đóng)
CREATE TABLE IF NOT EXISTS DangKy (
    MaDangKy TEXT PRIMARY KEY,
    MaHocVien TEXT NOT NULL,
    MaLop TEXT NOT NULL,
    NgayDangKy TEXT NOT NULL,
    HocPhiGoc REAL NOT NULL DEFAULT 0,
    LoaiUuDai TEXT,
    PhanTramGiam REAL DEFAULT 0,
    SoTienGiam REAL DEFAULT 0,
    TongTienPhaiDong REAL NOT NULL DEFAULT 0,
    DaDong REAL DEFAULT 0,
    ConNo REAL DEFAULT 0,
    TrangThai TEXT DEFAULT 'Chưa hoàn tất',
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop)
);

-- 7. BẢNG BIÊN LAI THU TIỀN
CREATE TABLE IF NOT EXISTS BienLaiThuTien (
    MaBienLai TEXT PRIMARY KEY,
    MaDangKy TEXT NOT NULL,
    MaHocVien TEXT NOT NULL,
    MaLop TEXT NOT NULL,
    SoTienThu REAL NOT NULL,
    DotThu INTEGER NOT NULL DEFAULT 1,
    HinhThucThanhToan TEXT DEFAULT 'Tiền mặt',
    NgayThu TEXT NOT NULL,
    NguoiThu TEXT,
    GhiChu TEXT,
    FOREIGN KEY (MaDangKy) REFERENCES DangKy(MaDangKy)
);

-- 8. BẢNG ĐIỂM DANH (Cảnh báo vắng > 3 buổi)
CREATE TABLE IF NOT EXISTS DiemDanh (
    MaDiemDanh TEXT PRIMARY KEY,
    MaLop TEXT NOT NULL,
    MaHocVien TEXT NOT NULL,
    BuoiSo INTEGER NOT NULL,
    NgayDiemDanh TEXT NOT NULL,
    TrangThai TEXT NOT NULL DEFAULT 'Có mặt',
    GhiChu TEXT,
    FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien)
);

-- 9. BẢNG KẾT QUẢ HỌC TẬP & CẤP CHỨNG NHẬN
CREATE TABLE IF NOT EXISTS KetQuaHocTap (
    MaKetQua TEXT PRIMARY KEY,
    MaLop TEXT NOT NULL,
    MaHocVien TEXT NOT NULL,
    DiemChuyenCan REAL DEFAULT 0,
    DiemGiuaKy REAL DEFAULT 0,
    DiemCuoiKy REAL DEFAULT 0,
    DiemTrungBinh REAL DEFAULT 0,
    XepLoai TEXT DEFAULT 'Chưa xếp loại',
    TrangThaiHoanThanh INTEGER DEFAULT 0,
    NgayCapChungNhan TEXT,
    FOREIGN KEY (MaLop) REFERENCES LopHoc(MaLop),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien)
);

-- 10. BẢNG TÀI KHOẢN HỆ THỐNG
CREATE TABLE IF NOT EXISTS TaiKhoan (
    TenDangNhap TEXT PRIMARY KEY,
    MatKhau TEXT NOT NULL,
    VaiTro TEXT NOT NULL,
    HoTen TEXT NOT NULL,
    MaLienKet TEXT
);
