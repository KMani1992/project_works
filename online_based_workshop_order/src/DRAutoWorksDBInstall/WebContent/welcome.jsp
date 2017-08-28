<% if(session.getAttribute("Username")!=null){ %>
<!DOCTYPE html>
<html lang="en" class="no-js">
	<head>
		<meta charset="UTF-8" />
		<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"> 
		<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
		<title> :: DuraiRajAutoWorks - Welcome :: </title>
		
		<link rel="shortcut icon" href="../favicon.ico">
		<link rel="stylesheet" type="text/css" href="css/normalize.css" />
		<link rel="stylesheet" type="text/css" href="css/demo.css" />
		<link rel="stylesheet" type="text/css" href="css/component1.css" />
		<link rel="stylesheet" type="text/css" href="style/drautoworksmasterstyle.css">		
		<script src="js/modernizr-2.6.2.min.js"></script>
	</head>
	<body>		
		<div class="container">
			<!-- Top Navigation -->
			<%@include file="welcomeheader.jsp" %>
			<div id="pagehead" >Welcome</div>
			<div class="component">
				<!-- Start Nav Structure -->
				<%@include file="menu.jsp"%>
				<!-- End Nav Structure -->
			</div>
		</div><!-- /container -->
		<script src="js/polyfills.js"></script>
		<script src="js/demo1.js"></script>
	</body>
</html>
<% }else{
	out.print("You Are Not Authorized For This Page");
}
%>