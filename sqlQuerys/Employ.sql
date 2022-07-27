create dataBase RegestrationForm

create table Employ( id int primary key identity(1,1),Emp_name nvarchar(200),Emp_city nvarchar(200),Emp_Designation nvarchar(200),Emp_phone_number nvarchar(200), Emp_Email nvarchar(200));

select * from Employ;

create Procedure ShowEmploy
as
select * from Employ;


create Procedure InsertEmployDetails
@Emp_name nvarchar(200),@Emp_city nvarchar(200),@Emp_Designation nvarchar(200),@Emp_phone_number nvarchar(200), @Emp_Email nvarchar(200)
as
begin
insert into Employ(Emp_name,Emp_city,Emp_Designation,Emp_phone_number,Emp_Email)values(@Emp_name,@Emp_city,@Emp_Designation,@Emp_phone_number, @Emp_Email)
end

select * from tireItems;
