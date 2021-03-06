USE [master]
GO
/****** Object:  Database [HiTech]    Script Date: 4/17/2017 11:57:09 AM ******/
CREATE DATABASE [HiTech]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTech', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\HiTech.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HiTech_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER2014\MSSQL\DATA\HiTech_log.ldf' , SIZE = 4672KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HiTech] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTech].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTech] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTech] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTech] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTech] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTech] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTech] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTech] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTech] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTech] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTech] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTech] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTech] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTech] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTech] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTech] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTech] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTech] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTech] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTech] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTech] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTech] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTech] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTech] SET RECOVERY FULL 
GO
ALTER DATABASE [HiTech] SET  MULTI_USER 
GO
ALTER DATABASE [HiTech] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTech] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTech] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTech] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HiTech] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HiTech]
GO
/****** Object:  Table [dbo].[AuthorBooks]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorBooks](
	[BookId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
	[Author2] [nvarchar](50) NULL,
 CONSTRAINT [PK_AuthorBooks] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC,
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Authors]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(2000,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Books]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[BookId] [int] IDENTITY(6000,1) NOT NULL,
	[Isbn] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[YearPublished] [int] NOT NULL,
	[Qoh] [int] NULL,
	[CategoryId] [int] NOT NULL,
	[PublisherId] [int] NOT NULL,
	[AuthorId] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(4000,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [int] IDENTITY(1000,1) NOT NULL,
	[ClientName] [nvarchar](100) NOT NULL,
	[StreetNumber] [int] NOT NULL,
	[StreetName] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](50) NOT NULL,
	[Province] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[CreditLimit] [float] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1111111,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
	[UserType] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderLineBooks]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLineBooks](
	[OlBooksId] [int] IDENTITY(8000,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[OlQuantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderLineBooks] PRIMARY KEY CLUSTERED 
(
	[OlBooksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderLineSoftwares]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLineSoftwares](
	[OlSoftwareId] [int] IDENTITY(9000,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[SoftwareId] [int] NOT NULL,
	[OlQuantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderLineSoftwares] PRIMARY KEY CLUSTERED 
(
	[OlSoftwareId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(7000,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[MadeBy] [nvarchar](50) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[ShippingDate] [date] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherId] [int] IDENTITY(3000,1) NOT NULL,
	[PublisherName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Softwares]    Script Date: 4/17/2017 11:57:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Softwares](
	[SoftwareId] [int] IDENTITY(5000,1) NOT NULL,
	[SoftwareName] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[Qoh] [int] NULL,
 CONSTRAINT [PK_Softwares] PRIMARY KEY CLUSTERED 
(
	[SoftwareId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6000, 2000, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6000, 2001, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6003, 2000, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6003, 2001, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6004, 2002, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6004, 2003, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6005, 2004, NULL)
INSERT [dbo].[AuthorBooks] ([BookId], [AuthorId], [Author2]) VALUES (6007, 2000, N'blabla    ')
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2000, N'Paul', N'Deitel')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2001, N'Harvey ', N'Deitel')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2002, N'Ramez', N'Elmasri')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2003, N'Shamkant', N'Navathe')
INSERT [dbo].[Authors] ([AuthorId], [FirstName], [LastName]) VALUES (2004, N'Bruce', N'Hallberg')
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([BookId], [Isbn], [Title], [UnitPrice], [YearPublished], [Qoh], [CategoryId], [PublisherId], [AuthorId]) VALUES (6000, N'0133379337', N'Visual C# 2012 How to Program ', 157.38, 2013, 500, 4000, 3000, 2000)
INSERT [dbo].[Books] ([BookId], [Isbn], [Title], [UnitPrice], [YearPublished], [Qoh], [CategoryId], [PublisherId], [AuthorId]) VALUES (6003, N'0134448235', N'C++ How to Program', 153.12, 2016, 500, 4000, 3000, 2000)
INSERT [dbo].[Books] ([BookId], [Isbn], [Title], [UnitPrice], [YearPublished], [Qoh], [CategoryId], [PublisherId], [AuthorId]) VALUES (6004, N'0321122267', N'Fundamentals of Database Systems', 84.9, 2003, 500, 4000, 3001, 2002)
INSERT [dbo].[Books] ([BookId], [Isbn], [Title], [UnitPrice], [YearPublished], [Qoh], [CategoryId], [PublisherId], [AuthorId]) VALUES (6005, N'0071812245', N'Networking: A Beginner''s Guide', 47.45, 2013, 500, 4000, 3002, 2004)
INSERT [dbo].[Books] ([BookId], [Isbn], [Title], [UnitPrice], [YearPublished], [Qoh], [CategoryId], [PublisherId], [AuthorId]) VALUES (6006, N'1234', N'testbook333', 100, 2000, 10, 4000, 3000, 2004)
INSERT [dbo].[Books] ([BookId], [Isbn], [Title], [UnitPrice], [YearPublished], [Qoh], [CategoryId], [PublisherId], [AuthorId]) VALUES (6007, N'1234', N'testbook4444', 10.11, 2000, 10, 4000, 3000, 2004)
SET IDENTITY_INSERT [dbo].[Books] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4000, N'Book')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4001, N'System')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4002, N'Application')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientId], [ClientName], [StreetNumber], [StreetName], [City], [PostalCode], [Province], [Phone], [CreditLimit]) VALUES (1001, N'LaSalle College', 2000, N'Ste-Catherine Ouest', N'Montreal', N'H3H2T2', N'Quebec', N'5149392006', 1000)
INSERT [dbo].[Clients] ([ClientId], [ClientName], [StreetNumber], [StreetName], [City], [PostalCode], [Province], [Phone], [CreditLimit]) VALUES (1002, N'Dawson College', 3040, N'Sherbrooke St W', N'Montreal', N'H3Z1A4', N'Quebec', N'5149318731', 1000)
INSERT [dbo].[Clients] ([ClientId], [ClientName], [StreetNumber], [StreetName], [City], [PostalCode], [Province], [Phone], [CreditLimit]) VALUES (1003, N'Concordia University', 7141, N'Sherbrooke St W', N'Montreal', N'H4B1R6', N'Quebec', N'5148482424', 2000)
INSERT [dbo].[Clients] ([ClientId], [ClientName], [StreetNumber], [StreetName], [City], [PostalCode], [Province], [Phone], [CreditLimit]) VALUES (1004, N'McGill University', 2000, N'Sherbrooke St W', N'Montreal', N'H3A0G4', N'Quebec', N'(514) 398-4455', 2000)
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111111, N'Henry', N'Brown', N'MIS Manager', N'User', N'admin', N'henrybrown@hitech.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111112, N'Thomas', N'Moore', N'Sales Manager', N'User', N'admin', N'thomasmoore@hitech.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111113, N'Peter ', N'Wang', N'Inventory Controller', N'User', N'admin', N'peterwang@hitech.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111114, N'Mary ', N'Brown', N'Order Clerk', N'User', N'admin', N'marybrown@hitech.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111115, N'Jennifer', N'Bouchard', N'Order Clerk', N'User', N'admin', N'jenniferbouchard@hitech.com')
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111118, N'Angela', N'Fort', N'Cleaning Lady', N'Employee', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111119, N'Michael', N'Scott', N'Cafeteria Cashier', N'Employee', NULL, NULL)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [JobTitle], [UserType], [Password], [Email]) VALUES (1111127, N'Gabriel', N'Frenette', N'Cafeteria Cashier', N'Employee', N'', N'')
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[OrderLineBooks] ON 

INSERT [dbo].[OrderLineBooks] ([OlBooksId], [OrderId], [BookId], [OlQuantity]) VALUES (8001, 7000, 6000, 10)
INSERT [dbo].[OrderLineBooks] ([OlBooksId], [OrderId], [BookId], [OlQuantity]) VALUES (8002, 7002, 6003, 10)
INSERT [dbo].[OrderLineBooks] ([OlBooksId], [OrderId], [BookId], [OlQuantity]) VALUES (8003, 7002, 6004, 20)
INSERT [dbo].[OrderLineBooks] ([OlBooksId], [OrderId], [BookId], [OlQuantity]) VALUES (8005, 7008, 6007, 80)
INSERT [dbo].[OrderLineBooks] ([OlBooksId], [OrderId], [BookId], [OlQuantity]) VALUES (8006, 7008, 6003, 50)
SET IDENTITY_INSERT [dbo].[OrderLineBooks] OFF
SET IDENTITY_INSERT [dbo].[OrderLineSoftwares] ON 

INSERT [dbo].[OrderLineSoftwares] ([OlSoftwareId], [OrderId], [SoftwareId], [OlQuantity]) VALUES (9000, 7000, 5000, 10)
INSERT [dbo].[OrderLineSoftwares] ([OlSoftwareId], [OrderId], [SoftwareId], [OlQuantity]) VALUES (9002, 7000, 5001, 43)
SET IDENTITY_INSERT [dbo].[OrderLineSoftwares] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7000, 1111114, 1001, N'Phone', CAST(N'2017-03-03' AS Date), CAST(N'2017-03-04' AS Date))
INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7002, 1111114, 1002, N'Email', CAST(N'2017-03-03' AS Date), CAST(N'2017-03-04' AS Date))
INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7003, 1111114, 1001, N'Email', CAST(N'2000-01-22' AS Date), CAST(N'2000-01-23' AS Date))
INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7004, 1111114, 1001, N'Phone', CAST(N'2015-12-12' AS Date), CAST(N'2015-12-13' AS Date))
INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7005, 1111114, 1004, N'Phone', CAST(N'2016-12-13' AS Date), CAST(N'2016-12-14' AS Date))
INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7007, 1111114, 1004, N'Phone', CAST(N'2016-12-14' AS Date), CAST(N'2016-12-15' AS Date))
INSERT [dbo].[Orders] ([OrderId], [EmployeeId], [ClientId], [MadeBy], [OrderDate], [ShippingDate]) VALUES (7008, 1111115, 1004, N'Fax', CAST(N'2015-11-15' AS Date), CAST(N'2015-11-16' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Publishers] ON 

INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (3000, N'Pearson')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (3001, N'Addison Wesley')
INSERT [dbo].[Publishers] ([PublisherId], [PublisherName]) VALUES (3002, N'McGraw-Hill Education')
SET IDENTITY_INSERT [dbo].[Publishers] OFF
SET IDENTITY_INSERT [dbo].[Softwares] ON 

INSERT [dbo].[Softwares] ([SoftwareId], [SoftwareName], [Company], [CategoryId], [Price], [Qoh]) VALUES (5000, N'Windows 10 Home', N'Microsoft', 4001, 149, 500)
INSERT [dbo].[Softwares] ([SoftwareId], [SoftwareName], [Company], [CategoryId], [Price], [Qoh]) VALUES (5001, N'Visual Studio Enterprise 2015', N'Microsoft', 4002, 405.98, 500)
INSERT [dbo].[Softwares] ([SoftwareId], [SoftwareName], [Company], [CategoryId], [Price], [Qoh]) VALUES (5002, N'SQL Server Developer Edition 2014', N'Microsoft', 4002, 259.99, 500)
SET IDENTITY_INSERT [dbo].[Softwares] OFF
ALTER TABLE [dbo].[AuthorBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorBooks_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[AuthorBooks] CHECK CONSTRAINT [FK_AuthorBooks_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Authors] ([AuthorId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherId])
REFERENCES [dbo].[Publishers] ([PublisherId])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[OrderLineBooks]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineBooks_Books] FOREIGN KEY([BookId])
REFERENCES [dbo].[Books] ([BookId])
GO
ALTER TABLE [dbo].[OrderLineBooks] CHECK CONSTRAINT [FK_OrderLineBooks_Books]
GO
ALTER TABLE [dbo].[OrderLineBooks]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineBooks_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderLineBooks] CHECK CONSTRAINT [FK_OrderLineBooks_Orders]
GO
ALTER TABLE [dbo].[OrderLineSoftwares]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineSoftwares_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderLineSoftwares] CHECK CONSTRAINT [FK_OrderLineSoftwares_Orders]
GO
ALTER TABLE [dbo].[OrderLineSoftwares]  WITH CHECK ADD  CONSTRAINT [FK_OrderLineSoftwares_Softwares] FOREIGN KEY([SoftwareId])
REFERENCES [dbo].[Softwares] ([SoftwareId])
GO
ALTER TABLE [dbo].[OrderLineSoftwares] CHECK CONSTRAINT [FK_OrderLineSoftwares_Softwares]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clients] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clients]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Softwares]  WITH CHECK ADD  CONSTRAINT [FK_Softwares_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Softwares] CHECK CONSTRAINT [FK_Softwares_Categories]
GO
USE [master]
GO
ALTER DATABASE [HiTech] SET  READ_WRITE 
GO
