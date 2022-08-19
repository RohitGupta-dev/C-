select * from OrderTbl
select * from personTbl
use Rohit
INSERT INTO personTbl values('r@gmai.com',3)
select * from personTbl where exists(select * from OrderTbl where personTbl.FId=OrderTbl.Id) UNION SELECT * FROM personTbl

select * from personTbl WHERE Name IN ('Rohit','Satyam','Sourav')

select id,name from personTbl where name like 'R%'

select id,name from personTbl where name like '%R%'

select id,name from personTbl where name like '%V'
select id,name from personTbl where name like '%r_h_t%'
select id,name from personTbl where name like '[r-s]%'


select id,name from personTbl where name like 'R%T'

select id,name from personTbl where name like '%_@_%'

select id,name from personTbl where name like '%@%'

select id,name from personTbl where name like '_@_'

select id,name from personTbl where name like '_@_%'
select id,name from personTbl where name like '_____@_%'
select id,name from personTbl where name like '%@_________%'
select id,name from personTbl where name like '%____@________%'
select id,name from personTbl where name like '%_@_%'

select * from personTbl where name like '_____v%'	

select *  from personTbl where id not between 1 and 5

select (id)  from personTbl 


select  * from personTbl  order by  rand() 

select  * from personTbl  order by  rand() 

	