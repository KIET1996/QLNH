create database QL_NhaHang;
use QL_NhaHang;

--drop database QL_NhaHang;

Create Login mylogin 
	with password= 'mylogin',  
	CHECK_POLICY = OFF ;
sp_changedbowner mylogin;


create table Categories(
	ID_Ca int identity(1,1) primary key,
	name nvarchar(100) 
);

create table Dishes(
	ID_Dish int identity primary key,
	ID_Ca int not null,
	name nvarchar(100), 
	unit nchar(30),
	price float not null,
	sta bit, 
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
	ID_Table int identity primary key,
	capability int,
	sta bit, --Status_Table -> sta
	ID_Pos int not null,
	constraint fk_Table foreign key (ID_Pos) references Position_Table(ID_Pos) on delete cascade on update cascade
);
--alter table Table_Management drop constraint fk_Table 
--alter table Table_Management add constraint fk_Table foreign key (ID_Pos) references Position_Table(ID_Pos) on delete cascade on update cascade;

create table Employee(
	ID_Emp int identity primary key,
	name nvarchar(100) not null, 
	Gender bit,
	addr nvarchar(100) not null, 
	phone nvarchar(15) not null, 
	DoB date 
);

create table Discount(
	ID_Dis int identity primary key, 
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
	ID_Dis int, 
	sta bit,
	Total_price float(20) not null,
	constraint PK_Bill primary key (ID_Bill),
	foreign key (ID_Emp) references Employee(ID_Emp),
	constraint fk_Table_Bill foreign key (ID_Table) references Table_Management(ID_Table),
	constraint fk_Discount_Bill foreign key (ID_Dis) references Discount(ID_Dis),
); 

create table Bill_Details(
	ID_Detail int identity not null,
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
--select * from Categories;

insert into Dishes values (1,'Ca kho', 'phan', 15000, 1, 'Ngon');
insert into Dishes values (2, 'Trung chien',	'phan', 15000, 1, 'Ngon');
insert into Dishes values (3, 'Mi xao', 'dia', 35000, 1, 'Ngon');
insert into Dishes values (4, 'Thit nuong', 'phan', 55000, 1, 'Ngon');
insert into Dishes values (5, 'Lau thai', 'cai', 90000, 1, 'Ngon');
--select * from Dishes;

insert into Position_Table values ('Tang tret', 'Trong','Khong');
insert into Position_Table values ('Tang 1', 'Trong','Khong');
insert into Position_Table values ('Tang 2', 'Trong','Khong');
insert into Position_Table values ('VIP1', 'Trong','Khong');
insert into Position_Table values ('VIP2', 'Trong','Khong');
--select * from Position_Table;

insert into Table_Management values (4, 0, 1);
insert into Table_Management values (4, 0, 1);
insert into Table_Management values (4, 0, 1);
insert into Table_Management values (8, 0, 1);
insert into Table_Management values (8, 0, 1);
insert into Table_Management values (8, 0, 1);
insert into Table_Management values (8, 0, 1);
insert into Table_Management values (4, 0, 1);
insert into Table_Management values (4, 0, 1);
insert into Table_Management values (6, 0, 2);
insert into Table_Management values (8, 0, 2);
insert into Table_Management values (10, 0, 2);
insert into Table_Management values (10, 0, 3);
insert into Table_Management values (10, 0, 3);
insert into Table_Management values (8, 0, 3);
insert into Table_Management values (12, 0, 4);
insert into Table_Management values (12, 0, 5);
--select * from Table_Management;

insert into Employee values ('Tran Chien Thanh', 1,'Sao hoa', '0099112233', '1-9-1998');
--select * from Employee;

insert into Discount values (0, 'Khong giam', '2020-5-1',null, 0);
insert into Discount values (5, 'Tren 4 nguoi', '2020-5-1','2020-5-10', 0);
insert into Discount values (7, 'Tren 6 nguoi', '2020-5-1','2020-5-10', 1);
--select * from Discount;

-- insert into Bill values (1, 1, '2020-4-16', '2020-4-17', 1, 0, 0);
--select * from Bill;

--insert into Bill_Details values ( 1, 1, 1);
--insert into Bill_Details values ( 1, 2, 1);
-- select * from Bill_Details;

insert into Account values('vankiet','123');

-------------- Vo Van Kiet ----------------------------------------
-- Kiem tra login
create procedure QLNH_Login
	@user_name nchar(50), @pass_word nchar(20) 
as begin
	select * from Account where userName=@user_name and passwd=@pass_word
end
go
--drop procedure QLNH_Login
--select * from Account;
--execute QLNH_Login 'vankiet' ,'123';


-- List danh sach ban
create procedure QLNH_ListTable
as begin
	select ID_Table, Capability, tm.sta, pt.position as Position
	from Table_Management tm join Position_Table pt on tm.ID_Pos=pt.ID_Pos
	
end
go

--drop procedure QLNH_InsertBill
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


--- Hua Vo Anh Thu -------------------------------------------------------------------
--Hiển thị thông tin khu vực
create procedure spgetPosition
as 
begin
	select * from Position_Table
end 
go

--Hien thi thong tin khu vun theo id_position
create proc spgetPositionByIDposition(
	@IDPosition int
)
as
begin
	select * from Position_Table where ID_Pos = @IDPosition
end
go

--Proc them khu vuc
create proc spInsertPosition(
	@IDPos int,
	@NamePos nvarchar(100),
	@Status nvarchar(50),
	@Note nvarchar(100)
)
as
begin
	insert into Position_Table(ID_Pos, position, sta, note)
	values(@IDPos, @NamePos, @Status, @Note)
end
go

--cap nhat khu vuc
create procedure spUpdatePosition(
	@IDPos int,
	@NamePos nvarchar(100),
	@Status nvarchar(50),
	@Note nvarchar(100)
)
as
begin
	update Position_Table set
		position = @NamePos,
		sta = @Status,
		note = @Note
	where ID_Pos = @IDPos
end 
go

--delete khuvuc
create procedure spDeletePosition(
	@IDPos int)
as
begin
	delete Position_Table where ID_Pos = @IDPos
end
go

--hien thi thong tin ban
create procedure spgetBan
as
begin
	select * from Table_Management
end
go

--hien thi ban theo id
create procedure spgetTableByID
	(@IDTable int)
as
begin
	select * from Table_Management where ID_Table=@IDTable
end
go 

--them ban
create proc spInsertTable(
	@IDTable int,
	@capa int,
	@status bit,
	@IDPos int
)
as 
begin
	insert into Table_Management(ID_Table, capability, sta, ID_Pos)
	values (@IDTable, @capa, @status, @IDPos)
end
go

--update table
create proc spUpdateTable(
	@IDTable int,
	@capa int,
	@status bit,
	@IDPos int
)
as 
begin
	update Table_Management set
		--ID_Table = @IDTable,
		capability = @capa,
		sta = @status,
		ID_Pos = @IDPos
	where ID_Table = @IDTable
end
go

--xoa ban
create proc spDeleteTable(
	@IDTable int)
as 
begin
	delete Table_Management where ID_Table = @IDTable
end
go

-- List danh sach ban va hien thi vi tri theo id
create procedure QLNH_getListTable
as begin
	select ID_Table, pt.ID_Pos, Capability, tm.sta 
	from Table_Management tm join Position_Table pt on tm.ID_Pos=pt.ID_Pos	
end
go

--drop procedure QLNH_getListTable
--exec QLNH_getListTable
-- Tran Chien Thanh -----------------------------------------------------------------
create procedure QLNH_UpdateDiscount  
	@id_dis int , @per float , @descript nvarchar(100), 
	@start Date , @finish Date
as begin
	Declare @sta int = 1;
--	@temp = DATEIFF(@finish, GETDATE())
	if ((GETDATE() <= @finish and GETDATE() >= @start ) or @finish = null)
		set @sta = 0;
	update Discount set  per = @per, descript = @descript, start = @start, finish = @finish, sta = @sta
	where ID_Dis = @id_dis;
end
go

-- drop proc QLNH_UpdateDiscount

create procedure QLNH_InsertDiscount  
	@per float , @descript nvarchar(100), 
	@start Date , @finish Date
as begin
	Declare @sta int = 1;
--	@temp = DATEIFF(@finish, GETDATE())
	if ((GETDATE() <= @finish and GETDATE() >= @start ) or @finish = null)
		set @sta = 0;
	insert into Discount values(@per, @descript, @start, @finish, @sta);
end
go

--select * from Dishes;
--select * from Bill_Details;


--drop trigger QLNH_UpdateBillDetail

create procedure QLNH_Profit
	@start Date, @finish Date
as begin
	Declare @end Date;
	set @end = DATEADD(day,1,@finish)	
	select b.ID_Bill, b.ID_Table, b.Time_Arrive, b.Time_Payment, d.per, b.Total_price 
	from Bill b join Discount d on b.ID_Dis=d.ID_Dis
	where b.Time_Arrive >= @start and b.Time_Payment <= @end 
end 
go

-- drop procedure QLNH_Profit

-- Lay danh sach thong ke doanh thu theo mon
create procedure QLNH_ProfitFollowDish
	@start Date, @finish Date
as begin
	Declare @end Date;
	set @end = DATEADD(day,1,@finish)
	-- so luong mon an theo ID	
	select ID_Dish, SUM(Quantity)as Sum into temp
	from Bill_Details db join Bill b on db.ID_Bill=b.ID_Bill
	where b.Time_Arrive >= @start and b.Time_Payment <= @end 
	group by db.ID_Dish
	--Join de lay ma mon an va so luong mon
	select d.ID_Dish, d.name, d.price, t.Sum as quantity, d.price*t.Sum as total		 
	from temp t join Dishes d on t.ID_Dish = d.ID_Dish
	order by quantity DESC;
	--Drop table de lan sau chay khong loi
	drop table temp
end 
go


--drop procedure QLNH_ProfitFollowDish

----- Huynh Thi Phuong Trinh ---------------------------
-- new funtion Search 25042020
--Search nhung ky tu khong dau 
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS BEGIN IF @strInput IS NULL 
RETURN @strInput IF @strInput = '' 
RETURN @strInput DECLARE @RT 
NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' 
+NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) +
SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END;
--Select * from Dishes where [dbo].[fuConvertToUnsign1](name) like '%'+ [dbo].[fuConvertToUnsign1]('lau chua') + '%';
--select * from Dishes;
--use QL_NhaHang;
--25042020 Delete insert to on casecade in dishes table
-- 01052020 -----------------

-- load page categories
go
create procedure loadPag
@page int
as
begin
	declare @pagerow int = 10
	declare @selectpage int = @pagerow * @page
	declare @exceptpage int = @pagerow * (@page -1);
	
	with pageshow as ( select * from Categories)
	select top (@selectpage)* from pageshow
	except
	select top (@exceptpage) * from pageshow
end
go

-- execute loadPag @page = 1;
-- drop proc loadPag
-- procedure sum all cetegories
go 
create procedure sumCa
as 
begin 
	select COUNT(*) from Categories
end
go

--execute sumCa;
-- drop proc sumCa
-- Procedure listDish

go
create procedure listfood
as 
begin 
	with FoodList as ( select d.ID_Dish, c.name as 'Tên Loại' , d.name, d.price, d.sta, d.unit, d.descript, d.ID_Ca as 'Mã Loại'
	from Dishes as d, Categories as c
	where d.ID_Ca = c.ID_Ca)
	select * from FoodList
end
go
--drop procedure listfood;
--execute listfood ;

-- Search díhes
go
create procedure searchfish
@name varchar(100)
as begin
	set @name = '%'+@name+'%'
	--print ('text:'+@name)
	;with FoodList as ( select d.ID_Dish,c.name as 'Tên Loại', d.name,d.price, d.sta,d.unit, d.descript, d.ID_Ca as 'Mã Loại'
	from Dishes as d, Categories as c
	where d.ID_Ca = c.ID_Ca)
	
	select * from FoodList where name like @name;
end 
go
--drop procedure searchfish;
--select * from Dishes;
--execute searchfish 'Thit';

-- Add on delete cascade Dish with fk Ca
ALTER TABLE dbo.Dishes DROP CONSTRAINT fk_Dish_Cate; 
ALTER TABLE dbo.Dishes
   ADD CONSTRAINT fk_Dish_Cate FOREIGN KEY (ID_Ca)
      REFERENCES dbo.Categories (ID_Ca)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;

 
--select * from categories;
insert into Categories values ('Hap');
insert into Categories values ('Ham');
insert into Categories values ('Rang');
insert into Categories values ('Goi');
insert into Categories values ('Sup');

-- select * from Dishes;
insert into Dishes values ('2','Dui ga chien gion', 'cai', 20000, 1, 'Ngon');
insert into Dishes values ('7','Thit heo ham ca rot', 'phan', 80000, 1, 'Ngon');
insert into Dishes values ('8','Thit heo rang muoi ot', 'phan', 40000, 1, 'Ngon');
insert into Dishes values ('1','Thit heo kho cu cai trang', 'phan', 40000, 1, 'Ngon');
insert into Dishes values ('3','Suon xao chua ngot', 'phan', 45000, 1, 'Ngon');
insert into Dishes values ('3','Suon xao sa ot', 'phan', 45000, 1, 'Ngon');
insert into Dishes values ('3','Thit heo xao cai chua', 'phan', 48000, 1, 'Ngon');
insert into Dishes values ('4','Thit heo nuong chao', 'phan', 57000, 1, 'Ngon');
insert into Dishes values ('4','Thit heo nuong mat ong', 'phan', 65000, 1, 'Ngon');
insert into Dishes values ('8','Thit heo rang toi', 'phan', 35000, 1, 'Ngon');
insert into Dishes values ('4','Thit bo nuong cay', 'phan', 75000, 1, 'Ngon');
insert into Dishes values ('3','Bun bo xao', 'to', 35000, 1, 'Ngon');
insert into Dishes values ('3','Com thit bo xao', 'to', 40000, 1, 'Ngon');
insert into Dishes values ('1','Bo kho', 'to', 50000, 1, 'Ngon');
insert into Dishes values ('6','Ga hap la chanh', 'phan', 48000, 1, 'Ngon');
insert into Dishes values ('6','Ga hap toi', 'phan', 48000, 1, 'Ngon');
insert into Dishes values ('7','Bo ham bia', 'phan', 80000, 1, 'Ngon');
insert into Dishes values ('4','Suon bo xien que', 'phan', 35000, 1, 'Ngon');










