# EDUCENTER PRO — HỆ THỐNG QUẢN LÝ TRUNG TÂM TIẾNG ANH / ĐÀO TẠO

Dự án C# WinForms (.NET 10.0) sử dụng cơ sở dữ liệu **SQLite**, hỗ trợ trực tiếp công cụ quản lý dữ liệu **Navicat for SQLite**, thiết kế chuẩn **Design Mode** trong **JetBrains Rider**, giao diện hiện đại tham khảo mẫu **Figma**.

---

## 📁 1. Cấu Trúc Dự Án (Project Structure)
Được tạo mới hoàn toàn tại: `C:\Users\HP\RiderProjects\EduCenterManagement\`
```
EduCenterManagement/
├── EduCenterManagement.sln               # Solution JetBrains Rider
├── README.md                             # Hướng dẫn chi tiết dự án
└── EduCenterApp/
    ├── EduCenterApp.csproj               # .NET 10.0-windows, Microsoft.Data.Sqlite, QRCoder
    ├── Program.cs                        # Điểm khởi chạy ứng dụng & nạp SQLite tự động
    ├── Database/
    │   ├── DatabaseHelper.cs             # Khởi tạo DB, thiết lập bảng, nạp dữ liệu mẫu
    │   ├── EduCenter_Schema.sql          # File SQL DDL chuẩn mở trực tiếp trong Navicat
    │   └── EduCenter.db                  # File SQLite Database (tự tạo lúc chạy)
    ├── Models/
    │   └── Models.cs                     # Model Khóa học, Lớp, Học viên, Biên lai, Điểm,...
    ├── Services/
    │   └── EduCenterService.cs           # Nghiệp vụ: Tránh xung đột, Học phí, Cảnh báo vắng,...
    └── Forms/
        ├── WelcomeForm.cs                # Màn hình Chào mừng & Chọn vai trò (Figma split layout)
        ├── WelcomeForm.Designer.cs       # Chuẩn Rider Design Mode
        ├── MainForm.cs                   # Màn hình Quản trị chính (7 chức năng chuyên sâu)
        ├── MainForm.Designer.cs          # Chuẩn Rider Design Mode
        ├── ReceiptForm.cs                # Dialog xem & in Biên lai thu học phí kèm mã QR Code
        ├── ReceiptForm.Designer.cs       # Chuẩn Rider Design Mode
        ├── CertificateForm.cs            # Dialog xem & in Giấy chứng nhận hoàn thành khóa học
        └── CertificateForm.Designer.cs   # Chuẩn Rider Design Mode
```

---

## 🎨 2. Hướng Dẫn Sử Dụng "Design Mode" Trong JetBrains Rider
Tất cả các Form (`MainForm`, `WelcomeForm`, `ReceiptForm`, `CertificateForm`) đều được tách bạch theo chuẩn Windows Forms của .NET:
- Giao diện và thành phần điều khiển được sinh hoàn toàn trong phương thức `InitializeComponent()` của tệp `*.Designer.cs`.
- Thuộc tính lớp được khai báo `partial class FormName : Form`.

**Cách mở Design Mode trong JetBrains Rider:**
1. Khởi động **JetBrains Rider**.
2. Chọn **Open** -> Chọn tệp `C:\Users\HP\RiderProjects\EduCenterManagement\EduCenterManagement.sln`.
3. Trong cửa sổ **Solution Explorer**, nhấp đúp vào một trong các Form (ví dụ: `MainForm.cs` hoặc `WelcomeForm.cs`).
4. Nhấn tổ hợp phím **`Shift + F7`** hoặc nhấp vào tab **Designer** ở cạnh dưới/cạnh trên cửa sổ soạn thảo của Rider để xem chế độ thiết kế kéo-thả đồ họa trực quan (Design Mode).

---

## 🗄️ 3. Hướng Dẫn Kết Nối Navicat Với SQLite (`EduCenter.db`)
File cơ sở dữ liệu `EduCenter.db` được lưu tại:
`C:\Users\HP\RiderProjects\EduCenterManagement\EduCenterApp\bin\Debug\net10.0-windows\Database\EduCenter.db`

**Các bước kết nối trên Navicat:**
1. Mở **Navicat Premium** hoặc **Navicat for SQLite**.
2. Nhấn menu **Connection** -> Chọn **SQLite...**
3. Điền thông tin:
   - **Connection Name**: `EduCenter_SQLite`
   - **Type**: `Existing Database File`
   - **Database File**: Bấm nút `...` và duyệt đến file `EduCenter.db` theo đường dẫn trên (hoặc bấm nút *"📂 Mở thư mục chứa Database"* ngay trong tab **Cơ sở dữ liệu** của phần mềm).
4. Nhấn **Test Connection** -> Khi hiện thông báo *"Connection Successful"*, nhấn **OK**.
5. Bây giờ bạn có thể mở các bảng: `KhoaHoc`, `LopHoc`, `HocVien`, `DangKy`, `BienLaiThuTien`, `DiemDanh`, `KetQuaHocTap`, `TaiKhoan` để duyệt, thêm sửa xóa dữ liệu trực tiếp song song với ứng dụng C#!
6. Ngoài ra, tệp `Database/EduCenter_Schema.sql` đã được tạo sẵn để bạn có thể mở trong **Navicat Query Editor** bất kỳ lúc nào.

---

## 🚀 4. Chi Tiết Thực Hiện Các Nghiệp Vụ Theo Yêu Cầu

### ① Quản lý Khóa học & Lớp học
- **Khóa học (Course Catalog):** Quản lý mã khóa học, tên khóa học (ví dụ: `TOEIC 500`, `IELTS 6.5`, `Giao tiếp phản xạ`), học phí gốc, số buổi học và lộ trình mô tả.
- **Lớp học (Class Management):** Mở các lớp học cụ thể từ một khóa học với đầy đủ thông tin: Lịch thứ học (T2-T4-T6, T3-T5-T7,...), phòng học (Phòng 201, Phòng 202,...), giáo viên phụ trách, ca học, giờ bắt đầu/kết thúc, ngày khai giảng và sĩ số tối đa.

### ② Xếp lịch học & Tự động tránh xung đột (Conflict Avoidance)
- Thuật toán `CheckScheduleConflict` kiểm tra giao thoa giữa thứ học và khoảng thời gian `[GioBatDau, GioKetThuc]`:
  - **Tránh trùng phòng:** Ngăn chặn việc xếp 2 lớp học vào cùng một phòng trong cùng một khung giờ.
  - **Tránh trùng giáo viên:** Ngăn chặn việc 1 giáo viên bị xếp dạy 2 lớp khác nhau tại cùng một thời điểm.
- Khi lưu lớp mới hoặc kiểm tra lịch, hệ thống sẽ đưa ra thông báo cảnh báo chi tiết và ngăn lưu nếu xảy ra xung đột.

### ③ Đăng ký & Thu học phí (Tuition & Receipt with QR Code)
- Chọn học viên và chọn lớp muốn học -> Hệ thống tự động lấy học phí gốc của khóa học tương ứng.
- **Chính sách ưu đãi:**
  - Tự động nhận diện và áp dụng chính sách **Giảm 10% cho học viên cũ** (`IsHocVienCu`).
  - Áp dụng **Giảm giá khi đăng ký theo nhóm** (nhập % giảm giá linh hoạt, ví dụ 5%, 15%).
- **Thanh toán linh hoạt:**
  - Cho phép đóng trọn gói 1 lần hoặc **chia thành nhiều đợt** (hệ thống tự động theo dõi số tiền đã đóng và số tiền còn nợ).
  - Có chức năng *"Thu học phí đợt tiếp theo"* cho các học viên còn nợ.
- **In biên lai thu tiền:**
  - Mẫu biên lai đồ họa sắc nét (`ReceiptForm`), hiển thị đầy đủ thông tin đợt thu, người nộp, người thu, và đặc biệt có **mã QR Code tự động sinh qua thư viện QRCoder** hỗ trợ quét thanh toán/tra cứu nhanh.
  - Hỗ trợ in trực tiếp ra máy in hoặc xem bản in trước (Print Preview).

### ④ Điểm danh & Cảnh báo vắng học quá 3 buổi (Attendance & Absence Warning)
- Màn hình điểm danh linh hoạt theo từng lớp và từng số buổi học:
  - 3 trạng thái chuẩn: **Có mặt**, **Vắng có phép**, **Vắng không phép**.
- **Cảnh báo vắng học vượt quá 3 buổi:**
  - Học viên có tổng số buổi vắng $\ge 3$ buổi sẽ được hệ thống **đổi màu nền đỏ nổi bật (Highlight)** trên bảng điểm danh.
  - Danh sách riêng *"Cảnh báo học viên vắng $\ge 3$ buổi"* kèm theo thông báo và số điện thoại để bộ phận lễ tân/chăm sóc khách hàng liên hệ trực tiếp nhắc nhở học viên và sắp xếp học bù.
  - Thẻ thông báo trên Dashboard chính và biểu tượng huy hiệu đỏ (Alert Badge) tự động cập nhật số lượng học viên cần liên hệ.

### ⑤ Quản lý Điểm thi & Cấp Chứng nhận hoàn thành (Grades & Certificate)
- Nhập điểm thi chuyên cần (10%), điểm thi giữa kỳ (40%) và điểm thi cuối kỳ (50%).
- **Hệ thống tự động tính Điểm trung bình (ĐTB)** theo công thức chuẩn:
  $$\text{ĐTB} = (\text{Chuyên cần} \times 0.1) + (\text{Giữa kỳ} \times 0.4) + (\text{Cuối kỳ} \times 0.5)$$
- **Tự động xếp loại:**
  - $\text{ĐTB} \ge 9.0$: Xuất sắc
  - $\text{ĐTB} \ge 8.0$: Giỏi
  - $\text{ĐTB} \ge 6.5$: Khá
  - $\text{ĐTB} \ge 5.0$: Trung bình (Đạt)
  - $\text{ĐTB} < 5.0$: Chưa đạt
- **In Giấy chứng nhận hoàn thành khóa học (`CertificateForm`):**
  - Dành cho các học viên đạt điều kiện tốt nghiệp ($\text{ĐTB} \ge 5.0$).
  - Mẫu chứng nhận trang trọng theo phong cách chứng chỉ quốc tế, hiển thị họ tên học viên, lớp học, điểm trung bình, xếp loại học lực, ngày cấp và chữ ký Giám đốc trung tâm đào tạo.
  - Hỗ trợ in ấn trực tiếp hoặc xem trước bản in.

### ⑥ Màn hình Chào mừng (WelcomeForm) & Giao diện Figma hiện đại
- Màn hình khởi động với giao diện chia đôi hiện đại (Split Layout) theo phong cách thiết kế Figma:
  - Chọn cổng làm việc: **Quản trị viên (Admin)**, **Giáo viên**, **Học viên**.
  - Hiển thị các tính năng cốt lõi và thông tin công nghệ (.NET 10, SQLite, Navicat, Rider Design Mode).

---

## 🔑 5. Tài Khoản Mẫu Trải Nghiệm (Demo Accounts)
| Tên đăng nhập | Mật khẩu | Vai trò | Chức năng |
|---|---|---|---|
| `admin` | `123456` | Quản trị viên | Toàn quyền quản trị trung tâm |
| `teacher` | `123456` | Giáo viên | Quản lý giảng dạy, điểm danh, điểm số |
| `student` | `123456` | Học viên | Tra cứu thông tin cá nhân & lớp học |

*(Ngoài ra bạn có thể nhấn trực tiếp vào các nút vai trò tại màn hình Welcome để vào hệ thống ngay mà không cần nhập lại).*

---

## 🛠️ 6. Lệnh Biên Dịch & Chạy Thử
Mở PowerShell hoặc Terminal:
```powershell
# Chuyển vào thư mục solution
cd "C:\Users\HP\RiderProjects\EduCenterManagement"

# Biên dịch dự án
dotnet build

# Chạy ứng dụng
dotnet run --project EduCenterApp
```
