create database QuanLyPhong
go
use QuanLyPhong
go
CREATE TABLE [dbo].[Phong](
	[MaP] [nvarchar](5) NOT NULL,
	[TenP] [nvarchar](255) NOT NULL,
	[LoaiP] [nvarchar](25) NOT NULL,
	[GiaP] [int] NOT NULL,
	[Tinhtrang] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

GO
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T101', N'PT101', N'Đơn thường', 300000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T102', N'PT102', N'Đơn thường', 300000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T103', N'PT103', N'Đơn thường', 300000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T104', N'PT104', N'Đơn thường', 300000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T201', N'PT201', N'Đôi thường', 400000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T202', N'PT202', N'Đôi thường', 400000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T203', N'PT203', N'Đôi thường', 400000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T204', N'PT204', N'Đôi thường', 400000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T301', N'PT301', N'Ba thường', 500000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T302', N'PT302', N'Ba thường', 500000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T303', N'PT303', N'Ba thường', 500000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'T304', N'PT304', N'Ba thường', 500000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V101', N'PV101', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V102', N'PV102', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V103', N'PV103', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V104', N'PV104', N'VIP đơn', 600000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V201', N'PV201', N'VIP đôi', 800000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V202', N'PV202', N'VIP đôi', 800000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V203', N'PV203', N'VIP đôi', 800000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V204', N'PV204', N'VIP đôi', 800000, N'Có khách')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V301', N'PV301', N'VIP ba', 1000000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V302', N'PV302', N'VIP ba', 1000000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V303', N'PV303', N'VIP ba', 1000000, N'Trống')
INSERT [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang]) VALUES (N'V304', N'PV304', N'VIP ba', 1000000, N'Trống')


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach](
	[CMT] [nvarchar](12) NOT NULL,
	[Hoten] [nvarchar](255) NOT NULL,
	[Diachi] [nvarchar](255) NOT NULL,
	[GT] [nvarchar](5) NOT NULL,
	[SDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_Khach] PRIMARY KEY CLUSTERED 
(
	[CMT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'012434832', N'Cao Thị Linh', N'18 Thanh Bình', N'Nữ', N'0984234567')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'123253454', N'Vũ Tuấn Anh', N'Bà Triệu', N'Nam', N'01235243234')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'123383294', N'Nguyễn Thị Mai', N'Lộc Hạ', N'Nữ', N'0987654356')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'145573262', N'Phạm Vân Anh', N'Nguyễn Du', N'Nữ', N'0956243242')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'152015415', N'Hoàng Đức Hưng', N'Lộc Hạ', N'Nam', N'0963243462')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'190023198', N'Phạm Anh Khoa', N'Hạ Long', N'Nam', N'0955734823')
INSERT [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT]) VALUES (N'234453134', N'Đào Đức Đủ', N'Bùi Thị Xuân', N'Nam', N'0942963929')

SET ANSI_NULLS ON
GO
--drop Table TaiKhoan
CREATE TABLE [dbo].[Taikhoan](
	[Acc] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[TenND] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[Acc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'quan', N'12345', N'Pham Anh Quan')
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'chuong', N'12345', N'Hoàng Chương')
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'tu', N'12345', N'Nguyễn Ngọc Tú')
INSERT [dbo].[Taikhoan] ([Acc], [Pass], [TenND]) VALUES (N'ky', N'12345', N'Nguyễn Tấn Cao Kỳ')


SET ANSI_NULLS ON
GO
select * from Taikhoan
--drop table ThueP
CREATE TABLE [dbo].[ThueP](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[CMT] [nvarchar](12) NOT NULL,
	[MaP] [nvarchar](5) NOT NULL,
	[Ngayden] [date] NOT NULL,
	[Ngaydi] [date] NULL,
	[TenNV] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_ThueP_1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ThueP] ON
-- Thêm dữ liệu vào bảng ThueP
INSERT INTO ThueP ([CMT], [MaP], [Ngayden], [Ngaydi], [TenNV])
VALUES (N'012434832', N'T101', '01/05/2023', '05/05/2023', N'Phạm Anh Quân')

INSERT INTO ThueP ([CMT], [MaP], [Ngayden], [Ngaydi], [TenNV])
VALUES (N'123253454', N'T102', '02/05/2023', '06/05/2023', N'Lê Ngọc Hoàng Chương')

INSERT INTO ThueP ([CMT], [MaP], [Ngayden], [Ngaydi], [TenNV])
VALUES (N'123383294', N'T103', '03/05/2023', '07/05/2023', N'Nguyễn Ngọc Tú')

INSERT INTO ThueP ([CMT], [MaP], [Ngayden], [Ngaydi], [TenNV])
VALUES (N'145573262', N'T104', '04/05/2023', '08/05/2023', N'Phạm Anh Quân')

INSERT INTO ThueP ([CMT], [MaP], [Ngayden], [Ngaydi], [TenNV])
VALUES (N'152015415', N'T201', '05/05/2023', '09/05/2023', N'Nguyễn Tấn Cao Kỳ')


SET IDENTITY_INSERT [dbo].[ThueP] OFF
select * from ThueP
SET ANSI_NULLS ON
GO

create proc LayDSPhong
as
begin
 select * from Phong 
end

exec LayDSPhong

-- thủ tục thêm 1 phòng
CREATE PROCEDURE [dbo].[sp_ThemPhong]
	@MaP nvarchar(5),
	@TenP nvarchar(255),
	@LoaiP nvarchar(25),
	@GiaP int,
	@Tinhtrang nvarchar(15)
AS
BEGIN
	INSERT INTO [dbo].[Phong] ([MaP], [TenP], [LoaiP], [GiaP], [Tinhtrang])
	VALUES (@MaP, @TenP, @LoaiP, @GiaP, @Tinhtrang)
END

-- thủ tục xóa phòng
CREATE PROCEDURE [dbo].[sp_XoaPhong]
	@MaP nvarchar(5)
AS
BEGIN
	DELETE FROM [dbo].[Phong]
	WHERE [MaP] = @MaP
END


-- thủ tục sửa thông tin của phòng
CREATE PROCEDURE [dbo].[sp_SuaPhong]
	@MaP nvarchar(5),
	@TenP nvarchar(255),
	@LoaiP nvarchar(25),
	@GiaP int,
	@Tinhtrang nvarchar(15)
AS
BEGIN
	UPDATE [dbo].[Phong]
	SET [TenP] = @TenP,
		[LoaiP] = @LoaiP,
		[GiaP] = @GiaP,
		[Tinhtrang] = @Tinhtrang
	WHERE [MaP] = @MaP
END
------ thủ tục thêm khách
CREATE PROCEDURE [dbo].[sp_ThemKhach]
	@CMT nvarchar(12),
	@Hoten nvarchar(255),
	@Diachi nvarchar(255),
	@GT nvarchar(5),
	@SDT nvarchar(15)
AS
BEGIN
	INSERT INTO [dbo].[Khach] ([CMT], [Hoten], [Diachi], [GT], [SDT])
	VALUES (@CMT, @Hoten, @Diachi, @GT, @SDT)
END
--------thủ tục Xóa Khách
CREATE PROCEDURE [dbo].[sp_XoaKhach]
    @CMT nvarchar(12)
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Khach
    WHERE CMT = @CMT;
END
-----------sua Khach
CREATE PROCEDURE [dbo].[sp_CapNhatKhach]
    @CMT NVARCHAR(12),
    @Hoten NVARCHAR(255),
    @Diachi NVARCHAR(255),
    @GT NVARCHAR(5),
    @SDT NVARCHAR(15)
AS
BEGIN
    UPDATE Khach
    SET Hoten = @Hoten,
        Diachi = @Diachi,
        GT = @GT,
        SDT = @SDT
    WHERE CMT = @CMT;
END

-- thủ tục đăng nhập
CREATE PROC USP_Login
@userName NVARCHAR(50),
@password NVARCHAR(50)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE Acc = @userName AND Pass = @password
END
GO
exec USP_Login @userName = N'quan', @password=N'1234'

-- lấy tài khoản dựa vào tên
CREATE PROC USP_GetAccountByUserName
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM TaiKhoan WHERE Acc = @username
END
GO
exec USP_GetAccountByUserName N'quan'

-- tìm kiếm theo tên
create PROCEDURE USP_SearchHangHoaByName
    @Hoten NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Khach
	where Hoten LIKE '%' + @Hoten + '%'
END

EXEC USP_SearchHangHoaByName @Hoten = 'linh'
-- tìm kiếm phòng
create PROCEDURE USP_SearchPhongByType
    @LoaiP NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Phong
	where LoaiP LIKE '%' + @LoaiP + '%'
END

exec USP_SearchPhongByType N'thường'
-- thủ tục thêm thuê phòng mới
CREATE PROCEDURE USP_ThemThuePhong
	@CMT nvarchar(12),
	@MaP nvarchar(5),
	@NgayDen date,
	@NgayDi date,
	@TenNV nvarchar(30)
AS
BEGIN
	INSERT INTO [dbo].[ThueP] ([CMT], [MaP], [Ngayden], [Ngaydi], [TenNV])
	VALUES (@CMT, @MaP, @NgayDen, @NgayDi, @TenNV)
END

Create PROCEDURE USP_XoaThuePhong
	@MaHD int
AS
BEGIN
	DELETE FROM [dbo].[ThueP]
	WHERE [MaHD] = @MaHD
END
-- thủ tục sửa tình trạng
CREATE PROCEDURE USP_SuaTinhTrangPhong
    @MaPhong NVARCHAR(5)
AS
BEGIN
    UPDATE Phong
    SET Tinhtrang = N'Có khách'
    WHERE MaP = @MaPhong;
END
exec USP_SuaTinhTrangPhong N'V301'

CREATE PROCEDURE sp_SuaTinhTrangPhong
    @MaPhong NVARCHAR(5),
    @TinhTrang NVARCHAR(15)
AS
BEGIN
    UPDATE Phong
    SET Tinhtrang = @TinhTrang
    WHERE MaP = @MaPhong;
END

CREATE PROCEDURE sp_XoaThuePhong
    @MaHD INT
AS
BEGIN
    DELETE FROM ThueP
    WHERE MaHD = @MaHD;
END