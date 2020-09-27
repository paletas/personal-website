CREATE TABLE [blog].[BlogPost]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Url] NVARCHAR(256) NOT NULL, 
    [When] DATETIME2 NULL, 
    [Content] NTEXT NOT NULL, 
    [Version] ROWVERSION NOT NULL
)
