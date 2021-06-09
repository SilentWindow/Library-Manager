CREATE TABLE [dbo].[NewBook] (
    [bid]     INT           IDENTITY (1, 1) NOT NULL,
    [bName]   VARCHAR (250) NOT NULL,
    [bAuthor] VARCHAR (250) NOT NULL,
    [bPubl]   VARCHAR (250) NOT NULL,
    [bDate]   VARCHAR (250) NOT NULL,
    [bPrice]  BIGINT        NOT NULL,
    [bQuan]   BIGINT        NOT NULL,
    PRIMARY KEY CLUSTERED ([bid] ASC)
);

