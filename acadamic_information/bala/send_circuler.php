
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title> :: Student Circular Information Notification :: </title>
<link rel="stylesheet" type="text/css" href="masterstyle.css" />
<script type="text/javascript" src="action.js"></script>
<script type="text/javascript" src="jquery-1.7.1.js"></script>
<script type="text/javascript">

</script>
</head>
<body>
<?php
session_start();	
if(!empty($_SESSION['username'])){
$host="localhost:3306";
$username="root";
$password="";
$dbname="acabala";

$con=mysql_connect($host,$username,$password);
if(!$con){
	die('Could Not Connect'.mysql_error());
}else{
$qry="select stuname,sturegno,stucorse,stubranch,stuemail,".
	 "stumobileno,stuaddress,stuactive,acyfrom,acyto,stuaddeddate,".
	 "staffid from student order by sturegno;";
	 mysql_select_db($dbname);
	$result=mysql_query($qry,$con);
?>
<div id="wrapper">
    <div id="inner">
    	<div id="header">
        <div id="header_left">
       <a href="adminpage.php"><img src="images/logo.png" width="200px" height="100px" /></a>
        </div>
        <div id="header_right">
        <h1>Sathyabama University</h1>
         <h3 align="right">Student Circular Information Notification</h3>
        </div>  
    
        </div>
        <div id="header_menu">
        	<div id="header_menu_left">
            <a href="" onclick="popupShow();">Edit</a>&nbsp;|&nbsp;<a href="">Delete</a>
            </div>
			<div id="header_menu_right">
		<?php print('You are Currently Logged in : ' .$_SESSION['username'])?> &nbsp; | &nbsp; <a href="logout.php">Logout</a>            </div>
        </div>       
        <div id="main" style="padding-bottom:50px;padding-top:0px;">
 			<form name="sendcircul" onsubmit="return setemailvalue();" action="sendemailcircul.php" method="post">
            <table id="stuview" align="center" cellpadding="5px;" cellspacing="2px;" 
            border="1px;" bordercolorlight="#996600" bordercolor="#996600" bordercolordark="#996600" style="border-style:solid">
            <tr id="tabheader">
            <td>Select</td>
            <td>Student Name</td><td>RegisterNo</td><td>Course</td>
            <td>Branch</td>
            </tr>
             
            <?php 
			$cnt=1;
			while($row=mysql_fetch_array($result,MYSQL_ASSOC)){				
			$idval=$row['sturegno'];
			$idval1=$idval;$idval2=$idval;$idval3=$idval;$idval4=$idval;$idval5=$idval;$idval6=$idval;$idval7=$idval;
			$idval8=$idval;
			$idval1.='n';$idval2.='r';$idval3.='c';$idval4.='b';$idval5.='e';$idval6.='m';$idval7.='a';$idval8.='dl';            
			$resstr ="<tr>".           
            "<td>".
			"<input type='checkbox' name='$cnt' id='$cnt' value='{$row['sturegno']}' />".
			"<input type='hidden' value='{$row['sturegno']}' id='{$row['sturegno']}'></input>".
			"</td><td><input type='hidden' id='$idval1' value='{$row['stuname']}'></input>{$row['stuname']}</td><td>".
			"<input type='hidden' id='$idval2' value='{$row['sturegno']}'></input>{$row['sturegno']}</td>".
			"<td><input type='hidden' id='$idval3' value='{$row['stucorse']}'></input>{$row['stucorse']}</td>".
            "<td><input type='hidden' id='$idval4' value='{$row['stubranch']}'></input>".
			"{$row['stubranch']}</td>".						
			"</tr>";			
			echo $resstr;
			$cnt+=1;			
			}
			$resstr="<tr>".
			"<td><input type='hidden' name='len' id='len' value='$cnt'><input type='hidden' name='emails' id='emails'>".
			"<input type='submit' id='sendcircul' value='Send'></td></tr>";
			echo $resstr;
			?>
            </table>
            </form>
        </div> 
        
    </div>
</div>


   <?php 
	mysql_free_result($result);
	mysql_close($con);
}

}else{
	print('Yoy are not authorized for this page');
}
?>
</body>
</html>
