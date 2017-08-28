
use master
select * from sysservers
--drop database netmini
--create database netmini
on (name='netmini',filename='E:\Database\vb_projects\net_mini\data\netmini.mdf')
log on (name='netmini_ldf',filename='E:\Database\vb_projects\net_mini\data\netmini_ldf.ldf')

use netmini

--drop table HeadAcc

--create table [HeadAcc](
[Heada_Name] varchar(40),
[Heada_Code] varchar(10),
[heada_Type] varchar(20),
[Address1] varchar(40),
[Address2]  varchar(40),
[Phone1] varchar(13),
[Phone2]  varchar(13),
[EMail] varchar(30),
[Join_Date] datetime, 
[Active] varchar(1),
[Updated_Date] varchar(15) default convert(varchar,getdate(),103),
[Updated_Time] varchar(15) default convert(varchar,getdate(),108),
)

select [Heada_Name],[Heada_Code],[heada_Type],[Address1],[Address2],[Phone1]
,[Phone2],[EMail],[Join_Date],[Active],[Updated_Date],[Updated_Time] from headacc
order by [heada_Type],[heada_Code],[heada_Name]

insert into headacc([Heada_Name],[Heada_Code],[heada_Type],[Address1],[Address2],
[Phone1],[Phone2],[EMail],[Join_Date],[Active],[Updated_Date],[Updated_Time])
values ('Mani','E01','Credit','11/42 Pampanvilal','Nagercoil 629201','9578781891','','kmani@gmail.com',)




--drop table Product

--create table [Product](
[Pro_name] varchar(40),[Pro_code] varchar(10),
[ShortName] varchar(30),[DtOfCreation]  datetime default convert(varchar,getdate(),103),
[PurcheseRate] numeric(10,2),[SellingRate] numeric(10,2),
[DisplayOrder] int, [Active] varchar(1)  
)

select [Pro_name],[Pro_code],[ShortName],[DtOfCreation],[PurcheseRate],[SellingRate],[DisplayOrder],[Active] from product
order  by displayorder,pro_name

--insert into Product([Pro_name],[Pro_code],[ShortName],[DtOfCreation],[PurcheseRate],[SellingRate],[DisplayOrder],[Active]) 
values('Yellow Banana','ba1','Banana','2014-06-29','4.50','6.00',1,'Y')

select count(pro_code),MAX(displayorder) from product

--create table [Purchese](
[Purchese_No] varchar(10),[Pro_code] varchar(10),
[heada_code] varchar(10),
[Pieces] int,[Amount] numeric(10,2),
[Purchese_Date] datetime,
[BillStatus] varchar(1),
[Updated_Date] varchar(15) default convert(varchar,getdate(),103),
[Updated_Time] varchar(15) default convert(varchar,getdate(),108)
)

select [Purchese_No],pr.Pro_name as [Product_Name],h.Heada_Name ,[Pieces],[Amount],[Purchese_Date] from purchese p 
left join HeadAcc h on p.heada_code =h.Heada_Code 
left join Product pr on pr.Pro_code =p.Pro_code 
where p.Purchese_Date between '2014/07/01' and '2014/07/02'
and ISNULL(p.purchese_no,0)=1


--drop table Purchese

select * from Purchese

--create table [Sales](
[Bill_No] varchar(10),[Bill_Date] datetime,
[heada_code] varchar(10),
[Pro_code] varchar(10),
[Pieces] int,[Amount] numeric(10,2),
[BillStatus] varchar(1),
[Updated_Date] varchar(15) default convert(varchar,getdate(),103),
[Updated_Time] varchar(15) default convert(varchar,getdate(),108)
)

select [Bill_No],pr.Pro_name as [Product_Name],h.Heada_Name ,[Pieces],[Amount],[Bill_Date] from sales s 
left join HeadAcc h on s.heada_code =h.Heada_Code 
left join Product pr on pr.Pro_code =s.Pro_code 
where s.[Bill_Date] between '2014/07/01' and '2014/07/02'


--drop table sales
--create table [ControlTable](
[Control_Name] varchar(50),
[Control_Code] varchar(20),
[Control_Type] varchar(20),
[Control_Length] varchar(10),
[SalBillNo] numeric(10),
[PurBillNo] numeric(10),
[Active] varchar(1) default 'Y'
)

--drop table ControlTable


--create table [Operator](
[Oper_Name] varchar(50),
[Oper_Code] int unique,
[Short_Name] varchar(20),
[Password] varchar(20),
[Confirm_Password] varchar(20),
[DateOfCreation] datetime,
[Active] varchar(1) default 'Y'
)


--drop table operator


select * from operator

use netmini

select 'select * from ' + name,* from sysobjects where xtype='u'

select * from Sales
select * from Purchese
select * from HeadAcc
select * from ControlTable
select * from Product
select * from operator

select oper_name,oper_code,short_name,password,confirm_password,dateofcreation,active from operator
--insert into operator(oper_name,oper_code,short_name,password,confirm_password,dateofcreation,active) values('Supervisor',1,'Super','kmk','kmk','2014/05/14','Y')


use NETMINI

select * from sales 

select * from [InventTrans]

--update [InventTrans] set trantype='R'

SELECT isnull(sum(pieces),0) as rec_pic FROM [InventTrans] where isnull(billstatus,'')<>'C'
 and isnull(trantype,'')='R'
and procode='app2'

create table [InventTrans](
[Bill_No] varchar(10),[Bill_Date] datetime,
[Pro_code] varchar(10),
[Pieces] int,[Amount] numeric(10,2),
[Trantype] varchar(1),
[BillStatus] varchar(1),
[Updated_Date] varchar(15) default convert(varchar,getdate(),103),
[Updated_Time] varchar(15) default convert(varchar,getdate(),108)
)



select Bill_No,Bill_Date,Pro_code,
(case when isnull(Trantype,'')='R' then Pieces else pieces * -1 end) as opnPic,
0 as Receipt,
0 as Issue,
(case when isnull(Trantype,'')='R' then Amount else Amount * -1 end) as opnAmt,
0 as ReceiptAmt,
0 as IssueAmt   from [InventTrans] where ISNULL(billstatus,'')<>'C'
and ISNULL(bill_date,'') between '2014-09-21'  and '2014-09-22'
and ISNULL(Pro_code,'')<>''
union all
select Bill_No,Bill_Date,Pro_code,
0 as opnPic,
(case when isnull(Trantype,'')='R' then Pieces end) as Receipt,
(case when isnull(Trantype,'')='I' then Pieces end) as Issue,
0 as OpnAmt,
(case when isnull(Trantype,'')='R' then Amount  end) as ReceiptAmt,
(case when isnull(Trantype,'')='I' then Amount end) as IssueAmt   from [InventTrans] 
where ISNULL(billstatus,'')<>'C'  and ISNULL(bill_date,'') between '2014-09-21'  and '2014-09-22' 
and ISNULL(Pro_code,'')<>''