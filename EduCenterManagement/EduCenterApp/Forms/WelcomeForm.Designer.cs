namespace EduCenterApp.Forms;

partial class WelcomeForm
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
        this.pnlLeft = new System.Windows.Forms.Panel();
        this.lblLogo = new System.Windows.Forms.Label();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.lblChooseRole = new System.Windows.Forms.Label();
        this.btnRoleAdmin = new System.Windows.Forms.Button();
        this.btnRoleTeacher = new System.Windows.Forms.Button();
        this.btnRoleStudent = new System.Windows.Forms.Button();
        this.lblFooterInfo = new System.Windows.Forms.Label();
        this.pnlRight = new System.Windows.Forms.Panel();
        this.lblHeroBadge = new System.Windows.Forms.Label();
        this.lblHeroTitle = new System.Windows.Forms.Label();
        this.lblHeroDesc = new System.Windows.Forms.Label();
        this.pnlFeature1 = new System.Windows.Forms.Panel();
        this.lblFeat1Icon = new System.Windows.Forms.Label();
        this.lblFeat1Title = new System.Windows.Forms.Label();
        this.lblFeat1Desc = new System.Windows.Forms.Label();
        this.pnlFeature2 = new System.Windows.Forms.Panel();
        this.lblFeat2Icon = new System.Windows.Forms.Label();
        this.lblFeat2Title = new System.Windows.Forms.Label();
        this.lblFeat2Desc = new System.Windows.Forms.Label();
        this.pnlFeature3 = new System.Windows.Forms.Panel();
        this.lblFeat3Icon = new System.Windows.Forms.Label();
        this.lblFeat3Title = new System.Windows.Forms.Label();
        this.lblFeat3Desc = new System.Windows.Forms.Label();
        this.pnlFeature4 = new System.Windows.Forms.Panel();
        this.lblFeat4Icon = new System.Windows.Forms.Label();
        this.lblFeat4Title = new System.Windows.Forms.Label();
        this.lblFeat4Desc = new System.Windows.Forms.Label();
        this.pnlLeft.SuspendLayout();
        this.pnlRight.SuspendLayout();
        this.pnlFeature1.SuspendLayout();
        this.pnlFeature2.SuspendLayout();
        this.pnlFeature3.SuspendLayout();
        this.pnlFeature4.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlLeft
        // 
        this.pnlLeft.BackColor = System.Drawing.Color.White;
        this.pnlLeft.Controls.Add(this.lblFooterInfo);
        this.pnlLeft.Controls.Add(this.btnRoleStudent);
        this.pnlLeft.Controls.Add(this.btnRoleTeacher);
        this.pnlLeft.Controls.Add(this.btnRoleAdmin);
        this.pnlLeft.Controls.Add(this.lblChooseRole);
        this.pnlLeft.Controls.Add(this.lblSubtitle);
        this.pnlLeft.Controls.Add(this.lblTitle);
        this.pnlLeft.Controls.Add(this.lblLogo);
        this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
        this.pnlLeft.Location = new System.Drawing.Point(0, 0);
        this.pnlLeft.Name = "pnlLeft";
        this.pnlLeft.Padding = new System.Windows.Forms.Padding(40);
        this.pnlLeft.Size = new System.Drawing.Size(460, 680);
        this.pnlLeft.TabIndex = 0;
        // 
        // lblLogo
        // 
        this.lblLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
        this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblLogo.ForeColor = System.Drawing.Color.White;
        this.lblLogo.Location = new System.Drawing.Point(40, 40);
        this.lblLogo.Name = "lblLogo";
        this.lblLogo.Size = new System.Drawing.Size(56, 56);
        this.lblLogo.TabIndex = 0;
        this.lblLogo.Text = "🎓";
        this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
        this.lblTitle.Location = new System.Drawing.Point(105, 45);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(226, 37);
        this.lblTitle.TabIndex = 1;
        this.lblTitle.Text = "EduCenter PRO";
        // 
        // lblSubtitle
        // 
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
        this.lblSubtitle.Location = new System.Drawing.Point(108, 82);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Size = new System.Drawing.Size(248, 19);
        this.lblSubtitle.TabIndex = 2;
        this.lblSubtitle.Text = "Hệ thống Quản lý Đào tạo & Ngoại ngữ";
        // 
        // lblChooseRole
        // 
        this.lblChooseRole.AutoSize = true;
        this.lblChooseRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblChooseRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
        this.lblChooseRole.Location = new System.Drawing.Point(40, 150);
        this.lblChooseRole.Name = "lblChooseRole";
        this.lblChooseRole.Size = new System.Drawing.Size(306, 20);
        this.lblChooseRole.TabIndex = 3;
        this.lblChooseRole.Text = "Chọn vai trò để đăng nhập vào hệ thống:";
        // 
        // btnRoleAdmin
        // 
        this.btnRoleAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
        this.btnRoleAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnRoleAdmin.FlatAppearance.BorderSize = 0;
        this.btnRoleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRoleAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnRoleAdmin.ForeColor = System.Drawing.Color.White;
        this.btnRoleAdmin.Location = new System.Drawing.Point(40, 190);
        this.btnRoleAdmin.Name = "btnRoleAdmin";
        this.btnRoleAdmin.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
        this.btnRoleAdmin.Size = new System.Drawing.Size(380, 85);
        this.btnRoleAdmin.TabIndex = 4;
        this.btnRoleAdmin.Text = "👑  CỔNG QUẢN TRỊ VIÊN (ADMIN)\r\nToàn quyền quản lý: Lớp, Xếp lịch, Học phí, Điểm danh";
        this.btnRoleAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnRoleAdmin.UseVisualStyleBackColor = false;
        // 
        // btnRoleTeacher
        // 
        this.btnRoleTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
        this.btnRoleTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnRoleTeacher.FlatAppearance.BorderSize = 0;
        this.btnRoleTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRoleTeacher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnRoleTeacher.ForeColor = System.Drawing.Color.White;
        this.btnRoleTeacher.Location = new System.Drawing.Point(40, 290);
        this.btnRoleTeacher.Name = "btnRoleTeacher";
        this.btnRoleTeacher.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
        this.btnRoleTeacher.Size = new System.Drawing.Size(380, 85);
        this.btnRoleTeacher.TabIndex = 5;
        this.btnRoleTeacher.Text = "👨‍🏫  CỔNG GIÁO VIÊN / GIẢNG VIÊN\r\nXem lịch dạy cá nhân, Điểm danh buổi học, Nhập điểm";
        this.btnRoleTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnRoleTeacher.UseVisualStyleBackColor = false;
        // 
        // btnRoleStudent
        // 
        this.btnRoleStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
        this.btnRoleStudent.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnRoleStudent.FlatAppearance.BorderSize = 0;
        this.btnRoleStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRoleStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnRoleStudent.ForeColor = System.Drawing.Color.White;
        this.btnRoleStudent.Location = new System.Drawing.Point(40, 390);
        this.btnRoleStudent.Name = "btnRoleStudent";
        this.btnRoleStudent.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
        this.btnRoleStudent.Size = new System.Drawing.Size(380, 85);
        this.btnRoleStudent.TabIndex = 6;
        this.btnRoleStudent.Text = "🎓  CỔNG HỌC VIÊN / KHÁCH HÀNG\r\nTra cứu lớp học, xem lịch học, học phí & chứng nhận";
        this.btnRoleStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnRoleStudent.UseVisualStyleBackColor = false;
        // 
        // lblFooterInfo
        // 
        this.lblFooterInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblFooterInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblFooterInfo.Location = new System.Drawing.Point(40, 560);
        this.lblFooterInfo.Name = "lblFooterInfo";
        this.lblFooterInfo.Size = new System.Drawing.Size(380, 80);
        this.lblFooterInfo.TabIndex = 7;
        this.lblFooterInfo.Text = "• Cơ sở dữ liệu: SQLite 3 (EduCenter.db)\r\n• Kết nối trực tiếp Navicat for SQLite\r\n• Thiết kế chuẩn JetBrains Rider Design Mode\r\n• Phiên bản 1.0.0 — Bản quyền © EduCenter";
        // 
        // pnlRight
        // 
        this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
        this.pnlRight.Controls.Add(this.pnlFeature4);
        this.pnlRight.Controls.Add(this.pnlFeature3);
        this.pnlRight.Controls.Add(this.pnlFeature2);
        this.pnlRight.Controls.Add(this.pnlFeature1);
        this.pnlRight.Controls.Add(this.lblHeroDesc);
        this.pnlRight.Controls.Add(this.lblHeroTitle);
        this.pnlRight.Controls.Add(this.lblHeroBadge);
        this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlRight.Location = new System.Drawing.Point(460, 0);
        this.pnlRight.Name = "pnlRight";
        this.pnlRight.Padding = new System.Windows.Forms.Padding(50);
        this.pnlRight.Size = new System.Drawing.Size(624, 680);
        this.pnlRight.TabIndex = 1;
        // 
        // lblHeroBadge
        // 
        this.lblHeroBadge.AutoSize = true;
        this.lblHeroBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
        this.lblHeroBadge.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblHeroBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
        this.lblHeroBadge.Location = new System.Drawing.Point(50, 45);
        this.lblHeroBadge.Name = "lblHeroBadge";
        this.lblHeroBadge.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
        this.lblHeroBadge.Size = new System.Drawing.Size(262, 27);
        this.lblHeroBadge.TabIndex = 0;
        this.lblHeroBadge.Text = "★ NỀN TẢNG ĐÀO TẠO THÔNG MINH";
        // 
        // lblHeroTitle
        // 
        this.lblHeroTitle.AutoSize = true;
        this.lblHeroTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        this.lblHeroTitle.ForeColor = System.Drawing.Color.White;
        this.lblHeroTitle.Location = new System.Drawing.Point(46, 85);
        this.lblHeroTitle.Name = "lblHeroTitle";
        this.lblHeroTitle.Size = new System.Drawing.Size(496, 82);
        this.lblHeroTitle.TabIndex = 1;
        this.lblHeroTitle.Text = "Quản lý Trung tâm Tiếng Anh\r\nChuyên nghiệp & Toàn diện";
        // 
        // lblHeroDesc
        // 
        this.lblHeroDesc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
        this.lblHeroDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblHeroDesc.Location = new System.Drawing.Point(48, 175);
        this.lblHeroDesc.Name = "lblHeroDesc";
        this.lblHeroDesc.Size = new System.Drawing.Size(520, 45);
        this.lblHeroDesc.TabIndex = 2;
        this.lblHeroDesc.Text = "Giải pháp số hóa trung tâm đào tạo đáp ứng đầy đủ nghiệp vụ xếp lịch, học phí, điểm danh cảnh báo và cấp chứng nhận hoàn thành.";
        // 
        // pnlFeature1
        // 
        this.pnlFeature1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
        this.pnlFeature1.Controls.Add(this.lblFeat1Desc);
        this.pnlFeature1.Controls.Add(this.lblFeat1Title);
        this.pnlFeature1.Controls.Add(this.lblFeat1Icon);
        this.pnlFeature1.Location = new System.Drawing.Point(50, 235);
        this.pnlFeature1.Name = "pnlFeature1";
        this.pnlFeature1.Size = new System.Drawing.Size(520, 80);
        this.pnlFeature1.TabIndex = 3;
        // 
        // lblFeat1Icon
        // 
        this.lblFeat1Icon.Font = new System.Drawing.Font("Segoe UI", 18F);
        this.lblFeat1Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
        this.lblFeat1Icon.Location = new System.Drawing.Point(12, 16);
        this.lblFeat1Icon.Name = "lblFeat1Icon";
        this.lblFeat1Icon.Size = new System.Drawing.Size(48, 48);
        this.lblFeat1Icon.TabIndex = 0;
        this.lblFeat1Icon.Text = "🛡️";
        this.lblFeat1Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblFeat1Title
        // 
        this.lblFeat1Title.AutoSize = true;
        this.lblFeat1Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblFeat1Title.ForeColor = System.Drawing.Color.White;
        this.lblFeat1Title.Location = new System.Drawing.Point(68, 15);
        this.lblFeat1Title.Name = "lblFeat1Title";
        this.lblFeat1Title.Size = new System.Drawing.Size(378, 20);
        this.lblFeat1Title.TabIndex = 1;
        this.lblFeat1Title.Text = "Xếp lịch thông minh — Tự động ngăn chặn xung đột";
        // 
        // lblFeat1Desc
        // 
        this.lblFeat1Desc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblFeat1Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblFeat1Desc.Location = new System.Drawing.Point(68, 38);
        this.lblFeat1Desc.Name = "lblFeat1Desc";
        this.lblFeat1Desc.Size = new System.Drawing.Size(435, 35);
        this.lblFeat1Desc.TabIndex = 2;
        this.lblFeat1Desc.Text = "Kiểm tra tức thời tránh 2 lớp trùng phòng học hoặc 1 giáo viên trùng lịch dạy cùng 1 giờ.";
        // 
        // pnlFeature2
        // 
        this.pnlFeature2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
        this.pnlFeature2.Controls.Add(this.lblFeat2Desc);
        this.pnlFeature2.Controls.Add(this.lblFeat2Title);
        this.pnlFeature2.Controls.Add(this.lblFeat2Icon);
        this.pnlFeature2.Location = new System.Drawing.Point(50, 325);
        this.pnlFeature2.Name = "pnlFeature2";
        this.pnlFeature2.Size = new System.Drawing.Size(520, 80);
        this.pnlFeature2.TabIndex = 4;
        // 
        // lblFeat2Icon
        // 
        this.lblFeat2Icon.Font = new System.Drawing.Font("Segoe UI", 18F);
        this.lblFeat2Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
        this.lblFeat2Icon.Location = new System.Drawing.Point(12, 16);
        this.lblFeat2Icon.Name = "lblFeat2Icon";
        this.lblFeat2Icon.Size = new System.Drawing.Size(48, 48);
        this.lblFeat2Icon.TabIndex = 0;
        this.lblFeat2Icon.Text = "💳";
        this.lblFeat2Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblFeat2Title
        // 
        this.lblFeat2Title.AutoSize = true;
        this.lblFeat2Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblFeat2Title.ForeColor = System.Drawing.Color.White;
        this.lblFeat2Title.Location = new System.Drawing.Point(68, 15);
        this.lblFeat2Title.Name = "lblFeat2Title";
        this.lblFeat2Title.Size = new System.Drawing.Size(374, 20);
        this.lblFeat2Title.TabIndex = 1;
        this.lblFeat2Title.Text = "Thu học phí nhiều đợt & In biên lai tích hợp QR Code";
        // 
        // lblFeat2Desc
        // 
        this.lblFeat2Desc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblFeat2Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblFeat2Desc.Location = new System.Drawing.Point(68, 38);
        this.lblFeat2Desc.Name = "lblFeat2Desc";
        this.lblFeat2Desc.Size = new System.Drawing.Size(435, 35);
        this.lblFeat2Desc.TabIndex = 2;
        this.lblFeat2Desc.Text = "Áp dụng giảm 10% học viên cũ, giảm giá nhóm, thanh toán 1 lần hoặc đóng nhiều đợt.";
        // 
        // pnlFeature3
        // 
        this.pnlFeature3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
        this.pnlFeature3.Controls.Add(this.lblFeat3Desc);
        this.pnlFeature3.Controls.Add(this.lblFeat3Title);
        this.pnlFeature3.Controls.Add(this.lblFeat3Icon);
        this.pnlFeature3.Location = new System.Drawing.Point(50, 415);
        this.pnlFeature3.Name = "pnlFeature3";
        this.pnlFeature3.Size = new System.Drawing.Size(520, 80);
        this.pnlFeature3.TabIndex = 5;
        // 
        // lblFeat3Icon
        // 
        this.lblFeat3Icon.Font = new System.Drawing.Font("Segoe UI", 18F);
        this.lblFeat3Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
        this.lblFeat3Icon.Location = new System.Drawing.Point(12, 16);
        this.lblFeat3Icon.Name = "lblFeat3Icon";
        this.lblFeat3Icon.Size = new System.Drawing.Size(48, 48);
        this.lblFeat3Icon.TabIndex = 0;
        this.lblFeat3Icon.Text = "⚠️";
        this.lblFeat3Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblFeat3Title
        // 
        this.lblFeat3Title.AutoSize = true;
        this.lblFeat3Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblFeat3Title.ForeColor = System.Drawing.Color.White;
        this.lblFeat3Title.Location = new System.Drawing.Point(68, 15);
        this.lblFeat3Title.Name = "lblFeat3Title";
        this.lblFeat3Title.Size = new System.Drawing.Size(406, 20);
        this.lblFeat3Title.TabIndex = 1;
        this.lblFeat3Title.Text = "Điểm danh & Cảnh báo vắng học vượt quá 3 buổi học";
        // 
        // lblFeat3Desc
        // 
        this.lblFeat3Desc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblFeat3Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblFeat3Desc.Location = new System.Drawing.Point(68, 38);
        this.lblFeat3Desc.Name = "lblFeat3Desc";
        this.lblFeat3Desc.Size = new System.Drawing.Size(435, 35);
        this.lblFeat3Desc.TabIndex = 2;
        this.lblFeat3Desc.Text = "Theo dõi chuyên cần từng buổi, tự động bật cờ cảnh báo đỏ để lễ tân gọi điện nhắc nhở.";
        // 
        // pnlFeature4
        // 
        this.pnlFeature4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
        this.pnlFeature4.Controls.Add(this.lblFeat4Desc);
        this.pnlFeature4.Controls.Add(this.lblFeat4Title);
        this.pnlFeature4.Controls.Add(this.lblFeat4Icon);
        this.pnlFeature4.Location = new System.Drawing.Point(50, 505);
        this.pnlFeature4.Name = "pnlFeature4";
        this.pnlFeature4.Size = new System.Drawing.Size(520, 80);
        this.pnlFeature4.TabIndex = 6;
        // 
        // lblFeat4Icon
        // 
        this.lblFeat4Icon.Font = new System.Drawing.Font("Segoe UI", 18F);
        this.lblFeat4Icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
        this.lblFeat4Icon.Location = new System.Drawing.Point(12, 16);
        this.lblFeat4Icon.Name = "lblFeat4Icon";
        this.lblFeat4Icon.Size = new System.Drawing.Size(48, 48);
        this.lblFeat4Icon.TabIndex = 0;
        this.lblFeat4Icon.Text = "📜";
        this.lblFeat4Icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblFeat4Title
        // 
        this.lblFeat4Title.AutoSize = true;
        this.lblFeat4Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblFeat4Title.ForeColor = System.Drawing.Color.White;
        this.lblFeat4Title.Location = new System.Drawing.Point(68, 15);
        this.lblFeat4Title.Name = "lblFeat4Title";
        this.lblFeat4Title.Size = new System.Drawing.Size(378, 20);
        this.lblFeat4Title.TabIndex = 1;
        this.lblFeat4Title.Text = "Tính ĐTB tự động & In Giấy chứng nhận hoàn thành";
        // 
        // lblFeat4Desc
        // 
        this.lblFeat4Desc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblFeat4Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
        this.lblFeat4Desc.Location = new System.Drawing.Point(68, 38);
        this.lblFeat4Desc.Name = "lblFeat4Desc";
        this.lblFeat4Desc.Size = new System.Drawing.Size(435, 35);
        this.lblFeat4Desc.TabIndex = 2;
        this.lblFeat4Desc.Text = "Nhập điểm giữa kỳ, cuối kỳ -> tính điểm TB, xếp loại và xem/in chứng nhận tốt nghiệp.";
        // 
        // WelcomeForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
        this.ClientSize = new System.Drawing.Size(1084, 680);
        this.Controls.Add(this.pnlRight);
        this.Controls.Add(this.pnlLeft);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "WelcomeForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "EduCenter PRO — Cổng Đăng Nhập & Chào Mừng";
        this.pnlLeft.ResumeLayout(false);
        this.pnlLeft.PerformLayout();
        this.pnlRight.ResumeLayout(false);
        this.pnlRight.PerformLayout();
        this.pnlFeature1.ResumeLayout(false);
        this.pnlFeature1.PerformLayout();
        this.pnlFeature2.ResumeLayout(false);
        this.pnlFeature2.PerformLayout();
        this.pnlFeature3.ResumeLayout(false);
        this.pnlFeature3.PerformLayout();
        this.pnlFeature4.ResumeLayout(false);
        this.pnlFeature4.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Label lblLogo;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Label lblChooseRole;
    private System.Windows.Forms.Button btnRoleAdmin;
    private System.Windows.Forms.Button btnRoleTeacher;
    private System.Windows.Forms.Button btnRoleStudent;
    private System.Windows.Forms.Label lblFooterInfo;
    private System.Windows.Forms.Panel pnlRight;
    private System.Windows.Forms.Label lblHeroBadge;
    private System.Windows.Forms.Label lblHeroTitle;
    private System.Windows.Forms.Label lblHeroDesc;
    private System.Windows.Forms.Panel pnlFeature1;
    private System.Windows.Forms.Label lblFeat1Icon;
    private System.Windows.Forms.Label lblFeat1Title;
    private System.Windows.Forms.Label lblFeat1Desc;
    private System.Windows.Forms.Panel pnlFeature2;
    private System.Windows.Forms.Label lblFeat2Icon;
    private System.Windows.Forms.Label lblFeat2Title;
    private System.Windows.Forms.Label lblFeat2Desc;
    private System.Windows.Forms.Panel pnlFeature3;
    private System.Windows.Forms.Label lblFeat3Icon;
    private System.Windows.Forms.Label lblFeat3Title;
    private System.Windows.Forms.Label lblFeat3Desc;
    private System.Windows.Forms.Panel pnlFeature4;
    private System.Windows.Forms.Label lblFeat4Icon;
    private System.Windows.Forms.Label lblFeat4Title;
    private System.Windows.Forms.Label lblFeat4Desc;
}
