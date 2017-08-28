<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>duraiRaj Auto Admin update</title>

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
<%

String message;
String veno=request.getParameter("vn");
String dname=request.getParameter("na");
String d=request.getParameter("dd");
String m=request.getParameter("mm");
String y=request.getParameter("yy");
String t=request.getParameter("tt");
String pro=request.getParameter("problem");

//out.println(udate);
try
{

Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");

String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";

Connection conn =DriverManager.getConnection( db );

Statement stmt = conn.createStatement();

String ps = "update details set dd='"+d+"',mm='"+m+"',yy='"+y+"',tt='"+t+"',problem='"+pro+"' where vehiclenumber='"+veno+"'"; 


int k = stmt.executeUpdate(ps);
%>
<div class="align">
<table align="right" cellpadding="2px" cellspacing="2px" style="margin-right:180px" >
<tr><td class="userelcome"><%=dname%></td><td>|</td><td><a href="index.html" style="color:#000">Logout</a></td>

</tr>
</table></div>
<br /><br />
<center>
<div id="banner">
</div>
<table cellpadding="0px" cellspacing="0px" align="center" width="1000px" height="40px">
<tr><td class="userwelcome"><strong><b>Welcome To <%=dname%></b></strong></td></tr>
</table></center>


 <div class="slidingDiv">
 <center>

        <h3><%=veno%> Service Booking has been Successfully Registered.... </h3><span style="font-size:16px; color:#900">
        
        <form action="userpage1.jsp" method="post">
<input type="hidden" value="<%=veno%>" name="vehino" />
      
        
<input type="submit" width="195px" height="55px" style="width:120px; height:55px; border:#FFF; background-image:url(new/back2.gif)" value="" />
</form>
 <br /><< back to Your Profile
        </span>
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