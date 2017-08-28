
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
session_start();	
if(!empty($_SESSION['username'])){
$host="localhost:3306";
$username="root";
$password="";
$dbname="acabala";
if(isset($_POST['addstu'])){
$con=mysql_connect($host,$username,$password);
//print_r($_POST);
if(!$con){
	die('Could Not Connect TO Server' .mysql_error());
}else{
	mysql_select_db($dbname);
	if(! get_magic_quotes_gpc()){
	$stuname=addslashes($_POST['stu_name']);
	$sturegno=addslashes($_POST['stu_regno']);
	$stucourse=addslashes($_POST['stu_course']);
	$stubranch=addslashes($_POST['stu_branch']);
	$stuemail=addslashes($_POST['stu_email']);
	$stumobile=addslashes($_POST['stu_mobile']);
	$stuaddr=addslashes($_POST['stu_addr']);
	$stusex=addslashes($_POST['stu_sex']);
	$stuactive=addslashes($_POST['stu_active']);
	$stuacyfrom=addslashes($_POST['stu_acyfrom']);
	$stuacyto=addslashes($_POST['stu_acyto']);
	}else{
	$stuname=$_POST['stu_name'];
	$sturegno=$_POST['stu_regno'];
	$stucourse=$_POST['stu_course'];
	$stubranch=$_POST['stu_branch'];
	$stuemail=$_POST['stu_email'];
	$stumobile=$_POST['stu_mobile'];
	$stuaddr=$_POST['stu_addr'];
	$stusex=$_POST['stu_sex'];
	$stuactive=$_POST['stu_active'];
	$stuacyfrom=$_POST['stu_acyfrom'];
	$stuacyto=$_POST['stu_acyto'];
	}
	$stuname=mysql_real_escape_string($stuname);
	$sturegno=mysql_real_escape_string($sturegno);
	$stucourse=mysql_real_escape_string($stucourse);
	$stubranch=mysql_real_escape_string($stubranch);
	$stuemail=mysql_real_escape_string($stuemail);
	$stumobile=mysql_real_escape_string($stumobile);
	$stuaddr=mysql_real_escape_string($stuaddr);
	$stusex=mysql_real_escape_string($stusex);
	$stuactive=mysql_real_escape_string($stuactive);
	$stuacyfrom=mysql_real_escape_string($stuacyfrom);
	$stuacyto=mysql_real_escape_string($stuacyto);
	$staffid=$_SESSION['staffid'];
	//$datearray=getdate();
//	$ndate=$datearray['year']. "/" .$datearray['month']. "/" .$datearray['day'];
//	print($ndate);
//	print($staffid);
	$qry="insert into student(stuname,sturegno,stucorse,stubranch,stuemail,".
	"stumobileno,stuaddress,stuactive,acyfrom,acyto,stuaddeddate,staffid) ".
	"values('$stuname','$sturegno','$stucourse','$stubranch','$stuemail','$stumobile',".
	"'$stuaddr','$stuactive','$stuacyfrom','$stuacyto',NOW(),'$staffid');";
//	print($qry);
	$result=mysql_query($qry,$con);
	if(!$result){
		?>
		<script type="text/javascript">
        alert("Data Could Not Saved Please GoBack And Try Again !!!.");
        </script>
		<?php
	}else{
		?>
		<script type="text/javascript">
        alert("Data Successfully Saved !!!.");
		
        </script>
		<?php
		
		mysql_close($con);
		
	}

}

}else{
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
        	<div>
            </div>
			<div id="header_menu_left">
		<?php print('You are Currently Logged in : ' .$_SESSION['username'])?> &nbsp; | &nbsp; <a href="logout.php">Logout</a>       
         </div>
        </div>       
        <div id="main" style="padding-bottom:50px;padding-top:0px;">
        <form name="frm_stuadd" action="<?php $_PHP_SELF ?>" method="post" onsubmit="return (stuaddchk());" autocomplete="off">
            <table id="addstutab"> 
                <tr><td>StudentName :</td><td>
                <input type="text" maxlength="40" name="stu_name" id="stu_name" required="required" autofocus="autofocus" />
                </td></tr>
                <tr><td>RegisterNo :</td><td>
                <input type="number" maxlength="20" name="stu_regno" id="stu_regno" required="required"/></td></tr>
                <tr><td>Course :</td><td>
                <input type="text" maxlength="10" name="stu_course" id="stu_course" required="required"/></td></tr>
                <tr><td>Branch :</td><td>
                <input type="text" maxlength="10" name="stu_branch" id="stu_branch" required="required"/></td></tr>
                <tr><td>Student E-mail Id :</td>
                <td>
                <input type="email" maxlength="40" name="stu_email" id="stu_email" required="required"/></td></tr>
                <tr><td>Student Mobile No :</td>
                <td><input type="number" maxlength="15" name="stu_mobile" id="stu_mobile" required="required"/></td></tr>
                <tr><td>Student Address :</td><td>
                <textarea name="stu_addr" id="stu_addr" required="required"></textarea></td></tr>
                <tr><td>Sex :</td><td>
                <select name="stu_sex" id="stu_sex">
                <option value="male">Male</option>
                <option value="female">Fe-Male</option>
                </select>
                </td>
               <td>Active :</td><td>
                <select name="stu_active" id="stu_active">
                <option value="Y">Yes</option>
                <option value="N">No</option>
                </select>
                </td>
                </tr>
                <tr><td>AcadamivYear From :</td><td>
                <input type="date" name="stu_acyfrom" id="stu_acyfrom" required="required"/></td>
				<td> To :</td><td><input type="date" name="stu_acyto" id="stu_acyto" required="required"/></td>
                </tr>
                <tr><td></td><td><input type="submit" value="Save" name="addstu" id="addstu"/>
                <input type="reset" value="Cancel" />
                </td></tr>
            </table>            
            </form>
        </div>    
    </div>
</div>
<?php
}
}else{
	print('Yoy are not authorized for this page');
}
?>

</body>
</html>