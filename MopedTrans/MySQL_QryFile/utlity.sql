SELECT
`custregstatus`.`CrStId`,
`custregstatus`.`CustId`,
`custregstatus`.`SerTranId`,
`custregstatus`.`OveralChFlag`,
`custregstatus`.`OrderMajorId`,
`custregstatus`.`updated`,
`custregstatus`.`OperId`,
`custregstatus`.`battery`,
`custregstatus`.`engine`,
`custregstatus`.`suspension`,
`custregstatus`.`breaks`,
`custregstatus`.`exterior`,
`custregstatus`.`tyres`,
`custregstatus`.`electrical`,
`custregstatus`.`seats`,
`custregstatus`.`overal`,
`custregstatus`.`Remarks`
FROM `drawtrandb`.`custregstatus`;

use drawmaindb;

use drawtrandb;

-- alter table servicemast modify column ServId bigint(20) not null auto_increment ;
-- alter table servicetran add nodeid varchar(20);
 
alter table custregstatus add nodeid varchar(20);


select * from custregistration;

select * from servicetran ;


select s.CrStId,s.updated,s.CustId,(select custname from drawmaindb.custsignup c where c.custid=s.custid) as custname,s.SerTranId,s.OveralChFlag,
s.OrderMajorId,s.battery,s.engine,s.suspension,s.brakes,s.exterior,s.tyres,s.electrical,s.seats,s.overal,
s.Remarks from custregstatus s order by s.CrStId;