use Rohit
create table persons(id int primary key identity(1,1) ,name nvarchar(50),age nvarchar(50),orderId int)
create table orders(id int primary key identity(1,1),orderName nvarchar(50))

select * from persons 
select * from orders


alter table orders add  CONSTRAINT FK_PersonOrder FOREIGN KEY (id)
    REFERENCES Persons(id) 

	ALTER TABLE orders
DROP FK_PersonOrder ;

insert into orders values('Phone'),('Laptop')
insert into persons values('rohit',21,1)

truncate table  orders
