using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using EduCenterApp.Models;
using QRCoder;

namespace EduCenterApp.Forms;

public partial class ReceiptForm : Form
{
    private readonly BienLaiThuTien? _bienLai;

    public ReceiptForm()
    {
        InitializeComponent();
        SetupEvents();
    }

    public ReceiptForm(BienLaiThuTien bienLai) : this()
    {
        _bienLai = bienLai;
        LoadReceiptData();
    }

    private void SetupEvents()
    {
        btnClose.Click += (s, e) => this.Close();
        btnPrint.Click += BtnPrint_Click;
    }

    private void LoadReceiptData()
    {
        if (_bienLai == null) return;

        lblReceiptNo.Text = $"Mã số: {_bienLai.MaBienLai}";
        lblDate.Text = $"Ngày lập: {_bienLai.NgayThu}";
        lblStudentValue.Text = $"{_bienLai.TenHocVien} ({_bienLai.MaHocVien})";
        lblClassValue.Text = $"{_bienLai.TenLop} ({_bienLai.MaLop})";
        lblInstallmentValue.Text = $"Đợt {_bienLai.DotThu}";
        lblMethodValue.Text = _bienLai.HinhThucThanhToan;
        lblAmountValue.Text = $"{_bienLai.SoTienThu:N0} VNĐ";
        lblNoteValue.Text = string.IsNullOrEmpty(_bienLai.GhiChu) ? "Không có" : _bienLai.GhiChu;
        lblCashierSign.Text = $"Người lập biên lai\n(Ký và ghi rõ họ tên)\n\n\n{_bienLai.NguoiThu}";

        try
        {
            string qrPayload = $"EDUCENTER-RECEIPT:{_bienLai.MaBienLai}|{_bienLai.TenHocVien}|{_bienLai.SoTienThu:N0}VND|{_bienLai.NgayThu}";
            using var qrGen = new QRCodeGenerator();
            var qrData = qrGen.CreateQrCode(qrPayload, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrData);
            picQr.Image = qrCode.GetGraphic(20);
        }
        catch
        {
        }
    }

    private void BtnPrint_Click(object? sender, EventArgs e)
    {
        try
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(pnlPaper.Width, pnlPaper.Height);
                pnlPaper.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPaper.Width, pnlPaper.Height));
                ev.Graphics?.DrawImage(bmp, 50, 50);
            };

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.Width = 800;
            dlg.Height = 600;
            dlg.ShowDialog(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể mở giao diện in: {ex.Message}", "Lỗi In ấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
