CREATE TABLE [dbo].[Note] (
    [Id]     BIGINT          IDENTITY (1, 1) NOT NULL,
    [UserId] BIGINT          NOT NULL,
    [Title]  NVARCHAR (100)  NOT NULL,
    [Text]   NVARCHAR (1024) NOT NULL,
    CONSTRAINT [FK_Note_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);


GO
CREATE UNIQUE CLUSTERED INDEX [PK_Note_Id]
    ON [dbo].[Note]([Id] ASC);

