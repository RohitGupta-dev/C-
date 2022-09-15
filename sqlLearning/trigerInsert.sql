use Rohit

create table tbl_trigerInsert(id int primary key identity,name nvarchar(255),city nvarchar(255),age int)

create  table tbl_trigerInsertReacord(id int primary key identity,name nvarchar(255))
/*
create trigger insertdata_trigger
on tbl_trigerInsert
for insert
as
begin 
select * from inserted
end
*/

alter trigger insertdata_trigger1
on tbl_trigerInsert
for insert
as
begin 
declare @id nvarchar(50)
select @id=id from inserted
insert into tbl_trigerInsertReacord values('inserted data ' + @id +' date is  ')
end


insert into tbl_trigerInsert values('rohit','Rajpura',11)

--truncate table tbl_trigerInsert

select * from tbl_trigerInsert
select * from tbl_trigerInsertReacord


alter trigger tbl_trigerUpdate
on Tbl_trigerInsert
for update
as begin 
select * from deleted
select * from Inserted
end




alter trigger tbl_trigerUpdate
on Tbl_trigerInsert
for update
as begin 
declare @id int
declare @name nvarchar(50),@oldName nvarchar(50),@city nvarchar(50),@oldcity nvarchar(50),@age int,@oldAge int 
declare @auditName nvarchar(50)

 Select * into #TempTable from inserted

select @id


end

update tbl_trigerInsert set name='	rgfh' ,age=120 where id=4


create trigger lgdfkglf
on tbl_trigerInsertReacord
INSTEAD OF insert 
as
 begin
 select * from tbl_trigerInsert
 end

CREATE VIEW lkbfhkl 
as 
SELECT name FROM tbl_trigerInsertReacord


alter trigger lgdfkglf
on tbl_trigerInsertReacord
INSTEAD OF delete 
as
 begin
 select * from lkbfhkl
 end

 delete from tbl_trigerInsertReacord where id=4

update tbl_trigerInsertReacord set name='kjgdsghf' where id=4