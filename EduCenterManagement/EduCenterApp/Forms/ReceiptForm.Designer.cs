namespace EduCenterApp.Forms;

partial class ReceiptForm
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
        this.pnlPaper = new System.Windows.Forms.Panel();
        this.lblCenterTitle = new System.Windows.Forms.Label();
        this.lblCenterSub = new System.Windows.Forms.Label();
        this.lblDivider1 = new System.Windows.Forms.Label();
        this.lblTitleReceipt = new System.Windows.Forms.Label();
        this.lblReceiptNo = new System.Windows.Forms.Label();
        this.lblDate = new System.Windows.Forms.Label();
        this.lblStudentLabel = new System.Windows.Forms.Label();
        this.lblStudentValue = new System.Windows.Forms.Label();
        this.lblClassLabel = new System.Windows.Forms.Label();
        this.lblClassValue = new System.Windows.Forms.Label();
        this.lblInstallmentLabel = new System.Windows.Forms.Label();
        this.lblInstallmentValue = new System.Windows.Forms.Label();
        this.lblMethodLabel = new System.Windows.Forms.Label();
        this.lblMethodValue = new System.Windows.Forms.Label();
        this.lblAmountLabel = new System.Windows.Forms.Label();
        this.lblAmountValue = new System.Windows.Forms.Label();
        this.lblNoteLabel = new System.Windows.Forms.Label();
        this.lblNoteValue = new System.Windows.Forms.Label();
        this.picQr = new System.Windows.Forms.PictureBox();
        this.lblQrHint = new System.Windows.Forms.Label();
        this.lblCashierSign = new System.Windows.Forms.Label();
        this.lblPayerSign = new System.Windows.Forms.Label();
        this.btnPrint = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.pnlPaper.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picQr)).BeginInit();
        this.SuspendLayout();
        // 
        // pnlPaper
        // 
        this.pnlPaper.BackColor = System.Drawing.Color.White;
        this.pnlPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlPaper.Controls.Add(this.lblCenterTitle);
        this.pnlPaper.Controls.Add(this.lblCenterSub);
        this.pnlPaper.Controls.Add(this.lblDivider1);
        this.pnlPaper.Controls.Add(this.lblTitleReceipt);
        this.pnlPaper.Controls.Add(this.lblReceiptNo);
        this.pnlPaper.Controls.Add(this.lblDate);
        this.pnlPaper.Controls.Add(this.lblStudentLabel);
        this.pnlPaper.Controls.Add(this.lblStudentValue);
        this.pnlPaper.Controls.Add(this.lblClassLabel);
        this.pnlPaper.Controls.Add(this.lblClassValue);
        this.pnlPaper.Controls.Add(this.lblInstallmentLabel);
        this.pnlPaper.Controls.Add(this.lblInstallmentValue);
        this.pnlPaper.Controls.Add(this.lblMethodLabel);
        this.pnlPaper.Controls.Add(this.lblMethodValue);
        this.pnlPaper.Controls.Add(this.lblAmountLabel);
        this.pnlPaper.Controls.Add(this.lblAmountValue);
        this.pnlPaper.Controls.Add(this.lblNoteLabel);
        this.pnlPaper.Controls.Add(this.lblNoteValue);
        this.pnlPaper.Controls.Add(this.picQr);
        this.pnlPaper.Controls.Add(this.lblQrHint);
        this.pnlPaper.Controls.Add(this.lblCashierSign);
        this.pnlPaper.Controls.Add(this.lblPayerSign);
        this.pnlPaper.Location = new System.Drawing.Point(30, 20);
        this.pnlPaper.Name = "pnlPaper";
        this.pnlPaper.Size = new System.Drawing.Size(560, 620);
        this.pnlPaper.TabIndex = 0;
        // 
        // lblCenterTitle
        // 
        this.lblCenterTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblCenterTitle.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblCenterTitle.Location = new System.Drawing.Point(20, 15);
        this.lblCenterTitle.Name = "lblCenterTitle";
        this.lblCenterTitle.Size = new System.Drawing.Size(520, 25);
        this.lblCenterTitle.TabIndex = 0;
        this.lblCenterTitle.Text = "TRUNG TÂM NGOẠI NGỮ NORTHSTAR (EduCenter)";
        this.lblCenterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblCenterSub
        // 
        this.lblCenterSub.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblCenterSub.ForeColor = System.Drawing.Color.FromArgb(100, 110, 120);
        this.lblCenterSub.Location = new System.Drawing.Point(20, 42);
        this.lblCenterSub.Name = "lblCenterSub";
        this.lblCenterSub.Size = new System.Drawing.Size(520, 20);
        this.lblCenterSub.TabIndex = 1;
        this.lblCenterSub.Text = "Địa chỉ: 123 Đường Cầu Giấy, Hà Nội - Hotline: 1900 6868";
        this.lblCenterSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblDivider1
        // 
        this.lblDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.lblDivider1.Location = new System.Drawing.Point(30, 68);
        this.lblDivider1.Name = "lblDivider1";
        this.lblDivider1.Size = new System.Drawing.Size(500, 2);
        this.lblDivider1.TabIndex = 2;
        // 
        // lblTitleReceipt
        // 
        this.lblTitleReceipt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitleReceipt.ForeColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.lblTitleReceipt.Location = new System.Drawing.Point(20, 80);
        this.lblTitleReceipt.Name = "lblTitleReceipt";
        this.lblTitleReceipt.Size = new System.Drawing.Size(520, 30);
        this.lblTitleReceipt.TabIndex = 3;
        this.lblTitleReceipt.Text = "BIÊN LAI THU TIỀN HỌC PHÍ";
        this.lblTitleReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblReceiptNo
        // 
        this.lblReceiptNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
        this.lblReceiptNo.ForeColor = System.Drawing.Color.Gray;
        this.lblReceiptNo.Location = new System.Drawing.Point(20, 112);
        this.lblReceiptNo.Name = "lblReceiptNo";
        this.lblReceiptNo.Size = new System.Drawing.Size(260, 20);
        this.lblReceiptNo.TabIndex = 4;
        this.lblReceiptNo.Text = "Mã số: BL2025001";
        // 
        // lblDate
        // 
        this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblDate.ForeColor = System.Drawing.Color.Gray;
        this.lblDate.Location = new System.Drawing.Point(280, 112);
        this.lblDate.Name = "lblDate";
        this.lblDate.Size = new System.Drawing.Size(260, 20);
        this.lblDate.TabIndex = 5;
        this.lblDate.Text = "Ngày lập: 2025-03-01";
        this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
        // 
        // lblStudentLabel
        // 
        this.lblStudentLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblStudentLabel.Location = new System.Drawing.Point(30, 150);
        this.lblStudentLabel.Name = "lblStudentLabel";
        this.lblStudentLabel.Size = new System.Drawing.Size(150, 22);
        this.lblStudentLabel.TabIndex = 6;
        this.lblStudentLabel.Text = "Họ tên học viên:";
        // 
        // lblStudentValue
        // 
        this.lblStudentValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblStudentValue.Location = new System.Drawing.Point(190, 150);
        this.lblStudentValue.Name = "lblStudentValue";
        this.lblStudentValue.Size = new System.Drawing.Size(340, 22);
        this.lblStudentValue.TabIndex = 7;
        this.lblStudentValue.Text = "Nguyễn Văn An (HV001)";
        // 
        // lblClassLabel
        // 
        this.lblClassLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblClassLabel.Location = new System.Drawing.Point(30, 185);
        this.lblClassLabel.Name = "lblClassLabel";
        this.lblClassLabel.Size = new System.Drawing.Size(150, 22);
        this.lblClassLabel.TabIndex = 8;
        this.lblClassLabel.Text = "Lớp đăng ký:";
        // 
        // lblClassValue
        // 
        this.lblClassValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblClassValue.Location = new System.Drawing.Point(190, 185);
        this.lblClassValue.Name = "lblClassValue";
        this.lblClassValue.Size = new System.Drawing.Size(340, 22);
        this.lblClassValue.TabIndex = 9;
        this.lblClassValue.Text = "TOEIC 500 - Lớp tối 1 (LOP_TOEIC_01)";
        // 
        // lblInstallmentLabel
        // 
        this.lblInstallmentLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblInstallmentLabel.Location = new System.Drawing.Point(30, 220);
        this.lblInstallmentLabel.Name = "lblInstallmentLabel";
        this.lblInstallmentLabel.Size = new System.Drawing.Size(150, 22);
        this.lblInstallmentLabel.TabIndex = 10;
        this.lblInstallmentLabel.Text = "Đợt thanh toán:";
        // 
        // lblInstallmentValue
        // 
        this.lblInstallmentValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblInstallmentValue.Location = new System.Drawing.Point(190, 220);
        this.lblInstallmentValue.Name = "lblInstallmentValue";
        this.lblInstallmentValue.Size = new System.Drawing.Size(340, 22);
        this.lblInstallmentValue.TabIndex = 11;
        this.lblInstallmentValue.Text = "Đợt 1";
        // 
        // lblMethodLabel
        // 
        this.lblMethodLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblMethodLabel.Location = new System.Drawing.Point(30, 255);
        this.lblMethodLabel.Name = "lblMethodLabel";
        this.lblMethodLabel.Size = new System.Drawing.Size(150, 22);
        this.lblMethodLabel.TabIndex = 12;
        this.lblMethodLabel.Text = "Hình thức:";
        // 
        // lblMethodValue
        // 
        this.lblMethodValue.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.lblMethodValue.Location = new System.Drawing.Point(190, 255);
        this.lblMethodValue.Name = "lblMethodValue";
        this.lblMethodValue.Size = new System.Drawing.Size(340, 22);
        this.lblMethodValue.TabIndex = 13;
        this.lblMethodValue.Text = "Chuyển khoản ngân hàng";
        // 
        // lblAmountLabel
        // 
        this.lblAmountLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblAmountLabel.ForeColor = System.Drawing.Color.FromArgb(16, 42, 67);
        this.lblAmountLabel.Location = new System.Drawing.Point(30, 295);
        this.lblAmountLabel.Name = "lblAmountLabel";
        this.lblAmountLabel.Size = new System.Drawing.Size(150, 25);
        this.lblAmountLabel.TabIndex = 14;
        this.lblAmountLabel.Text = "SỐ TIỀN THU:";
        // 
        // lblAmountValue
        // 
        this.lblAmountValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        this.lblAmountValue.ForeColor = System.Drawing.Color.FromArgb(235, 75, 75);
        this.lblAmountValue.Location = new System.Drawing.Point(190, 292);
        this.lblAmountValue.Name = "lblAmountValue";
        this.lblAmountValue.Size = new System.Drawing.Size(340, 30);
        this.lblAmountValue.TabIndex = 15;
        this.lblAmountValue.Text = "3,150,000 VNĐ";
        // 
        // lblNoteLabel
        // 
        this.lblNoteLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblNoteLabel.Location = new System.Drawing.Point(30, 335);
        this.lblNoteLabel.Name = "lblNoteLabel";
        this.lblNoteLabel.Size = new System.Drawing.Size(150, 22);
        this.lblNoteLabel.TabIndex = 16;
        this.lblNoteLabel.Text = "Ghi chú:";
        // 
        // lblNoteValue
        // 
        this.lblNoteValue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
        this.lblNoteValue.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.lblNoteValue.Location = new System.Drawing.Point(190, 335);
        this.lblNoteValue.Name = "lblNoteValue";
        this.lblNoteValue.Size = new System.Drawing.Size(340, 40);
        this.lblNoteValue.TabIndex = 17;
        this.lblNoteValue.Text = "Đã áp dụng chính sách giảm 10% học viên cũ";
        // 
        // picQr
        // 
        this.picQr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picQr.Location = new System.Drawing.Point(35, 410);
        this.picQr.Name = "picQr";
        this.picQr.Size = new System.Drawing.Size(110, 110);
        this.picQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picQr.TabIndex = 18;
        this.picQr.TabStop = false;
        // 
        // lblQrHint
        // 
        this.lblQrHint.Font = new System.Drawing.Font("Segoe UI", 8F);
        this.lblQrHint.ForeColor = System.Drawing.Color.Gray;
        this.lblQrHint.Location = new System.Drawing.Point(25, 525);
        this.lblQrHint.Name = "lblQrHint";
        this.lblQrHint.Size = new System.Drawing.Size(130, 35);
        this.lblQrHint.TabIndex = 19;
        this.lblQrHint.Text = "Quét mã xác thực biên lai học phí";
        this.lblQrHint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblCashierSign
        // 
        this.lblCashierSign.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblCashierSign.Location = new System.Drawing.Point(340, 420);
        this.lblCashierSign.Name = "lblCashierSign";
        this.lblCashierSign.Size = new System.Drawing.Size(180, 80);
        this.lblCashierSign.TabIndex = 20;
        this.lblCashierSign.Text = "Người lập biên lai\r\n(Ký và ghi rõ họ tên)\r\n\r\n\r\nLễ tân";
        this.lblCashierSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblPayerSign
        // 
        this.lblPayerSign.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
        this.lblPayerSign.Location = new System.Drawing.Point(160, 420);
        this.lblPayerSign.Name = "lblPayerSign";
        this.lblPayerSign.Size = new System.Drawing.Size(160, 80);
        this.lblPayerSign.TabIndex = 21;
        this.lblPayerSign.Text = "Người nộp tiền\r\n(Ký và ghi rõ họ tên)";
        this.lblPayerSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // btnPrint
        // 
        this.btnPrint.BackColor = System.Drawing.Color.FromArgb(24, 115, 255);
        this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnPrint.ForeColor = System.Drawing.Color.White;
        this.btnPrint.Location = new System.Drawing.Point(180, 655);
        this.btnPrint.Name = "btnPrint";
        this.btnPrint.Size = new System.Drawing.Size(120, 38);
        this.btnPrint.TabIndex = 1;
        this.btnPrint.Text = "🖨️ In Biên Lai";
        this.btnPrint.UseVisualStyleBackColor = false;
        // 
        // btnClose
        // 
        this.btnClose.BackColor = System.Drawing.Color.White;
        this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnClose.ForeColor = System.Drawing.Color.FromArgb(60, 70, 80);
        this.btnClose.Location = new System.Drawing.Point(320, 655);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(100, 38);
        this.btnClose.TabIndex = 2;
        this.btnClose.Text = "Đóng";
        this.btnClose.UseVisualStyleBackColor = false;
        // 
        // ReceiptForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(244, 247, 252);
        this.ClientSize = new System.Drawing.Size(620, 710);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnPrint);
        this.Controls.Add(this.pnlPaper);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "ReceiptForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "In Biên Lai Thu Tiền Học Phí - EduCenter";
        this.pnlPaper.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.picQr)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlPaper;
    private System.Windows.Forms.Label lblCenterTitle;
    private System.Windows.Forms.Label lblCenterSub;
    private System.Windows.Forms.Label lblDivider1;
    private System.Windows.Forms.Label lblTitleReceipt;
    private System.Windows.Forms.Label lblReceiptNo;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblStudentLabel;
    private System.Windows.Forms.Label lblStudentValue;
    private System.Windows.Forms.Label lblClassLabel;
    private System.Windows.Forms.Label lblClassValue;
    private System.Windows.Forms.Label lblInstallmentLabel;
    private System.Windows.Forms.Label lblInstallmentValue;
    private System.Windows.Forms.Label lblMethodLabel;
    private System.Windows.Forms.Label lblMethodValue;
    private System.Windows.Forms.Label lblAmountLabel;
    private System.Windows.Forms.Label lblAmountValue;
    private System.Windows.Forms.Label lblNoteLabel;
    private System.Windows.Forms.Label lblNoteValue;
    private System.Windows.Forms.PictureBox picQr;
    private System.Windows.Forms.Label lblQrHint;
    private System.Windows.Forms.Label lblCashierSign;
    private System.Windows.Forms.Label lblPayerSign;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnClose;
}
