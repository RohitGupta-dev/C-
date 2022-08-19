select * from tireItems

create proc getName 
@Name nvarchar(200)
as
begin
select * from tireItems where name = @Name
end
getName 'rohit'