<%@ page language="java" import="java.sql.*" errorPage="" %>
<%
String vehicle=null;
String pword=null;
String message;
String vno=request.getParameter("sUserName");
String pass=request.getParameter("sPwd");
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

	if(vno.equals(vehicle)&&pass.equals(pword))
	{
		out.println("success");
	}
   else
    {
      message="No user or password matched" ;
      response.sendRedirect("login.jsp?error="+message);
    }
    }
    catch(Exception e)
    {
        out.println(e);
    }

    
    /// close object and connection
  
%>