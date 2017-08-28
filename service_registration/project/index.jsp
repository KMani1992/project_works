<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>

<body>
<%
Connection conn = null;
String Event = new String("");

Statement stmt = null;
Statement stmt2 = null;

ResultSet rs = null;
ResultSet rs2 = null;

try
{
Class.forName( "sun.jdbc.odbc.JdbcOdbcDriver" );
String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\demo.mdb";

conn = DriverManager.getConnection( db );
stmt = conn.createStatement();
stmt2 = conn.createStatement();

rs = stmt.executeQuery( "SELECT * FROM NODESTABLE" );
rs2 = stmt2.executeQuery( "SELECT * FROM NODESTABLE" );

%><BR>Names<BR><%
while( rs.next() )
{
%>
this is a line from the DB:  "<%= rs.getString( "name" ) %>" <br>
<%
}

%><br>IDs<br><%
while( rs2.next() )
{
%>
this is a line from the DB:  "<%= rs2.getString( "regno" ) %>" <br>
<%
}
}

catch( ClassNotFoundException e )
{
%>
ClassNotFoundException: <%= e.getMessage() %>
<br>
<%
}
catch( Exception e )
{
%>
Unexpected error: <%= e.getMessage() %>
<br>
<%
}
finally
{
//Clean up resources, close the connection.
if( conn != null )
{
try
{
conn.close();
}
catch( Exception ignored )
{
}
}
}

%>

</body>
</html>