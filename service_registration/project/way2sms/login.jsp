<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
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
.error
{
	color:#C00;
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
<h1 align="center">Login</h1>
<form onsubmit="return check()" action="doLogin.jsp" method="post">
<table cellpadding="2px" cellspacing="2px" width="500px" height="400px" align="center" background:#8fcaf2" style="color:#000000; border:#999; border:solid; border-width:thin" class="style">
<tr><td>VehicleNo :</td><td><input name="vnumber" /></td></tr>
<tr ><td></td><td class="error" style="display:none" id="verror">Enter Vehicle Number</td></tr>
<tr><td>Password :</td><td><input type="password" name="password" /></td></tr>
<tr ><td></td><td class="error" style="display:none" id="perror">Enter Password</td></tr>
<tr align="center"><td></td><td><input type="submit"  value="Signin"/></td></tr>
<br />
<tr><td>Register</td></tr>
<tr><td>Forget Password?</td></tr>
</table></form>
</body>
</html>