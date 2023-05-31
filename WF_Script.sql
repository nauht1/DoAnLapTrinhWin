USE [master]
GO
/****** Object:  Database [QLKhachSan]    Script Date: 5/31/2023 2:53:37 PM ******/
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
/****** Object:  Table [dbo].[ChiTietDatPhong]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[ChiTietDichVu]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[DanhGia]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[DichVu]    Script Date: 5/31/2023 2:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [varchar](50) NOT NULL,
	[MoTa] [varchar](100) NULL,
	[GiaDichVu] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/31/2023 2:53:38 PM ******/
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
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/31/2023 2:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[MaChucVu] [int] NOT NULL,
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
/****** Object:  Table [dbo].[PhieuDatPhong]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[PhieuDichVu]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[Phong]    Script Date: 5/31/2023 2:53:38 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoanDangNhap]    Script Date: 5/31/2023 2:53:38 PM ******/
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
GO
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (1, 1, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (1, 2, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (2, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (3, 3, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (3, 6, 1)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (4, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (5, 3, 2)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (6, 2, 3)
INSERT [dbo].[ChiTietDichVu] ([MaPhieu], [MaDichVu], [SoLuong]) VALUES (6, 3, 2)
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

INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu]) VALUES (1, N'Gymnastic', N'Phong tap gym', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu]) VALUES (2, N'Swimming', N'Ho boi', CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu]) VALUES (3, N'Yoga', N'Phong tap yoga', CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu]) VALUES (5, N'Sauna', N'Xong hoi', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [MoTa], [GiaDichVu]) VALUES (6, N'Massage', N'Mat-xa', CAST(300000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] ON 

INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (1, 1, CAST(N'2023-05-27' AS Date), CAST(1050000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (2, 2, CAST(N'2023-05-27' AS Date), CAST(1300000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (3, 3, CAST(N'2023-05-28' AS Date), CAST(2850000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (4, 4, CAST(N'2023-05-29' AS Date), CAST(1800000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (5, 5, CAST(N'2023-05-30' AS Date), CAST(1800000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDonThanhToan] ([MaHoaDon], [MaKhachHang], [NgayThanhToan], [TongTien]) VALUES (6, 6, CAST(N'2023-05-30' AS Date), CAST(3450000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (1, N'Ho Thi Thanh', N'Nu', N'110 Tan Binh', N'0871373828')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (2, N'Nguyen Minh Thang', N'Nam', N'120 Truong Tho', N'0982721782')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (3, N'Tran Ngoc Tuyet Nhu', N'Nu', N'12 Quan 1', N'0838373732')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (4, N'Cao Ba Phat', N'Nam', N'21 Quan Binh Thanh', N'0928282818')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (5, N'Luong Duy Khanh', N'Nam', N'101 Ben Nghe', N'0288282828')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (6, N'Tran Ngoc Le', N'Nu', N'32 Tan Binh', N'0938282717')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (7, N'Ngo Thanh Tam', N'Nam', N'01 Ben Nghe', N'0933839391')
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [GioiTinh], [DiaChi], [SoDienThoai]) VALUES (8, N'Vo Thi Thanh Thuy', N'Nu', N'201 Tran Xuan', N'0292282811')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong]) VALUES (1, N'Don 1G-1N', N'Phong don 1 giuong don, cho 1 nguoi', CAST(800000 AS Decimal(18, 0)), 9)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong]) VALUES (2, N'Doi 1G-2N', N'Phong doi 1 giuong doi, cho 2 nguoi', CAST(1000000 AS Decimal(18, 0)), 8)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong]) VALUES (3, N'Doi 2G-2N', N'Phong doi 2 giuong don, cho 2 nguoi', CAST(1200000 AS Decimal(18, 0)), 7)
INSERT [dbo].[LoaiPhong] ([MaLoaiPhong], [TenLoaiPhong], [MoTa], [GiaPhong], [SoLuong]) VALUES (4, N'Doi 2G-4N', N'Phong doi 2 giuong doi, cho 4 nguoi', CAST(1500000 AS Decimal(18, 0)), 6)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (1, 1, N'Nguyen Van A', N'Nam', N'01 Pham Ngu Lao', N'0921288372', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (2, 2, N'Tran Minh Thien', N'Nam', N'12 Pham Ngu Lao', N'0923283828', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (3, 3, N'Tran Ngoc Oanh', N'Nu', N'012 Ben Thanh', N'0929832818', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (4, 3, N'Pham Thi Thu Ngan', N'Nu', N'121 Ben Nghe', N'0727928288', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (5, 3, N'Do Van Anh', N'Nu', N'023 Nguyen Thai Binh', N'0282838281', 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (6, 3, N'Tran Quang Nam', N'Nam', N'121 Ben Thanh', N'0322828281', 0)
INSERT [dbo].[NhanVien] ([MaNhanVien], [MaChucVu], [TenNhanVien], [GioiTinh], [DiaChi], [SoDienThoai], [HoatDong]) VALUES (7, 3, N'Nguyen Nhat Minh', N'Nam', N'323 Nguyen Thai Binh', N'0892817281', 0)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDatPhong] ON 

INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (1, 1, CAST(N'2023-05-27' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(800000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (2, 2, CAST(N'2023-05-27' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (3, 3, CAST(N'2023-05-28' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(2400000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (4, 4, CAST(N'2023-05-29' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (5, 5, CAST(N'2023-05-26' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDatPhong] ([MaPhieu], [MaKhachHang], [NgayLapPhieu], [TienCoc], [TongTien]) VALUES (6, 6, CAST(N'2023-05-29' AS Date), CAST(400000 AS Decimal(18, 0)), CAST(3000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PhieuDatPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuDichVu] ON 

INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (1, 1, CAST(N'2023-05-27' AS Date), CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (2, 2, CAST(N'2023-05-27' AS Date), CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (3, 3, CAST(N'2023-05-28' AS Date), CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (4, 4, CAST(N'2023-05-29' AS Date), CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (5, 5, CAST(N'2023-05-30' AS Date), CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[PhieuDichVu] ([MaPhieu], [MaKhachHang], [NgaySuDung], [TongTien]) VALUES (6, 6, CAST(N'2023-05-30' AS Date), CAST(450000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PhieuDichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (1, 1, N'P101', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (2, 1, N'P102', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (3, 1, N'P103', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (4, 1, N'P104', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (5, 2, N'P201', N'Dang sua chua')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (6, 2, N'P202', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (7, 2, N'P203', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (8, 2, N'P204', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (9, 3, N'P301', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (10, 3, N'P302', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (11, 3, N'P303', N'Dang sua chua')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (12, 3, N'P304', N'Con phong')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (13, 4, N'P401', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (14, 4, N'P402', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (15, 4, N'P403', N'Dang su dung')
INSERT [dbo].[Phong] ([MaPhong], [MaLoaiPhong], [TenPhong], [TrangThai]) VALUES (16, 4, N'P404 ', N'Dang su dung')
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoanDangNhap] ON 

INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (1, 1, N'anguyen1.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (2, 2, N'thientran2.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (3, 3, N'oanhtran3.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (4, 4, N'nganpham4.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (5, 5, N'anhdo5.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (6, 6, N'namtran6.stown', N'123456')
INSERT [dbo].[TaiKhoanDangNhap] ([MaSo], [MaNhanVien], [TenDangNhap], [MatKhau]) VALUES (7, 7, N'minhnguyen7.stown', N'123456')
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
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [status_check] CHECK  (([TrangThai]='Dang sua chua' OR [TrangThai]='Dang su dung' OR [TrangThai]='Con phong'))
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [status_check]
GO
USE [master]
GO
ALTER DATABASE [QLKhachSan] SET  READ_WRITE 
GO
