USE [QLDT]
GO
/****** Object:  Table [dbo].[tbDeTai]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDeTai](
	[MaDeTai] [nvarchar](50) NOT NULL,
	[TenDeTai] [nvarchar](50) NOT NULL,
	[Thoigian] [nvarchar](50) NOT NULL,
	[MaLoaiDeTai] [nvarchar](50) NOT NULL,
	[MaTacGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbDeTai] PRIMARY KEY CLUSTERED 
(
	[MaDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblBaiBaoKH]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaiBaoKH](
	[MaBaiBao] [nvarchar](50) NOT NULL,
	[TenBaiBao] [nvarchar](50) NOT NULL,
	[ThoiGian] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](50) NOT NULL,
	[MaLoaiBaiBao] [nvarchar](50) NOT NULL,
	[MaTacGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblBaiBaoKH] PRIMARY KEY CLUSTERED 
(
	[MaBaiBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[TenDangnhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[QuyenDangNhap] [int] NOT NULL,
 CONSTRAINT [PK_tblDangNhap] PRIMARY KEY CLUSTERED 
(
	[TenDangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMaLoaiBaiBao]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMaLoaiBaiBao](
	[MaLoaiBaiBao] [nvarchar](50) NOT NULL,
	[TenLoaiBaiBao] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblMaLoaiBaiBao] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBaiBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMaLoaiDeTai]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMaLoaiDeTai](
	[MaloaiDeTai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblMaLoaiDeTai] PRIMARY KEY CLUSTERED 
(
	[MaloaiDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbTacGia]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTacGia](
	[MaTacGia] [nvarchar](50) NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
	[DonVi] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbTacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_2]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_2]
AS
SELECT        dbo.tbDeTai.MaDeTai, dbo.tbDeTai.TenDeTai, dbo.tbDeTai.Thoigian, dbo.tbTacGia.TenTacGia, dbo.tbTacGia.DonVi, dbo.tbTacGia.DienThoai, dbo.tbTacGia.Email, dbo.tbTacGia.ChucVu, dbo.tblMaLoaiDeTai.TenLoai, 
                         dbo.tblMaLoaiDeTai.MoTa
FROM            dbo.tbDeTai INNER JOIN
                         dbo.tbTacGia ON dbo.tbDeTai.MaTacGia = dbo.tbTacGia.MaTacGia INNER JOIN
                         dbo.tblMaLoaiDeTai ON dbo.tbDeTai.MaLoaiDeTai = dbo.tblMaLoaiDeTai.MaloaiDeTai

GO
/****** Object:  View [dbo].[View_3]    Script Date: 20/12/2022 8:22:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_3]
AS
SELECT        dbo.tblBaiBaoKH.MaBaiBao, dbo.tblBaiBaoKH.TenBaiBao, dbo.tblBaiBaoKH.ThoiGian, dbo.tblBaiBaoKH.MoTa, dbo.tblMaLoaiBaiBao.TenLoaiBaiBao, dbo.tblMaLoaiBaiBao.MoTa AS Expr1, dbo.tbTacGia.TenTacGia, 
                         dbo.tbTacGia.DonVi, dbo.tbTacGia.DienThoai, dbo.tbTacGia.Email, dbo.tbTacGia.ChucVu
FROM            dbo.tblBaiBaoKH INNER JOIN
                         dbo.tblMaLoaiBaiBao ON dbo.tblBaiBaoKH.MaLoaiBaiBao = dbo.tblMaLoaiBaiBao.MaLoaiBaiBao INNER JOIN
                         dbo.tbTacGia ON dbo.tblBaiBaoKH.MaTacGia = dbo.tbTacGia.MaTacGia

GO
INSERT [dbo].[tbDeTai] ([MaDeTai], [TenDeTai], [Thoigian], [MaLoaiDeTai], [MaTacGia]) VALUES (N'MaDT1', N'Xử lý nước thải', N'19/12/2022', N'Ma01', N'TG1')
INSERT [dbo].[tbDeTai] ([MaDeTai], [TenDeTai], [Thoigian], [MaLoaiDeTai], [MaTacGia]) VALUES (N'MaDT2', N'Nghiên cứu khoa học môn địa chất', N'19/12/2022', N'Ma02', N'TG2')
INSERT [dbo].[tbDeTai] ([MaDeTai], [TenDeTai], [Thoigian], [MaLoaiDeTai], [MaTacGia]) VALUES (N'MaDT4', N'Lập trình hướng đối tượng', N'17/12/2022', N'Ma01', N'TG1')
INSERT [dbo].[tblBaiBaoKH] ([MaBaiBao], [TenBaiBao], [ThoiGian], [MoTa], [MaLoaiBaiBao], [MaTacGia]) VALUES (N'MaBB2', N'Bài viết xây dựng Wifi tốc độ cao', N'02/12/2022', N'Hội nghị khoa học thường niên', N'Ma1', N'TG2')
INSERT [dbo].[tblDangNhap] ([TenDangnhap], [MatKhau], [QuyenDangNhap]) VALUES (N'Administrator', N'123456', 1)
INSERT [dbo].[tblDangNhap] ([TenDangnhap], [MatKhau], [QuyenDangNhap]) VALUES (N'Hoang', N'1234567', 3)
INSERT [dbo].[tblDangNhap] ([TenDangnhap], [MatKhau], [QuyenDangNhap]) VALUES (N'Hoàng Văn Hùng', N'123456', 2)
INSERT [dbo].[tblDangNhap] ([TenDangnhap], [MatKhau], [QuyenDangNhap]) VALUES (N'Nguyễn Tiến An', N'123456', 3)
INSERT [dbo].[tblMaLoaiBaiBao] ([MaLoaiBaiBao], [TenLoaiBaiBao], [MoTa]) VALUES (N'Ma1', N'Hội nghị khoa học', N'Hội nghị khoa học tổ chức tại nhà trường')
INSERT [dbo].[tblMaLoaiBaiBao] ([MaLoaiBaiBao], [TenLoaiBaiBao], [MoTa]) VALUES (N'Ma2', N'Tạp chí trong nước', N'Tạp chí khoa học liên quan đến CNTT trong nước')
INSERT [dbo].[tblMaLoaiBaiBao] ([MaLoaiBaiBao], [TenLoaiBaiBao], [MoTa]) VALUES (N'Ma3', N'Tạp chí nước ngoài', N'Tạp chí khoa học nước ngoài')
INSERT [dbo].[tblMaLoaiDeTai] ([MaloaiDeTai], [TenLoai], [MoTa]) VALUES (N'Ma01', N'Đề tài nghiên cứu khoa học', N'Đề tài của sinh viên nghiên cứu khoa học')
INSERT [dbo].[tblMaLoaiDeTai] ([MaloaiDeTai], [TenLoai], [MoTa]) VALUES (N'Ma02', N'Đề tài tốt nghiệp', N'Đề tài của sinh viên cuối khóa')
INSERT [dbo].[tblMaLoaiDeTai] ([MaloaiDeTai], [TenLoai], [MoTa]) VALUES (N'Ma03', N'Đề tài khoa học', N'Đề tài của giáo viên bộ môn')
INSERT [dbo].[tbTacGia] ([MaTacGia], [TenTacGia], [DonVi], [DienThoai], [Email], [ChucVu]) VALUES (N'TG1', N'Đàm Ngọc Linh', N'Lớp CNTT1', N'098456214', N'sonbg@@', N'Học Viên')
INSERT [dbo].[tbTacGia] ([MaTacGia], [TenTacGia], [DonVi], [DienThoai], [Email], [ChucVu]) VALUES (N'TG2', N'Nhữ Thị Khánh Ly', N'Lớp CN1', N'031644644', N'KhanhLy@gmail.com', N'Sinh viên')
INSERT [dbo].[tbTacGia] ([MaTacGia], [TenTacGia], [DonVi], [DienThoai], [Email], [ChucVu]) VALUES (N'TG3', N'Dương Ngọc Sơn', N'Bộ môn Mạng máy tính', N'0311545487', N'sonbgt36@giam', N'Cán bộ')
INSERT [dbo].[tbTacGia] ([MaTacGia], [TenTacGia], [DonVi], [DienThoai], [Email], [ChucVu]) VALUES (N'TG4', N'Hiển', N'fgsfsf', N'011131311', N'fsfsf', N'Cán bộ')
ALTER TABLE [dbo].[tbDeTai]  WITH CHECK ADD  CONSTRAINT [FK_tbDeTai_tblMaLoaiDeTai] FOREIGN KEY([MaLoaiDeTai])
REFERENCES [dbo].[tblMaLoaiDeTai] ([MaloaiDeTai])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbDeTai] CHECK CONSTRAINT [FK_tbDeTai_tblMaLoaiDeTai]
GO
ALTER TABLE [dbo].[tbDeTai]  WITH CHECK ADD  CONSTRAINT [FK_tbDeTai_tbTacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[tbTacGia] ([MaTacGia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbDeTai] CHECK CONSTRAINT [FK_tbDeTai_tbTacGia]
GO
ALTER TABLE [dbo].[tblBaiBaoKH]  WITH CHECK ADD  CONSTRAINT [FK_tblBaiBaoKH_tblMaLoaiBaiBao] FOREIGN KEY([MaLoaiBaiBao])
REFERENCES [dbo].[tblMaLoaiBaiBao] ([MaLoaiBaiBao])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblBaiBaoKH] CHECK CONSTRAINT [FK_tblBaiBaoKH_tblMaLoaiBaiBao]
GO
ALTER TABLE [dbo].[tblBaiBaoKH]  WITH CHECK ADD  CONSTRAINT [FK_tblBaiBaoKH_tbTacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[tbTacGia] ([MaTacGia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblBaiBaoKH] CHECK CONSTRAINT [FK_tblBaiBaoKH_tbTacGia]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbDeTai"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "tbTacGia"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tblMaLoaiDeTai"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 119
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblBaiBaoKH"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tblMaLoaiBaiBao"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbTacGia"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_3'
GO
