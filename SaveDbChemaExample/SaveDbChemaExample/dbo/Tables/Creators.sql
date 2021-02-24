CREATE TABLE [dbo].[Creators] (
    [CreatorId] INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (450) NULL,
    [LastName]  NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_Creators] PRIMARY KEY CLUSTERED ([CreatorId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Creators_FirstName_LastName]
    ON [dbo].[Creators]([FirstName] ASC, [LastName] ASC) WHERE ([FirstName] IS NOT NULL);

