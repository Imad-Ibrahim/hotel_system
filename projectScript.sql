USE [master]
GO
/****** Object:  Database [Bloomfield_Hotel]    Script Date: 14/02/2022 14:39:16 ******/
CREATE DATABASE [Bloomfield_Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bloomfield_Hotel', FILENAME = N'C:\SQL\MSSQL14.TEAM1\MSSQL\DATA\Bloomfield_Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bloomfield_Hotel_log', FILENAME = N'C:\SQL\MSSQL14.TEAM1\MSSQL\DATA\Bloomfield_Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Bloomfield_Hotel] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bloomfield_Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bloomfield_Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bloomfield_Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bloomfield_Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bloomfield_Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bloomfield_Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [Bloomfield_Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Bloomfield_Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bloomfield_Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bloomfield_Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bloomfield_Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bloomfield_Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bloomfield_Hotel', N'ON'
GO
ALTER DATABASE [Bloomfield_Hotel] SET QUERY_STORE = OFF
GO
USE [Bloomfield_Hotel]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] NOT NULL,
	[Check-in] [date] NULL,
	[Check-out] [date] NULL,
	[GuestNames] [varchar](300) NULL,
	[AdditionalNotes] [varchar](300) NULL,
	[NumSingleRooms] [int] NULL,
	[NumDoubleRooms] [int] NULL,
	[NumTwinRooms] [int] NULL,
	[RoomList] [varchar](100) NULL,
	[CheckedIn] [bit] NULL,
	[CheckedOut] [bit] NULL,
	[Total] [float] NULL,
	[GuestID] [int] NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CancelledBookings]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CancelledBookings](
	[CancelledBookingID] [int] NOT NULL,
	[BookingID] [int] NULL,
	[GuestName] [varchar](50) NULL,
	[NumSingleRooms] [int] NULL,
	[NumDoubleRooms] [int] NULL,
	[NumTwinRooms] [int] NULL,
	[Total] [float] NULL,
	[TotalRefund] [float] NULL,
 CONSTRAINT [PK_CancelledBookings] PRIMARY KEY CLUSTERED 
(
	[CancelledBookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cleaningassignments]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cleaningassignments](
	[AssignedOn] [date] NOT NULL,
	[Room] [int] NOT NULL,
	[Cleaners] [varchar](10) NULL,
	[AssignedBy] [int] NULL,
	[Complete] [bit] NULL,
	[Damaged] [bit] NULL,
	[Report] [varchar](300) NULL,
 CONSTRAINT [PK_cleaningassignments] PRIMARY KEY CLUSTERED 
(
	[AssignedOn] ASC,
	[Room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CleaningSupplies]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CleaningSupplies](
	[ItemID] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Supplier] [varchar](50) NULL,
	[UnitCost] [float] NULL,
 CONSTRAINT [PK_CleaningSupplies] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCard]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCard](
	[holderName] [varchar](24) NULL,
	[expirDate] [date] NULL,
	[cardNumber] [varchar](16) NOT NULL,
	[securityCode] [varchar](3) NULL,
	[SaveCardDetails] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[cardNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customersales]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customersales](
	[SaleID] [int] NOT NULL,
	[Guest] [varchar](60) NULL,
	[TableNumber] [int] NULL,
	[Total] [float] NULL,
	[Date] [date] NULL,
	[Cashier] [int] NULL,
 CONSTRAINT [PK_customersales] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] NOT NULL,
	[Username] [varchar](48) NULL,
	[Password] [varchar](64) NULL,
	[FirstName] [varchar](24) NULL,
	[LastName] [varchar](24) NULL,
	[Email] [varchar](64) NULL,
	[PhoneNumber] [varchar](14) NULL,
	[DateOfBirth] [date] NULL,
	[UserType] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[guestID] [int] NOT NULL,
	[name] [varchar](24) NULL,
	[address] [varchar](300) NULL,
	[phone] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[marketingConsent] [bit] NULL,
	[saveCustomerDetails] [bit] NULL,
	[creditcard] [varchar](16) NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[guestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ItemID] [int] NOT NULL,
	[Name] [varchar](32) NULL,
	[Description] [varchar](512) NULL,
	[Price] [float] NULL,
	[PortionSize] [varchar](64) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderitems]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderitems](
	[LineID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[ItemID] [int] NULL,
	[Quantity] [int] NULL,
	[LineCost] [float] NULL,
 CONSTRAINT [PK_orderitems] PRIMARY KEY CLUSTERED 
(
	[LineID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[OrderID] [int] NOT NULL,
	[Date] [date] NULL,
	[OrderType] [varchar](20) NULL,
	[Supplier] [varchar](50) NULL,
	[AcceptPartial] [bit] NULL,
	[Received] [bit] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[recipes]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[recipes](
	[RecipeID] [int] NOT NULL,
	[Name] [varchar](40) NULL,
	[Ingredients] [varchar](300) NULL,
	[Instructions] [varchar](400) NULL,
	[TimeToPrepare] [int] NULL,
	[Allergens] [varchar](200) NULL,
 CONSTRAINT [PK_recipes] PRIMARY KEY CLUSTERED 
(
	[RecipeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[roomID] [int] NULL,
	[roomType] [nchar](15) NULL,
	[roomAvailability] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[RoomNumber] [int] NOT NULL,
	[Floor] [int] NULL,
	[RoomType] [varchar](10) NULL,
	[Available] [bit] NULL,
	[Clean] [bit] NULL,
	[Assigned] [bit] NULL,
 CONSTRAINT [PK_rooms] PRIMARY KEY CLUSTERED 
(
	[RoomNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saleitems]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saleitems](
	[ItemID] [int] NOT NULL,
	[Description] [varchar](50) NULL,
	[Price] [float] NULL,
	[Unit] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[RecipeID] [int] NULL,
 CONSTRAINT [PK_saleitems] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salelineitems]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salelineitems](
	[SaleID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[Cooked] [bit] NULL,
	[Quantity] [int] NULL,
	[LineCost] [float] NULL,
 CONSTRAINT [PK_salelineitems] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stockitems]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stockitems](
	[ItemID] [int] NOT NULL,
	[Description] [varchar](60) NULL,
	[Unit] [varchar](50) NULL,
	[Quantity] [float] NULL,
	[Supplier] [varchar](50) NULL,
	[UnitCost] [float] NULL,
	[DrinkType] [varchar](50) NULL,
	[ItemType] [varchar](50) NULL,
	[ShelfLifeInDays] [int] NULL,
	[CurrentUseByDate] [date] NULL,
	[UnitValue/Servings] [int] NULL,
 CONSTRAINT [PK_stockitems] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 14/02/2022 14:39:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[UserID] [int] NOT NULL,
	[Username] [varchar](48) NULL,
	[Password] [varchar](64) NULL,
	[FirstName] [varchar](24) NULL,
	[LastName] [varchar](24) NULL,
	[Email] [varchar](64) NULL,
	[PhoneNumber] [varchar](14) NULL,
	[DateOfBirth] [date] NULL,
	[UserType] [varchar](15) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Booking] ([BookingID], [Check-in], [Check-out], [GuestNames], [AdditionalNotes], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [RoomList], [CheckedIn], [CheckedOut], [Total], [GuestID]) VALUES (1, CAST(N'2022-02-11' AS Date), CAST(N'2022-02-20' AS Date), N'', N'', 3, 1, 0, N'1', 1, 0, 262, 1)
INSERT [dbo].[Booking] ([BookingID], [Check-in], [Check-out], [GuestNames], [AdditionalNotes], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [RoomList], [CheckedIn], [CheckedOut], [Total], [GuestID]) VALUES (2, CAST(N'2022-02-11' AS Date), CAST(N'2022-02-17' AS Date), N'', N'', 1, 2, 3, N'3 4 5 6 7 8', 1, 0, 429, 2)
INSERT [dbo].[Booking] ([BookingID], [Check-in], [Check-out], [GuestNames], [AdditionalNotes], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [RoomList], [CheckedIn], [CheckedOut], [Total], [GuestID]) VALUES (3, CAST(N'2022-02-11' AS Date), CAST(N'2022-02-24' AS Date), N'', N'', 0, 2, 0, NULL, 0, 0, 158, 3)
INSERT [dbo].[Booking] ([BookingID], [Check-in], [Check-out], [GuestNames], [AdditionalNotes], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [RoomList], [CheckedIn], [CheckedOut], [Total], [GuestID]) VALUES (4, CAST(N'2022-02-11' AS Date), CAST(N'2022-02-22' AS Date), N'', N'', 0, 1, 1, NULL, 0, 0, 149, 4)
INSERT [dbo].[Booking] ([BookingID], [Check-in], [Check-out], [GuestNames], [AdditionalNotes], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [RoomList], [CheckedIn], [CheckedOut], [Total], [GuestID]) VALUES (5, CAST(N'2022-03-01' AS Date), CAST(N'2022-03-05' AS Date), N'', N'', 3, 0, 0, NULL, 0, 0, 183, 2)
INSERT [dbo].[Booking] ([BookingID], [Check-in], [Check-out], [GuestNames], [AdditionalNotes], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [RoomList], [CheckedIn], [CheckedOut], [Total], [GuestID]) VALUES (6, CAST(N'2022-02-11' AS Date), CAST(N'2022-02-13' AS Date), N'', N'', 1, 2, 1, NULL, 0, 0, 289, 2)
GO
INSERT [dbo].[CancelledBookings] ([CancelledBookingID], [BookingID], [GuestName], [NumSingleRooms], [NumDoubleRooms], [NumTwinRooms], [Total], [TotalRefund]) VALUES (1, 2, N'Imad Ibrahim', 1, 2, 2, 359, 0)
GO
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2021-12-15' AS Date), 7, N'11,8', 3, 1, 1, N'Sample, Sample, Sample, Sample, Sample, Sample')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2021-12-15' AS Date), 8, N'11,8', 3, 1, 0, N'')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 3, N'9,11', 3, 1, 0, N'')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 4, N'10,14', 3, 1, 1, N'Test Test Test')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 6, N'10,9', 3, 1, 1, N'Test, Test')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 8, N'10,8', 3, 1, 1, N'Sample Test Sample')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 10, N'11,10', 3, 1, 0, N'')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 14, N'8,10', 3, 1, 1, N'Sample Test')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-10' AS Date), 15, N'10,8', 3, 1, 1, N'Test Test Test')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-11' AS Date), 9, N'10,11', 3, 0, 0, N'')
INSERT [dbo].[cleaningassignments] ([AssignedOn], [Room], [Cleaners], [AssignedBy], [Complete], [Damaged], [Report]) VALUES (CAST(N'2022-02-11' AS Date), 10, N'10,8', 3, 1, 1, N'lamp broken , bath broken')
GO
INSERT [dbo].[CleaningSupplies] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost]) VALUES (13, N'Bleach', N'2L Bottle', 10, N'4.99', 0)
GO
INSERT [dbo].[CreditCard] ([holderName], [expirDate], [cardNumber], [securityCode], [SaveCardDetails]) VALUES (N'Imad Ibrahim', CAST(N'2022-08-19' AS Date), N'1230123012301230', N'031', 1)
INSERT [dbo].[CreditCard] ([holderName], [expirDate], [cardNumber], [securityCode], [SaveCardDetails]) VALUES (N'John Flynn', CAST(N'2022-10-28' AS Date), N'1254125412541257', N'154', 1)
INSERT [dbo].[CreditCard] ([holderName], [expirDate], [cardNumber], [securityCode], [SaveCardDetails]) VALUES (N'Mike Murphy ', CAST(N'2022-08-26' AS Date), N'1297129712971297', N'128', 1)
INSERT [dbo].[CreditCard] ([holderName], [expirDate], [cardNumber], [securityCode], [SaveCardDetails]) VALUES (N'David Ahern', CAST(N'2022-03-18' AS Date), N'7878656512340989', N'678', 1)
GO
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (0, N'Brian Dunne', 4, 89.5, CAST(N'2021-12-06' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (1, N'Imad Ibrahim', 5, 21, CAST(N'2021-12-03' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (2, N'James Kenny', 7, 47.5, CAST(N'2021-12-06' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (3, N'Barry Allen', 1, 54, CAST(N'2021-12-06' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (4, N'Brian Green', 4, 118, CAST(N'2021-12-06' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (5, N'James Daly', 5, 92.5, CAST(N'2021-12-09' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (6, N'Eoin Daly', 9, 116.5, CAST(N'2021-12-09' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (7, N'Eoin McLoughlin', 2, 45.5, CAST(N'2021-12-10' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (8, N'Grace Kelly', 4, 22.5, CAST(N'2021-12-15' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (9, N'Brian Green', 3, 34, CAST(N'2021-12-16' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (10, N'David Ahern', 5, 25, CAST(N'2022-01-21' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (11, N'David Ahern', 5, 36, CAST(N'2022-01-21' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (12, N'David Ahern', 5, 27.5, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (13, N'Imad Ibrahim', 2, 24, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (14, N'Brian Down', 6, 13, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (15, N'Brian Ahern', 4, 35, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (16, N'Craig Ryan', 4, 13, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (17, N'Brian Green', 6, 29.5, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (18, N'Kate Ryan', 4, 33, CAST(N'2022-02-11' AS Date), 6)
INSERT [dbo].[customersales] ([SaleID], [Guest], [TableNumber], [Total], [Date], [Cashier]) VALUES (19, N'Brian Drake', 7, 19, CAST(N'2022-02-11' AS Date), 6)
GO
INSERT [dbo].[Employees] ([ID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (1, N'l.hayes', N'1234', N'lisa', N'hayes', N'lisa.hayes@gmail.com', N'0859892233', CAST(N'1986-01-13' AS Date), N'Admin')
INSERT [dbo].[Employees] ([ID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (2, N'l.naggia', N'1234', N'lawrence', N'naggia', N'lawrence.naggia@gmail.com', N'0864545765', CAST(N'1988-10-03' AS Date), N'Manager')
GO
INSERT [dbo].[Guest] ([guestID], [name], [address], [phone], [email], [marketingConsent], [saveCustomerDetails], [creditcard]) VALUES (1, N'David Ahern', N'23 anoav;oai,
Limerick', N'0838339889', N'david.ahern@gmail.com', 1, 1, N'7878656512340989')
INSERT [dbo].[Guest] ([guestID], [name], [address], [phone], [email], [marketingConsent], [saveCustomerDetails], [creditcard]) VALUES (2, N'Imad Ibrahim', N'15 Cork City', N'0871234567', N'imad@gmail.com', 1, 1, N'1230123012301230')
INSERT [dbo].[Guest] ([guestID], [name], [address], [phone], [email], [marketingConsent], [saveCustomerDetails], [creditcard]) VALUES (3, N'John Flynn', N'125 Shannon Twon', N'0871264539', N'john@gmail.com', 1, 1, N'1254125412541257')
INSERT [dbo].[Guest] ([guestID], [name], [address], [phone], [email], [marketingConsent], [saveCustomerDetails], [creditcard]) VALUES (4, N'Mike Murphy', N'12 Limerick City 
Co. Limerick', N'0831542698', N'mike@gmail.com', 1, 1, N'1297129712971297')
GO
INSERT [dbo].[Menu] ([ItemID], [Name], [Description], [Price], [PortionSize], [Date]) VALUES (1, N'Lasagne', N'Lasagna is a wide, flat sheet of pasta. Lasagna can refer to either the type of noodle or to the typical lasagna dish which is a dish made with several layers of lasagna sheets with sauce and other ingredients, such as meats and cheese, in between the lasagna noodles.', 17.99, N'420 g', CAST(N'2022-02-14' AS Date))
INSERT [dbo].[Menu] ([ItemID], [Name], [Description], [Price], [PortionSize], [Date]) VALUES (2, N'spaghetti bolognese', N'Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.', 11.99, N'390 g', CAST(N'2022-02-14' AS Date))
INSERT [dbo].[Menu] ([ItemID], [Name], [Description], [Price], [PortionSize], [Date]) VALUES (3, N'Pizza', N'A flat, open-faced baked pie of Italian origin, consisting of a thin layer of bread dough topped with spiced tomato sauce and cheese, often garnished with anchovies, sausage slices, mushrooms, etc.', 19.99, N'24 inch', CAST(N'2022-02-14' AS Date))
GO
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 999, 1, 6, 93)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 12334, 1, 5, 77.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 54321, 2, 31, 651)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 234432, 2, 3, 63)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 987659, 1, 6, 93)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 3153543, 1, 5, 77.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435135, 3, 5, 62.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435136, 3, 8, 100)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435137, 1, 50, 775)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435138, 2, 4, 84)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435139, 2, 4, 84)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435140, 1, 10, 155)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435141, 1, 50, 775)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435142, 1, 50, 775)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435143, 1, 50, 775)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435144, 1, 10, 155)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435145, 5, 4, 128)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435146, 10, 10, 1200)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435147, 10, 10, 1200)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435148, 2, 4, 84)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435149, 6, 6, 177)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435150, 2, 5, 105)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435151, 4, 5, 43.75)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (1, 135435152, 7, 8, 150.4)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 999, 3, 3, 37.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 12334, 2, 7, 147)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 54321, 3, 12, 150)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 234432, 3, 5, 62.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 987659, 2, 5, 105)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 3153543, 4, 3, 26.25)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435135, 2, 9, 189)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435136, 2, 4, 84)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435138, 1, 5, 77.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435139, 3, 2, 25)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435145, 9, 4, 100)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435147, 6, 15, 442.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435148, 4, 5, 43.75)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435149, 10, 5, 600)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435150, 3, 10, 125)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435151, 2, 7, 147)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (2, 135435152, 12, 5, 50)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 999, 1, 99, 1534.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 12334, 3, 8, 100)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 987659, 4, 44, 385)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 3153543, 3, 7, 87.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 135435136, 1, 5, 77.5)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 135435138, 4, 7, 61.25)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 135435139, 2, 3, 63)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (3, 135435145, 6, 2, 59)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (4, 999, 2, 2, 42)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (4, 12334, 4, 99, 866.25)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (4, 987659, 4, 4, 35)
INSERT [dbo].[orderitems] ([LineID], [OrderID], [ItemID], [Quantity], [LineCost]) VALUES (5, 987659, 3, 9, 112.5)
GO
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (999, CAST(N'2021-11-30' AS Date), N'Food', N'Musgraves', 0, 0, 1707)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (12334, CAST(N'2021-11-30' AS Date), N'Food', N'Musgraves', 0, 0, 1190.75)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (12434, CAST(N'2021-11-26' AS Date), N'Food', N'Musgraves', 0, 0, 518.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (54321, CAST(N'2021-11-26' AS Date), N'Food', N'Musgraves', 0, 0, 801)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (143422, CAST(N'2021-11-26' AS Date), N'Food', N'Musgraves', 0, 0, 333)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (234432, CAST(N'2021-11-29' AS Date), N'Food', N'Musgraves', 0, 0, 125.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (987659, CAST(N'2021-11-30' AS Date), N'Food', N'Musgraves', 0, 0, 730.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (1345345, CAST(N'2021-11-26' AS Date), N'Food', N'Musgraves', 0, 0, 653.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (3153543, CAST(N'2021-11-29' AS Date), N'Food', N'Musgraves', 0, 0, 191.25)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435135, CAST(N'2021-11-29' AS Date), N'Food', N'Musgraves', 0, 0, 251.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435136, CAST(N'2021-11-30' AS Date), N'Food', N'Musgraves', 1, 0, 261.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435137, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 1, 1, 775)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435138, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 1, 222.75)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435139, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 0, 172)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435140, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 1, 155)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435141, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 1, 775)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435142, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 1, 775)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435143, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 1, 775)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435144, CAST(N'2021-12-13' AS Date), N'Food', N'Musgraves', 0, 1, 155)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435145, CAST(N'2022-02-10' AS Date), N'Food', N'Cash and Carry', 0, 1, 287)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435146, CAST(N'2022-02-10' AS Date), N'Food', N'Cash and Carry', 1, 0, 1200)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435147, CAST(N'2022-02-11' AS Date), N'Food', N'Cash and Carry', 1, 1, 1042.5)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435148, CAST(N'2022-02-10' AS Date), N'Food', N'Musgraves', 1, 1, 127.75)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435149, CAST(N'2022-02-10' AS Date), N'Food', N'Cash and Carry', 1, 1, 777)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435150, CAST(N'2022-02-11' AS Date), N'Food', N'Musgraves', 0, 0, 230)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435151, CAST(N'2022-02-11' AS Date), N'Food', N'Musgraves', 0, 1, 190.75)
INSERT [dbo].[orders] ([OrderID], [Date], [OrderType], [Supplier], [AcceptPartial], [Received], [Total]) VALUES (135435152, CAST(N'2022-02-11' AS Date), N'Food', N'Cash and Carry', 1, 1, 125.2)
GO
INSERT [dbo].[recipes] ([RecipeID], [Name], [Ingredients], [Instructions], [TimeToPrepare], [Allergens]) VALUES (1, N'Chicken Curry', N'Rice,0.2,Chicken Breast,0.2', N'Sample Sample Sample', 15, N'Example1,Example2')
INSERT [dbo].[recipes] ([RecipeID], [Name], [Ingredients], [Instructions], [TimeToPrepare], [Allergens]) VALUES (2, N'Beef Casserole', N'Potato,0.2,Beef,0.2,Stock,0.5', N'Sample Sample Sample', 30, N'Example1,Example2')
GO
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (1, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (2, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (3, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (4, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (5, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (6, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (7, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (8, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (9, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (10, NULL, NULL)
INSERT [dbo].[Room] ([roomID], [roomType], [roomAvailability]) VALUES (11, NULL, NULL)
GO
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (1, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (2, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (3, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (4, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (5, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (6, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (7, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (8, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (9, 1, N'Single', 0, 0, 1)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (10, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (11, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (12, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (13, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (14, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (15, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (16, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (17, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (18, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (19, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (20, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (21, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (22, 1, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (23, 1, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (24, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (25, 1, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (26, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (27, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (28, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (29, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (30, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (31, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (32, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (33, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (34, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (35, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (36, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (37, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (38, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (39, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (40, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (41, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (42, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (43, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (44, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (45, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (46, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (47, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (48, 2, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (49, 2, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (50, 2, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (51, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (52, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (53, 3, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (54, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (55, 3, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (56, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (57, 3, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (58, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (59, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (60, 3, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (61, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (62, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (63, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (64, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (65, 3, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (66, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (67, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (68, 3, N'Single', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (69, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (70, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (71, 3, N'Twin', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (72, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (73, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (74, 3, N'Double', 1, 1, 0)
INSERT [dbo].[rooms] ([RoomNumber], [Floor], [RoomType], [Available], [Clean], [Assigned]) VALUES (75, 3, N'Twin', 1, 1, 0)
GO
INSERT [dbo].[saleitems] ([ItemID], [Description], [Price], [Unit], [Quantity], [RecipeID]) VALUES (1, N'Guinness', 4.5, N'Pint', 76, NULL)
INSERT [dbo].[saleitems] ([ItemID], [Description], [Price], [Unit], [Quantity], [RecipeID]) VALUES (2, N'Heineken', 4, N'Bottle', 69, NULL)
INSERT [dbo].[saleitems] ([ItemID], [Description], [Price], [Unit], [Quantity], [RecipeID]) VALUES (3, N'Chicken Curry', 6.5, N'Meal', 30, 1)
INSERT [dbo].[saleitems] ([ItemID], [Description], [Price], [Unit], [Quantity], [RecipeID]) VALUES (4, N'Beef Casserole', 7, N'Meal', 30, 2)
INSERT [dbo].[saleitems] ([ItemID], [Description], [Price], [Unit], [Quantity], [RecipeID]) VALUES (5, N'Heineken', 5, N'Pint', 149, NULL)
INSERT [dbo].[saleitems] ([ItemID], [Description], [Price], [Unit], [Quantity], [RecipeID]) VALUES (6, N'Jack Daniels', 6, N'Shot', 13, NULL)
GO
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (0, 1, 0, 14, 63)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (0, 2, 0, 5, 20)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (0, 3, 1, 1, 6.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (1, 2, 0, 2, 8)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (1, 3, 1, 2, 13)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (2, 1, 0, 3, 13.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (2, 2, 0, 2, 8)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (2, 3, 1, 4, 26)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (3, 1, 0, 12, 54)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (4, 2, 0, 5, 20)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (4, 4, 1, 14, 98)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (5, 1, 0, 5, 22.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (5, 4, 1, 10, 70)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (6, 1, 0, 5, 22.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (6, 2, 0, 6, 24)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (6, 4, 1, 10, 70)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (7, 1, 0, 4, 18)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (7, 3, 1, 1, 6.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (7, 4, 1, 3, 21)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (8, 1, 0, 2, 9)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (8, 3, 1, 1, 6.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (8, 4, 1, 1, 7)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (9, 2, 0, 2, 8)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (9, 3, 1, 4, 26)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (10, 2, 0, 3, 12)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (10, 3, 1, 2, 13)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (11, 3, 1, 4, 26)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (11, 5, 0, 2, 10)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (12, 2, 0, 2, 8)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (12, 3, 0, 3, 19.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (13, 4, 0, 2, 14)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (13, 5, 0, 2, 10)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (14, 3, 0, 2, 13)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (15, 4, 0, 5, 35)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (16, 3, 0, 2, 13)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (17, 3, 0, 3, 19.5)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (17, 5, 0, 2, 10)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (18, 4, 0, 3, 21)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (18, 6, 0, 2, 12)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (19, 4, 0, 2, 14)
INSERT [dbo].[salelineitems] ([SaleID], [ItemID], [Cooked], [Quantity], [LineCost]) VALUES (19, 5, 0, 1, 5)
GO
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (1, N'Potato', N'Bag 8kg', 60, N'Musgraves', 15.5, NULL, N'Food', 10, CAST(N'2021-12-23' AS Date), 30)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (2, N'Chicken Breast', N'Box 6kg', 23, N'Musgraves', 21, NULL, N'Food', 3, CAST(N'2022-02-14' AS Date), 20)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (3, N'Rice', N'Bag 5kg', 13, N'Musgraves', 12.5, NULL, N'Food', 730, CAST(N'2023-09-22' AS Date), 50)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (4, N'Red Bell Pepper', N'Bag 4kg', 27, N'Musgraves', 8.75, NULL, N'Food', 7, CAST(N'2022-02-18' AS Date), 12)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (5, N'Guinness - Pint', N'Keg', 8, N'Cash and Carry', 32, N'Pint', N'Drink', 100, CAST(N'2022-02-11' AS Date), 1)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (6, N'Heineken - Bottle', N'Box 330ml', 5.5, N'Cash and Carry', 29.5, N'Bottle', N'Drink', 100, CAST(N'2021-12-17' AS Date), 24)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (7, N'Beef Steak', N'Box 5kg', 14, N'Cash and Carry', 18.8, NULL, N'Food', 3, CAST(N'2022-02-14' AS Date), 12)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (8, N'Vegetable Stock', N'Box 2kg', 20, N'Musgraves', 10, NULL, N'Food', 500, CAST(N'2022-03-11' AS Date), 14)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (9, N'Heineken - Pint', N'Keg', 4, N'Cash and Carry', 25, N'Pint', N'Drink', 100, CAST(N'2022-02-11' AS Date), 1)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (10, N'Jack Daniels', N'Box 70cl', 7, N'Cash and Carry', 120, N'Shot', N'Drink', 999, CAST(N'2021-12-17' AS Date), 12)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (11, N'Carrot', N'Bag 6kg', 11, N'Cash and Carry', 14, NULL, N'Food', 13, CAST(N'2022-02-22' AS Date), 30)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (12, N'Red Onion', N'Bag 4kg', 15, N'Cash and Carry', 10, NULL, N'Food', 17, CAST(N'2022-02-28' AS Date), 30)
INSERT [dbo].[stockitems] ([ItemID], [Description], [Unit], [Quantity], [Supplier], [UnitCost], [DrinkType], [ItemType], [ShelfLifeInDays], [CurrentUseByDate], [UnitValue/Servings]) VALUES (13, N'Bleach', N'2L Bottle', 35, N'Total Cleaning Supplies', 4.99, NULL, N'Cleaning', 183, CAST(N'2022-08-07' AS Date), 1)
GO
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (1, N'l.hayes', N'12345', N'lisa', N'hayes', N'lisa.hayes@gmail.com', N'0897654545', CAST(N'1986-01-14' AS Date), N'Admin')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (2, N'l.dunn', N'1234', N'letha', N'dunn', N'letha.dunn@gmail.com', N'0863451255', CAST(N'1989-08-17' AS Date), N'Receptionist')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (3, N'd.beaumont', N'123456', N'dyson', N'beaumont', N'dbeau@gmail.com', N'0851050005', CAST(N'1991-03-19' AS Date), N'CleaningSuper')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (4, N's.mccailin', N'1234567', N'stefania', N'mccailin', N'smac@gmail,com', N'0852233456', CAST(N'1975-11-18' AS Date), N'Manager')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (5, N'v.regan', N'1234', N'voitto', N'regan', N'vreg@gmail.com', N'0867896655', CAST(N'1995-08-20' AS Date), N'Chef')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (6, N'j.murphy', N'1234', N'john', N'murphy', N'jmurph@gmail.com', N'0871059999', CAST(N'1992-03-10' AS Date), N'BarStaff')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (7, N'j.ryan', N'12345678', N'jane', N'ryan', N'jryan55@gmail.com', N'0876761122', CAST(N'1989-09-28' AS Date), N'BarManager')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (8, N'k.obrien', N'1234', N'kate', N'obrien', N'kob94@gmail.com', N'0865556666', CAST(N'1994-08-13' AS Date), N'Cleaner')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (9, N'e.ryan', N'1234', N'evan', N'ryan', N'eryan88@gmail.com', N'0851059999', CAST(N'1988-10-01' AS Date), N'Cleaner')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (10, N'j.green', N'1234', N'jane', N'green', N'jgreen78@gmail.com', N'0879998877', CAST(N'1978-04-23' AS Date), N'Cleaner')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (11, N'e.davis', N'1234', N'edward', N'davis', N'ed1987@gmail.com', N'0851112211', CAST(N'1987-07-15' AS Date), N'Cleaner')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (13, N'kay.obrien', N'1234', N'kay', N'obrien', N'kob99@gmail.com', N'0859054554', CAST(N'1999-08-29' AS Date), N'BarStaff')
INSERT [dbo].[users] ([UserID], [Username], [Password], [FirstName], [LastName], [Email], [PhoneNumber], [DateOfBirth], [UserType]) VALUES (14, N'ka.obrien', N'1234', N'kay', N'obrien', N'obrien55@gmail.com', N'0839339339', CAST(N'1995-12-22' AS Date), N'Receptionist')
GO
/****** Object:  Index [IX_orderitems]    Script Date: 14/02/2022 14:39:16 ******/
CREATE NONCLUSTERED INDEX [IX_orderitems] ON [dbo].[orderitems]
(
	[LineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cleaningassignments]  WITH CHECK ADD  CONSTRAINT [FK_cleaningassignments_cleaningassignments] FOREIGN KEY([AssignedOn], [Room])
REFERENCES [dbo].[cleaningassignments] ([AssignedOn], [Room])
GO
ALTER TABLE [dbo].[cleaningassignments] CHECK CONSTRAINT [FK_cleaningassignments_cleaningassignments]
GO
ALTER TABLE [dbo].[cleaningassignments]  WITH CHECK ADD  CONSTRAINT [FK_cleaningassignments_rooms] FOREIGN KEY([Room])
REFERENCES [dbo].[rooms] ([RoomNumber])
GO
ALTER TABLE [dbo].[cleaningassignments] CHECK CONSTRAINT [FK_cleaningassignments_rooms]
GO
ALTER TABLE [dbo].[orderitems]  WITH CHECK ADD  CONSTRAINT [FK_orderitems_orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[orders] ([OrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderitems] CHECK CONSTRAINT [FK_orderitems_orders]
GO
ALTER TABLE [dbo].[orderitems]  WITH CHECK ADD  CONSTRAINT [FK_orderitems_stockitems] FOREIGN KEY([ItemID])
REFERENCES [dbo].[stockitems] ([ItemID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderitems] CHECK CONSTRAINT [FK_orderitems_stockitems]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[orders] ([OrderID])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_orders]
GO
ALTER TABLE [dbo].[saleitems]  WITH CHECK ADD  CONSTRAINT [FK_saleitems_recipes] FOREIGN KEY([RecipeID])
REFERENCES [dbo].[recipes] ([RecipeID])
GO
ALTER TABLE [dbo].[saleitems] CHECK CONSTRAINT [FK_saleitems_recipes]
GO
ALTER TABLE [dbo].[salelineitems]  WITH CHECK ADD  CONSTRAINT [FK_salelineitems_salelineitems] FOREIGN KEY([SaleID])
REFERENCES [dbo].[customersales] ([SaleID])
GO
ALTER TABLE [dbo].[salelineitems] CHECK CONSTRAINT [FK_salelineitems_salelineitems]
GO
ALTER TABLE [dbo].[salelineitems]  WITH CHECK ADD  CONSTRAINT [FK_salelineitems_salelineitems1] FOREIGN KEY([ItemID])
REFERENCES [dbo].[saleitems] ([ItemID])
GO
ALTER TABLE [dbo].[salelineitems] CHECK CONSTRAINT [FK_salelineitems_salelineitems1]
GO
USE [master]
GO
ALTER DATABASE [Bloomfield_Hotel] SET  READ_WRITE 
GO
