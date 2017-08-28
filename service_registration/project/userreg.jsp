<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Customer registration</title>
<link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
</head>

<%
String rname=request.getParameter("name");
String raddress=request.getParameter("address");
String fcity=request.getParameter("city");
String fzip=request.getParameter("zip");
String fcountry=request.getParameter("country");
String fphone=request.getParameter("phone");
String fmail=request.getParameter("mail");
String fpassword=request.getParameter("password");
String fconfirmpassword=request.getParameter("confirmpassword");
String fvnumber=request.getParameter("vnumber");

if(rname==""||raddress==""||fcity==""||fzip==""||fcountry==""||fphone==""||fmail==""||fvnumber==""||fpassword==""||fconfirmpassword=="")
{%>
<script type="text/javascript">
alert("please fill all the field");
</script>
<%
}
else
{

try
{
Connection conn = null;
Class.forName( "sun.jdbc.odbc.JdbcOdbcDriver" );
String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";

conn = DriverManager.getConnection( db );
Statement st=conn.createStatement();

int i=st.executeUpdate("insert into details(fullname,address,city,zipcode,state,phone,email,vehiclenumber,password,confirmpassword) values('"+rname+"','"+raddress+"','"+fcity+"','"+fzip+"','"+fcountry+"','"+fphone+"','"+fmail+"','"+fvnumber+"','"+fpassword+"','"+fconfirmpassword+"')");
//out.println("Data is inserted successfully");
//alert("successfully Registered.");
%>
<div id="tab1"  style="background-color:#0CF; border-bottom-style:solid; border-bottom-color:#30F; color:#FFF; width:600px; height:200px" align="center">
<br />
<br />
<br />
<font face="Trebuchet MS, Arial, Helvetica, sans-serif" size="+2">
Thank You For Your Registration</font>
<br />
<br />
<br />
<font face="Verdana, Geneva, sans-serif" size="+1">
You Have Successfully Registered.</font>
<br />
<br />
<br />
<br />
<a href="general.html"><input align="middle" type="button" class="button"  value="Back To Home" onclick="general.html"/></a>&nbsp;&nbsp;
<a href="login.jsp"><input align="middle" type="button" class="button"  value="Login" onclick="login.jsp"/></a>
</div>



<%
}
catch(Exception e)
{
	out.println(e);
}
}
%>
</body>
</html>