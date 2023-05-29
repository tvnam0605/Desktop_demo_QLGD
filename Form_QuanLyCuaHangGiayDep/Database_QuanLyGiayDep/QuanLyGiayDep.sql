CREATE DATABASE QuanLyGiayDep;
GO
USE QuanLyGiayDep;
GO
drop table LoaiHangHoa
go
CREATE TABLE LoaiHangHoa
(
  ID INT IDENTITY(1,1) PRIMARY KEY,
  TenLoaiHang NVARCHAR(50),
  MoTa NVARCHAR(200)
);
drop table NhaCungCap
go
CREATE TABLE NhaCungCap
(
  ID INT IDENTITY(1,1) PRIMARY KEY,
  TenNhaCungCap NVARCHAR(50),
  SoDienThoai NVARCHAR(20),
  DiaChi NVARCHAR(200)
);
drop table HangHoa
go
CREATE TABLE HangHoa
(
  ID INT IDENTITY(1,1) PRIMARY KEY,
  TenHangHoa NVARCHAR(50),
  DonGia FLOAT,
  Size float,
  LoaiHangHoaID INT REFERENCES LoaiHangHoa(ID),
  XuatXu NVARCHAR(50),
  NhaCungCapID INT REFERENCES NhaCungCap(ID)
);
--drop table KhachHang
--go
--CREATE TABLE KhachHang
--(
--  MaKH INT IDENTITY(1,1) PRIMARY KEY,
--  TenKhachHang NVARCHAR(50),
--  SoDienThoai NVARCHAR(20),
--  DiaChi NVARCHAR(200)
--);

drop table TaiKhoan
go
CREATE TABLE TaiKhoan
(
  TenDangNhap NVARCHAR(50) PRIMARY KEY,
  MatKhau NVARCHAR(50),
  HoTen NVARCHAR(50),
  Email NVARCHAR(50),
  DienThoai NVARCHAR(20),
  NgayTaoTaiKhoan DATE
);
drop table HoaDon
go
CREATE TABLE HoaDon
(
  ID INT IDENTITY(1,1) PRIMARY KEY,
  NgayLap DATE,
  TenDangNhap NVARCHAR(50) REFERENCES TaiKhoan(TenDangNhap),
  TongTien FLOAT,
  GiamGia FLOAT,
  TenKhachHang NVARCHAR(50),
  SoDienThoai NVARCHAR(20),
  DiaChi NVARCHAR(200),
  TrangThaiDonHang NVARCHAR(50)
);
drop table CT_HoaDon
go
CREATE TABLE CT_HoaDon
(
  MaHD INT REFERENCES HoaDon(ID),
  MaHangHoa INT REFERENCES HangHoa(ID),
  SoLuong INT,
  DonGia FLOAT,
  PRIMARY KEY (MaHD, MaHangHoa)
);
drop table HoaDonNhap
go
CREATE TABLE HoaDonNhap
(
  ID INT IDENTITY(1,1) PRIMARY KEY,
  NgayLap DATE,
  NguoiLap NVARCHAR(50) REFERENCES TaiKhoan(TenDangNhap),
  NhaCungCapID INT REFERENCES NhaCungCap(ID),
  TongTien FLOAT,
  GiamGia FLOAT,
  TrangThaiHoaDonNhap NVARCHAR(50)
);
drop table CT_HoaDonNhap
go
CREATE TABLE CT_HoaDonNhap
(
  MaHoaDonNhap INT REFERENCES HoaDonNhap(ID),
  MaHangHoa INT REFERENCES HangHoa(ID),
  SoLuong INT,
  DonGia FLOAT,
  PRIMARY KEY (MaHoaDonNhap, MaHangHoa)
);

-- loại hàng hóa
CREATE PROCEDURE USP_ThemLoaiHangHoa
    @TenLoaiHang nvarchar(50),
    @MoTa nvarchar(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO LoaiHangHoa(TenLoaiHang, MoTa)
    VALUES (@TenLoaiHang, @MoTa)
END
EXEC USP_ThemLoaiHangHoa 'Giày', N'Các loại giày dép'
EXEC USP_ThemLoaiHangHoa 'Dép', N'Các loại giày dép'
select * from LoaiHangHoa



--  thủ tục  xóa một loại hàng hóa
CREATE PROCEDURE USP_XoaLoaiHangHoa
  @ID INT
AS
BEGIN
  DELETE FROM LoaiHangHoa
  WHERE ID = @ID
END;

-- Tạo thủ tục để cập nhật thông tin một loại hàng hóa
CREATE PROCEDURE USP_CapNhatLoaiHangHoa
  @ID INT,
  @TenLoaiHang NVARCHAR(50),
  @MoTa NVARCHAR(200)
AS
BEGIN
  UPDATE LoaiHangHoa
  SET TenLoaiHang = @TenLoaiHang,
      MoTa = @MoTa
  WHERE ID = @ID
END;

--delete from LoaiHangHoa where ID=2
-- nhà cung cấp
drop PROCEDURE USP_ThemNhaCungCap
go
CREATE PROCEDURE USP_ThemNhaCungCap
    @TenNCC nvarchar(50),
    @SoDienThoai nvarchar(20),
    @DiaChi nvarchar(200)
AS
BEGIN
    INSERT INTO NhaCungCap(TenNhaCungCap, SoDienThoai, DiaChi)
    VALUES (@TenNCC, @SoDienThoai, @DiaChi)
END

EXEC USP_ThemNhaCungCap N'Tên nhà cung cấp', N'0898354417', N'Địa chỉ'

select * from NhaCungCap
-- hàng hóa
go
-- thủ tục thêm hàng hóa
drop proc USP_ThemHangHoa
go
CREATE PROCEDURE USP_ThemHangHoa
    @TenHangHoa nvarchar(50),
    @DonGia float,
    @Size float,
    @LoaiHangHoaID int,
    @XuatXu nvarchar(50),
    @NhaCungCapID int
AS
BEGIN
    INSERT INTO HangHoa(TenHangHoa, DonGia, Size, LoaiHangHoaID, XuatXu, NhaCungCapID)
    VALUES (@TenHangHoa, @DonGia, @Size, @LoaiHangHoaID, @XuatXu, @NhaCungCapID)
END

EXEC USP_ThemHangHoa N'Dép lê', 100000, 41, 1, N'Trung quốc', 1
EXEC USP_ThemHangHoa N'Giày da', 100000, 41, 1, N'Việt Nam', 1
EXEC USP_ThemHangHoa N'Giày thể thao', 100000, 41, 1, N'Trung quốc', 1
EXEC USP_ThemHangHoa N'Giày Cao gót', 100000, 41, 1, N'Việt Nam', 1
EXEC USP_ThemHangHoa N'Dép', 100000, 41, 1, N'Trung Quốc', 1
--delete from HangHoa where ID between 70 and 96
select * from HangHoa
-- thủ tục xem tất carhangf hóa
drop PROCEDURE USP_ViewAllHangHoa
go
CREATE PROCEDURE USP_ViewAllHangHoa
AS
BEGIN
    SELECT * FROM HangHoa
END
go
Exec USP_ViewAllHangHoa
-- thủ tục sửa hàng hóa
drop proc USP_SuaHangHoa
go
create PROCEDURE USP_SuaHangHoa
    @MaSanPham INT,
    @TenHH NVARCHAR(50),
    @DonGia float,
    @Size float,
    @LoaiHH INT,
    @XuatXu NVARCHAR(50),
    @NhaCC INT
AS
BEGIN
    UPDATE HangHoa
    SET TenHangHoa = @TenHH,
        DonGia = @DonGia,
        Size = @Size,
        LoaiHangHoaID = @LoaiHH,
        XuatXu = @XuatXu,
        NhaCungCapID = @NhaCC
    WHERE ID = @MaSanPham
END

-- thủ tục xóa hàng hóa
CREATE PROCEDURE USP_XoaHangHoa
    @maHangHoa INT
AS
BEGIN
    DELETE FROM HangHoa
    WHERE ID = @maHangHoa;
END;

--thủ tục tìm kiếm hàng hóa theo tên
drop proc USP_SearchHangHoaByName
go
CREATE PROCEDURE USP_SearchHangHoaByName
    @tenHangHoa NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM HangHoa
    WHERE TenHangHoa LIKE '%' + @tenHangHoa + '%'
END

EXEC USP_SearchHangHoaByName @tenHangHoa = 'tên'
EXEC USP_SearchHangHoaByName @tenHangHoa = 'Dép'



--Tài khoản
-- Thêm tài khoản tvnam
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan)
VALUES ('tvnam', 'password123', N'Trần Văn Nam', 'tvnam@example.com', '0987654321', GETDATE());

-- Thêm tài khoản vxquang
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan)
VALUES ('vxquang', 'password123', N'Võ Xuân Quang', 'vxquang@example.com', '0987654321', GETDATE());

-- Thêm tài khoản cqminh
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan)
VALUES ('cqminh', 'password123', N'Chế Quang Minh', 'cqminh@example.com', '0987654321', GETDATE());

-- Thêm tài khoản dlqhuy
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan)
VALUES ('dlqhuy', 'password123', N'Đinh Lê Quang Huy', 'dlqhuy@example.com', '0987654321', GETDATE());

select * from TaiKhoan

-- thủ tục xem tất cả tài khoản
create proc USP_XemAllTaiKhoan
AS
BEGIN
    SELECT * FROM TaiKhoan
END
go
Exec USP_XemAllTaiKhoan
-- thủ tục thêm tài khoản
CREATE PROCEDURE USP_ThemTaiKhoan
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(50),
    @HoTen NVARCHAR(50),
    @Email NVARCHAR(50),
    @DienThoai NVARCHAR(20),
    @NgayTaoTaiKhoan DATE
AS
BEGIN
    INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, Email, DienThoai, NgayTaoTaiKhoan)
    VALUES (@TenDangNhap, @MatKhau, @HoTen, @Email, @DienThoai, @NgayTaoTaiKhoan)
END
-- thủ tục xóa tài khoản
CREATE PROCEDURE USP_XoaTaiKhoan
    @TenDangNhap NVARCHAR(50)
AS
BEGIN
    DELETE FROM TaiKhoan
    WHERE TenDangNhap = @TenDangNhap
END

-- thủ tục sửa tài khoản
create PROCEDURE USP_SuaTaiKhoan
    @TenDangNhap nvarchar(50),
    @MatKhau NVARCHAR(50),
    @HoTen nvarchar(50),
    @Email nvarchar(50),
    @DienThoai nvarchar(20),
    @NgayTaoTaiKhoan Datetime

AS
BEGIN
    UPDATE TaiKhoan
    SET TenDangNhap = @TenDangNhap,
        MatKhau = @MatKhau,
        HoTen = @HoTen,
        Email = @Email,
        DienThoai = @DienThoai,
        NgayTaoTaiKhoan = @NgayTaoTaiKhoan
    WHERE TenDangNhap = @TenDangNhap
END
-- thủ tục lấy thông tin của 1 tên đăng nhập
drop proc GetAccountNameByUsername
go
CREATE PROCEDURE GetAccountNameByUsername
    @Username VARCHAR(50)
AS
BEGIN
    SELECT *  FROM TaiKhoan WHERE TenDangNhap = @Username
END
EXEC GetAccountNameByUsername 'tvnam'
go
-- thủ tục đăng nhập
drop proc USP_Login
go
CREATE PROC USP_Login
@tenDangNhap NVARCHAR(100),
@matKhau NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = @tenDangNhap AND MatKhau = @matKhau
END
GO

exec USP_Login 'tvnam', 'Password123'
exec USP_Login 'vxquang', 'Password123'
exec USP_Login 'cqminh', 'Password123'
exec USP_Login 'dlqhuy', 'Password123'
go
CREATE PROCEDURE GetTenDangNhapDangNhap
    @TenDangNhap NVARCHAR(50) OUTPUT
AS
BEGIN
    SET @TenDangNhap = SUSER_SNAME() -- Các câu lệnh khác trong thủ tục nếu cần
END
DECLARE @TenDangNhap NVARCHAR(50);
EXEC GetTenDangNhapDangNhap
    @TenDangNhap = @TenDangNhap OUTPUT;
-- khách hàng
-- thủ tục thêm khách hàng
CREATE PROCEDURE USP_ThemKhachHang
    @TenKhachHang NVARCHAR(50),
    @SoDienThoai NVARCHAR(20),
    @DiaChi NVARCHAR(200)
AS
BEGIN
    INSERT INTO KhachHang (TenKhachHang, SoDienThoai, DiaChi)
    VALUES (@TenKhachHang, @SoDienThoai, @DiaChi)
END
--theem1 kh
EXEC USP_ThemKhachHang @TenKhachHang = N'Trần Văn Nam', 
                       @SoDienThoai = N'0898354417', 
                       @DiaChi = N'Đak Nông'
select * from KhachHang

-- Hoas don
--CREATE TABLE HoaDon
--(
--  ID INT IDENTITY(1,1) PRIMARY KEY,
--  NgayLap DATE,
--  TenDangNhap NVARCHAR(50) REFERENCES TaiKhoan(TenDangNhap),
--  MaKH INT REFERENCES KhachHang(MaKH),
--  TongTien FLOAT,
--  GiamGia FLOAT,
--  TrangThaiDonHang NVARCHAR(50)
--);
--INSERT INTO HoaDon (NgayLap, TenDangNhap, MaKH, TongTien, GiamGia, TrangThaiDonHang)
--VALUES ('2023-05-13', 'tvnam', 1, 100000, 0, N'Đã hoàn thành');
INSERT INTO HoaDon (NgayLap, TenDangNhap, TongTien, GiamGia, TenKhachHang, SoDienThoai, DiaChi, TrangThaiDonHang)
VALUES ('2023-05-28', 'tvnam', 1000, 100, N'Nguyễn Văn A', '1234567890', N'123 Đường ABC', N'Đã thanh toán');


select * from HoaDon

-- thủ tục xem tất cả hóa đơn
create proc USP_XemAllHoaDon
AS
BEGIN
    SELECT * FROM HoaDon
END
go

EXEC USP_XemAllHoaDon

-- chi tiết đơn hàng
INSERT INTO CT_HoaDon (MaHD, MaHangHoa, SoLuong, DonGia)
VALUES (1, 5, 2, 100000)

select * from CT_HoaDon

-- thủ ục xem hóa đơn dựa vào mãhd
create proc USP_XemHDByMaHD
 @MaHD int 
AS
BEGIN
    SELECT *  FROM CT_HoaDon WHERE MaHD = @MaHD
END
exec dbo.USP_XemHDByMaHD 1


-- các đợt hàng đã nhập

-- thủ tục thêm đợt hàng nhập
CREATE PROCEDURE USP_ThemHoaDonNhap
(
  @NgayLap DATE,
  @NguoiLap NVARCHAR(50),
  @NhaCungCapID INT,
  @TongTien FLOAT,
  @GiamGia FLOAT,
  @TrangThaiHoaDonNhap NVARCHAR(50)
)
AS
BEGIN
  INSERT INTO HoaDonNhap (NgayLap, NguoiLap, NhaCungCapID, TongTien, GiamGia, TrangThaiHoaDonNhap)
  VALUES (@NgayLap, @NguoiLap, @NhaCungCapID, @TongTien, @GiamGia, @TrangThaiHoaDonNhap)
END
--thêm dữ liệu: insert
INSERT INTO HoaDonNhap (NgayLap, NguoiLap, NhaCungCapID, TongTien, GiamGia, TrangThaiHoaDonNhap)
VALUES ('2023-05-20', 'tvnam', 1, 100000.0, 0.0, N'Đang xử lý')
delete from HoaDonNhap where ID =3

-- xem tất cả hóa đơn nhập
create proc USP_XemAllHDNhap
as
begin
	select *from HoaDonNhap
end

exec USP_XemAllHDNhap
go

-- thủ tục thêm 1 hóa đơn
CREATE PROCEDURE USP_ThemHoaDon
    @NgayLap DATE,
    @TenDangNhap NVARCHAR(50),
    @TongTien FLOAT,
    @GiamGia FLOAT,
    @TenKhachHang NVARCHAR(50),
    @SoDienThoai NVARCHAR(20),
    @DiaChi NVARCHAR(200),
    @TrangThaiDonHang NVARCHAR(50)
AS
BEGIN
    INSERT INTO HoaDon (NgayLap, TenDangNhap, TongTien, GiamGia, TenKhachHang, SoDienThoai, DiaChi, TrangThaiDonHang)
    VALUES (@NgayLap, @TenDangNhap, @TongTien, @GiamGia, @TenKhachHang, @SoDienThoai, @DiaChi, @TrangThaiDonHang);
END
-- thủ tục tìm theo tên khach hàng
CREATE PROCEDURE USP_SearchKhachHangByName
    @tenKhachHang NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM HoaDon
    WHERE TenKhachHang LIKE '%' + @tenKhachHang + '%'
END
exec USP_SearchKhachHangByName N'j'

-- thủ tục tìm theo SDT
CREATE PROCEDURE USP_SearchHoaDonBySDT
    @soDienThoai NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM HoaDon
    WHERE SoDienThoai LIKE '%' + @soDienThoai + '%'
END
exec USP_SearchHoaDonBySDT'466'

-- thủ tục tìm theo người lập
CREATE PROCEDURE USP_SearchHoaDonByNV
    @tenNhanVien NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM HoaDon
    WHERE TenDangNhap LIKE '%' + @tenNhanVien + '%'
END
exec USP_SearchHoaDonByNV N'v'