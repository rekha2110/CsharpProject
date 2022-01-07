select order_date,salesman_id,count(*)
from orders
group by order_date,salesman_id


select count(*) 'salespeople'
from customer
group by city


select count(*) 'no.of.orders'
from orders
where order_date='2012-08-17'


select salesman_id,Max(purch_amt) 'Max Purchase'
from orders
where salesman_id between 5003 and 5008
group by salesman_id




