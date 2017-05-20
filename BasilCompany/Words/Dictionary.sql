CREATE TABLE [word].[Dictionary]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[English] VARCHAR(256),
	[Ukrainian] NVARCHAR(256),
	[Transcription] NVARCHAR(256),
)
