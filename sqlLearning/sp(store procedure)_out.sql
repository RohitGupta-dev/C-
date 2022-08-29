create table tbl_c(id int ,name nvarchar(200))

alter table tbl_c alter column id int not null

alter table tbl_c add primary key(id) 

alter table tbl_c add rollno int


create table tbl_d(id int primary key identity,gender nvarchar(10))

alter table tbl_c add constraint fk__genderid foreign key(genderid) references tbl_d(id)

insert into tbl_c (id,name)values(9,null)

insert into tbl_c values(8,null)
insert into tbl_d values('male'),('female'),('other')

alter table tbl_c add constraint  df_genderid default 1 for genderid

select c.name,d.gender from tbl_c as c inner join tbl_d as d on c.genderid=d.id

select COALESCE(c.name,'Execption'),COALESCE(c.rollno,11),COALESCE(d.gender,'notMention' )from tbl_c as c left join tbl_d as d on c.genderid=d.id
select isnull(c.name,'eugffegfs'),isnull(c.rollno,15),isnull(d.gender,'notMention' )from tbl_c as c left join tbl_d as d on c.genderid=d.id


select c.name,COALESCE(c.rollno,11),COALESCE(d.gender,'notMention' )from tbl_c as c left join tbl_d as d on c.genderid=d.id
select isnull(c.name,'eugffegfs'),isnull(c.rollno,15),isnull(d.gender,'notMention' )from tbl_c as c left join tbl_d as d on c.genderid=d.id


select * from tbl_c
select * from tbl_d
select name from tbl_c union select gender from tbl_d
select gender  from tbl_d union  select name  from tbl_c
select name from tbl_c union all select gender from tbl_d
select gender  from tbl_d union all select name  from tbl_c
	
--alter proc selectall @name nvarchar(255) out as begin  select name from tbl_c where id=1 end

alter proc selectall @name nvarchar(255) out ,@id int as begin  select name from tbl_c where id=@id end

Declare @Employee int
Execute selectall 1
Print @Employee

sp_help tbl_c
sp_helptext  selectall
sp_depends  selectall



alter Procedure spGetEmployeeCountByGender
@Gender nvarchar(20),
@EmployeeCount int Output
as
Begin
 Select @EmployeeCount = COUNT(*) from tbl_d  where gender = @Gender 
End


Declare @EmployeeTotal int
Execute spGetEmployeeCountByGender 'male', @EmployeeTotal output
Print @EmployeeTotal





alter proc selectall @name nvarchar(255) out  as begin  select @name=name from tbl_c where id=1 end

Declare @Employee int
Execute selectall 'dfskl'
Print @Employee
