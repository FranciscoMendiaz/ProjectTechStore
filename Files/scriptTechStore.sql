USE [master]
GO
/****** Object:  Database [Tech-Store]    Script Date: 4/9/2023 14:39:59 ******/
CREATE DATABASE [Tech-Store]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tech-Store', FILENAME = N'C:\DataSQLServer\Tech-Store.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tech-Store_log', FILENAME = N'C:\DataSQLServer\Tech-Store_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Tech-Store] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tech-Store].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tech-Store] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tech-Store] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tech-Store] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tech-Store] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tech-Store] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tech-Store] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tech-Store] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tech-Store] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tech-Store] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tech-Store] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tech-Store] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tech-Store] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tech-Store] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tech-Store] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tech-Store] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tech-Store] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tech-Store] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tech-Store] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tech-Store] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tech-Store] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tech-Store] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tech-Store] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tech-Store] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tech-Store] SET  MULTI_USER 
GO
ALTER DATABASE [Tech-Store] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tech-Store] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tech-Store] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tech-Store] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tech-Store] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tech-Store] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Tech-Store] SET QUERY_STORE = ON
GO
ALTER DATABASE [Tech-Store] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Tech-Store]
GO
/****** Object:  Table [dbo].[brands]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brands](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_brands] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cards]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cards](
	[number] [int] NOT NULL,
	[security_code] [int] NOT NULL,
	[type] [nvarchar](100) NOT NULL,
	[due_date] [date] NOT NULL,
	[email_user] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_cards] PRIMARY KEY CLUSTERED 
(
	[number] ASC,
	[security_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment_types]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment_types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_payment_types] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prices]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prices](
	[validityDate] [date] NOT NULL,
	[ammount] [decimal](12, 2) NOT NULL,
	[id_product] [int] NOT NULL,
 CONSTRAINT [PK_prices] PRIMARY KEY CLUSTERED 
(
	[validityDate] ASC,
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[description] [nvarchar](100) NOT NULL,
	[colour] [nvarchar](100) NOT NULL,
	[image] [varbinary](8000) NULL,
	[id_brand] [int] NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shipping_price]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shipping_price](
	[validityDate] [date] NOT NULL,
	[ammount] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK_shipping_price] PRIMARY KEY CLUSTERED 
(
	[validityDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_roles]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_roles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_user_roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 4/9/2023 14:40:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[email] [nvarchar](100) NOT NULL,
	[first_name] [nvarchar](100) NOT NULL,
	[last_name] [nvarchar](100) NOT NULL,
	[password] [nvarchar](15) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[id_user_role] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_user_roles]    Script Date: 4/9/2023 14:40:00 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_user_roles] ON [dbo].[user_roles]
(
	[description] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cards]  WITH CHECK ADD  CONSTRAINT [FK_cards_users] FOREIGN KEY([email_user])
REFERENCES [dbo].[users] ([email])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[cards] CHECK CONSTRAINT [FK_cards_users]
GO
ALTER TABLE [dbo].[prices]  WITH CHECK ADD  CONSTRAINT [FK_prices_products] FOREIGN KEY([id_product])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[prices] CHECK CONSTRAINT [FK_prices_products]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_brands] FOREIGN KEY([id_brand])
REFERENCES [dbo].[brands] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_brands]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_user_roles] FOREIGN KEY([id_user_role])
REFERENCES [dbo].[user_roles] ([id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_user_roles]
GO
USE [master]
GO
ALTER DATABASE [Tech-Store] SET  READ_WRITE 
GO
