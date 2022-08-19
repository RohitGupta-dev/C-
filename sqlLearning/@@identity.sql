use Rohit2

create table table_1(id int primary key identity(1,1),name varchar(255),rollno varchar(255))
create table table_2(id int primary key identity(1,1),name varchar(255))

select * from table_1
select * from table_2

truncate table table_1
truncate table table_2

alter trigger addData on table_1 for insert
as
begin 
insert into table_2 values('ROhit')
end


select SCOPE_IDENTITY()
select @@IDENTITY
select Ident_Current('table_1')
select Ident_Current('table_2')


insert into table_2 values('mohit')