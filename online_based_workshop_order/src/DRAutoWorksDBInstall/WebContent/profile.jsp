<% if(session.getAttribute("Username")!=null){ %>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"    pageEncoding="ISO-8859-1"%>
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
				
		<script src="js/modernizr-2.6.2.min.js"></script>		
		<script type="text/javascript" src="action.js"></script>
		<script type="text/javascript" src="ajaxaction.js"></script>
		<title> :: DuraiRajAutoWorks - MyProfile :: </title>
</head>
<body onload="pwordupd();">

<div class="container">
			<!-- Top Navigation -->
			<%@include file="welcomeheader.jsp" %>
			<div id="pagehead" >Profile Status</div>
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
			<tr>
			<td class="bokrgmbkdt">E-MailAddres </td><td class="bokrgmbkdt">:</td><td class="bokrgmbkdtval"><%if(session.getAttribute("EmailAddr")!=null){out.print(session.getAttribute("EmailAddr").toString().toUpperCase());}else{out.print("--Nill--");} %></td>			
			</tr>
			</table>
			</div>						
			</div>
			<!-- MainArea Start	-->
			<div id="registrinnerpbm">
				<div id="registrinnerpbminner">								
					<!--	profupd start	-->
					<div id="profupd">
					<form name="frmproupd" method="post" id="frmproupd">					
						<div class="pghd"><strong>Profile Information</strong></div>
						<table id="profupdtb">																						
						<tr>
						<td class="preofilelables">Name :</td><td class="preofilelables" >MobileNumber :</td>
						</tr>
						<tr>
						<td class="preofilevalues"><input type="text" id="custname" class ="txtpu" value="<% out.print(session.getAttribute("Username").toString().toUpperCase()); %>"  name="custname" placeholder="Enter Your Name" autofocus required ></td><td class="preofilelables"><input type="number" id="mobileno"  class ="txtpu" name="mobieno" value="<% out.print(session.getAttribute("MobieNo")); %>" placeholder="Enter Your Mobile Number" required ></td>
						</tr>
						
						<tr>
						<td id="profupdvspc"></td><td></td>
						</tr>
						
						<tr>
						<td class="preofilelables">MotorBikeNo :</td><td class="preofilelables">MotorBikeName :</td>
						</tr>
						<tr>
						<td class="preofilevalues"><input type="text" id="motbikeno" value="<%out.print(session.getAttribute("MoBikeNo").toString().toUpperCase()); %>" class ="txtpu" name="motbikeno" placeholder="Enter Your MotorBike Number" required ></td><td class="preofilelables"><input type="text" id="motbikename" class ="txtpu" value="<%out.print(session.getAttribute("MoBikeName").toString().toUpperCase()); %>" name="motbikename" placeholder="Enter Your MotorBike Name"></td>
						</tr>
						
						<tr>
						<td id="profupdvspc"></td><td></td>
						</tr>
						
						<tr>
						<td><input type="button" value="Update" class="btn" onclick="profupdtvalidate();">
						<input type="reset" value="Cancel" class="btn"></td>
						</tr>
												
						</table>						
					</form>
					
					<!--	horiz line	-->
					<div class="pghd"><strong></strong></div>
					<button id="chngpwd" class="btn" onclick="chngpwdscr();">Change Password</button>
					</div>
					<!--	profupd end	-->
					
					
					
					<!--	pwordchng start	-->
					<div id="pwordchng">
					<form name="frmpwdchng" id="frmpwdchng" >					
						<div class="pghd"><strong>Login Information</strong></div>
						<table id="profupdtb">																						
						<tr>
						<td class="preofilelables">Old Password :</td>
						</tr>
						<tr>
						<td class="preofilevalues"><input type="password" id="custregoldpassword" class ="txtpu" name="custregoldpassword" placeholder="Enter Your Old Password" autofocus required ></td>
						</tr>
						
						<tr>
						<td id="profupdvspc"></td><td></td>
						</tr>
						
						<tr>
						<td class="preofilelables">New Password :</td><td class="preofilelables">Confirm Password :</td>
						</tr>
						<tr>
						<td class="preofilevalues"><input type="password" id="custregpassword" class ="txtpu" name="custregpassword" placeholder="Enter Your New Password" required ></td><td class="preofilevalues"><input type="password" id="custregconfirmpassword" class ="txtpu" name="custregconfirmpassword" placeholder="Confirm Password"></td>
						</tr>
						
						<tr>
						<td id="profupdvspc"></td><td></td>
						</tr>
						
						<tr>
						<td><input type="button" value="Change Password" class="btn" onclick="chngpwdvalidate();">
						<input type="reset" value="Cancel" class="btn"></td>
						</tr>
												
						</table>						
					</form>
					
					<!--	horiz line	-->
					<div class="pghd"><strong></strong></div>
					<button id="goback" class="btn" onclick="goback();">GO Back</button>
					</div>
					<!--	Pwordchng end	-->
					
					
					
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
		<%@include file="loadingscreen.jsp" %>
		<script type="text/javascript" src="jquery-1.8.2.js"></script>		
		<script src="js/polyfills.js"></script>
		<script src="js/demo1.js"></script>
	</body>
</html>
<% }else{
	out.print("You Are Not Authorized For This Page");
}
%>