<%@ page language="java" import="java.sql.*" errorPage="" %>
<%@ page import="java.io.*,java.util.Date" %>
<%@ page import="javax.servlet.*,java.text.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>User Page</title>
 <link href="shailey.css" rel="stylesheet" type="text/css">
<style type="text/css">
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
.align
{
	padding-right:40px;
	margin-right:150px;
}
a:hover
{
	border-top:#001842;
	border-top-style:solid;
	border-width:medium;
}
a
{
	text-decoration:none;
}
.tot
{
	width:1500px;
	
}
.mid
{
	width:1500px;
	
}
.bott
{
	float:center;

	margin-top:0px;
	padding-top:0px;
	padding-left:0px;
	margin-left:0px;
	
}
#menu3 {
	width: 200px;
	margin:0px;
	
	
	}
	
#menu3 li a {
	height: 32px;
  	voice-family: "\"}\""; 
  	voice-family: inherit;
  	height: 24px;
	text-decoration: none;
	}	
	
#menu3 li a:link, #menu3 li a:visited {
	color: #8BADCF;
	display: block;
	background:  url(menu3.gif);
	padding: 8px 0 0 10px;
	}
	
#menu3 li a:hover {
	color: #627EB7;
	background:  url(menu3.gif) 0 -32px;
	padding: 8px 0 0 10px;
	}
	.usertab
	{
		
		border-color:#ffffff;
		text-align:center;
		font-family:Georgia, "Times New Roman", Times, serif;
		font-size:14px;
	}
	
</style>

		<script type="text/javascript" src="lib/jquery-1.3.2.min.js"></script>
		<script type="text/javascript" src="lib/jquery.tools.js"></script>
    	<script type="text/javascript" src="lib/jquery.custom.js"></script>
		
<!-- Pirobox setup and styles -->

<script type="text/javascript" src="lib/pirobox.js"></script>
<script type="text/javascript">
$(document).ready(function() {
	$().piroBox({
			my_speed: 400, //animation speed
			bg_alpha: 0.1, //background opacity
			slideShow : false, // true == slideshow on, false == slideshow off
			slideSpeed : 4, //slideshow duration in seconds(3 to 6 Recommended)
			close_all : '.piro_close,.piro_overlay'// add class .piro_overlay(with comma)if you want overlay click close piroBox

	});
});
</script>

<link href="imagess/style.css" rel="stylesheet" type="text/css" /> 

<!-- Pirobox setup and styles end-->

        <link href="styles.css" rel="stylesheet" type="text/css" media="screen" />
<link href="stylesheet.css" rel="stylesheet" type="text/css" />
<link href="style.css" rel="stylesheet" type="text/css" />










</head>
<body bgcolor="#FFFFFF">
<%
String vehicle=null;
String pword=null;



/*String cname=null;
String cadd=null;
String =null;
String pword=null;
String pword=null;
String pword=null;*/
String message;
String vno=request.getParameter("vnumber");
String pass=request.getParameter("password");
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
		 
		
	%>
    <div id="center">
<table align="center" width="590px">
<tr><td><img src="new/myAdvertsieBanner.jpg" width="590px" height="156" /></td></tr>
</table>

 <table cellpadding="2px" cellspacing="2px" align="center" width="590px" bgcolor="#cdeefe" style="margin-top:0px">
                                     <tr> <td id="text" style="padding:8px; background-image:url(new/abouttopbg.gif); background-position:right; background-repeat:no-repeat; "><div align="justify" class="text12"><p><strong><p align="center">Our Vision
                                     <br />
                                    
                                     </p class="userta"> </strong>
                                     On this page you have an overview of all your status on BIKES.</p>
                                     
                                     
                                     <br />
                                     <p class="userta">
                                     
You can edit the status, see details and change your Profile. You can upgrade at any time, but if the credits aren't all used,
 they still will be lost. 
Your package will be renewed as of the moment you choose to pay.

<br /></p></div></td></tr></table>



<p style="background-color:#036; color:#FFF; font-size:18px; width:570" align="center">Your Status</p>
<table cellpadding="0px" cellspacing="0px" width="590px" border="1px" height="180px" bgcolor="#cdeefe" align="center" class="usertab">

<tr bgcolor="#FFCC99"><td>Fullname</td><td>manikandan</td></tr>
<tr><td>Vehicle No</td><td>tn 74 1234</td></tr>
<tr bgcolor="#FFCC99"><td>Your Checking date</td><td><%
Date df=new Date();
SimpleDateFormat ft=new SimpleDateFormat("d");

String s= ft.format(df);
int a=Integer.parseInt(s);
int b=30-a;
out.print(b);

%></td></tr>


<tr><td>Date</td><td>

<%
   Date dNow = new Date( );
   SimpleDateFormat ft = 
   new SimpleDateFormat ("d.m.y ");
   out.print(  ft.format(dNow));
%>
</td></tr>


</table>
</div>
    
    
    
    
    
    
   
  
    
    
        
	<%}
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

</body>
</html>