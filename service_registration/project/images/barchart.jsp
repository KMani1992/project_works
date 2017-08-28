<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<%@ page import="java.io.*,java.util.Date" %>
<%@ page import="javax.servlet.*,java.text.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
	
		.userta
	{
		
		border-color:#ffffff;
		
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
<body bgcolor="#ffffff">


<%

String ba1=null;
String ba2=null;
String ba3=null;
String ba4=null; 
String ba5=null;
String ba6=null;
String ba7=null;
String ba8=null; 
String ba9=null; 


String vnum=request.getParameter("vn");



try
{
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection connection=DriverManager.getConnection(ss);
//Statement st=con.createStatement();
Statement statement = connection.createStatement();

ResultSet re=statement.executeQuery("select * from details where vehiclenumber='"+vnum+"'");
while(re.next())
{
	
vehicle=re.getString("vehiclenumber");
ba1=re.getString("battery");	
ba2=re.getString("engine");
ba3=re.getString("suspensions");
ba4=re.getString("brakes");
ba5=re.getString("exterior");
ba6=re.getString("tyres");
ba7=re.getString("electrical");
ba8=re.getString("seats");
ba9=re.getString("overal");
}
if(vnum.equals(vehicle))
{
	
	out.println("success");

%>

<div class="align">
<table align="right" cellpadding="2px" cellspacing="2px">
<tr><td class="userelcome"><%=dname%> </td><td>|</td><td><a href="index.html" style="color:#000">Logout</a></td>
<td>|</td><td><a href="#" style="color:#000">Contact Us</a></td>
<td>|</td><td><a href="#" style="color:#000">About Us</a></td>
</tr>
</table></div>
<br /><br />
<center>
<div id="banner">
</div>
<table cellpadding="0px" cellspacing="0px" align="center" width="1000px" height="40px">
<tr><td class="userwelcome"><strong><b>Welcome <%=dname%></b></strong></td></tr>
</table></center>
<div class="tot">
<div class="mid">
<div id="left">
<table style="margin-top:0px; padding-top:opx; white-space:0px">
<tr><td><a href="#" target="ifram"><img src="new/pserviceurcar.png" width="195" height="61"/></a></td></tr>
<tr><td><a href="services/sales.html" target="ifram"><img src="new/ptobuyold.png" width="195" height="61"/></a></td></tr>
<tr><td><a href="services/insurencerenew.html" target="ifram"><img src="new/homebtmo.png" width="195" height="61"/></a></td></tr>
<tr><td><a href="#" target="ifram"><img src="new/profile.jpg" width="195" height="55"/></a></td></tr>
<tr><td><a href="#" target="ifram"><img src="new/status.jpg" width="195" height="55"/></a></td></tr>
<tr><td>
<form action="barchart.jsp" method="post">
 <input type="text" name="vn" value="<%=vehicle%>" style="display:none" />
<img src="new/chart.jpg" width="195" height="55"/>

</form></td></tr>

<tr><td><a href="#" target="ifram"><img src="new/workshop.gif" width="200" height="33"/></a></td></tr>
<tr><td><a href="services/sales.html" target="ifram"><img src="new/query.gif" width="200" height="33"/></a></td></tr>
<tr><td><a href="services/insurencerenew.html" target="ifram"><img src="new/feedback.gif" width="200" height="33"/></a></td></tr>



</table>

</div>

<div id="center">
<table align="center" width="590px">
<tr><td><img src="new/myAdvertsieBanner.jpg" width="590px" height="156" /></td></tr>
</table>

<%
}
%>


</div>
<div id="right" style="padding:3px">
<table align="center" border="0" cellpadding="0" cellspacing="0">
  <tbody><tr valign="top">
    <td align="center" width="210">

    <table border="0" cellpadding="0" cellspacing="0" width="210">
        <tbody><tr>
          <td><img src="book-new-vehicle_files/spiral.jpg" height="19" width="200" align="right"></td>
        </tr>
        <tr>
          <td background="book-new-vehicle_files/why-bg1.gif"><img src="book-new-vehicle_files/why-us.gif" height="28" width="210"></td>
        </tr>
        <tr>
          <td  class="margin" align="left" background="book-new-vehicle_files/why-bg1.gif" > <p><img src="book-new-vehicle_files/why-us-ico.jpg" align="left" height="16" width="37">
          <br>We
 provide attractive facilities and personalized care to our customers. 
Our facilities are unmatchable &amp; state of art. We specialize in: </p>
            <ul type="none">
              <li>Finance</li>
              <li>Exchange Schemes</li>
              <li>Personalized Care</li>
              <li>Experience</li>
			  
              <li>Insurance Renewal For Old Two Wheelers </li>
            </ul>
            <div class="call"><img src="book-new-vehicle_files/helpdesk.gif" border="0" height="17" width="87"><br>
    Let us serve you better...</div>
            <br>
    </td>
        </tr>
        <tr>
          <td background="book-new-vehicle_files/why-bg1.gif"><img src="book-new-vehicle_files/why-btm.gif" height="13" width="210"></td>
        </tr>
      </tbody></table>

     </tr>
</tbody></table>
 
<center>

<table cellpadding="3" cellspacing="0" id="news" style="border:solid #058cea" align="center" width="210px">

<tr><td align="center" style="padding-top:0px;margin:0, auto;border-bottom:dotted thin #666;background:#8fcaf2; font-size:18px" class="newsoff">Quick News *</td></tr>
<tr><td>
<marquee direction="up" align="middle" onmouseout="this.start()" onmouseover="this.stop()" scrolldelay="100">
<center><font style="text-decoration:none; font-size:16px" face="Verdana, Geneva, sans-serif" ><br />Welcome To Durairaj Auto Works</font>
<br /><br><font style="text-decoration:none" face="Verdana, Geneva, sans-serif" size="-1">Take 3 Simultaneously & <br /><br />
Get FREE 4th Service</font>
</center>
</marquee><br>
</td></tr>
</table>
</center>
</div>
</div>

</div>

     	     	<div id="wrap" class="bott">
        	
				<div id="footer">
					<div id="footer_column">
						<div id="footer_con_bg">
							<div id="footer_con_top">
								<div id="footer_con_bot">
									<div class="foot_col1">
										<h3 class="userta">Contact Information</h3>
                            <div  class="pad_left" class="userta" style="background: url(imagess/home.png) no-repeat left center; font-family:Verdana, Geneva, sans-serif; font-size:12px">
                                11 - 42, Pampanvilai
                            </div>
                            <div class="pad_left" class="userta" style="font-family:Verdana, Geneva, sans-serif; font-size:12px">
                                Anantha Nadar Kudi P.O
                            </div>
                            <div class="pad_left" class="userta" style="font-family:Verdana, Geneva, sans-serif; font-size:12px">
                            K.K Dt, Pin: 629 201.
                                
                            </div>
                            <br />
                            <div class="pad_left" class="userta" style="background: url(imagess/phone.png) no-repeat left center; font-family:Verdana, Geneva, sans-serif; font-size:12px">
                                Ph: 944 290 6489
                            </div> <br />
                            
                            <div class="pad_left" class="userta" style="background: url(imagess/contact.png) no-repeat left center; font-family:Verdana, Geneva, sans-serif; font-size:12px">
                                E-mail:drauworks@gmail.com
                            </div>
                        </div>
                        <div class="foot_col2">
                            <h3>Our Services</h3>
                            <div id="menu3">
                            
		<ul type="none">
			<li><a href="#1" title="Link 1">Chain and Sprocket kits fitting</a></li>
			<li><a href="#2" title="Link 2">Performance parts fitting</a></li>
			<li><a href="#3" title="Link 3">Cylinder replating and relining</a></li>
			<li><a href="#4" title="Link 4">Headstock bearings replacement</a></li>
			<li><a href="#5" title="Link 5">Engine rebuilds</a></li>	
            <li><a href="#4" title="Link 4">Crank rebuilds</a></li>
			<li><a href="#5" title="Link 5">Tyre fitting</a></li>	
		</ul>
</div>

                        </div>
                        <div class="foot_col3">
                            <h3>New Arrivels</h3>
                            <a href="#"><img src="imagess/hero_honda_passion_pro_bike.jpg" alt="" width="200px" height="120px" title="" style="padding-bottom: 10px;"/></a>
                            <p>Passion Pluss is the new model of Hero Company,It's very advance model of all fittings parts and we are specilized for alternete their feutures. </p>
                        </div>
                        <div class="foot_col4">
                            <h3>Safty Tips</h3>
							<h2>Wear Healmet and save Life. </h2>
							<p>Check Before bike Riding: Break, Cluch, Feuel,Tyre.  </p>
							
							<br />
							<div id="foot-navi">
                            
                            <br />
                            <br />
	<p class="foot-navi-link "><a class="a2a_dd" href="http://www.addtoany.com/share_save#url=www.yamaha-motor-india.com&amp;title=Service%20%7C%20India%20Yamaha%20Motor%20Pvt.%20Ltd.&amp;description="><img src="index_files/share_save_120_16.gif" alt="Share/Save/Bookmark" border="0" height="18" width="120"></a><script type="text/javascript">a2a_linkname=document.title;a2a_linkurl="www.yamaha-motor-india.com";</script><script type="text/javascript" src="index_files/page.js"></script>
    </p>
	</div>
                        </div>
                        <div style="clear: both"></div>								
								</div>
							</div>
						</div>
					</div>
					<div id="footer_bot">
						<p>Copyright&nbsp;&copy;&nbsp;2012. <a href="#">Privacy Policy</a> | <a href="#">Terms of Use</a> | <a href="#" title="This page validates as XHTML 1.0 Transitional"><abbr title="eXtensible HyperText Markup Language">Home</abbr></a> | <a href="#" title="This page validates as CSS"><abbr title="Cascading Style Sheets">About us</abbr></a></p>
                    <!-- Please DO NOT remove the following notice --><p>Design by <a href="http://www.metamorphozis.com/" title="Flash Templates">Workshop</a></p><!-- end of copyright notice-->
					</div>
				</div>	
        	</div>
        </div>
</div>
<%
	}
	else
	{
		 message="Login Faild Check Vehicle No and Password";
      response.sendRedirect("login.jsp?error="+message);
	}}
	catch(Exception e)
	{
		out.println(e);
	}

%>
</body>
</html>