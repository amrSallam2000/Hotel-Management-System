create database myHotel;



create table rooms(
roomid int Identity(1,1) primary key not null,
roomNo varchar(4) not null unique,
roomType varchar(6) not null,
bed varchar(20) not null,
price bigint not null,
booked varchar(4) default 'NO');



create table customer
(
cid int Identity(1,1) primary key,
cname varchar(50) not null,
mobile Varchar(11) not null,
nationality varchar(20) not null,
gender varchar(6) not null,
dob varchar(50) not null,
idproof varchar(11) not null,
addres varchar(50) not null,
checkin varchar(50) not null,
checkout varchar(50),
chekout varchar(50) not null default 'NO',
roomid int not null,
foreign key (roomid) references rooms(roomid)
);

create table employee
(
eid int identity(1,1)primary key,
ename varchar(50) not null,
mobile varchar(11) not null,
gender varchar(6)not null,
emailid varchar(60) not null,
username varchar(20) not null,
pass varchar(15) not null,
);



 create view ViewRoom as
 Select
 rooms.roomNo as'Room_number',
 rooms.roomType as 'Room_Type',
 rooms.bed as'Bed_Type',
 rooms.price as'Price',
 rooms.booked as 'Booking_Status' from rooms;
 
 select customer.cid,
 customer.cname,
 customer.mobile,
 customer.nationality,
 customer.gender,
 customer.dob,
 customer.idProof,
 customer.addres,
 customer.checkin,
 rooms.roomNo,
 rooms.roomType,
 rooms.bed,
 rooms.price 
 from customer inner join rooms on customer.roomid=rooms.roomid where chekout='NO';
 
  select customer.cid,
 customer.cname,
 customer.mobile,
 customer.nationality,
 customer.gender,
 customer.dob,
 customer.idProof,
 customer.addres,
 customer.checkin,
 rooms.roomNo,
 rooms.roomType,
 rooms.bed,
 rooms.price
 from customer inner join rooms on customer.roomid=rooms.roomid where cname like 'Amr Mohamed Meligy' and chekout='NO'

 Update customer set chekout ='Yes',checkout='+ cdate + ' where cid= + id + update rooms set booked ='NO' where roomNo=' ';
        
query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idProof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid ";


create view CustomerDetails as select
cid as 'ID',
cname as'Name',
mobile as 'Phone_Number',
nationality as 'Nationality',
gender as 'Gender',
dob as 'Birth_Date',
idproof as 'National_ID',
addres as 'Address',
checkin as 'Checkin_Date',
checkout as 'CheckOut_Date',
rooms.roomNo 'Room_NO',
rooms.roomType as 'Room_Type',
rooms.bed as 'Bed_Type',
rooms.price as 'Price' 
from customer inner join rooms on customer.roomid=rooms.roomid


 query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idProof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where chekout='NO'";
Create View CustomerView as select
customer.cid as 'ID',
customer.cname as 'Name',
customer.mobile as 'Phone_Number',
customer.nationality as 'Nationality',
customer.gender as 'Gender' ,
customer.dob as 'BirthDate',
customer.idproof as 'National_ID',
customer.addres as 'Address',
customer.checkin as 'Checkin_Date',
rooms.roomNo as 'Room_NO',
rooms.roomType as 'Room_Type',
rooms.bed as 'Bed_Type',
rooms.price as 'Price' 
from customer inner join rooms on customer.roomid=rooms.roomid where chekout='NO';







query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idProof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout is null ";
Create view CustomerInHotel as select
customer.cid as 'ID',
customer.cname as 'Name',
customer.mobile as 'Phone_Number',
customer.nationality as 'Nationality',
customer.gender as 'Gender' ,
customer.dob as 'BirthDate',
customer.idproof as 'National_ID',
customer.addres as 'Address',
customer.checkin as 'Checkin_Date',
rooms.roomNo as 'Room_NO',
rooms.roomType as 'Room_Type',
rooms.bed as 'Bed_Type',
rooms.price as 'Price' 
from customer inner join rooms on customer.roomid=rooms.roomid where checkout is null;






  query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idProof,customer.addres,customer.checkin,customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where checkout is not null ";
Create view CustomerCheckOut as select
customer.cid as 'ID',
customer.cname as 'Name',
customer.mobile as 'Phone_Number',
customer.nationality as 'Nationality',
customer.gender as 'Gender' ,
customer.dob as 'BirthDate',
customer.idproof as 'National_ID',
customer.addres as 'Address',
customer.checkin as 'Checkin_Date',
customer.checkout as 'CheckOut_Date',
rooms.roomNo as 'Room_NO',
rooms.roomType as 'Room_Type',
rooms.bed as 'Bed_Type',
rooms.price as 'Price' 
from customer inner join rooms on customer.roomid=rooms.roomid where checkout is not null;


Create view EmployeeView as select
eid as 'ID',
ename as 'Name',
gender as 'Gender',
mobile as 'Phone_Number',
emailid as 'Email',
username as 'User_Name',
pass as 'Password' from employee;