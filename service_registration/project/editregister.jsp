<%@ page language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Durairaj auto works</title>
<link href="stylesheet.css" rel="stylesheet" type="text/css" />
<link href="style.css" rel="stylesheet" type="text/css" />
</head>
<%
String vehicle=null;
//String pword=null;
/*String cname=null;
String cadd=null;
String =null;
String pword=null;
String pword=null;
String pword=null;*/
//String message;
String vno=request.getParameter("vnumber");
//String pass=request.getParameter("password");
out.println(vno);
out.println(pass);
try
{
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection connection=DriverManager.getConnection(ss);
//Statement st=con.createStatement();
Statement statement = connection.createStatement();

ResultSet re=statement.executeQuery("select * from details where vehiclenumber='"+vno+"'");
while(re.next())
{
vehicle=re.getString("vehiclenumber");
pword=re.getString("password");
out.println(vehicle);
out.println(pword);
}

	if(vno.equals(vehicle))
	{
		out.println("success");
	%>
   
    
 
        
	<%}
   else
    {
      //message="No user or password matched" ;
     // response.sendRedirect("login.jsp?error="+message);
	 out.println("faill");
	 
    }
    }
    catch(Exception e)
    {
        out.println(e);
    }

    
    /// close object and connection
  
%>

</body>
</html>