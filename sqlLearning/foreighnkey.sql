create  table employDetails(id int primary key identity(1,1),employName varchar(200))
create  table employContact(id int primary key identity(1,1),employPhone varchar(200))
create  table employLocation(id int primary key identity(1,1),employAddress varchar(200))
create  table employSalaryInformation(id int primary key identity(1,1),employSalaryInformation varchar(200))
create  table employStatus(id int primary key identity(1,1),employStatus varchar(200))
create  table AllEmploys(id int primary key identity,employDetailsId int,employContactId int, employLocationId int,employSalaryInformationId int,employStatus int )

use rohit
select * from employDetails
select * from employContact
select * from employLocation
select * from employSalaryInformation
select * from employStatus
select * from AllEmploys


insert into employDetails   values('Mohit')
insert into employContact  values('1234567890')
insert into employLocation  values('Ambala')
insert into employSalaryInformation values('No')
insert into employStatus  values('DeActive')
insert into AllEmploys values(12,2,2,2,2);


create Database Rohit2
use Rohit2
--C:\Users\Local User\Documents\SQL Server Management Studio



create table students(id int not null, age int ,class nvarchar(200),status nvarchar(10))

alter table students
add primary key (id)

alter table students add constraint check_age 