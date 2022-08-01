use Rohit

Create Table Students   
(  
id int primary key not null identity(1,1),  
firstName nvarchar(MAX) not null,  
lastName nvarchar(MAX) not null,  
feesPaid int not null,  
gender nvarchar(MAX) not null,  
emailId nvarchar(MAX) not null,  
telephoneNumber nvarchar(MAX) not null,  
dateOfBirth date not null,  
isActive bit not null,  
creationDate datetime not null,  
lastModifiedDate datetime not null  
)  

select * from Students

INSERT INTO Students VALUES ('Ankit','Bansal',45000, 'Male', 'ankit@a.com','2564210000','20/May/1993',1,GETDATE(),GETDATE())  

create procedure insertstudentData
@name  nvarchar(MAX) ,@lastname  nvarchar(MAX),@fee int ,@gender  nvarchar(MAX),@email  nvarchar(MAX),@tel  nvarchar(MAX),@Dob date,@active bit,@creationDate datetime,@lastModify datetime
as
begin 
insert into Students values (@name,@lastname,@fee,@gender,@email,@tel,@Dob,@active,@creationDate,@lastModify);
end


create procedure showDataStudent
as 
select * from Students where isActive=1;