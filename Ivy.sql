use master
GO

IF DB_ID('final') IS NOT NULL
BEGIN
	DROP DaTaBaSE final
END
GO

create database final
GO
use final
GO

create table product(
	productID varchar(10) not null,
	productName nvarchar(50),
	productQuantity float,
	supplier nvarchar(50),
	unit varchar(10),
	importPrice money,
	exportPrice money,
)
GO
create table ordering (
	orderID varchar(10) not null,
	ordererID varchar(10) not null,

	orderDate datetime,
	deliveryStatus varchar(20),
)

create table ordering_items(
	listID varchar(10) not null,
	productID varchar(10) not null,
	quantity float,
)
GO
create table export(
	billID varchar(10) not null,
	orderID varchar(10) not null,
	paymentStatus varchar(15),
	total money,
	exportTime datetime,
)
GO
create table import(
	billID varchar(10) not null,
	productID varchar(10) not null,

	quantity float,
	importTime datetime,
)
GO
create table account(
	[accID] varchar(10) not null,
	[Name] nvarchar(50),
	[Username] varchar(50) Unique,
	[Password] varchar(50),
	[address] varchar(100),
	[Phone] varchar(20),
	[Email] varchar(50),
	[Role] varchar(50)	--Accountant/Customer
)

GO

alter table product add constraint pk_product Primary key(productID)

alter table import add constraint pk_import Primary key(billID,productID)
alter table import add constraint fk_import foreign key(productID) references product(productID)

alter table account add Constraint pk_account Primary key(accID)

alter table ordering add constraint pk_ordering Primary key(orderID)
alter table ordering add constraint fk_ordering foreign key(ordererID) references account(accID)


alter table ordering_items add constraint pk_items Primary key(listID,productID)
alter table ordering_items add constraint fk_items foreign key(listID) references ordering(orderID)

alter table export add constraint pk_export Primary key(billID,orderID)
alter table export add constraint fk_export foreign key(orderID) references ordering(orderID)

GO
--Insert product
insert into product values('P00', N'Sâm Alipas', '200', N'Ecogreen', 'Box', 80000, 100000); 
insert into product values('P01', N'Fomeal', '200', 'TH Co', 'Box', 100000, 120000);
insert into product values('P02', N'Herbalife', '200', 'PepsiCo', 'Box', 120000, 125000); 
insert into product values('P03', N'Blossomy', '150', 'Coca-Cola', 'Box', 100000, 120000); 
insert into product values('P04', N'Nzpurehealth Propolis', '200', 'PepsiCo', 'Box', 100000, 150000); 
insert into product values('P05', N'Complete Multivitamin', '200', 'PepsiCo', 'Box', 100000, 150000); 
insert into product values('P06', N'Blackmores', '200', N'Nestlé', 'Box', 150000, 160000); 
insert into product values('P07', N'Collagen Glow', '220', 'URC Coporation', 'Box', 120000, 140000);
insert into product values('P08', N'Focus Factor', '200', 'PepsiCo', 'Box', 180000, 190000); 
insert into product values('P09', N'Viên Uống Otiv', '200', N'NesCafé', 'Box', 200000, 220000); 
insert into product values('P10', N'Warrior', '300', 'Pharmaceutical Co', 'Box', 150000, 160000); 
GO
--Insert account
insert into account values('A00', N'Nguyễn Minh Trí', 'accountant1', 'accountant1', N'37/22 Bùi Minh Trực', '0900000000', 'trigpm@gmail.com', 'accountant');
insert into account values('A01', N'Đặng Nhật Tường Vy', 'accountant2', 'accountant2', N'37/2 Nguyễn Văn Quá', '0900000001', 'ivydang2010@gmail.com', 'accountant');
insert into account values('A02', N'Kỳ Quý Grocery', 'kyquy', 'kyquy', N'73/22 Bùi Minh Trực', '0902535412', 'kyquy@gmail.com', 'customer');
insert into account values('A03', N'Hòa Phát Grocery', 'hoaphat', 'hoaphat', N'82/22 Phạm Thế Hiển', '0902235412', 'kyquy@gmail.com', 'customer');


--Insert order
insert into ordering values('O00', 'A02', '12-28-2021', 'Pending'); 
insert into ordering values('O01', 'A03', '12-29-2021', 'Pending');
insert into ordering values('O02', 'A02', '1-1-2022', 'Pending');  

--Insert ordering_items
insert into ordering_items values('O00', 'P00', 10);
insert into ordering_items values('O00', 'P01', 12);
insert into ordering_items values('O00', 'P04', 20);
insert into ordering_items values('O01', 'P09', 30);
insert into ordering_items values('O01', 'P010', 12);
insert into ordering_items values('O01', 'P08', 5);

--Insert export
--insert into export values('E00', 'O00', 'Paid' , 0, '1-1-2022');

--Insert import 
insert into import values('I00', 'P00', 100, '12-22-2021');
insert into import values('I00', 'P01', 100, '12-22-2021');
insert into import values('I00', 'P03', 100, '12-22-2021');
insert into import values('I01', 'P04', 150, '12-23-2021');
insert into import values('I01', 'P05', 150, '12-23-2021');
insert into import values('I02', 'P06', 150, '12-24-2021');
insert into import values('I02', 'P07', 150, '12-24-2021');
insert into import values('I02', 'P08', 150, '12-24-2021');
insert into import values('I03', 'P09', 150, '12-24-2021');
insert into import values('I03', 'P10', 150, '12-24-2021');

GO

create proc addinImport(@billID varchar(10), @mahanghoa varchar(10), @quantity float)
as
begin
	Insert into import(billID, productID, quantity, importTime) values (@billID, @mahanghoa, @quantity, GETDATE());
End
GO

create proc addinOrder(@listID varchar(10), @productID varchar(10), @quantity float)
as
begin
	Insert into ordering_items(listID, productID, quantity) values (@listID, @productID, @quantity)
End
GO

GO
create proc importExecute(@billID varchar(10))
as
begin
	declare @rowcount int
	select @rowcount = Count(*) from import where billID = @billID

	declare @i int
	set @i = 1
	while @i <= @rowcount
	begin
		declare @productID varchar(10)
		select @productID = im1.productID
		from import im1, 
			(select productID, ROW_NUMBER() OVER(ORDER BY im2.productID Asc) AS [row] 
				from import im2 
				where im2.billID = @billID) countRow
		where im1.billID = @billID and countRow.[row] = @i and im1.productID = countRow.productID
		order BY im1.productID Asc

		declare @quantity int
		select @quantity = quantity from import Where billID = @billID and productID = @productID

		Update product Set productQuantity = productQuantity + @quantity where productID = @productID

		Set @i = @i+1
	End
End
GO

create proc exportExecute(@orderid varchar(10))
as
begin
	declare @rowcount int
	declare @total  money
	Set @total = 0 
	select @rowcount = Count(*) from ordering_items where listID = @orderid

	Declare @exportid varchar(10)
	set @exportid = ''
	While @exportid = ''
	Begin
		Declare @tmpid varchar(10)
		Set @tmpid = 'E'+ Upper( Left( Replace( Newid(),'-',''),9) )

		If Not Exists(Select Top 1 1 From export Where billID = @tmpid)
		Begin
			Set @exportid = @tmpid
		End
	End

	declare @i int
	set @i = 1
	while @i <= @rowcount
	begin
		declare @productID varchar(10)
		select @productID = oi.productID
		from ordering_items oi, 
			(select productID, ROW_NUMBER() OVER(ORDER BY oi2.productID Asc) AS [row] 
				from ordering_items oi2 
				where oi2.listID = @orderid) countRow
		where oi.listID = @orderid and countRow.[row] = @i and oi.productID = countRow.productID
		order BY oi.productID Asc

		declare @quantity int
		select @quantity = quantity from ordering_items Where listID = @orderid and productID = @productID

		Declare @price money
		select @price = exportPrice from product Where productID = @productID

		Set @total += @price * @quantity
		Update product Set productQuantity = productQuantity - @quantity where productID = @productID

		Set @i = @i+1
	End

	Insert into export Values (@exportid,@orderid,'Pending',@total,getdate())

	Update ordering Set deliveryStatus = 'Done' Where orderID = @orderid
End
GO

select orderID, p.productName [Pname], quantity , orderDate From ordering
left join ordering_items oitems on ordering.orderID = oitems.listID 
left join product p on p.productID = oitems.productID
GO
 
exec dbo.addinImport 'I00','P04',100
select * From import
GO

select * From ordering
select * From ordering_items
--exec dbo.addinOrder 'P06', 20
GO

select * From product
exec dbo.importExecute 'I00'
select * From product
GO
select * from import
GO
/*
select * From product
exec dbo.exportExecute 'O01'
select * From product
GO
*/
select * from export
GO

select ex.billID, p.productID, p.productName, oi.quantity, exportTime
From ordering, ordering_items oi, product p, export ex
where ordering.orderID = oi.listID and oi.productID = p.productID and ex.orderID = ordering.orderID
GO
select * from product
GO

select i.billID, p.productID, p.productName, i.quantity, i.importTime
from product p, import i
where p.productID = i.productID
GO

-- Export
/*
select o.orderID,o.ordererID, o.orderDate
from ordering o
where deliveryStatus ='Pending'
GO
select oi.productID, p.productName, p.exportPrice
from ordering o, product p,ordering_items oi
where o.ordererID = 'A02' and o.orderID = oi.listID and oi.productID = p.productID
GO
*/

