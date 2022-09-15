use Rohit


Create Table  Tbl_Main(
id int  primary Key Identity,
Name nvarchar(50),
Email nvarchar(50) unique,
Password nvarchar(50),
Dob nvarchar(50),
Age int ,
Qualification  nvarchar(50),
State		   nvarchar(50),
City		   nvarchar(50),
Address	   nvarchar(50),
Photo		   nvarchar(50),
Profile nvarcHAR(50),
status  nvarcHAR(50)

)


Alter proc UserSingupData

@Name nvarchar(50),
@Email nvarchar(50),
@Password nvarchar(50),@pro nvarchar(50)
as 
begin 
insert into Tbl_Main(Name,Email,Password,Profile)values(@Name ,@Email ,@Password,@pro)
select 'msg' as success
end


ALTER proc UserSingFullDetails

@Dob nvarchar(50),
@Age int ,
@Qualification nvarchar(50),
@State		   nvarchar(50),
@City		   nvarchar(50),
@Address	   nvarchar(50),
@Photo		   nvarchar(50),
@Profile nvarcHAR(50),
@Email nvarchar(50)

as 
begin 
update Tbl_Main set Dob               =@Dob ,
					Age               =@Age ,
					Qualification     =@Qualification,
					State		      =@State,
					City		      =@City	,
					Address		      =@Address,
					Photo		      =@Photo	,
					Profile           =@Profile,
					Email             =@Email 
				 WHERE Email             =@Email 
select 'msg' as success
				end
aLTER PROCEDURE uSERCHECK
@Email nvarchar(50),
@Pwd nvarchar(50)
 AS
BEGIN
sELECT * FROM Tbl_Main WHERE Email =@Email AND Password=@Pwd 
END


Create PROCEDURE AdminCHECK
@Email nvarchar(50),
@Pwd nvarchar(50),@pro nvarchar(50)
 AS
BEGIN
sELECT * FROM Tbl_Main WHERE Email =@Email AND Password=@Pwd and Profile =@pro 
END


create proc AllAdmin
as
begin
select * from  Tbl_Main
end


create proc UserDatacheck
@Email nvarchar(50),
@Pwd nvarchar(50)
as
begin
select * from  Tbl_Main where Email=@email And Password=@Pwd 
end

truncate Table Tbl_Main

UserDatacheck 'Admin@gmail.com','123'