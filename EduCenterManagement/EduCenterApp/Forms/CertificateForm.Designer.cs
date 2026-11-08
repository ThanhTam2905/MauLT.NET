namespace EduCenterApp.Forms;

partial class CertificateForm
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
        this.pnlCert = new System.Windows.Forms.Panel();
        this.pnlInnerBorder = new System.Windows.Forms.Panel();
        this.lblOrgName = new System.Windows.Forms.Label();
        this.lblCertTitle = new System.Windows.Forms.Label();
        this.lblCertSubtitle = new System.Windows.Forms.Label();
        this.lblPresentedTo = new System.Windows.Forms.Label();
        this.lblStudentName = new System.Windows.Forms.Label();
        this.lblLine1 = new System.Windows.Forms.Label();
        this.lblDescCourse = new System.Windows.Forms.Label();
        this.lblCourseName = new System.Windows.Forms.Label();
        this.lblScoreInfo = new System.Windows.Forms.Label();
        this.lblDateIssued = new System.Windows.Forms.Label();
        this.lblDirectorTitle = new System.Windows.Forms.Label();
        this.lblDirectorName = new System.Windows.Forms.Label();
        this.btnPrint = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.pnlCert.SuspendLayout();
        this.pnlInnerBorder.SuspendLayout();
        this.SuspendLayout();
        // 
        // pnlCert
        // 
        this.pnlCert.BackColor = System.Drawing.Color.FromArgb(254, 252, 246);
        this.pnlCert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlCert.Controls.Add(this.pnlInnerBorder);
        this.pnlCert.Location = new System.Drawing.Point(30, 20);
        this.pnlCert.Name = "pnlCert";
        this.pnlCert.Size = new System.Drawing.Size(740, 520);
        this.pnlCert.TabIndex = 0;
        // 
        // pnlInnerBorder
        // 
        this.pnlInnerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlInnerBorder.Controls.Add(this.lblOrgName);
        this.pnlInnerBorder.Controls.Add(this.lblCertTitle);
        this.pnlInnerBorder.Controls.Add(this.lblCertSubtitle);
        this.pnlInnerBorder.Controls.Add(this.lblPresentedTo);
        this.pnlInnerBorder.Controls.Add(this.lblStudentName);
        this.pnlInnerBorder.Controls.Add(this.lblLine1);
        this.pnlInnerBorder.Controls.Add(this.lblDescCourse);
        this.pnlInnerBorder.Controls.Add(this.lblCourseName);
        this.pnlInnerBorder.Controls.Add(this.lblScoreInfo);
        this.pnlInnerBorder.Controls.Add(this.lblDateIssued);
        this.pnlInnerBorder.Controls.Add(this.lblDirectorTitle);
        this.pnlInnerBorder.Controls.Add(this.lblDirectorName);
        this.pnlInnerBorder.Location = new System.Drawing.Point(15, 15);
        this.pnlInnerBorder.Name = "pnlInnerBorder";
        this.pnlInnerBorder.Size = new System.Drawing.Size(708, 488);
        this.pnlInnerBorder.TabIndex = 0;
        // 
        // lblOrgName
        // 
        this.lblOrgName.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Bold);
        this.lblOrgName.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblOrgName.Location = new System.Drawing.Point(20, 20);
        this.lblOrgName.Name = "lblOrgName";
        this.lblOrgName.Size = new System.Drawing.Size(668, 25);
        this.lblOrgName.TabIndex = 0;
        this.lblOrgName.Text = "NORTHSTAR ENGLISH EDUCATION CENTER";
        this.lblOrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCertTitle
        // 
        this.lblCertTitle.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold);
        this.lblCertTitle.ForeColor = System.Drawing.Color.FromArgb(180, 130, 40);
        this.lblCertTitle.Location = new System.Drawing.Point(20, 55);
        this.lblCertTitle.Name = "lblCertTitle";
        this.lblCertTitle.Size = new System.Drawing.Size(668, 40);
        this.lblCertTitle.TabIndex = 1;
        this.lblCertTitle.Text = "GIẤY CHỨNG NHẬN";
        this.lblCertTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCertSubtitle
        // 
        this.lblCertSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
        this.lblCertSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120);
        this.lblCertSubtitle.Location = new System.Drawing.Point(20, 95);
        this.lblCertSubtitle.Name = "lblCertSubtitle";
        this.lblCertSubtitle.Size = new System.Drawing.Size(668, 20);
        this.lblCertSubtitle.TabIndex = 2;
        this.lblCertSubtitle.Text = "CERTIFICATE OF COMPLETION";
        this.lblCertSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblPresentedTo
        // 
        this.lblPresentedTo.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblPresentedTo.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.lblPresentedTo.Location = new System.Drawing.Point(20, 130);
        this.lblPresentedTo.Name = "lblPresentedTo";
        this.lblPresentedTo.Size = new System.Drawing.Size(668, 22);
        this.lblPresentedTo.TabIndex = 3;
        this.lblPresentedTo.Text = "Chứng nhận trao cho học viên:";
        this.lblPresentedTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblStudentName
        // 
        this.lblStudentName.Font = new System.Drawing.Font("Georgia", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.lblStudentName.Location = new System.Drawing.Point(20, 160);
        this.lblStudentName.Name = "lblStudentName";
        this.lblStudentName.Size = new System.Drawing.Size(668, 38);
        this.lblStudentName.TabIndex = 4;
        this.lblStudentName.Text = "NGUYỄN VĂN AN";
        this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblLine1
        // 
        this.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblLine1.Location = new System.Drawing.Point(150, 205);
        this.lblLine1.Name = "lblLine1";
        this.lblLine1.Size = new System.Drawing.Size(408, 2);
        this.lblLine1.TabIndex = 5;
        // 
        // lblDescCourse
        // 
        this.lblDescCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblDescCourse.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.lblDescCourse.Location = new System.Drawing.Point(20, 220);
        this.lblDescCourse.Name = "lblDescCourse";
        this.lblDescCourse.Size = new System.Drawing.Size(668, 22);
        this.lblDescCourse.TabIndex = 6;
        this.lblDescCourse.Text = "Đã hoàn thành xuất sắc chương trình đào tạo chuẩn quốc tế khóa:";
        this.lblDescCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCourseName
        // 
        this.lblCourseName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblCourseName.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblCourseName.Location = new System.Drawing.Point(20, 250);
        this.lblCourseName.Name = "lblCourseName";
        this.lblCourseName.Size = new System.Drawing.Size(668, 30);
        this.lblCourseName.TabIndex = 7;
        this.lblCourseName.Text = "TOEIC 500+ CĂN BẢN (Lớp TOEIC 500 - Tối T246)";
        this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblScoreInfo
        // 
        this.lblScoreInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblScoreInfo.ForeColor = System.Drawing.Color.FromArgb(40, 50, 60);
        this.lblScoreInfo.Location = new System.Drawing.Point(20, 290);
        this.lblScoreInfo.Name = "lblScoreInfo";
        this.lblScoreInfo.Size = new System.Drawing.Size(668, 25);
        this.lblScoreInfo.TabIndex = 8;
        this.lblScoreInfo.Text = "Điểm trung bình: 8.8 / 10  —  Xếp loại: Giỏi";
        this.lblScoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDateIssued
        // 
        this.lblDateIssued.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
        this.lblDateIssued.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120);
        this.lblDateIssued.Location = new System.Drawing.Point(40, 370);
        this.lblDateIssued.Name = "lblDateIssued";
        this.lblDateIssued.Size = new System.Drawing.Size(300, 25);
        this.lblDateIssued.TabIndex = 9;
        this.lblDateIssued.Text = "Hà Nội, ngày 30 tháng 04 năm 2025";
        // 
        // lblDirectorTitle
        // 
        this.lblDirectorTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblDirectorTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblDirectorTitle.Location = new System.Drawing.Point(430, 350);
        this.lblDirectorTitle.Name = "lblDirectorTitle";
        this.lblDirectorTitle.Size = new System.Drawing.Size(240, 30);
        this.lblDirectorTitle.TabIndex = 10;
        this.lblDirectorTitle.Text = "GIÁM ĐỐC TRUNG TÂM\r\n(Ký tên & đóng dấu)";
        this.lblDirectorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblDirectorName
        // 
        this.lblDirectorName.Font = new System.Drawing.Font("Segoe UI", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
        this.lblDirectorName.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblDirectorName.Location = new System.Drawing.Point(430, 440);
        this.lblDirectorName.Name = "lblDirectorName";
        this.lblDirectorName.Size = new System.Drawing.Size(240, 25);
        this.lblDirectorName.TabIndex = 11;
        this.lblDirectorName.Text = "TS. Nguyễn Minh Trí";
        this.lblDirectorName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // btnPrint
        // 
        this.btnPrint.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnPrint.ForeColor = System.Drawing.Color.White;
        this.btnPrint.Location = new System.Drawing.Point(260, 555);
        this.btnPrint.Name = "btnPrint";
        this.btnPrint.Size = new System.Drawing.Size(140, 38);
        this.btnPrint.TabIndex = 1;
        this.btnPrint.Text = "🖨️ In Chứng Nhận";
        this.btnPrint.UseVisualStyleBackColor = false;
        // 
        // btnClose
        // 
        this.btnClose.BackColor = System.Drawing.Color.White;
        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnClose.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.btnClose.Location = new System.Drawing.Point(420, 555);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(100, 38);
        this.btnClose.TabIndex = 2;
        this.btnClose.Text = "Đóng";
        this.btnClose.UseVisualStyleBackColor = false;
        // 
        // CertificateForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(244, 247, 252);
        this.ClientSize = new System.Drawing.Size(800, 610);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnPrint);
        this.Controls.Add(this.pnlCert);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "CertificateForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Chứng Nhận Hoàn Thành Khóa Học - EduCenter";
        this.pnlCert.ResumeLayout(false);
        this.pnlInnerBorder.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlCert;
    private System.Windows.Forms.Panel pnlInnerBorder;
    private System.Windows.Forms.Label lblOrgName;
    private System.Windows.Forms.Label lblCertTitle;
    private System.Windows.Forms.Label lblCertSubtitle;
    private System.Windows.Forms.Label lblPresentedTo;
    private System.Windows.Forms.Label lblStudentName;
    private System.Windows.Forms.Label lblLine1;
    private System.Windows.Forms.Label lblDescCourse;
    private System.Windows.Forms.Label lblCourseName;
    private System.Windows.Forms.Label lblScoreInfo;
    private System.Windows.Forms.Label lblDateIssued;
    private System.Windows.Forms.Label lblDirectorTitle;
    private System.Windows.Forms.Label lblDirectorName;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnClose;
}
