<% if(session.getAttribute("Username")!=null){ %>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%
     final String pgtitle = request.getParameter("pgtitle");
     final String status = request.getParameter("status");    
    %>
<!DOCTYPE html>
<html>
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">		 
	<meta name="viewport" content="width=device-width, initial-scale=1.0">				
	<link rel="shortcut icon" href="../favicon.ico">
	<link rel="stylesheet" type="text/css" href="css/normalize.css" />
	<link rel="stylesheet" type="text/css" href="css/demo.css" />
	<link rel="stylesheet" type="text/css" href="css/component1.css" />
	<link rel="stylesheet" type="text/css" href="style/drautoworksmasterstyle.css">	
	<link rel="stylesheet" type="text/css" href="style/DBInstallMaster.css">
		
	<script type="text/javascript" src="js/modernizr-2.6.2.min.js"></script>
	<script type="text/javascript" src="action.js"></script>
	<script type="text/javascript" src="ajaxaction.js"></script>
	
<title> :: DRAUWorks - BookRegistration :: </title>
</head>
<body>
		<div class="container">
			<!-- Top Navigation -->
			<%@include file="welcomeheader.jsp" %>
			<div id="pagehead" ><%=pgtitle %></div>
			<div id="registrinner">
			<div id="registrinnerhead">
			<div id="registrinnerheadleft">
				<a href="profile.jsp" title="View My Profile"><img src="images\motor_bike_booking.png" alt="Profile Picture" title="View My Profile"/></a>
			</div>
			<div id="registrinnerheadright">
			<table id="pginmobikinfo" cellpadding="2px" cellspacing="2px">
			<tr>
			<td class="bokrgmbkdt">MotorBikeNo </td><td class="bokrgmbkdt">:</td><td class="bokrgmbkdtval"><%if(session.getAttribute("MoBikeNo")!=null){out.print(session.getAttribute("MoBikeNo").toString().toUpperCase());}else{out.print("--Nill--");} %></td>
			</tr>			
			<tr>
			<td class="bokrgmbkdt">MotorBikeName </td><td class="bokrgmbkdt">:</td><td class="bokrgmbkdtval"><%if(session.getAttribute("MoBikeName")!=null){out.print(session.getAttribute("MoBikeName").toString().toUpperCase());}else{out.print("--Nill--");} %></td>
			</tr>
			</table>
			</div>						
			</div>
			<!-- MainArea Start	-->
			<div id="registrinnerpbm">
				<div id="registrinnerpbminner">								
					<h3><%=status %></h3>
				</div>	
			</div>
			<!-- MainArea End	-->
			</div>
			<!-- Container End	-->
			<div class="component">
				<!-- Start Nav Structure -->
				<%@include file="menu.jsp"%>
				<!-- End Nav Structure -->
			</div>
		</div><!-- /container -->
		<script src="js/polyfills.js"></script>
		<script src="js/demo1.js"></script>
		<%@include file="loadingscreen.jsp" %>
</body>
</html>
<% }else{
	out.print("You Are Not Authorized For This Page");
}
%>