<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>User Registration</title>

</head>

<body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0" onload="view()">
<%
String rname=request.getParameter("name");
String raddress=request.getParameter("address");
String fcity=request.getParameter("city");
String fzip=request.getParameter("zip");
String fcountry=request.getParameter("country");
String fphone=request.getParameter("phone");
String ffax=request.getParameter("fax");
String fmail=request.getParameter("mail");
//String fpassword=request.getParameter("password");
//String fconfirmpassword=request.getParameter("confirmpassword");
String fvnumber=request.getParameter("vnumber");
String fproduct=request.getParameter("product");
String fother=request.getParameter("other");
String fdd=request.getParameter("dd");
String fmm=request.getParameter("mm");
String fyy=request.getParameter("yy");
String ftt=request.getParameter("tt");
String fproblem=request.getParameter("problem");
String fremark=request.getParameter("remark");
//out.println(rname);
if(rname==""||raddress==""||fcity==""||fzip==""||fcountry==""||fphone==""||ffax==""||fmail==""||fvnumber==""||fproduct==""||fother==""||fdd==""||fmm==""||fyy==""||ftt==""||fproblem==""||fremark==""||)
{%>
<script type="text/javascript">
alert("please fill all the field");
</script>
<%}
else
{

try
{
	request.setCharacterEncoding("UTF-8");
Connection conn = null;
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";

conn = DriverManager.getConnection( db );
Statement stmt = conn.createStatement();
//PreparedStatement ps=null; 
//Statement st=conn.createStatement();
//PreparedStatement ps=null;
String ps = "update details set fullname='"+rname+"' where vehiclenumber='"+fvnumber+"'"; 
//int i=st.executeUpdate("update details set fullname='"+rname+"',address='"+raddress+"',city='"+fcity+"',zipcode='"+fzip+"',state='"+fcountry+"',phone'"+fphone+"',fax='"+ffax+"',email='"+fmail+"',product='"+fproduct+"',other='"+fother+"',dd='"+fdd+"',mm='"+fmm+"',yy='"+fyy+"',tt='"+ftt+"',problem='"+fproblem+"',remark='"+fremark+"' where vehiclenumber='"+fvnumber+"'");
ResultSet rs = stmt.executeUpdate(ps);
out.println("Data is updated successfully");

out.println("Data is inserted successfully");
}
catch(Exception e)
{
	out.println(e);
}

}


%>

</body>
</html>