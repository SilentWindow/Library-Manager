CREATE TABLE [dbo].[loginTable] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (150) NOT NULL,
    [pass]     VARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

