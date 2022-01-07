select *
from salesman

select Name,commission
from salesman

select order_date,salesman_id,ord_no,purch_amt
from orders

select Name,city
from salesman
where city='Paris'

select customer_id,cust_name,city,grade,salesman_id
from customer

select ord_no,order_date,purch_amt
from orders
where salesman_id=5001


select Avg(purch_amt) as 'average purch amt'
from orders

select Count(Distinct salesman_id) 'salespeople'
from salesman

select count(*)  as noofcustomer
from customer

select max(purch_amt) 'Max amt'
from orders

select city,Max(grade) 'Max Grade'
from customer 
group by city

select customer_id,Max(purch_amt) 'Max amt'
from orders
group by customer_id













