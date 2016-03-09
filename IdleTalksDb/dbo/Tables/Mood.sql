CREATE TABLE [dbo].[Mood] (
    [Id]     BIGINT       NOT NULL,
    [Text]   NCHAR (1024) NOT NULL,
    CONSTRAINT [FK_Mood_User] FOREIGN KEY ([Id]) REFERENCES [dbo].[User] ([Id])
);

GO
CREATE UNIQUE CLUSTERED INDEX [PK_Mood_Id]
    ON [dbo].[Mood]([Id] ASC);

