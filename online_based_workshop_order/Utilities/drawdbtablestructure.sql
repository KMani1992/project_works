

-- create database drawmaster;
use drawmaster;

 CREATE  TABLE IF NOT EXISTS `drawmaster`.`CustSignUp` (
  `custname` VARCHAR(40) NULL ,
  `motbikeno` VARCHAR(20) NULL ,
  `motbikename` VARCHAR(40) NULL ,
  `mobieno` VARCHAR(15) NULL ,
  `emailaddr` VARCHAR(40) NOT NULL ,
  `cregpwd` VARCHAR(20) NULL ,
  `cregcpwd` VARCHAR(40) NULL ,
  `updated` timestamp default current_timestamp() ,  
  `active` VARCHAR(1) 	DEFAULT 'Y',
  PRIMARY KEY (`emailaddr`) );



 CREATE  TABLE IF NOT EXISTS `drawmaster`.`CustRegistrationSumry` (
  `emailaddr` VARCHAR(40) NULL ,
  `motorbikeno` VARCHAR(20) NULL ,
  `OrderMajorId` INT NOT NULL default 0,  
  `ordersubject` VARCHAR(45) NOT NULL DEFAULT 'Problem Booking' ,  
  `updated` TIMESTAMP null default current_timestamp(),  
  `ordercancel` VARCHAR(2) NULL ,
  `orddeliverydate` datetime null,
  `orddetsmry` varchar(50),
  PRIMARY KEY (`OrderMajorId`) ,    
    FOREIGN KEY (`emailaddr` )
    REFERENCES `drawmaster`.`CustSignUp` (`emailaddr` )
    );


 CREATE  TABLE IF NOT EXISTS `drawmaster`.`CustRegistration` (
  `emailaddr` VARCHAR(40) NULL ,
  `motorbikeno` VARCHAR(20) NULL ,
  `OrderMajorId` INT NOT NULL default 0 ,
  `OrderSubId` INT NOT NULL default 0,
  `ordersubject` VARCHAR(45) NOT NULL DEFAULT 'Problem Booking' ,
  `orderdetail` VARCHAR(45) NULL ,
  `updated` TIMESTAMP null default current_timestamp() ,  
  `ordercancel` VARCHAR(2) NULL ,
  `pbstatus`  varchar(50) not null default 'Not Assigned',
  `pbfinunfinflag` varchar(1) not null default 'N',
  foreign key (`OrderMajorId`) 
	references `drawmaster`.`CustRegistrationSumry`(`OrderMajorId`),    
    FOREIGN KEY (`emailaddr` )
    REFERENCES `drawmaster`.`CustSignUp` (`emailaddr` )
    );


create table CustRegStatus(
  `emailaddr` VARCHAR(40) NULL ,
  `motorbikeno` VARCHAR(20) NULL ,  
  `updated` TIMESTAMP null default current_timestamp(),  
  `battery` int default 0,	
  `engine` int default 0,
  `suspension` int default 0,
  `breaks` int default 0,
  `exterior` int default 0,
  `tyres` int default 0,
  `electrical` int default 0,
  `seats` int default 0,
  `overal` int default 0,
    FOREIGN KEY (`emailaddr` )
    REFERENCES `drawmaster`.`CustSignUp` (`emailaddr` )
);
