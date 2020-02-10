create database Sample1;

use sample1;

create table Employee (Eid int,Ename varchar(30),Ecity varchar(22),Estate varchar(20));

insert into Employee values(901,'Roman','Mumbai','Maharashtra');

select * from Employee;

insert into Employee values(902,'John','Pune','Maharshtra');

select * from Employee;

go;
create trigger Inform on Employee
After Insert

As

print 'Inserted data';
go;

insert into Employee(Eid,Ename,Ecity,Estate) values(903,'Bigshow','Nagpur','Maharashtra');
select * from Employee;

go;

create trigger Infrom1 on Employee
After Update

As

print 'Updated data';

go;

update Employee set Ename='Deepak' where Eid=902;

select * from Employee;
delete from Employee where Eid=902;

go;


create table Deleted_data (Eid int,Ename varchar(50),Ecity varchar(30),Estate varchar(40));


select * from Deleted_data;

go;

create trigger inform2  on  Employee for Delete
As
insert into Deleted_data(Eid,Ename,Ecity,Estate) 
select Eid,Ename,Ecity,Estate from Deleted;

