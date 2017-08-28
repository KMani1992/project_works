<%@ page language="java" import="java.sql.*" errorPage="" %>
<%
String vehicle;
String pword;
String vno=request.getParameter("sUserName");
String pass=request.getParameter("sPwd");
out.println(vno);
out.println(pass);
/*try
{
Class.forName("sun.jdbc.odbc:JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection con=DriverManager.getConnection(ss);
Statement st=con.create Statement();

ResultSet re=st.executeQuery("select * from details where vehiclenumber='"+vno+"'");
while(re.next())
{
 vehicle=re.getString("vehiclenumber");
 pword=re.getString("password");
}

	if(vno==vehicle&&pass==pword)
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
        e.printStackTrace();
    }
    */
    
    /// close object and connection
  
%>