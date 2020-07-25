USE [ARK]
GO

/****** Object: SqlProcedure [dbo].[SelectEngramsByCategory] Script Date: 07/25/2020 00:37:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectEngramsByCategory]
	@pickID int = 0
AS
	SELECT * FROM [dbo].[Engrams] WHERE [CategoryID] = @pickID ORDER BY [ArkLevel], [FriendlyName]
