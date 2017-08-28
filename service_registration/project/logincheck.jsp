<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>logincheck</title>
</head>

<body>
<%
String vnum=request.getParameter("vnumber");
String pass=request.getParameter("password");

//out.println(vnum);

try
{
Class.forName("sun.jdbc.odbc:JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection con=DriverManager.getConnection(ss);
Statement st=con.create Statement();

ResultSet re=st.executeQuery("select * from details where vehiclenumber='"+vnum+"'");
while(re.next())
out.println("success");
st.close();
con.close();
}
catch(Exception e)
{
	out.println(e);
}

%>

</body>
</html>