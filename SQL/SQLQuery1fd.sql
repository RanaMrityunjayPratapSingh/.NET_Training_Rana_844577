Create Database EmployeeEFDB;

Create Table Employee
(EmpID int Primary key, Name Varchar(30) not null, SSN bigint not null, 
Salary float not null, DepID int not null);



Create Table Department
(DepID int Primary key, Name Varchar(30) not null);


Alter Table Employee Add constraint FK_DepID FOREIGN KEY (DepID) 
references Department(DepID)

insert into Department values(1,'James');
insert into Department values(2,'Games');
insert into Department values(3,'Femes');

insert into Employee values(94,'Ranjeet',35484,500, 3);

select * from Department;
select * from Employee;