CREATE TABLE [dbo].[Stories] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Stories] PRIMARY KEY CLUSTERED ([Id] ASC)
);

