use drawmaster;

select crs.ordersubject,crs.orddetsmry,crs.OrderMajorId,crs.updated,
isnull(crs.orddeliverydate,'') as orddeliverydate,
count(case cr.pbfinunfinflag when 'Y' then pbfinunfinflag end) as `Finished`,
count(case cr.pbfinunfinflag when 'N' then pbfinunfinflag end) as `UnFinished` 
from CustRegistrationSumry as  crs left join CustRegistration cr on 
crs.emailaddr=cr.emailaddr and  crs.OrderMajorId=cr.OrderMajorId left join custSignUp as cs on cr.emailaddr=cs.emailaddr 
where cs.emailaddr='kmani@gmail.com' 
and cs.motbikeno='TNI 435'
group by crs.OrderMajorId
order by crs.OrderMajorId desc;

select cr.orderdetail,cr.pbfinunfinflag,cr.pbstatus from 
CustRegistrationSumry crs left join CustRegistration cr on 
crs.emailaddr=cr.emailaddr and crs.ordermajorid=cr.ordermajorid
where crs.emailaddr='kmani@gmail.com' and crs.ordermajorid=1
order by cr.ordersubid;


select cr.orderdetail,cr.pbfinunfinflag,cr.pbstatus from CustRegistrationSumry as crs 
left join CustRegistration cr on crs.emailaddr=cr.emailaddr and 
crs.ordermajorid=cr.ordermajorid where crs.emailaddr='kmani@gmail.com' 
and crs.ordermajorid=7 and crs.motorbikeno='TNI 435' 
order by cr.ordersubid;


select * from custsignup;


update CustSignUp set custname='',motbikeno='',motbikename='',mobieno='' 
where emailaddr='';