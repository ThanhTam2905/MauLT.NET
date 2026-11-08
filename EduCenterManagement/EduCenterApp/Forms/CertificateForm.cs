using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using EduCenterApp.Models;

namespace EduCenterApp.Forms;

public partial class CertificateForm : Form
{
    private readonly KetQuaHocTap? _ketQua;

    public CertificateForm()
    {
        InitializeComponent();
        SetupEvents();
    }

    public CertificateForm(KetQuaHocTap kq) : this()
    {
        _ketQua = kq;
        LoadCertificateData();
    }

    private void SetupEvents()
    {
        btnClose.Click += (s, e) => this.Close();
        btnPrint.Click += BtnPrint_Click;
    }

    private void LoadCertificateData()
    {
        if (_ketQua == null) return;

        lblStudentName.Text = _ketQua.TenHocVien.ToUpper();
        lblCourseName.Text = $"{_ketQua.TenLop} ({_ketQua.MaLop})";
        lblScoreInfo.Text = $"Điểm trung bình: {_ketQua.DiemTrungBinh:N1} / 10  —  Xếp loại: {_ketQua.XepLoai}";

        string ngayCap = string.IsNullOrEmpty(_ketQua.NgayCapChungNhan) ? DateTime.Now.ToString("yyyy-MM-dd") : _ketQua.NgayCapChungNhan;
        if (DateTime.TryParse(ngayCap, out var dt))
        {
            lblDateIssued.Text = $"Hà Nội, ngày {dt.Day:D2} tháng {dt.Month:D2} năm {dt.Year}";
        }
        else
        {
            lblDateIssued.Text = $"Hà Nội, ngày {ngayCap}";
        }
    }

    private void BtnPrint_Click(object? sender, EventArgs e)
    {
        try
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(pnlCert.Width, pnlCert.Height);
                pnlCert.DrawToBitmap(bmp, new Rectangle(0, 0, pnlCert.Width, pnlCert.Height));
                ev.Graphics?.DrawImage(bmp, 40, 40);
            };

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.Width = 900;
            dlg.Height = 650;
            dlg.ShowDialog(this);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể mở giao diện in chứng nhận: {ex.Message}", "Lỗi In ấn", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
