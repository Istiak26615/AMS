CREATE DATABASE OurEduAMSDb
USE [OurEduAMSDb]
GO
/****** Object:  Table [dbo].[Bonus]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bonus](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StaffId] [bigint] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Bonus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COM_Genders]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COM_Genders](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_COM_Genders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Designations]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designations](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Designations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donation]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donation](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DonationFrom] [nvarchar](50) NULL,
	[Details] [nvarchar](50) NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Donation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Details] [nvarchar](50) NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExtraIncomes]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExtraIncomes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StaffId] [bigint] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_ExtraIncomes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fees]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fees](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClassId] [bigint] NOT NULL,
	[FeesTypeId] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[DueDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Fees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeesTypes]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeesTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Term] [int] NOT NULL,
 CONSTRAINT [PK_FeesTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTypes]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PaymentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayScales]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayScales](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DesignationId] [bigint] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_PayScales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StaffId] [bigint] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[Remarks] [nvarchar](50) NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryIncrements]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryIncrements](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StaffId] [bigint] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_SalaryIncrements] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scholarships]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scholarships](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StudentId] [bigint] NOT NULL,
	[Percentage] [int] NOT NULL,
 CONSTRAINT [PK_Scholarships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[Id] [bigint] NOT NULL,
	[DesignationId] [bigint] NOT NULL,
	[ClassId] [bigint] NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Cell] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentPayments]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentPayments](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[StudentId] [bigint] NOT NULL,
	[FeeId] [bigint] NOT NULL,
	[PaymentTypeId] [bigint] NOT NULL,
	[Fine] [decimal](18, 0) NULL,
	[Discount] [decimal](18, 0) NULL,
	[PaidAmount] [decimal](18, 0) NOT NULL,
	[Remarks] [nvarchar](50) NULL,
 CONSTRAINT [PK_StudentPayments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/30/2019 10:35:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [bigint] NOT NULL,
	[ClassId] [bigint] NOT NULL,
	[GenderId] [bigint] NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NULL,
	[AdmittedYear] [date] NULL,
	[PresentAddress] [nvarchar](200) NULL,
	[PermanentAddress] [nvarchar](200) NULL,
	[DOB] [date] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bonus] ON 

INSERT [dbo].[Bonus] ([Id], [StaffId], [Name], [Amount], [Date]) VALUES (1, 1001, N'Eid Bonus', CAST(15000 AS Decimal(18, 0)), CAST(N'2019-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Bonus] ([Id], [StaffId], [Name], [Amount], [Date]) VALUES (2, 1001, N'Eid Bonus', CAST(20000 AS Decimal(18, 0)), CAST(N'2019-11-28T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Bonus] OFF
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([Id], [Name]) VALUES (1, N'One')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (8, N'Two')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (9, N'Three')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (10, N'None')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (11, N'Four')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (12, N'Five')
SET IDENTITY_INSERT [dbo].[Classes] OFF
SET IDENTITY_INSERT [dbo].[COM_Genders] ON 

INSERT [dbo].[COM_Genders] ([Id], [Name]) VALUES (1, N'Male')
INSERT [dbo].[COM_Genders] ([Id], [Name]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[COM_Genders] OFF
SET IDENTITY_INSERT [dbo].[Designations] ON 

INSERT [dbo].[Designations] ([Id], [Name]) VALUES (1, N'Headmaster')
INSERT [dbo].[Designations] ([Id], [Name]) VALUES (2, N'Assistant Head Master')
INSERT [dbo].[Designations] ([Id], [Name]) VALUES (3, N'Assistant Teacher')
INSERT [dbo].[Designations] ([Id], [Name]) VALUES (4, N'Senior Teacher')
INSERT [dbo].[Designations] ([Id], [Name]) VALUES (5, N'Registrar')
INSERT [dbo].[Designations] ([Id], [Name]) VALUES (6, N'Accountant')
SET IDENTITY_INSERT [dbo].[Designations] OFF
SET IDENTITY_INSERT [dbo].[Donation] ON 

INSERT [dbo].[Donation] ([Id], [DonationFrom], [Details], [Amount], [Date]) VALUES (1, N'Retrival IT', N'Doantion', CAST(50000 AS Decimal(18, 0)), CAST(N'2019-11-26T00:23:00.000' AS DateTime))
INSERT [dbo].[Donation] ([Id], [DonationFrom], [Details], [Amount], [Date]) VALUES (2, N'OurEdu', N'Education', CAST(20000 AS Decimal(18, 0)), CAST(N'2019-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Donation] ([Id], [DonationFrom], [Details], [Amount], [Date]) VALUES (3, N'Government', N'Donation', CAST(20000 AS Decimal(18, 0)), CAST(N'2019-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Donation] ([Id], [DonationFrom], [Details], [Amount], [Date]) VALUES (4, N'IUBAT', NULL, CAST(10000 AS Decimal(18, 0)), CAST(N'2020-01-03T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Donation] OFF
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([Id], [Name], [Details], [Amount], [Date]) VALUES (1, N'Water Bill', N'January', CAST(2000 AS Decimal(18, 0)), CAST(N'2019-01-01' AS Date))
INSERT [dbo].[Expenses] ([Id], [Name], [Details], [Amount], [Date]) VALUES (2, N'Elecrticity Bill', N'January', CAST(5000 AS Decimal(18, 0)), CAST(N'2019-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
SET IDENTITY_INSERT [dbo].[ExtraIncomes] ON 

INSERT [dbo].[ExtraIncomes] ([Id], [StaffId], [Name], [Amount], [Date]) VALUES (1, 1001, N'Extra Class', CAST(500 AS Decimal(18, 0)), CAST(N'2019-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[ExtraIncomes] ([Id], [StaffId], [Name], [Amount], [Date]) VALUES (2, 1001, N'Check Script of Exam', CAST(1000 AS Decimal(18, 0)), CAST(N'2019-11-18T00:00:00.000' AS DateTime))
INSERT [dbo].[ExtraIncomes] ([Id], [StaffId], [Name], [Amount], [Date]) VALUES (3, 1001, N'Visit', CAST(2000 AS Decimal(18, 0)), CAST(N'2019-12-29T00:00:00.000' AS DateTime))
INSERT [dbo].[ExtraIncomes] ([Id], [StaffId], [Name], [Amount], [Date]) VALUES (4, 1001, N'Tution', CAST(1000 AS Decimal(18, 0)), CAST(N'2019-12-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExtraIncomes] OFF
SET IDENTITY_INSERT [dbo].[Fees] ON 

INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (1, 1, 2, N'Admission Fee 1', CAST(5000 AS Decimal(18, 0)), CAST(N'2019-01-31T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (9, 8, 1, N'January- Tuiton Fee 2', CAST(500 AS Decimal(18, 0)), CAST(N'2019-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (11, 1, 3, N'First Term Exam 1', CAST(1000 AS Decimal(18, 0)), CAST(N'2019-04-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (12, 8, 2, N'Book Fee 2', CAST(1000 AS Decimal(18, 0)), CAST(N'2019-02-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (13, 1, 3, N'Mid Term Fees 1', CAST(500 AS Decimal(18, 0)), CAST(N'2019-11-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (14, 1, 1, N'February- Tuiton Fee 1', CAST(500 AS Decimal(18, 0)), CAST(N'2019-03-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (15, 1, 3, N'Mid Term Exam Fee 1', CAST(1500 AS Decimal(18, 0)), CAST(N'2019-04-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (16, 1, 3, N'Final Term Exam Fee 1', CAST(1000 AS Decimal(18, 0)), CAST(N'2019-12-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Fees] ([Id], [ClassId], [FeesTypeId], [Name], [Amount], [DueDate]) VALUES (20, 8, 2, N'Admission Fee  2', CAST(8000 AS Decimal(18, 0)), CAST(N'2019-01-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Fees] OFF
SET IDENTITY_INSERT [dbo].[FeesTypes] ON 

INSERT [dbo].[FeesTypes] ([Id], [Name], [Term]) VALUES (1, N'Monthly', 12)
INSERT [dbo].[FeesTypes] ([Id], [Name], [Term]) VALUES (2, N'Yearly', 1)
INSERT [dbo].[FeesTypes] ([Id], [Name], [Term]) VALUES (3, N'Term Wise', 3)
SET IDENTITY_INSERT [dbo].[FeesTypes] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([UserId], [UserType], [Password], [FirstName], [LastName], [Email]) VALUES (1, N'Registrar', N'1', N'Sohel', N'Rana Khan', N'sohel@gmail.com')
INSERT [dbo].[Login] ([UserId], [UserType], [Password], [FirstName], [LastName], [Email]) VALUES (2, N'Accountant', N'1', N'Apon', N'Sarian', N'khan@gmail.com')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[PaymentTypes] ON 

INSERT [dbo].[PaymentTypes] ([Id], [Name]) VALUES (1, N'Cash')
INSERT [dbo].[PaymentTypes] ([Id], [Name]) VALUES (2, N'BCash')
INSERT [dbo].[PaymentTypes] ([Id], [Name]) VALUES (3, N'Bank Cheque')
INSERT [dbo].[PaymentTypes] ([Id], [Name]) VALUES (4, N'Rocket')
SET IDENTITY_INSERT [dbo].[PaymentTypes] OFF
SET IDENTITY_INSERT [dbo].[PayScales] ON 

INSERT [dbo].[PayScales] ([Id], [DesignationId], [Amount]) VALUES (1, 1, CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[PayScales] ([Id], [DesignationId], [Amount]) VALUES (2, 2, CAST(45000 AS Decimal(18, 0)))
INSERT [dbo].[PayScales] ([Id], [DesignationId], [Amount]) VALUES (3, 3, CAST(40000 AS Decimal(18, 0)))
INSERT [dbo].[PayScales] ([Id], [DesignationId], [Amount]) VALUES (4, 4, CAST(35000 AS Decimal(18, 0)))
INSERT [dbo].[PayScales] ([Id], [DesignationId], [Amount]) VALUES (5, 5, CAST(25000 AS Decimal(18, 0)))
INSERT [dbo].[PayScales] ([Id], [DesignationId], [Amount]) VALUES (6, 6, CAST(20000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[PayScales] OFF
SET IDENTITY_INSERT [dbo].[Salary] ON 

INSERT [dbo].[Salary] ([Id], [StaffId], [Date], [Amount], [Remarks]) VALUES (1, 1001, CAST(N'2019-11-10T00:00:00.000' AS DateTime), CAST(30000 AS Decimal(18, 0)), N'Paid')
INSERT [dbo].[Salary] ([Id], [StaffId], [Date], [Amount], [Remarks]) VALUES (2, 1001, CAST(N'2019-11-22T00:00:00.000' AS DateTime), CAST(35000 AS Decimal(18, 0)), N'Paid')
SET IDENTITY_INSERT [dbo].[Salary] OFF
SET IDENTITY_INSERT [dbo].[SalaryIncrements] ON 

INSERT [dbo].[SalaryIncrements] ([Id], [StaffId], [Date], [Amount]) VALUES (2, 1001, CAST(N'2019-11-13T00:00:00.000' AS DateTime), CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[SalaryIncrements] ([Id], [StaffId], [Date], [Amount]) VALUES (3, 1002, CAST(N'2019-11-11T00:00:00.000' AS DateTime), CAST(500 AS Decimal(18, 0)))
INSERT [dbo].[SalaryIncrements] ([Id], [StaffId], [Date], [Amount]) VALUES (5, 1001, CAST(N'2019-12-30T00:00:00.000' AS DateTime), CAST(1000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[SalaryIncrements] OFF
SET IDENTITY_INSERT [dbo].[Scholarships] ON 

INSERT [dbo].[Scholarships] ([Id], [StudentId], [Percentage]) VALUES (4, 1001, 50)
INSERT [dbo].[Scholarships] ([Id], [StudentId], [Percentage]) VALUES (7, 2001, 25)
INSERT [dbo].[Scholarships] ([Id], [StudentId], [Percentage]) VALUES (8, 3001, 50)
SET IDENTITY_INSERT [dbo].[Scholarships] OFF
INSERT [dbo].[Staffs] ([Id], [DesignationId], [ClassId], [Name], [Cell], [Email], [Address]) VALUES (1001, 1, 10, N'Mizanur Rahman Manik', N'015874856321', N'manik@gmail.com', N'Dhaka')
INSERT [dbo].[Staffs] ([Id], [DesignationId], [ClassId], [Name], [Cell], [Email], [Address]) VALUES (1002, 2, 10, N'Azizul Islam', N'01587484598', N'aziz@gmail.com', N'Dhaka')
INSERT [dbo].[Staffs] ([Id], [DesignationId], [ClassId], [Name], [Cell], [Email], [Address]) VALUES (1003, 3, 9, N'Rabbani Islam', N'017874856321', N'rabbani@gmail.com', N'Dhaka')
INSERT [dbo].[Staffs] ([Id], [DesignationId], [ClassId], [Name], [Cell], [Email], [Address]) VALUES (1004, 1, 1, N'Rabbani Islam', N'017874856321', N'khan@gmail.com', N'Dhaka')
INSERT [dbo].[Staffs] ([Id], [DesignationId], [ClassId], [Name], [Cell], [Email], [Address]) VALUES (1005, 5, 10, N'Abul Hossain', N'01587458965', N'abul@gmail.com', N'Dhaka')
SET IDENTITY_INSERT [dbo].[StudentPayments] ON 

INSERT [dbo].[StudentPayments] ([Id], [PaymentDate], [StudentId], [FeeId], [PaymentTypeId], [Fine], [Discount], [PaidAmount], [Remarks]) VALUES (7, CAST(N'2019-11-01T00:00:00.000' AS DateTime), 1001, 1, 1, CAST(500 AS Decimal(18, 0)), CAST(100 AS Decimal(18, 0)), CAST(250 AS Decimal(18, 0)), NULL)
INSERT [dbo].[StudentPayments] ([Id], [PaymentDate], [StudentId], [FeeId], [PaymentTypeId], [Fine], [Discount], [PaidAmount], [Remarks]) VALUES (10, CAST(N'2019-12-10T00:00:00.000' AS DateTime), 1001, 14, 1, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(500 AS Decimal(18, 0)), NULL)
INSERT [dbo].[StudentPayments] ([Id], [PaymentDate], [StudentId], [FeeId], [PaymentTypeId], [Fine], [Discount], [PaidAmount], [Remarks]) VALUES (11, CAST(N'2019-12-10T00:00:00.000' AS DateTime), 1001, 15, 1, NULL, NULL, CAST(500 AS Decimal(18, 0)), NULL)
INSERT [dbo].[StudentPayments] ([Id], [PaymentDate], [StudentId], [FeeId], [PaymentTypeId], [Fine], [Discount], [PaidAmount], [Remarks]) VALUES (12, CAST(N'2019-01-01T00:00:00.000' AS DateTime), 2001, 20, 1, NULL, NULL, CAST(8000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[StudentPayments] ([Id], [PaymentDate], [StudentId], [FeeId], [PaymentTypeId], [Fine], [Discount], [PaidAmount], [Remarks]) VALUES (13, CAST(N'2019-12-30T00:00:00.000' AS DateTime), 1001, 11, 1, NULL, NULL, CAST(1000 AS Decimal(18, 0)), NULL)
SET IDENTITY_INSERT [dbo].[StudentPayments] OFF
INSERT [dbo].[Students] ([Id], [ClassId], [GenderId], [FirstName], [LastName], [AdmittedYear], [PresentAddress], [PermanentAddress], [DOB]) VALUES (1001, 1, 1, N'Rabbi', N'Ahmed', CAST(N'2019-01-01' AS Date), N'Dhaka', N'Dhaka', CAST(N'2015-01-01' AS Date))
INSERT [dbo].[Students] ([Id], [ClassId], [GenderId], [FirstName], [LastName], [AdmittedYear], [PresentAddress], [PermanentAddress], [DOB]) VALUES (2001, 8, 1, N'Asif', N'Rahman', CAST(N'2019-01-01' AS Date), N'Dhaka', N'Dhaka', CAST(N'2014-01-01' AS Date))
INSERT [dbo].[Students] ([Id], [ClassId], [GenderId], [FirstName], [LastName], [AdmittedYear], [PresentAddress], [PermanentAddress], [DOB]) VALUES (3001, 9, 1, N'Muhaimin', N'Atik', CAST(N'2019-01-01' AS Date), N'Uttara, Dhaka', N'Dhaka', CAST(N'2010-02-09' AS Date))
INSERT [dbo].[Students] ([Id], [ClassId], [GenderId], [FirstName], [LastName], [AdmittedYear], [PresentAddress], [PermanentAddress], [DOB]) VALUES (4001, 11, 1, N'Rakibul', N'Islam', CAST(N'2019-01-01' AS Date), N'Tongi, Gazipur', N'Gazipur', CAST(N'2009-02-10' AS Date))
INSERT [dbo].[Students] ([Id], [ClassId], [GenderId], [FirstName], [LastName], [AdmittedYear], [PresentAddress], [PermanentAddress], [DOB]) VALUES (5001, 12, 1, N'Sajal', N'Babu', CAST(N'2019-01-01' AS Date), N'Khilkhet, Dhaka', N'Khilkhet, Dhaka', CAST(N'2009-01-01' AS Date))
ALTER TABLE [dbo].[Bonus]  WITH CHECK ADD  CONSTRAINT [FK_Bonus_Staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([Id])
GO
ALTER TABLE [dbo].[Bonus] CHECK CONSTRAINT [FK_Bonus_Staff]
GO
ALTER TABLE [dbo].[ExtraIncomes]  WITH CHECK ADD  CONSTRAINT [FK_ExtraIncomes_Staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([Id])
GO
ALTER TABLE [dbo].[ExtraIncomes] CHECK CONSTRAINT [FK_ExtraIncomes_Staff]
GO
ALTER TABLE [dbo].[Fees]  WITH CHECK ADD  CONSTRAINT [FK_Fees_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
GO
ALTER TABLE [dbo].[Fees] CHECK CONSTRAINT [FK_Fees_Class]
GO
ALTER TABLE [dbo].[Fees]  WITH CHECK ADD  CONSTRAINT [FK_Fees_FeesTypeId] FOREIGN KEY([FeesTypeId])
REFERENCES [dbo].[FeesTypes] ([Id])
GO
ALTER TABLE [dbo].[Fees] CHECK CONSTRAINT [FK_Fees_FeesTypeId]
GO
ALTER TABLE [dbo].[PayScales]  WITH CHECK ADD  CONSTRAINT [FK_PayScales_DesignationFK] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designations] ([Id])
GO
ALTER TABLE [dbo].[PayScales] CHECK CONSTRAINT [FK_PayScales_DesignationFK]
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD  CONSTRAINT [FK_Salary_StaffFK] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([Id])
GO
ALTER TABLE [dbo].[Salary] CHECK CONSTRAINT [FK_Salary_StaffFK]
GO
ALTER TABLE [dbo].[SalaryIncrements]  WITH CHECK ADD  CONSTRAINT [FK_SalaryIncrements_Staffs] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staffs] ([Id])
GO
ALTER TABLE [dbo].[SalaryIncrements] CHECK CONSTRAINT [FK_SalaryIncrements_Staffs]
GO
ALTER TABLE [dbo].[Scholarships]  WITH CHECK ADD  CONSTRAINT [FK_Scholarships_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[Scholarships] CHECK CONSTRAINT [FK_Scholarships_Students]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [FK_Staffs_ClassId] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [FK_Staffs_ClassId]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [FK_Staffs_Designation] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designations] ([Id])
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [FK_Staffs_Designation]
GO
ALTER TABLE [dbo].[StudentPayments]  WITH CHECK ADD  CONSTRAINT [FK_StudentPayments_FeeId] FOREIGN KEY([FeeId])
REFERENCES [dbo].[Fees] ([Id])
GO
ALTER TABLE [dbo].[StudentPayments] CHECK CONSTRAINT [FK_StudentPayments_FeeId]
GO
ALTER TABLE [dbo].[StudentPayments]  WITH CHECK ADD  CONSTRAINT [FK_StudentPayments_PaymentType] FOREIGN KEY([PaymentTypeId])
REFERENCES [dbo].[PaymentTypes] ([Id])
GO
ALTER TABLE [dbo].[StudentPayments] CHECK CONSTRAINT [FK_StudentPayments_PaymentType]
GO
ALTER TABLE [dbo].[StudentPayments]  WITH CHECK ADD  CONSTRAINT [FK_StudentPayments_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[StudentPayments] CHECK CONSTRAINT [FK_StudentPayments_Student]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_classForegn] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_classForegn]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Gender] FOREIGN KEY([GenderId])
REFERENCES [dbo].[COM_Genders] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Gender]
GO
