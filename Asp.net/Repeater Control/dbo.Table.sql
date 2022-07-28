CREATE TABLE [dbo].[repratedControl]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [name] NCHAR(10) NOT NULL, 
    [rollno] NCHAR(10) NULL, 
    [class] NCHAR(10) NULL, 
    [gender] NCHAR(10) NULL
)
