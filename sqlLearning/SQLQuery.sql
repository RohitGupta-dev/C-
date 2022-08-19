
create database mysqlLearning
use mysqlLearning
describe JOHN;
create taBLE JOHN(ID VARCHAR(200),NAME VARCHAR(200))
select * from JOHN
create table Employs(name varchar(25),age int,gender char(1),doj date,city varchar(50),salary float)
select * from Employs
select  distinct city from Employs
select  count(name) as totalCount  from Employs
select  count(name)   from Employs
SELECT SUM(salary)   from Employs
SELECT avg(salary) as AverageSalary   from Employs
select name, age ,city from Employs
select * from Employs where age >30
select * from Employs where gender='m'
select * from Employs where city='rajpura' or city='Ambala'
select * from Employs where city in ('rajpura','ambala')
select * from Employs where doj between '2001-01-01' and '2022-01-01'
select * from Employs where age>30 and gender='f'

select gender , sum(salary) as TotalSalary  from Employs group by gender
select * from Employs order by salary 
select * from Employs order by salary desc

select (10+30) as addition
    





select length('Rohit') as totalLength

select repeat('@',10) 
select upper('india')
select lower('india')
select curdate()
select now()
select day('2022-09-09')
insert into Employs values('hjjh',21,'M','2009-09-09','Ambala',10.00),('Anu',32,'f','2005-09-09','mohali',1000.00),('Rohan',12,'M','2005-09-09','rajpura',2112.00),('rajat',82,'f','2005-09-09','rajpfdsura',1000.00)


select character_length('234113')

select concat('Rohit','is','gjksdflg','54357677')
select concat(name,'',age) from Employs
select REVERSE('fjdlugdl','adsiogfdugdgads')
select REVERSE(name) from Employs
select REPLACE('orane is vegitable','vegitable','fruit')
select REPLACE(name,'rohit','radhe') from Employs

select LTRIM('                   india                   ');
select RTRIM('                   india                   ');
select POSITION('rohit'in'dslfsjfljg g lgldflsdg rohit' ) as  name
select ascii('a')

create table Employess(EmpID int primary key identity,Emp_name varchar(200),Age int,city varchar(200),emp_sex char(1),Doj date,Dept varchar(200),salary float)

insert into Employess values('Fanjali',21,'Faridabad','F','2022-01-01','Intern' ,2500),('Kamika',21,'jaipur','F','2014-01-05','Testing' ,5000),('joshi',32,'Ludhiyana','M','2021-01-01','Lease',12343)
select * from Employess

select distinct city from Employess
select distinct Dept from Employess
select Dept,avg(age)as salary from Employess group by Dept;

select Dept,round(avg(age),2)as salary from Employess group by Dept;

select Dept,sum(salary)as totalSalary from Employess group by Dept
	
select count(EmpID),city  from Employess group by city order by count(EmpId) desc

select year(Doj) as JioningDate, count(EmpID) from Employess Group by year(Doj) order by count(EmpID) desc


create table c_product(productId int ,price float)

insert into c_product values(11,110.00),(12,455.00)

CREATE DATABASE