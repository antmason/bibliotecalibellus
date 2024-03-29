SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LlibreAutor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LlibreAutor](
	[isbn] [int] NULL,
	[id_autor] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Llibre]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Llibre](
	[isbn] [int] NOT NULL,
	[titol_curt] [nchar](10) NULL,
	[titol_llarg] [nchar](50) NULL,
	[id_publicador] [int] NULL,
	[resum] [nvarchar](max) NULL,
	[premis] [nvarchar](50) NULL,
	[pvp] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Llibre] PRIMARY KEY CLUSTERED 
(
	[isbn] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Genere]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Genere](
	[id_genere] [int] NULL,
	[nom] [nchar](30) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LlibreGenere]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LlibreGenere](
	[isbn] [int] NULL,
	[id_genere] [int] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Autor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Autor](
	[id_autor] [int] NULL,
	[nom] [nchar](20) NULL,
	[cognoms] [nchar](50) NULL
) ON [PRIMARY]
END
