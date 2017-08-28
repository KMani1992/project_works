show tables;
SHOW Databases like 'TESTPRO';
select current_date;

 drop database company;

use mysql;
select 'current_time';

use testpro;
show tables;

select * from testpro;

drop database company;

use company;
select * from company;


select companyid,companyname,companycode,dbpath,servername,password,periodto,created from company;

select * from company where companyname like 'DuraiRajAutoWorks' and companycode='draw';
USE MYSQL;
select * from help_topic where name like '%trigger%';


select * from company;  




-- create database company;
use company;
-- drop database company;
-- drop table company;
select current_date();
create table company (companyid int not null auto_increment,
	companyname varchar(50),
	companycode varchar(4),
	dbpath varchar(30),
	servername varchar(40),
	password varchar(20),
	periodfrom datetime,
	periodto datetime,
	created varchar(20) default current_date(),PRIMARY KEY(companyid) );
show tables where Tables_in_company like 'company';
insert into company (companyid,companyname,companycode,dbpath,
servername,password,periodfrom,periodto,created) values(?,?,?,?,?,?,?,?,?);
create database drawmaster;
use drawmaster;
create table BalGroup(GroupId	varchar(10),
	GroupName	varchar(40),
	GroupType	varchar(25),
	Discription	varchar(40));
create table ProcessMaster	(ProId	varchar(10),
	ProType	varchar(25),
	ProName	varchar(40),
	ProDiscription	varchar(40));
create table DepartmentMasster(DeptId	varchar(10),
	DeptName	varchar(25) primary key,
	DeptType	varchar(10),
	DeptDiscription	varchar(40));
create table CuctomerMaster	(Cid	bigint	primary Key,
	CType	varchar(10),	
	Cname	varchar(40)	unique,
	Active	varchar(10),
	ShortName	varchar(10)	);
create table EmployeMaster	(EmpId	varchar(25)	primary key,
	EmpName	varchar(40),	
	EmpType	varchar(10),
	EmpaCTIVE	varchar(10));
create table StateMaster (STId	bigint	unique,
	STName	varchar(40),	
	STShortName	varchar(25));
create table RegularProcess	(ProId	varchar(25)	primary key,
	ProName	varchar(40),	
	ProDiscription	varchar(40)	);
create table EmployeRestriction	(EmpId	varchar(25),
	EmpName	varchar(40),
	EmpType	varchar(10),
	EmpRelation	varchar(40));
create table ChargeList	(Clid	bigint	primary key,
	Cltype	varchar(10),	
	CLName	varchar(40),
	CLDiscription	varchar(40),	
	CAmount	numeric(10,2));	

create table DiscountMaster(DisId varchar(10)	primary key,
	DisType	varchar(10),
	DisName	varchar(25),	
	DisPercent	bigint,	
	DisAmount	numeric(10,2));	

use drawmaster;

show tABLES;
	
-- drop table BalGroup;
-- drop table ProcessMaster;
-- drop table DepartmentMasster;
-- drop table CuctomerMaster;
-- drop table EmployeMaster;
-- drop table StateMaster;
-- drop table RegularProcess;
-- drop table EmployeRestriction;
-- drop table ChargeList;
-- drop table DiscountMaster;

-- drop table custSignUp;

select emailaddr from custSignUp where emailaddr='kmk@gmail.com';

select * from custSignUp;
-- truncate table custSignUp;

select custname,motbikeno,motbikename,mobieno,emailaddr from custSignUp;

-- insert into custSignUp(custname,motbikeno,motbikename,mobieno,emailaddr,cregpwd,cregcpwd) values('?','?','?','?','?','?','?');


use drawmaster;


-- alter table CustRegistrationSumry  add orddeliverydate datetime;

-- INSERT INTO `CustRegistration` (
`emailaddr`, `motorbikeno`, `OrderMajorId`, `OrderSubId`, `ordersubject`, 
`orderdetail`) VALUES('?','?','?','?','?','?');

select * from CustRegistration;
select orddeliverydate from CustRegistrationSumry;

-- create table tsd(name varchar(3),dt DATETIME default @@now);

SELECT CURDATE();

-- alter table CustRegistrationSumry add orddeliverydate datetime null timestamp default current_timestamp() orddetsmry varchar(50);

-- drop table CustRegistration;
-- drop table CustRegistrationSumry;
-- drop table CustSignUp;
-- drop table RegistrationStatus;

select  * from CustRegistration;
select * from CustRegistrationSumry;

select * from CustRegStatus;
-- insert into custregstatus(emailaddr,motorbikeno
,battery,engine,suspension,breaks,
exterior,tyres,electrical,seats,overal)
 values('kmanikandangce@gmail.com','TNI 435',50,60,80,40,90,60,70,20,40);









