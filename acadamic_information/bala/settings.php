
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
$qry="select sno,name,staffid,active,password from staff order by sno;";
	
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
        	<div>
            </div>
			<div id="header_menu_left">
		<?php print('You are Currently Logged in : ' .$_SESSION['username'])?> &nbsp; | &nbsp; <a href="logout.php">Logout</a>            </div>
        </div>       
        <div id="main" style="padding-bottom:50px;padding-top:0px;">
 			<table id="stuview" align="center" cellpadding="5px;" cellspacing="2px;" 
            border="1px;" bordercolorlight="#996600" bordercolor="#996600" bordercolordark="#996600" style="border-style:solid">
            <tr id="tabheader">
            <td>Option</td><td>Sno</td><td>Staff Name</td><td>Staff Id</td><td>Active</td><td>Option</td>
            
            </tr>
            
            <?php while($row=mysql_fetch_array($result,MYSQL_ASSOC)){
			$staffid=$row['sno'];$staffid1=$row['sno'];$staffid2=$row['sno'];$staffid3=$row['sno'];	
			$staffid.='n';$staffid1.='i';$staffid2.='a';$staffid3.='p';
			$sid=$row['staffid'];
            $resstr ="<tr>".           
            "<td onclick='addstaff();' style='cursor:pointer'>".
			"Add</td><td>{$row['sno']}</td><td><input type='hidden' value='{$row['name']}' id='$staffid' />{$row['name']}</td>".
			"<td><input type='hidden' value='{$row['staffid']}' id='$staffid1' />{$row['staffid']}</td>".
			"<td><input type='hidden' value='{$row['active']}' id='$staffid2' />{$row['active']}</td>".
			"<td onclick='staffedit({$row['sno']});' style='cursor:pointer'>".
			"<input type='hidden' value='{$row['password']}' id='$staffid3' />Edit</td></tr>";
			echo $resstr;
			}
			
			?>
            </table>
        </div>    
    </div>
</div>
<div id="outeroverlap">
   <?php 
 if(isset($_POST['editstaff'])){
// print_r($_POST);
 $con=mysql_connect($host,$username,$password);
 if(!$con){
	 die('Could Not Connect'.mysql_error());	 
	 }else{
		 mysql_select_db($dbname,$con);
		 //start
		 
	if(! get_magic_quotes_gpc()){
	$staffpwd=addslashes($_POST['staff_pwd']);
	$staffname=addslashes($_POST['staff_name']);	
	$staffactive=addslashes($_POST['staff_active']);
	$staffno=addslashes($_POST['staff_no']);	
	}else{
	$staffpwd=$_POST['staff_pwd'];
	$staffname=$_POST['staff_name'];	
	$staffactive=$_POST['staff_active'];
	$staffno=$_POST['staff_no'];	
	}
	$staffpwd=mysql_real_escape_string($staffpwd);
	$staffname=mysql_real_escape_string($staffname);			
	$staffactive=mysql_real_escape_string($staffactive);
	$staffno=mysql_real_escape_string($staffno);	

	$sql="update staff set name='$staffname',password='$staffpwd',active='$staffactive'".
	" where sno='$staffno';" ;
	$result=mysql_query($sql,$con);
	if(!$result){
		?>
        <script type="text/javascript">
			alert("Successfully Updated");
        </script>
        <?php 
		//header("location: settings.php");
		echo('Successfully Updated');
	}else{
		?>
        <script type="text/javascript">
			alert("Cant Updated Please Goback and try Again!!!");
        </script>
        <?php
//		echo('Cant Updated Please Goback and try Again!!!');
		header("location: settings.php");
		
	}
	mysql_free_result($result);
	mysql_close($con);
	 }
 }else{
	 ////// staff edit  details/////
   ?>   


<div id="inneroverlap">
        <div id="closebtn" onclick="popupClose();">X</div>
        <form name="frm_staffedit" action="<?php $_PHP_SELF ?>" method="post" onsubmit="return staffEdchk();" autocomplete="off">
           <table id="editstutab"> 
            	<tr><td>StaffNo :</td><td>
                <input type="text" readonly="readonly" maxlength="20" name="staff_no" id="staff_no" required="required"/>
                </td></tr>                
                <tr><td>StaffId :</td><td>
                <input type="text" readonly="readonly" maxlength="20" name="staff_id" id="staff_id" required="required"/>
                </td></tr>
                <tr><td>StaffName :</td><td>
                <input type="text" maxlength="40" name="staff_name" id="staff_name" required="required" autofocus="autofocus" />
                </td></tr>                
                <tr><td>Password :</td><td>
                <input type="password" maxlength="10" name="staff_pwd" id="staff_pwd" required="required"/></td></tr>
               
               
               <tr><td>Active :</td><td>
                <select name="staff_active" id="staff_active">
                <option value="Y">Yes</option>
                <option value="N">No</option>
                </select>
                </td>
                </tr>                
                <tr><td></td><td><input type="submit" value="Update" name="editstaff" id="editsaff"/>
                <input type="reset" value="Cancel" />
                </td></tr>
            </table>                        
            </form>
 </div>
</div>
<?php
 }
 ///// add staff details ///////
?>
<div id="outeroverlapadd">
<?php 
 if(isset($_POST['addstaff'])){
// print_r($_POST);
 $con=mysql_connect($host,$username,$password);
 if(!$con){
	 die('Could Not Connect'.mysql_error());	 
	 }else{
		 mysql_select_db($dbname,$con);
		 //start
		 
	if(! get_magic_quotes_gpc()){
	$staffpwd=addslashes($_POST['addstaff_pwd']);
	$staffname=addslashes($_POST['addstaff_name']);	
	$staffactive=addslashes($_POST['addstaff_active']);
	$staffno=addslashes($_POST['addstaff_id']);	
	}else{
	$staffpwd=$_POST['addstaff_pwd'];
	$staffname=$_POST['addstaff_name'];	
	$staffactive=$_POST['addstaff_active'];
	$staffno=$_POST['addstaff_id'];	
	}
	$staffpwd=mysql_real_escape_string($staffpwd);
	$staffname=mysql_real_escape_string($staffname);			
	$staffactive=mysql_real_escape_string($staffactive);
	$staffno=mysql_real_escape_string($staffno);	

	$sql="insert into staff(name,staffid,password,active)".
	" values('$staffname','$staffno','$staffpwd','$staffactive');";
	
	$result=mysql_query($sql,$con);
	if(!$result){
		?>
        <script type="text/javascript">
			alert("Successfully Added");
        </script>
        <?php 
		header("location: settings.php");
		//echo('Successfully Added');
	}else{
		?>
        <script type="text/javascript">
			alert("Can't Added Please Goback and try Again!!!");
        </script>
        <?php
//		echo('Cant Updated Please Goback and try Again!!!');
		header("location: settings.php");
		
	}
	mysql_free_result($result);
	mysql_close($con);
	 }

 }else{
?>

<div id="inneroverlapadd">
        <div id="closebtn" onclick="staffadddpopupClose();">X</div>
        <form name="frm_staffadd" action="<?php $_PHP_SELF ?>" method="post" onsubmit="return staffaddchk();" autocomplete="off">
            <table id="addstutab"> 
            	 <tr><td>StaffId :</td><td>
           <input type="text" maxlength="20" name="addstaff_id" id="addstaff_id" required="required"  autofocus="autofocus" />
                </td></tr>
                <tr><td>StaffName :</td><td>
           <input type="text" maxlength="40" name="addstaff_name" id="addstaff_name" required="required"/>
                </td></tr>                
                <tr><td>Password :</td><td>
                <input type="password" maxlength="10" name="addstaff_pwd" id="addstaff_pwd" required="required"/></td></tr>
               
               
               <tr><td>Active :</td><td>
                <select name="addstaff_active" id="addstaff_active">
                <option value="Y">Yes</option>
                <option value="N">No</option>
                </select>
                </td>
                </tr>                
                <tr><td></td><td><input type="submit" value="Add" name="addstaff" id="addsaff"/>
                <input type="reset" value="Cancel" />
                </td></tr>
            </table>            
            </form>
 </div>
</div>
<?php
 }
 ///// add staff details end///////
?>
<?php
}
mysql_free_result($result);
mysql_close($con);
}else{
	print('Yoy are not authorized for this page');
}
?>

</body>
</html>