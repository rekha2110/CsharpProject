select cust_name,Commission,customer.city,customer.salesman_id
from customer inner join salesman
on customer.salesman_id=salesman.salesman_id and commission>0.12


select cust_name,customer.city 'cust_city',salesman.salesman_id,salesman.city 'salesman_city',commission
from customer inner join salesman
on customer.salesman_id=salesman.salesman_id and commission>0.12 and customer.city!=salesman.city


select cust_name,customer.city,salesman.salesman_id,commission
from customer left outer join salesman
on customer.salesman_id=salesman.salesman_id
order by salesman_id asc


select salesman.salesman_id,cust_name,salesman.city
from customer inner join salesman
on customer.salesman_id=salesman.salesman_id


select ord_no,purch_amt,cust_name,city
from customer inner join orders
on customer.customer_id=orders.customer_id and purch_amt between 500 and 2000





