create table Emp(id int ,name varchar(255),age int,salary int,genderid int)
create table Emp_Gen(id int primary key identity ,name varchar(255))
alter table Emp drop column id 

alter table Emp add constraint pr_idprimary primary key(id)

alter table Emp  add id int identity(1,1)

alter table Emp add constraint fk_gender foreign key(genderid) References EMp_Gen(id)

insert into Emp_Gen values('Male'),('Female'),('Others')

alter table Emp add constraint check_age check(age>0 and age <120)

alter table Emp add Constraint set_deault default  4 for genderid 