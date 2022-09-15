use Rohit

-- string function

Select ASCII('A')

Declare @Number int
Set @Number = 1
While(@Number <= 255)
Begin
 Print CHAR(@Number)
 Set @Number = @Number + 1
End

Declare @Number1 int
Set @Number1 = 65
While(@Number1 <= 90)
Begin
 Print CHAR(@Number1)
 Set @Number1 = @Number1 + 1
End

declare @lowerCase int
set @lowerCase = 97
while(@lowerCase <=122)
begin
print char(@lowerCase)
set @lowerCase=@lowerCase+1
End

print lower('Rohti')

select lower('Rohti')

print upper('Rohti')


select  ltrim ('          hghg fhgjfsd;jsljkfjgklsdfjg')

select  rtrim ('hghg fhgjfsd;jsljkfjgklsdfjg                       ')


Select REVERSE('ABCDEFGHIJKLMNOPQRSTUVWXYZ')

Select len('     ABCDEFGHIJKLMNOPQRSTUVWXYZ')

Select LEFT('ABCDE', 3)

Select right('ABCDE', 3)

Select CHARINDEX('@','gra@aaa.com',1)

Select SUBSTRING('John@bbb.com',6, 7)

Select SUBSTRING('John@bbb.com',(CHARINDEX('@', 'John@bbb.com') + 1),(LEN('John@bbb.com') - CHARINDEX('@','John@bbb.com')))
		
Select (CHARINDEX('@', 'John@bbb.com') + 1)

select (LEN('John@bbb.com') - CHARINDEX('@','John@bbb.com'))

Select SUBSTRING('Jogfdgfgfdhn@bbb.com',0, (CHARINDEX('@', 'Jogfdgfgfdhn@bbb.com')  ))

Create Table tblEmployee
(
ID int primary key,
FirstName varchar(20),
MiddleName varchar(20),
LastName varchar(20),
Email varchar(20),
Gender varchar(20),
DepartmentID int,
Number int
)

Insert into tblEmployee values (1, ' Sam ', 'S', 'Sony','Sam@aaa.com', 'Male', 1, 1)
Insert into tblEmployee values (2, ' Ram ', 'R', 'Barber','Ram@aaa.com', 'Male', 1, 1)
Insert into tblEmployee values (3, ' Sara ', 'J', 'Sanosky','Sara@ccc.com', 'Female', 1, 1)
Insert into tblEmployee values (4, ' Todd ', '', 'Gartner','Todd@bbb.com', 'Male', 1, 1)
Insert into tblEmployee values (5, ' John ', '', 'Grover','John@aaa.com', 'Male', 1, 1)
Insert into tblEmployee values (6, ' Sana ', 'J', 'Lenin','Sana@ccc.com', 'Female', 1, 1)
Insert into tblEmployee values (7, ' James ', 'S', 'Bond','James@bbb.com', 'Male', 1, 1)
Insert into tblEmployee values (8, ' Rob ', 'J', 'Hunter','Rob@ccc.com', 'Male', 1, 1)
Insert into tblEmployee values (9, ' Steve ', 'R', 'Wilson','Steve@aaa.com', 'Male', 1, 1)
Insert into tblEmployee values (10, ' Pam ', 'P', 'Broker','Pam@bbb.com','Female', 1, 1)

Select * from tblEmployee



Select SUBSTRING(Email, CHARINDEX('@', Email) + 1,
LEN(Email) - CHARINDEX('@', Email)) as EmailDomain,
COUNT(Email) as Total
from tblEmployee
Group By SUBSTRING(Email, CHARINDEX('@', Email) + 1,
LEN(Email) - CHARINDEX('@', Email))


Select SUBSTRING(Email, CHARINDEX('@', Email) + 1,LEN(Email) - CHARINDEX('@', Email)) as EmailDomain
from tblEmployee



Select SUBSTRING(Email, CHARINDEX('@', Email) + 1,LEN(Email) - CHARINDEX('@', Email)) as EmailDomain
from tblEmployee

select CHARINDEX('@', Email)from tblEmployee
select LEN(Email)            from tblEmployee
select CHARINDEX('@', Email) from tblEmployee
select * from tblEmployee


create view vw_tblEmployee
as
select firstName,MiddleName,LastName,Email,Gender from tblEmployee


SELECT * FROM vw_tblEmployee WHERE Gender='FeMale'
