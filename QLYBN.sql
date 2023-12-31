USE [QLYBENHNHAN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TenDangNhap] [nvarchar](100) NULL,
	[TenHienThi] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bacsi]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bacsi](
	[MaBacSi] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[MaKhoa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBacSi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Benh]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benh](
	[MaBenh] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[Trieuchung] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Benhnhan]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benhnhan](
	[MaBenhNhan] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[CCCD] [nvarchar](20) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Phone] [nvarchar](20) NULL,
	[BHYT] [nvarchar](100) NULL,
	[NgayNhapVien] [date] NULL,
	[NgayRaVien] [date] NULL,
	[MaKhoa] [int] NULL,
	[MaBacSi] [int] NULL,
	[MaYTa] [int] NULL,
	[MaBenh] [int] NULL,
	[MaGiuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giuongbenh]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giuongbenh](
	[MaGiuong] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[status] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] NOT NULL,
	[DaTT] [float] NULL,
	[ChuaTT] [float] NULL,
	[status] [int] NULL,
	[MaBenhNhan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[price] [float] NULL,
	[MaBenh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yta]    Script Date: 13/10/2023 8:22:00 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yta](
	[MaYTa] [int] NOT NULL,
	[name] [nvarchar](100) NULL,
	[MaKhoa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaYTa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TenDangNhap], [TenHienThi], [MatKhau]) VALUES (N'tuyetnhi123', N'Tuyết Nhi', N'12345678')
INSERT [dbo].[Account] ([TenDangNhap], [TenHienThi], [MatKhau]) VALUES (N'tramy123', N'Trà My', N'123456789')
INSERT [dbo].[Account] ([TenDangNhap], [TenHienThi], [MatKhau]) VALUES (N'a', N'a', N'1')
INSERT [dbo].[Account] ([TenDangNhap], [TenHienThi], [MatKhau]) VALUES (NULL, N'', NULL)
GO
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (101, N'Nguyễn Thuỵ Trang', 10)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (102, N'Lê Bảo Huy', 10)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (103, N'Nguyễn Đức Tới', 10)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (104, N'Bùi Văn Duy', 10)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (105, N'Nguyễn Thị Thu Hương', 10)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (111, N'Nguyễn Thị Hiền', 11)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (112, N'Đào Ngô Quyền', 11)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (113, N'Danh Bình An', 11)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (114, N'Nguyễn Thị Thanh Thuỷ', 11)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (115, N'Bùi Tấn Dũng', 11)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (121, N'Ngô Thiện Cường', 12)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (122, N'Phạm Thanh Hằng', 12)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (123, N'Nguyễn Thị Hồng', 12)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (124, N'Nguyễn Đắc Nhân Tâm', 12)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (125, N'Trần Mạnh Hoàng', 12)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (131, N'Hà Vũ', 13)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (132, N'Ngô Thị Thanh Quýt', 13)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (133, N'Phạm Thị Hà Giang', 13)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (134, N'Phạm Thị Thuỳ Trang', 13)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (135, N'Ngô Minh Sáng', 13)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (141, N'Võ Thành Toàn', 14)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (142, N'Nguyễn Trọng Sỹ', 14)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (143, N'Phan Ngọc Thi', 14)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (144, N'Nguyễn Thiên Đức', 14)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (145, N'Đỗ Phúc Nguyên', 14)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (151, N'Đỗ Thị Thu Hương', 15)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (152, N'Nguyễn Văn Dũng', 15)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (153, N'Trần Trung Kiên', 15)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (154, N'Nguyễn Hữu Huỳnh Hải', 15)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (155, N'Lê Xuân Long', 15)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (161, N'Trần Thị Mỹ Liên', 16)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (162, N'Nguyễn Văn Bé Hai', 16)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (163, N'Nguyễn Thanh Huân', 16)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (164, N'Nguyễn Ngọc Quỳnh Dung', 16)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (165, N'Phạm Thị Mỹ Hạnh', 16)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (171, N'Nguyễn Thu Huyền', 17)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (172, N'Nguyễn Vĩnh Phước', 17)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (173, N'Huỳnh Công Dũng', 17)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (174, N'Lê Nhạt Vinh', 17)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (175, N'Hồ Minh Mẫn', 17)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (181, N'Nguyễn Thị Mới', 18)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (182, N'Trần Đình Tùng', 18)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (183, N'Lê Thị Thanh Hải', 18)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (184, N'Trần Thị Kim Hoa', 18)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (185, N'Nguyễn Thị Thuỷ Tiên', 18)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (201, N'Trần Thị Mai Hương', 20)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (202, N'Trần Huỳnh Hạnh Thảo', 20)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (203, N'Lê Thị Linh Nhi', 20)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (211, N'Lê Văn Lâm', 21)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (212, N'Bùi Thị Hương Quỳnh', 21)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (213, N'Trần Thị Phương Mai', 21)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (214, N'Nguyễn Thị Yến', 21)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (215, N'Nguyễn Thị Ngọc Thuỳ', 21)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (221, N'Tạ Tấn Vũ', 22)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (222, N'Vũ Quang Huy', 22)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (223, N'Cao Thị Vân', 22)
INSERT [dbo].[Bacsi] ([MaBacSi], [name], [MaKhoa]) VALUES (224, N'Phạm Ngọc Thuý', 22)
GO
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (1, N'Đau tim', N'Đau ngực nặng, đau nhói, căng tức, tim như bị đè ép bởi vật nặng,khó thở')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (2, N'Bướu cổ', N'Mệt mỏi, khô da, thường xuyên bị lạnh, hay đổ mồ hôi,lồi mắt, khàn giọng')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (3, N'Hội chứng ruột kích thích', N'Đau quặn bụng, táo bón, tiêu chảy, thay đổi thói quen đại tiện ')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (4, N'Viêm amidan', N'Khó thở, khó nuốt nước bọt, sốt cao liên tục, thay đổi giọng nói')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (5, N'Đau mắt đỏ', N'Chảy ghèn xanh, ngứa, cộm mắt, sốt nhẹ hoặc đau họng')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (6, N'Mộng du', N'Thực hiện các hành động phức tạp, nói chuyện trong lúc ngủ, không nhớ gì khi thức dậy')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (7, N'Đột quỵ ', N'Mất ngôn ngữ, tê liệt, cử động yếu một phần cơ thể, thị lực suy giảm')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (8, N'Viêm nướu ', N'Sưng nướu răng, nướu có màu sẫm đỏ hoặc tím, nướu dễ chảy máu, hôi miệng')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (9, N'Gù lưng', N'Vùng lưng nhô cao bất thường, đau lưng, cứng cột sống')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (10, N'Ho gà', N'Đau họng, ho , sốt nhẹ, cảm lạnh')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (11, N'Ung thư da', N'Bị ngứa hoặc đau, vết loét không lành, xuất hiện các nốt như mụt cóc')
INSERT [dbo].[Benh] ([MaBenh], [name], [Trieuchung]) VALUES (12, N'Quai bị', N'Sưng viêm các tuyết nước bọt, mang tai, sốt, khó nuốt, biếng ăn')
GO
INSERT [dbo].[Benhnhan] ([MaBenhNhan], [Name], [CCCD], [NgaySinh], [GioiTinh], [Phone], [BHYT], [NgayNhapVien], [NgayRaVien], [MaKhoa], [MaBacSi], [MaYTa], [MaBenh], [MaGiuong]) VALUES (1, N'Nguyễn Văn A', N'048294006364', CAST(N'2013-02-03' AS Date), N'nam', N'0963784748', N'rhge242964', CAST(N'2015-04-02' AS Date), CAST(N'2015-04-07' AS Date), 10, 101, 101, 1, 1)
INSERT [dbo].[Benhnhan] ([MaBenhNhan], [Name], [CCCD], [NgaySinh], [GioiTinh], [Phone], [BHYT], [NgayNhapVien], [NgayRaVien], [MaKhoa], [MaBacSi], [MaYTa], [MaBenh], [MaGiuong]) VALUES (2, N'Nguyễn Thị B', N'046284284628', CAST(N'2015-03-04' AS Date), N'nữ', N'0962646648', N'gfgg465876', CAST(N'2015-04-05' AS Date), CAST(N'2016-03-04' AS Date), 10, 102, 102, 2, 2)
INSERT [dbo].[Benhnhan] ([MaBenhNhan], [Name], [CCCD], [NgaySinh], [GioiTinh], [Phone], [BHYT], [NgayNhapVien], [NgayRaVien], [MaKhoa], [MaBacSi], [MaYTa], [MaBenh], [MaGiuong]) VALUES (3, N'Nguyễn Văn C', N'072725895986', CAST(N'2010-04-07' AS Date), N'nam', N'0947664784', N'jbdjg475574', CAST(N'2015-05-03' AS Date), CAST(N'2016-04-07' AS Date), 11, 111, 111, 3, 2)
INSERT [dbo].[Benhnhan] ([MaBenhNhan], [Name], [CCCD], [NgaySinh], [GioiTinh], [Phone], [BHYT], [NgayNhapVien], [NgayRaVien], [MaKhoa], [MaBacSi], [MaYTa], [MaBenh], [MaGiuong]) VALUES (4, N'Phạm Thị D', N'047839768598', CAST(N'2009-03-04' AS Date), N'nữ', N'0976775447', N'jụggg64753', CAST(N'2009-06-05' AS Date), CAST(N'2009-09-05' AS Date), 12, 121, 121, 4, 4)
INSERT [dbo].[Benhnhan] ([MaBenhNhan], [Name], [CCCD], [NgaySinh], [GioiTinh], [Phone], [BHYT], [NgayNhapVien], [NgayRaVien], [MaKhoa], [MaBacSi], [MaYTa], [MaBenh], [MaGiuong]) VALUES (5, N'Vũ Thị Tuyết Nhi', N'052782665859', CAST(N'2005-06-19' AS Date), N'nữ', N'0842765573', N'jggge75633', CAST(N'2023-10-03' AS Date), CAST(N'2023-10-10' AS Date), 18, 181, 181, 5, 6)
GO
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (1, N'GB01', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (2, N'GB02', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (3, N'GB03', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (4, N'GB04', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (5, N'GB05', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (6, N'GB06', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (7, N'GB07', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (8, N'GB08', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (9, N'GB09', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (10, N'GB10', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (11, N'GB11', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (12, N'GB12', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (13, N'GB13', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (14, N'GB14', N'0')
INSERT [dbo].[Giuongbenh] ([MaGiuong], [name], [status]) VALUES (15, N'GB15', N'0')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (10, N'Khoa Cấp Cứu')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (11, N'Khoa Răng- Hàm - Mặt')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (12, N'Khoa Ung Bướu')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (13, N'Khoa Tiêu Hoá')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (14, N'Khoa Chấn Thương Chỉnh Hình')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (15, N'Khoa Thần Kinh')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (16, N'Khoa Tim Mạch')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (17, N'Khoa Tai Mũi Họng')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (18, N'Khoa Mắt')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (20, N'Khoa Nhi - Sơ sinh')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (21, N'Khoa Da liễu')
INSERT [dbo].[Khoa] ([MaKhoa], [name]) VALUES (22, N'Khoa Truyền Nhiễm')
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (11, N'Benazepril', 3000, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (12, N'Warfarin', 2300, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (13, N'Aspirin', 575, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (14, N'Acebutolol', 3000, 1)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (21, N'Levothyroxine', 800, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (22, N'Thimazole', 1300, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (23, N'Aspirin', 575, 2)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (31, N'Polyethylene Glycol', NULL, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (32, N'Diphenoxylate', NULL, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (33, N'Gabapentin', NULL, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (34, N'Alosetron', NULL, 3)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (41, N'Viên ngậm thảo dược', NULL, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (42, N'Ibuprofen', NULL, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (43, N'Penicillin', NULL, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (44, N'Cephalexin', NULL, 4)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (51, N'Mepoly', 32000, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (52, N'Antazoline', NULL, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (53, N'Vitamin', NULL, 5)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (61, N'Clonazepam', NULL, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (62, N'Estazolam', NULL, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (63, N'Trazodone', NULL, 6)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (71, N'Heparin', NULL, 7)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (72, N'Warfarin', NULL, 7)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (73, N'Acetylsalicylic (ASA)', NULL, 7)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (74, N'Statin', NULL, 7)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (81, N'Paracetamol', NULL, 8)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (82, N'Corticosteroid', NULL, 8)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (83, N'Cetylpyridinium clorua', NULL, 8)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (84, N'Penicilin', NULL, 8)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (91, N'Aspirin', NULL, 9)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (92, N'Naproxen', NULL, 9)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (93, N'Ibuprofen', NULL, 9)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (94, N'Paracetamol', NULL, 9)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (101, N'Erythromycin', NULL, 10)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (102, N'Ampiciliin', NULL, 10)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (103, N'Amoxicilin', NULL, 10)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (104, N'Dimedrol 0.15%', NULL, 10)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (111, N'Yervoy (ipilimumab)', NULL, 11)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (112, N'Erivedge', NULL, 11)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (113, N'Kem chống nắng', NULL, 11)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (121, N'Corticosteroid', NULL, 12)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (122, N'Paracetamol', NULL, 12)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (123, N'Oresol', NULL, 12)
INSERT [dbo].[Thuoc] ([MaThuoc], [name], [price], [MaBenh]) VALUES (124, N'Vitamin B,C,E', NULL, 12)
GO
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (101, N'Trần Thị Luận', 10)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (102, N'Huỳnh Quốc Đức', 10)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (103, N'NGuyễn Thị Phương Nhi', 10)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (104, N'Cao Thị Hạnh', 10)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (105, N'Nguyễn Hoàng Cường', 10)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (111, N'Hoàng Tuấn', 11)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (112, N'Nguyễn Vũ Quỳnh Phương', 11)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (113, N'Nguyễn Đức Thắng', 11)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (114, N'Bùi Thị Nương', 11)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (115, N'Lê Thị Hương Thảo', 11)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (121, N'Nguyễn Thị Đại Hồng', 12)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (122, N'Mai Văn Hiếu', 12)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (123, N'Trương Hoàng Kim', 12)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (124, N'Nguyễn Đức Trường', 12)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (125, N'Trần Thị Hương', 12)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (131, N'Nguyễn Thị Lam', 13)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (132, N'Dỗ Hoàng Xuân', 13)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (133, N'Phạm Thị Mai Thế', 13)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (134, N'Tô Quang Khánh', 13)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (135, N'Trần Thị Kim Tuyết', 13)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (141, N'Nông Ngọc Hải', 14)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (142, N'Bùi Mạnh Hùng', 14)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (143, N'Nguyễn Bảo Lục', 14)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (144, N'Bùi Văn Anh', 14)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (145, N'Nguyễn Thị Thắm', 14)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (151, N'Lê Thị Thuý Uyên', 15)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (152, N'Trườn Kim Anh', 15)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (153, N'Nguyễn Thị Phương Nga', 15)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (154, N'Phạm Quốc Đại', 15)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (155, N'lê Thị Thu Hiền', 15)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (161, N'Trần Hữu Duy', 16)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (162, N'Lê Văn Quang', 16)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (163, N'Phạm Thế Anh', 16)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (164, N'Đỗ Duy Đạt', 16)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (165, N'Phạm THị Hiền Diệu', 16)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (171, N'Hoàng Văn Phước', 17)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (172, N'Đỗ bảo Ngọc', 17)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (173, N'Trương Hoàng Việt', 17)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (174, N'Châu Thị Mạnh Thu', 17)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (175, N'Phan Thị Ngọc Linh', 17)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (181, N'Nguyễn Đức Sự', 18)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (182, N'Đặng Thị Thuỳ Quyên', 18)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (183, N'Hoàng Ngọc Vân', 18)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (184, N'Đỗ Thị Thắm', 18)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (185, N'Hồ Thị Thanh Tâm', 18)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (201, N'Phạm Quốc TRung', 20)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (202, N'Nguyễn Hữu Nghị', 20)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (203, N'Nguyễn Khánh Vân', 20)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (204, N'Nguyễn Xuân hoà', 20)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (211, N'Phạm Thị Hương', 21)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (212, N'Đặng Văn Thông', 21)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (213, N'Đỗ Võ Công Nguyên', 21)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (214, N'Nguyễn Trường Giang', 21)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (221, N'Trần Thị Tài', 22)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (222, N'Dương Thị KIm Loan', 22)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (223, N'Đỗ Hoàng Xuân', 22)
INSERT [dbo].[Yta] ([MaYTa], [name], [MaKhoa]) VALUES (224, NULL, 22)
GO
ALTER TABLE [dbo].[Bacsi]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Benhnhan]  WITH CHECK ADD FOREIGN KEY([MaBacSi])
REFERENCES [dbo].[Bacsi] ([MaBacSi])
GO
ALTER TABLE [dbo].[Benhnhan]  WITH CHECK ADD FOREIGN KEY([MaBenh])
REFERENCES [dbo].[Benh] ([MaBenh])
GO
ALTER TABLE [dbo].[Benhnhan]  WITH CHECK ADD FOREIGN KEY([MaGiuong])
REFERENCES [dbo].[Giuongbenh] ([MaGiuong])
GO
ALTER TABLE [dbo].[Benhnhan]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Benhnhan]  WITH CHECK ADD FOREIGN KEY([MaYTa])
REFERENCES [dbo].[Yta] ([MaYTa])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[Benhnhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD FOREIGN KEY([MaBenh])
REFERENCES [dbo].[Benh] ([MaBenh])
GO
ALTER TABLE [dbo].[Yta]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO

