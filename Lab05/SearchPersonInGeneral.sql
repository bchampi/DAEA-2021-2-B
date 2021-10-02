create proc SearchPersonInGeneral
 @input nvarchar(50)  
as   
	select * from Person where PersonID like '%'+ @input + '%' or
	FirstName like '%'+ @input + '%' or 
	LastName like '%'+ @input + '%';