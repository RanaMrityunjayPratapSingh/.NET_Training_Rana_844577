create database rec;

use rec;
create table records (empid int not null, name varchar(50), 
salary float, Depid int,
primary key (empid));
insert into records values (1,'John',2000,11);
insert into records values (2,'sam',2200,12);
insert into records values (3,'raj',2400,13);
insert into records values (4,'Jam',2500,14);
insert into records values (0,'rancho', 210,15);
 select * from records;
 select depid, sum(salary) 'Total salary' from records
 group by depid
order by depid;
select max(salary) as max from records;
select Top(2) salary from records
order by salary asc;
order by salary desc;

alter table records change column salary pay(int);
update records set salary = paygfgh;
select * from records order by salary desc;

select name, len(name) as 'Length' from records;

select Upper(name) as 'Uppercase', 
Lower(name) as 'Lowercase' from records;

select name, substring(name,1,3) as 'partName' from records;

select SUBSTRING('Good Morning India',1,20);

select name, reverse(name) as 'name reverse' from records;

select replace('Good morning','Morning','Evening') 
as 'Greeting';

--sub queries
select empid,name,salary from records where salary > (select 
avg(salary) from records);

--Wrting sub-query from another table
select empid,name,salary, depid from records where depid = (select depid from Department 
where depname = 'techinal');

select empid,name.salary,depid from records where depid = (select depid from department where
depname= 'admin');