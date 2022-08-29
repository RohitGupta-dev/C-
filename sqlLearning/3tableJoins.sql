-- 3 table relation 1-2 ,2-3 
use Rohit
create table student(id int primary key identity,name nvarchar(255),age int,city nvarchar(255))

create table table_course(id int primary key identity,courseName nvarchar(255),teacherid int)

create table table_students_courses(studentcouseid int,courseid int)

create table table_teacher(id int primary key identity,name nvarchar(255),lastname nvarchar(255))



alter table table_students_courses add constraint fk_studentcouseid foreign key(studentcouseid) references student(id)

alter table table_students_courses add constraint fk_courseid foreign key(courseid) references table_course(id)

alter table table_course add constraint fk_teacherid foreign key(teacherid) references table_teacher(id)

insert into table_teacher values('Doris','Wilson'),('Amy ','Smith'),('Geraldine ','Carpenter'),('Edna','Francis')



 insert into table_course values('Python',1),('C#',2),('Sql',3),('Andriod',4)
 insert into student values('Rohit',22,'Rajpura'),('Mohit',31,'Chd'),('Mohan',27,'Delhi')


 use Rohit_2

 select * from rev
 select * from revgen
 --delete  from rev where id in (11,12)
 --insert into rev values('same',null,21,9)

  select r1.name,r2.name from rev as r1  right join revgen as r2 on r1.genderid=r2.id

  
  select r2.name, r1.name from revgen as r1  right join rev as r2 on r1.id=r2.genderid
                   