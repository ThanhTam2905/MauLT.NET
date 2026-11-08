using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace EduCenterApp.Database;

public static class DatabaseHelper
{
    private static string _dbPath = string.Empty;
    public static string DatabasePath
    {
        get
        {
            if (string.IsNullOrEmpty(_dbPath))
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string dir = Path.Combine(baseDir, "Database");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                _dbPath = Path.Combine(dir, "EduCenter.db");
            }
            return _dbPath;
        }
    }

    public static string ConnectionString => $"Data Source={DatabasePath};";

    public static SqliteConnection GetConnection()
    {
        var conn = new SqliteConnection(ConnectionString);
        conn.Open();
        return conn;
    }

    public static void InitializeDatabase()
    {
        string dbFile = DatabasePath;
        bool isNewDb = !File.Exists(dbFile) || new FileInfo(dbFile).Length == 0;

        using var conn = GetConnection();
        using var cmd = conn.CreateCommand();

        // Enable foreign keys
        cmd.CommandText = "PRAGMA foreign_keys = ON;";
        cmd.ExecuteNonQuery();

        // Create Tables
        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS KhoaHoc (
                MaKhoaHoc TEXT PRIMARY KEY,
                TenKhoaHoc TEXT NOT NULL,
                HocPhi REAL NOT NULL DEFAULT 0,
                SoBuoi INTEGER NOT NULL DEFAULT 0,
                MoTa TEXT
            );

            CREATE TABLE IF NOT EXISTS PhongHoc (
                MaPhong TEXT PRIMARY KEY,
                TenPhong TEXT NOT NULL,
                SucChua INTEGER NOT NULL DEFAULT 20
            );

            CREATE TABLE IF NOT EXISTS GiaoVien (
                MaGiaoVien TEXT PRIMARY KEY,
                HoTen TEXT NOT NULL,
                SoDienThoai TEXT,
                Email TEXT,
                ChuyenMon TEXT
            );

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

            CREATE TABLE IF NOT EXISTS TaiKhoan (
                TenDangNhap TEXT PRIMARY KEY,
                MatKhau TEXT NOT NULL,
                VaiTro TEXT NOT NULL,
                HoTen TEXT NOT NULL,
                MaLienKet TEXT
            );
        ";
        cmd.ExecuteNonQuery();

        cmd.CommandText = "SELECT COUNT(*) FROM KhoaHoc;";
        long count = (long)(cmd.ExecuteScalar() ?? 0);
        if (count == 0)
        {
            SeedInitialData(conn);
        }
    }

    public static void ResetSampleData()
    {
        using var conn = GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            DELETE FROM DiemDanh;
            DELETE FROM BienLaiThuTien;
            DELETE FROM KetQuaHocTap;
            DELETE FROM DangKy;
            DELETE FROM LopHoc;
            DELETE FROM HocVien;
            DELETE FROM GiaoVien;
            DELETE FROM PhongHoc;
            DELETE FROM KhoaHoc;
            DELETE FROM TaiKhoan;
        ";
        cmd.ExecuteNonQuery();
        SeedInitialData(conn);
    }

    private static void SeedInitialData(SqliteConnection conn)
    {
        using var tx = conn.BeginTransaction();
        using var cmd = conn.CreateCommand();
        cmd.Transaction = tx;

        cmd.CommandText = @"
            -- Khoa Hoc
            INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc, HocPhi, SoBuoi, MoTa) VALUES
            ('KH_TOEIC500', 'TOEIC 500+ Căn bản', 3500000, 24, 'Khóa học củng cố ngữ pháp, từ vựng và luyện đề TOEIC đạt 500-650'),
            ('KH_IELTS65', 'IELTS 6.5+ Chuyên sâu', 8500000, 36, 'Luyện toàn diện 4 kỹ năng Nghe - Nói - Đọc - Viết học thuật đạt 6.5+'),
            ('KH_COMM', 'Tiếng Anh Giao Tiếp Phản Xạ', 4200000, 24, 'Rèn luyện phản xạ tự nhiên, phát âm chuẩn giọng Mỹ cho người đi làm'),
            ('KH_KIDS', 'Tiếng Anh Thiếu Nhi Starters', 3800000, 24, 'Phương pháp học qua trò chơi, tạo hứng thú cho trẻ 6-11 tuổi');

            -- Phong Hoc
            INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua) VALUES
            ('P201', 'Phòng 201 (Smart Room)', 25),
            ('P202', 'Phòng 202 (Audio Lab)', 20),
            ('P301', 'Phòng 301 (Hội thảo)', 35);

            -- Giao Vien
            INSERT INTO GiaoVien (MaGiaoVien, HoTen, SoDienThoai, Email, ChuyenMon) VALUES
            ('GV001', 'Thầy John Smith', '0901234567', 'john.smith@educenter.edu.vn', 'IELTS Master 8.5'),
            ('GV002', 'Cô Linh Nguyễn', '0912345678', 'linh.nguyen@educenter.edu.vn', 'TOEIC & Giao tiếp'),
            ('GV003', 'Thầy David Brown', '0923456789', 'david.brown@educenter.edu.vn', 'Writing & Grammar'),
            ('GV004', 'Cô Mai Phạm', '0934567890', 'mai.pham@educenter.edu.vn', 'Cambridge Young Learners');

            -- Hoc Vien
            INSERT INTO HocVien (MaHocVien, HoTen, NgaySinh, SoDienThoai, Email, DiaChi, NgayThamGia, IsHocVienCu) VALUES
            ('HV001', 'Nguyễn Văn An', '2003-05-12', '0981112233', 'an.nguyen@gmail.com', 'Cầu Giấy, Hà Nội', '2025-01-10', 1),
            ('HV002', 'Trần Thị Bích', '2004-08-20', '0982223344', 'bich.tran@gmail.com', 'Đống Đa, Hà Nội', '2025-01-15', 0),
            ('HV003', 'Lê Hoàng Long', '2002-11-03', '0983334455', 'long.le@gmail.com', 'Thanh Xuân, Hà Nội', '2025-02-01', 1),
            ('HV004', 'Phạm Minh Thảo', '2005-04-18', '0984445566', 'thao.pham@gmail.com', 'Hai Bà Trưng, Hà Nội', '2025-02-10', 0),
            ('HV005', 'Vũ Đình Trọng', '2003-09-25', '0985556677', 'trong.vu@gmail.com', 'Ba Đình, Hà Nội', '2025-02-15', 0),
            ('HV006', 'Đặng Thu Hà', '2004-12-01', '0986667788', 'ha.dang@gmail.com', 'Hoàng Mai, Hà Nội', '2025-02-20', 1),
            ('HV007', 'Bùi Gia Huy', '2005-07-08', '0987778899', 'huy.bui@gmail.com', 'Nam Từ Liêm, Hà Nội', '2025-03-01', 0),
            ('HV008', 'Hoàng Bảo Ngọc', '2003-03-14', '0988889900', 'ngoc.hoang@gmail.com', 'Tây Hồ, Hà Nội', '2025-03-05', 0);

            -- Lop Hoc
            INSERT INTO LopHoc (MaLop, TenLop, MaKhoaHoc, MaGiaoVien, MaPhong, ThuHoc, CaHoc, GioBatDau, GioKetThuc, SiSoToiDa, NgayKhaiGiang, TrangThai) VALUES
            ('LOP_IELTS_01', 'IELTS 6.5 - Lớp Sáng T246', 'KH_IELTS65', 'GV001', 'P201', 'T2-T4-T6', 'Ca sáng', '08:30', '10:00', 20, '2025-03-01', 'Đang học'),
            ('LOP_TOEIC_01', 'TOEIC 500 - Tối T246', 'KH_TOEIC500', 'GV002', 'P201', 'T2-T4-T6', 'Ca tối 1', '18:00', '19:30', 25, '2025-03-03', 'Đang học'),
            ('LOP_COMM_01', 'Giao Tiếp Phản Xạ - Tối T357', 'KH_COMM', 'GV003', 'P202', 'T3-T5-T7', 'Ca tối 1', '18:00', '19:30', 20, '2025-03-04', 'Đang học'),
            ('LOP_IELTS_02', 'IELTS Chuyên Sâu - Tối 2 T246', 'KH_IELTS65', 'GV001', 'P202', 'T2-T4-T6', 'Ca tối 2', '19:45', '21:15', 20, '2025-03-10', 'Đang mở');

            -- Dang Ky & Thu Hoc Phi (Sample 1: Hoc vien cu giam 10%, dong 1 lan)
            INSERT INTO DangKy (MaDangKy, MaHocVien, MaLop, NgayDangKy, HocPhiGoc, LoaiUuDai, PhanTramGiam, SoTienGiam, TongTienPhaiDong, DaDong, ConNo, TrangThai) VALUES
            ('DK001', 'HV001', 'LOP_TOEIC_01', '2025-02-25', 3500000, 'Học viên cũ (-10%)', 10, 350000, 3150000, 3150000, 0, 'Đã hoàn tất'),
            ('DK002', 'HV002', 'LOP_TOEIC_01', '2025-02-26', 3500000, 'Không áp dụng', 0, 0, 3500000, 2000000, 1500000, 'Còn nợ đợt 2'),
            ('DK003', 'HV003', 'LOP_IELTS_01', '2025-02-20', 8500000, 'Học viên cũ (-10%)', 10, 850000, 7650000, 7650000, 0, 'Đã hoàn tất'),
            ('DK004', 'HV004', 'LOP_IELTS_01', '2025-02-22', 8500000, 'Đăng ký nhóm (-5%)', 5, 425000, 8075000, 4000000, 4075000, 'Còn nợ đợt 2'),
            ('DK005', 'HV005', 'LOP_TOEIC_01', '2025-02-27', 3500000, 'Không áp dụng', 0, 0, 3500000, 3500000, 0, 'Đã hoàn tất');

            -- Bien Lai Thu Tien
            INSERT INTO BienLaiThuTien (MaBienLai, MaDangKy, MaHocVien, MaLop, SoTienThu, DotThu, HinhThucThanhToan, NgayThu, NguoiThu, GhiChu) VALUES
            ('BL2025001', 'DK001', 'HV001', 'LOP_TOEIC_01', 3150000, 1, 'Chuyển khoản', '2025-02-25', 'Lễ tân Hoa', 'Đóng đủ 1 lần (Đã giảm 10% HV cũ)'),
            ('BL2025002', 'DK002', 'HV002', 'LOP_TOEIC_01', 2000000, 1, 'Tiền mặt', '2025-02-26', 'Lễ tân Hoa', 'Đóng đợt 1, hẹn đợt 2 trước ngày 15/03'),
            ('BL2025003', 'DK003', 'HV003', 'LOP_IELTS_01', 7650000, 1, 'Chuyển khoản', '2025-02-20', 'Lễ tân Lan', 'Thanh toán trọn gói 100%'),
            ('BL2025004', 'DK004', 'HV004', 'LOP_IELTS_01', 4000000, 1, 'Chuyển khoản', '2025-02-22', 'Lễ tân Lan', 'Đợt 1 ưu đãi nhóm 5%');

            -- Diem Danh (HV005 vang 4 buoi -> He thong canh bao vang > 3 buoi)
            INSERT INTO DiemDanh (MaDiemDanh, MaLop, MaHocVien, BuoiSo, NgayDiemDanh, TrangThai, GhiChu) VALUES
            ('DD001', 'LOP_TOEIC_01', 'HV001', 1, '2025-03-03', 'Có mặt', 'Tốt'),
            ('DD002', 'LOP_TOEIC_01', 'HV002', 1, '2025-03-03', 'Có mặt', ''),
            ('DD003', 'LOP_TOEIC_01', 'HV005', 1, '2025-03-03', 'Vắng không phép', 'Không liên lạc được'),
            ('DD004', 'LOP_TOEIC_01', 'HV001', 2, '2025-03-05', 'Có mặt', ''),
            ('DD005', 'LOP_TOEIC_01', 'HV002', 2, '2025-03-05', 'Vắng có phép', 'Báo ốm'),
            ('DD006', 'LOP_TOEIC_01', 'HV005', 2, '2025-03-05', 'Vắng không phép', 'Không lý do'),
            ('DD007', 'LOP_TOEIC_01', 'HV001', 3, '2025-03-07', 'Có mặt', ''),
            ('DD008', 'LOP_TOEIC_01', 'HV002', 3, '2025-03-07', 'Có mặt', ''),
            ('DD009', 'LOP_TOEIC_01', 'HV005', 3, '2025-03-07', 'Vắng có phép', 'Gia đình có việc'),
            ('DD010', 'LOP_TOEIC_01', 'HV001', 4, '2025-03-10', 'Có mặt', ''),
            ('DD011', 'LOP_TOEIC_01', 'HV002', 4, '2025-03-10', 'Có mặt', ''),
            ('DD012', 'LOP_TOEIC_01', 'HV005', 4, '2025-03-10', 'Vắng không phép', '⚠️ ĐÃ VẮNG 4 BUỔI - CẦN LỄ TÂN LIÊN HỆ!');

            -- Ket Qua Hoc Tap (Scores & Certificate)
            INSERT INTO KetQuaHocTap (MaKetQua, MaLop, MaHocVien, DiemChuyenCan, DiemGiuaKy, DiemCuoiKy, DiemTrungBinh, XepLoai, TrangThaiHoanThanh, NgayCapChungNhan) VALUES
            ('KQ001', 'LOP_TOEIC_01', 'HV001', 10.0, 8.5, 9.0, 8.8, 'Giỏi', 1, '2025-04-30'),
            ('KQ002', 'LOP_TOEIC_01', 'HV002', 8.5, 7.0, 7.5, 7.4, 'Khá', 1, '2025-04-30'),
            ('KQ003', 'LOP_TOEIC_01', 'HV005', 4.0, 5.0, 4.5, 4.6, 'Chưa đạt', 0, NULL),
            ('KQ004', 'LOP_IELTS_01', 'HV003', 9.5, 8.5, 8.5, 8.6, 'Xuất sắc', 1, '2025-05-15');

            -- Tai Khoan
            INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, HoTen, MaLienKet) VALUES
            ('admin', '123456', 'Quản trị viên', 'Nguyễn Quản Trị', 'AD001'),
            ('teacher', '123456', 'Giáo viên', 'Cô Linh Nguyễn', 'GV002'),
            ('student', '123456', 'Học viên', 'Nguyễn Văn An', 'HV001');
        ";
        cmd.ExecuteNonQuery();
        tx.Commit();
    }
}
