CREATE DATABASE JIONS
USE JIONS

create table cricket(cricketid int  identity,Stu_name varchar(30),primary key(cricketid)) 

create table football(footballid int  identity,Stu_name varchar(30),primary key(footballid)) 

insert into cricket values('rohit'),('michel'),('johnson'),('ragav'),('mohit')

delete  from cricket;
insert into football values('rohit'),('michel'),('Mohan'),('Rajahn'),('tiger'),('Astro'),('JOhn')

select * from cricket as c inner join football as f on c.Stu_name=f.Stu_name;

select c.Stu_name ,c.cricketid,f.footballid,f.footballid from cricket as c inner join football as f on c.Stu_name=f.Stu_name;

select Stu_name from cricket where Stu_name=(select min(Stu_name) from cricket)

select cricketid ,Stu_name from cricket where Stu_name=(select min(Stu_name) from cricket)



create table products(product_id int identity,p_name varchar(50),sell_price float,p_type varchar(50) )

create table orders(order_id int identity,o_name varchar(50),order_sell_price float )

insert into products values('laptop',10.00,'luxry'),('phone',20.00,'medium'),('car',1000.99,'luxry'),('jawelery',800.01,'jawelleey'),('tshirt',50.90,'luxry'),('Table',120.00,'non-luxry');
select * from  products
select * from orders
insert into orders select p_name,sell_price from products where product_id in (select product_id from products where sell_price>60) 


insert into orders values('sold',10.00),('unsold',20.00),('car',1000.99),('jawelery',800.01),('sold',50.90),('sold',120.00);

create table SubupdateQuery (Emp_id int identity(100,1),Emp_name nvarchar(200),Age int,Gender nvarchar(200),Doj date,Dept nvarchar(200),city nvarchar(200),salary float(50))

create table SubupdateQuery_e (Emp_id int identity(100,1),Emp_name nvarchar(200),Age int,Gender nvarchar(200),Doj date,Dept nvarchar(200),city nvarchar(200),salary float(50))

insert into SubupdateQuery values('Rahul',32,'male','2020-01-06','Software Devloper','Rajpura Chd',70.99),('rajan',36,'male','2021-01-06','Intern Trainer','chandigadh',80.99),
								('Manish',42,'male','2020-09-09','Digital Marketing','Mohali',990.99),('Mohani',22,'Male','2006-09-21','Sales Force','Badhinda',69.99)

insert into SubupdateQuery_e values('Rahul',32,'male','2020-01-06','Software Devloper','Rajpura Chd',70.99),('rajan',36,'male','2021-01-06','Intern Trainer','chandigadh',80.99),
								('Manish',42,'male','2020-09-09','Digital Marketing','Mohali',990.99),('Mohani',22,'Male','2006-09-21','Sales Force','Badhinda',69.99)

select * from SubupdateQuery

select * from SubupdateQuery_e

update SubupdateQuery set salary = salary*0.35 where age in (select age from SubupdateQuery_e where age >=32)

Delete from SubupdateQuery where age in (select Age from SubupdateQuery_e where age<32)