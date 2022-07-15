CREATE TABLE userdata (
    id int IDENTITY(1, 1),
    name nvarchar(200) ,
   mobile nvarchar(200),Address nvarchar(200),Designation nvarchar(200) ,FatherName nvarchar(200),EmailID nvarchar(200),DOB nvarchar(200)
);

create procedure insertdata
@name nvarchar(200),
@mobile nvarchar(200),@Address nvarchar(200),@Designation nvarchar(200),@FatherName nvarchar(200),@EmailID nvarchar(200),@DOB nvarchar(200)
as
begin 
insert into userdata(name,mobile,Address,Designation,FatherName,EmailID,DOB)values(@name,@mobile,@Address,@Designation,@FatherName,@EmailID,@DOB);
end

select * from userdata;