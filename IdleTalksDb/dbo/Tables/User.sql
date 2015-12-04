CREATE TABLE [dbo].[User] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (20) NOT NULL,
    [LastName]  NVARCHAR (30) NOT NULL,
    [BirthDay]  DATETIME2 (7) NULL,
    [Password]  NVARCHAR (20) NOT NULL,
    [MoodId]    BIGINT        NULL
);


GO
CREATE UNIQUE CLUSTERED INDEX [PK_User_id]
    ON [dbo].[User]([Id] ASC);

