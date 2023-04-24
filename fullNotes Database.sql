// Table Create Syntax:
-----------------------
create table table_Name(data_Name Data_TYpe);
..............................................
Ex:
---
create table emp(
id number(3),
name varchar(50),
add varchar(50)
);
=============================================================================================
View Data_TYpe table for use describe keyword.
------------------------------------------------
Syntax:
describe table_Name;
or desc table_Name;
=============================================================================================
table width and height set ;
-------------------------------------------------
syntax:
-------
set linesize 200;
set pagesize 20;
=============================================================================================
Create New table from copy last table:
----------------------------------------------------------------------------------------------
Syntax:
--------
create table neworder as(select * from order_p);
==============================================================================================
Use of ALTER Command:
-----------------------------------------------------------------------------------------------
If we want to modification in table structure then we have to use alter command.
...............................................................................................
Add syntax:
-----------
alter table <table-name> add <column-name> <data-type>;
Ex:
alter table order_p add mobile_number varchar2(15);
---------------------------------------------------
Delete Syntax:
--------------
alter table <table-name> drop column <column-name>;
Ex:
alter table order_p drop column mobile_number;
----------------------------------------------------
Modify Syntax:
--------------
alter table <table-name> modify <column-name> <data-type>;
Ex:
alter table order_p modify mobile_number number(12);
----------------------------------------------------
Modify Syntax2:
----------------
alter table <table-name> rename <column-name> to <new name:>;
alter table order_p rename column mobile_number to mobno;
==============================================================================================
Rename table name:
-------------------
syntax:
-------
rename table-name to new_table-name;
ex:
rename order_p to myorder;
Syntax2:
--------
alter table table-name rename to new_table-name;
Ex:
---
alter table myorder rename to abc;
===============================================================================================
Use of INSERT Command to insert record into the table
-----------------------------------------------------------------------------------------------
SYNTAX :
-------
insert into <table-name> values(<value 1>,<value2>,….);
EXAMPLE 
-------
insert into employee values(‘1001’,’Ajay Singh’,’12-Jan-2012’,45000);
.....................................................................
insert into neworder values(01,’Atul Kumar’,’KLP’,2,201928);
insert into neworder values(02,’Ahira’,’AJM’,5,2023928);
insert into neworder values(03,’Hiteshwa’,’KLP’,6,256430);
-----------------------------------------------------------------------------------------------
Only insert some column:
----------------------------------------------------------------------------------------------
syntax:
-------
insert into neworder(order_id,quantity,product_id) values(103,2,200384);
==============================================================================================
Show the table record command:
----------------------------------------------------------------------------------------------
select * from table-name;
==============================================================================================
insert into neworder(order_id,quantity,product_id) values(&order_id,&quantity,&product_id);
==============================================================================================
use commit;command save record
==============================================================================================
create table order_test
(
 order_id number(10),
 cus_name varchar2(50),
 adress varchar2(250)
);
insert into order_test(order_id,cus_name,adress) select order_id,cus_name,adress from neworder;
==============================================================================================
delete Command:
---------------
Syntax:
------
delete from order_test;
syntax2:
--------
delete from order_test where adress='KLP';
===============================================================================================
truncate table table-name;
-------------------------
all table record delete;
===============================================================================================
drop means table delete:
--------------------------------------
syntax:
------- 
drop table table-name;
================================================================================================
file insert command:
------------------------------------------------------------------------------------------------
syntax: @ E://demobld.sql;
------------------------------------------------------------------------------------------------
syntax: desc all_tables;
================================================================================================
View all system table:
------------------------------------------------------------------------------------------------
syntax:select*from all_tables;
================================================================================================
syntax: select table_Name,owner from all_tables;

select table_Name,owner from all_tables where owner='SYSTEM';

desc user_tables;

select table_Name from user_tables;
================================================================================================

select * from salgrade;
================================================================================================
update emp set deptno=10 where empno=7521;
================================================================================================
update emp set job='MANAGER where empno=7844;
================================================================================================
select job from emp;
===============================================================================================
duplicate file no view use distinct command;
---------------------------------------------------------------------------------------------
select distinct job from emp;
================================================================================================
select empno,ename from emp;
=======================================
Temprary name creation:
----------------------------------------
select empno,ename as name from emp;
=========================================
select * from dept;
select deptno,dname from dept;
=============================================================================================
Use of order by
----------------
“order” and “by” both are the keywords. The order by used to display records in ascending and descending order.
----------------
EXAMPLE Select * from employee order by empname;
Note: After that all records are displayed in ascending order such as alphabetical order (A, B, C,….).
For descending order
--------------------
EXAMPLE Select * from employee order by empname desc;

Note: After that all records are displayed in sorted form of descending order such (Z, Y, X,….).
===============================================================================================
aggegate function:
-----------------------------------------------------------------------------------------------
1) sum()
2) max()
3) avg()
4) count()
5) min()
6) sqrt()
...............................................................................................
group by clouse:It used to collect data from multiple rows:
-----------------------------------------------------------------------------------------------
=> Group by means  all add group:
Syntax:
-------
select deptno,sum(sal) from emp group by deptno;
select deptno,count(deptno),sum(sal) from emp group by deptno;
select deptno,count(deptno) as No_Of_Employees,sum(sal) from emp group by deptno;
=============================================================================================
total number of record table:
-----------------------------------------------------------------------------------------------
syntax: select count(deptno) from emp;
==============================================================================================
select job,count(job) from emp group by job;
-----------------------------------------------------------------------------------------------
Used Min() function:
--------------------
Syntax: 
select deptno,min(sal) from emp group by deptno;
-----------------------------------------------------------------------------------------------
Used avg() function:
--------------------
Syntax: 
select job,avg(sal) from emp group by job;
================================================================================================
select job,ename,avg(sal) from emp group by job,ename order by job,ename;          
================================================================================================
Having clouse:It us used to validate result of 
------------------------------------------------------------------------------------------------
select job,sum(sal) from emp group by job having count(job)>2;
select job,count(job),sum(sal) from emp group by job having count(job)>2;
select job,count(job),sum(sal) from emp group by job having sum(sal)>2000;
===============================================================================================
select Clouse:
----------------------------------------------------------------------------------------------
=> It is used to fetch the data from a specific table ,We can also apply filters while fetching 
-----------------------------------------------------------------------------------------------
Syntax:
-------
select ename,sal+200 from emp;
select * from emp where sal>3000;
..........................................
 use and clouse:
------------------------------------------ 
select * from emp where deptno=30 and sal>1000;
select * from emp where deptno=30 and (sal>1000 and job='SALESMAN');
select * from emp where deptno=30 or sal=1500;
select * from emp where ename='SMITH' or (deptno=30 and sal>1000);
===============================================================================================
select * from emp group by deptno where ename='SMITH' or (deptno=30 and deptno10);
==============================================================================================
select * from emp where ename='SMITH' or (deptno=30 and sal>1000) order by ename;
...............................................................................................
select * from emp where comm is null;
select * from emp where comm is not null;
select * from emp where comm>300 and comm<1200;
select * from emp where comm between 300 and 1200;
select * from emp where sal between 300 and 1200 or(ename='SMITH');
===============================================================================================
Like operator:
-----------------------------------------------------------------------------------------------
select * from emp where ename like 'JA%';
select * from emp where ename like '%EN';
select * from emp where ename like 'S_H%';
searching from ORACLE :
select * from demo where ename like '%bi%(middle)';
select * from demo where ename like 'a%(starting)'; or '%a(last)';
select * from demo where ename like 'b_a%(first chR B AND LAST CHAR A)';
select * from demo where ename like 'A_U_';
select * from emp where ename like '____IN%';
select * from emp where ename not like '____IN%';
===============================================================================================
Constraints:
-------------
=> Constraints are facility to apply rules for inserting only valid values in table.

1) Not NULL Constraint:
--------------------
=> It will prevent to insert null value on a specific column.
EX:
---
create table employee1
(
 emp_id number(5) not null,
 emp_name varchar2(50) not null,
 mob_no varchar2(12),
 address varchar2(200)
);
insert into employee(emp_id,mob_no,address) values(101,8707252768,'KTP');
-----------------------------------------------------------------------------------------------
2) unique:
-----------
=> It is used to prevent duplicate values/record into table.

EX:
---
create table employee2
(
 emp_id number(5) unique,
 emp_name varchar2(50),
 mob_no varchar2(12),
 address varchar2(200)
);
insert into employee2(emp_id,mob_no,address) values(101,8707252768,'KTP');
-----------------------------------------------------------------------------------------------
3) auto increment(not supported in oracle):
--------------------------------------------
=> 
create table employee3
(
 emp_id int(5) auto increment,
 emp_name varchar2(50),
 mob_no varchar2(12),
 address varchar2(200)
);
insert into employee2(emp_id,mob_no,address) values(101,8707252768,'KTP');
------------------------------------------------------------------------------------------------
4) primary Key:
----------------
=> It is used to uniquly identify record in a table .
=> primary key is a combination of unique and not null constraints.
EX:
create table employee4
(
 emp_id number(5) primary key,
 emp_name varchar2(50),
 mob_no varchar2(12),
 address varchar2(200)
);
insert into employee4(emp_id,mob_no,address) values(101,8707252768,'KTP');
EX2:
create table employee5
(
 emp_id number(5),
 emp_name varchar2(50),
 mob_no varchar2(12),
 address varchar2(200),
 constraint test primary key(emp_id)
);
------------------------------------------------------------------------------------------------
5) foreign key:
---------------
=> primary key of one table into another table is known as foreign key.It is refrenced from primary key of another table.
EX:
create table salary1
(
 emp_id number(5) references employee5(emp_id),
 sal varchar2(10)
);
,,,,,,,,,,,,
create table salary2
(
empid number(5),
sal varchar2(10),
constraint test1
foreign key(empid)
references employee5(emp_id)
);
----------------------------------------------------------------------------------------------
6) check:
---------
=> It is used to check specific condition while insetring record in a table.
EX:
create table salary3
(
emp_id number(5),
sal varchar2(10) check(sal>5000)
);
insert into salary3 values(2900);
===============================================================================================
:join In Oracle:
-----------------------------------------------------------------------------------------------
=> join is a query that is used to fetch the data from multiple tables.

1) inner Join:
--------------
=> Retrieves records that have matching values in both tables involved in the join. This isthe widely used join for queries.

:Syntax:
SELECT * FROM Table_A INNER JOIN Table_B;
select * from Table_A inner join Table_B on Table_A.column=Table_B.column;
EX:
---
select * from emp inner join dept on emp.deptno=dept.deptno;
insert into dept values(95,'HEAD','KALPI');
INSERT INTO EMP VALUES(7169, 'ATUL', 'MANAGER',     7911, TO_DATE('17-DEC-2021', 'DD-MON-YYYY'),  67000,  NULL, 90);
-----------------------------------------------------------------------------------------------
2) outer join:
--------------
A) left outer join
-------------------
=> Retrieves all the records/rows from the left and the matched records/rows fromthe right table.

:syntax:
-------
SELECT * FROM Table_A A LEFT JOIN Table_B B ON A.col=B.col;
select * from emp left outer join dept on emp.deptno=dept.deptno;
select emp.empno,emp.ename,emp.deptno,dept.dname,dept.loc from emp left outer join dept on emp.deptno=dept.deptno;
...............................................................................................
B) right outer join
-------------------
=> Retrieves all the records/rows from the right and the matched records/rowsfrom the left table.

:syntax:
-------
SELECT * FROM Table_A A RIGHT JOIN Table_B B ON A.col=B.col;
select * from emp right outer join dept on emp.deptno=dept.deptno;
select emp.empno,emp.ename,emp.deptno,dept.dname,dept.loc from emp right outer join dept on emp.deptno=dept.deptno;
...............................................................................................
C) full outer join
-------------------
=> Retrieves all the records where there is a match in either the left or right table.

:syntax:
-------
SELECT * FROM Table_A A FULL JOIN Table_B B ON A.col=B.col;
select * from emp full outer join dept on emp.deptno=dept.deptno;

select emp.empno,emp.ename,emp.deptno,dept.dname,dept.loc from emp full outer join dept on emp.deptno=dept.deptno;
...............................................................................................
-----------------------------------------------------------------------------------------------
3) Equi join:
-------------
In this join we can fetch data from multiple tables by using where clouse.

:syntax:
-------
SELECT * FROM Table_A A , Table_B B where A.col=B.col;
select * from emp, dept where emp.deptno=dept.deptno;
-----------------------------------------------------------------------------------------------
4) self join:
-------------
=> In this join a table can join by it self.

:syntax:
-------
SELECT * FROM Table_A A join Table_B B on A.col=B.col;
select a.ename,b.deptno from emp a join emp b on a.deptno=b.deptno;
-----------------------------------------------------------------------------------------------
5) cross join:
--------------
=>  Table_A * Table_B;

select * from emp cross join dept;
-----------------------------------------------------------------------------------------------
6) Anti join:
-------------
=> SELECT * from emp where not exists (SELECT * from dept where emp.deptno=dept.deptno);
-----------------------------------------------------------------------------------------------
6) semi join:
-------------
SELECT * from emp where exists (SELECT * from dept where emp.deptno=dept.deptno);
---------------------------------------------------------------------------------------------------------------
:Data_TYpe:
---------
varchar2
number
timestamp,date
===============================================================================================================
               wpx                                 :PL/SQL:
---------------------------------------------------------------------------------------------------------------	
=> PL/SQL stands for Procedural Language [Extension] of SQL. It provides programming language functionality to SQL.
   It is introduced in oracle 7.
   
EX:
---
Begin
dbms_output.put_line('Hello Oracle');
End;
/
----------------------------------------------------------------------------------------------------------------
Command Enable Server output to view program output:
----------------------------------------------------------------------------------------------------------------
set serveroutput on 
................................................................................................................
:Program:
................................................................................................................
Declare
a number:=10;
b number:=20;
c number;
begin
c:a+b;
dbms_output.put_line('Addition is: '||c);
end;
/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                 :Program Start:
.................................................................................................................
Begin
dbms_output.put_line('Hello Oracle');
End;
/
==============================================================================================================
Addition Program:
---------------------------------------------------------------------------------------------------------------
Declare
a number :=10;
b number :=10;
c number;
begin
c:=a+b;
dbms_output.put_line('Addition='||c);
end;
/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
Max Number Find:
---------------------------------------------------------------------------------------------------------------
Declare
a number:=10;
b number:=20;
Begin
if(a>b) then
dbms_output.put_line('Max Number Is='||a);
else
dbms_output.put_line('Max Number Is='||b);
end if;
end;
/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
:Table Print:
------------------------------------------------------------------------------------------------------------------
declare
a number:=&a;
b number:=1;
t number;
begin
while b<=10 loop
t:=a*b;
dbms_output.put_line(t);
b:=b+1;
end loop;
end;
/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
Use Switch Case:
Note:-Use & user input:
------------------------------------------------------------------------------------------------------------------
declare
day char:='&day';
begin
case day
when '1' then
dbms_output.put_line('Monday');
when '2' then
dbms_output.put_line('Tuesday');
when '3' then
dbms_output.put_line('Wednesday');
when '4' then
dbms_output.put_line('thursday');
when '5' then
dbms_output.put_line('Friday');
when '6' then
dbms_output.put_line('satarday');
when '7' then
dbms_output.put_line('Sunday');
else 
dbms_output.put_line('Invalid input:');
end case;
end;
/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
Program For Loop:
------------------------------------------------------------------------------------------------------------------
--Exit Loop--
declare
i number:=0;
begin
loop
exit when i>10;
dbms_output.put_line(i);
i:=i+1;
end loop;
end;
/
..................................................................................................................
---While loop---
declare
i number:=0;
begin
while i<=10 loop
dbms_output.put_line(i);
i:=i+1;
end loop;
end;
/
..................................................................................................................
---For loop---
declare
begin
for i in 1..10 loop
dbms_output.put_line(i);
end loop;
end;
/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
GOTO and CONTINUE read
------------------------------------------------------------------------------------------------------------------
2)CONTINUE statement
--------------------
=> Causes the loop to skip the remainder of its body and immediately retest its condition prior to reiterating.
EX:
---
begin 
for i in 1..10 loop 
if (i=5) then
continue;
end if;
dbms_output.put_line(i);
end loop;
end;
/
------------------------------------------------------------------------------------------------------------------
3)GOTO statement
----------------
=> The GOTO statement branches unconditionally to a statement label or block label. The label must be unique within its scope and must precede an executable statement or a PL/SQL block. The GOTO statement transfers control to the labelled statement or block. For more information, see "Using the GOTO Statement".

Syntax:
------
label declaration ::=
----------------------
Description of label_declaration
<<l1>>
Description of the illustration label_declaration
......................................................
EX:
---
Begin
goto l1;
dbms_output.put_line('Massage 1');
<<l1>>
dbms_output.put_line('Massage 2');
dbms_output.put_line('Massage 3');
dbms_output.put_line('Massage 4');
end;
/
..................................................................................................................
function in c Definition:
---------
=>A function is a group of statements that together perform a specific task.
-----------------------------------------------------------------------------------------------------------------
Procedural:- 
------------
=> In PL/SQL procedure is a block of statement that can perform a specific task.Procedural can have in,out,in out parameters. It can return a value or can't return a value.

create or replace procedure display(a in number)
is
begin
dbms_output.put_line('Hello Oracle:'||a);
end;
/
drop procedure display;
begin
DISPLAY(5);
end;
/

 ye DISCONNECT MOD hota hai 
------------------------------------------------------------------------------------------------------------------
create or replace procedure adder(num1 in number,num2 in number,res out number)
is
begin
res:=num1+num2;
end;
/
1)
declare
x number;
begin
adder(5,6,x);
dbms_output.put_line('Addition is ='||x);
end;
/
,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
2)
declare
a number:=5;
b number:=6;
x number;
begin
adder(a,b,x);
dbms_output.put_line('Addition is ='||x);
end;
/
----------------------------------------------------------------------------------------------------------------
create or replace procedure adder(num1 in number,num2 in number,res in out number)
is
begin
res:=num1+num2+res;
end;
/

declare
x number:=20;
begin
adder(5,6,x);
dbms_output.put_line('Addition is ='||x);
end;
/
-----------------------------------------------------------------------------------------------------------------
create or replace procedure tabler(num in number,res out number)
is 
begin
for i in 1..10 loop;
res:=num*i;
end loop;
end;
/

declare
x number;
begin
tabler(5,x);
dbms_output.put_line('Table Is:='||x);
end;
/
=============================================================================================================
create table std(
id number(5),
name varchar2(50)
);

create or replace procedure insertstd(id in number,name in varchar2)
is
begin
insert into std values(id,name);
dbms_output.put_line('Record insert successfully');
end;
/

begin
insertstd(5,'Atul');
end;
/
==================================================================================================================
Function:- 
-----------
=> In PL/SQL procedure is a block of statement that can perform a specific task.Function must return a value.
   it can have only input parameters and output statement(parameters),rest all is similar as procedure.

create or replace function mymax(a in number,b in number)
return number
is
res number;
begin
if(a>b) then
res:=a;
else
res:=b;
end if;
return res;
end;
/
drop function mymax;

declare
x number;
begin
x:=mymax(4,6);
dbms_output.put_line('Max Number is:'||x);
end;
/

===================================================================================================================
 -----------------------------------------------------------------------------------------------------------------
Trigger:
--------
=> In PL/SQL procedure is a block of statement that can execute automatacally when a specific event accorers.

insert:
-------
create or replace trigger test
before insert or update or delete on std
begin
dbms_output.put_line('Record successfully Inserted into stu table.');
end;
/

insert into std values(103,'Aman');
insert into std values(104,'BABA');

...............................................................................................................
delete:
-------
create or replace trigger test
before insert or update or delete on std
begin
dbms_output.put_line('Trigger successfully executable.');
end;
/

delete from std;

...............................................................................................................
Update:
-------
create or replace trigger test
before insert or update or delete on std
begin
dbms_output.put_line('Trigger successfully Update.');
end;
/

update table std set id=11 where name='BABA';
================================================================================================================

create or replace trigger noDropSTD
before drop on database
begin
if(ORA_DICT_OBJ_NAME='STD') then
RAISE_APPLICATION_ERROR(-20000,'Unauthorised drop action for table std.');
rollback;
end if;
end;
/

Error Number -20000 to -20999

drop table std;
drop trigger noDropSTD;
================================================================================================================
Sub Query:
----------
=> Query inside a query is called sub Query.By using sub Query we can use result of one query inside another query.
   It is also helpful to reduce the complexity of queries.
   
select max(sal) from emp;
select from emp where sal==5000;
select * from emp where sal(select max(sal) from emp);
=================================================================================================================
EX:1 CREATE TABLE
-----------------------------------------------------------------------------------------------------------------
create table myemp
(
id number(5),
name VARCHAR2(50),
address VARCHAR2(100)
);
INSERT INTO myemp VALUES(01,'SCOTT','US');
INSERT INTO myemp(id,name) VALUES('02','Suraj');
INSERT INTO myemp(id,name) VALUES(&id,'&name');
>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<
DESC myemp;
>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<
update myemp set address='KALPI' WHERE id=03;
UPDATE myemp set name='SMITH DOI',address='UK' WHERE id=02;
>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
DELETE from myemp where id=03; // DELETE ONLY id SELECTed
DELETE from myemp; //all RECORD DELETE in command.
>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
truncate TABLE myemp;//DELETEd no condition.
drop TABLE myemp;//trigger and procuser.
================================================================================================================
ex:2
-----------------------------------------------------------------------------------------------------------------
create table std1
(
id number(5),
name VARCHAR2(50),
course VARCHAR2(100)
);

ALTER TABLE std1 add mobno VARCHAR2(13);
ALTER TABLE std1 MODIFY id VARCHAR2(5);
ALTER TABLE std1 MODIFY (id VARCHAR2(6),name VARCHAR2(55),course VARCHAR2(20));
ALTER TABLE std1 drop column mobno;
ALTER TABLE sted1 RENAME column name to std_name;
ALTER TABLE std1 RENAME to mystd;

INSERT INTO std1 VALUES(01,'Atul','Btech');

file insert command:
------------------------------------------------------------------------------------------------
syntax: @ E://demobld.sql;

================================================================================================================
EX:3
----------------------------------------------------------------------------------------------------------------
inner join: common RECORD.
-----------
left join:   Left all RECORD and right matching RECORD.
right join:  right all RECORD and left matching RECORD.
full join:   Full RECORD.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
select *from emp;
SELECT * from dept;

SELECT * from emp inner join dept on emp.deptno=dept.deptno;//inner join
SELECT * from emp left join dept on emp.deptno=dept.deptno;//left join
SELECT * from emp right join dept on emp.deptno=dept.deptno;
SELECT * from emp full join dept on emp.deptno=dept.deptno;
SELECT emp.ename,emp.deptno,dept.dname,dept.deptno from emp full join dept on emp.deptno=dept.deptno;

insert into emp values(‘1001’,’Ajay Singh’,’12-Jan-2012’,45000);

INSERT INTO EMP VALUES(7368, 'JOHN', 'CLERK',     7901, TO_DATE('17-DEC-1990', 'DD-MON-YYYY'),  1200,  NULL, 50);
INSERT INTO dept VALUES(80,'Software','INDIA');
INSERT INTO dept VALUES(60,'IT','SOUTHINDIA');
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<
Equi join:
SELECT * from emp,dept where emp.deptno=dept.deptno;
SELECT * from emp,dept where emp.deptno=dept.deptno and sal>2000;
SELECT * from emp,dept where emp.deptno=dept.deptno ORDER by ename;
SELECT * from emp,dept where emp.deptno=dept.deptno ORDER by ename;
select * from emp where comm between 300 and 1200;
select * from emp where sal between 300 and 1200;
select * from emp where deptno between 10 and 20;
================================================================================================================
EX:4
----------------------------------------------------------------------------------------------------------------
procedure: VALUE RETURN krega bhi or na bhi.
function: VALUE RETURN krega.(output parameters ek hoga jabki input kai ho sakte hai.)

create or replace procedure display(a in number)
is
begin
dbms_output.put_line('Hello Oracle:'||a);
end;
/
drop procedure display;
begin
DISPLAY(5);
end;
/

create TABLE std1
(
id NUMBER(5),
name VARCHAR2(50),
course VARCHAR2(20)
);


create or replace procedure ins_emp(id in NUMBER,name in VARCHAR2,course in VARCHAR2)
is 
BEGIN
INSERT into std1 VALUES(id,name,course);
end;
/

BEGIN 
ins_emp(102,'SURAJ','DIPLOMA');
dbms_output.put_line('RECORD Save SUCCESSFULLY');
end;
/

=================================================================================================================
create or replace function myadda(a in NUMBER,b in NUMBER)
RETURN NUMBER
is 
c NUMBER(5);
BEGIN
c:=a+b;
RETURN c;
end;
/

DECLARE
r NUMBER(5);
BEGIN
r:=myadda(5,8);
dbms_output.put_line('Result='||r);
end;
/

////////////////////////////////
create or replace function mymax(a in number,b in number)
return number
is
res number;
begin
if(a>b) then
res:=a;
else
res:=b;
end if;
return res;
end;
/
drop function mymax;

declare
x number;
begin
x:=mymax(4,6);
dbms_output.put_line('Max Number is:'||x);
end;
/
==============================================================================================================
TRIGGER:
--------------------------------------------------------------------------------------------------------------
create or REPLACE trigger test11
BEFORE DELETE or UPDATE or INSERT on std1
BEGIN
dbms_output.put_line('RECORD Insert SUCCESSFULLY');
end;
/


