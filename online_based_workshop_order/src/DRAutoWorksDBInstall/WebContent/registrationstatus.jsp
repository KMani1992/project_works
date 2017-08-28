<% if(session.getAttribute("Username")!=null){ %>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
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
	<link rel="stylesheet" type="text/css" href="style/headerstyle.css">
			
	<script src="js/modernizr-2.6.2.min.js"></script>
	
	<script type="text/javascript" src="action.js"></script>
	<script type="text/javascript" src="ajaxaction.js"></script>
	<script type="text/javascript" src="jquery-1.8.2.js"></script>
	
	<link href="style/jquery.mCustomScrollbar.css" rel="stylesheet" />
		
<title> :: DRAUWorks - RegistrationStatus :: </title>
</head>
<body onload="regstatusview()">
	<div class="container">
			<!-- Top Navigation -->
			<%@include file="welcomeheader.jsp" %>
			<div id="pagehead" >Registration Status</div>
			
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
					<!--	profupd start	-->
					<div id="regstatus">
						<div class="pghd"><strong>Problem Status</strong></div>
						<div id="regstatuscontent_1" class="regstatuscontent"> 				
							<table id="regstatustb" cellpadding="0px" cellspacing="0px">												
							</table>					
						 </div> 
						 <div class='pghd'><strong></strong></div>
						 <div class="regststats">Total No Of Registeration : <span id="rgstttr"></span></div> 
					</div>
					<!--	profupd end	-->
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
		
		<!-- Custom ScrollBar Start -->
	<script>!window.jQuery && document.write(unescape('%3Cscript src="js/jquery-1.9.1.min.js"%3E%3C/script%3E'))</script>
	<!-- custom scrollbars plugin -->
	<script src="js/jquery.mCustomScrollbar.concat.min.js"></script>
	<script>
		//(function($){
			//$(window).load(function(){				
				//$("#regstatuscontent_1").mCustomScrollbar({
					//scrollButtons:{
						//enable:true
					//}
				//});
			//});
		//})(jQuery);		
	
	</script>
		
		<!-- CustomScrollBarEnd -->		
<%@include file="loadingscreen.jsp" %>
<%@include file="PopUpWindow.jsp"%>		
</body>
</html>
<% }else{
	out.print("You Are Not Authorized For This Page");
}
%>