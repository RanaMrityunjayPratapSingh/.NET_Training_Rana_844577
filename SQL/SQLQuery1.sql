CREATE DATABASE Emps;

use emps;
 create table emplys (empId int not null primary key, 
 EmpName varchar(30) not null, 
 Sal float not null,DepId int not null);
  insert into emplys values(420,'Rancho',2500,421);
  insert into emplys values(421,'Raja',2600,422);
  insert into emplys values(422,'Ram',2700,423);
  insert into emplys values(423,'Ranjeet',2800,424);

  select * from emplys;
  select * from emplys where empid = 421;
  alter table emplys add email varchar(30);
  update emplys set email = 'ranamr@gmail.com' where empid = 420;
  update emplys set empname = 'Grain', sal= 3000 where empId = 422;
  select * from emplys where sal between 2500 AND 2800;
  select * from emplys where sal < 2600;
  select empid,empname from emplys where depid = 423;
  select top 2 * from emplys;
  select max(sal) as higst from emplys;
  select min(sal) as lowest from emplys;
  select count(empid) from emplys;
  select AVG(empid) from emplys;
  select sum(empid) from emplys;
  select * from emplys where EmpName like 'g%';
  select * from emplys where EmpName like '%__a';
  alter table emplys add dob varchar(30);
  select * from emplys;
  update emplys set dob = '22/07/1998' where empid = 420;
  alter table emplys drop column doj;
  alter table emplys add doj varchar(20);
