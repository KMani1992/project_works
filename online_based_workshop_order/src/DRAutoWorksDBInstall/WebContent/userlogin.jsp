<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@include file="pageheader.jsp"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="shortcut icon" href="favicon.ico">
<link rel="stylesheet" type="text/css" href="style/DBInstallMaster.css">
<script type="text/javascript" src="action.js"></script>
<script type="text/javascript" src="ajaxaction.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title> :: DuraiRajAutoWorks :: </title>
</head>
<body>
    <div id="wrapper">
     <div id="inner">             
         
     </div>
    </div>
    <div id="loginback"></div>
    <div id="logininner">
    <div id="closebtn">X</div>    
    <!--<div><strong class="pghd">SignIn</strong></div>-->
    <form name="userlogin" autocomplete="off">       
    <div id="loghed">SignIn</div>
    <table id="userlogintb" align="left">    
    <tr>
    <td>E-Mail Address :</td><td><input name="logusername" id="logusername" class="txt"  type="text" autofocus required placeholder="Enter Your E-Mail Address" title="Enter Your E-Mail Address"></td>
    </tr>
    <tr>
    <td>Password :</td><td><input  name="logpassword" id="logpassword" class="txt"  type="password"  required placeholder="Enter Your Password" title="Enter Your Passworde"></td>
    </tr>
    <tr>
    <td ></td><td><input type="button" name ="logsubmit" value ="Login" class="btn" onclick="validateuserlogin();" ><input type="reset" value="Cancel" id="logcancel" class="btn" onclick="custlogsetfocus();"></td>
    </tr>
    <tr><td id="logresult"></td></tr>
    </table>
        
    </form>    
    </div>

<script type="text/javascript" src="jquery-1.8.2.js"></script>
<script>
$(document).ready(function(){
	//alert("chk");
		$("#loginback").fadeIn("slow");
		$("#logininner").fadeIn("slow");
		
	$("#closebtn").click(function(){
		$("#loginback").fadeOut("fast");
		$("#logininner").fadeOut("fast");
		});
});
</script>
<%@include file="loadingscreen.jsp" %>
</body>
</html>
 <%@include file="pagefooter.jsp"%>