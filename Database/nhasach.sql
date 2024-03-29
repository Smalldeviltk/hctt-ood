USE [master]
GO
/****** Object:  Database [NHASACH]    Script Date: 12/24/13 10:01:18 ******/
CREATE DATABASE [NHASACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NHASACH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NHASACH.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NHASACH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\NHASACH_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NHASACH] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NHASACH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NHASACH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NHASACH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NHASACH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NHASACH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NHASACH] SET ARITHABORT OFF 
GO
ALTER DATABASE [NHASACH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NHASACH] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [NHASACH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NHASACH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NHASACH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NHASACH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NHASACH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NHASACH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NHASACH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NHASACH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NHASACH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NHASACH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NHASACH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NHASACH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NHASACH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NHASACH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NHASACH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NHASACH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NHASACH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NHASACH] SET  MULTI_USER 
GO
ALTER DATABASE [NHASACH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NHASACH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NHASACH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NHASACH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'NHASACH', N'ON'
GO
USE [NHASACH]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[id] [nvarchar](20) NOT NULL,
	[MaHoaDon] [nvarchar](20) NULL,
	[MaSach] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_chitiethoadon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[id] [nvarchar](20) NOT NULL,
	[MaPhieuNhap] [nvarchar](20) NULL,
	[MaSach] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_chitietphieunhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[id] [nvarchar](20) NOT NULL,
	[MaNhanVien] [nvarchar](20) NULL,
	[TongTien] [nvarchar](20) NULL,
	[Ngay] [smalldatetime] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[id] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[id] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgaySinh] [nvarchar](20) NULL,
	[CMND] [nvarchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[Username] [nvarchar](20) NULL,
	[Password] [nvarchar](20) NULL,
	[Loai] [nvarchar](10) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[id] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[id] [nvarchar](20) NOT NULL,
	[MaNhanVien] [nvarchar](20) NULL,
	[TongTien] [int] NULL,
	[Ngay] [smalldatetime] NULL,
 CONSTRAINT [PK_phieunhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[id] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](200) NOT NULL,
	[GiaMua] [int] NULL,
	[GiaBan] [int] NULL,
	[MaNhaCungCap] [nvarchar](20) NULL,
	[SoLuong] [int] NULL,
	[MaTheLoai] [nvarchar](20) NULL,
	[MaNhaXuatBan] [nvarchar](20) NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACHTACGIA]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACHTACGIA](
	[id] [nvarchar](20) NOT NULL,
	[MaSach] [nvarchar](20) NOT NULL,
	[MaTacGia] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_SACHTACGIA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[id] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tacgia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[Ten] [nvarchar](50) NULL,
	[GiaTri] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 12/24/13 10:01:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[id] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NHACUNGCAP] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'NCC000001', N'Lê Phước Thạch ncc', N'', N'', N'', N'')
INSERT [dbo].[NHACUNGCAP] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'NCC000002', N'Huỳnh Văn Dog ncc', N'', N'', N'', N'')
INSERT [dbo].[NHANVIEN] ([id], [Ten], [NgaySinh], [CMND], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [Username], [Password], [Loai]) VALUES (N'NV006', N'Chó Thân', N'01/06/1991', N'215', N'Nam', N'016', N'129/27', N'lakongai', N'dog', N'dog', N'A')
INSERT [dbo].[NHAXUATBAN] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'NXB000001', N'Lê Phước Thạch nxb', N'', N'', N'', N'')
INSERT [dbo].[NHAXUATBAN] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'NXB000002', N'Huynh Van Dog nxb', N'', N'', N'', N'')
INSERT [dbo].[SACH] ([id], [Ten], [GiaMua], [GiaBan], [MaNhaCungCap], [SoLuong], [MaTheLoai], [MaNhaXuatBan]) VALUES (N'S000001', N'ÐQT', 20000, 22000, N'NCC000001', 10, N'TL000002', N'NXB000001')
INSERT [dbo].[SACH] ([id], [Ten], [GiaMua], [GiaBan], [MaNhaCungCap], [SoLuong], [MaTheLoai], [MaNhaXuatBan]) VALUES (N'S000002', N'Đek bit', 20000, 22000, N'NCC000001', 10, N'TL000002', N'NXB000001')
INSERT [dbo].[SACHTACGIA] ([id], [MaSach], [MaTacGia]) VALUES (N'STG000007', N'S000001', N'TG000002')
INSERT [dbo].[SACHTACGIA] ([id], [MaSach], [MaTacGia]) VALUES (N'STG000009', N'S000002', N'TG000003')
INSERT [dbo].[TACGIA] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'TG000001', N'Lê Phước Thạch tác giả', N'', N'', N'', N'')
INSERT [dbo].[TACGIA] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'TG000002', N'Gái Thân tác giả', N'', N'', N'', N'')
INSERT [dbo].[TACGIA] ([id], [Ten], [DiaChi], [DienThoai], [Email], [GhiChu]) VALUES (N'TG000003', N'Dog Than', NULL, NULL, NULL, NULL)
INSERT [dbo].[THELOAI] ([id], [Ten]) VALUES (N'TL000001', N'Văn học')
INSERT [dbo].[THELOAI] ([id], [Ten]) VALUES (N'TL000002', N'Lịch sử')
INSERT [dbo].[THELOAI] ([id], [Ten]) VALUES (N'TL000003', N'Tiểu thuyết')
ALTER TABLE [dbo].[SACH] ADD  CONSTRAINT [DF_SACH_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_chitiethoadon_hoadon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([id])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_chitiethoadon_hoadon]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_SACH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([id])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_SACH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_nhanvien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([id])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_hoadon_nhanvien]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_phieunhap_nhanvien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([id])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_phieunhap_nhanvien]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_sach_nhacungcap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([id])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_sach_nhacungcap]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNhaXuatBan])
REFERENCES [dbo].[NHAXUATBAN] ([id])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([id])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
ALTER TABLE [dbo].[SACHTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_SACHTACGIA_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([id])
GO
ALTER TABLE [dbo].[SACHTACGIA] CHECK CONSTRAINT [FK_SACHTACGIA_SACH]
GO
ALTER TABLE [dbo].[SACHTACGIA]  WITH CHECK ADD  CONSTRAINT [FK_SACHTACGIA_TACGIA] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TACGIA] ([id])
GO
ALTER TABLE [dbo].[SACHTACGIA] CHECK CONSTRAINT [FK_SACHTACGIA_TACGIA]
GO
USE [master]
GO
ALTER DATABASE [NHASACH] SET  READ_WRITE 
GO

ALTER TABLE [dbo].[PHIEUNHAP]
Alter Column Ngay datetime
GO

ALTER TABLE [dbo].[HOADON]
Alter Column Ngay datetime
GO