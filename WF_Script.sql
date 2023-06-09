USE [master]
GO
/****** Object:  Database [QLKhachSan]    Script Date: 6/6/2023 5:57:17 PM ******/
CREATE DATABASE [QLKhachSan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLKhachSan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NAUHTSQLSERVER\MSSQL\DATA\QLKhachSan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLKhachSan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.NAUHTSQLSERVER\MSSQL\DATA\QLKhachSan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLKhachSan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKhachSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKhachSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKhachSan] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QLKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKhachSan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKhachSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKhachSan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKhachSan', N'ON'
GO
ALTER DATABASE [QLKhachSan] SET QUERY_STORE = OFF
GO
USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [varchar](50) NOT NULL,
	[MoTa] [varchar](100) NULL,
	[GiaDichVu] [decimal](18, 0) NOT NULL,
	[TrangThai] [int] NOT NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [varchar](80) NOT NULL,
	[GioiTinh] [varchar](30) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[SoDienThoai] [varchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDichVu](
	[MaPhieu] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietDichVu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDichVu](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgaySuDung] [date] NOT NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_PhieuDichVu] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_ChiTietPhieuDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_ChiTietPhieuDichVu]
AS
	SELECT c.MaPhieu, TenDichVu, SoLuong, NgaySuDung, TenKhachHang, SoDienThoai
	FROM ChiTietDichVu c
	JOIN DichVu d ON c.MaDichVu = d.MaDichVu
	JOIN PhieuDichVu p ON c.MaPhieu = p.MaPhieu
	JOIN KhachHang k ON p.MaKhachHang = k.MaKhachHang
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiPhong] [int] NOT NULL,
	[TenPhong] [varchar](50) NOT NULL,
	[TrangThai] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDatPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatPhong](
	[MaPhieu] [int] NOT NULL,
	[MaPhong] [int] NOT NULL,
	[NgayNhanPhong] [date] NOT NULL,
	[NgayTraPhong] [date] NOT NULL,
 CONSTRAINT [PK_ChiTietDatPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatPhong](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgayLapPhieu] [date] NOT NULL,
	[TienCoc] [decimal](18, 0) NOT NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_PhieuDatPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewDatPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewDatPhong]
AS
SELECT 
	CTP.MaPhieu,
    KH.TenKhachHang,
    KH.SoDienThoai,
    P.TenPhong,
    CTP.NgayNhanPhong,
    CTP.NgayTraPhong
FROM 
    KhachHang KH
    JOIN PhieuDatPhong PDT ON KH.MaKhachHang = PDT.MaKhachHang
    JOIN ChiTietDatPhong CTP ON PDT.MaPhieu = CTP.MaPhieu
    JOIN Phong P ON CTP.MaPhong = P.MaPhong
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [varchar](50) NOT NULL,
	[MoTa] [varchar](50) NULL,
	[GiaPhong] [decimal](18, 0) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TinhTrang] [int] NOT NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewPhong]
AS
SELECT MaPhong, LoaiPhong.MaLoaiPhong, TenPhong, TenLoaiPhong, GiaPhong, TrangThai, MoTa
FROM Phong 
JOIN dbo.LoaiPhong ON LoaiPhong.MaLoaiPhong = Phong.MaLoaiPhong
WHERE TrangThai = 'Con phong'
GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonThanhToan](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
	[TongTien] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_HoaDonThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewHoaDonDaThanhToan]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewHoaDonDaThanhToan] 
AS 
SELECT HoaDonThanhToan.MaHoaDon, HoaDonThanhToan.MaKhachHang, PhieuDichVu.MaPhieu AS MaPhieuDichVu, PhieuDatPhong.MaPhieu AS MaPhieuPhong,
    NgayThanhToan, HoaDonThanhToan.TongTien
FROM dbo.HoaDonThanhToan 
JOIN dbo.PhieuDatPhong ON PhieuDatPhong.MaKhachHang = HoaDonThanhToan.MaKhachHang
LEFT JOIN dbo.PhieuDichVu ON PhieuDichVu.MaKhachHang = HoaDonThanhToan.MaKhachHang
GO
/****** Object:  View [dbo].[viewHoaDon]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewHoaDon] AS
SELECT KhachHang.MaKhachHang, TenKhachHang, SoDienThoai, PhieuDatPhong.MaPhieu AS MaPhieuPhong, 
	PhieuDatPhong.TongTien AS TienPhong, PhieuDichVu.MaPhieu AS MaPhieuDichVu, PhieuDichVu.TongTien AS TienDichVu
FROM dbo.KhachHang
JOIN dbo.PhieuDatPhong ON PhieuDatPhong.MaKhachHang = KhachHang.MaKhachHang
LEFT JOIN dbo.PhieuDichVu ON PhieuDichVu.MaKhachHang = KhachHang.MaKhachHang
WHERE NOT EXISTS (
	SELECT *
	FROM dbo.viewHoaDonDaThanhToan
	WHERE viewHoaDonDaThanhToan.MaKhachHang = KhachHang.MaKhachHang
		AND (viewHoaDonDaThanhToan.MaPhieuDichVu = PhieuDichVu.MaPhieu OR viewHoaDonDaThanhToan.MaPhieuPhong = PhieuDatPhong.MaPhieu)
)
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaDanhGia] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NOT NULL,
	[NoiDung] [varchar](200) NOT NULL,
 CONSTRAINT [PK_DanhGia] PRIMARY KEY CLUSTERED 
(
	[MaDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MaChucVu] [int] NULL,
	[TenNhanVien] [varchar](80) NOT NULL,
	[GioiTinh] [varchar](30) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[SoDienThoai] [varchar](10) NOT NULL,
	[HoatDong] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanDangNhap]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanDangNhap](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TaiKhoanDangNhap] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (1, 4, CAST(N'2023-05-27' AS Date), CAST(N'2023-05-28' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (2, 6, CAST(N'2023-05-27' AS Date), CAST(N'2023-05-28' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (3, 9, CAST(N'2023-05-28' AS Date), CAST(N'2023-05-29' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (3, 10, CAST(N'2023-05-28' AS Date), CAST(N'2023-05-29' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (4, 13, CAST(N'2023-05-29' AS Date), CAST(N'2023-05-30' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (5, 14, CAST(N'2023-05-30' AS Date), CAST(N'2023-05-31' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (6, 15, CAST(N'2023-05-31' AS Date), CAST(N'2023-06-01' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (6, 16, CAST(N'2023-05-31' AS Date), CAST(N'2023-06-01' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (8, 1, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-04' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (8, 2, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-04' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (9, 3, CAST(N'2023-06-03' AS Date), CAST(N'2023-06-04' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (9, 7, CAST(N'2023-06-03' AS Date), CAST(N'2023-06-04' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (10, 12, CAST(N'2023-06-04' AS Date), CAST(N'2023-06-05' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (10, 18, CAST(N'2023-06-04' AS Date), CAST(N'2023-06-05' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (11, 7, CAST(N'2023-06-04' AS Date), CAST(N'2023-06-05' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (11, 8, CAST(N'2023-06-04' AS Date), CAST(N'2023-06-08' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (12, 3, CAST(N'2023-06-04' AS Date), CAST(N'2023-06-05' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (13, 7, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (13, 8, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (14, 7, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-08' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (14, 20, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (15, 7, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (15, 8, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
INSERT [dbo].[ChiTietDatPhong] ([MaPhieu], [MaPhong], [NgayNhanPhong], [NgayTraPhong]) VALUES (16, 7, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-08' AS Date))
GO
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (1, 1, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (1, 2, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (2, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (3, 3, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (3, 5, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (4, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (5, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (6, 2, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (6, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (7, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (7, 4, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (8, 2, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (8, 3, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (8, 4, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (9, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (9, 5, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (10, 3, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (11, 2, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (11, 3, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (12, 2, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (12, 3, 3)
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (1, N'Admin')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (2, N'Quan ly')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (3, N'Nhan vien')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhGia] ON 

INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (1, 1, N'Dich vu rat tot')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (2, 2, N'Dich vu kha tot')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (3, 3, N'Phong rat sach se')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (4, 4, N'Chat luong tuyet voi, 5 sao nhe!')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (5, 5, N'De nghi them mot vai dich vu moi')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (6, 6, N'Khach san dep, nhan viet nhiet tinh')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (7, 7, N'Dich vu chat luong cao')
INSERT [dbo].[DanhGia] ([MaDanhGia], [MaKhachHang], [NoiDung]) VALUES (8, 8, N'Gia su dung dich vu hoi dat')
SET IDENTITY_INSERT [dbo].[DanhGia] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (1, N'Gymnastic', N'Phong tap gym', CAST(200000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (2, N'Swimming', N'Ho boi', CAST(50000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (3, N'Yoga', N'Phong tap yoga', CAST(150000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (4, N'Sauna', N'Xong hoi', CAST(250000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (5, N'Massage', N'Mat-xa', CAST(300000 AS Decimal(18, 0)), 1)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (6, N'Karaoke', N'Hat kara', CAST(70000 AS Decimal(18, 0)), 0)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu], [TrangThai]) VALUES (7, N'Nha an', N'Nha an 5 sao', CAST(450000 AS Decimal(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] ON 

INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (1, 1, CAST(N'2023-05-27' AS Date), CAST(1050000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (2, 2, CAST(N'2023-05-27' AS Date), CAST(1300000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (3, 3, CAST(N'2023-05-28' AS Date), CAST(2850000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (4, 4, CAST(N'2023-05-29' AS Date), CAST(1800000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (5, 5, CAST(N'2023-05-30' AS Date), CAST(1800000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (6, 6, CAST(N'2023-05-30' AS Date), CAST(3450000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (7, 11, CAST(N'2023-06-03' AS Date), CAST(5600000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (8, 13, CAST(N'2023-06-04' AS Date), CAST(2700000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (9, 12, CAST(N'2023-06-04' AS Date), CAST(2600000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (10, 14, CAST(N'2023-06-04' AS Date), CAST(6200000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (11, 16, CAST(N'2023-06-06' AS Date), CAST(2600000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (12, 17, CAST(N'2023-06-06' AS Date), CAST(3200000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (13, 18, CAST(N'2023-06-06' AS Date), CAST(2600000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (14, 19, CAST(N'2023-06-06' AS Date), CAST(2000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (1, N'Ho Thi Thanh', N'Nu', N'110 Tan Binh', N'0871373828')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (2, N'Nguyen Minh Thang', N'Nam', N'120 Truong Tho', N'0982721782')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (3, N'Tran Ngoc Tuyet Nhu', N'Nu', N'12 Quan 1', N'0838373732')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (4, N'Cao Ba Phat', N'Nam', N'21 Quan Binh Tan', N'0928282818')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (5, N'Luong Duy Khanh', N'Nam', N'101 Ben Nghe', N'0288282828')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (6, N'Tran Ngoc Le', N'Nu', N'32 Tan Binh', N'0938282717')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (7, N'Ngo Thanh Tam', N'Nam', N'01 Ben Nghe', N'0933839391')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (8, N'Vo Thi Thanh Thuy', N'Nu', N'201 Tran Xuan', N'0292282811')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (9, N'Ngo Minh Thuan', N'Nam', N'230 Thu Duc', N'0823827112')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (10, N'Ngo Thua An', N'Nam', N'12 Binh Phuoc', N'0287283112')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (11, N'Ngo Thua An', N'Nam', N'12 Nam Dinh', N'0238219831')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (12, N'Nguyen Van Long', N'Nam', N'183 Binh Dinh', N'0832173612')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (13, N'Hao Quang Dang', N'Nam', N'12 Thu Duc', N'0872837211')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (14, N'Tran Van Tin', N'Nam', N'12 Vo Van Ngan', N'0823871231')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (15, N'Nguyen Thanh Trung', N'Nam', N'83 Vo Van Ngan', N'0893183121')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (16, N'Ngo Minh Thuan', N'Nam', N'023 Vo Van Ngan', N'0937772812')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (17, N'Tran Ngoc Nam', N'Nu', N'12 Thu Duc', N'0827782721')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (18, N'Nguyen Thi Ngoc Anh', N'Nu', N'232 Vo Ngan Ngan', N'0898983213')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (19, N'Ngo Minh Thuan', N'Nam', N'23 Chuong Duong', N'0787635213')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong], [TinhTrang]) VALUES (1, N'Don 1G-1N', N'Phong don 1 giuong don, cho 1 nguoi', CAST(800000 AS Decimal(18, 0)), 5, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong], [TinhTrang]) VALUES (2, N'Doi 1G-2N', N'Phong doi 1 giuong doi, cho 2 nguoi', CAST(1000000 AS Decimal(18, 0)), -1, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong], [TinhTrang]) VALUES (3, N'Doi 2G-2N', N'Phong doi 2 giuong don, cho 2 nguoi', CAST(1200000 AS Decimal(18, 0)), 7, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong], [TinhTrang]) VALUES (4, N'Doi 2G-4N', N'Phong doi 2 giuong doi, cho 4 nguoi', CAST(1500000 AS Decimal(18, 0)), 7, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong], [TinhTrang]) VALUES (5, N'4G-4N', N'Phong doi', CAST(2000000 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong], [TinhTrang]) VALUES (6, N'5G-5N', N'Phong don, 5 giuong , 5 nguoi', CAST(2200000 AS Decimal(18, 0)), 0, 0)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (1, 1, N'Nguyen Van An', N'Nam', N'01 Pham Ngu Lao', N'0921288372', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (2, 2, N'Tran Minh Thien', N'Nam', N'12 Pham Ngu Lao', N'0923283828', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (3, 3, N'Tran Ngoc Oanh', N'Nu', N'012 Ben Thanh', N'0929832818', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (4, 3, N'Pham Thi Thu Ngan', N'Nu', N'121 Ben Nghe', N'0727928288', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (5, 3, N'Do Van Anh', N'Nu', N'023 Nguyen Thai Binh', N'0282838281', 0)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (6, 3, N'Tran Quang Nam', N'Nam', N'121 Ben Thanh', N'0322828281', 0)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (7, 3, N'Nguyen Nhat Minh', N'Nam', N'323 Nguyen Thai Binh', N'0892817281', 0)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (8, 3, N'Nguyen Hai Binh', N'Nam', N'78 Tan Binh', N'0827389271', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (9, 3, N'Ngo Minh Thuan', N'Nam', N'01 Quan 1', N'0928372132', 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDatPhong] ON 

INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (1, 1, CAST(N'2023-05-27' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (2, 2, CAST(N'2023-05-27' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (3, 3, CAST(N'2023-05-28' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(2400000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (4, 4, CAST(N'2023-05-29' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (5, 5, CAST(N'2023-05-26' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (6, 6, CAST(N'2023-05-29' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(3000000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (8, 11, CAST(N'2023-06-01' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(4800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (9, 12, CAST(N'2023-06-03' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (10, 13, CAST(N'2023-06-04' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(2700000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (11, 14, CAST(N'2023-06-04' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (12, 15, CAST(N'2023-06-04' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (13, 16, CAST(N'2023-06-06' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (14, 17, CAST(N'2023-06-06' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(3200000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (15, 18, CAST(N'2023-06-06' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (16, 19, CAST(N'2023-06-06' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(2000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PhieuDatPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDichVu] ON 

INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (1, 1, CAST(N'2023-05-27' AS Date), CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (2, 2, CAST(N'2023-05-27' AS Date), CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (3, 3, CAST(N'2023-05-28' AS Date), CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (4, 4, CAST(N'2023-05-29' AS Date), CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (5, 5, CAST(N'2023-05-30' AS Date), CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (6, 6, CAST(N'2023-05-30' AS Date), CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (7, 11, CAST(N'2023-06-02' AS Date), CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (8, 12, CAST(N'2023-06-03' AS Date), CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (9, 14, CAST(N'2023-06-04' AS Date), CAST(1200000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (10, 15, CAST(N'2023-06-04' AS Date), CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (11, 16, CAST(N'2023-06-06' AS Date), CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (12, 18, CAST(N'2023-06-06' AS Date), CAST(600000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PhieuDichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (1, 1, N'P101', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (2, 1, N'P102', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (3, 1, N'P103', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (4, 1, N'P104', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (5, 2, N'P201', N'Dang sua chua')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (6, 2, N'P202', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (7, 2, N'P203', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (8, 2, N'P204', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (9, 3, N'P301', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (10, 3, N'P302', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (11, 3, N'P303', N'Dang sua chua')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (12, 3, N'P304', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (13, 4, N'P401', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (14, 4, N'P402', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (15, 4, N'P403', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (16, 4, N'P404 ', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (17, 4, N'P405', N'Dang sua chua')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (18, 4, N'P406', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (19, 5, N'P406', N'Da huy')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (20, 3, N'P305', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (21, 3, N'P306', N'Da huy')
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanDangNhap] ON 

INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (1, 1, N'nguyenvanan1.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (2, 2, N'tranminhthien2.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (3, 3, N'tranngocoanh3.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (4, 4, N'phamthithungan4.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (5, 5, N'dovananh5.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (6, 6, N'tranquannam6.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (7, 7, N'nguyennhatminh7.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (8, 8, N'nguyenhaibinh8.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (9, 9, N'ngominhthuan9.stown', N'123456')
SET IDENTITY_INSERT [dbo].[TaiKhoanDangNhap] OFF
GO
ALTER TABLE [dbo].[ChiTietDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatPhong_PhieuDatPhong] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDatPhong] ([MaPhieu])
GO
ALTER TABLE [dbo].[ChiTietDatPhong] CHECK CONSTRAINT [FK_ChiTietDatPhong_PhieuDatPhong]
GO
ALTER TABLE [dbo].[ChiTietDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatPhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[ChiTietDatPhong] CHECK CONSTRAINT [FK_ChiTietDatPhong_Phong]
GO
ALTER TABLE [dbo].[ChiTietDichVu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDichVu_DichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[ChiTietDichVu] CHECK CONSTRAINT [FK_ChiTietDichVu_DichVu]
GO
ALTER TABLE [dbo].[ChiTietDichVu]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDichVu_PhieuDichVu] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuDichVu] ([MaPhieu])
GO
ALTER TABLE [dbo].[ChiTietDichVu] CHECK CONSTRAINT [FK_ChiTietDichVu_PhieuDichVu]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonThanhToan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonThanhToan_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDonThanhToan] CHECK CONSTRAINT [FK_HoaDonThanhToan_KhachHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhieuDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatPhong_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuDatPhong] CHECK CONSTRAINT [FK_PhieuDatPhong_KhachHang]
GO
ALTER TABLE [dbo].[PhieuDichVu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDichVu_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuDichVu] CHECK CONSTRAINT [FK_PhieuDichVu_KhachHang]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([MaLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[TaiKhoanDangNhap]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanDangNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoanDangNhap] CHECK CONSTRAINT [FK_TaiKhoanDangNhap_NhanVien]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [status_check] CHECK  (([TrangThai]='Da huy' OR [TrangThai]='Dang sua chua' OR [TrangThai]='Dang su dung' OR [TrangThai]='Con phong'))
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [status_check]
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatChucVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCapNhatChucVu] 
	@maChucVu INT,
	@tenChucVu VARCHAR(30)
AS
BEGIN
	UPDATE dbo.ChucVu 
	SET TenChucVu = @tenChucVu
	WHERE MaChucVu = @maChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spCapNhatDichVu]
	@maDichVu INT,
	@tenDichVu varchar(50),
	@moTa varchar(100),
	@giaDichVu decimal(18,0)
AS
BEGIN
	UPDATE DichVu
	SET TenDichVu = @tenDichVu,
		MoTa = @moTa,
		GiaDichVu = @giaDichVu
	WHERE MaDichVu = @maDichVu
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatKhachHang]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCapNhatKhachHang]
	@maKhachHang INT,
	@tenKhachHang VARCHAR(50),
	@gioiTinh VARCHAR(30),
	@diaChi VARCHAR(100),
	@soDienThoai VARCHAR(10)
AS
BEGIN
	UPDATE dbo.KhachHang
	SET TenKhachHang = @tenKhachHang,
		GioiTinh = @gioiTinh,
		DiaChi = @diaChi,
		SoDienThoai = @soDienThoai
	WHERE MaKhachHang = @maKhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatLoaiPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCapNhatLoaiPhong]
	@maLoaiPhong INT,
	@tenLoaiPhong VARCHAR(30),
	@moTa VARCHAR(100),
	@giaPhong DECIMAL
AS
BEGIN
	UPDATE dbo.LoaiPhong
	SET TenLoaiPhong = @tenLoaiPhong,
		MoTa = @moTa,
		GiaPhong = @giaPhong
	WHERE MaLoaiPhong = @maLoaiPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatNhanVien]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spCapNhatNhanVien]
	@maNhanVien INT,
	@maChucVu INT,
	@tenNhanVien VARCHAR(50),
	@gioiTinh VARCHAR(30),
	@diaChi VARCHAR(100),
	@soDienThoai VARCHAR(10)
AS
BEGIN
	UPDATE dbo.NhanVien
	SET MaChucVu = @maChucVu,
		TenNhanVien = @tenNhanVien,
		GioiTinh = @gioiTinh,
		DiaChi = @diaChi,
		SoDienThoai = @soDienThoai
	WHERE MaNhanVien = @maNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[spCapNhatPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spCapNhatPhong]
	@maPhong INT,
	@maLoaiPhong INT,
	@tenPhong VARCHAR(30),
	@trangThai VARCHAR(30)
AS
BEGIN
	UPDATE dbo.Phong
	SET TenPhong = @tenPhong,
		MaLoaiPhong = @maLoaiPhong,
		TrangThai = @trangThai
	WHERE MaPhong = @maPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spDoiMatKhau]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDoiMatKhau]
	@maNhanVien INT,
	@matKhauCu VARCHAR(30),
	@matKhauMoi VARCHAR(30)
AS
BEGIN
	IF EXISTS (SELECT * FROM TaiKhoanDangNhap WHERE MatKhau = @matKhauCu)
	BEGIN
		IF LEN(@matKhauMoi) >= 6 AND LEN(@matKhauMoi) <=30
		BEGIN
			UPDATE dbo.TaiKhoanDangNhap
			SET MatKhau = @matKhauMoi
			WHERE MaNhanVien = @maNhanVien
		END
		ELSE
        BEGIN
			RAISERROR(N'Mật khẩu không phải từ 6-30 ký tự', 16, 1)
			RETURN
        END
	END
	ELSE
    BEGIN
		RAISERROR(N'Mật khẩu cũ không đúng!',16,1)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[spTaoHoaDon]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spTaoHoaDon]
	@maKhachHang INT,
	@ngayThanhToan DATE,
	@tongTien DECIMAL
AS
BEGIN
	INSERT INTO HoaDonThanhToan(MaKhachHang,NgayThanhToan,TongTien)
	VALUES (@maKhachHang, @ngayThanhToan, @tongTien)
END
GO
/****** Object:  StoredProcedure [dbo].[spTaoPhieuDatDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spTaoPhieuDatDichVu]
	@maKhachHang INT,
	@ngaySuDung DATE,
	@tongTien DECIMAL
AS
BEGIN
	INSERT INTO PhieuDichVu(MaKhachHang, NgaySuDung, TongTien)
	VALUES (@maKhachHang, @ngaySuDung, @tongTien)
END
GO
/****** Object:  StoredProcedure [dbo].[spTaoPhieuDatPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----
CREATE PROC [dbo].[spTaoPhieuDatPhong]
	@tenKhachHang VARCHAR(50),
	@gioiTinh VARCHAR(30),
	@diaChi VARCHAR(100),
	@soDienThoai VARCHAR(10),
	@ngayLapPhieu DATE,
	@tongTien DECIMAL
AS
BEGIN
	DECLARE @maKhachHang INT 
	SET XACT_ABORT ON
	BEGIN TRY
		BEGIN TRAN
			INSERT INTO KhachHang(TenKhachHang, GioiTinh, DiaChi, SoDienThoai)
			VALUES (@TenKhachHang, @gioiTinh, @diaChi, @soDienThoai)

			SET @maKhachHang = IDENT_CURRENT('dbo.KhachHang')
			INSERT INTO PhieuDatPhong(MaKhachHang, NgayLapPhieu, TienCoc, TongTien)
			VALUES (@maKhachHang, @ngayLapPhieu, 400000, @tongTien)

		COMMIT TRAN
	END TRY
    BEGIN CATCH 
		RAISERROR('Loi roi !!!', 16 ,1)
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[spThemChiTietDatPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spThemChiTietDatPhong]
	@maPhong INT,
	@ngayNhanPhong DATE,
	@ngayTraPhong DATE
AS
BEGIN
	DECLARE @maPhieu INT
	SET @maPhieu = IDENT_CURRENT('dbo.PhieuDatPhong')

	INSERT INTO ChiTietDatPhong(MaPhieu, MaPhong, NgayNhanPhong, NgayTraPhong)
	VALUES (@maPhieu, @maPhong, @ngayNhanPhong, @ngayTraPhong)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemChiTietDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemChiTietDichVu]
	@maDichVu INT,
	@soLuong INT
AS
BEGIN
	DECLARE @maPhieu INT
	SET @maPhieu = IDENT_CURRENT('dbo.PhieuDichVu')
	INSERT INTO ChiTietDichVu(MaPhieu, MaDichVu, SoLuong)
	VALUES (@maPhieu, @maDichVu, @soLuong)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemChucVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemChucVu]
	@tenChucVu VARCHAR(30)
AS
BEGIN
	INSERT INTO ChucVu(TenChucVu) VALUES (@tenChucVu)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemDichVu]
	@tenDichVu varchar(50),
	@moTa varchar(100),
	@giaDichVu decimal(18,0)
AS
BEGIN
	INSERT INTO DichVu(TenDichVu, MoTa, GiaDichVu, TrangThai)
	VALUES (@tenDichVu, @moTa, @giaDichVu, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemKhachHang]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--

CREATE PROC [dbo].[spThemKhachHang]
	@tenKhachHang VARCHAR(50),
	@gioiTinh VARCHAR(30),
	@diaChi VARCHAR(100),
	@soDienThoai VARCHAR(10)
AS
BEGIN
	INSERT INTO KhachHang(TenKhachHang, GioiTinh, DiaChi, SoDienThoai)
	VALUES(@tenKhachHang, @gioiTinh, @diaChi, @soDienThoai)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemLoaiPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemLoaiPhong]
	@tenLoaiPhong VARCHAR(30),
	@moTa VARCHAR(100),
	@giaPhong DECIMAL
AS
BEGIN
	INSERT INTO LoaiPhong(TenLoaiPhong, MoTa, GiaPhong, SoLuong, TinhTrang)
	VALUES (@tenLoaiPhong, @moTa, @giaPhong, 0, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemNhanVien]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spThemNhanVien]
	@maChucVu INT,
	@tenNhanVien VARCHAR(50),
	@gioiTinh VARCHAR(30),
	@diaChi VARCHAR(100),
	@soDienThoai VARCHAR(10)
AS
BEGIN
	INSERT INTO NhanVien(MaChucVu, TenNhanVien, GioiTinh, DiaChi, SoDienThoai, HoatDong)
	VALUES(@maChucVu, @tenNhanVien, @gioiTinh, @diaChi, @soDienThoai, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[spThemPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spThemPhong]
	@maLoaiPhong INT,
	@tenPhong VARCHAR(30),
	@trangThai VARCHAR(30)
AS
BEGIN
	INSERT INTO Phong(MaLoaiPhong, TenPhong, TrangThai)
	VALUES (@maLoaiPhong, @tenPhong, @trangThai)
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaChucVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spXoaChucVu] 
	@maChucVu INT
AS
BEGIN
	DELETE FROM dbo.ChucVu WHERE MaChucVu = @maChucVu
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaDichVu]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[spXoaDichVu]
	@maDichVu INT
 AS 
 BEGIN
	UPDATE dbo.DichVu
	SET TrangThai = 0
	WHERE MaDichVu = @maDichVu
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaLoaiPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spXoaLoaiPhong]
	@maLoaiPhong INT
AS
BEGIN
	UPDATE dbo.LoaiPhong
	SET TinhTrang = 0
	WHERE MaLoaiPhong = @maLoaiPhong
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaNhanVien]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spXoaNhanVien]
(@maNhanVien INT)
AS
BEGIN
	UPDATE dbo.NhanVien
	SET HoatDong = 0
	WHERE MaNhanVien = @maNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[spXoaPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spXoaPhong]
	@maPhong INT
AS
BEGIN
	UPDATE dbo.Phong 
	SET TrangThai = 'Da huy'
	WHERE MaPhong = @maPhong
END
GO
/****** Object:  Trigger [dbo].[trgCapNhatSoLuongPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trgCapNhatSoLuongPhong]
ON [dbo].[ChiTietDatPhong]
AFTER INSERT
AS
BEGIN
	UPDATE dbo.Phong
	SET TrangThai = 'Dang su dung'
	WHERE MaPhong IN (SELECT MaPhong FROM Inserted)

    UPDATE LoaiPhong
    SET SoLuong = SoLuong - 1
    FROM LoaiPhong LP
    INNER JOIN Phong P ON LP.MaLoaiPhong = P.MaLoaiPhong
    INNER JOIN inserted I ON P.MaPhong = I.MaPhong;
END
GO
ALTER TABLE [dbo].[ChiTietDatPhong] ENABLE TRIGGER [trgCapNhatSoLuongPhong]
GO
/****** Object:  Trigger [dbo].[trgCapNhatTrangThaiPhongSauKhiThanhToan]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trgCapNhatTrangThaiPhongSauKhiThanhToan]
ON [dbo].[HoaDonThanhToan]
AFTER INSERT
AS
BEGIN
    -- Lấy danh sách các Mã phòng từ bảng ChiTietDatPhong liên quan đến khách hàng trong hóa đơn thanh toán mới
    UPDATE dbo.Phong
    SET TrangThai = 'Con phong'
    WHERE MaPhong IN (
        SELECT ChiTietDatPhong.MaPhong
        FROM dbo.ChiTietDatPhong
        INNER JOIN dbo.PhieuDatPhong ON ChiTietDatPhong.MaPhieu = PhieuDatPhong.MaPhieu
        INNER JOIN inserted ON PhieuDatPhong.MaKhachHang = inserted.MaKhachHang
    )
END
GO
ALTER TABLE [dbo].[HoaDonThanhToan] ENABLE TRIGGER [trgCapNhatTrangThaiPhongSauKhiThanhToan]
GO
/****** Object:  Trigger [dbo].[TaoTaiKhoan]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[TaoTaiKhoan]
ON [dbo].[NhanVien]
AFTER INSERT
AS
BEGIN
    -- Lấy thông tin từ bảng Inserted (những dòng đã được chèn vào bảng NhanVien)
    DECLARE @MaNhanVien INT, @TenNhanVien VARCHAR(80), @TenDangNhap VARCHAR(50), @MatKhau VARCHAR(30)

    SELECT
        @MaNhanVien = MaNhanVien,
        @TenNhanVien = TenNhanVien
    FROM
        Inserted

    -- Tạo giá trị cho TenDangNhap và MatKhau
    SET @TenDangNhap = LOWER(REPLACE(@TenNhanVien, ' ', '')) + CONVERT(VARCHAR(10), @MaNhanVien) + '.stown'
    SET @MatKhau = '123456'

    -- Thêm dữ liệu vào bảng TaiKhoanDangNhap
    INSERT INTO TaiKhoanDangNhap (MaNhanVien, TenDangNhap, MatKhau)
    VALUES (@MaNhanVien, @TenDangNhap, @MatKhau)
END
GO
ALTER TABLE [dbo].[NhanVien] ENABLE TRIGGER [TaoTaiKhoan]
GO
/****** Object:  Trigger [dbo].[trgTangSoLuongPhong]    Script Date: 6/6/2023 5:57:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trgTangSoLuongPhong]
ON [dbo].[Phong]
AFTER INSERT
AS
BEGIN
    UPDATE LoaiPhong
    SET SoLuong = SoLuong + 1 -- Tăng số lượng phòng lên 1
    WHERE LoaiPhong.MaLoaiPhong IN (SELECT MaLoaiPhong FROM inserted);
END;
GO
ALTER TABLE [dbo].[Phong] ENABLE TRIGGER [trgTangSoLuongPhong]
GO
USE [master]
GO
ALTER DATABASE [QLKhachSan] SET  READ_WRITE 
GO
