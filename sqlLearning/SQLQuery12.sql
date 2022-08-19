 use salary

 create table salary_Emp(id int primary key identity,name varchar(200),salary float,doj date,updateon timestamp,status int )

 select top 2* from salary_Emp  ORDER BY salary desc
 insert into salary_Emp(name,doj) values('fhfgh','2080-09-18')


 alter table salary_Emp add constraine jdfls defalut as 1;

 ALTER TABLE salary_Emp
ADD CONSTRAINT df_City
DEFAULT 1 FOR salary;


	 ALTER TABLE salary_Emp
	ADD CONSTRAINT df_status
	DEFAULT 0 FOR status;









