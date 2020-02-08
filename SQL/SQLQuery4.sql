use northwind;

Create Procedure GetCustomersByCountrys (@country varchar(30))
As
Select CustomerID,ContactName,Companyname,Address,Country from Customers Where Country = @country;
Go
Execute GetCustomersByCountrys'USA'


Create Procedure GetProductsByCategoryIDe (@categoryID int)
As
Select p.ProductId, p.ProductName,p.UnitPrice,p.QuantityPerUnit,
c.CategoryID,c.CategoryName from Products p INNER JOIN Categories
c ON p.CategoryID = c.CategoryID AND c.CategoryID = @CategoryID;
Go
Execute GetProductsByCategoryIDe 2;



--Declaring Local Variable

Declare @country as Varchar(30);
Set @country = 'France';
Select * from Customers where Country = @country;

Alter Procedure GetTotalOrdersByDatess
(@date1 date,@date2 date,@CountOrder int output)
As
Select @countOrder = Count(OrderID) from Orders Where OrderDate Between 
@date1 And @date2;
Go

Declare @count as int;

Declare @date1 as date, @date2 as date;

set @date1 ='01/01/1990';
set @date1 ='12/31/1998';

Execute GetTotalOrdersByDatess  @date1,@date2,@Count output;
print 'Total number of orders placed : ' + Convert(varchar(10),@count);
print GetDate();
--select * from Orders;


--creatin function

-- by default this function is strored inside the default Schema Known as 'dbo' 
--which stands for database
 
alter function Multy(@n1 int, @n2 int) Returns bigint
As 
Begin
Declare @prod as bigint
Set @prod = @n1*@n2;
Return @prod;

End

Select dbo.Multy(50,80) as Product;


--Table valued function

Create function GetCustomers(@country varchar(30)) Returns Table
As
Return Select * from Customers where Country = @Country;
Go

select * from dbo.GetCustomers('Germany');

---Creating function and performing joins

Create function GetProductsByCategory(@categoryID int) Returns Table
As
Return Select p.ProductId, p.ProductName,p.UnitPrice,p.QuantityPerUnit,
c.CategoryID,c.CategoryName from Products p INNER JOIN Categories
c ON p.CategoryID = c.CategoryID AND c.CategoryID = @CategoryID;


Select * from dbo.GetProductsByCategory(5);



--SubQueies

--1. A subqueries is used as part ofd a main query and value return from the 
--subquery will be used by the main query for its excuition

--2. Sometimes a subquery is used in-place of JOIN operations to combin two table
-- but JOINs are prefered over subquerys because of their effiencey


Select ProductID, ProductName, UnitPrice, QuantityPerUnit, CategoryID from 
Products where UnitPrice > (Select AVG(UnitPrice) from Products) Order By UnitPrice;

select * from Orders;

Select OrderID,CustomerID,EmployeeID,OrderDate,ShippedDate from Orders where 
OrderID = (Select OrderID from Orders where EmployeeID = 5 AND CustomerID='VINET');



-- Correlated Subqueries

-- A correlated subqueries doesn't return any data back to main query.But it allways 
--return a boolean value of either 'true' or 'false' and accordingly tha main query
-- get excuited if it receives a boolean valuie of true, otherwise, tha main query
-- will not be excuited 

Select CustomerID, CompanyName,Address, Country from Customers where EXISTS 
(Select ContactName from Customers where Country = 'Russia');




