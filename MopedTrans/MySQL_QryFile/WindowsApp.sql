Create database drawmaindb;

use drawmaindb;

create table Operator(
	OperId	bigint  auto_increment primary key,	
	FirstName	varchar(30)	not null,
	LastName	varchar(3)	,
	userName	varchar(16) unique,
	Password	varchar(40)	,
	Active	varchar(1)	default 'Y',
	Last_Updated	timestamp	default current_timestamp    
);

CREATE TABLE `custsignup` (
  `CustId`	bigint not null auto_increment primary key,
  `custname` varchar(40) DEFAULT NULL,
  `motbikeno` varchar(20) DEFAULT NULL,
  `motbikename` varchar(40) DEFAULT NULL,
  `mobieno` varchar(15) DEFAULT NULL,
  `emailaddr` varchar(40) NOT NULL unique,
  `cregpwd` varchar(20) DEFAULT NULL,
  `cregcpwd` varchar(40) DEFAULT NULL,
  `updated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `active` varchar(1) DEFAULT 'Y',  
  `OnlineFlg` varchar(1) DEFAULT 'Y'	
);

-- alter table custsignup add  `OnlineFlg` varchar(1) DEFAULT 'Y';

create table RateMaster(
	RateId	bigint	auto_increment primary key,
	rate	numeric(10,2)	unique,
	Active	varchar(1)	default 'Y',
	Last_Updated	timestamp	default current_timestamp);

create table ServiceMast(
	ServId	bigint	primary key,
	ServiceName	varchar(30)	unique,
	SubService	Varchar(1)	,
	RateId	bigint	,
	Active	varchar(1)	default 'Y'	,
	Last_Updated	timestamp	default current_timestamp,
	foreign key (`rateid`)
	references `drawmaindb`.`ratemaster` (`rateid`)
);

create table SubServiceMast(			
	ServId	bigint	,
	SubServId	bigint auto_increment	primary key,
	SubServiceName	varchar(30)	unique,
	RateId	bigint	,
	Active	varchar(1)	default 'Y',
	Last_Updated	timestamp	default current_timestamp,
	foreign key (`ServId`)
	references `drawmaindb`.`ServiceMast` (`ServId`)
);

create database drawtrandb;

use drawtrandb;


CREATE TABLE `custregistrationsumry` (
  `CustId` bigint ,
  `OrderMajorId` bigint NOT NULL  auto_increment PRIMARY KEY ,
  `ordersubject` varchar(45) NOT NULL DEFAULT 'Problem Booking',
  `OrderDate` datetime,	
  `updated` timestamp NULL DEFAULT CURRENT_TIMESTAMP(),
  `ordercancel` varchar(2) DEFAULT NULL,
  `orddetsmry` varchar(50) DEFAULT NULL,
  `orddeliverydate` datetime DEFAULT NULL,
  `OperId` bigint,
  `nodeid` varchar(20),
  FOREIGN KEY (`CustId`) REFERENCES `drawmaindb`.`custsignup` (`CustId`),
  FOREIGN KEY (`OperId`) REFERENCES `drawmaindb`.`Operator` (`OperId`)
);

CREATE TABLE `custregistration` (
  `CustId` bigint,   
  `OrderMajorId` bigint NOT NULL ,
  `OrderSubId` bigint NOT NULL DEFAULT '0',  
  `orderdetail` varchar(45) DEFAULT NULL,
  `OrderDate` datetime,		
  `updated` timestamp NULL DEFAULT CURRENT_TIMESTAMP(),
  `ordercancel` varchar(2) DEFAULT NULL,
  `pbstatus` varchar(50) NOT NULL DEFAULT 'Not Assigned',
  `pbfinunfinflag` varchar(1) NOT NULL DEFAULT 'N',
  `orddeliverydate` datetime DEFAULT NULL,
  `OperId` bigint,
  `nodeid` varchar(20),
  FOREIGN KEY (`OrderMajorId`) REFERENCES `drawtrandb`.`custregistrationsumry` (`OrderMajorId`),
  FOREIGN KEY (`CustId`) REFERENCES `drawmaindb`.`custsignup` (`CustId`),
  foreign key (`OperId`) references `drawmaindb`.`Operator` (`OperId`)
);

CREATE TABLE `custregistration_log` (
  `CustId` bigint,   
  `OrderMajorId` bigint NOT NULL ,
  `OrderSubId` bigint NOT NULL DEFAULT '0',  
  `orderdetail` varchar(45) DEFAULT NULL,
  `OrderDate` datetime,		
  `updated` timestamp NULL DEFAULT CURRENT_TIMESTAMP(),
  `ordercancel` varchar(2) DEFAULT NULL,
  `pbstatus` varchar(50) NOT NULL DEFAULT 'Not Assigned',
  `pbfinunfinflag` varchar(1) NOT NULL DEFAULT 'N'  ,
  `User` varchar(50)  	
);


create table ServiceTran(			
	SerTranId	bigint	not null,
	SerTrandate	datetime,	
	CustId	bigint	,
	OrderMajorId	bigint	,
	OrderSubId	bigint,	
	ServId	bigint	,
	SubServId	bigint	,
	Cancel varchar(1),
	Remarks varchar(50),
	OperId	bigint	,
	Last_Updated	timestamp	default current_timestamp(),
    foreign key (`CustId`) references `drawmaindb`.`custsignup` (`CustId`),
	foreign key (`OrderMajorId`) references `drawtrandb`.`custregistrationsumry` (`OrderMajorId`),
	foreign key (`ServId`) references `drawmaindb`.`ServiceMast` (`ServId`),
	foreign key (`SubServId`) references `drawmaindb`.`SubServiceMast` (`SubServId`),
	foreign key (`OperId`) references `drawmaindb`.`Operator` (`OperId`)
);

CREATE TABLE `custregstatus` (
  `CrStId` bigint auto_increment primary key,
  `CustId` bigint,
  `SerTranId` bigint,
  `OveralChFlag` varchar(1) DEFAULT 'N',
  `OrderMajorId` bigint , 
  `updated` timestamp DEFAULT CURRENT_TIMESTAMP(),
  `OperId` bigint, 
  `battery` int(11) DEFAULT '0',
  `engine` int(11) DEFAULT '0',
  `suspension` int(11) DEFAULT '0',
  `brakes` int(11) DEFAULT '0',
  `exterior` int(11) DEFAULT '0',
  `tyres` int(11) DEFAULT '0',
  `electrical` int(11) DEFAULT '0',
  `seats` int(11) DEFAULT '0',
  `overal` int(11) DEFAULT '0',
  `Remarks` varchar(50),
  `nodeid`	varchar(20),
   FOREIGN KEY (`CustId`) REFERENCES `drawmaindb`.`custsignup` (`CustId`),
   FOREIGN KEY (`OrderMajorId`) REFERENCES `drawtrandb`.`custregistrationsumry` (`OrderMajorId`),
   FOREIGN KEY (`OperId`) REFERENCES `drawmaindb`.`Operator` (`OperId`)  
);


CREATE TABLE `Authorization`(
	`AuthId` bigint auto_increment primary key,
	`OperId` bigint,
	`CustId` bigint,
	`RefNo` bigint not null default 0,
	`RefDate` datetime not null ,
	`AuthType` varchar(2),
	`Reason` varchar(50) not  null,
	`Remarks` varchar(50) not  null,
	`Updated` timestamp default current_timestamp(),
	FOREIGN KEY (`OperId`) REFERENCES `drawmaindb`.`Operator` (`OperId`),
	FOREIGN KEY (`CustId`) REFERENCES `drawmaindb`.`custsignup` (`CustId`)   
);

drop table custregstatus;
 drop table ServiceTran;
-- drop table ServiceMast;
-- drop table Operator	;
-- drop table RateMaster;

-- drop table custsignup;
 drop table custregistrationsumry;
 drop table custregistration;
 drop table custregstatus;
-- drop table Authorization;
-- drop table custregistration_log;

use drawtrandb;

DELIMITER //
CREATE TRIGGER `drawtrandb`.`custreg_del` BEFORE DELETE 
ON `drawtrandb`.`custregistration`
FOR EACH ROW
BEGIN
	DECLARE vUSER VARCHAR(50);
	SELECT USER() INTO vUSER;
      INSERT INTO custregistration_log (CustId,OrderMajorId,OrderSubId,orderdetail,OrderDate,updated,ordercancel,pbstatus,pbfinunfinflag,USER)
        VALUES (OLD.CustId,OLD.OrderMajorId,OLD.OrderSubId,OLD.orderdetail,OLD.OrderDate,OLD.updated,OLD.ordercancel,OLD.pbstatus,OLD.pbfinunfinflag,vUSER);
END; //
DELIMITER ;

use drawmaindb;


select * from custregistration_log;

select * from custregistration;
select * from operator;


