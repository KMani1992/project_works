<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title> :: Student Circular Information Notification :: </title>
<link rel="stylesheet" type="text/css" href="masterstyle.css" />

<script type="text/javascript" src="action.js">
</script>

</head>

<body>
<?php

if(isset($_POST['login'])){	
//print_r($_POST);
	$dbhost="localhost:3306";
	$username="root";
	$password="";
	$dbname="acabala";
	$con=mysql_connect($dbhost,$username,$password);
	if(!$con){
		die('couldnot Connect' . mysql_error());
	}
	mysql_select_db($dbname);
	if(!get_magic_quotes_gpc()){
		$name=addslashes($_POST['usname']);
		$password=addslashes($_POST['pass']);
	}else{
	$name=$_POST['usname'];
	$password=$_POST['pass'];
	}
	$name = mysql_real_escape_string($name);	
	$password=mysql_real_escape_string($password);
	
	
	$sql="select count(*) cnt,staffid,name,password from staff where".
	" staffid='$name' and password='$password' group by staffid,name,password";
	//print_r($sql);
	$result=mysql_query($sql,$con);
	$row = mysql_fetch_assoc($result);
	if($row['cnt']<1){
		
		//die('' . mysql_error());

?>
<script type="text/javascript">

alert("UserName Or Password's are Incorrect Please GoBack and Try Again !!!.");

</script>

<?php
//header("Location: index.php");		
	}else{
		print("Success");
		session_start();
		if(!isset($_SESSION['username'])){
		$_SESSION['username']=$row['name'];
		$_SESSION['staffid']=$row['staffid'];
		}
		
		header("Location: adminpage.php");
		//print($_SESSION['staffid']);	
		mysql_close($con);
	}
}else{
?>
<div id="wrapper">
    <div id="inner">
    	<div id="header">
        <div id="header_left">
        <img src="images/logo.png" width="200px" height="100px" />
        </div>
        <div id="header_right">
        <h1>Sathyabama University</h1>
         <h3 align="right">Student Circular Information Notification</h3>
        </div>  
    
        </div>
        <div id="main">
        <h3 align="center">Admin Login</h3>
        
        <form method="post" action="<?php $_PHP_SELF ?>" name="frmloginin" onsubmit="return checkadminlog();" autocomplete="off">
        <table cellpadding="0px" cellspacing="0px" width="250px" height="170px" align="center">
        <tr><td>Staff ID :</td><td><input type="text" name="usname" id="usname" required="required" autofocus="autofocus"/></td></tr>
        
        <tr><td>Password :</td><td><input type="password" name="pass" id="pass" required="required" /></td></tr>
        
        <tr style="padding-top:0px">
        <td align="left"><input type="submit" value="Signin" name="login" id="login"/></td>
        <td align="left"><input type="reset" value="Reset"/></td>
        </tr>
        </table>
        </form>        
        </div>
    </div>
</div>
</body>
<?php
}
?>
</html>