create table app_employDetails(id int primary key identity,employid int,genderid int,contactid int,addressid int)

create table app_employs(id int primary key identity,employname varchar(255))

create table app_employs_gender(id int primary key identity,employgender varchar(255))

create table app_employs_contact(id int primary key identity,employcontact varchar(255))

create table app_employs_address(id int primary key identity,employaddress varchar(255))


use Rohit

alter table app_employDetails  add constraint fk_employid foreign key(employid) references app_employs(id)

alter table app_employDetails  add constraint fk_genderid foreign key(genderid) references app_employs_gender(id)

alter table app_employDetails  add constraint fk_contactid foreign key(contactid) references app_employs_contact(id)


alter table app_employDetails  add constraint fk_address foreign key(addressid) references app_employs_address(id)



insert into app_employs 		values('tom john')
insert into app_employs_gender	values('male')
insert into app_employs_contact	values('9931233553')
insert into app_employs_address values('north Delhi')


select * from app_employs 		   
select * from app_employs_gender	
select * from app_employs_contact	
select * from app_employs_address  
select * from app_employDetails
insert into app_employDetails values(4,4,4,4),(5,5,5,5)

 

select e1.employname,e2.employgender,e3.employcontact,e4.employaddress from app_employDetails as m
join
app_employs as e1 on m.employid=e1.id
 join 
app_employs_gender as e2 on m.employid=e2.id
join
app_employs_contact as e3 on m.contactid=e3.id
join 
app_employs_address as e4  on m.addressid= e4.id
order by employaddress