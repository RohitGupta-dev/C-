use salary
TRUNCATE TABLE emptable
create table emptable(
ID int,
Name nvarchar(30),
Designation nvarchar(10),
Salary float,
Status int)

Insert into emptable(ID ,Name ,Designation ,Salary )values (1,'rohit','trainer',102.09)
Insert into emptable(ID ,Name ,Designation ,Salary )values (4,'Rajat','Dev',1022.09),(5,'Mohan','pr',3022.09)

select top 3 * from emptable where Status=0 and Salary>13  order by Salary desc

alter table emptable
add constraint df_emp_status
default 0 for Status

alter table emptable
add constraint df_emp_status

alter TABLE
  emptable
ALTER COLUMN
  ID
    INT NOT NULL;

ALTER TABLE emptable
ADD CONSTRAINT PK_emptable PRIMARY KEY (ID);

alter table emptable
add constraint df_designation
default 'intern' for Designation

Insert into emptable(ID ,Name  ,Salary )values (1,'Rohit',20.09)

SELECT * FROM emptable WHERE  Salary = (SELECT  MAX(Salary) FROM emptable)
 
