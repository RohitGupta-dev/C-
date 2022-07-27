create database tire;

create table tireItems(id int primary key identity(1,1),name nvarchar(200),class nvarchar(200),rollno nvarchar(2000))

select * from tireItems;

alter procedure insertData
@name nvarchar(200),@class nvarchar(200),@rollno nvarchar(200)
as
begin
insert into tireItems (name,class,rollno)values(@name,@class,@rollno)
select 'data saved successfully' as msg
end

create procedure showData
as
select*from tireItems