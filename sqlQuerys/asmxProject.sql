create database checkDaa;
create table insertdata( id int primary key identity(1,1),name nvarchar(200),email nvarchar(200),phone nvarchar(200),class nvarchar(200))

Alter procedure checkData
@name nvarchar(200),@email nvarchar(200),@phone nvarchar(200),@class nvarchar(200)
as
begin 
insert into insertdata(name,email,phone,class)values(@name,@email,@phone,@class)
select 'data saved successfully' as msg
end


ALTER proc showData
as
select * from insertdata 