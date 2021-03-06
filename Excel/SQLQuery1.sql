﻿USE [Database1]
GO
/****** Object:  Table [dbo].[Пол]    Script Date: 12.11.2019 15:57:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пол](
	[ID_Пола] [int] IDENTITY(1,1) NOT NULL,
	[Пол] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Пол] PRIMARY KEY CLUSTERED 
(
	[ID_Пола] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Человек]    Script Date: 12.11.2019 15:57:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Человек](
	[ID_Человека] [int] IDENTITY(1,1) NOT NULL,
	[Имя] [nvarchar](50) NOT NULL,
	[Пол] [int] NOT NULL,
 CONSTRAINT [PK_Человек] PRIMARY KEY CLUSTERED 
(
	[ID_Человека] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Человек]  WITH CHECK ADD  CONSTRAINT [FK_Человек_Пол] FOREIGN KEY([Пол])
REFERENCES [dbo].[Пол] ([ID_Пола])
GO
ALTER TABLE [dbo].[Человек] CHECK CONSTRAINT [FK_Человек_Пол]
GO