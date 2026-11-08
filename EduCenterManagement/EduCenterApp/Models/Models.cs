namespace EduCenterApp.Models;

public class KhoaHoc
{
    public string MaKhoaHoc { get; set; } = string.Empty;
    public string TenKhoaHoc { get; set; } = string.Empty;
    public decimal HocPhi { get; set; }
    public int SoBuoi { get; set; }
    public string MoTa { get; set; } = string.Empty;
}

public class PhongHoc
{
    public string MaPhong { get; set; } = string.Empty;
    public string TenPhong { get; set; } = string.Empty;
    public int SucChua { get; set; }
}

public class GiaoVien
{
    public string MaGiaoVien { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ChuyenMon { get; set; } = string.Empty;
}

public class HocVien
{
    public string MaHocVien { get; set; } = string.Empty;
    public string HoTen { get; set; } = string.Empty;
    public string NgaySinh { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string DiaChi { get; set; } = string.Empty;
    public string NgayThamGia { get; set; } = string.Empty;
    public bool IsHocVienCu { get; set; }
}

public class LopHoc
{
    public string MaLop { get; set; } = string.Empty;
    public string TenLop { get; set; } = string.Empty;
    public string MaKhoaHoc { get; set; } = string.Empty;
    public string TenKhoaHoc { get; set; } = string.Empty;
    public string MaGiaoVien { get; set; } = string.Empty;
    public string TenGiaoVien { get; set; } = string.Empty;
    public string MaPhong { get; set; } = string.Empty;
    public string TenPhong { get; set; } = string.Empty;
    public string ThuHoc { get; set; } = string.Empty; // e.g. "T2-T4-T6"
    public string CaHoc { get; set; } = string.Empty;
    public string GioBatDau { get; set; } = string.Empty;
    public string GioKetThuc { get; set; } = string.Empty;
    public int SiSoToiDa { get; set; }
    public int SiSoHienTai { get; set; }
    public string NgayKhaiGiang { get; set; } = string.Empty;
    public string TrangThai { get; set; } = "Đang mở";
}

public class DangKy
{
    public string MaDangKy { get; set; } = string.Empty;
    public string MaHocVien { get; set; } = string.Empty;
    public string TenHocVien { get; set; } = string.Empty;
    public string MaLop { get; set; } = string.Empty;
    public string TenLop { get; set; } = string.Empty;
    public string NgayDangKy { get; set; } = string.Empty;
    public decimal HocPhiGoc { get; set; }
    public string LoaiUuDai { get; set; } = string.Empty;
    public decimal PhanTramGiam { get; set; }
    public decimal SoTienGiam { get; set; }
    public decimal TongTienPhaiDong { get; set; }
    public decimal DaDong { get; set; }
    public decimal ConNo { get; set; }
    public string TrangThai { get; set; } = "Chưa hoàn tất";
}

public class BienLaiThuTien
{
    public string MaBienLai { get; set; } = string.Empty;
    public string MaDangKy { get; set; } = string.Empty;
    public string MaHocVien { get; set; } = string.Empty;
    public string TenHocVien { get; set; } = string.Empty;
    public string MaLop { get; set; } = string.Empty;
    public string TenLop { get; set; } = string.Empty;
    public decimal SoTienThu { get; set; }
    public int DotThu { get; set; }
    public string HinhThucThanhToan { get; set; } = "Tiền mặt";
    public string NgayThu { get; set; } = string.Empty;
    public string NguoiThu { get; set; } = string.Empty;
    public string GhiChu { get; set; } = string.Empty;
}

public class DiemDanhItem
{
    public string MaDiemDanh { get; set; } = string.Empty;
    public string MaLop { get; set; } = string.Empty;
    public string MaHocVien { get; set; } = string.Empty;
    public string TenHocVien { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public int BuoiSo { get; set; }
    public string NgayDiemDanh { get; set; } = string.Empty;
    public string TrangThai { get; set; } = "Có mặt"; // Có mặt, Vắng có phép, Vắng không phép
    public string GhiChu { get; set; } = string.Empty;
    public int TongSoBuoiVang { get; set; }
    public bool CanCanhBaoVang { get; set; }
}

public class KetQuaHocTap
{
    public string MaKetQua { get; set; } = string.Empty;
    public string MaLop { get; set; } = string.Empty;
    public string TenLop { get; set; } = string.Empty;
    public string MaHocVien { get; set; } = string.Empty;
    public string TenHocVien { get; set; } = string.Empty;
    public decimal DiemChuyenCan { get; set; }
    public decimal DiemGiuaKy { get; set; }
    public decimal DiemCuoiKy { get; set; }
    public decimal DiemTrungBinh { get; set; }
    public string XepLoai { get; set; } = "Chưa xếp loại";
    public bool TrangThaiHoanThanh { get; set; }
    public string NgayCapChungNhan { get; set; } = string.Empty;
}

public class TaiKhoan
{
    public string TenDangNhap { get; set; } = string.Empty;
    public string MatKhau { get; set; } = string.Empty;
    public string VaiTro { get; set; } = "Quản trị viên";
    public string HoTen { get; set; } = string.Empty;
    public string MaLienKet { get; set; } = string.Empty;
}

public class XungDotLichHoc
{
    public bool HasConflict { get; set; }
    public string LoaiXungDot { get; set; } = string.Empty;
    public string ChiTiet { get; set; } = string.Empty;
    public LopHoc? LopBiTrung { get; set; }
}
