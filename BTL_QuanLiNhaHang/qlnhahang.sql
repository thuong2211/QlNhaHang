--create database QLNhaHang
use QLNhaHang
create TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[PhanQuyen] int NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[NgaySinh] datetime null,
	[BoPhan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](500) null,
	[Anh] nvarchar(500) null
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [dbo].[NHANVIEN] (MaNV, TenNV, MatKhau, PhanQuyen, GioiTinh, SDT, NgaySinh, BoPhan, DiaChi, Anh)
VALUES
('NV0001', N'Nguyễn Văn A', 'matkhau1', 1, N'Nam', '0123456789', '1990-05-15', N'Quản lý', N'123 Đường ABC, Hà Nội', 'D:\LTTQuan\BTL_QuanLiNhaHang\dinosaur.png')

ALTER TABLE NHANVIEN
ALTER COLUMN MatKhau NVARCHAR(100);