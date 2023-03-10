USE [master]
GO
/****** Object:  Database [EnocaCaseStudyDB]    Script Date: 16 Şub 2023 15:42:34 ******/
CREATE DATABASE [EnocaCaseStudyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnocaCaseStudyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EnocaCaseStudyDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnocaCaseStudyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EnocaCaseStudyDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EnocaCaseStudyDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnocaCaseStudyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET RECOVERY FULL 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET  MULTI_USER 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EnocaCaseStudyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EnocaCaseStudyDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EnocaCaseStudyDB', N'ON'
GO
ALTER DATABASE [EnocaCaseStudyDB] SET QUERY_STORE = OFF
GO
USE [EnocaCaseStudyDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16 Şub 2023 15:42:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 16 Şub 2023 15:42:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[isConfirm] [bit] NOT NULL,
	[OrderAllowStartTime] [datetime2](7) NOT NULL,
	[OrderAllowFinishTime] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 16 Şub 2023 15:42:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](max) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[ProductId] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 16 Şub 2023 15:42:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[Stock] [decimal](18, 2) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230215220344_InitialCreate_V1', N'6.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230216094253_Mig_2', N'6.0.14')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230216094835_Mig_3', N'6.0.14')
GO
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (5, N'Enoca', 1, CAST(N'2023-02-16T14:25:10.2690000' AS DateTime2), CAST(N'2023-02-16T15:25:10.2690000' AS DateTime2), CAST(N'2023-02-16T14:25:28.9243561' AS DateTime2), NULL)
INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (6, N'Koc Holding', 1, CAST(N'2023-02-16T10:25:10.2690000' AS DateTime2), CAST(N'2023-02-16T12:25:10.2690000' AS DateTime2), CAST(N'2023-02-16T14:25:51.0377490' AS DateTime2), NULL)
INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (7, N'ABC Holding', 1, CAST(N'2023-02-16T12:25:10.2690000' AS DateTime2), CAST(N'2023-02-16T14:25:10.2690000' AS DateTime2), CAST(N'2023-02-16T14:26:16.0546502' AS DateTime2), NULL)
INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (8, N'Doğan Holding', 1, CAST(N'2023-02-16T11:00:00.7650000' AS DateTime2), CAST(N'2023-02-16T12:00:00.7650000' AS DateTime2), CAST(N'2023-02-16T15:00:21.5751766' AS DateTime2), NULL)
INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (9, N'KBT Insaat Ltd.', 1, CAST(N'2023-02-16T12:06:40.7530000' AS DateTime2), CAST(N'2023-02-16T16:06:40.7530000' AS DateTime2), CAST(N'2023-02-16T15:07:18.6378670' AS DateTime2), NULL)
INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (10, N'Akyazı Tasımacılık', 1, CAST(N'2023-02-16T12:10:07.2780000' AS DateTime2), CAST(N'2023-02-16T12:10:07.2780000' AS DateTime2), CAST(N'2023-02-16T15:10:34.3255205' AS DateTime2), NULL)
INSERT [dbo].[Companies] ([Id], [CompanyName], [isConfirm], [OrderAllowStartTime], [OrderAllowFinishTime], [CreatedDate], [UpdatedDate]) VALUES (11, N'Avz Ticaret', 1, CAST(N'2023-02-16T12:21:34.2760000' AS DateTime2), CAST(N'2023-02-16T12:21:34.2760000' AS DateTime2), CAST(N'2023-02-16T15:21:47.5948187' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Companies] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CustomerName], [OrderDate], [ProductId], [CreatedDate], [UpdatedDate], [CompanyId]) VALUES (1, N'Kaan Tokat', CAST(N'2023-02-16T14:43:46.0118677' AS DateTime2), 2, CAST(N'2023-02-16T14:43:46.0118199' AS DateTime2), NULL, 5)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductName], [Stock], [Price], [CompanyId], [CreatedDate], [UpdatedDate]) VALUES (2, N'Bilgisayar', CAST(1000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), 5, CAST(N'2023-02-16T14:26:59.2802985' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Stock], [Price], [CompanyId], [CreatedDate], [UpdatedDate]) VALUES (3, N'Televizyon', CAST(500.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 6, CAST(N'2023-02-16T14:27:19.6525833' AS DateTime2), NULL)
INSERT [dbo].[Products] ([Id], [ProductName], [Stock], [Price], [CompanyId], [CreatedDate], [UpdatedDate]) VALUES (4, N'Deterjan', CAST(5000.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), 7, CAST(N'2023-02-16T14:27:44.1268884' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
/****** Object:  Index [IX_Orders_ProductId]    Script Date: 16 Şub 2023 15:42:34 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_ProductId] ON [dbo].[Orders]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CompanyId]    Script Date: 16 Şub 2023 15:42:34 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CompanyId] ON [dbo].[Products]
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [CompanyId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Companies_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Companies_CompanyId]
GO
USE [master]
GO
ALTER DATABASE [EnocaCaseStudyDB] SET  READ_WRITE 
GO
