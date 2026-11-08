namespace EduCenterApp.Forms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.pnlSidebar = new System.Windows.Forms.Panel();
        this.lblBrand = new System.Windows.Forms.Label();
        this.lblBrandSub = new System.Windows.Forms.Label();
        this.lblNavHeader1 = new System.Windows.Forms.Label();
        this.btnNavDashboard = new System.Windows.Forms.Button();
        this.btnNavCourses = new System.Windows.Forms.Button();
        this.btnNavSchedule = new System.Windows.Forms.Button();
        this.btnNavTuition = new System.Windows.Forms.Button();
        this.btnNavAttendance = new System.Windows.Forms.Button();
        this.btnNavGrades = new System.Windows.Forms.Button();
        this.lblNavHeader2 = new System.Windows.Forms.Label();
        this.btnNavDatabase = new System.Windows.Forms.Button();
        this.pnlUserSide = new System.Windows.Forms.Panel();
        this.lblUserAvatar = new System.Windows.Forms.Label();
        this.lblUserName = new System.Windows.Forms.Label();
        this.lblUserRole = new System.Windows.Forms.Label();
        this.pnlTopHeader = new System.Windows.Forms.Panel();
        this.lblHeaderGreeting = new System.Windows.Forms.Label();
        this.lblHeaderDate = new System.Windows.Forms.Label();
        this.lblAlertBadge = new System.Windows.Forms.Label();
        this.btnLogout = new System.Windows.Forms.Button();
        this.pnlMainContainer = new System.Windows.Forms.Panel();
        this.tabMain = new System.Windows.Forms.TabControl();
        
        // Tab 1: Dashboard
        this.tabDashboard = new System.Windows.Forms.TabPage();
        this.pnlStatCard1 = new System.Windows.Forms.Panel();
        this.lblStat1Icon = new System.Windows.Forms.Label();
        this.lblStat1Title = new System.Windows.Forms.Label();
        this.lblStat1Val = new System.Windows.Forms.Label();
        this.pnlStatCard2 = new System.Windows.Forms.Panel();
        this.lblStat2Icon = new System.Windows.Forms.Label();
        this.lblStat2Title = new System.Windows.Forms.Label();
        this.lblStat2Val = new System.Windows.Forms.Label();
        this.pnlStatCard3 = new System.Windows.Forms.Panel();
        this.lblStat3Icon = new System.Windows.Forms.Label();
        this.lblStat3Title = new System.Windows.Forms.Label();
        this.lblStat3Val = new System.Windows.Forms.Label();
        this.pnlStatCard4 = new System.Windows.Forms.Panel();
        this.lblStat4Icon = new System.Windows.Forms.Label();
        this.lblStat4Title = new System.Windows.Forms.Label();
        this.lblStat4Val = new System.Windows.Forms.Label();
        this.pnlBannerAlert = new System.Windows.Forms.Panel();
        this.lblAlertText = new System.Windows.Forms.Label();
        this.btnViewAlertDetail = new System.Windows.Forms.Button();
        this.pnlDashSchedule = new System.Windows.Forms.Panel();
        this.lblDashSchedTitle = new System.Windows.Forms.Label();
        this.dgvDashClasses = new System.Windows.Forms.DataGridView();
        this.pnlDashTasks = new System.Windows.Forms.Panel();
        this.lblDashTaskTitle = new System.Windows.Forms.Label();
        this.lblTaskItem1 = new System.Windows.Forms.Label();
        this.lblTaskItem2 = new System.Windows.Forms.Label();
        this.lblTaskItem3 = new System.Windows.Forms.Label();
        this.lblTaskItem4 = new System.Windows.Forms.Label();

        // Tab 2: Courses & Classes
        this.tabCourses = new System.Windows.Forms.TabPage();
        this.tabCourseSub = new System.Windows.Forms.TabControl();
        this.tabSubKhoaHoc = new System.Windows.Forms.TabPage();
        this.dgvKhoaHoc = new System.Windows.Forms.DataGridView();
        this.pnlKhoaHocForm = new System.Windows.Forms.Panel();
        this.lblMaKH = new System.Windows.Forms.Label();
        this.txtMaKH = new System.Windows.Forms.TextBox();
        this.lblTenKH = new System.Windows.Forms.Label();
        this.txtTenKH = new System.Windows.Forms.TextBox();
        this.lblHocPhiKH = new System.Windows.Forms.Label();
        this.numHocPhiKH = new System.Windows.Forms.NumericUpDown();
        this.lblSoBuoiKH = new System.Windows.Forms.Label();
        this.numSoBuoiKH = new System.Windows.Forms.NumericUpDown();
        this.lblMoTaKH = new System.Windows.Forms.Label();
        this.txtMoTaKH = new System.Windows.Forms.TextBox();
        this.btnSaveKH = new System.Windows.Forms.Button();
        this.btnDeleteKH = new System.Windows.Forms.Button();
        this.btnNewKH = new System.Windows.Forms.Button();
        
        this.tabSubLopHoc = new System.Windows.Forms.TabPage();
        this.dgvLopHoc = new System.Windows.Forms.DataGridView();
        this.pnlLopHocForm = new System.Windows.Forms.Panel();
        this.lblMaLop = new System.Windows.Forms.Label();
        this.txtMaLop = new System.Windows.Forms.TextBox();
        this.lblTenLop = new System.Windows.Forms.Label();
        this.txtTenLop = new System.Windows.Forms.TextBox();
        this.lblLopKhoaHoc = new System.Windows.Forms.Label();
        this.cboLopKhoaHoc = new System.Windows.Forms.ComboBox();
        this.lblLopGiaoVien = new System.Windows.Forms.Label();
        this.cboLopGiaoVien = new System.Windows.Forms.ComboBox();
        this.lblLopPhong = new System.Windows.Forms.Label();
        this.cboLopPhong = new System.Windows.Forms.ComboBox();
        this.lblLopThu = new System.Windows.Forms.Label();
        this.cboLopThu = new System.Windows.Forms.ComboBox();
        this.lblLopGioBD = new System.Windows.Forms.Label();
        this.txtLopGioBD = new System.Windows.Forms.TextBox();
        this.lblLopGioKT = new System.Windows.Forms.Label();
        this.txtLopGioKT = new System.Windows.Forms.TextBox();
        this.lblLopSiSo = new System.Windows.Forms.Label();
        this.numLopSiSo = new System.Windows.Forms.NumericUpDown();
        this.lblLopKhaiGiang = new System.Windows.Forms.Label();
        this.dtpLopKhaiGiang = new System.Windows.Forms.DateTimePicker();
        this.btnSaveLop = new System.Windows.Forms.Button();
        this.btnDeleteLop = new System.Windows.Forms.Button();
        this.btnNewLop = new System.Windows.Forms.Button();

        // Tab 3: Scheduler & Live Conflict Checking
        this.tabSchedule = new System.Windows.Forms.TabPage();
        this.pnlScheduleTop = new System.Windows.Forms.Panel();
        this.lblSchedFormTitle = new System.Windows.Forms.Label();
        this.lblSchedPhong = new System.Windows.Forms.Label();
        this.cboSchedPhong = new System.Windows.Forms.ComboBox();
        this.lblSchedGV = new System.Windows.Forms.Label();
        this.cboSchedGV = new System.Windows.Forms.ComboBox();
        this.lblSchedThu = new System.Windows.Forms.Label();
        this.cboSchedThu = new System.Windows.Forms.ComboBox();
        this.lblSchedGioBD = new System.Windows.Forms.Label();
        this.txtSchedGioBD = new System.Windows.Forms.TextBox();
        this.lblSchedGioKT = new System.Windows.Forms.Label();
        this.txtSchedGioKT = new System.Windows.Forms.TextBox();
        this.btnCheckConflict = new System.Windows.Forms.Button();
        this.pnlConflictAlertBox = new System.Windows.Forms.Panel();
        this.lblConflictResult = new System.Windows.Forms.Label();
        this.dgvAllSchedules = new System.Windows.Forms.DataGridView();
        this.lblAllSchedTitle = new System.Windows.Forms.Label();

        // Tab 4: Registration & Tuition Fee
        this.tabTuition = new System.Windows.Forms.TabPage();
        this.pnlRegForm = new System.Windows.Forms.Panel();
        this.lblRegTitle = new System.Windows.Forms.Label();
        this.lblRegHocVien = new System.Windows.Forms.Label();
        this.cboRegHocVien = new System.Windows.Forms.ComboBox();
        this.lblRegLop = new System.Windows.Forms.Label();
        this.cboRegLop = new System.Windows.Forms.ComboBox();
        this.lblRegHocPhiGoc = new System.Windows.Forms.Label();
        this.txtRegHocPhiGoc = new System.Windows.Forms.TextBox();
        this.chkOldStudentDiscount = new System.Windows.Forms.CheckBox();
        this.chkGroupDiscount = new System.Windows.Forms.CheckBox();
        this.numGroupPercent = new System.Windows.Forms.NumericUpDown();
        this.lblRegTotalFee = new System.Windows.Forms.Label();
        this.txtRegTotalFee = new System.Windows.Forms.TextBox();
        this.lblRegPayAmount = new System.Windows.Forms.Label();
        this.numRegPayAmount = new System.Windows.Forms.NumericUpDown();
        this.lblRegPaymentMethod = new System.Windows.Forms.Label();
        this.cboRegPaymentMethod = new System.Windows.Forms.ComboBox();
        this.btnRegisterAndPrint = new System.Windows.Forms.Button();
        this.btnQuickAddHV = new System.Windows.Forms.Button();
        this.tabRegSub = new System.Windows.Forms.TabControl();
        this.tabSubDangKy = new System.Windows.Forms.TabPage();
        this.dgvDangKy = new System.Windows.Forms.DataGridView();
        this.tabSubBienLai = new System.Windows.Forms.TabPage();
        this.dgvBienLai = new System.Windows.Forms.DataGridView();
        this.btnReprintReceipt = new System.Windows.Forms.Button();
        this.btnPayNextInstallment = new System.Windows.Forms.Button();

        // Tab 5: Attendance & > 3 Absences Warning
        this.tabAttendance = new System.Windows.Forms.TabPage();
        this.pnlAttFilter = new System.Windows.Forms.Panel();
        this.lblAttLop = new System.Windows.Forms.Label();
        this.cboAttLop = new System.Windows.Forms.ComboBox();
        this.lblAttBuoi = new System.Windows.Forms.Label();
        this.numAttBuoi = new System.Windows.Forms.NumericUpDown();
        this.lblAttNgay = new System.Windows.Forms.Label();
        this.dtpAttNgay = new System.Windows.Forms.DateTimePicker();
        this.btnLoadAttendance = new System.Windows.Forms.Button();
        this.btnSaveAttendance = new System.Windows.Forms.Button();
        this.dgvAttendance = new System.Windows.Forms.DataGridView();
        this.pnlAttWarning = new System.Windows.Forms.Panel();
        this.lblAttWarningTitle = new System.Windows.Forms.Label();
        this.dgvWarningAbsences = new System.Windows.Forms.DataGridView();

        // Tab 6: Grades & Certificates
        this.tabGrades = new System.Windows.Forms.TabPage();
        this.pnlGradeFilter = new System.Windows.Forms.Panel();
        this.lblGradeLop = new System.Windows.Forms.Label();
        this.cboGradeLop = new System.Windows.Forms.ComboBox();
        this.btnLoadGrades = new System.Windows.Forms.Button();
        this.btnSaveGrades = new System.Windows.Forms.Button();
        this.btnPrintCertificate = new System.Windows.Forms.Button();
        this.dgvGrades = new System.Windows.Forms.DataGridView();

        // Tab 7: SQLite Database & Navicat Guide
        this.tabDatabase = new System.Windows.Forms.TabPage();
        this.pnlNavicatGuide = new System.Windows.Forms.Panel();
        this.lblNavicatTitle = new System.Windows.Forms.Label();
        this.txtNavicatGuide = new System.Windows.Forms.TextBox();
        this.btnOpenDbFolder = new System.Windows.Forms.Button();
        this.btnReloadSampleData = new System.Windows.Forms.Button();

        this.pnlSidebar.SuspendLayout();
        this.pnlUserSide.SuspendLayout();
        this.pnlTopHeader.SuspendLayout();
        this.pnlMainContainer.SuspendLayout();
        this.tabMain.SuspendLayout();
        this.tabDashboard.SuspendLayout();
        this.pnlStatCard1.SuspendLayout();
        this.pnlStatCard2.SuspendLayout();
        this.pnlStatCard3.SuspendLayout();
        this.pnlStatCard4.SuspendLayout();
        this.pnlBannerAlert.SuspendLayout();
        this.pnlDashSchedule.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvDashClasses)).BeginInit();
        this.pnlDashTasks.SuspendLayout();
        this.tabCourses.SuspendLayout();
        this.tabCourseSub.SuspendLayout();
        this.tabSubKhoaHoc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
        this.pnlKhoaHocForm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numHocPhiKH)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiKH)).BeginInit();
        this.tabSubLopHoc.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
        this.pnlLopHocForm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numLopSiSo)).BeginInit();
        this.tabSchedule.SuspendLayout();
        this.pnlScheduleTop.SuspendLayout();
        this.pnlConflictAlertBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvAllSchedules)).BeginInit();
        this.tabTuition.SuspendLayout();
        this.pnlRegForm.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numGroupPercent)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.numRegPayAmount)).BeginInit();
        this.tabRegSub.SuspendLayout();
        this.tabSubDangKy.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
        this.tabSubBienLai.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvBienLai)).BeginInit();
        this.tabAttendance.SuspendLayout();
        this.pnlAttFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numAttBuoi)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
        this.pnlAttWarning.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvWarningAbsences)).BeginInit();
        this.tabGrades.SuspendLayout();
        this.pnlGradeFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
        this.tabDatabase.SuspendLayout();
        this.pnlNavicatGuide.SuspendLayout();
        this.SuspendLayout();

        // 
        // pnlSidebar
        // 
        this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.pnlSidebar.Controls.Add(this.lblBrand);
        this.pnlSidebar.Controls.Add(this.lblBrandSub);
        this.pnlSidebar.Controls.Add(this.lblNavHeader1);
        this.pnlSidebar.Controls.Add(this.btnNavDashboard);
        this.pnlSidebar.Controls.Add(this.btnNavCourses);
        this.pnlSidebar.Controls.Add(this.btnNavSchedule);
        this.pnlSidebar.Controls.Add(this.btnNavTuition);
        this.pnlSidebar.Controls.Add(this.btnNavAttendance);
        this.pnlSidebar.Controls.Add(this.btnNavGrades);
        this.pnlSidebar.Controls.Add(this.lblNavHeader2);
        this.pnlSidebar.Controls.Add(this.btnNavDatabase);
        this.pnlSidebar.Controls.Add(this.pnlUserSide);
        this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
        this.pnlSidebar.Name = "pnlSidebar";
        this.pnlSidebar.Size = new System.Drawing.Size(250, 768);
        this.pnlSidebar.TabIndex = 0;

        // lblBrand
        this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblBrand.ForeColor = System.Drawing.Color.White;
        this.lblBrand.Location = new System.Drawing.Point(20, 20);
        this.lblBrand.Name = "lblBrand";
        this.lblBrand.Size = new System.Drawing.Size(210, 32);
        this.lblBrand.TabIndex = 0;
        this.lblBrand.Text = "EduCenter";

        // lblBrandSub
        this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
        this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(130, 150, 170);
        this.lblBrandSub.Location = new System.Drawing.Point(22, 52);
        this.lblBrandSub.Name = "lblBrandSub";
        this.lblBrandSub.Size = new System.Drawing.Size(210, 18);
        this.lblBrandSub.TabIndex = 1;
        this.lblBrandSub.Text = "NORTHSTAR MANAGEMENT";

        // lblNavHeader1
        this.lblNavHeader1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        this.lblNavHeader1.ForeColor = System.Drawing.Color.FromArgb(130, 150, 170);
        this.lblNavHeader1.Location = new System.Drawing.Point(20, 85);
        this.lblNavHeader1.Name = "lblNavHeader1";
        this.lblNavHeader1.Size = new System.Drawing.Size(210, 18);
        this.lblNavHeader1.TabIndex = 2;
        this.lblNavHeader1.Text = "QUẢN LÝ ĐÀO TẠO";

        // btnNavDashboard
        this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnNavDashboard.FlatAppearance.BorderSize = 0;
        this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
        this.btnNavDashboard.Location = new System.Drawing.Point(12, 110);
        this.btnNavDashboard.Name = "btnNavDashboard";
        this.btnNavDashboard.Size = new System.Drawing.Size(226, 42);
        this.btnNavDashboard.TabIndex = 3;
        this.btnNavDashboard.Text = "  📊 Tổng quan";
        this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnNavDashboard.UseVisualStyleBackColor = false;

        // btnNavCourses
        this.btnNavCourses.FlatAppearance.BorderSize = 0;
        this.btnNavCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavCourses.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavCourses.ForeColor = System.Drawing.Color.FromArgb(200, 215, 230);
        this.btnNavCourses.Location = new System.Drawing.Point(12, 155);
        this.btnNavCourses.Name = "btnNavCourses";
        this.btnNavCourses.Size = new System.Drawing.Size(226, 42);
        this.btnNavCourses.TabIndex = 4;
        this.btnNavCourses.Text = "  📚 Khóa học & Lớp học";
        this.btnNavCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // btnNavSchedule
        this.btnNavSchedule.FlatAppearance.BorderSize = 0;
        this.btnNavSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavSchedule.ForeColor = System.Drawing.Color.FromArgb(200, 215, 230);
        this.btnNavSchedule.Location = new System.Drawing.Point(12, 200);
        this.btnNavSchedule.Name = "btnNavSchedule";
        this.btnNavSchedule.Size = new System.Drawing.Size(226, 42);
        this.btnNavSchedule.TabIndex = 5;
        this.btnNavSchedule.Text = "  🗓️ Xếp lịch & Trùng lịch";
        this.btnNavSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // btnNavTuition
        this.btnNavTuition.FlatAppearance.BorderSize = 0;
        this.btnNavTuition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavTuition.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavTuition.ForeColor = System.Drawing.Color.FromArgb(200, 215, 230);
        this.btnNavTuition.Location = new System.Drawing.Point(12, 245);
        this.btnNavTuition.Name = "btnNavTuition";
        this.btnNavTuition.Size = new System.Drawing.Size(226, 42);
        this.btnNavTuition.TabIndex = 6;
        this.btnNavTuition.Text = "  💰 Đăng ký & Học phí";
        this.btnNavTuition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // btnNavAttendance
        this.btnNavAttendance.FlatAppearance.BorderSize = 0;
        this.btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(200, 215, 230);
        this.btnNavAttendance.Location = new System.Drawing.Point(12, 290);
        this.btnNavAttendance.Name = "btnNavAttendance";
        this.btnNavAttendance.Size = new System.Drawing.Size(226, 42);
        this.btnNavAttendance.TabIndex = 7;
        this.btnNavAttendance.Text = "  📋 Điểm danh (Cảnh báo)";
        this.btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // btnNavGrades
        this.btnNavGrades.FlatAppearance.BorderSize = 0;
        this.btnNavGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavGrades.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavGrades.ForeColor = System.Drawing.Color.FromArgb(200, 215, 230);
        this.btnNavGrades.Location = new System.Drawing.Point(12, 335);
        this.btnNavGrades.Name = "btnNavGrades";
        this.btnNavGrades.Size = new System.Drawing.Size(226, 42);
        this.btnNavGrades.TabIndex = 8;
        this.btnNavGrades.Text = "  🎓 Điểm & Chứng nhận";
        this.btnNavGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // lblNavHeader2
        this.lblNavHeader2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        this.lblNavHeader2.ForeColor = System.Drawing.Color.FromArgb(130, 150, 170);
        this.lblNavHeader2.Location = new System.Drawing.Point(20, 395);
        this.lblNavHeader2.Name = "lblNavHeader2";
        this.lblNavHeader2.Size = new System.Drawing.Size(210, 18);
        this.lblNavHeader2.TabIndex = 9;
        this.lblNavHeader2.Text = "CƠ SỞ DỮ LIỆU & NAVICAT";

        // btnNavDatabase
        this.btnNavDatabase.FlatAppearance.BorderSize = 0;
        this.btnNavDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNavDatabase.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.btnNavDatabase.ForeColor = System.Drawing.Color.FromArgb(200, 215, 230);
        this.btnNavDatabase.Location = new System.Drawing.Point(12, 420);
        this.btnNavDatabase.Name = "btnNavDatabase";
        this.btnNavDatabase.Size = new System.Drawing.Size(226, 42);
        this.btnNavDatabase.TabIndex = 10;
        this.btnNavDatabase.Text = "  🗄️ SQLite & Navicat Guide";
        this.btnNavDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // pnlUserSide
        this.pnlUserSide.BackColor = System.Drawing.Color.FromArgb(24, 56, 88);
        this.pnlUserSide.Controls.Add(this.lblUserAvatar);
        this.pnlUserSide.Controls.Add(this.lblUserName);
        this.pnlUserSide.Controls.Add(this.lblUserRole);
        this.pnlUserSide.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlUserSide.Location = new System.Drawing.Point(0, 700);
        this.pnlUserSide.Name = "pnlUserSide";
        this.pnlUserSide.Size = new System.Drawing.Size(250, 68);
        this.pnlUserSide.TabIndex = 11;

        this.lblUserAvatar.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.lblUserAvatar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblUserAvatar.ForeColor = System.Drawing.Color.White;
        this.lblUserAvatar.Location = new System.Drawing.Point(15, 14);
        this.lblUserAvatar.Name = "lblUserAvatar";
        this.lblUserAvatar.Size = new System.Drawing.Size(40, 40);
        this.lblUserAvatar.TabIndex = 0;
        this.lblUserAvatar.Text = "AD";
        this.lblUserAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblUserName.ForeColor = System.Drawing.Color.White;
        this.lblUserName.Location = new System.Drawing.Point(62, 14);
        this.lblUserName.Name = "lblUserName";
        this.lblUserName.Size = new System.Drawing.Size(170, 20);
        this.lblUserName.TabIndex = 1;
        this.lblUserName.Text = "Nguyễn Quản Trị";

        this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblUserRole.ForeColor = System.Drawing.Color.FromArgb(140, 170, 200);
        this.lblUserRole.Location = new System.Drawing.Point(62, 36);
        this.lblUserRole.Name = "lblUserRole";
        this.lblUserRole.Size = new System.Drawing.Size(170, 18);
        this.lblUserRole.TabIndex = 2;
        this.lblUserRole.Text = "Quản trị viên";

        // 
        // pnlTopHeader
        // 
        this.pnlTopHeader.BackColor = System.Drawing.Color.White;
        this.pnlTopHeader.Controls.Add(this.lblHeaderGreeting);
        this.pnlTopHeader.Controls.Add(this.lblHeaderDate);
        this.pnlTopHeader.Controls.Add(this.lblAlertBadge);
        this.pnlTopHeader.Controls.Add(this.btnLogout);
        this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlTopHeader.Location = new System.Drawing.Point(250, 0);
        this.pnlTopHeader.Name = "pnlTopHeader";
        this.pnlTopHeader.Size = new System.Drawing.Size(1116, 68);
        this.pnlTopHeader.TabIndex = 1;

        this.lblHeaderGreeting.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblHeaderGreeting.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblHeaderGreeting.Location = new System.Drawing.Point(20, 12);
        this.lblHeaderGreeting.Name = "lblHeaderGreeting";
        this.lblHeaderGreeting.Size = new System.Drawing.Size(400, 25);
        this.lblHeaderGreeting.TabIndex = 0;
        this.lblHeaderGreeting.Text = "Trung Tâm Anh Ngữ Northstar (EduCenter)";

        this.lblHeaderDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
        this.lblHeaderDate.ForeColor = System.Drawing.Color.Gray;
        this.lblHeaderDate.Location = new System.Drawing.Point(22, 38);
        this.lblHeaderDate.Name = "lblHeaderDate";
        this.lblHeaderDate.Size = new System.Drawing.Size(400, 18);
        this.lblHeaderDate.TabIndex = 1;
        this.lblHeaderDate.Text = "Hôm nay, Thứ ..., ngày ...";

        this.lblAlertBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.lblAlertBadge.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
        this.lblAlertBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblAlertBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblAlertBadge.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.lblAlertBadge.Location = new System.Drawing.Point(680, 18);
        this.lblAlertBadge.Name = "lblAlertBadge";
        this.lblAlertBadge.Size = new System.Drawing.Size(280, 32);
        this.lblAlertBadge.TabIndex = 2;
        this.lblAlertBadge.Text = "⚠️ 1 Học viên vắng >= 3 buổi cần nhắc nhở";
        this.lblAlertBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLogout.BackColor = System.Drawing.Color.FromArgb(244, 247, 252);
        this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(210, 220, 230);
        this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.btnLogout.Location = new System.Drawing.Point(980, 16);
        this.btnLogout.Name = "btnLogout";
        this.btnLogout.Size = new System.Drawing.Size(110, 36);
        this.btnLogout.TabIndex = 3;
        this.btnLogout.Text = "🚪 Đăng xuất";
        this.btnLogout.UseVisualStyleBackColor = false;

        // 
        // pnlMainContainer
        // 
        this.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(244, 247, 252);
        this.pnlMainContainer.Controls.Add(this.tabMain);
        this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlMainContainer.Location = new System.Drawing.Point(250, 68);
        this.pnlMainContainer.Name = "pnlMainContainer";
        this.pnlMainContainer.Padding = new System.Windows.Forms.Padding(15);
        this.pnlMainContainer.Size = new System.Drawing.Size(1116, 700);
        this.pnlMainContainer.TabIndex = 2;

        // 
        // tabMain
        // 
        this.tabMain.Controls.Add(this.tabDashboard);
        this.tabMain.Controls.Add(this.tabCourses);
        this.tabMain.Controls.Add(this.tabSchedule);
        this.tabMain.Controls.Add(this.tabTuition);
        this.tabMain.Controls.Add(this.tabAttendance);
        this.tabMain.Controls.Add(this.tabGrades);
        this.tabMain.Controls.Add(this.tabDatabase);
        this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.tabMain.Location = new System.Drawing.Point(15, 15);
        this.tabMain.Name = "tabMain";
        this.tabMain.SelectedIndex = 0;
        this.tabMain.Size = new System.Drawing.Size(1086, 670);
        this.tabMain.TabIndex = 0;

        // ==========================================
        // TAB 1: DASHBOARD
        // ==========================================
        this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(244, 247, 252);
        this.tabDashboard.Controls.Add(this.pnlStatCard1);
        this.tabDashboard.Controls.Add(this.pnlStatCard2);
        this.tabDashboard.Controls.Add(this.pnlStatCard3);
        this.tabDashboard.Controls.Add(this.pnlStatCard4);
        this.tabDashboard.Controls.Add(this.pnlBannerAlert);
        this.tabDashboard.Controls.Add(this.pnlDashSchedule);
        this.tabDashboard.Controls.Add(this.pnlDashTasks);
        this.tabDashboard.Location = new System.Drawing.Point(4, 25);
        this.tabDashboard.Name = "tabDashboard";
        this.tabDashboard.Padding = new System.Windows.Forms.Padding(10);
        this.tabDashboard.Size = new System.Drawing.Size(1078, 641);
        this.tabDashboard.TabIndex = 0;
        this.tabDashboard.Text = "Tổng quan";

        // StatCard 1
        this.pnlStatCard1.BackColor = System.Drawing.Color.White;
        this.pnlStatCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlStatCard1.Controls.Add(this.lblStat1Icon);
        this.pnlStatCard1.Controls.Add(this.lblStat1Title);
        this.pnlStatCard1.Controls.Add(this.lblStat1Val);
        this.pnlStatCard1.Location = new System.Drawing.Point(15, 15);
        this.pnlStatCard1.Name = "pnlStatCard1";
        this.pnlStatCard1.Size = new System.Drawing.Size(245, 100);
        this.pnlStatCard1.TabIndex = 0;

        this.lblStat1Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
        this.lblStat1Icon.Location = new System.Drawing.Point(15, 15);
        this.lblStat1Icon.Name = "lblStat1Icon";
        this.lblStat1Icon.Size = new System.Drawing.Size(45, 45);
        this.lblStat1Icon.TabIndex = 0;
        this.lblStat1Icon.Text = "🎓";

        this.lblStat1Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStat1Title.ForeColor = System.Drawing.Color.Gray;
        this.lblStat1Title.Location = new System.Drawing.Point(70, 18);
        this.lblStat1Title.Name = "lblStat1Title";
        this.lblStat1Title.Size = new System.Drawing.Size(160, 20);
        this.lblStat1Title.TabIndex = 1;
        this.lblStat1Title.Text = "Tổng học viên";

        this.lblStat1Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblStat1Val.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblStat1Val.Location = new System.Drawing.Point(70, 42);
        this.lblStat1Val.Name = "lblStat1Val";
        this.lblStat1Val.Size = new System.Drawing.Size(160, 35);
        this.lblStat1Val.TabIndex = 2;
        this.lblStat1Val.Text = "8 học viên";

        // StatCard 2
        this.pnlStatCard2.BackColor = System.Drawing.Color.White;
        this.pnlStatCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlStatCard2.Controls.Add(this.lblStat2Icon);
        this.pnlStatCard2.Controls.Add(this.lblStat2Title);
        this.pnlStatCard2.Controls.Add(this.lblStat2Val);
        this.pnlStatCard2.Location = new System.Drawing.Point(280, 15);
        this.pnlStatCard2.Name = "pnlStatCard2";
        this.pnlStatCard2.Size = new System.Drawing.Size(245, 100);
        this.pnlStatCard2.TabIndex = 1;

        this.lblStat2Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
        this.lblStat2Icon.Location = new System.Drawing.Point(15, 15);
        this.lblStat2Icon.Name = "lblStat2Icon";
        this.lblStat2Icon.Size = new System.Drawing.Size(45, 45);
        this.lblStat2Icon.TabIndex = 0;
        this.lblStat2Icon.Text = "📘";

        this.lblStat2Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStat2Title.ForeColor = System.Drawing.Color.Gray;
        this.lblStat2Title.Location = new System.Drawing.Point(70, 18);
        this.lblStat2Title.Name = "lblStat2Title";
        this.lblStat2Title.Size = new System.Drawing.Size(160, 20);
        this.lblStat2Title.TabIndex = 1;
        this.lblStat2Title.Text = "Lớp đang hoạt động";

        this.lblStat2Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblStat2Val.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblStat2Val.Location = new System.Drawing.Point(70, 42);
        this.lblStat2Val.Name = "lblStat2Val";
        this.lblStat2Val.Size = new System.Drawing.Size(160, 35);
        this.lblStat2Val.TabIndex = 2;
        this.lblStat2Val.Text = "4 lớp";

        // StatCard 3
        this.pnlStatCard3.BackColor = System.Drawing.Color.White;
        this.pnlStatCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlStatCard3.Controls.Add(this.lblStat3Icon);
        this.pnlStatCard3.Controls.Add(this.lblStat3Title);
        this.pnlStatCard3.Controls.Add(this.lblStat3Val);
        this.pnlStatCard3.Location = new System.Drawing.Point(545, 15);
        this.pnlStatCard3.Name = "pnlStatCard3";
        this.pnlStatCard3.Size = new System.Drawing.Size(245, 100);
        this.pnlStatCard3.TabIndex = 2;

        this.lblStat3Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
        this.lblStat3Icon.Location = new System.Drawing.Point(15, 15);
        this.lblStat3Icon.Name = "lblStat3Icon";
        this.lblStat3Icon.Size = new System.Drawing.Size(45, 45);
        this.lblStat3Icon.TabIndex = 0;
        this.lblStat3Icon.Text = "👥";

        this.lblStat3Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStat3Title.ForeColor = System.Drawing.Color.Gray;
        this.lblStat3Title.Location = new System.Drawing.Point(70, 18);
        this.lblStat3Title.Name = "lblStat3Title";
        this.lblStat3Title.Size = new System.Drawing.Size(160, 20);
        this.lblStat3Title.TabIndex = 1;
        this.lblStat3Title.Text = "Đội ngũ giảng viên";

        this.lblStat3Val.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblStat3Val.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblStat3Val.Location = new System.Drawing.Point(70, 42);
        this.lblStat3Val.Name = "lblStat3Val";
        this.lblStat3Val.Size = new System.Drawing.Size(160, 35);
        this.lblStat3Val.TabIndex = 2;
        this.lblStat3Val.Text = "4 giảng viên";

        // StatCard 4
        this.pnlStatCard4.BackColor = System.Drawing.Color.White;
        this.pnlStatCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlStatCard4.Controls.Add(this.lblStat4Icon);
        this.pnlStatCard4.Controls.Add(this.lblStat4Title);
        this.pnlStatCard4.Controls.Add(this.lblStat4Val);
        this.pnlStatCard4.Location = new System.Drawing.Point(810, 15);
        this.pnlStatCard4.Name = "pnlStatCard4";
        this.pnlStatCard4.Size = new System.Drawing.Size(250, 100);
        this.pnlStatCard4.TabIndex = 3;

        this.lblStat4Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
        this.lblStat4Icon.Location = new System.Drawing.Point(15, 15);
        this.lblStat4Icon.Name = "lblStat4Icon";
        this.lblStat4Icon.Size = new System.Drawing.Size(45, 45);
        this.lblStat4Icon.TabIndex = 0;
        this.lblStat4Icon.Text = "💳";

        this.lblStat4Title.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStat4Title.ForeColor = System.Drawing.Color.Gray;
        this.lblStat4Title.Location = new System.Drawing.Point(70, 18);
        this.lblStat4Title.Name = "lblStat4Title";
        this.lblStat4Title.Size = new System.Drawing.Size(170, 20);
        this.lblStat4Title.TabIndex = 1;
        this.lblStat4Title.Text = "Doanh thu học phí";

        this.lblStat4Val.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblStat4Val.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
        this.lblStat4Val.Location = new System.Drawing.Point(70, 42);
        this.lblStat4Val.Name = "lblStat4Val";
        this.lblStat4Val.Size = new System.Drawing.Size(170, 35);
        this.lblStat4Val.TabIndex = 2;
        this.lblStat4Val.Text = "16,800,000 đ";

        // pnlBannerAlert
        this.pnlBannerAlert.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
        this.pnlBannerAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlBannerAlert.Controls.Add(this.lblAlertText);
        this.pnlBannerAlert.Controls.Add(this.btnViewAlertDetail);
        this.pnlBannerAlert.Location = new System.Drawing.Point(15, 130);
        this.pnlBannerAlert.Name = "pnlBannerAlert";
        this.pnlBannerAlert.Size = new System.Drawing.Size(1045, 50);
        this.pnlBannerAlert.TabIndex = 4;

        this.lblAlertText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblAlertText.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.lblAlertText.Location = new System.Drawing.Point(15, 12);
        this.lblAlertText.Name = "lblAlertText";
        this.lblAlertText.Size = new System.Drawing.Size(780, 25);
        this.lblAlertText.TabIndex = 0;
        this.lblAlertText.Text = "⚠️ CẢNH BÁO CHUYÊN CẦN: Có học viên đã vắng từ 3 buổi trở lên! Cần bộ phận Lễ tân liên hệ nhắc nhở ngay.";

        this.btnViewAlertDetail.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.btnViewAlertDetail.FlatAppearance.BorderSize = 0;
        this.btnViewAlertDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnViewAlertDetail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
        this.btnViewAlertDetail.ForeColor = System.Drawing.Color.White;
        this.btnViewAlertDetail.Location = new System.Drawing.Point(820, 8);
        this.btnViewAlertDetail.Name = "btnViewAlertDetail";
        this.btnViewAlertDetail.Size = new System.Drawing.Size(210, 32);
        this.btnViewAlertDetail.TabIndex = 1;
        this.btnViewAlertDetail.Text = "Xem danh sách liên hệ >";
        this.btnViewAlertDetail.UseVisualStyleBackColor = false;

        // pnlDashSchedule
        this.pnlDashSchedule.BackColor = System.Drawing.Color.White;
        this.pnlDashSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlDashSchedule.Controls.Add(this.lblDashSchedTitle);
        this.pnlDashSchedule.Controls.Add(this.dgvDashClasses);
        this.pnlDashSchedule.Location = new System.Drawing.Point(15, 195);
        this.pnlDashSchedule.Name = "pnlDashSchedule";
        this.pnlDashSchedule.Size = new System.Drawing.Size(650, 430);
        this.pnlDashSchedule.TabIndex = 5;

        this.lblDashSchedTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblDashSchedTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblDashSchedTitle.Location = new System.Drawing.Point(15, 12);
        this.lblDashSchedTitle.Name = "lblDashSchedTitle";
        this.lblDashSchedTitle.Size = new System.Drawing.Size(400, 25);
        this.lblDashSchedTitle.TabIndex = 0;
        this.lblDashSchedTitle.Text = "📅 Lớp Học Đang Hoạt Động";

        this.dgvDashClasses.AllowUserToAddRows = false;
        this.dgvDashClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvDashClasses.BackgroundColor = System.Drawing.Color.White;
        this.dgvDashClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvDashClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvDashClasses.Location = new System.Drawing.Point(15, 45);
        this.dgvDashClasses.Name = "dgvDashClasses";
        this.dgvDashClasses.ReadOnly = true;
        this.dgvDashClasses.RowHeadersVisible = false;
        this.dgvDashClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvDashClasses.Size = new System.Drawing.Size(618, 368);
        this.dgvDashClasses.TabIndex = 1;

        // pnlDashTasks
        this.pnlDashTasks.BackColor = System.Drawing.Color.White;
        this.pnlDashTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlDashTasks.Controls.Add(this.lblDashTaskTitle);
        this.pnlDashTasks.Controls.Add(this.lblTaskItem1);
        this.pnlDashTasks.Controls.Add(this.lblTaskItem2);
        this.pnlDashTasks.Controls.Add(this.lblTaskItem3);
        this.pnlDashTasks.Controls.Add(this.lblTaskItem4);
        this.pnlDashTasks.Location = new System.Drawing.Point(680, 195);
        this.pnlDashTasks.Name = "pnlDashTasks";
        this.pnlDashTasks.Size = new System.Drawing.Size(380, 430);
        this.pnlDashTasks.TabIndex = 6;

        this.lblDashTaskTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblDashTaskTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblDashTaskTitle.Location = new System.Drawing.Point(15, 12);
        this.lblDashTaskTitle.Name = "lblDashTaskTitle";
        this.lblDashTaskTitle.Size = new System.Drawing.Size(300, 25);
        this.lblDashTaskTitle.TabIndex = 0;
        this.lblDashTaskTitle.Text = "📌 Công Việc Cần Xử Lý";

        this.lblTaskItem1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.lblTaskItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTaskItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblTaskItem1.Location = new System.Drawing.Point(15, 50);
        this.lblTaskItem1.Name = "lblTaskItem1";
        this.lblTaskItem1.Padding = new System.Windows.Forms.Padding(10);
        this.lblTaskItem1.Size = new System.Drawing.Size(348, 70);
        this.lblTaskItem1.TabIndex = 1;
        this.lblTaskItem1.Text = "🔴 Liên hệ HV Vũ Đình Trọng (vắng 4 buổi)\nSố ĐT: 0985556677 - Lớp TOEIC 500";

        this.lblTaskItem2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.lblTaskItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTaskItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblTaskItem2.Location = new System.Drawing.Point(15, 130);
        this.lblTaskItem2.Name = "lblTaskItem2";
        this.lblTaskItem2.Padding = new System.Windows.Forms.Padding(10);
        this.lblTaskItem2.Size = new System.Drawing.Size(348, 70);
        this.lblTaskItem2.TabIndex = 2;
        this.lblTaskItem2.Text = "💳 Thu học phí đợt 2: HV Trần Thị Bích\nCòn nợ: 1,500,000 đ - Hạn: 15/03/2025";

        this.lblTaskItem3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.lblTaskItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTaskItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblTaskItem3.Location = new System.Drawing.Point(15, 210);
        this.lblTaskItem3.Name = "lblTaskItem3";
        this.lblTaskItem3.Padding = new System.Windows.Forms.Padding(10);
        this.lblTaskItem3.Size = new System.Drawing.Size(348, 70);
        this.lblTaskItem3.TabIndex = 3;
        this.lblTaskItem3.Text = "📝 Chấm điểm giữa kỳ Lớp IELTS 6.5\nGiáo viên phụ trách: Thầy John Smith";

        this.lblTaskItem4.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.lblTaskItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblTaskItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblTaskItem4.Location = new System.Drawing.Point(15, 290);
        this.lblTaskItem4.Name = "lblTaskItem4";
        this.lblTaskItem4.Padding = new System.Windows.Forms.Padding(10);
        this.lblTaskItem4.Size = new System.Drawing.Size(348, 70);
        this.lblTaskItem4.TabIndex = 4;
        this.lblTaskItem4.Text = "🎓 Xuất chứng nhận hoàn thành khóa học\nCho học viên Nguyễn Văn An (Điểm: 8.8)";

        // ==========================================
        // TAB 2: COURSES & CLASSES
        // ==========================================
        this.tabCourses.Controls.Add(this.tabCourseSub);
        this.tabCourses.Location = new System.Drawing.Point(4, 25);
        this.tabCourses.Name = "tabCourses";
        this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
        this.tabCourses.Size = new System.Drawing.Size(1078, 641);
        this.tabCourses.TabIndex = 1;
        this.tabCourses.Text = "Khóa học & Lớp học";

        this.tabCourseSub.Controls.Add(this.tabSubKhoaHoc);
        this.tabCourseSub.Controls.Add(this.tabSubLopHoc);
        this.tabCourseSub.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabCourseSub.Location = new System.Drawing.Point(3, 3);
        this.tabCourseSub.Name = "tabCourseSub";
        this.tabCourseSub.SelectedIndex = 0;
        this.tabCourseSub.Size = new System.Drawing.Size(1072, 635);
        this.tabCourseSub.TabIndex = 0;

        // SubTab: KhoaHoc
        this.tabSubKhoaHoc.BackColor = System.Drawing.Color.White;
        this.tabSubKhoaHoc.Controls.Add(this.pnlKhoaHocForm);
        this.tabSubKhoaHoc.Controls.Add(this.dgvKhoaHoc);
        this.tabSubKhoaHoc.Location = new System.Drawing.Point(4, 25);
        this.tabSubKhoaHoc.Name = "tabSubKhoaHoc";
        this.tabSubKhoaHoc.Padding = new System.Windows.Forms.Padding(10);
        this.tabSubKhoaHoc.Size = new System.Drawing.Size(1064, 606);
        this.tabSubKhoaHoc.TabIndex = 0;
        this.tabSubKhoaHoc.Text = "Danh mục Khóa học";

        this.dgvKhoaHoc.AllowUserToAddRows = false;
        this.dgvKhoaHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvKhoaHoc.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvKhoaHoc.Location = new System.Drawing.Point(10, 10);
        this.dgvKhoaHoc.Name = "dgvKhoaHoc";
        this.dgvKhoaHoc.ReadOnly = true;
        this.dgvKhoaHoc.RowHeadersVisible = false;
        this.dgvKhoaHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvKhoaHoc.Size = new System.Drawing.Size(680, 580);
        this.dgvKhoaHoc.TabIndex = 0;

        this.pnlKhoaHocForm.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlKhoaHocForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKhoaHocForm.Controls.Add(this.lblMaKH);
        this.pnlKhoaHocForm.Controls.Add(this.txtMaKH);
        this.pnlKhoaHocForm.Controls.Add(this.lblTenKH);
        this.pnlKhoaHocForm.Controls.Add(this.txtTenKH);
        this.pnlKhoaHocForm.Controls.Add(this.lblHocPhiKH);
        this.pnlKhoaHocForm.Controls.Add(this.numHocPhiKH);
        this.pnlKhoaHocForm.Controls.Add(this.lblSoBuoiKH);
        this.pnlKhoaHocForm.Controls.Add(this.numSoBuoiKH);
        this.pnlKhoaHocForm.Controls.Add(this.lblMoTaKH);
        this.pnlKhoaHocForm.Controls.Add(this.txtMoTaKH);
        this.pnlKhoaHocForm.Controls.Add(this.btnNewKH);
        this.pnlKhoaHocForm.Controls.Add(this.btnSaveKH);
        this.pnlKhoaHocForm.Controls.Add(this.btnDeleteKH);
        this.pnlKhoaHocForm.Location = new System.Drawing.Point(705, 10);
        this.pnlKhoaHocForm.Name = "pnlKhoaHocForm";
        this.pnlKhoaHocForm.Size = new System.Drawing.Size(345, 580);
        this.pnlKhoaHocForm.TabIndex = 1;

        this.lblMaKH.Location = new System.Drawing.Point(15, 15);
        this.lblMaKH.Name = "lblMaKH";
        this.lblMaKH.Size = new System.Drawing.Size(315, 20);
        this.lblMaKH.Text = "Mã khóa học:";
        this.txtMaKH.Location = new System.Drawing.Point(15, 38);
        this.txtMaKH.Name = "txtMaKH";
        this.txtMaKH.Size = new System.Drawing.Size(315, 25);

        this.lblTenKH.Location = new System.Drawing.Point(15, 75);
        this.lblTenKH.Name = "lblTenKH";
        this.lblTenKH.Size = new System.Drawing.Size(315, 20);
        this.lblTenKH.Text = "Tên khóa học (vd: TOEIC 500, IELTS 6.5):";
        this.txtTenKH.Location = new System.Drawing.Point(15, 98);
        this.txtTenKH.Name = "txtTenKH";
        this.txtTenKH.Size = new System.Drawing.Size(315, 25);

        this.lblHocPhiKH.Location = new System.Drawing.Point(15, 135);
        this.lblHocPhiKH.Name = "lblHocPhiKH";
        this.lblHocPhiKH.Size = new System.Drawing.Size(315, 20);
        this.lblHocPhiKH.Text = "Học phí gốc (VNĐ):";
        this.numHocPhiKH.DecimalPlaces = 0;
        this.numHocPhiKH.Increment = new decimal(500000);
        this.numHocPhiKH.Location = new System.Drawing.Point(15, 158);
        this.numHocPhiKH.Maximum = new decimal(100000000);
        this.numHocPhiKH.Name = "numHocPhiKH";
        this.numHocPhiKH.Size = new System.Drawing.Size(315, 25);

        this.lblSoBuoiKH.Location = new System.Drawing.Point(15, 195);
        this.lblSoBuoiKH.Name = "lblSoBuoiKH";
        this.lblSoBuoiKH.Size = new System.Drawing.Size(315, 20);
        this.lblSoBuoiKH.Text = "Số buổi học:";
        this.numSoBuoiKH.Location = new System.Drawing.Point(15, 218);
        this.numSoBuoiKH.Maximum = new decimal(200);
        this.numSoBuoiKH.Minimum = new decimal(1);
        this.numSoBuoiKH.Name = "numSoBuoiKH";
        this.numSoBuoiKH.Size = new System.Drawing.Size(315, 25);
        this.numSoBuoiKH.Value = new decimal(24);

        this.lblMoTaKH.Location = new System.Drawing.Point(15, 255);
        this.lblMoTaKH.Name = "lblMoTaKH";
        this.lblMoTaKH.Size = new System.Drawing.Size(315, 20);
        this.lblMoTaKH.Text = "Mô tả khóa học:";
        this.txtMoTaKH.Location = new System.Drawing.Point(15, 278);
        this.txtMoTaKH.Multiline = true;
        this.txtMoTaKH.Name = "txtMoTaKH";
        this.txtMoTaKH.Size = new System.Drawing.Size(315, 100);

        this.btnNewKH.BackColor = System.Drawing.Color.White;
        this.btnNewKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNewKH.Location = new System.Drawing.Point(15, 400);
        this.btnNewKH.Name = "btnNewKH";
        this.btnNewKH.Size = new System.Drawing.Size(95, 35);
        this.btnNewKH.Text = "Làm mới";

        this.btnSaveKH.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnSaveKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveKH.ForeColor = System.Drawing.Color.White;
        this.btnSaveKH.Location = new System.Drawing.Point(120, 400);
        this.btnSaveKH.Name = "btnSaveKH";
        this.btnSaveKH.Size = new System.Drawing.Size(110, 35);
        this.btnSaveKH.Text = "💾 Lưu Khóa";

        this.btnDeleteKH.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
        this.btnDeleteKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDeleteKH.ForeColor = System.Drawing.Color.White;
        this.btnDeleteKH.Location = new System.Drawing.Point(240, 400);
        this.btnDeleteKH.Name = "btnDeleteKH";
        this.btnDeleteKH.Size = new System.Drawing.Size(90, 35);
        this.btnDeleteKH.Text = "Xóa";

        // SubTab: LopHoc
        this.tabSubLopHoc.BackColor = System.Drawing.Color.White;
        this.tabSubLopHoc.Controls.Add(this.pnlLopHocForm);
        this.tabSubLopHoc.Controls.Add(this.dgvLopHoc);
        this.tabSubLopHoc.Location = new System.Drawing.Point(4, 25);
        this.tabSubLopHoc.Name = "tabSubLopHoc";
        this.tabSubLopHoc.Padding = new System.Windows.Forms.Padding(10);
        this.tabSubLopHoc.Size = new System.Drawing.Size(1064, 606);
        this.tabSubLopHoc.TabIndex = 1;
        this.tabSubLopHoc.Text = "Danh sách Lớp học cụ thể";

        this.dgvLopHoc.AllowUserToAddRows = false;
        this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvLopHoc.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvLopHoc.Location = new System.Drawing.Point(10, 10);
        this.dgvLopHoc.Name = "dgvLopHoc";
        this.dgvLopHoc.ReadOnly = true;
        this.dgvLopHoc.RowHeadersVisible = false;
        this.dgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvLopHoc.Size = new System.Drawing.Size(680, 580);
        this.dgvLopHoc.TabIndex = 0;

        this.pnlLopHocForm.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlLopHocForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlLopHocForm.Controls.Add(this.lblMaLop);
        this.pnlLopHocForm.Controls.Add(this.txtMaLop);
        this.pnlLopHocForm.Controls.Add(this.lblTenLop);
        this.pnlLopHocForm.Controls.Add(this.txtTenLop);
        this.pnlLopHocForm.Controls.Add(this.lblLopKhoaHoc);
        this.pnlLopHocForm.Controls.Add(this.cboLopKhoaHoc);
        this.pnlLopHocForm.Controls.Add(this.lblLopGiaoVien);
        this.pnlLopHocForm.Controls.Add(this.cboLopGiaoVien);
        this.pnlLopHocForm.Controls.Add(this.lblLopPhong);
        this.pnlLopHocForm.Controls.Add(this.cboLopPhong);
        this.pnlLopHocForm.Controls.Add(this.lblLopThu);
        this.pnlLopHocForm.Controls.Add(this.cboLopThu);
        this.pnlLopHocForm.Controls.Add(this.lblLopGioBD);
        this.pnlLopHocForm.Controls.Add(this.txtLopGioBD);
        this.pnlLopHocForm.Controls.Add(this.lblLopGioKT);
        this.pnlLopHocForm.Controls.Add(this.txtLopGioKT);
        this.pnlLopHocForm.Controls.Add(this.lblLopSiSo);
        this.pnlLopHocForm.Controls.Add(this.numLopSiSo);
        this.pnlLopHocForm.Controls.Add(this.lblLopKhaiGiang);
        this.pnlLopHocForm.Controls.Add(this.dtpLopKhaiGiang);
        this.pnlLopHocForm.Controls.Add(this.btnNewLop);
        this.pnlLopHocForm.Controls.Add(this.btnSaveLop);
        this.pnlLopHocForm.Controls.Add(this.btnDeleteLop);
        this.pnlLopHocForm.Location = new System.Drawing.Point(705, 10);
        this.pnlLopHocForm.Name = "pnlLopHocForm";
        this.pnlLopHocForm.Size = new System.Drawing.Size(345, 580);
        this.pnlLopHocForm.TabIndex = 1;

        this.lblMaLop.Location = new System.Drawing.Point(12, 10);
        this.lblMaLop.Name = "lblMaLop";
        this.lblMaLop.Size = new System.Drawing.Size(150, 18);
        this.lblMaLop.Text = "Mã lớp:";
        this.txtMaLop.Location = new System.Drawing.Point(12, 28);
        this.txtMaLop.Name = "txtMaLop";
        this.txtMaLop.Size = new System.Drawing.Size(150, 25);

        this.lblLopKhoaHoc.Location = new System.Drawing.Point(175, 10);
        this.lblLopKhoaHoc.Name = "lblLopKhoaHoc";
        this.lblLopKhoaHoc.Size = new System.Drawing.Size(155, 18);
        this.lblLopKhoaHoc.Text = "Khóa học:";
        this.cboLopKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLopKhoaHoc.Location = new System.Drawing.Point(175, 28);
        this.cboLopKhoaHoc.Name = "cboLopKhoaHoc";
        this.cboLopKhoaHoc.Size = new System.Drawing.Size(155, 25);

        this.lblTenLop.Location = new System.Drawing.Point(12, 60);
        this.lblTenLop.Name = "lblTenLop";
        this.lblTenLop.Size = new System.Drawing.Size(318, 18);
        this.lblTenLop.Text = "Tên lớp học:";
        this.txtTenLop.Location = new System.Drawing.Point(12, 80);
        this.txtTenLop.Name = "txtTenLop";
        this.txtTenLop.Size = new System.Drawing.Size(318, 25);

        this.lblLopGiaoVien.Location = new System.Drawing.Point(12, 115);
        this.lblLopGiaoVien.Name = "lblLopGiaoVien";
        this.lblLopGiaoVien.Size = new System.Drawing.Size(150, 18);
        this.lblLopGiaoVien.Text = "Giáo viên phụ trách:";
        this.cboLopGiaoVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLopGiaoVien.Location = new System.Drawing.Point(12, 135);
        this.cboLopGiaoVien.Name = "cboLopGiaoVien";
        this.cboLopGiaoVien.Size = new System.Drawing.Size(150, 25);

        this.lblLopPhong.Location = new System.Drawing.Point(175, 115);
        this.lblLopPhong.Name = "lblLopPhong";
        this.lblLopPhong.Size = new System.Drawing.Size(155, 18);
        this.lblLopPhong.Text = "Phòng học:";
        this.cboLopPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLopPhong.Location = new System.Drawing.Point(175, 135);
        this.cboLopPhong.Name = "cboLopPhong";
        this.cboLopPhong.Size = new System.Drawing.Size(155, 25);

        this.lblLopThu.Location = new System.Drawing.Point(12, 170);
        this.lblLopThu.Name = "lblLopThu";
        this.lblLopThu.Size = new System.Drawing.Size(318, 18);
        this.lblLopThu.Text = "Thứ học trong tuần:";
        this.cboLopThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLopThu.Items.AddRange(new object[] { "T2-T4-T6", "T3-T5-T7", "T7-CN" });
        this.cboLopThu.Location = new System.Drawing.Point(12, 190);
        this.cboLopThu.Name = "cboLopThu";
        this.cboLopThu.Size = new System.Drawing.Size(318, 25);

        this.lblLopGioBD.Location = new System.Drawing.Point(12, 225);
        this.lblLopGioBD.Name = "lblLopGioBD";
        this.lblLopGioBD.Size = new System.Drawing.Size(150, 18);
        this.lblLopGioBD.Text = "Giờ bắt đầu (vd: 18:00):";
        this.txtLopGioBD.Location = new System.Drawing.Point(12, 245);
        this.txtLopGioBD.Name = "txtLopGioBD";
        this.txtLopGioBD.Size = new System.Drawing.Size(150, 25);

        this.lblLopGioKT.Location = new System.Drawing.Point(175, 225);
        this.lblLopGioKT.Name = "lblLopGioKT";
        this.lblLopGioKT.Size = new System.Drawing.Size(155, 18);
        this.lblLopGioKT.Text = "Giờ kết thúc (19:30):";
        this.txtLopGioKT.Location = new System.Drawing.Point(175, 245);
        this.txtLopGioKT.Name = "txtLopGioKT";
        this.txtLopGioKT.Size = new System.Drawing.Size(155, 25);

        this.lblLopSiSo.Location = new System.Drawing.Point(12, 280);
        this.lblLopSiSo.Name = "lblLopSiSo";
        this.lblLopSiSo.Size = new System.Drawing.Size(150, 18);
        this.lblLopSiSo.Text = "Sĩ số tối đa:";
        this.numLopSiSo.Location = new System.Drawing.Point(12, 300);
        this.numLopSiSo.Name = "numLopSiSo";
        this.numLopSiSo.Size = new System.Drawing.Size(150, 25);
        this.numLopSiSo.Value = new decimal(20);

        this.lblLopKhaiGiang.Location = new System.Drawing.Point(175, 280);
        this.lblLopKhaiGiang.Name = "lblLopKhaiGiang";
        this.lblLopKhaiGiang.Size = new System.Drawing.Size(155, 18);
        this.lblLopKhaiGiang.Text = "Ngày khai giảng:";
        this.dtpLopKhaiGiang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpLopKhaiGiang.Location = new System.Drawing.Point(175, 300);
        this.dtpLopKhaiGiang.Name = "dtpLopKhaiGiang";
        this.dtpLopKhaiGiang.Size = new System.Drawing.Size(155, 25);

        this.btnNewLop.BackColor = System.Drawing.Color.White;
        this.btnNewLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnNewLop.Location = new System.Drawing.Point(12, 350);
        this.btnNewLop.Name = "btnNewLop";
        this.btnNewLop.Size = new System.Drawing.Size(95, 35);
        this.btnNewLop.Text = "Làm mới";

        this.btnSaveLop.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnSaveLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveLop.ForeColor = System.Drawing.Color.White;
        this.btnSaveLop.Location = new System.Drawing.Point(115, 350);
        this.btnSaveLop.Name = "btnSaveLop";
        this.btnSaveLop.Size = new System.Drawing.Size(120, 35);
        this.btnSaveLop.Text = "💾 Lưu Lớp";

        this.btnDeleteLop.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
        this.btnDeleteLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDeleteLop.ForeColor = System.Drawing.Color.White;
        this.btnDeleteLop.Location = new System.Drawing.Point(245, 350);
        this.btnDeleteLop.Name = "btnDeleteLop";
        this.btnDeleteLop.Size = new System.Drawing.Size(85, 35);
        this.btnDeleteLop.Text = "Xóa";

        // ==========================================
        // TAB 3: SCHEDULER & CONFLICT CHECKING
        // ==========================================
        this.tabSchedule.BackColor = System.Drawing.Color.White;
        this.tabSchedule.Controls.Add(this.pnlScheduleTop);
        this.tabSchedule.Controls.Add(this.lblAllSchedTitle);
        this.tabSchedule.Controls.Add(this.dgvAllSchedules);
        this.tabSchedule.Location = new System.Drawing.Point(4, 25);
        this.tabSchedule.Name = "tabSchedule";
        this.tabSchedule.Padding = new System.Windows.Forms.Padding(10);
        this.tabSchedule.Size = new System.Drawing.Size(1078, 641);
        this.tabSchedule.TabIndex = 2;
        this.tabSchedule.Text = "Xếp lịch & Trùng lịch";

        this.pnlScheduleTop.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlScheduleTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlScheduleTop.Controls.Add(this.lblSchedFormTitle);
        this.pnlScheduleTop.Controls.Add(this.lblSchedPhong);
        this.pnlScheduleTop.Controls.Add(this.cboSchedPhong);
        this.pnlScheduleTop.Controls.Add(this.lblSchedGV);
        this.pnlScheduleTop.Controls.Add(this.cboSchedGV);
        this.pnlScheduleTop.Controls.Add(this.lblSchedThu);
        this.pnlScheduleTop.Controls.Add(this.cboSchedThu);
        this.pnlScheduleTop.Controls.Add(this.lblSchedGioBD);
        this.pnlScheduleTop.Controls.Add(this.txtSchedGioBD);
        this.pnlScheduleTop.Controls.Add(this.lblSchedGioKT);
        this.pnlScheduleTop.Controls.Add(this.txtSchedGioKT);
        this.pnlScheduleTop.Controls.Add(this.btnCheckConflict);
        this.pnlScheduleTop.Controls.Add(this.pnlConflictAlertBox);
        this.pnlScheduleTop.Location = new System.Drawing.Point(10, 10);
        this.pnlScheduleTop.Name = "pnlScheduleTop";
        this.pnlScheduleTop.Size = new System.Drawing.Size(1055, 175);
        this.pnlScheduleTop.TabIndex = 0;

        this.lblSchedFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblSchedFormTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblSchedFormTitle.Location = new System.Drawing.Point(15, 10);
        this.lblSchedFormTitle.Name = "lblSchedFormTitle";
        this.lblSchedFormTitle.Size = new System.Drawing.Size(600, 22);
        this.lblSchedFormTitle.TabIndex = 0;
        this.lblSchedFormTitle.Text = "⚡ Công Cụ Kiểm Tra Xung Đột Xếp Lịch (Tránh Trùng Phòng / Trùng Giáo Viên)";

        this.lblSchedPhong.Location = new System.Drawing.Point(15, 40);
        this.lblSchedPhong.Name = "lblSchedPhong";
        this.lblSchedPhong.Size = new System.Drawing.Size(150, 18);
        this.lblSchedPhong.Text = "Chọn Phòng học:";
        this.cboSchedPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboSchedPhong.Location = new System.Drawing.Point(15, 60);
        this.cboSchedPhong.Name = "cboSchedPhong";
        this.cboSchedPhong.Size = new System.Drawing.Size(180, 25);

        this.lblSchedGV.Location = new System.Drawing.Point(210, 40);
        this.lblSchedGV.Name = "lblSchedGV";
        this.lblSchedGV.Size = new System.Drawing.Size(160, 18);
        this.lblSchedGV.Text = "Chọn Giáo viên:";
        this.cboSchedGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboSchedGV.Location = new System.Drawing.Point(210, 60);
        this.cboSchedGV.Name = "cboSchedGV";
        this.cboSchedGV.Size = new System.Drawing.Size(180, 25);

        this.lblSchedThu.Location = new System.Drawing.Point(405, 40);
        this.lblSchedThu.Name = "lblSchedThu";
        this.lblSchedThu.Size = new System.Drawing.Size(140, 18);
        this.lblSchedThu.Text = "Thứ học:";
        this.cboSchedThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboSchedThu.Items.AddRange(new object[] { "T2-T4-T6", "T3-T5-T7", "T7-CN" });
        this.cboSchedThu.Location = new System.Drawing.Point(405, 60);
        this.cboSchedThu.Name = "cboSchedThu";
        this.cboSchedThu.Size = new System.Drawing.Size(140, 25);

        this.lblSchedGioBD.Location = new System.Drawing.Point(560, 40);
        this.lblSchedGioBD.Name = "lblSchedGioBD";
        this.lblSchedGioBD.Size = new System.Drawing.Size(100, 18);
        this.lblSchedGioBD.Text = "Bắt đầu:";
        this.txtSchedGioBD.Location = new System.Drawing.Point(560, 60);
        this.txtSchedGioBD.Name = "txtSchedGioBD";
        this.txtSchedGioBD.Size = new System.Drawing.Size(100, 25);
        this.txtSchedGioBD.Text = "18:00";

        this.lblSchedGioKT.Location = new System.Drawing.Point(675, 40);
        this.lblSchedGioKT.Name = "lblSchedGioKT";
        this.lblSchedGioKT.Size = new System.Drawing.Size(100, 18);
        this.lblSchedGioKT.Text = "Kết thúc:";
        this.txtSchedGioKT.Location = new System.Drawing.Point(675, 60);
        this.txtSchedGioKT.Name = "txtSchedGioKT";
        this.txtSchedGioKT.Size = new System.Drawing.Size(100, 25);
        this.txtSchedGioKT.Text = "19:30";

        this.btnCheckConflict.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnCheckConflict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnCheckConflict.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.btnCheckConflict.ForeColor = System.Drawing.Color.White;
        this.btnCheckConflict.Location = new System.Drawing.Point(795, 50);
        this.btnCheckConflict.Name = "btnCheckConflict";
        this.btnCheckConflict.Size = new System.Drawing.Size(240, 38);
        this.btnCheckConflict.Text = "🔍 Kiểm Tra Xung Đột";
        this.btnCheckConflict.UseVisualStyleBackColor = false;

        this.pnlConflictAlertBox.BackColor = System.Drawing.Color.FromArgb(240, 253, 244);
        this.pnlConflictAlertBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlConflictAlertBox.Controls.Add(this.lblConflictResult);
        this.pnlConflictAlertBox.Location = new System.Drawing.Point(15, 100);
        this.pnlConflictAlertBox.Name = "pnlConflictAlertBox";
        this.pnlConflictAlertBox.Size = new System.Drawing.Size(1020, 60);
        this.pnlConflictAlertBox.TabIndex = 1;

        this.lblConflictResult.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblConflictResult.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52);
        this.lblConflictResult.Location = new System.Drawing.Point(15, 10);
        this.lblConflictResult.Name = "lblConflictResult";
        this.lblConflictResult.Size = new System.Drawing.Size(990, 40);
        this.lblConflictResult.TabIndex = 0;
        this.lblConflictResult.Text = "✅ Chưa phát hiện xung đột. Hãy chọn thông số và nhấn 'Kiểm Tra Xung Đột' để thẩm định!";

        this.lblAllSchedTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblAllSchedTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblAllSchedTitle.Location = new System.Drawing.Point(10, 195);
        this.lblAllSchedTitle.Name = "lblAllSchedTitle";
        this.lblAllSchedTitle.Size = new System.Drawing.Size(400, 25);
        this.lblAllSchedTitle.TabIndex = 1;
        this.lblAllSchedTitle.Text = "📋 Thời Khóa Biểu Hiện Tại Của Trung Tâm";

        this.dgvAllSchedules.AllowUserToAddRows = false;
        this.dgvAllSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvAllSchedules.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvAllSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvAllSchedules.Location = new System.Drawing.Point(10, 225);
        this.dgvAllSchedules.Name = "dgvAllSchedules";
        this.dgvAllSchedules.ReadOnly = true;
        this.dgvAllSchedules.RowHeadersVisible = false;
        this.dgvAllSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvAllSchedules.Size = new System.Drawing.Size(1055, 400);
        this.dgvAllSchedules.TabIndex = 2;

        // ==========================================
        // TAB 4: TUITION & REGISTRATION
        // ==========================================
        this.tabTuition.BackColor = System.Drawing.Color.White;
        this.tabTuition.Controls.Add(this.pnlRegForm);
        this.tabTuition.Controls.Add(this.tabRegSub);
        this.tabTuition.Location = new System.Drawing.Point(4, 25);
        this.tabTuition.Name = "tabTuition";
        this.tabTuition.Padding = new System.Windows.Forms.Padding(10);
        this.tabTuition.Size = new System.Drawing.Size(1078, 641);
        this.tabTuition.TabIndex = 3;
        this.tabTuition.Text = "Đăng ký & Học phí";

        this.pnlRegForm.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlRegForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlRegForm.Controls.Add(this.lblRegTitle);
        this.pnlRegForm.Controls.Add(this.lblRegHocVien);
        this.pnlRegForm.Controls.Add(this.cboRegHocVien);
        this.pnlRegForm.Controls.Add(this.btnQuickAddHV);
        this.pnlRegForm.Controls.Add(this.lblRegLop);
        this.pnlRegForm.Controls.Add(this.cboRegLop);
        this.pnlRegForm.Controls.Add(this.lblRegHocPhiGoc);
        this.pnlRegForm.Controls.Add(this.txtRegHocPhiGoc);
        this.pnlRegForm.Controls.Add(this.chkOldStudentDiscount);
        this.pnlRegForm.Controls.Add(this.chkGroupDiscount);
        this.pnlRegForm.Controls.Add(this.numGroupPercent);
        this.pnlRegForm.Controls.Add(this.lblRegTotalFee);
        this.pnlRegForm.Controls.Add(this.txtRegTotalFee);
        this.pnlRegForm.Controls.Add(this.lblRegPayAmount);
        this.pnlRegForm.Controls.Add(this.numRegPayAmount);
        this.pnlRegForm.Controls.Add(this.lblRegPaymentMethod);
        this.pnlRegForm.Controls.Add(this.cboRegPaymentMethod);
        this.pnlRegForm.Controls.Add(this.btnRegisterAndPrint);
        this.pnlRegForm.Location = new System.Drawing.Point(10, 10);
        this.pnlRegForm.Name = "pnlRegForm";
        this.pnlRegForm.Size = new System.Drawing.Size(1055, 175);
        this.pnlRegForm.TabIndex = 0;

        this.lblRegTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblRegTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblRegTitle.Location = new System.Drawing.Point(15, 8);
        this.lblRegTitle.Name = "lblRegTitle";
        this.lblRegTitle.Size = new System.Drawing.Size(600, 22);
        this.lblRegTitle.Text = "✍️ Ghi Danh Học Viên & Tính Học Phí (Áp Dụng Ưu Đãi / Đóng Nhiều Đợt)";

        this.lblRegHocVien.Location = new System.Drawing.Point(15, 38);
        this.lblRegHocVien.Name = "lblRegHocVien";
        this.lblRegHocVien.Size = new System.Drawing.Size(180, 18);
        this.lblRegHocVien.Text = "Chọn Học viên:";
        this.cboRegHocVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboRegHocVien.Location = new System.Drawing.Point(15, 58);
        this.cboRegHocVien.Name = "cboRegHocVien";
        this.cboRegHocVien.Size = new System.Drawing.Size(180, 25);

        this.btnQuickAddHV.BackColor = System.Drawing.Color.White;
        this.btnQuickAddHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnQuickAddHV.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.btnQuickAddHV.Location = new System.Drawing.Point(200, 58);
        this.btnQuickAddHV.Name = "btnQuickAddHV";
        this.btnQuickAddHV.Size = new System.Drawing.Size(65, 25);
        this.btnQuickAddHV.Text = "+ Thêm";

        this.lblRegLop.Location = new System.Drawing.Point(280, 38);
        this.lblRegLop.Name = "lblRegLop";
        this.lblRegLop.Size = new System.Drawing.Size(200, 18);
        this.lblRegLop.Text = "Chọn Lớp học:";
        this.cboRegLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboRegLop.Location = new System.Drawing.Point(280, 58);
        this.cboRegLop.Name = "cboRegLop";
        this.cboRegLop.Size = new System.Drawing.Size(200, 25);

        this.lblRegHocPhiGoc.Location = new System.Drawing.Point(495, 38);
        this.lblRegHocPhiGoc.Name = "lblRegHocPhiGoc";
        this.lblRegHocPhiGoc.Size = new System.Drawing.Size(130, 18);
        this.lblRegHocPhiGoc.Text = "Học phí gốc:";
        this.txtRegHocPhiGoc.Location = new System.Drawing.Point(495, 58);
        this.txtRegHocPhiGoc.Name = "txtRegHocPhiGoc";
        this.txtRegHocPhiGoc.ReadOnly = true;
        this.txtRegHocPhiGoc.Size = new System.Drawing.Size(130, 25);

        this.chkOldStudentDiscount.Location = new System.Drawing.Point(15, 95);
        this.chkOldStudentDiscount.Name = "chkOldStudentDiscount";
        this.chkOldStudentDiscount.Size = new System.Drawing.Size(210, 24);
        this.chkOldStudentDiscount.Text = "Học viên cũ (Giảm 10%)";

        this.chkGroupDiscount.Location = new System.Drawing.Point(230, 95);
        this.chkGroupDiscount.Name = "chkGroupDiscount";
        this.chkGroupDiscount.Size = new System.Drawing.Size(155, 24);
        this.chkGroupDiscount.Text = "Đăng ký nhóm (%)";

        this.numGroupPercent.Location = new System.Drawing.Point(390, 95);
        this.numGroupPercent.Maximum = new decimal(50);
        this.numGroupPercent.Name = "numGroupPercent";
        this.numGroupPercent.Size = new System.Drawing.Size(60, 25);
        this.numGroupPercent.Value = new decimal(5);

        this.lblRegTotalFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblRegTotalFee.Location = new System.Drawing.Point(495, 98);
        this.lblRegTotalFee.Name = "lblRegTotalFee";
        this.lblRegTotalFee.Size = new System.Drawing.Size(130, 18);
        this.lblRegTotalFee.Text = "Tổng phải đóng:";
        this.txtRegTotalFee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.txtRegTotalFee.ForeColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.txtRegTotalFee.Location = new System.Drawing.Point(495, 120);
        this.txtRegTotalFee.Name = "txtRegTotalFee";
        this.txtRegTotalFee.ReadOnly = true;
        this.txtRegTotalFee.Size = new System.Drawing.Size(130, 25);

        this.lblRegPayAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.lblRegPayAmount.Location = new System.Drawing.Point(645, 38);
        this.lblRegPayAmount.Name = "lblRegPayAmount";
        this.lblRegPayAmount.Size = new System.Drawing.Size(150, 18);
        this.lblRegPayAmount.Text = "Số tiền đóng đợt này:";
        this.numRegPayAmount.Increment = new decimal(500000);
        this.numRegPayAmount.Location = new System.Drawing.Point(645, 58);
        this.numRegPayAmount.Maximum = new decimal(100000000);
        this.numRegPayAmount.Name = "numRegPayAmount";
        this.numRegPayAmount.Size = new System.Drawing.Size(150, 25);

        this.lblRegPaymentMethod.Location = new System.Drawing.Point(645, 98);
        this.lblRegPaymentMethod.Name = "lblRegPaymentMethod";
        this.lblRegPaymentMethod.Size = new System.Drawing.Size(150, 18);
        this.lblRegPaymentMethod.Text = "Hình thức:";
        this.cboRegPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboRegPaymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Quẹt thẻ POS" });
        this.cboRegPaymentMethod.Location = new System.Drawing.Point(645, 120);
        this.cboRegPaymentMethod.Name = "cboRegPaymentMethod";
        this.cboRegPaymentMethod.Size = new System.Drawing.Size(150, 25);

        this.btnRegisterAndPrint.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
        this.btnRegisterAndPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRegisterAndPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnRegisterAndPrint.ForeColor = System.Drawing.Color.White;
        this.btnRegisterAndPrint.Location = new System.Drawing.Point(820, 55);
        this.btnRegisterAndPrint.Name = "btnRegisterAndPrint";
        this.btnRegisterAndPrint.Size = new System.Drawing.Size(215, 90);
        this.btnRegisterAndPrint.Text = "🧾 Ghi Danh &\nIn Biên Lai Thu Tiền";
        this.btnRegisterAndPrint.UseVisualStyleBackColor = false;

        this.tabRegSub.Controls.Add(this.tabSubDangKy);
        this.tabRegSub.Controls.Add(this.tabSubBienLai);
        this.tabRegSub.Location = new System.Drawing.Point(10, 195);
        this.tabRegSub.Name = "tabRegSub";
        this.tabRegSub.SelectedIndex = 0;
        this.tabRegSub.Size = new System.Drawing.Size(1055, 435);
        this.tabRegSub.TabIndex = 1;

        // SubTab: DangKy
        this.tabSubDangKy.Controls.Add(this.dgvDangKy);
        this.tabSubDangKy.Controls.Add(this.btnPayNextInstallment);
        this.tabSubDangKy.Location = new System.Drawing.Point(4, 25);
        this.tabSubDangKy.Name = "tabSubDangKy";
        this.tabSubDangKy.Padding = new System.Windows.Forms.Padding(5);
        this.tabSubDangKy.Size = new System.Drawing.Size(1047, 406);
        this.tabSubDangKy.TabIndex = 0;
        this.tabSubDangKy.Text = "Hồ sơ Đăng ký & Công nợ";

        this.dgvDangKy.AllowUserToAddRows = false;
        this.dgvDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvDangKy.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvDangKy.Location = new System.Drawing.Point(5, 5);
        this.dgvDangKy.Name = "dgvDangKy";
        this.dgvDangKy.ReadOnly = true;
        this.dgvDangKy.RowHeadersVisible = false;
        this.dgvDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvDangKy.Size = new System.Drawing.Size(1035, 350);
        this.dgvDangKy.TabIndex = 0;

        this.btnPayNextInstallment.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnPayNextInstallment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPayNextInstallment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnPayNextInstallment.ForeColor = System.Drawing.Color.White;
        this.btnPayNextInstallment.Location = new System.Drawing.Point(5, 362);
        this.btnPayNextInstallment.Name = "btnPayNextInstallment";
        this.btnPayNextInstallment.Size = new System.Drawing.Size(240, 36);
        this.btnPayNextInstallment.Text = "💳 Thu Tiền Đợt Kế Tiếp Cho Học Viên";
        this.btnPayNextInstallment.UseVisualStyleBackColor = false;

        // SubTab: BienLai
        this.tabSubBienLai.Controls.Add(this.dgvBienLai);
        this.tabSubBienLai.Controls.Add(this.btnReprintReceipt);
        this.tabSubBienLai.Location = new System.Drawing.Point(4, 25);
        this.tabSubBienLai.Name = "tabSubBienLai";
        this.tabSubBienLai.Padding = new System.Windows.Forms.Padding(5);
        this.tabSubBienLai.Size = new System.Drawing.Size(1047, 406);
        this.tabSubBienLai.TabIndex = 1;
        this.tabSubBienLai.Text = "Lịch sử Biên lai đã thu";

        this.dgvBienLai.AllowUserToAddRows = false;
        this.dgvBienLai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvBienLai.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvBienLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvBienLai.Location = new System.Drawing.Point(5, 5);
        this.dgvBienLai.Name = "dgvBienLai";
        this.dgvBienLai.ReadOnly = true;
        this.dgvBienLai.RowHeadersVisible = false;
        this.dgvBienLai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvBienLai.Size = new System.Drawing.Size(1035, 350);
        this.dgvBienLai.TabIndex = 0;

        this.btnReprintReceipt.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnReprintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnReprintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnReprintReceipt.ForeColor = System.Drawing.Color.White;
        this.btnReprintReceipt.Location = new System.Drawing.Point(5, 362);
        this.btnReprintReceipt.Name = "btnReprintReceipt";
        this.btnReprintReceipt.Size = new System.Drawing.Size(180, 36);
        this.btnReprintReceipt.Text = "🖨️ In lại Biên Lai Này";
        this.btnReprintReceipt.UseVisualStyleBackColor = false;

        // ==========================================
        // TAB 5: ATTENDANCE & > 3 ABSENCES ALERT
        // ==========================================
        this.tabAttendance.BackColor = System.Drawing.Color.White;
        this.tabAttendance.Controls.Add(this.pnlAttFilter);
        this.tabAttendance.Controls.Add(this.dgvAttendance);
        this.tabAttendance.Controls.Add(this.pnlAttWarning);
        this.tabAttendance.Location = new System.Drawing.Point(4, 25);
        this.tabAttendance.Name = "tabAttendance";
        this.tabAttendance.Padding = new System.Windows.Forms.Padding(10);
        this.tabAttendance.Size = new System.Drawing.Size(1078, 641);
        this.tabAttendance.TabIndex = 4;
        this.tabAttendance.Text = "Điểm danh (Cảnh báo)";

        this.pnlAttFilter.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlAttFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlAttFilter.Controls.Add(this.lblAttLop);
        this.pnlAttFilter.Controls.Add(this.cboAttLop);
        this.pnlAttFilter.Controls.Add(this.lblAttBuoi);
        this.pnlAttFilter.Controls.Add(this.numAttBuoi);
        this.pnlAttFilter.Controls.Add(this.lblAttNgay);
        this.pnlAttFilter.Controls.Add(this.dtpAttNgay);
        this.pnlAttFilter.Controls.Add(this.btnLoadAttendance);
        this.pnlAttFilter.Controls.Add(this.btnSaveAttendance);
        this.pnlAttFilter.Location = new System.Drawing.Point(10, 10);
        this.pnlAttFilter.Name = "pnlAttFilter";
        this.pnlAttFilter.Size = new System.Drawing.Size(1055, 60);
        this.pnlAttFilter.TabIndex = 0;

        this.lblAttLop.Location = new System.Drawing.Point(15, 20);
        this.lblAttLop.Name = "lblAttLop";
        this.lblAttLop.Size = new System.Drawing.Size(100, 20);
        this.lblAttLop.Text = "Chọn Lớp học:";
        this.cboAttLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboAttLop.Location = new System.Drawing.Point(115, 17);
        this.cboAttLop.Name = "cboAttLop";
        this.cboAttLop.Size = new System.Drawing.Size(220, 25);

        this.lblAttBuoi.Location = new System.Drawing.Point(355, 20);
        this.lblAttBuoi.Name = "lblAttBuoi";
        this.lblAttBuoi.Size = new System.Drawing.Size(60, 20);
        this.lblAttBuoi.Text = "Buổi số:";
        this.numAttBuoi.Location = new System.Drawing.Point(420, 17);
        this.numAttBuoi.Maximum = new decimal(60);
        this.numAttBuoi.Minimum = new decimal(1);
        this.numAttBuoi.Name = "numAttBuoi";
        this.numAttBuoi.Size = new System.Drawing.Size(60, 25);
        this.numAttBuoi.Value = new decimal(1);

        this.lblAttNgay.Location = new System.Drawing.Point(500, 20);
        this.lblAttNgay.Name = "lblAttNgay";
        this.lblAttNgay.Size = new System.Drawing.Size(70, 20);
        this.lblAttNgay.Text = "Ngày học:";
        this.dtpAttNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpAttNgay.Location = new System.Drawing.Point(575, 17);
        this.dtpAttNgay.Name = "dtpAttNgay";
        this.dtpAttNgay.Size = new System.Drawing.Size(120, 25);

        this.btnLoadAttendance.BackColor = System.Drawing.Color.White;
        this.btnLoadAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLoadAttendance.Location = new System.Drawing.Point(715, 13);
        this.btnLoadAttendance.Name = "btnLoadAttendance";
        this.btnLoadAttendance.Size = new System.Drawing.Size(140, 32);
        this.btnLoadAttendance.Text = "🔄 Tải Danh Sách";

        this.btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
        this.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveAttendance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnSaveAttendance.ForeColor = System.Drawing.Color.White;
        this.btnSaveAttendance.Location = new System.Drawing.Point(870, 13);
        this.btnSaveAttendance.Name = "btnSaveAttendance";
        this.btnSaveAttendance.Size = new System.Drawing.Size(165, 32);
        this.btnSaveAttendance.Text = "💾 Lưu Điểm Danh";

        this.dgvAttendance.AllowUserToAddRows = false;
        this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvAttendance.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvAttendance.Location = new System.Drawing.Point(10, 80);
        this.dgvAttendance.Name = "dgvAttendance";
        this.dgvAttendance.RowHeadersVisible = false;
        this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvAttendance.Size = new System.Drawing.Size(1055, 320);
        this.dgvAttendance.TabIndex = 1;

        this.pnlAttWarning.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
        this.pnlAttWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlAttWarning.Controls.Add(this.lblAttWarningTitle);
        this.pnlAttWarning.Controls.Add(this.dgvWarningAbsences);
        this.pnlAttWarning.Location = new System.Drawing.Point(10, 410);
        this.pnlAttWarning.Name = "pnlAttWarning";
        this.pnlAttWarning.Size = new System.Drawing.Size(1055, 215);
        this.pnlAttWarning.TabIndex = 2;

        this.lblAttWarningTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblAttWarningTitle.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
        this.lblAttWarningTitle.Location = new System.Drawing.Point(15, 10);
        this.lblAttWarningTitle.Name = "lblAttWarningTitle";
        this.lblAttWarningTitle.Size = new System.Drawing.Size(800, 22);
        this.lblAttWarningTitle.Text = "🚨 DANH SÁCH CẢNH BÁO: HỌC VIÊN VẮNG TỪ 3 BUỔI TRỞ LÊN (CẦN LỄ TÂN LIÊN HỆ)";

        this.dgvWarningAbsences.AllowUserToAddRows = false;
        this.dgvWarningAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvWarningAbsences.BackgroundColor = System.Drawing.Color.White;
        this.dgvWarningAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvWarningAbsences.Location = new System.Drawing.Point(15, 38);
        this.dgvWarningAbsences.Name = "dgvWarningAbsences";
        this.dgvWarningAbsences.ReadOnly = true;
        this.dgvWarningAbsences.RowHeadersVisible = false;
        this.dgvWarningAbsences.Size = new System.Drawing.Size(1020, 160);
        this.dgvWarningAbsences.TabIndex = 1;

        // ==========================================
        // TAB 6: GRADES & CERTIFICATE
        // ==========================================
        this.tabGrades.BackColor = System.Drawing.Color.White;
        this.tabGrades.Controls.Add(this.pnlGradeFilter);
        this.tabGrades.Controls.Add(this.dgvGrades);
        this.tabGrades.Location = new System.Drawing.Point(4, 25);
        this.tabGrades.Name = "tabGrades";
        this.tabGrades.Padding = new System.Windows.Forms.Padding(10);
        this.tabGrades.Size = new System.Drawing.Size(1078, 641);
        this.tabGrades.TabIndex = 5;
        this.tabGrades.Text = "Điểm & Chứng nhận";

        this.pnlGradeFilter.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlGradeFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlGradeFilter.Controls.Add(this.lblGradeLop);
        this.pnlGradeFilter.Controls.Add(this.cboGradeLop);
        this.pnlGradeFilter.Controls.Add(this.btnLoadGrades);
        this.pnlGradeFilter.Controls.Add(this.btnSaveGrades);
        this.pnlGradeFilter.Controls.Add(this.btnPrintCertificate);
        this.pnlGradeFilter.Location = new System.Drawing.Point(10, 10);
        this.pnlGradeFilter.Name = "pnlGradeFilter";
        this.pnlGradeFilter.Size = new System.Drawing.Size(1055, 60);
        this.pnlGradeFilter.TabIndex = 0;

        this.lblGradeLop.Location = new System.Drawing.Point(15, 20);
        this.lblGradeLop.Name = "lblGradeLop";
        this.lblGradeLop.Size = new System.Drawing.Size(100, 20);
        this.lblGradeLop.Text = "Chọn Lớp học:";
        this.cboGradeLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboGradeLop.Location = new System.Drawing.Point(120, 17);
        this.cboGradeLop.Name = "cboGradeLop";
        this.cboGradeLop.Size = new System.Drawing.Size(260, 25);

        this.btnLoadGrades.BackColor = System.Drawing.Color.White;
        this.btnLoadGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLoadGrades.Location = new System.Drawing.Point(400, 13);
        this.btnLoadGrades.Name = "btnLoadGrades";
        this.btnLoadGrades.Size = new System.Drawing.Size(130, 32);
        this.btnLoadGrades.Text = "🔄 Tải Bảng Điểm";

        this.btnSaveGrades.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
        this.btnSaveGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveGrades.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnSaveGrades.ForeColor = System.Drawing.Color.White;
        this.btnSaveGrades.Location = new System.Drawing.Point(545, 13);
        this.btnSaveGrades.Name = "btnSaveGrades";
        this.btnSaveGrades.Size = new System.Drawing.Size(190, 32);
        this.btnSaveGrades.Text = "💾 Lưu Điểm & Tính ĐTB";

        this.btnPrintCertificate.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnPrintCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPrintCertificate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnPrintCertificate.ForeColor = System.Drawing.Color.White;
        this.btnPrintCertificate.Location = new System.Drawing.Point(750, 13);
        this.btnPrintCertificate.Name = "btnPrintCertificate";
        this.btnPrintCertificate.Size = new System.Drawing.Size(285, 32);
        this.btnPrintCertificate.Text = "🎓 In Chứng Nhận Hoàn Thành Khóa Học";

        this.dgvGrades.AllowUserToAddRows = false;
        this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvGrades.BackgroundColor = System.Drawing.Color.FromArgb(248, 250, 252);
        this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvGrades.Location = new System.Drawing.Point(10, 80);
        this.dgvGrades.Name = "dgvGrades";
        this.dgvGrades.RowHeadersVisible = false;
        this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvGrades.Size = new System.Drawing.Size(1055, 545);
        this.dgvGrades.TabIndex = 1;

        // ==========================================
        // TAB 7: DATABASE & NAVICAT GUIDE
        // ==========================================
        this.tabDatabase.BackColor = System.Drawing.Color.White;
        this.tabDatabase.Controls.Add(this.pnlNavicatGuide);
        this.tabDatabase.Location = new System.Drawing.Point(4, 25);
        this.tabDatabase.Name = "tabDatabase";
        this.tabDatabase.Padding = new System.Windows.Forms.Padding(10);
        this.tabDatabase.Size = new System.Drawing.Size(1078, 641);
        this.tabDatabase.TabIndex = 6;
        this.tabDatabase.Text = "CSDL & Navicat";

        this.pnlNavicatGuide.BackColor = System.Drawing.Color.FromArgb(250, 252, 255);
        this.pnlNavicatGuide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlNavicatGuide.Controls.Add(this.lblNavicatTitle);
        this.pnlNavicatGuide.Controls.Add(this.txtNavicatGuide);
        this.pnlNavicatGuide.Controls.Add(this.btnOpenDbFolder);
        this.pnlNavicatGuide.Controls.Add(this.btnReloadSampleData);
        this.pnlNavicatGuide.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlNavicatGuide.Location = new System.Drawing.Point(10, 10);
        this.pnlNavicatGuide.Name = "pnlNavicatGuide";
        this.pnlNavicatGuide.Padding = new System.Windows.Forms.Padding(20);
        this.pnlNavicatGuide.Size = new System.Drawing.Size(1058, 621);
        this.pnlNavicatGuide.TabIndex = 0;

        this.lblNavicatTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblNavicatTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblNavicatTitle.Location = new System.Drawing.Point(20, 20);
        this.lblNavicatTitle.Name = "lblNavicatTitle";
        this.lblNavicatTitle.Size = new System.Drawing.Size(800, 30);
        this.lblNavicatTitle.Text = "🗄️ Hướng Dẫn Kết Nối CSDL SQLite Bằng Navicat for SQLite";

        this.txtNavicatGuide.BackColor = System.Drawing.Color.White;
        this.txtNavicatGuide.Font = new System.Drawing.Font("Consolas", 10F);
        this.txtNavicatGuide.Location = new System.Drawing.Point(20, 65);
        this.txtNavicatGuide.Multiline = true;
        this.txtNavicatGuide.Name = "txtNavicatGuide";
        this.txtNavicatGuide.ReadOnly = true;
        this.txtNavicatGuide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtNavicatGuide.Size = new System.Drawing.Size(1015, 470);
        this.txtNavicatGuide.TabIndex = 1;

        this.btnOpenDbFolder.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnOpenDbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnOpenDbFolder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnOpenDbFolder.ForeColor = System.Drawing.Color.White;
        this.btnOpenDbFolder.Location = new System.Drawing.Point(20, 550);
        this.btnOpenDbFolder.Name = "btnOpenDbFolder";
        this.btnOpenDbFolder.Size = new System.Drawing.Size(300, 42);
        this.btnOpenDbFolder.TabIndex = 2;
        this.btnOpenDbFolder.Text = "📁 Mở Thư Mục Chứa EduCenter.db";
        this.btnOpenDbFolder.UseVisualStyleBackColor = false;

        this.btnReloadSampleData.BackColor = System.Drawing.Color.White;
        this.btnReloadSampleData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnReloadSampleData.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnReloadSampleData.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.btnReloadSampleData.Location = new System.Drawing.Point(340, 550);
        this.btnReloadSampleData.Name = "btnReloadSampleData";
        this.btnReloadSampleData.Size = new System.Drawing.Size(260, 42);
        this.btnReloadSampleData.TabIndex = 3;
        this.btnReloadSampleData.Text = "🔄 Nạp Lại Dữ Liệu SQLite Mẫu";
        this.btnReloadSampleData.UseVisualStyleBackColor = false;

        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1366, 768);
        this.Controls.Add(this.pnlMainContainer);
        this.Controls.Add(this.pnlTopHeader);
        this.Controls.Add(this.pnlSidebar);
        this.MinimumSize = new System.Drawing.Size(1200, 700);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "EduCenter - Hệ Thống Quản Lý Trung Tâm Tiếng Anh";
        this.pnlSidebar.ResumeLayout(false);
        this.pnlUserSide.ResumeLayout(false);
        this.pnlTopHeader.ResumeLayout(false);
        this.pnlMainContainer.ResumeLayout(false);
        this.tabMain.ResumeLayout(false);
        this.tabDashboard.ResumeLayout(false);
        this.pnlStatCard1.ResumeLayout(false);
        this.pnlStatCard2.ResumeLayout(false);
        this.pnlStatCard3.ResumeLayout(false);
        this.pnlStatCard4.ResumeLayout(false);
        this.pnlBannerAlert.ResumeLayout(false);
        this.pnlDashSchedule.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvDashClasses)).EndInit();
        this.pnlDashTasks.ResumeLayout(false);
        this.tabCourses.ResumeLayout(false);
        this.tabCourseSub.ResumeLayout(false);
        this.tabSubKhoaHoc.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
        this.pnlKhoaHocForm.ResumeLayout(false);
        this.pnlKhoaHocForm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numHocPhiKH)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiKH)).EndInit();
        this.tabSubLopHoc.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
        this.pnlLopHocForm.ResumeLayout(false);
        this.pnlLopHocForm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numLopSiSo)).EndInit();
        this.tabSchedule.ResumeLayout(false);
        this.pnlScheduleTop.ResumeLayout(false);
        this.pnlScheduleTop.PerformLayout();
        this.pnlConflictAlertBox.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvAllSchedules)).EndInit();
        this.tabTuition.ResumeLayout(false);
        this.pnlRegForm.ResumeLayout(false);
        this.pnlRegForm.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.numGroupPercent)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.numRegPayAmount)).EndInit();
        this.tabRegSub.ResumeLayout(false);
        this.tabSubDangKy.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
        this.tabSubBienLai.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvBienLai)).EndInit();
        this.tabAttendance.ResumeLayout(false);
        this.pnlAttFilter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.numAttBuoi)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
        this.pnlAttWarning.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvWarningAbsences)).EndInit();
        this.tabGrades.ResumeLayout(false);
        this.pnlGradeFilter.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
        this.tabDatabase.ResumeLayout(false);
        this.pnlNavicatGuide.ResumeLayout(false);
        this.pnlNavicatGuide.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlSidebar;
    private System.Windows.Forms.Label lblBrand;
    private System.Windows.Forms.Label lblBrandSub;
    private System.Windows.Forms.Label lblNavHeader1;
    private System.Windows.Forms.Button btnNavDashboard;
    private System.Windows.Forms.Button btnNavCourses;
    private System.Windows.Forms.Button btnNavSchedule;
    private System.Windows.Forms.Button btnNavTuition;
    private System.Windows.Forms.Button btnNavAttendance;
    private System.Windows.Forms.Button btnNavGrades;
    private System.Windows.Forms.Label lblNavHeader2;
    private System.Windows.Forms.Button btnNavDatabase;
    private System.Windows.Forms.Panel pnlUserSide;
    private System.Windows.Forms.Label lblUserAvatar;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Label lblUserRole;
    private System.Windows.Forms.Panel pnlTopHeader;
    private System.Windows.Forms.Label lblHeaderGreeting;
    private System.Windows.Forms.Label lblHeaderDate;
    private System.Windows.Forms.Label lblAlertBadge;
    private System.Windows.Forms.Button btnLogout;
    private System.Windows.Forms.Panel pnlMainContainer;
    private System.Windows.Forms.TabControl tabMain;
    private System.Windows.Forms.TabPage tabDashboard;
    private System.Windows.Forms.Panel pnlStatCard1;
    private System.Windows.Forms.Label lblStat1Icon;
    private System.Windows.Forms.Label lblStat1Title;
    private System.Windows.Forms.Label lblStat1Val;
    private System.Windows.Forms.Panel pnlStatCard2;
    private System.Windows.Forms.Label lblStat2Icon;
    private System.Windows.Forms.Label lblStat2Title;
    private System.Windows.Forms.Label lblStat2Val;
    private System.Windows.Forms.Panel pnlStatCard3;
    private System.Windows.Forms.Label lblStat3Icon;
    private System.Windows.Forms.Label lblStat3Title;
    private System.Windows.Forms.Label lblStat3Val;
    private System.Windows.Forms.Panel pnlStatCard4;
    private System.Windows.Forms.Label lblStat4Icon;
    private System.Windows.Forms.Label lblStat4Title;
    private System.Windows.Forms.Label lblStat4Val;
    private System.Windows.Forms.Panel pnlBannerAlert;
    private System.Windows.Forms.Label lblAlertText;
    private System.Windows.Forms.Button btnViewAlertDetail;
    private System.Windows.Forms.Panel pnlDashSchedule;
    private System.Windows.Forms.Label lblDashSchedTitle;
    private System.Windows.Forms.DataGridView dgvDashClasses;
    private System.Windows.Forms.Panel pnlDashTasks;
    private System.Windows.Forms.Label lblDashTaskTitle;
    private System.Windows.Forms.Label lblTaskItem1;
    private System.Windows.Forms.Label lblTaskItem2;
    private System.Windows.Forms.Label lblTaskItem3;
    private System.Windows.Forms.Label lblTaskItem4;
    private System.Windows.Forms.TabPage tabCourses;
    private System.Windows.Forms.TabControl tabCourseSub;
    private System.Windows.Forms.TabPage tabSubKhoaHoc;
    private System.Windows.Forms.DataGridView dgvKhoaHoc;
    private System.Windows.Forms.Panel pnlKhoaHocForm;
    private System.Windows.Forms.Label lblMaKH;
    private System.Windows.Forms.TextBox txtMaKH;
    private System.Windows.Forms.Label lblTenKH;
    private System.Windows.Forms.TextBox txtTenKH;
    private System.Windows.Forms.Label lblHocPhiKH;
    private System.Windows.Forms.NumericUpDown numHocPhiKH;
    private System.Windows.Forms.Label lblSoBuoiKH;
    private System.Windows.Forms.NumericUpDown numSoBuoiKH;
    private System.Windows.Forms.Label lblMoTaKH;
    private System.Windows.Forms.TextBox txtMoTaKH;
    private System.Windows.Forms.Button btnNewKH;
    private System.Windows.Forms.Button btnSaveKH;
    private System.Windows.Forms.Button btnDeleteKH;
    private System.Windows.Forms.TabPage tabSubLopHoc;
    private System.Windows.Forms.DataGridView dgvLopHoc;
    private System.Windows.Forms.Panel pnlLopHocForm;
    private System.Windows.Forms.Label lblMaLop;
    private System.Windows.Forms.TextBox txtMaLop;
    private System.Windows.Forms.Label lblTenLop;
    private System.Windows.Forms.TextBox txtTenLop;
    private System.Windows.Forms.Label lblLopKhoaHoc;
    private System.Windows.Forms.ComboBox cboLopKhoaHoc;
    private System.Windows.Forms.Label lblLopGiaoVien;
    private System.Windows.Forms.ComboBox cboLopGiaoVien;
    private System.Windows.Forms.Label lblLopPhong;
    private System.Windows.Forms.ComboBox cboLopPhong;
    private System.Windows.Forms.Label lblLopThu;
    private System.Windows.Forms.ComboBox cboLopThu;
    private System.Windows.Forms.Label lblLopGioBD;
    private System.Windows.Forms.TextBox txtLopGioBD;
    private System.Windows.Forms.Label lblLopGioKT;
    private System.Windows.Forms.TextBox txtLopGioKT;
    private System.Windows.Forms.Label lblLopSiSo;
    private System.Windows.Forms.NumericUpDown numLopSiSo;
    private System.Windows.Forms.Label lblLopKhaiGiang;
    private System.Windows.Forms.DateTimePicker dtpLopKhaiGiang;
    private System.Windows.Forms.Button btnNewLop;
    private System.Windows.Forms.Button btnSaveLop;
    private System.Windows.Forms.Button btnDeleteLop;
    private System.Windows.Forms.TabPage tabSchedule;
    private System.Windows.Forms.Panel pnlScheduleTop;
    private System.Windows.Forms.Label lblSchedFormTitle;
    private System.Windows.Forms.Label lblSchedPhong;
    private System.Windows.Forms.ComboBox cboSchedPhong;
    private System.Windows.Forms.Label lblSchedGV;
    private System.Windows.Forms.ComboBox cboSchedGV;
    private System.Windows.Forms.Label lblSchedThu;
    private System.Windows.Forms.ComboBox cboSchedThu;
    private System.Windows.Forms.Label lblSchedGioBD;
    private System.Windows.Forms.TextBox txtSchedGioBD;
    private System.Windows.Forms.Label lblSchedGioKT;
    private System.Windows.Forms.TextBox txtSchedGioKT;
    private System.Windows.Forms.Button btnCheckConflict;
    private System.Windows.Forms.Panel pnlConflictAlertBox;
    private System.Windows.Forms.Label lblConflictResult;
    private System.Windows.Forms.Label lblAllSchedTitle;
    private System.Windows.Forms.DataGridView dgvAllSchedules;
    private System.Windows.Forms.TabPage tabTuition;
    private System.Windows.Forms.Panel pnlRegForm;
    private System.Windows.Forms.Label lblRegTitle;
    private System.Windows.Forms.Label lblRegHocVien;
    private System.Windows.Forms.ComboBox cboRegHocVien;
    private System.Windows.Forms.Button btnQuickAddHV;
    private System.Windows.Forms.Label lblRegLop;
    private System.Windows.Forms.ComboBox cboRegLop;
    private System.Windows.Forms.Label lblRegHocPhiGoc;
    private System.Windows.Forms.TextBox txtRegHocPhiGoc;
    private System.Windows.Forms.CheckBox chkOldStudentDiscount;
    private System.Windows.Forms.CheckBox chkGroupDiscount;
    private System.Windows.Forms.NumericUpDown numGroupPercent;
    private System.Windows.Forms.Label lblRegTotalFee;
    private System.Windows.Forms.TextBox txtRegTotalFee;
    private System.Windows.Forms.Label lblRegPayAmount;
    private System.Windows.Forms.NumericUpDown numRegPayAmount;
    private System.Windows.Forms.Label lblRegPaymentMethod;
    private System.Windows.Forms.ComboBox cboRegPaymentMethod;
    private System.Windows.Forms.Button btnRegisterAndPrint;
    private System.Windows.Forms.TabControl tabRegSub;
    private System.Windows.Forms.TabPage tabSubDangKy;
    private System.Windows.Forms.DataGridView dgvDangKy;
    private System.Windows.Forms.Button btnPayNextInstallment;
    private System.Windows.Forms.TabPage tabSubBienLai;
    private System.Windows.Forms.DataGridView dgvBienLai;
    private System.Windows.Forms.Button btnReprintReceipt;
    private System.Windows.Forms.TabPage tabAttendance;
    private System.Windows.Forms.Panel pnlAttFilter;
    private System.Windows.Forms.Label lblAttLop;
    private System.Windows.Forms.ComboBox cboAttLop;
    private System.Windows.Forms.Label lblAttBuoi;
    private System.Windows.Forms.NumericUpDown numAttBuoi;
    private System.Windows.Forms.Label lblAttNgay;
    private System.Windows.Forms.DateTimePicker dtpAttNgay;
    private System.Windows.Forms.Button btnLoadAttendance;
    private System.Windows.Forms.Button btnSaveAttendance;
    private System.Windows.Forms.DataGridView dgvAttendance;
    private System.Windows.Forms.Panel pnlAttWarning;
    private System.Windows.Forms.Label lblAttWarningTitle;
    private System.Windows.Forms.DataGridView dgvWarningAbsences;
    private System.Windows.Forms.TabPage tabGrades;
    private System.Windows.Forms.Panel pnlGradeFilter;
    private System.Windows.Forms.Label lblGradeLop;
    private System.Windows.Forms.ComboBox cboGradeLop;
    private System.Windows.Forms.Button btnLoadGrades;
    private System.Windows.Forms.Button btnSaveGrades;
    private System.Windows.Forms.Button btnPrintCertificate;
    private System.Windows.Forms.DataGridView dgvGrades;
    private System.Windows.Forms.TabPage tabDatabase;
    private System.Windows.Forms.Panel pnlNavicatGuide;
    private System.Windows.Forms.Label lblNavicatTitle;
    private System.Windows.Forms.TextBox txtNavicatGuide;
    private System.Windows.Forms.Button btnOpenDbFolder;
    private System.Windows.Forms.Button btnReloadSampleData;
}
