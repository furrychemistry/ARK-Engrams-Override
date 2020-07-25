USE [ARK]
GO

/****** Object: Table [dbo].[EngramCategories] Script Date: 07/25/2020 00:36:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EngramCategories] (
    [ID]           INT            NOT NULL,
    [CategoryName] NVARCHAR (50)  NOT NULL,
    [Notes]        NVARCHAR (200) NOT NULL
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_EngramCategories_ID]
    ON [dbo].[EngramCategories]([ID] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_EngramCategories_CategoryName]
    ON [dbo].[EngramCategories]([CategoryName] ASC);


