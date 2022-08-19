create table emps(id int primary key identity,name varchar(255), age int,rollno int,genderid int	)
create table epm2(id int primary key identity,name varchar(255))

alter table emps add constraint fk_gender foreign key(genderid)  references epm2(id)

insert into emps(name,age,rollno) values('rohit',17,34)
insert into emps values('rohit',17,34,2)
insert into epm2 values('')('female'),('Male'),('other')

select e1.name,age,rollno,e2.name from emps as e1 inner join epm2 as e2 on e1.genderid=e2.id

select e1.name,age,rollno,e2.name from emps as e1 full outer join epm2 as e2 on e1.genderid=e2.id

select e1.name,age,rollno,e2.name from emps as e1 left join epm2 as e2 on e1.genderid=e2.id

select e1.name,age,rollno,e2.name from emps as e1 right join epm2 as e2 on e1.genderid=e2.id

select e1.name,age,rollno,e2.name from emps as e1 cross join epm2 as e2-- on e1.genderid=e2.id

select e1.name,age,rollno,e2.name from emps as e1 left join epm2 as e2 on e1.genderid=e2.id where e1.genderid is null

select e1.name,age,rollno,e2.name from emps as e1 right join epm2 as e2 on e1.genderid=e2.id where e1.genderid is null

select e1.name,age,rollno,e2.name from emps as e1 full join epm2 as e2 on e1.genderid=e2.id where e1.genderid is null or e2.id is null

