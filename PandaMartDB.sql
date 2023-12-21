use Mustafa;

Create Table items_tb1(
item_id int primary key identity(1,1),
item_name varchar(50),
item_price int,
item_discount int,
);
select*from items_tb1;

insert into items_tb1 values ('Lipton Tea Lagr e',350,20), ('Lipton Tea Small',250,10), ('EveryDay Lagre',1350,50), ('EveryDay Small',1000,20);
insert into items_tb1 values ('Lays',50,5);


CREATE TABLE login(
id int primary key identity(1,1),
username varchar(50),
password varchar(50)
);
 
 insert into login values ('Mustafa','Mus@123');
 select * from login;

 CREATE table signup(
 user_id int primary key identity(1,1),
 fname varchar(50),
 lname varchar(50),
 age int,
 gender varchar(50),
 address varchar(60),
 email varchar(50),
 Password varchar(50)
 );

 select * from signup

 create table order_master(
 invoice_id int primary key identity(1,1),
 username varchar(40),
 datetime varchar(50),
 finalcost int
 );
 insert into signup values ('Salman', 'Khan', 32, 'Male', 'India', 'Salman32@gmail.com', 'Salman32@');

 select * from order_master

 create table order_details(
 order_details_id int primary key identity,
 innvoice_id int foreign key references order_master(invoice_id),
 items_name varchar(50),
 unit_rice int,
 discount_per_item int,
 quantity int,
 subtotal int,
 tax int,
 totalcost int
 );

 select * from order_details

 create procedure sp_getBothTableData
 as
 begin
 select A.invoice_id, A.username, A.[datetime], B.items_name, B.unit_rice, B.discount_per_item, B.quantity, B.subtotal, B.tax, B.totalcost, A.finalCost 
 from order_master as A
 inner join order_details as B
 on A.invoice_id = B.innvoice_id;
 end

 create procedure sp_getBothTableDataByInvoice
 @invoiceID int
 as
 begin
 select A.invoice_id, A.username, A.[datetime], B.items_name, B.unit_rice, B.discount_per_item, B.quantity, B.subtotal, B.tax, B.totalcost, A.finalCost 
 from order_master as A
 inner join order_details as B
 on A.invoice_id = B.innvoice_id where A.invoice_id = @invoiceID
 end
