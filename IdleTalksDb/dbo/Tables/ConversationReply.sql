CREATE TABLE [dbo].[ConversationReply] (
    [Id]             UNIQUEIDENTIFIER CONSTRAINT [DF_ConversationReply_Id] DEFAULT (newid()) NOT NULL,
    [ConversationId] UNIQUEIDENTIFIER NOT NULL,
    [UserId]         BIGINT           NOT NULL,
    [Message]        NVARCHAR (1024)  NOT NULL,
    CONSTRAINT [FK_ConversationReply_Conversation] FOREIGN KEY ([ConversationId]) REFERENCES [dbo].[Conversation] ([Id])
);


GO
CREATE UNIQUE CLUSTERED INDEX [PK_ConversationReply_Id]
    ON [dbo].[ConversationReply]([Id] ASC);

