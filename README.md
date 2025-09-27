# k58ptp_baitap1_web
VU LAN_K225480106036_bai tap 1 web

TẠO SOLUTION GỒM CÁC PROJECT SAU:

DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

### Bài làm

### Đề tài: Kiểm tra số Happy

## 1. Tạo SOLUTION sau đó add các project:

* Thư viện libraly: MultiPurposeDLL*
  
* CONSOLE: HappyConsoleApp*

* WINFORMS: HappyWinFormApp*

* WEBFROMS: HappyWebApp*

<img width="1920" height="1079" alt="image" src="https://github.com/user-attachments/assets/042f37b4-ac9d-44b2-b51e-eec5ea33cdca" />

# 2.Chay CONSOLE:HappyConsoleApp

sau khi tạo project chuột phải vào references-> add references->chọn thư viện MultiPurposeDLL-> OK

chọn file code xong build 

chọn HappyConsoleApp chọn Set as startup project-> chọn F5 để chạy chương trinh:

<img width="1915" height="1078" alt="image" src="https://github.com/user-attachments/assets/1d556a94-6b50-4126-a80b-848d2b7cef3a" />

<img width="855" height="1080" alt="image" src="https://github.com/user-attachments/assets/0f60c8ec-d79d-47fe-b28c-ff084c76c029" />

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/481df497-5f0f-461c-b2bd-1bb5570f27ca" />

# 3. Chạy thử WINFORMS: HappyWinFormApp

sau khi tạo project chuột phải vào references-> add references->chọn thư viện MultiPurposeDLL-> OK

code file Form1.cs và Form1.Designer.cs cấu hình nó

chọn file HappyWinFormApp build ->chọn Set as startup project-> chọn F5 để chạy chương trinh:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/7b0ced99-3c14-427b-b33e-12b7a3f576e6" />

# 4.Chạy WEBFROMS: HappyWebApp

sau khi tạo project chuột phải vào references-> add references->chọn thư viện MultiPurposeDLL-> OK

chuột phải vào HappyWebApp->chọn Add-> chọn New ltem...tạo file index.html và file api.aspx

cấu hình file index.html và file api.aspx.cs

vào IIS manager-> add website-> đặt name và hostname local-> Ok 

vào noptepad adm nhap host local->ok 

vào visual studio chuột phải vào HappyWebApp build ->chọn Set as startup project-> chọn F5 để chạy chương trình:

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/1f81f745-9173-4bcf-b394-4ad71a50667a" />

Có thể nhập tên và số bất kỳ xem có Happy hay khong và nếu Happy sẽ cho ra một câu đối và câu chúc người đó năm 2026 dồi dào sức khỏe, vạn sự như ý.



