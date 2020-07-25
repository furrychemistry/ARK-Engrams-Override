USE [ARK]
GO

/****** Object: Table [dbo].[Engrams] Script Date: 07/25/2020 00:36:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Engrams] (
    [EngramIndex]         INT            NOT NULL,
    [EngramClassName]     NVARCHAR (250) NOT NULL,
    [FriendlyName]        NVARCHAR (50)  NOT NULL,
    [ArkCost]             INT            NOT NULL,
    [MyCost]              INT            NOT NULL,
    [UseMyCost]           BIT            NOT NULL,
    [ArkLevel]            INT            NOT NULL,
    [MyLevel]             INT            NOT NULL,
    [UseMyLevel]          BIT            NOT NULL,
    [AutoUnlockLevel]     NUMERIC (18)   NOT NULL,
    [UseAutoUnlockLevel]  BIT            NOT NULL,
    [RemovePrerequisites] BIT            NOT NULL,
    [Hidden]              BIT            NOT NULL,
    [CategoryID]          INT            NOT NULL
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Engrams_EngramIndex]
    ON [dbo].[Engrams]([EngramIndex] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Engrams_EngramClassName]
    ON [dbo].[Engrams]([EngramClassName] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_FriendlyName]
    ON [dbo].[Engrams]([FriendlyName] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_ArkCost]
    ON [dbo].[Engrams]([ArkCost] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_ArkLevel]
    ON [dbo].[Engrams]([ArkLevel] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_UseMyCost]
    ON [dbo].[Engrams]([UseMyCost] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_MyCost]
    ON [dbo].[Engrams]([MyCost] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_MyLevel]
    ON [dbo].[Engrams]([MyLevel] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_UseMyLevel]
    ON [dbo].[Engrams]([UseMyLevel] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_AutoUnlockLevel]
    ON [dbo].[Engrams]([AutoUnlockLevel] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_UseAutoUnlockLevel]
    ON [dbo].[Engrams]([UseAutoUnlockLevel] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_RemovePrerequisites]
    ON [dbo].[Engrams]([RemovePrerequisites] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Engrams_Hidden]
    ON [dbo].[Engrams]([Hidden] ASC);


GO
ALTER TABLE [dbo].[Engrams]
    ADD CONSTRAINT [FK_Engrams_EngramCategories] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[EngramCategories] ([ID]);


