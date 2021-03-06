/****** Object:  Table [dbo].[Address]    Script Date: 2019.05.15. 16:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FI_Person] [int] NOT NULL,
	[Kind] [char](10) NOT NULL,
	[Country3166] [char](2) NOT NULL,
	[Zip] [varchar](10) NOT NULL,
	[City] [varchar](30) NOT NULL,
	[Line1] [varchar](30) NOT NULL,
	[Line2] [varchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[Person]    Script Date: 2019.05.15. 16:36:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titles] [nvarchar](10) NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Phone] [varchar](30) NULL,
	[Mobile] [varchar](30) NULL,
	[Email] [varchar](80) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_Kind]  DEFAULT ('RES') FOR [Kind]
GO
