<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<%
String error=request.getParameter("error");
if(error==null || error=="null"){
 error="";
}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Login Page</title>
<style type="text/css">
.style
{
	-moz-border-radius:10px;
	-webkit-border-radius:10px;
}
.sstyle
{
	border-top-left-radius:10px;
	border-top-right-radius:10px;
	
	
}
a
{
	text-decoration:none;
}
.divst
{
	background:"#8fcaf2"; 
	border-color:#09F;
	width:500px;
	height:430px;
	 border:solid;
	 float:center;
	 -moz-border-radius:10px;
	-webkit-border-radius:10px;
	  border-width:2px;
		 
	  
}
.error
{
	color:#C00;
	text-align:right;
}
</style>
<script type="text/javascript">
function check()
{
	var no=document.forms[0].vnumber.value;
    var pass=document.forms[0].password.value;
	//document.getElementById("").style.display="none"
	if(no==""||pass=="")
	{
	if(no=="")
	{
    document.getElementById("verror").style.display="block";
	return false;
	}
	else if(pass=="")
	{
		document.getElementById("perror").style.display="block";
			return false;
	}
	else if(pass==""&&no=="")
	{
		document.getElementById("perror").style.display="block";
		document.getElementById("verror").style.display="block";
			return false;
	}
	else if(pass!=""&&no!=="") 
	{
		document.getElementById("perror").style.display="none";
		document.getElementById("verror").style.display="none";
			return false;
	}
	}
	else
	{
	return true;
	}
	//alert("hai");
}
</script>

</head>

<body>
<center>
<div class="divst" align="center" style="margin-top:40px; padding-top:0px">
<div style="background:#99C; margin-top:0px; padding-top:0px" class="sstyle">
<span style="font-size:18px; color:#F03;"><strong>LOGIN</strong></span></div>
<div style="margin:0px; padding:0px"><img src="new/ContactBanner.jpg" width="500px" height="156px"/> 
</div>

<form onsubmit="return check();" action="userpage.jsp" target="_new" method="post">
<table cellpadding="0px" cellspacing="0px" width="250px" height="200px">
<tr><td>
VehicleNo :</td><td><input name="vnumber"/></td></tr>
<tr ><td></td><td class="error" style="display:none" id="verror">Enter Vehicle Number</td></tr>
<tr><td>Password :</td><td><input type="password" name="password" /></td></tr>
<tr ><td></td><td class="error" style="display:none" id="perror">Enter Password</td></tr>
<span class="error"><%=error%></span>
<tr><td></td><td align="left"><input type="submit" value="Signin"/>&nbsp;<a href="userregistration.jsp"><input type="button"  value="Signup"/></a></td></tr>
</table>
</form>
<table align="left">
<tr><td><a href="#">Forget Password?</a></td><td align="right"></td></tr><tr><td><a href="http://fb.com"><img src="new/facebook-login.png" width="154" height="22" /></a></td></tr>
</table>
</div>
</center>
</body>
</html>