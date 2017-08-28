create database acabala;
use acabala;
-- DROP TABLE STAFF;
create table staff(sno int unique AUTO_INCREMENT ,name varchar(50),staffid varchar(20),password varchar(20),active varchar(2),primary key(staffid ));
alter table staff add active varchar(1);
insert into staff(name,staffid,password,active) values('superviser','superviser','bala','Y');
select name,staffid,password from staff order by name;
-- delete from staff where staffid=3;
create table student(stuname varchar(40),sturegno varchar(20),stucorse varchar(10),
stubranch varchar(10),stuemail varchar(40),stumobileno varchar(15),stuaddress varchar(50),
stuactive varchar(1),acyfrom date,acyto date,stuaddeddate timestamp NOT NULL,staffid varchar(20),primary key(sturegno));
-- drop table student;
-- truncate table student;
insert into student(stuname,sturegno,stucorse,stubranch,stuemail,
stumobileno,stuaddress,stuactive,acyfrom,acyto,stuaddeddate,staffid) 
values('mani','97409104025','b.e','cse','mani@gmail.com','9578781891','nagercoil'
,'y','2009/04/01','2013/03,30','2014/02/02','mani');
select stuname,sturegno,stucorse,stubranch,stuemail,
stumobileno,stuaddress,stuactive,acyfrom,acyto,stuaddeddate,
staffid from student order by sturegno;

 insert into student(stuname,sturegno,stucorse,stubranch,stuemail,stumobileno,
stuaddress,stuactive,acyfrom,acyto,stuaddeddate,staffid) 
values('test','956789','be','cse','mani@gmail.com','9578781891','say hello',
'Y','2014-02-02','2014-03-01','now()');

select now();
select name,staffid,active from staff where active='Y' order by name ;

select stuname,sturegno,stucorse,stubranch,stuemail,
	 staffid from student where sturegno=9578781891 and stuactive='Y' order by sturegno;