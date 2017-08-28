<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>User Registration</title>
<link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 
</head>

<body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0" onload="view()">
<%
String rname=request.getParameter("name");
String rpassword=request.getParameter("password");
String rconfirmpassword=request.getParameter("confirmpassword");
String raddress=request.getParameter("address");
String fcity=request.getParameter("city");
String fzip=request.getParameter("zip");
String fcountry=request.getParameter("country");
String fphone=request.getParameter("phone");

String fmail=request.getParameter("mail");
//String fpassword=request.getParameter("password");
//String fconfirmpassword=request.getParameter("confirmpassword");
String fvnumber=request.getParameter("vnumber");
String fproduct=request.getParameter("product");

String fdd=request.getParameter("dd");
String fmm=request.getParameter("mm");
String fyy=request.getParameter("yy");
String ftt=request.getParameter("tt");
String fproblem=request.getParameter("problem");

if(rname==""||raddress==""||fcity==""||fzip==""||fcountry==""||fphone==""||fmail==""||fvnumber==""||fproduct==""||fdd==""||fmm==""||fyy==""||ftt==""||fproblem=="")
{%>
<script type="text/javascript">
alert("please fill all the field");
</script>
<%}
else
{
try
{
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection conn =DriverManager.getConnection( db );
Statement stmt = conn.createStatement();

String ps = "update details set fullname='"+rname+"',address='"+raddress+"',city='"+fcity+"',zipcode='"+fzip+"',state='"+fcountry+"',phone='"+fphone+"',email='"+fmail+"',vehiclenumber='"+fvnumber+"',product='"+fproduct+"',dd='"+fdd+"',mm='"+fmm+"',yy='"+fyy+"',tt='"+ftt+"',problem='"+fproblem+"',password='"+rpassword+"',confirmpassword='"+rconfirmpassword+"' where vehiclenumber='"+fvnumber+"'"; 
int k = stmt.executeUpdate(ps);
//out.println("Data is updated successfully");

//out.println("Data is inserted successfully");
stmt.close();
conn.close();
}
catch(Exception e)
{
	out.println(e);
}
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
%>


</body>
</html>