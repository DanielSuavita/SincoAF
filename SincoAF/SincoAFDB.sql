USE [master]
GO
/****** Object:  Database [SINCOAFDB]    Script Date: 25/11/2020 11:47:59 a. m. ******/
CREATE DATABASE [SINCOAFDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SINCOAFDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SINCOAFDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SINCOAFDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SINCOAFDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SINCOAFDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SINCOAFDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SINCOAFDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SINCOAFDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SINCOAFDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SINCOAFDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SINCOAFDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SINCOAFDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SINCOAFDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SINCOAFDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SINCOAFDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SINCOAFDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SINCOAFDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SINCOAFDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SINCOAFDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SINCOAFDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SINCOAFDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SINCOAFDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SINCOAFDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SINCOAFDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SINCOAFDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SINCOAFDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SINCOAFDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SINCOAFDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SINCOAFDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SINCOAFDB] SET  MULTI_USER 
GO
ALTER DATABASE [SINCOAFDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SINCOAFDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SINCOAFDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SINCOAFDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SINCOAFDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SINCOAFDB', N'ON'
GO
ALTER DATABASE [SINCOAFDB] SET QUERY_STORE = OFF
GO
USE [SINCOAFDB]
GO
/****** Object:  Table [dbo].[ORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[USERID] [int] NOT NULL,
	[CREATEDAT] [datetime] NOT NULL,
	[CONCEPT] [varchar](max) NOT NULL,
	[STATEID] [int] NOT NULL,
	[COMPLETEDDATE] [datetime] NULL,
 CONSTRAINT [PK_ORDER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ORDERSTATE]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERSTATE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERSTATE] [varchar](30) NOT NULL,
 CONSTRAINT [PK_ORDERSTATE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CODE] [int] NOT NULL,
	[NAME] [varchar](120) NOT NULL,
	[CREATEDAT] [int] NOT NULL,
	[QUANTITY] [int] NOT NULL,
	[PRICE] [int] NOT NULL,
	[STATEID] [int] NOT NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTSORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTSORDER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ORDERID] [int] NOT NULL,
	[PRODUCTID] [int] NOT NULL,
 CONSTRAINT [PK_PRODUCTSORDER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTSTATE]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTSTATE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PRODUCTSTATE] [varchar](30) NOT NULL,
 CONSTRAINT [PK_PRODUCTSTATE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](120) NULL,
	[USERNAME] [varchar](120) NOT NULL,
	[EMAIL] [varchar](80) NOT NULL,
	[CREATEDAT] [datetime] NOT NULL,
	[ROLEID] [int] NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERSROLE]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERSROLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ROLE] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USERSROLE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ORDER]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_ORDERSTATE] FOREIGN KEY([STATEID])
REFERENCES [dbo].[ORDERSTATE] ([ID])
GO
ALTER TABLE [dbo].[ORDER] CHECK CONSTRAINT [FK_ORDER_ORDERSTATE]
GO
ALTER TABLE [dbo].[ORDER]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_USERS] FOREIGN KEY([USERID])
REFERENCES [dbo].[USERS] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ORDER] CHECK CONSTRAINT [FK_ORDER_USERS]
GO
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_PRODUCTSTATE] FOREIGN KEY([STATEID])
REFERENCES [dbo].[PRODUCTSTATE] ([ID])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_PRODUCTSTATE]
GO
ALTER TABLE [dbo].[PRODUCTSORDER]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTSORDER_ORDER] FOREIGN KEY([ORDERID])
REFERENCES [dbo].[ORDER] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PRODUCTSORDER] CHECK CONSTRAINT [FK_PRODUCTSORDER_ORDER]
GO
ALTER TABLE [dbo].[PRODUCTSORDER]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTSORDER_PRODUCT] FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[PRODUCT] ([ID])
GO
ALTER TABLE [dbo].[PRODUCTSORDER] CHECK CONSTRAINT [FK_PRODUCTSORDER_PRODUCT]
GO
ALTER TABLE [dbo].[USERS]  WITH CHECK ADD  CONSTRAINT [FK_USERS_USERSROLE] FOREIGN KEY([ROLEID])
REFERENCES [dbo].[USERSROLE] ([ID])
GO
ALTER TABLE [dbo].[USERS] CHECK CONSTRAINT [FK_USERS_USERSROLE]
GO
/****** Object:  StoredProcedure [dbo].[CREATEORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CREATEORDER]
	@USERID int,
    @CREATEDAT datetime,
    @CONCEPT varchar(MAX),
    @STATEID int
AS
BEGIN


	INSERT INTO [dbo].[ORDER]
           ([USERID]
           ,[CREATEDAT]
           ,[CONCEPT]
           ,[STATEID])
     VALUES
           (
			@USERID,
			@CREATEDAT,
			@CONCEPT,
			@STATEID
		   )

END
GO
/****** Object:  StoredProcedure [dbo].[CREATEPRODUCT]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CREATEPRODUCT]
	@CODE int,
    @NAME varchar(120),
    @CREATEDAT int,
    @QUANTITY int,
    @PRICE int,
	@STATEID int
AS
BEGIN

	INSERT INTO [dbo].[PRODUCT]
           ([CODE]
           ,[NAME]
           ,[CREATEDAT]
           ,[QUANTITY]
           ,[PRICE]
		   ,[STATEID])
     VALUES
           (
			@CODE,
			@NAME,
			@CREATEDAT,
			@QUANTITY,
			@PRICE,
			@STATEID
		   );

END
GO
/****** Object:  StoredProcedure [dbo].[CREATEPRODUCTSORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CREATEPRODUCTSORDER]
	@ORDERID int,
    @PRODUCTID int
AS
BEGIN

	INSERT INTO [dbo].[PRODUCTSORDER]
           (
			   [ORDERID],
			   [PRODUCTID]
		   )
     VALUES
           (
			   @ORDERID,
			   @PRODUCTID
		   )

END
GO
/****** Object:  StoredProcedure [dbo].[CREATEUSER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CREATEUSER]
	@NAME varchar (120),
    @USERNAME varchar (120),
    @EMAIL varchar (80),
    @CREATEDAT datetime,
    @ROLEID int
AS
BEGIN

	INSERT INTO [dbo].[USERS]
           (
			[NAME]
           ,[USERNAME]
           ,[EMAIL]
           ,[CREATEDAT]
           ,[ROLEID]
		   )
     VALUES
           (
			@NAME,
			@USERNAME,
			@EMAIL ,
			@CREATEDAT,
			@ROLEID 
		   );

END
GO
/****** Object:  StoredProcedure [dbo].[DELETEORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DELETEORDER]
    @ID int
AS
BEGIN

	UPDATE [dbo].[ORDER]
	
	SET   [STATEID]		= 1

	WHERE [ORDER].[ID]	= @ID
END
GO
/****** Object:  StoredProcedure [dbo].[DELETEPRODUCT]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DELETEPRODUCT]
	@ID int
AS
BEGIN
	

	UPDATE [dbo].[PRODUCT]

	SET [STATEID]		= 1

	WHERE [PRODUCT].[ID] = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[DELETEPRODUCTSORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DELETEPRODUCTSORDER] 
	@ID int
AS
BEGIN

	DELETE FROM [dbo].[PRODUCTSORDER]

    WHERE [PRODUCTSORDER].[ID] = @ID

END
GO
/****** Object:  StoredProcedure [dbo].[DELETEUSER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DELETEUSER] 
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE [dbo].[USERS]

	SET [ROLEID]		= 1

	WHERE [USERS].[ID]	= @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTORDERBYCONCEPTORPRODUCT]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECTORDERBYCONCEPTORPRODUCT]
	@CONCEPT varchar(MAX),
	@CODE int
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT        
			dbo.[ORDER].CREATEDAT, 
			dbo.[ORDER].CONCEPT, 
			dbo.[ORDER].COMPLETEDDATE, 
			dbo.[ORDERSTATE].ORDERSTATE, 
			dbo.[PRODUCT].CODE, 
			dbo.[PRODUCT].NAME, 
			dbo.[PRODUCT].QUANTITY, 
			dbo.[PRODUCT].PRICE

	FROM            
			dbo.[ORDER] 
			INNER JOIN	dbo.[ORDERSTATE]	ON dbo.[ORDER].STATEID = dbo.ORDERSTATE.ID 
			INNER JOIN	dbo.[PRODUCTSORDER]	ON dbo.[ORDER].ID = dbo.PRODUCTSORDER.ORDERID 
			INNER JOIN  dbo.[PRODUCT]		ON dbo.[PRODUCTSORDER].PRODUCTID = dbo.PRODUCT.ID

	WHERE        
			(dbo.[ORDER].CONCEPT	= @CONCEPT) 
		OR	(dbo.[PRODUCT].CODE		= @CODE) 
		OR	(dbo.[PRODUCT].NAME		= @CONCEPT)
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTORDERSBYUSERSORCONCEPT]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECTORDERSBYUSERSORCONCEPT] 
	-- Add the parameters for the stored procedure here
		@NAME varchar(120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT        
			dbo.[ORDER].CREATEDAT, 
			dbo.[ORDER].CONCEPT, 
			dbo.[ORDERSTATE].ORDERSTATE, 
            dbo.[ORDER].COMPLETEDDATE

	FROM    
			dbo.[USERS] 
			INNER JOIN dbo.[ORDER]		ON dbo.[USERS].ID = dbo.[ORDER].USERID 
			INNER JOIN dbo.[ORDERSTATE]	ON dbo.[ORDER].STATEID = dbo.[ORDERSTATE].ID 
			INNER JOIN dbo.[USERSROLE]	ON dbo.[USERS].ROLEID = dbo.[USERSROLE].ID

	WHERE        
			(dbo.[USERS].NAME		= @NAME) 
		OR	(dbo.[USERS].USERNAME	= @NAME)
		OR	(dbo.[USERS].EMAIL		= @NAME)
		OR	(dbo.[ORDER].CONCEPT	= @NAME)

END
GO
/****** Object:  StoredProcedure [dbo].[SELECTPRODUCSORDERTBYORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECTPRODUCSORDERTBYORDER]
	@CONCEPT varchar(MAX),
	@ID int
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT        
			dbo.[PRODUCTSORDER].ID,
			dbo.[PRODUCT].CODE, 
			dbo.[PRODUCT].NAME, 
			dbo.[PRODUCT].QUANTITY, 
			dbo.[PRODUCT].PRICE

	FROM            
			dbo.[ORDER] 
			INNER JOIN	dbo.[PRODUCTSORDER]	ON dbo.[ORDER].ID = dbo.PRODUCTSORDER.ORDERID 
			INNER JOIN  dbo.[PRODUCT]		ON dbo.[PRODUCTSORDER].PRODUCTID = dbo.PRODUCT.ID

	WHERE        
			(dbo.[ORDER].CONCEPT	= @CONCEPT) 
		OR	(dbo.[ORDER].ID			= @ID) 
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTPRODUCTBYCODEORNAME]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECTPRODUCTBYCODEORNAME]
	-- Add the parameters for the stored procedure here
	@PRODUCT varchar (120),
	@CODE int
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT        
			CODE, 
			NAME, 
			QUANTITY, 
			PRICE, 
			CREATEDAT
	FROM            
			dbo.PRODUCT
	WHERE        
			(CODE = @CODE) 
		OR	(NAME = @PRODUCT)

END
GO
/****** Object:  StoredProcedure [dbo].[SELECTUSERBYCREDENTIALS]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECTUSERBYCREDENTIALS]
	@NAME varchar(120)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT		
			dbo.USERSROLE.ROLE, 
			dbo.USERS.NAME, 
			dbo.USERS.USERNAME, 
			dbo.USERS.EMAIL, 
			dbo.USERS.CREATEDAT, 
			dbo.USERSROLE.ID

	FROM    
			dbo.USERS 
			INNER JOIN dbo.USERSROLE	ON dbo.USERS.ROLEID = dbo.USERSROLE.ID

	WHERE   
			(dbo.USERSROLE.ID	>= 1) 
		AND (dbo.USERS.NAME		= @NAME) 
		OR	(dbo.USERS.USERNAME = @NAME) 
		OR	(dbo.USERS.EMAIL	= @NAME)
END
GO
/****** Object:  StoredProcedure [dbo].[SELECTUSERROLE]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SELECTUSERROLE]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT [ID]
		  ,[ROLE]
	  FROM [dbo].[USERSROLE]

END
GO
/****** Object:  StoredProcedure [dbo].[UPDATEORDER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATEORDER]
    @ID int,
    @CONCEPT varchar(MAX),
    @STATEID int,
    @COMPLETEDDATE datetime
AS
BEGIN

	UPDATE [dbo].[ORDER]
	
	SET 
		  [CONCEPT]			= @CONCEPT,
		  [STATEID]			= @STATEID,
		  [COMPLETEDDATE]	= @COMPLETEDDATE

	WHERE [ORDER].[ID]	= @ID


END
GO
/****** Object:  StoredProcedure [dbo].[UPDATEPRODUCT]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATEPRODUCT]
	@ID int,
	@CODE int,
    @NAME varchar(120),
    @QUANTITY int,
    @PRICE int,
	@STATEID int
AS
BEGIN
	

	UPDATE [dbo].[PRODUCT]

	SET [CODE]			= @CODE, 
		[NAME]			= @NAME, 
		[QUANTITY]		= @QUANTITY, 
		[PRICE]			= @PRICE,
		[STATEID]		= @STATEID

	WHERE [PRODUCT].[ID] = @ID


END
GO
/****** Object:  StoredProcedure [dbo].[UPDATEUSER]    Script Date: 25/11/2020 11:47:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UPDATEUSER]
	@ID int,
	@NAME varchar (120),
    @USERNAME varchar (120),
    @EMAIL varchar (80),
    @ROLEID int
AS
BEGIN

	UPDATE [dbo].[USERS]

	SET [NAME]		= @NAME, 
      [USERNAME]	= @USERNAME, 
      [EMAIL]		= @EMAIL, 
      [ROLEID]		= @ROLEID

	WHERE [USERS].[ID] = @ID

END
GO
USE [master]
GO
ALTER DATABASE [SINCOAFDB] SET  READ_WRITE 
GO
