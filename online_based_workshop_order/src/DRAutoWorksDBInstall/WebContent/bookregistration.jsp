<% if(session.getAttribute("Username")!=null){ %>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
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
<body onload="clcon();">
		<div class="container">
			<!-- Top Navigation -->
			<%@include file="welcomeheader.jsp" %>
			<div id="pagehead" >Book My Registration</div>
			<div id="registrinner">
			<div id="registrinnerhead">
			<div id="registrinnerheadleft">
				<a href="profile.jsp" title="View My Profile"><img src="images\motor_bike_booking.png" alt="Profile Picture" title="View My Profile"/></a>
			</div>
			<div id="registrinnerheadright">
			<table id="pginmobikinfo" cellpadding="2px" cellspacing="2px">
			<tr>
			<td class="bokrgmbkdt">MotorBikeNo <input type="hidden" value="<% out.print(session.getAttribute("EmailAddr")); %>" id="hidemailaddr"><input type="hidden" id="hidmobikno" value="<% out.print(session.getAttribute("MoBikeNo")); %>"></td><td class="bokrgmbkdt">:</td><td class="bokrgmbkdtval"><%if(session.getAttribute("MoBikeNo")!=null){out.print(session.getAttribute("MoBikeNo").toString().toUpperCase());}else{out.print("--Nill--");} %></td>
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
					<form name="frmregbpm" method="post" id="frmregbpm"  action="servletbookregistration">						
						<table id="probregtb">
						<tr>
						<td>
						<div class="pghd"><strong>Enter Your Problems ... With The Reference Of Bellow Mentioned Note</strong></div>
						</td>
						</tr>
						<tr>
						<td>
						<textarea id="pbid" placeholder="Enter Your Problems ... With The Reference Of Bellow Mentioned Note" name="pbid" required></textarea>
						</td>
						</tr>
						<tr>
						<td><input type="button" value="Submit" class="btn" onclick="pbmbookingvalidate();">
						<input type="reset" value="Cancel" class="btn"></td>
						</tr>
						<tr></tr>
						<tr>
						<td><small>Note : Use Comma For Each Problems Seperation, Ex : problem1,problem2</small> </td>
						</tr>
						</table>						
					</form>	
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
		<script type="text/javascript">
			function clcon(){
				document.getElementById("pbid").value="";
				document.getElementById("pbid").focus();
			}
		</script>
		<script src="js/polyfills.js"></script>
		<script src="js/demo1.js"></script>
		<script type="text/javascript" src="jquery-1.8.2.js"></script>
		<%@include file="loadingscreen.jsp" %>
</body>
</html>
<% }else{
	out.print("You Are Not Authorized For This Page");
}
%>