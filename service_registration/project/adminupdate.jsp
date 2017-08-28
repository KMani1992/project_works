<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>DuraiRaj Auto Admin update</title>

<link href="style.css" rel="stylesheet" type="text/css" /><link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 <script src="booking-service_files/swfobject.js" type="text/javascript"></script>
 <link href="WebResource.css" rel="stylesheet" type="text/css" media="all"><link href="main.css" rel="stylesheet" type="text/css">

<style>

body{
font-family:Verdana, Geneva, sans-serif;
font-size:14px;}

.slidingDiv {
	height:200px;
	width:960px;
	margin:0 auto;
	background-color: #99CCFF;
	padding:20px;
	
	border-bottom:5px solid #3399FF;
}
.userwelcome
{
	background-color:#001842;
	
	font-family:Arial, Helvetica, sans-serif;
	font-size:13px;
	font-weight:100;
	font-variant:normal;
	text-decoration:none;
	text-align:center;
	color:#FFF;
}

.userelcome
{

	
	font-family:Arial, Helvetica, sans-serif;
	font-size:13px;
	font-weight:100;
	font-variant:normal;
	text-decoration:none;
	text-align:center;
	color:rgb(247, 56, 50);
}

.show_hide {
	
	display:none;
}
.error
{
	color:#C00;
	text-align:right;
	font-size:14px;
}
.reginf {
	
	display:none;
}

</style>
</head>
<body>

<div class="align">
<table align="right" cellpadding="2px" cellspacing="2px" style="margin-right:180px" >
<tr><td class="userelcome">DuraiRaj Auto Admin</td><td>|</td><td><a href="index.html" style="color:#000">Logout</a></td>

</tr>
</table></div>
<br /><br />
<center>
<div id="banner">
</div>
<table cellpadding="0px" cellspacing="0px" align="center" width="1000px" height="40px">
<tr><td class="userwelcome"><strong><b>Welcome To Admin Page</b></strong></td></tr>
</table></center>




<%

String message;
String veno=request.getParameter("vehno");
String udate=request.getParameter("date");
String ubattery=request.getParameter("selBattery");
String uengine=request.getParameter("selEngine");
String usus=request.getParameter("selSuspension");
String ubreak=request.getParameter("selBrakes");
String uexter=request.getParameter("selExterior");
String utyre=request.getParameter("selTyres");
String uelectrical=request.getParameter("selElectricals");
String useets=request.getParameter("selSeats");
String uoveral=request.getParameter("selOverall");

//out.println(udate);
try
{

Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");

String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";

Connection conn =DriverManager.getConnection( db );

Statement stmt = conn.createStatement();

String ps = "update details set battery='"+ubattery+"',engine='"+uengine+"',suspensions='"+usus+"',brakes='"+ubreak+"',exterior='"+uexter+"',tyres='"+utyre+"',electrical='"+uelectrical+"',seats='"+useets+"',overal='"+uoveral+"',statusupdatedate='"+udate+"' where vehiclenumber='"+veno+"'"; 



int k = stmt.executeUpdate(ps);
%>

 <div class="slidingDiv">
 <center>

        <h3><%=veno%> Status has been updated.... </h3><span style="font-size:16px; color:#900"><a href="adminpage.jsp"><img src="new/back.gif" width="120" height="55" /><br /><< back to home</a></span>
    </center>
    </div>







<%
}


catch(Exception e)
{
	out.println(e);
}







//out.println(vno);


%>


</body>
</html>