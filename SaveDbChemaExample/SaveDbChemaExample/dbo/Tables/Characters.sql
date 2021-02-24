CREATE TABLE [dbo].[Characters] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NULL,
    [LastName]  NVARCHAR (MAX) NULL,
    [Gender]    BIT            NOT NULL,
    [Age]       INT            NOT NULL,
    [StoryId]   INT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Characters] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Characters_Stories_StoryId] FOREIGN KEY ([StoryId]) REFERENCES [dbo].[Stories] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Characters_StoryId]
    ON [dbo].[Characters]([StoryId] ASC);

