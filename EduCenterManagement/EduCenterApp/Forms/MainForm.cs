using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EduCenterApp.Database;
using EduCenterApp.Models;
using EduCenterApp.Services;

namespace EduCenterApp.Forms;

public partial class MainForm : Form
{
    private readonly EduCenterService _service;
    private readonly string _currentUserRole;
    private bool _isNewKhoaHoc = false;
    private bool _isNewLopHoc = false;

    private List<KhoaHoc> _listKhoaHoc = new();
    private List<LopHoc> _listLopHoc = new();
    private List<HocVien> _listHocVien = new();
    private List<PhongHoc> _listPhongHoc = new();
    private List<GiaoVien> _listGiaoVien = new();
    private List<DangKy> _listDangKy = new();
    private List<BienLaiThuTien> _listBienLai = new();
    private List<DiemDanhItem> _listDiemDanh = new();
    private List<KetQuaHocTap> _listKetQua = new();

    public MainForm(string userRole = "Quản trị viên")
    {
        _currentUserRole = userRole;
        _service = new EduCenterService();

        InitializeComponent();
        SetupCustomStyling();
        SetupNavigation();
        SetupEventHandlers();
        
        this.Load += MainForm_Load;
    }

    private void SetupCustomStyling()
    {
        this.Text = "EduCenter Pro - Hệ thống Quản lý Trung tâm Tiếng Anh & Đào tạo";
        lblUserName.Text = _currentUserRole.Equals("Giáo viên", StringComparison.OrdinalIgnoreCase) ? "Thầy Nguyễn Hùng" : "Admin Quản trị";
        lblUserRole.Text = _currentUserRole;
        lblHeaderGreeting.Text = $"Xin chào, {lblUserName.Text}!";
        lblHeaderDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy", new System.Globalization.CultureInfo("vi-VN"));

        // Hide raw tab control headers for clean Figma-like appearance
        tabMain.Appearance = TabAppearance.FlatButtons;
        tabMain.ItemSize = new Size(0, 1);
        tabMain.SizeMode = TabSizeMode.Fixed;

        // Navicat guide text
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "EduCenter.db");
        string sqlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "EduCenter_Schema.sql");
        txtNavicatGuide.Text = 
            "=== HƯỚNG DẪN KẾT NỐI NAVICAT CHO SQLITE ===\r\n\r\n" +
            "1. Mở phần mềm Navicat Premium hoặc Navicat for SQLite.\r\n" +
            "2. Nhấn vào Connection -> Chọn 'SQLite...'\r\n" +
            "3. Đặt 'Connection Name': EduCenter_SQLite\r\n" +
            "4. Mục 'Database File': Bấm Browse [...] và chọn file EduCenter.db tại đường dẫn:\r\n" +
            $"   {dbPath}\r\n" +
            "5. Bấm 'Test Connection' -> Hiện 'Connection Successful' -> Bấm OK để lưu.\r\n" +
            "6. Bạn có thể xem cấu trúc bảng, truy vấn SQL, export/import dữ liệu trực tiếp song song với ứng dụng C#.\r\n\r\n" +
            "=== FILE SCRIPT TẠO DATABASE (SCHEMA) ===\r\n" +
            $"Tệp mã nguồn SQL DDL đầy đủ được lưu tại:\r\n{sqlPath}\r\n" +
            "Bạn có thể mở tệp này trong Navicat Query Editor để thực thi hoặc xuất báo cáo.";
    }

    private void SetupNavigation()
    {
        btnNavDashboard.Click += (s, e) => SwitchTab(tabDashboard, btnNavDashboard);
        btnNavCourses.Click += (s, e) => SwitchTab(tabCourses, btnNavCourses);
        btnNavSchedule.Click += (s, e) => SwitchTab(tabSchedule, btnNavSchedule);
        btnNavTuition.Click += (s, e) => SwitchTab(tabTuition, btnNavTuition);
        btnNavAttendance.Click += (s, e) => SwitchTab(tabAttendance, btnNavAttendance);
        btnNavGrades.Click += (s, e) => SwitchTab(tabGrades, btnNavGrades);
        btnNavDatabase.Click += (s, e) => SwitchTab(tabDatabase, btnNavDatabase);

        btnViewAlertDetail.Click += (s, e) => SwitchTab(tabAttendance, btnNavAttendance);
        lblAlertBadge.Click += (s, e) => SwitchTab(tabAttendance, btnNavAttendance);

        btnLogout.Click += (s, e) =>
        {
            var res = MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        };
    }

    private void SwitchTab(TabPage targetTab, Button activeButton)
    {
        tabMain.SelectedTab = targetTab;

        Button[] navButtons = new[]
        {
            btnNavDashboard, btnNavCourses, btnNavSchedule,
            btnNavTuition, btnNavAttendance, btnNavGrades, btnNavDatabase
        };

        foreach (var btn in navButtons)
        {
            if (btn == activeButton)
            {
                btn.BackColor = Color.FromArgb(37, 99, 235); // Active Blue
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.FromArgb(203, 213, 225);
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            }
        }

        // On-demand refresh for tabs
        if (targetTab == tabDashboard) RefreshDashboard();
        else if (targetTab == tabCourses) RefreshCoursesAndClasses();
        else if (targetTab == tabSchedule) RefreshScheduleTab();
        else if (targetTab == tabTuition) RefreshTuitionTab();
        else if (targetTab == tabAttendance) RefreshAttendanceTab();
        else if (targetTab == tabGrades) RefreshGradesTab();
    }

    private void SetupEventHandlers()
    {
        // Tab Courses & Classes
        dgvKhoaHoc.SelectionChanged += DgvKhoaHoc_SelectionChanged;
        btnNewKH.Click += BtnNewKH_Click;
        btnSaveKH.Click += BtnSaveKH_Click;
        btnDeleteKH.Click += BtnDeleteKH_Click;

        dgvLopHoc.SelectionChanged += DgvLopHoc_SelectionChanged;
        btnNewLop.Click += BtnNewLop_Click;
        btnSaveLop.Click += BtnSaveLop_Click;
        btnDeleteLop.Click += BtnDeleteLop_Click;

        // Tab Schedule
        btnCheckConflict.Click += BtnCheckConflict_Click;

        // Tab Tuition
        cboRegHocVien.SelectedIndexChanged += CboRegHocVien_SelectedIndexChanged;
        cboRegLop.SelectedIndexChanged += CboRegLop_SelectedIndexChanged;
        chkOldStudentDiscount.CheckedChanged += (s, e) => RecalculateTuitionForm();
        chkGroupDiscount.CheckedChanged += (s, e) =>
        {
            numGroupPercent.Enabled = chkGroupDiscount.Checked;
            RecalculateTuitionForm();
        };
        numGroupPercent.ValueChanged += (s, e) => RecalculateTuitionForm();
        btnQuickAddHV.Click += BtnQuickAddHV_Click;
        btnRegisterAndPrint.Click += BtnRegisterAndPrint_Click;
        btnPayNextInstallment.Click += BtnPayNextInstallment_Click;
        btnReprintReceipt.Click += BtnReprintReceipt_Click;

        // Tab Attendance
        btnLoadAttendance.Click += (s, e) => LoadAttendanceList();
        btnSaveAttendance.Click += BtnSaveAttendance_Click;
        dgvAttendance.RowPrePaint += DgvAttendance_RowPrePaint;

        // Tab Grades
        btnLoadGrades.Click += (s, e) => LoadGradesList();
        btnSaveGrades.Click += BtnSaveGrades_Click;
        btnPrintCertificate.Click += BtnPrintCertificate_Click;
        dgvGrades.CellValueChanged += DgvGrades_CellValueChanged;

        // Tab Database
        btnOpenDbFolder.Click += (s, e) =>
        {
            string dbFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            if (!Directory.Exists(dbFolder)) Directory.CreateDirectory(dbFolder);
            Process.Start(new ProcessStartInfo("explorer.exe", dbFolder) { UseShellExecute = true });
        };

        btnReloadSampleData.Click += (s, e) =>
        {
            var res = MessageBox.Show(
                "Bạn có chắc muốn nạp lại dữ liệu mẫu? Toàn bộ thay đổi thêm mới sẽ được khôi phục về trạng thái mẫu ban đầu.",
                "Xác nhận khôi phục mẫu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                DatabaseHelper.ResetSampleData();
                RefreshDashboard();
                MessageBox.Show("Đã nạp lại dữ liệu mẫu SQLite thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        SwitchTab(tabDashboard, btnNavDashboard);
    }

    #region 1. DASHBOARD LOGIC
    private void RefreshDashboard()
    {
        try
        {
            var stats = _service.GetDashboardStats();
            lblStat1Val.Text = stats.TongHocVien.ToString("N0");
            lblStat2Val.Text = stats.LopDangChay.ToString("N0");
            lblStat3Val.Text = stats.TongGiaoVien.ToString("N0");
            lblStat4Val.Text = $"{stats.DoanhThu:N0} đ";

            lblAlertBadge.Text = stats.SoCanhBaoVang.ToString();
            if (stats.SoCanhBaoVang > 0)
            {
                pnlBannerAlert.BackColor = Color.FromArgb(254, 242, 242);
                lblAlertText.ForeColor = Color.FromArgb(185, 28, 28);
                lblAlertText.Text = $"⚠️ CẢNH BÁO CHUYÊN CẦN: Có {stats.SoCanhBaoVang} học viên vắng từ 3 buổi học trở lên! Lễ tân cần kiểm tra danh sách và gọi điện thoại hỗ trợ học viên.";
                lblAlertBadge.Visible = true;
            }
            else
            {
                pnlBannerAlert.BackColor = Color.FromArgb(240, 253, 244);
                lblAlertText.ForeColor = Color.FromArgb(22, 101, 52);
                lblAlertText.Text = "✅ Tình hình chuyên cần ổn định: Hiện không có học viên nào vắng quá 3 buổi học.";
                lblAlertBadge.Visible = false;
            }

            // Load upcoming class list
            var classes = _service.GetAllLopHoc();
            dgvDashClasses.DataSource = classes.Select(c => new
            {
                Mã_Lớp = c.MaLop,
                Tên_Lớp = c.TenLop,
                Khóa_Học = c.TenKhoaHoc,
                Giáo_Viên = c.TenGiaoVien,
                Phòng = c.TenPhong,
                Lịch_Học = $"{c.ThuHoc} ({c.GioBatDau} - {c.GioKetThuc})",
                Sĩ_Số = $"{c.SiSoHienTai}/{c.SiSoToiDa}",
                Trạng_Thái = c.TrangThai
            }).ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải Dashboard: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion

    #region 2. COURSES & CLASSES LOGIC
    private void RefreshCoursesAndClasses()
    {
        try
        {
            _listKhoaHoc = _service.GetAllKhoaHoc();
            dgvKhoaHoc.DataSource = null;
            dgvKhoaHoc.DataSource = _listKhoaHoc.Select(k => new
            {
                Mã_Khóa = k.MaKhoaHoc,
                Tên_Khóa_Học = k.TenKhoaHoc,
                Học_Phí = $"{k.HocPhi:N0} đ",
                Số_Buổi = k.SoBuoi,
                Mô_Tả = k.MoTa
            }).ToList();

            _listLopHoc = _service.GetAllLopHoc();
            dgvLopHoc.DataSource = null;
            dgvLopHoc.DataSource = _listLopHoc.Select(l => new
            {
                Mã_Lớp = l.MaLop,
                Tên_Lớp = l.TenLop,
                Khóa_Học = l.TenKhoaHoc,
                Giáo_Viên = l.TenGiaoVien,
                Phòng = l.TenPhong,
                Thứ = l.ThuHoc,
                Giờ_Học = $"{l.GioBatDau} - {l.GioKetThuc}",
                Sĩ_Số = $"{l.SiSoHienTai}/{l.SiSoToiDa}",
                Khai_Giảng = l.NgayKhaiGiang,
                Trạng_Thái = l.TrangThai
            }).ToList();

            // Populate Dropdowns
            _listPhongHoc = _service.GetAllPhongHoc();
            _listGiaoVien = _service.GetAllGiaoVien();

            cboLopKhoaHoc.DataSource = null;
            cboLopKhoaHoc.DataSource = _listKhoaHoc;
            cboLopKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboLopKhoaHoc.ValueMember = "MaKhoaHoc";

            cboLopGiaoVien.DataSource = null;
            cboLopGiaoVien.DataSource = _listGiaoVien;
            cboLopGiaoVien.DisplayMember = "HoTen";
            cboLopGiaoVien.ValueMember = "MaGiaoVien";

            cboLopPhong.DataSource = null;
            cboLopPhong.DataSource = _listPhongHoc;
            cboLopPhong.DisplayMember = "TenPhong";
            cboLopPhong.ValueMember = "MaPhong";

            cboLopThu.Items.Clear();
            cboLopThu.Items.AddRange(new object[] { "T2-T4-T6", "T3-T5-T7", "T7-CN", "T2-T5", "T3-T6", "Hàng ngày" });
            if (cboLopThu.Items.Count > 0) cboLopThu.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi tải danh mục Khóa học / Lớp học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void DgvKhoaHoc_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvKhoaHoc.CurrentRow == null || dgvKhoaHoc.CurrentRow.Index < 0) return;
        int idx = dgvKhoaHoc.CurrentRow.Index;
        if (idx < _listKhoaHoc.Count)
        {
            var kh = _listKhoaHoc[idx];
            txtMaKH.Text = kh.MaKhoaHoc;
            txtMaKH.ReadOnly = true;
            txtTenKH.Text = kh.TenKhoaHoc;
            numHocPhiKH.Value = kh.HocPhi;
            numSoBuoiKH.Value = kh.SoBuoi;
            txtMoTaKH.Text = kh.MoTa;
            _isNewKhoaHoc = false;
        }
    }

    private void BtnNewKH_Click(object? sender, EventArgs e)
    {
        _isNewKhoaHoc = true;
        txtMaKH.ReadOnly = false;
        txtMaKH.Text = "KH" + (new Random().Next(100, 999));
        txtTenKH.Clear();
        numHocPhiKH.Value = 3500000;
        numSoBuoiKH.Value = 24;
        txtMoTaKH.Clear();
        txtTenKH.Focus();
    }

    private void BtnSaveKH_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaKH.Text) || string.IsNullOrWhiteSpace(txtTenKH.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ Mã khóa học và Tên khóa học!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var kh = new KhoaHoc
        {
            MaKhoaHoc = txtMaKH.Text.Trim(),
            TenKhoaHoc = txtTenKH.Text.Trim(),
            HocPhi = numHocPhiKH.Value,
            SoBuoi = (int)numSoBuoiKH.Value,
            MoTa = txtMoTaKH.Text.Trim()
        };

        try
        {
            _service.SaveKhoaHoc(kh, _isNewKhoaHoc);
            MessageBox.Show("Đã lưu thông tin khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshCoursesAndClasses();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi lưu khóa học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnDeleteKH_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaKH.Text)) return;
        var res = MessageBox.Show($"Bạn có chắc chắn muốn xóa khóa học '{txtTenKH.Text}' ({txtMaKH.Text})?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
            try
            {
                _service.DeleteKhoaHoc(txtMaKH.Text);
                MessageBox.Show("Đã xóa khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCoursesAndClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xóa khóa học (có thể đang có lớp học thuộc khóa này): {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void DgvLopHoc_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvLopHoc.CurrentRow == null || dgvLopHoc.CurrentRow.Index < 0) return;
        int idx = dgvLopHoc.CurrentRow.Index;
        if (idx < _listLopHoc.Count)
        {
            var lop = _listLopHoc[idx];
            txtMaLop.Text = lop.MaLop;
            txtMaLop.ReadOnly = true;
            txtTenLop.Text = lop.TenLop;
            if (cboLopKhoaHoc.DataSource != null) cboLopKhoaHoc.SelectedValue = lop.MaKhoaHoc;
            if (cboLopGiaoVien.DataSource != null) cboLopGiaoVien.SelectedValue = lop.MaGiaoVien;
            if (cboLopPhong.DataSource != null) cboLopPhong.SelectedValue = lop.MaPhong;
            cboLopThu.Text = lop.ThuHoc;
            txtLopGioBD.Text = lop.GioBatDau;
            txtLopGioKT.Text = lop.GioKetThuc;
            numLopSiSo.Value = Math.Max(1, lop.SiSoToiDa);
            if (DateTime.TryParse(lop.NgayKhaiGiang, out var dt)) dtpLopKhaiGiang.Value = dt;
            _isNewLopHoc = false;
        }
    }

    private void BtnNewLop_Click(object? sender, EventArgs e)
    {
        _isNewLopHoc = true;
        txtMaLop.ReadOnly = false;
        txtMaLop.Text = "LH" + (new Random().Next(100, 999));
        txtTenLop.Text = "Lớp Mới - " + DateTime.Now.ToString("MM/yy");
        numLopSiSo.Value = 20;
        txtLopGioBD.Text = "18:00";
        txtLopGioKT.Text = "20:00";
        txtTenLop.Focus();
    }

    private void BtnSaveLop_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ Mã lớp và Tên lớp!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string maPhong = cboLopPhong.SelectedValue?.ToString() ?? "";
        string maGV = cboLopGiaoVien.SelectedValue?.ToString() ?? "";
        string thu = cboLopThu.Text;
        string gioBD = txtLopGioBD.Text.Trim();
        string gioKT = txtLopGioKT.Text.Trim();

        // Check for schedule conflicts (room & teacher)
        var conflict = _service.CheckScheduleConflict(_isNewLopHoc ? null : txtMaLop.Text.Trim(), maPhong, maGV, thu, gioBD, gioKT);
        if (conflict.HasConflict)
        {
            var res = MessageBox.Show(
                $"{conflict.ChiTiet}\r\n\r\nBạn có muốn điều chỉnh lại giờ/phòng học không?",
                "Cảnh báo xếp lịch học (Trùng phòng / Trùng giáo viên)",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var lop = new LopHoc
        {
            MaLop = txtMaLop.Text.Trim(),
            TenLop = txtTenLop.Text.Trim(),
            MaKhoaHoc = cboLopKhoaHoc.SelectedValue?.ToString() ?? "",
            MaGiaoVien = maGV,
            MaPhong = maPhong,
            ThuHoc = thu,
            CaHoc = "Ca tối",
            GioBatDau = gioBD,
            GioKetThuc = gioKT,
            SiSoToiDa = (int)numLopSiSo.Value,
            NgayKhaiGiang = dtpLopKhaiGiang.Value.ToString("yyyy-MM-dd"),
            TrangThai = "Đang mở"
        };

        try
        {
            _service.SaveLopHoc(lop, _isNewLopHoc);
            MessageBox.Show("Đã lưu thông tin lớp học thành công! (Không có xung đột phòng hoặc giáo viên)", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshCoursesAndClasses();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi lưu lớp học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnDeleteLop_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaLop.Text)) return;
        var res = MessageBox.Show($"Bạn có chắc chắn muốn xóa lớp học '{txtTenLop.Text}' ({txtMaLop.Text})?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
            try
            {
                _service.DeleteLopHoc(txtMaLop.Text);
                MessageBox.Show("Đã xóa lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCoursesAndClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xóa lớp học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    #endregion

    #region 3. SCHEDULE & CONFLICT CHECK LOGIC
    private void RefreshScheduleTab()
    {
        _listPhongHoc = _service.GetAllPhongHoc();
        _listGiaoVien = _service.GetAllGiaoVien();
        _listLopHoc = _service.GetAllLopHoc();

        cboSchedPhong.DataSource = null;
        cboSchedPhong.DataSource = _listPhongHoc;
        cboSchedPhong.DisplayMember = "TenPhong";
        cboSchedPhong.ValueMember = "MaPhong";

        cboSchedGV.DataSource = null;
        cboSchedGV.DataSource = _listGiaoVien;
        cboSchedGV.DisplayMember = "HoTen";
        cboSchedGV.ValueMember = "MaGiaoVien";

        cboSchedThu.Items.Clear();
        cboSchedThu.Items.AddRange(new object[] { "T2-T4-T6", "T3-T5-T7", "T7-CN", "T2-T5", "T3-T6", "Hàng ngày" });
        if (cboSchedThu.Items.Count > 0) cboSchedThu.SelectedIndex = 0;

        dgvAllSchedules.DataSource = null;
        dgvAllSchedules.DataSource = _listLopHoc.Select(l => new
        {
            Mã_Lớp = l.MaLop,
            Tên_Lớp = l.TenLop,
            Phòng_Học = l.TenPhong,
            Giáo_Viên_Phụ_Trách = l.TenGiaoVien,
            Thứ_Học = l.ThuHoc,
            Giờ_Học = $"{l.GioBatDau} - {l.GioKetThuc}",
            Sĩ_Số = $"{l.SiSoHienTai}/{l.SiSoToiDa} HV",
            Trạng_Thái = l.TrangThai
        }).ToList();
    }

    private void BtnCheckConflict_Click(object? sender, EventArgs e)
    {
        string maPhong = cboSchedPhong.SelectedValue?.ToString() ?? "";
        string maGV = cboSchedGV.SelectedValue?.ToString() ?? "";
        string thu = cboSchedThu.Text;
        string gioBD = txtSchedGioBD.Text.Trim();
        string gioKT = txtSchedGioKT.Text.Trim();

        var conflict = _service.CheckScheduleConflict(null, maPhong, maGV, thu, gioBD, gioKT);

        if (conflict.HasConflict)
        {
            pnlConflictAlertBox.BackColor = Color.FromArgb(254, 226, 226); // Light red
            lblConflictResult.ForeColor = Color.FromArgb(185, 28, 28);
            lblConflictResult.Text = conflict.ChiTiet;
        }
        else
        {
            pnlConflictAlertBox.BackColor = Color.FromArgb(220, 252, 231); // Light green
            lblConflictResult.ForeColor = Color.FromArgb(21, 128, 61);
            lblConflictResult.Text = $"✅ HỢP LỆ — KHÔNG CÓ XUNG ĐỘT!\nPhòng '{cboSchedPhong.Text}' và Giáo viên '{cboSchedGV.Text}' đều hoàn toàn sẵn sàng vào {thu} ({gioBD} - {gioKT}). Có thể mở lớp an toàn!";
        }
    }
    #endregion

    #region 4. REGISTRATION & TUITION LOGIC
    private void RefreshTuitionTab()
    {
        _listHocVien = _service.GetAllHocVien();
        _listLopHoc = _service.GetAllLopHoc();
        _listDangKy = _service.GetAllDangKy();
        _listBienLai = _service.GetAllBienLai();

        cboRegHocVien.DataSource = null;
        cboRegHocVien.DataSource = _listHocVien;
        cboRegHocVien.DisplayMember = "HoTen";
        cboRegHocVien.ValueMember = "MaHocVien";

        cboRegLop.DataSource = null;
        cboRegLop.DataSource = _listLopHoc;
        cboRegLop.DisplayMember = "TenLop";
        cboRegLop.ValueMember = "MaLop";

        cboRegPaymentMethod.Items.Clear();
        cboRegPaymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản QR", "Thẻ ngân hàng", "Ví điện tử" });
        cboRegPaymentMethod.SelectedIndex = 1;

        dgvDangKy.DataSource = null;
        dgvDangKy.DataSource = _listDangKy.Select(d => new
        {
            Mã_ĐK = d.MaDangKy,
            Học_Viên = d.TenHocVien,
            Mã_HV = d.MaHocVien,
            Lớp_Học = d.TenLop,
            Ngày_ĐK = d.NgayDangKy,
            Học_Phí_Gốc = $"{d.HocPhiGoc:N0} đ",
            Ưu_Đãi = d.LoaiUuDai,
            Giảm_Giá = $"-{d.PhanTramGiam:N0}% ({d.SoTienGiam:N0} đ)",
            Tổng_Phải_Đóng = $"{d.TongTienPhaiDong:N0} đ",
            Đã_Đóng = $"{d.DaDong:N0} đ",
            Còn_Nợ = $"{d.ConNo:N0} đ",
            Trạng_Thái = d.TrangThai
        }).ToList();

        dgvBienLai.DataSource = null;
        dgvBienLai.DataSource = _listBienLai.Select(b => new
        {
            Mã_Biên_Lai = b.MaBienLai,
            Mã_ĐK = b.MaDangKy,
            Học_Viên = b.TenHocVien,
            Lớp_Học = b.TenLop,
            Số_Tiền = $"{b.SoTienThu:N0} đ",
            Đợt_Thu = $"Đợt {b.DotThu}",
            Hình_Thức = b.HinhThucThanhToan,
            Ngày_Thu = b.NgayThu,
            Người_Thu = b.NguoiThu,
            Ghi_Chú = b.GhiChu
        }).ToList();
    }

    private void CboRegHocVien_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboRegHocVien.SelectedItem is HocVien hv)
        {
            chkOldStudentDiscount.Checked = hv.IsHocVienCu;
            RecalculateTuitionForm();
        }
    }

    private void CboRegLop_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboRegLop.SelectedItem is LopHoc lop)
        {
            var kh = _service.GetAllKhoaHoc().FirstOrDefault(k => k.MaKhoaHoc == lop.MaKhoaHoc);
            decimal hocPhi = kh?.HocPhi ?? 0;
            txtRegHocPhiGoc.Text = $"{hocPhi:N0} đ";
            txtRegHocPhiGoc.Tag = hocPhi;
            RecalculateTuitionForm();
        }
    }

    private void RecalculateTuitionForm()
    {
        decimal hocPhiGoc = txtRegHocPhiGoc.Tag is decimal val ? val : 0;
        decimal discountPercent = 0;

        if (chkOldStudentDiscount.Checked) discountPercent += 10m;
        if (chkGroupDiscount.Checked) discountPercent += numGroupPercent.Value;

        if (discountPercent > 100m) discountPercent = 100m;

        decimal discountAmount = hocPhiGoc * (discountPercent / 100m);
        decimal finalFee = hocPhiGoc - discountAmount;

        txtRegTotalFee.Text = $"{finalFee:N0} đ (Giảm {discountPercent:N0}%)";
        txtRegTotalFee.Tag = finalFee;

        // Default pay full or half
        numRegPayAmount.Maximum = 100000000;
        numRegPayAmount.Value = finalFee;
    }

    private void BtnQuickAddHV_Click(object? sender, EventArgs e)
    {
        using var prompt = new Form();
        prompt.Width = 420;
        prompt.Height = 330;
        prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
        prompt.Text = "Thêm nhanh học viên mới";
        prompt.StartPosition = FormStartPosition.CenterParent;
        prompt.BackColor = Color.White;

        var lblName = new Label { Left = 24, Top = 20, Text = "Họ và tên học viên:", AutoSize = true, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) };
        var txtName = new TextBox { Left = 24, Top = 45, Width = 350, Font = new Font("Segoe UI", 10F) };

        var lblPhone = new Label { Left = 24, Top = 80, Text = "Số điện thoại:", AutoSize = true, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) };
        var txtPhone = new TextBox { Left = 24, Top = 105, Width = 350, Font = new Font("Segoe UI", 10F) };

        var lblEmail = new Label { Left = 24, Top = 140, Text = "Email:", AutoSize = true, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) };
        var txtEmail = new TextBox { Left = 24, Top = 165, Width = 350, Font = new Font("Segoe UI", 10F) };

        var chkOld = new CheckBox { Left = 24, Top = 200, Text = "Là học viên cũ (được giảm 10% học phí)", AutoSize = true, Font = new Font("Segoe UI", 9.5F) };

        var btnOk = new Button { Text = "Thêm học viên", Left = 170, Width = 110, Top = 235, Height = 36, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(37, 99, 235), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        var btnCancel = new Button { Text = "Hủy", Left = 290, Width = 84, Top = 235, Height = 36, DialogResult = DialogResult.Cancel, BackColor = Color.FromArgb(241, 245, 249), FlatStyle = FlatStyle.Flat };

        prompt.Controls.AddRange(new Control[] { lblName, txtName, lblPhone, txtPhone, lblEmail, txtEmail, chkOld, btnOk, btnCancel });
        prompt.AcceptButton = btnOk;
        prompt.CancelButton = btnCancel;

        if (prompt.ShowDialog(this) == DialogResult.OK)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newHv = new HocVien
            {
                MaHocVien = "HV" + (new Random().Next(100, 999)),
                HoTen = txtName.Text.Trim(),
                SoDienThoai = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                IsHocVienCu = chkOld.Checked
            };

            _service.AddHocVien(newHv);
            RefreshTuitionTab();
            cboRegHocVien.SelectedValue = newHv.MaHocVien;
            MessageBox.Show($"Đã thêm học viên {newHv.HoTen} ({newHv.MaHocVien}) thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void BtnRegisterAndPrint_Click(object? sender, EventArgs e)
    {
        if (cboRegHocVien.SelectedValue == null || cboRegLop.SelectedValue == null)
        {
            MessageBox.Show("Vui lòng chọn học viên và lớp học cần đăng ký!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string maHv = cboRegHocVien.SelectedValue.ToString()!;
        string maLop = cboRegLop.SelectedValue.ToString()!;

        decimal discountPercent = 0;
        string discountReason = "Không giảm";
        if (chkOldStudentDiscount.Checked && chkGroupDiscount.Checked)
        {
            discountPercent = 10m + numGroupPercent.Value;
            discountReason = $"HV cũ (10%) + Nhóm ({numGroupPercent.Value}%)";
        }
        else if (chkOldStudentDiscount.Checked)
        {
            discountPercent = 10m;
            discountReason = "Ưu đãi học viên cũ (10%)";
        }
        else if (chkGroupDiscount.Checked)
        {
            discountPercent = numGroupPercent.Value;
            discountReason = $"Đăng ký nhóm ({numGroupPercent.Value}%)";
        }

        decimal soTienDong = numRegPayAmount.Value;
        string hinhThucTT = cboRegPaymentMethod.Text;

        try
        {
            var bienLai = _service.RegisterStudent(maHv, maLop, discountReason, discountPercent, soTienDong, hinhThucTT, lblUserName.Text, "Thu học phí khi đăng ký lớp");
            RefreshTuitionTab();

            // In biên lai thu tiền với QR Code
            using var receiptDlg = new ReceiptForm(bienLai);
            receiptDlg.ShowDialog(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi đăng ký / thu học phí: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnPayNextInstallment_Click(object? sender, EventArgs e)
    {
        if (dgvDangKy.CurrentRow == null || dgvDangKy.CurrentRow.Index < 0)
        {
            MessageBox.Show("Vui lòng chọn một dòng đăng ký cần đóng học phí đợt tiếp theo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int idx = dgvDangKy.CurrentRow.Index;
        if (idx >= _listDangKy.Count) return;
        var dk = _listDangKy[idx];

        if (dk.ConNo <= 0)
        {
            MessageBox.Show($"Học viên '{dk.TenHocVien}' đã hoàn thành 100% học phí lớp '{dk.TenLop}', không còn nợ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var prompt = new Form();
        prompt.Width = 420;
        prompt.Height = 270;
        prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
        prompt.Text = "Thu học phí đợt tiếp theo";
        prompt.StartPosition = FormStartPosition.CenterParent;
        prompt.BackColor = Color.White;

        var lblInfo = new Label { Left = 24, Top = 16, Width = 360, Height = 40, Text = $"Học viên: {dk.TenHocVien} - Lớp: {dk.TenLop}\nSố tiền còn nợ: {dk.ConNo:N0} VNĐ", Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) };
        var lblAmount = new Label { Left = 24, Top = 65, Text = "Số tiền thu đợt này (VNĐ):", AutoSize = true, Font = new Font("Segoe UI", 9.5F) };
        var numAmount = new NumericUpDown { Left = 24, Top = 90, Width = 350, Maximum = 100000000, Value = dk.ConNo, Increment = 500000, ThousandsSeparator = true, Font = new Font("Segoe UI", 11F, FontStyle.Bold) };

        var lblMethod = new Label { Left = 24, Top = 125, Text = "Hình thức thanh toán:", AutoSize = true, Font = new Font("Segoe UI", 9.5F) };
        var cboMethod = new ComboBox { Left = 24, Top = 150, Width = 350, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 9.5F) };
        cboMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản QR", "Thẻ ngân hàng", "Ví điện tử" });
        cboMethod.SelectedIndex = 1;

        var btnOk = new Button { Text = "Xác nhận thu tiền", Left = 150, Width = 130, Top = 185, Height = 36, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(37, 99, 235), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
        var btnCancel = new Button { Text = "Hủy", Left = 290, Width = 84, Top = 185, Height = 36, DialogResult = DialogResult.Cancel, BackColor = Color.FromArgb(241, 245, 249), FlatStyle = FlatStyle.Flat };

        prompt.Controls.AddRange(new Control[] { lblInfo, lblAmount, numAmount, lblMethod, cboMethod, btnOk, btnCancel });

        if (prompt.ShowDialog(this) == DialogResult.OK)
        {
            try
            {
                var receipt = _service.RecordTuitionPayment(dk.MaDangKy, numAmount.Value, cboMethod.Text, lblUserName.Text, $"Thu học phí đợt tiếp theo");
                RefreshTuitionTab();

                using var receiptDlg = new ReceiptForm(receipt);
                receiptDlg.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thu tiền đợt tiếp theo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void BtnReprintReceipt_Click(object? sender, EventArgs e)
    {
        if (dgvBienLai.CurrentRow == null || dgvBienLai.CurrentRow.Index < 0)
        {
            MessageBox.Show("Vui lòng chọn một biên lai cần in lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int idx = dgvBienLai.CurrentRow.Index;
        if (idx >= _listBienLai.Count) return;
        var bl = _listBienLai[idx];

        using var receiptDlg = new ReceiptForm(bl);
        receiptDlg.ShowDialog(this);
    }
    #endregion

    #region 5. ATTENDANCE & WARNING LOGIC
    private void RefreshAttendanceTab()
    {
        _listLopHoc = _service.GetAllLopHoc();
        cboAttLop.DataSource = null;
        cboAttLop.DataSource = _listLopHoc;
        cboAttLop.DisplayMember = "TenLop";
        cboAttLop.ValueMember = "MaLop";

        LoadAttendanceList();
        LoadWarningAbsences();
    }

    private void LoadAttendanceList()
    {
        if (cboAttLop.SelectedValue == null) return;
        string maLop = cboAttLop.SelectedValue.ToString()!;
        int buoiSo = (int)numAttBuoi.Value;
        string ngay = dtpAttNgay.Value.ToString("yyyy-MM-dd");

        _listDiemDanh = _service.GetDiemDanh(maLop, buoiSo, ngay);

        dgvAttendance.Columns.Clear();
        dgvAttendance.AutoGenerateColumns = false;

        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaHocVien", HeaderText = "Mã HV", Width = 90, ReadOnly = true });
        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenHocVien", HeaderText = "Họ và Tên", Width = 180, ReadOnly = true });
        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "Số Điện Thoại", Width = 110, ReadOnly = true });

        var cboCol = new DataGridViewComboBoxColumn
        {
            DataPropertyName = "TrangThai",
            HeaderText = "Trạng Thái Điểm Danh",
            Width = 160
        };
        cboCol.Items.AddRange("Có mặt", "Vắng có phép", "Vắng không phép");
        dgvAttendance.Columns.Add(cboCol);

        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TongSoBuoiVang", HeaderText = "Tổng Số Buổi Vắng", Width = 120, ReadOnly = true });
        dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GhiChu", HeaderText = "Ghi Chú", Width = 200 });

        dgvAttendance.DataSource = new BindingSource { DataSource = _listDiemDanh };
    }

    private void DgvAttendance_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _listDiemDanh.Count) return;
        var item = _listDiemDanh[e.RowIndex];
        if (item.CanCanhBaoVang || item.TongSoBuoiVang >= 3)
        {
            dgvAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226); // Soft red highlight
            dgvAttendance.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(185, 28, 28);
            dgvAttendance.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }
        else
        {
            dgvAttendance.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            dgvAttendance.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvAttendance.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }
    }

    private void BtnSaveAttendance_Click(object? sender, EventArgs e)
    {
        try
        {
            dgvAttendance.EndEdit();
            _service.SaveDiemDanh(_listDiemDanh);
            MessageBox.Show("Đã lưu bảng điểm danh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAttendanceList();
            LoadWarningAbsences();
            RefreshDashboard();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi lưu điểm danh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadWarningAbsences()
    {
        var warningList = _service.GetDanhSachCanhBaoVang();
        dgvWarningAbsences.DataSource = null;
        dgvWarningAbsences.DataSource = warningList.Select(w => new
        {
            Lớp_Học = w.GhiChu,
            Mã_HV = w.MaHocVien,
            Họ_Tên = w.TenHocVien,
            Số_Điện_Thoại = w.SoDienThoai,
            Số_Buổi_Vắng = $"⚠️ {w.TongSoBuoiVang} buổi",
            Yêu_Cầu_Lễ_Tân = "Gọi điện xác minh lý do nghỉ & Xếp lịch học bù"
        }).ToList();
    }
    #endregion

    #region 6. GRADES & CERTIFICATE LOGIC
    private void RefreshGradesTab()
    {
        _listLopHoc = _service.GetAllLopHoc();
        cboGradeLop.DataSource = null;
        cboGradeLop.DataSource = _listLopHoc;
        cboGradeLop.DisplayMember = "TenLop";
        cboGradeLop.ValueMember = "MaLop";

        LoadGradesList();
    }

    private void LoadGradesList()
    {
        if (cboGradeLop.SelectedValue == null) return;
        string maLop = cboGradeLop.SelectedValue.ToString()!;

        _listKetQua = _service.GetKetQuaByLop(maLop);

        dgvGrades.Columns.Clear();
        dgvGrades.AutoGenerateColumns = false;

        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaHocVien", HeaderText = "Mã HV", Width = 90, ReadOnly = true });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenHocVien", HeaderText = "Họ và Tên", Width = 180, ReadOnly = true });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiemChuyenCan", HeaderText = "Chuyên Cần (10%)", Width = 120 });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiemGiuaKy", HeaderText = "Điểm Giữa Kỳ (40%)", Width = 130 });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiemCuoiKy", HeaderText = "Điểm Cuối Kỳ (50%)", Width = 130 });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DiemTrungBinh", HeaderText = "Điểm TB (Hệ 10)", Width = 110, ReadOnly = true });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "XepLoai", HeaderText = "Xếp Loại", Width = 120, ReadOnly = true });
        dgvGrades.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "TrangThaiHoanThanh", HeaderText = "Đạt / Hoàn Thành", Width = 110, ReadOnly = true });
        dgvGrades.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayCapChungNhan", HeaderText = "Ngày Cấp CN", Width = 110, ReadOnly = true });

        dgvGrades.DataSource = new BindingSource { DataSource = _listKetQua };
    }

    private void DgvGrades_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= _listKetQua.Count) return;
        var kq = _listKetQua[e.RowIndex];

        // Tự động tính điểm trung bình: ĐTB = 10% Chuyên cần + 40% Giữa kỳ + 50% Cuối kỳ
        decimal dtb = Math.Round((kq.DiemChuyenCan * 0.1m) + (kq.DiemGiuaKy * 0.4m) + (kq.DiemCuoiKy * 0.5m), 2);
        kq.DiemTrungBinh = dtb;

        if (dtb >= 9.0m)
        {
            kq.XepLoai = "Xuất sắc";
            kq.TrangThaiHoanThanh = true;
        }
        else if (dtb >= 8.0m)
        {
            kq.XepLoai = "Giỏi";
            kq.TrangThaiHoanThanh = true;
        }
        else if (dtb >= 6.5m)
        {
            kq.XepLoai = "Khá";
            kq.TrangThaiHoanThanh = true;
        }
        else if (dtb >= 5.0m)
        {
            kq.XepLoai = "Trung bình (Đạt)";
            kq.TrangThaiHoanThanh = true;
        }
        else
        {
            kq.XepLoai = "Chưa đạt";
            kq.TrangThaiHoanThanh = false;
        }

        if (kq.TrangThaiHoanThanh && string.IsNullOrEmpty(kq.NgayCapChungNhan))
        {
            kq.NgayCapChungNhan = DateTime.Now.ToString("yyyy-MM-dd");
        }

        dgvGrades.InvalidateRow(e.RowIndex);
    }

    private void BtnSaveGrades_Click(object? sender, EventArgs e)
    {
        try
        {
            dgvGrades.EndEdit();
            foreach (var kq in _listKetQua)
            {
                _service.SaveDiem(kq.MaKetQua, kq.DiemChuyenCan, kq.DiemGiuaKy, kq.DiemCuoiKy);
            }
            MessageBox.Show("Đã lưu bảng điểm và xếp loại học tập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGradesList();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi lưu điểm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnPrintCertificate_Click(object? sender, EventArgs e)
    {
        if (dgvGrades.CurrentRow == null || dgvGrades.CurrentRow.Index < 0)
        {
            MessageBox.Show("Vui lòng chọn học viên cần in Chứng nhận hoàn thành khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int idx = dgvGrades.CurrentRow.Index;
        if (idx >= _listKetQua.Count) return;
        var kq = _listKetQua[idx];

        if (!kq.TrangThaiHoanThanh || kq.DiemTrungBinh < 5.0m)
        {
            MessageBox.Show(
                $"Học viên '{kq.TenHocVien}' có điểm trung bình là {kq.DiemTrungBinh:N1} (Xếp loại: {kq.XepLoai}).\r\nChưa đủ điều kiện hoàn thành khóa học để cấp chứng nhận!",
                "Chưa đủ điều kiện cấp chứng nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var certDlg = new CertificateForm(kq);
        certDlg.ShowDialog(this);
    }
    #endregion
}
