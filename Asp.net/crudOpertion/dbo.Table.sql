CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	name nvarchar(200) NOT NULL,gender nvarchar(200) NOT NULL,course nvarchar(200) NOT NULL,rollno nvarchar(200) not null,
)
