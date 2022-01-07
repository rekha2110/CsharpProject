create table Tutorial(Id int,Name varchar(100),Descr varchar(max),Published int)
alter table Tutorial 
add Author varchar(100)
insert into Tutorial values(1,'C#','Multithreading',0)
insert into Tutorial values(2,'SQL','SQL Commands',1)
insert into Tutorial values(3,'Java','Java hybernate',1)
insert into Tutorial values(4,'C#','OOPS',1)
insert into Tutorial values(5,'C#','File Handling',1)
insert into Tutorial values(6,'Java','Java MVC',0)

select *
from Tutorial

--saleman table
create table salesman(salesman_id int primary key,Name varchar(100),city varchar(200),commission real)
insert into salesman values(5001,'James Houg','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.11)
insert into salesman values(5004,'Paul Adam','Rome',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
select *
from salesman

select Name,commission
from salesman 

--orders table
 
create table orders(ord_no int,purch_amt real,order_date Date,customer_id int,salesman_id int references salesman(salesman_id))
insert into orders values(70001,150.0,'2012-10-05',3005,5002)
insert into orders values(70009,270.65,'2012-09-10',3001,5005)
insert into orders values(70002,65.26,'2012-10-05',3002,5001)
insert into orders values(70004,110.5,'2012-08-17',3009,5003)
insert into orders values(70007,948.5,'2012-09-10',3005,5002)
insert into orders values(70005,2400.6,'2012-07-27',3007,5001)
insert into orders values(70008,5760,'2012-09-10',3002,5001)
insert into orders values(70010,1983.43,'2012-10-10',3004,5006)
insert into orders values(70003,2480.4,'2012-10-10',3009,5003)
insert into orders values(70001,250.45,'2012-06-27',3008,5002)
insert into orders values(70012,75.29,'2012-08-17',3003,5007)
insert into orders values(70013,3045.6,'2012-04-25',3002,5001)

select order_date,salesman_id,ord_no,purch_amt
from orders

--customer table
create table customer(customer_id int,cust_name varchar(100),city varchar(200),grade int,salesman_id int references salesman(salesman_id))
insert into customer values(3002,'Nick Rimando','New york',100,5001)
insert into customer values(3007,'Brad Davis','New york',200,5001)
insert into customer values(3005,'Graham Zusi','California',200,5002)
insert into customer values(3008,'Julian Green','London',300,5002)
insert into customer values(3004,'Fabian Johnson','Paris',300,5006)
insert into customer values(3009,'Geoff Cameeron','Berlin',100,5001)
--insert into customer values(3002,'Jozy Altidor','Moscow',200,5007)
insert into customer values(3001,'Brad Guzan','London',0,5005)

select*
from customer

select Name,city
from salesman,customer
where salesman.salesman_id=customer.salesman_id and 
      city='Paris'


select customer_id,cust_name,city,grade,salesman_id
from customer
where grade=200


select ord_no,order_date,purch_amt
from orders
where salesman_id=5001
