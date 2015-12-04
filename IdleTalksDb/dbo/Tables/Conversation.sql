CREATE TABLE [dbo].[Conversation] (
    [Id]        UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [UserOneId] BIGINT           NOT NULL,
    [UserTwoId] BIGINT           NOT NULL,
    CONSTRAINT [FK_Conversation_UserOne] FOREIGN KEY ([UserOneId]) REFERENCES [dbo].[User] ([Id]),
    CONSTRAINT [FK_Conversation_UserTwo] FOREIGN KEY ([UserTwoId]) REFERENCES [dbo].[User] ([Id])
);


GO
CREATE UNIQUE CLUSTERED INDEX [PK_Conversation_Id]
    ON [dbo].[Conversation]([Id] ASC);

