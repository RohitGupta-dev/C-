CREATE DATABASE  Triger;
use Triger;

create table customers(cust_id int ,age int,name varchar(30))

Create Trigger before_insert_empworkinghours   
BEFORE INSERT ON customers FOR EACH ROW  
BEGIN  
IF NEW.age < 0 THEN SET NEW.age = 0;  
END IF;


select * from customers

create trigger age_verify
before insert on customers
for each row 
if new.age < 0  then set new.age=0;
end if;

DELIMITER $$

CREATE TRIGGER before_workcenters_insert
BEFORE INSERT
ON customers FOR EACH ROW
BEGIN
    DECLARE rowcount INT;
    
    SELECT COUNT(*) 
    INTO rowcount
    FROM WorkCenterStats;
    
    IF rowcount > 0 THEN
        UPDATE WorkCenterStats
        SET totalCapacity = totalCapacity + new.capacity;
    ELSE
        INSERT INTO WorkCenterStats(totalCapacity)
        VALUES(new.capacity);
    END IF; 

END $$

DELIMITER ;

CREATE OR REPLACE TRIGGER display_salary_changes 
BEFORE DELETE OR INSERT OR UPDATE ON customers 
FOR EACH ROW 
WHEN (NEW.ID > 0) 
DECLARE 
   sal_diff number; 
BEGIN 
   sal_diff := :NEW.salary  - :OLD.salary; 
   dbms_output.put_line('Old salary: ' || :OLD.salary); 
   dbms_output.put_line('New salary: ' || :NEW.salary); 
   dbms_output.put_line('Salary difference: ' || sal_diff); 
END; 


CREATE TABLE Student_Trigger  
(  
Student_RollNo INT NOT NULL PRIMARY KEY,  
Student_FirstName Varchar (100),  
Student_EnglishMarks INT,  
Student_PhysicsMarks INT,   
Student_ChemistryMarks INT,  
Student_MathsMarks INT,  
Student_TotalMarks INT,  
Student_Percentage int );

CREATE TRIGGER Student_Table_Marks  
BEFORE INSERT  
ON  
Student_Trigger  
FOR EACH ROW  
SET new.Student_TotalMarks = new.Student_EnglishMarks + new.Student_PhysicsMarks + new.Student_ChemistryMarks + new.Student_MathsMarks,   
new.Student_Percentage = ( new.Student_TotalMarks / 400) * 100;  

INSERT INTO Student_Trigger (Student_RollNo, Student_FirstName, Student_EnglishMarks, Student_PhysicsMarks, Student_ChemistryMarks, Student_MathsMarks, Student_TotalMarks, Student_Percentage) VALUES ( 201,' Sorya', 88, 75, 69, 92, 0, 0);  

select * from Student_Trigger 