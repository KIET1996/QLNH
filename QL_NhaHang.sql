create database QL_NhaHang;
use QL_NhaHang;

--drop database QL_NhaHang;

Create Login mylogin 
	with password= 'mylogin',  
	CHECK_POLICY = OFF ;
sp_changedbowner mylogin;


create table Categories(
	ID_Ca int identity(1,1) primary key,
	name nvarchar(100) -- Name_Ca -> name
);

create table Dishes(
	ID_Dish int identity primary key,
	ID_Ca int not null,
	name nvarchar(100), --Name_Dish -> name
	unit nchar(30),
	price float not null,
	sta bit, -- Status_Dish -> sta
	descript ntext,
	constraint fk_Dish_Cate foreign key (ID_Ca) references Categories(ID_Ca)
);

create table Position_Table(
	ID_Pos int identity primary key,
	position nvarchar(100) not null,
	sta nchar(50) not null, --Có nhiều trạng thái ghi bằng text nên t k để kiểu bit Status_Pos -> sta
	note nvarchar(100) -- Note_Pos -> note
);

create table Table_Management(
	ID_Table int primary key,
	capability int,
	sta bit, --Status_Table -> sta
	ID_Pos int not null,
	constraint fk_Table foreign key (ID_Pos) references Position_Table(ID_Pos) 
);

create table Employee(
	ID_Emp int identity primary key,
	name nvarchar(100) not null, -- Name_Emp -> name
	Gender bit,
	addr nvarchar(100) not null, -- Address_Emp -> addr
	phone nvarchar(15) not null, --Phone_Emp ->phone
	DoB date -- DoB_Emp ->DoB
);

create table Customer(
	ID_Cus int identity primary key,
	name nvarchar(100) not null, -- Name_Cus -> name
	phone nvarchar(15) not null, -- Phone_Cus -> phone
	addr nvarchar(100) not null --address_Cus -> addr
);

create table Discount(
	ID_Dis int identity primary key, -- Tu tang luon
	per float,
	descript varchar(25), 
	start Date,
	finish Date,
	sta bit
);

create table Bill(
	ID_Bill int identity,
	ID_Emp int ,
	ID_Table int,
	Time_Arrive datetime ,
	Time_Payment datetime,
	ID_Dis int, --Discount
	sta bit,
	Total_price float(20) not null,
	constraint PK_Bill primary key (ID_Bill),
	foreign key (ID_Emp) references Employee(ID_Emp),
	foreign key (ID_Table) references Table_Management(ID_Table),
	constraint fk_Discount_Dish foreign key (ID_Dis) references Discount(ID_Dis),
); 

create table Bill_Details(
	ID_Detail int identity not null, -- Tu tang di
	ID_Bill int not null,
	ID_Dish int not null,	
	Quantity int not null,
	constraint PK_Bill_Detail primary key (ID_Detail),
	constraint fk_BillDetails_Bill foreign key (ID_Bill) references Bill(ID_Bill),
	constraint fk_BillDetails_Dish foreign key (ID_Dish) references Dishes(ID_Dish)
);


Create table Account(
	userName nchar(50) primary key,
	passwd nchar(20),
);


insert into Categories values ('Kho');
insert into Categories values ('Chien');
insert into Categories values ('Xao');
insert into Categories values ('Nuong');
insert into Categories values ('Lau');
select * from Categories;

insert into Dishes values (1,'Ca kho', 'phan', 15000, 1, 'Ngon');
insert into Dishes values (2, 'Trung chien',	'phan', 15000, 1, 'Ngon');
insert into Dishes values (3, 'Mi xao', 'dia', 35000, 1, 'Ngon');
insert into Dishes values (4, 'Thit nuong', 'phan', 55000, 1, 'Ngon');
insert into Dishes values (5, 'Lau thai', 'cai', 90000, 1, 'Ngon');
select * from Dishes;

insert into Position_Table values ('Tang tret', 'Trong','Khong');
insert into Position_Table values ('Tang 1', 'Trong','Khong');
insert into Position_Table values ('Tang 2', 'Trong','Khong');
insert into Position_Table values ('VIP1', 'Trong','Khong');
insert into Position_Table values ('VIP2', 'Trong','Khong');
select * from Position_Table;

insert into Table_Management values (1, 4, 0, 1);
insert into Table_Management values (2, 4, 0, 1);
insert into Table_Management values (3, 4, 0, 1);
insert into Table_Management values (4, 8, 0, 1);
insert into Table_Management values (5, 8, 0, 1);
insert into Table_Management values (6, 8, 0, 1);
insert into Table_Management values (7, 8, 0, 1);
insert into Table_Management values (8, 4, 0, 1);
insert into Table_Management values (9, 4, 0, 1);
insert into Table_Management values (10, 6, 0, 2);
insert into Table_Management values (11, 8, 0, 2);
insert into Table_Management values (12, 10, 0, 2);
insert into Table_Management values (13, 10, 0, 3);
insert into Table_Management values (14, 10, 0, 3);
insert into Table_Management values (15, 8, 0, 3);
insert into Table_Management values (16, 12, 0, 4);
insert into Table_Management values (17, 12, 0, 5);
select * from Table_Management;

insert into Employee values ('Tran Chien Thanh', 1,'Sao hoa', '0099112233', '1-9-1998');
select * from Employee;

insert into Discount values (0, 'Khong giam', '2020-5-1',null, 0);
insert into Discount values (5, 'Tren 4 nguoi', '2020-5-1','2020-5-10', 0);
insert into Discount values (7, 'Tren 6 nguoi', '2020-5-1','2020-5-10', 1);
select * from Discount;

-- insert into Bill values (1, 1, '2020-4-16', '2020-4-17', 1, 0, 0);
select * from Bill;

--insert into Bill_Details values ( 1, 1, 1);
--insert into Bill_Details values ( 1, 2, 1);
select * from Bill_Details;



-- Kiem tra login
create procedure QLNH_Login
	@user_name nchar(50), @pass_word nchar(20) 
as begin
	select * from Account where userName=@user_name and passwd=@pass_word
end
go

-- List danh sach ban
create procedure QLNH_ListTable
as begin
	select ID_Table, Capability, tm.sta, pt.position as Position
	from Table_Management tm join Position_Table pt on tm.ID_Pos=pt.ID_Pos
end
go

-- Them bill 
Create procedure QLNH_InsertBill
	@id_emp int, @id_table int
as begin
	Insert into Bill
		(
			ID_Emp,
			ID_Table,
			Time_Arrive,
			Time_Payment,
			ID_Dis,
			sta,
			Total_price
		)
	values (@id_emp, @id_table,GETDATE(), null, 1, 0, 0);
end
go

-- Cap nhat bill khi chon thanh toan 
Create procedure QLNH_CheckoutBill
	@id_bill int, @id_dícount int, @total float
as begin
	Update Bill
	set
		ID_Dis = @id_dícount,
		Time_Payment = GETDATE(),
		sta = 1,
		Total_price = @total
	where ID_Bill = @id_bill
end
go


-- Them chi tiet  bill, neu bill chua co mon A ton tai them moi, neu da ton tai 
-- mon A trong do tang so luong
Create procedure QLNH_InsertBillDetail
	@id_bill int, @id_dish int, @quantity int
as begin
	declare @isExist int
	declare @dishQuantity int = 1
	
	select @isExist=ID_Detail, @dishQuantity= Quantity from Bill_Details where ID_Bill=@id_bill and ID_Dish=@id_dish 
	 
	if (@isExist>0)
		begin
			declare @new int = @dishQuantity + @quantity
			if (@new>0)
				update Bill_Details
				set Quantity = @dishQuantity + @quantity
				where ID_Bill=@id_bill and ID_Dish=@id_dish
			else
				delete Bill_Details where ID_Bill=@id_bill and ID_Dish=@id_dish
		end
	else
		begin
			Insert into Bill_Details
				(
					ID_Bill,
					ID_Dish,
					Quantity
				)
			values (@id_bill, @id_dish, @quantity)
		end	
end
go




-- Tao trigger lang nghe khi ban bill_details duoc insert, update 
-- de biet ban co nguoi
CREATE TRIGGER QLNH_UpdateBillDetail
ON Bill_Details FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = ID_Bill FROM Inserted
	
	DECLARE @idTable INT
	
	SELECT @idTable = ID_Table FROM Bill WHERE ID_Bill = @idBill AND sta = 0
	
	UPDATE Table_Management SET sta = 1 WHERE ID_Table = @idTable
END
GO

-- Tao trigger lang nghe khi ban bill update status cua ban
-- chuyen ban ve trang thai trong
CREATE TRIGGER QLNH_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = ID_Bill FROM Inserted	
	
	DECLARE @idTable INT
	
	SELECT @idTable = ID_Table FROM Bill WHERE ID_Bill = @idBill
	
	DECLARE @count int = 0
	
	SELECT @count = COUNT(*) FROM Bill WHERE ID_Table = @idTable AND sta = 0
	
	IF (@count = 0)
		UPDATE Table_Management SET sta = 0 WHERE ID_Table = @idTable
END
GO

select * from Bill;
select * from Bill_Details;

delete Bill;
delete Bill_Details;
delete Table_Management;
drop data