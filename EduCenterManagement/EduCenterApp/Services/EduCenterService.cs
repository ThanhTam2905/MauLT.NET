using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using EduCenterApp.Database;
using EduCenterApp.Models;

namespace EduCenterApp.Services;

public class EduCenterService
{
    public List<KhoaHoc> GetAllKhoaHoc()
    {
        var list = new List<KhoaHoc>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT MaKhoaHoc, TenKhoaHoc, HocPhi, SoBuoi, MoTa FROM KhoaHoc ORDER BY MaKhoaHoc;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new KhoaHoc
            {
                MaKhoaHoc = reader.GetString(0),
                TenKhoaHoc = reader.GetString(1),
                HocPhi = Convert.ToDecimal(reader.GetDouble(2)),
                SoBuoi = reader.GetInt32(3),
                MoTa = reader.IsDBNull(4) ? "" : reader.GetString(4)
            });
        }
        return list;
    }

    public void SaveKhoaHoc(KhoaHoc kh, bool isNew)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        if (isNew)
        {
            cmd.CommandText = @"
                INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc, HocPhi, SoBuoi, MoTa)
                VALUES (@ma, @ten, @hp, @sb, @mt);";
        }
        else
        {
            cmd.CommandText = @"
                UPDATE KhoaHoc 
                SET TenKhoaHoc = @ten, HocPhi = @hp, SoBuoi = @sb, MoTa = @mt
                WHERE MaKhoaHoc = @ma;";
        }
        cmd.Parameters.AddWithValue("@ma", kh.MaKhoaHoc);
        cmd.Parameters.AddWithValue("@ten", kh.TenKhoaHoc);
        cmd.Parameters.AddWithValue("@hp", (double)kh.HocPhi);
        cmd.Parameters.AddWithValue("@sb", kh.SoBuoi);
        cmd.Parameters.AddWithValue("@mt", kh.MoTa ?? "");
        cmd.ExecuteNonQuery();
    }

    public void DeleteKhoaHoc(string maKhoaHoc)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM KhoaHoc WHERE MaKhoaHoc = @ma;";
        cmd.Parameters.AddWithValue("@ma", maKhoaHoc);
        cmd.ExecuteNonQuery();
    }

    public List<PhongHoc> GetAllPhongHoc()
    {
        var list = new List<PhongHoc>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT MaPhong, TenPhong, SucChua FROM PhongHoc ORDER BY MaPhong;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PhongHoc
            {
                MaPhong = reader.GetString(0),
                TenPhong = reader.GetString(1),
                SucChua = reader.GetInt32(2)
            });
        }
        return list;
    }

    public List<GiaoVien> GetAllGiaoVien()
    {
        var list = new List<GiaoVien>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT MaGiaoVien, HoTen, SoDienThoai, Email, ChuyenMon FROM GiaoVien ORDER BY MaGiaoVien;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new GiaoVien
            {
                MaGiaoVien = reader.GetString(0),
                HoTen = reader.GetString(1),
                SoDienThoai = reader.IsDBNull(2) ? "" : reader.GetString(2),
                Email = reader.IsDBNull(3) ? "" : reader.GetString(3),
                ChuyenMon = reader.IsDBNull(4) ? "" : reader.GetString(4)
            });
        }
        return list;
    }

    public List<HocVien> GetAllHocVien()
    {
        var list = new List<HocVien>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT MaHocVien, HoTen, NgaySinh, SoDienThoai, Email, DiaChi, NgayThamGia, IsHocVienCu FROM HocVien ORDER BY MaHocVien;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new HocVien
            {
                MaHocVien = reader.GetString(0),
                HoTen = reader.GetString(1),
                NgaySinh = reader.IsDBNull(2) ? "" : reader.GetString(2),
                SoDienThoai = reader.IsDBNull(3) ? "" : reader.GetString(3),
                Email = reader.IsDBNull(4) ? "" : reader.GetString(4),
                DiaChi = reader.IsDBNull(5) ? "" : reader.GetString(5),
                NgayThamGia = reader.IsDBNull(6) ? "" : reader.GetString(6),
                IsHocVienCu = reader.GetInt32(7) == 1
            });
        }
        return list;
    }

    public void AddHocVien(HocVien hv)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            INSERT INTO HocVien (MaHocVien, HoTen, NgaySinh, SoDienThoai, Email, DiaChi, NgayThamGia, IsHocVienCu)
            VALUES (@ma, @ten, @ns, @sdt, @email, @dc, @ntg, @cu);";
        cmd.Parameters.AddWithValue("@ma", hv.MaHocVien);
        cmd.Parameters.AddWithValue("@ten", hv.HoTen);
        cmd.Parameters.AddWithValue("@ns", hv.NgaySinh ?? "");
        cmd.Parameters.AddWithValue("@sdt", hv.SoDienThoai ?? "");
        cmd.Parameters.AddWithValue("@email", hv.Email ?? "");
        cmd.Parameters.AddWithValue("@dc", hv.DiaChi ?? "");
        cmd.Parameters.AddWithValue("@ntg", string.IsNullOrEmpty(hv.NgayThamGia) ? DateTime.Now.ToString("yyyy-MM-dd") : hv.NgayThamGia);
        cmd.Parameters.AddWithValue("@cu", hv.IsHocVienCu ? 1 : 0);
        cmd.ExecuteNonQuery();
    }

    public List<LopHoc> GetAllLopHoc()
    {
        var list = new List<LopHoc>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT l.MaLop, l.TenLop, l.MaKhoaHoc, k.TenKhoaHoc,
                   l.MaGiaoVien, g.HoTen, l.MaPhong, p.TenPhong,
                   l.ThuHoc, l.CaHoc, l.GioBatDau, l.GioKetThuc,
                   l.SiSoToiDa, 
                   (SELECT COUNT(*) FROM DangKy d WHERE d.MaLop = l.MaLop) AS SiSoHienTai,
                   l.NgayKhaiGiang, l.TrangThai
            FROM LopHoc l
            LEFT JOIN KhoaHoc k ON l.MaKhoaHoc = k.MaKhoaHoc
            LEFT JOIN GiaoVien g ON l.MaGiaoVien = g.MaGiaoVien
            LEFT JOIN PhongHoc p ON l.MaPhong = p.MaPhong
            ORDER BY l.MaLop;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new LopHoc
            {
                MaLop = reader.GetString(0),
                TenLop = reader.GetString(1),
                MaKhoaHoc = reader.GetString(2),
                TenKhoaHoc = reader.IsDBNull(3) ? "" : reader.GetString(3),
                MaGiaoVien = reader.GetString(4),
                TenGiaoVien = reader.IsDBNull(5) ? "" : reader.GetString(5),
                MaPhong = reader.GetString(6),
                TenPhong = reader.IsDBNull(7) ? "" : reader.GetString(7),
                ThuHoc = reader.GetString(8),
                CaHoc = reader.GetString(9),
                GioBatDau = reader.GetString(10),
                GioKetThuc = reader.GetString(11),
                SiSoToiDa = reader.GetInt32(12),
                SiSoHienTai = reader.GetInt32(13),
                NgayKhaiGiang = reader.IsDBNull(14) ? "" : reader.GetString(14),
                TrangThai = reader.IsDBNull(15) ? "Đang mở" : reader.GetString(15)
            });
        }
        return list;
    }

    public XungDotLichHoc CheckScheduleConflict(string? maLopHienTai, string maPhong, string maGiaoVien, string thuHoc, string gioBatDau, string gioKetThuc)
    {
        var result = new XungDotLichHoc { HasConflict = false };
        var allClasses = GetAllLopHoc();

        TimeSpan newStart = TimeSpan.TryParse(gioBatDau, out var ns) ? ns : TimeSpan.Zero;
        TimeSpan newEnd = TimeSpan.TryParse(gioKetThuc, out var ne) ? ne : TimeSpan.FromHours(2);

        foreach (var lop in allClasses)
        {
            if (!string.IsNullOrEmpty(maLopHienTai) && lop.MaLop.Equals(maLopHienTai, StringComparison.OrdinalIgnoreCase))
                continue;

            if (!AreDaysOverlapping(thuHoc, lop.ThuHoc))
                continue;

            TimeSpan exStart = TimeSpan.TryParse(lop.GioBatDau, out var es) ? es : TimeSpan.Zero;
            TimeSpan exEnd = TimeSpan.TryParse(lop.GioKetThuc, out var ee) ? ee : TimeSpan.FromHours(2);

            bool isTimeOverlap = (newStart < exEnd) && (newEnd > exStart);
            if (!isTimeOverlap)
                continue;

            // 1. Kiểm tra TRÙNG PHÒNG HỌC
            if (lop.MaPhong.Equals(maPhong, StringComparison.OrdinalIgnoreCase))
            {
                result.HasConflict = true;
                result.LoaiXungDot = "Trùng phòng học";
                result.LopBiTrung = lop;
                result.ChiTiet = $"⚠️ Xung đột: Phòng '{lop.TenPhong}' đã được xếp cho lớp '{lop.TenLop}' ({lop.MaLop}) vào {lop.ThuHoc} lúc {lop.GioBatDau} - {lop.GioKetThuc}!";
                return result;
            }

            // 2. Kiểm tra TRÙNG GIÁO VIÊN
            if (lop.MaGiaoVien.Equals(maGiaoVien, StringComparison.OrdinalIgnoreCase))
            {
                result.HasConflict = true;
                result.LoaiXungDot = "Trùng lịch giáo viên";
                result.LopBiTrung = lop;
                result.ChiTiet = $"⚠️ Xung đột: Giáo viên '{lop.TenGiaoVien}' đã có lịch dạy lớp '{lop.TenLop}' ({lop.MaLop}) vào {lop.ThuHoc} lúc {lop.GioBatDau} - {lop.GioKetThuc}!";
                return result;
            }
        }

        return result;
    }

    private bool AreDaysOverlapping(string days1, string days2)
    {
        if (days1.Equals(days2, StringComparison.OrdinalIgnoreCase)) return true;
        string[] d1Parts = days1.Split(new[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] d2Parts = days2.Split(new[] { '-', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var p1 in d1Parts)
        {
            foreach (var p2 in d2Parts)
            {
                if (p1.Equals(p2, StringComparison.OrdinalIgnoreCase)) return true;
            }
        }
        return false;
    }

    public void SaveLopHoc(LopHoc lop, bool isNew)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        if (isNew)
        {
            cmd.CommandText = @"
                INSERT INTO LopHoc (MaLop, TenLop, MaKhoaHoc, MaGiaoVien, MaPhong, ThuHoc, CaHoc, GioBatDau, GioKetThuc, SiSoToiDa, NgayKhaiGiang, TrangThai)
                VALUES (@ma, @ten, @makh, @magv, @maph, @thu, @ca, @gbd, @gkt, @ss, @nkg, @tt);";
        }
        else
        {
            cmd.CommandText = @"
                UPDATE LopHoc
                SET TenLop = @ten, MaKhoaHoc = @makh, MaGiaoVien = @magv, MaPhong = @maph,
                    ThuHoc = @thu, CaHoc = @ca, GioBatDau = @gbd, GioKetThuc = @gkt,
                    SiSoToiDa = @ss, NgayKhaiGiang = @nkg, TrangThai = @tt
                WHERE MaLop = @ma;";
        }
        cmd.Parameters.AddWithValue("@ma", lop.MaLop);
        cmd.Parameters.AddWithValue("@ten", lop.TenLop);
        cmd.Parameters.AddWithValue("@makh", lop.MaKhoaHoc);
        cmd.Parameters.AddWithValue("@magv", lop.MaGiaoVien);
        cmd.Parameters.AddWithValue("@maph", lop.MaPhong);
        cmd.Parameters.AddWithValue("@thu", lop.ThuHoc);
        cmd.Parameters.AddWithValue("@ca", lop.CaHoc);
        cmd.Parameters.AddWithValue("@gbd", lop.GioBatDau);
        cmd.Parameters.AddWithValue("@gkt", lop.GioKetThuc);
        cmd.Parameters.AddWithValue("@ss", lop.SiSoToiDa);
        cmd.Parameters.AddWithValue("@nkg", lop.NgayKhaiGiang ?? "");
        cmd.Parameters.AddWithValue("@tt", lop.TrangThai ?? "Đang mở");
        cmd.ExecuteNonQuery();
    }

    public void DeleteLopHoc(string maLop)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM LopHoc WHERE MaLop = @ma;";
        cmd.Parameters.AddWithValue("@ma", maLop);
        cmd.ExecuteNonQuery();
    }

    public List<DangKy> GetAllDangKy()
    {
        var list = new List<DangKy>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT d.MaDangKy, d.MaHocVien, h.HoTen, d.MaLop, l.TenLop,
                   d.NgayDangKy, d.HocPhiGoc, d.LoaiUuDai, d.PhanTramGiam,
                   d.SoTienGiam, d.TongTienPhaiDong, d.DaDong, d.ConNo, d.TrangThai
            FROM DangKy d
            LEFT JOIN HocVien h ON d.MaHocVien = h.MaHocVien
            LEFT JOIN LopHoc l ON d.MaLop = l.MaLop
            ORDER BY d.MaDangKy DESC;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DangKy
            {
                MaDangKy = reader.GetString(0),
                MaHocVien = reader.GetString(1),
                TenHocVien = reader.IsDBNull(2) ? "" : reader.GetString(2),
                MaLop = reader.GetString(3),
                TenLop = reader.IsDBNull(4) ? "" : reader.GetString(4),
                NgayDangKy = reader.GetString(5),
                HocPhiGoc = Convert.ToDecimal(reader.GetDouble(6)),
                LoaiUuDai = reader.IsDBNull(7) ? "" : reader.GetString(7),
                PhanTramGiam = Convert.ToDecimal(reader.GetDouble(8)),
                SoTienGiam = Convert.ToDecimal(reader.GetDouble(9)),
                TongTienPhaiDong = Convert.ToDecimal(reader.GetDouble(10)),
                DaDong = Convert.ToDecimal(reader.GetDouble(11)),
                ConNo = Convert.ToDecimal(reader.GetDouble(12)),
                TrangThai = reader.IsDBNull(13) ? "" : reader.GetString(13)
            });
        }
        return list;
    }

    public BienLaiThuTien RegisterStudent(string maHocVien, string maLop, string loaiUuDai, decimal phanTramGiam, decimal soTienDong, string hinhThucTT, string nguoiThu, string ghiChu)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var tx = conn.BeginTransaction();

        using var cmdFee = conn.CreateCommand();
        cmdFee.Transaction = tx;
        cmdFee.CommandText = @"
            SELECT k.HocPhi, l.TenLop, h.HoTen
            FROM LopHoc l
            JOIN KhoaHoc k ON l.MaKhoaHoc = k.MaKhoaHoc
            JOIN HocVien h ON h.MaHocVien = @mahv
            WHERE l.MaLop = @malop;";
        cmdFee.Parameters.AddWithValue("@mahv", maHocVien);
        cmdFee.Parameters.AddWithValue("@malop", maLop);

        decimal hocPhiGoc = 0;
        string tenLop = "";
        string tenHocVien = "";

        using (var r = cmdFee.ExecuteReader())
        {
            if (r.Read())
            {
                hocPhiGoc = Convert.ToDecimal(r.GetDouble(0));
                tenLop = r.GetString(1);
                tenHocVien = r.GetString(2);
            }
        }

        decimal soTienGiam = hocPhiGoc * (phanTramGiam / 100m);
        decimal tongPhaiDong = hocPhiGoc - soTienGiam;
        decimal daDong = Math.Min(soTienDong, tongPhaiDong);
        decimal conNo = tongPhaiDong - daDong;
        string trangThai = conNo <= 0 ? "Đã hoàn tất" : "Còn nợ";

        string maDangKy = "DK" + DateTime.Now.ToString("yyMMddHHmmss");
        string ngayHienTai = DateTime.Now.ToString("yyyy-MM-dd");

        using var cmdDK = conn.CreateCommand();
        cmdDK.Transaction = tx;
        cmdDK.CommandText = @"
            INSERT INTO DangKy (MaDangKy, MaHocVien, MaLop, NgayDangKy, HocPhiGoc, LoaiUuDai, PhanTramGiam, SoTienGiam, TongTienPhaiDong, DaDong, ConNo, TrangThai)
            VALUES (@madk, @mahv, @malop, @ngay, @hpg, @uudai, @ptg, @stg, @tong, @dadong, @conno, @tt);";
        cmdDK.Parameters.AddWithValue("@madk", maDangKy);
        cmdDK.Parameters.AddWithValue("@mahv", maHocVien);
        cmdDK.Parameters.AddWithValue("@malop", maLop);
        cmdDK.Parameters.AddWithValue("@ngay", ngayHienTai);
        cmdDK.Parameters.AddWithValue("@hpg", (double)hocPhiGoc);
        cmdDK.Parameters.AddWithValue("@uudai", loaiUuDai);
        cmdDK.Parameters.AddWithValue("@ptg", (double)phanTramGiam);
        cmdDK.Parameters.AddWithValue("@stg", (double)soTienGiam);
        cmdDK.Parameters.AddWithValue("@tong", (double)tongPhaiDong);
        cmdDK.Parameters.AddWithValue("@dadong", (double)daDong);
        cmdDK.Parameters.AddWithValue("@conno", (double)conNo);
        cmdDK.Parameters.AddWithValue("@tt", trangThai);
        cmdDK.ExecuteNonQuery();

        string maBienLai = "BL" + DateTime.Now.ToString("yyMMddHHmmss");
        using var cmdBL = conn.CreateCommand();
        cmdBL.Transaction = tx;
        cmdBL.CommandText = @"
            INSERT INTO BienLaiThuTien (MaBienLai, MaDangKy, MaHocVien, MaLop, SoTienThu, DotThu, HinhThucThanhToan, NgayThu, NguoiThu, GhiChu)
            VALUES (@mabl, @madk, @mahv, @malop, @sotien, 1, @ht, @ngay, @nguoithu, @gc);";
        cmdBL.Parameters.AddWithValue("@mabl", maBienLai);
        cmdBL.Parameters.AddWithValue("@madk", maDangKy);
        cmdBL.Parameters.AddWithValue("@mahv", maHocVien);
        cmdBL.Parameters.AddWithValue("@malop", maLop);
        cmdBL.Parameters.AddWithValue("@sotien", (double)daDong);
        cmdBL.Parameters.AddWithValue("@ht", hinhThucTT);
        cmdBL.Parameters.AddWithValue("@ngay", ngayHienTai);
        cmdBL.Parameters.AddWithValue("@nguoithu", nguoiThu);
        cmdBL.Parameters.AddWithValue("@gc", ghiChu ?? "Thu học phí đợt 1");
        cmdBL.ExecuteNonQuery();

        string maKetQua = "KQ" + DateTime.Now.ToString("yyMMddHHmmss");
        using var cmdKQ = conn.CreateCommand();
        cmdKQ.Transaction = tx;
        cmdKQ.CommandText = @"
            INSERT OR IGNORE INTO KetQuaHocTap (MaKetQua, MaLop, MaHocVien, DiemChuyenCan, DiemGiuaKy, DiemCuoiKy, DiemTrungBinh, XepLoai, TrangThaiHoanThanh)
            VALUES (@makq, @malop, @mahv, 0, 0, 0, 0, 'Chưa xếp loại', 0);";
        cmdKQ.Parameters.AddWithValue("@makq", maKetQua);
        cmdKQ.Parameters.AddWithValue("@malop", maLop);
        cmdKQ.Parameters.AddWithValue("@mahv", maHocVien);
        cmdKQ.ExecuteNonQuery();

        tx.Commit();

        return new BienLaiThuTien
        {
            MaBienLai = maBienLai,
            MaDangKy = maDangKy,
            MaHocVien = maHocVien,
            TenHocVien = tenHocVien,
            MaLop = maLop,
            TenLop = tenLop,
            SoTienThu = daDong,
            DotThu = 1,
            HinhThucThanhToan = hinhThucTT,
            NgayThu = ngayHienTai,
            NguoiThu = nguoiThu,
            GhiChu = ghiChu ?? ""
        };
    }

    public List<BienLaiThuTien> GetAllBienLai()
    {
        var list = new List<BienLaiThuTien>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT b.MaBienLai, b.MaDangKy, b.MaHocVien, h.HoTen, b.MaLop, l.TenLop,
                   b.SoTienThu, b.DotThu, b.HinhThucThanhToan, b.NgayThu, b.NguoiThu, b.GhiChu
            FROM BienLaiThuTien b
            LEFT JOIN HocVien h ON b.MaHocVien = h.MaHocVien
            LEFT JOIN LopHoc l ON b.MaLop = l.MaLop
            ORDER BY b.MaBienLai DESC;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new BienLaiThuTien
            {
                MaBienLai = reader.GetString(0),
                MaDangKy = reader.GetString(1),
                MaHocVien = reader.GetString(2),
                TenHocVien = reader.IsDBNull(3) ? "" : reader.GetString(3),
                MaLop = reader.GetString(4),
                TenLop = reader.IsDBNull(5) ? "" : reader.GetString(5),
                SoTienThu = Convert.ToDecimal(reader.GetDouble(6)),
                DotThu = reader.GetInt32(7),
                HinhThucThanhToan = reader.IsDBNull(8) ? "Tiền mặt" : reader.GetString(8),
                NgayThu = reader.GetString(9),
                NguoiThu = reader.IsDBNull(10) ? "" : reader.GetString(10),
                GhiChu = reader.IsDBNull(11) ? "" : reader.GetString(11)
            });
        }
        return list;
    }

    public BienLaiThuTien RecordTuitionPayment(string maDangKy, decimal soTien, string hinhThucTT, string nguoiThu, string ghiChu)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var tx = conn.BeginTransaction();

        using var cmdCheck = conn.CreateCommand();
        cmdCheck.Transaction = tx;
        cmdCheck.CommandText = @"
            SELECT d.MaHocVien, h.HoTen, d.MaLop, l.TenLop, d.TongTienPhaiDong, d.DaDong, d.ConNo,
                   (SELECT COUNT(*) FROM BienLaiThuTien b WHERE b.MaDangKy = d.MaDangKy) AS SoDotDaThu
            FROM DangKy d
            JOIN HocVien h ON d.MaHocVien = h.MaHocVien
            JOIN LopHoc l ON d.MaLop = l.MaLop
            WHERE d.MaDangKy = @madk;";
        cmdCheck.Parameters.AddWithValue("@madk", maDangKy);

        string maHocVien = "";
        string tenHocVien = "";
        string maLop = "";
        string tenLop = "";
        decimal tongPhaiDong = 0;
        decimal daDongHienTai = 0;
        int soDotDaThu = 0;

        using (var r = cmdCheck.ExecuteReader())
        {
            if (r.Read())
            {
                maHocVien = r.GetString(0);
                tenHocVien = r.GetString(1);
                maLop = r.GetString(2);
                tenLop = r.GetString(3);
                tongPhaiDong = Convert.ToDecimal(r.GetDouble(4));
                daDongHienTai = Convert.ToDecimal(r.GetDouble(5));
                soDotDaThu = r.GetInt32(7);
            }
        }

        int dotMoi = soDotDaThu + 1;
        decimal daDongMoi = daDongHienTai + soTien;
        decimal connoMoi = Math.Max(0, tongPhaiDong - daDongMoi);
        string trangThaiMoi = connoMoi <= 0 ? "Đã hoàn tất" : "Còn nợ";

        using var cmdUpdate = conn.CreateCommand();
        cmdUpdate.Transaction = tx;
        cmdUpdate.CommandText = @"
            UPDATE DangKy 
            SET DaDong = @dadong, ConNo = @conno, TrangThai = @tt
            WHERE MaDangKy = @madk;";
        cmdUpdate.Parameters.AddWithValue("@dadong", (double)daDongMoi);
        cmdUpdate.Parameters.AddWithValue("@conno", (double)connoMoi);
        cmdUpdate.Parameters.AddWithValue("@tt", trangThaiMoi);
        cmdUpdate.Parameters.AddWithValue("@madk", maDangKy);
        cmdUpdate.ExecuteNonQuery();

        string maBienLai = "BL" + DateTime.Now.ToString("yyMMddHHmmss");
        string ngayHienTai = DateTime.Now.ToString("yyyy-MM-dd");

        using var cmdBL = conn.CreateCommand();
        cmdBL.Transaction = tx;
        cmdBL.CommandText = @"
            INSERT INTO BienLaiThuTien (MaBienLai, MaDangKy, MaHocVien, MaLop, SoTienThu, DotThu, HinhThucThanhToan, NgayThu, NguoiThu, GhiChu)
            VALUES (@mabl, @madk, @mahv, @malop, @sotien, @dot, @ht, @ngay, @nguoithu, @gc);";
        cmdBL.Parameters.AddWithValue("@mabl", maBienLai);
        cmdBL.Parameters.AddWithValue("@madk", maDangKy);
        cmdBL.Parameters.AddWithValue("@mahv", maHocVien);
        cmdBL.Parameters.AddWithValue("@malop", maLop);
        cmdBL.Parameters.AddWithValue("@sotien", (double)soTien);
        cmdBL.Parameters.AddWithValue("@dot", dotMoi);
        cmdBL.Parameters.AddWithValue("@ht", hinhThucTT);
        cmdBL.Parameters.AddWithValue("@ngay", ngayHienTai);
        cmdBL.Parameters.AddWithValue("@nguoithu", nguoiThu);
        cmdBL.Parameters.AddWithValue("@gc", ghiChu ?? $"Đóng học phí đợt {dotMoi}");
        cmdBL.ExecuteNonQuery();

        tx.Commit();

        return new BienLaiThuTien
        {
            MaBienLai = maBienLai,
            MaDangKy = maDangKy,
            MaHocVien = maHocVien,
            TenHocVien = tenHocVien,
            MaLop = maLop,
            TenLop = tenLop,
            SoTienThu = soTien,
            DotThu = dotMoi,
            HinhThucThanhToan = hinhThucTT,
            NgayThu = ngayHienTai,
            NguoiThu = nguoiThu,
            GhiChu = ghiChu ?? ""
        };
    }

    public List<DiemDanhItem> GetDiemDanh(string maLop, int buoiSo, string ngayDiemDanh)
    {
        var list = new List<DiemDanhItem>();
        using var conn = DatabaseHelper.GetConnection();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT h.MaHocVien, h.HoTen, h.SoDienThoai,
                   COALESCE(dd.MaDiemDanh, '') AS MaDiemDanh,
                   COALESCE(dd.TrangThai, 'Có mặt') AS TrangThai,
                   COALESCE(dd.GhiChu, '') AS GhiChu,
                   (SELECT COUNT(*) FROM DiemDanh d WHERE d.MaLop = @malop AND d.MaHocVien = h.MaHocVien AND d.TrangThai != 'Có mặt') AS TongSoVang
            FROM DangKy dk
            JOIN HocVien h ON dk.MaHocVien = h.MaHocVien
            LEFT JOIN DiemDanh dd ON dd.MaLop = @malop AND dd.MaHocVien = h.MaHocVien AND dd.BuoiSo = @buoi
            WHERE dk.MaLop = @malop
            ORDER BY h.HoTen;";
        cmd.Parameters.AddWithValue("@malop", maLop);
        cmd.Parameters.AddWithValue("@buoi", buoiSo);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            string maHv = reader.GetString(0);
            string tenHv = reader.GetString(1);
            string sdt = reader.IsDBNull(2) ? "" : reader.GetString(2);
            string maDd = reader.GetString(3);
            string trangThai = reader.GetString(4);
            string ghiChu = reader.GetString(5);
            int tongVang = reader.GetInt32(6);

            list.Add(new DiemDanhItem
            {
                MaDiemDanh = string.IsNullOrEmpty(maDd) ? ("DD_" + maLop + "_" + maHv + "_" + buoiSo) : maDd,
                MaLop = maLop,
                MaHocVien = maHv,
                TenHocVien = tenHv,
                SoDienThoai = sdt,
                BuoiSo = buoiSo,
                NgayDiemDanh = ngayDiemDanh,
                TrangThai = trangThai,
                GhiChu = ghiChu,
                TongSoBuoiVang = tongVang,
                CanCanhBaoVang = tongVang >= 3
            });
        }
        return list;
    }

    public void SaveDiemDanh(List<DiemDanhItem> items)
    {
        using var conn = DatabaseHelper.GetConnection();
        using var tx = conn.BeginTransaction();

        foreach (var item in items)
        {
            using var cmd = conn.CreateCommand();
            cmd.Transaction = tx;
            cmd.CommandText = @"
                INSERT INTO DiemDanh (MaDiemDanh, MaLop, MaHocVien, BuoiSo, NgayDiemDanh, TrangThai, GhiChu)
                VALUES (@madd, @malop, @mahv, @buoi, @ngay, @tt, @gc)
                ON CONFLICT(MaDiemDanh) DO UPDATE SET
                    TrangThai = @tt,
                    NgayDiemDanh = @ngay,
                    GhiChu = @gc;";
            cmd.Parameters.AddWithValue("@madd", item.MaDiemDanh);
            cmd.Parameters.AddWithValue("@malop", item.MaLop);
            cmd.Parameters.AddWithValue("@mahv", item.MaHocVien);
            cmd.Parameters.AddWithValue("@buoi", item.BuoiSo);
            cmd.Parameters.AddWithValue("@ngay", item.NgayDiemDanh);
            cmd.Parameters.AddWithValue("@tt", item.TrangThai);
            cmd.Parameters.AddWithValue("@gc", item.GhiChu ?? "");
            cmd.ExecuteNonQuery();
        }
        tx.Commit();
    }

    public List<DiemDanhItem> GetDanhSachCanhBaoVang()
    {
        var list = new List<DiemDanhItem>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT d.MaLop, l.TenLop, d.MaHocVien, h.HoTen, h.SoDienThoai, COUNT(*) as SoBuoiVang
            FROM DiemDanh d
            JOIN HocVien h ON d.MaHocVien = h.MaHocVien
            JOIN LopHoc l ON d.MaLop = l.MaLop
            WHERE d.TrangThai != 'Có mặt'
            GROUP BY d.MaLop, d.MaHocVien
            HAVING COUNT(*) >= 3
            ORDER BY SoBuoiVang DESC;";
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DiemDanhItem
            {
                MaLop = reader.GetString(0),
                GhiChu = reader.GetString(1),
                MaHocVien = reader.GetString(2),
                TenHocVien = reader.GetString(3),
                SoDienThoai = reader.IsDBNull(4) ? "" : reader.GetString(4),
                TongSoBuoiVang = reader.GetInt32(5),
                CanCanhBaoVang = true
            });
        }
        return list;
    }

    public List<KetQuaHocTap> GetKetQuaByLop(string maLop)
    {
        var list = new List<KetQuaHocTap>();
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT k.MaKetQua, k.MaLop, l.TenLop, k.MaHocVien, h.HoTen,
                   k.DiemChuyenCan, k.DiemGiuaKy, k.DiemCuoiKy, k.DiemTrungBinh,
                   k.XepLoai, k.TrangThaiHoanThanh, k.NgayCapChungNhan
            FROM KetQuaHocTap k
            JOIN HocVien h ON k.MaHocVien = h.MaHocVien
            JOIN LopHoc l ON k.MaLop = l.MaLop
            WHERE k.MaLop = @malop
            ORDER BY h.HoTen;";
        cmd.Parameters.AddWithValue("@malop", maLop);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new KetQuaHocTap
            {
                MaKetQua = reader.GetString(0),
                MaLop = reader.GetString(1),
                TenLop = reader.GetString(2),
                MaHocVien = reader.GetString(3),
                TenHocVien = reader.GetString(4),
                DiemChuyenCan = Convert.ToDecimal(reader.GetDouble(5)),
                DiemGiuaKy = Convert.ToDecimal(reader.GetDouble(6)),
                DiemCuoiKy = Convert.ToDecimal(reader.GetDouble(7)),
                DiemTrungBinh = Convert.ToDecimal(reader.GetDouble(8)),
                XepLoai = reader.IsDBNull(9) ? "Chưa xếp loại" : reader.GetString(9),
                TrangThaiHoanThanh = reader.GetInt32(10) == 1,
                NgayCapChungNhan = reader.IsDBNull(11) ? "" : reader.GetString(11)
            });
        }
        return list;
    }

    public void SaveDiem(string maKetQua, decimal chuyenCan, decimal giuaKy, decimal cuoiKy)
    {
        decimal dtb = Math.Round((chuyenCan * 0.1m) + (giuaKy * 0.4m) + (cuoiKy * 0.5m), 2);

        string xepLoai = "Chưa đạt";
        bool hoanThanh = false;
        string ngayCap = "";

        if (dtb >= 9.0m)
        {
            xepLoai = "Xuất sắc";
            hoanThanh = true;
        }
        else if (dtb >= 8.0m)
        {
            xepLoai = "Giỏi";
            hoanThanh = true;
        }
        else if (dtb >= 6.5m)
        {
            xepLoai = "Khá";
            hoanThanh = true;
        }
        else if (dtb >= 5.0m)
        {
            xepLoai = "Trung bình (Đạt)";
            hoanThanh = true;
        }

        if (hoanThanh)
        {
            ngayCap = DateTime.Now.ToString("yyyy-MM-dd");
        }

        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            UPDATE KetQuaHocTap
            SET DiemChuyenCan = @cc, DiemGiuaKy = @gk, DiemCuoiKy = @ck,
                DiemTrungBinh = @dtb, XepLoai = @xl, TrangThaiHoanThanh = @ht,
                NgayCapChungNhan = @nc
            WHERE MaKetQua = @makq;";
        cmd.Parameters.AddWithValue("@cc", (double)chuyenCan);
        cmd.Parameters.AddWithValue("@gk", (double)giuaKy);
        cmd.Parameters.AddWithValue("@ck", (double)cuoiKy);
        cmd.Parameters.AddWithValue("@dtb", (double)dtb);
        cmd.Parameters.AddWithValue("@xl", xepLoai);
        cmd.Parameters.AddWithValue("@ht", hoanThanh ? 1 : 0);
        cmd.Parameters.AddWithValue("@nc", string.IsNullOrEmpty(ngayCap) ? (object)DBNull.Value : ngayCap);
        cmd.Parameters.AddWithValue("@makq", maKetQua);
        cmd.ExecuteNonQuery();
    }

    public (int TongHocVien, int LopDangChay, int TongGiaoVien, decimal DoanhThu, int SoCanhBaoVang) GetDashboardStats()
    {
        using var conn = DatabaseHelper.GetConnection();
        using var cmd = conn.CreateCommand();

        cmd.CommandText = "SELECT COUNT(*) FROM HocVien;";
        int tongHocVien = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

        cmd.CommandText = "SELECT COUNT(*) FROM LopHoc WHERE TrangThai = 'Đang học' OR TrangThai = 'Đang mở';";
        int lopDangChay = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

        cmd.CommandText = "SELECT COUNT(*) FROM GiaoVien;";
        int tongGiaoVien = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

        cmd.CommandText = "SELECT COALESCE(SUM(SoTienThu), 0) FROM BienLaiThuTien;";
        decimal doanhThu = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);

        cmd.CommandText = @"
            SELECT COUNT(*) FROM (
                SELECT MaHocVien FROM DiemDanh 
                WHERE TrangThai != 'Có mặt' 
                GROUP BY MaLop, MaHocVien 
                HAVING COUNT(*) >= 3
            );";
        int soCanhBaoVang = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);

        return (tongHocVien, lopDangChay, tongGiaoVien, doanhThu, soCanhBaoVang);
    }
}
