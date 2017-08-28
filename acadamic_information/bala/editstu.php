
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title> :: Student Circular Information Notification :: </title>
<link rel="stylesheet" type="text/css" href="masterstyle.css" />
<script type="text/javascript" src="action.js"></script>
<script type="text/javascript" src="jquery-1.7.1.js"></script>
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
 			<table id="stuview" align="center" cellpadding="5px;" cellspacing="2px;" 
            border="1px;" bordercolorlight="#996600" bordercolor="#996600" bordercolordark="#996600" style="border-style:solid">
            <tr id="tabheader">
            <td>Option</td><td>Student Name</td><td>RegisterNo</td><td>Course</td>
            <td>Branch</td><td>E-Mail</td><td>MobileNo</td><td>Active</td><td>Option</td>
            </tr>
            
            <?php while($row=mysql_fetch_array($result,MYSQL_ASSOC)){				
			$idval=$row['sturegno'];
			$idval1=$idval;$idval2=$idval;$idval3=$idval;$idval4=$idval;$idval5=$idval;$idval6=$idval;$idval7=$idval;
			$idval8=$idval;
			$idval1.='n';$idval2.='r';$idval3.='c';$idval4.='b';$idval5.='e';$idval6.='m';$idval7.='a';$idval8.='dl';
            $resstr ="<tr>".           
            "<td style='cursor:pointer' onclick='editrow({$row['sturegno']});'>".
			"Edit<input type='hidden' value='{$row['sturegno']}' id='{$row['sturegno']}'></input>".
			"</td><td><input type='hidden' id='$idval1' value='{$row['stuname']}'></input>{$row['stuname']}</td><td>".
			"<input type='hidden' id='$idval2' value='{$row['sturegno']}'></input>{$row['sturegno']}</td>".
			"<td><input type='hidden' id='$idval3' value='{$row['stucorse']}'></input>{$row['stucorse']}</td>".
            "<td><input type='hidden' id='$idval4' value='{$row['stubranch']}'></input>".
			"{$row['stubranch']}</td><td><input type='hidden' id='$idval5' value='{$row['stuemail']}'></input>".
			"{$row['stuemail']}".
			"</td><td><input type='hidden' id='$idval6' value='{$row['stumobileno']}'></input>{$row['stumobileno']}</td>".
            "<td><input type='hidden' id='$idval7' value='{$row['stuactive']}'></input>{$row['stuactive']}</td>".
			"<td style='cursor:pointer' onclick='deleterow({$row['sturegno']});'>".
			"Delete<input type='hidden' value='{$row['sturegno']}' id='$idval8'></input></td>".
			"</tr>";
			echo $resstr;
			}
			mysql_free_result($result);
			mysql_close($con);
			
			?>
            </table>
        </div> 
        
    </div>
</div>

<div id="outeroverlap">
   <?php 
 if(isset($_POST['editstu'])){
// print_r($_POST);
 $con=mysql_connect($host,$username,$password);
 if(!$con){
	 die('Could Not Connect'.mysql_error());	 
	 }else{
		 mysql_select_db($dbname,$con);
		 //start
		 
	if(! get_magic_quotes_gpc()){
	$sturegno=addslashes($_POST['stu_regno']);
	$stuname=addslashes($_POST['stu_name']);	
	$stucourse=addslashes($_POST['stu_course']);
	$stubranch=addslashes($_POST['stu_branch']);
	$stuemail=addslashes($_POST['stu_email']);
	$stumobile=addslashes($_POST['stu_mobile']);	
	$stuactive=addslashes($_POST['stu_active']);	
	}else{
	$sturegno=$_POST['stu_regno'];
	$stuname=$_POST['stu_name'];	
	$stucourse=$_POST['stu_course'];
	$stubranch=$_POST['stu_branch'];
	$stuemail=$_POST['stu_email'];
	$stumobile=$_POST['stu_mobile'];	
	$stuactive=$_POST['stu_active'];	
	}
	$sturegno=mysql_real_escape_string($sturegno);
	$stuname=mysql_real_escape_string($stuname);	
	$stucourse=mysql_real_escape_string($stucourse);
	$stubranch=mysql_real_escape_string($stubranch);
	$stuemail=mysql_real_escape_string($stuemail);
	$stumobile=mysql_real_escape_string($stumobile);	
	$stuactive=mysql_real_escape_string($stuactive);	
	$staffid=$_SESSION['staffid'];		 
	$sql="update student set stuname='$stuname',stucorse='$stucourse',stubranch='$stubranch',stuemail='$stuemail',".
	"stumobileno='$stumobile',stuactive='$stuactive' where sturegno='$sturegno';" ;
	$result=mysql_query($sql,$con);
	if($result){
		?>
        <script type="text/javascript">
			alert("Successfully Updated");
        </script>
        <?php 
		header("location: editstu.php");
		//echo('Successfully Updated');
	}else{
		?>
        <script type="text/javascript">
			alert("Cant Updated Please Goback and try Again!!!");
        </script>
        <?php
//		echo('Cant Updated Please Goback and try Again!!!');
		header("location: editstu.php");
		
	}
	mysql_free_result($result);
	mysql_close($con);
	 }
 }else{
   ?>   

<div id="inneroverlap">
        <div id="closebtn" onclick="popupClose();">X</div>
        <form name="frm_stuedit" action="<?php $_PHP_SELF ?>" method="post" onsubmit="return stuaddchk();" autocomplete="off">
            <table id="editstutab"> 
                <tr><td>RegisterNo :</td><td>
                <input type="text" readonly="readonly" maxlength="20" name="stu_regno" id="stu_regno" required="required"/>
                </td></tr>
                <tr><td>StudentName :</td><td>
                <input type="text" maxlength="40" name="stu_name" id="stu_name" required="required" autofocus="autofocus" />
                </td></tr>                
                <tr><td>Course :</td><td>
                <input type="text" maxlength="10" name="stu_course" id="stu_course" required="required"/></td></tr>
                <tr><td>Branch :</td><td>
                <input type="text" maxlength="10" name="stu_branch" id="stu_branch" required="required"/></td></tr>
                <tr><td>Student E-mail Id :</td>
                <td>
                <input type="email" maxlength="40" name="stu_email" id="stu_email" required="required"/></td></tr>
                <tr><td>Student Mobile No :</td>
                <td><input type="number" maxlength="15" name="stu_mobile" id="stu_mobile" required="required"/></td></tr>
               <tr><td>Active :</td><td>
                <select name="stu_active" id="stu_active">
                <option value="Y">Yes</option>
                <option value="N">No</option>
                </select>
                </td>
                </tr>                
                <tr><td></td><td><input type="submit" value="Update" name="editstu" id="editstu"/>
                <input type="reset" value="Cancel" />
                </td></tr>
            </table>            
            </form>
 </div>
</div>
<?php
 }
}

}else{
	print('Yoy are not authorized for this page');
}
?>
</body>
</html>
