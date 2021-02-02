--select
select ContactName Adi,CompanyName Sirketadi,City Sehir from customers 

select*from Customers where City='Berlin'

--case insensitive
select*from Products where CategoryID=1 or CategoryID=3

select*from Products where CategoryID=1 and UnitPrice>=10

select*from Products where CategoryID=1 order by UnitPrice desc --ascending --descending

select count(*) from Products 

select categoryID,count(*) FROM Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, products.ProductName,Products.UnitPrice,Categories.CategoryName  from products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation object

select*from Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.orders=od.OrderID

select*from Customers c left join orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

--






