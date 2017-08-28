
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title> :: Student Circular Information Notification :: </title>
<link rel="stylesheet" type="text/css" href="masterstyle.css" />

</head>

<body>
<?php
session_start();	
if(!empty($_SESSION['username'])){
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
        <div id="main" style="height:170px;">
        <h3 align="center">Admin Pannel</h3>
        <ul>
        <li><a href="addstu.php"><img src="images/add_stu.png" width="168"  height="119" /></a></li>
        <li><a href="editstu.php"><img src="images/edit_stu.png" width="168"  height="119" /></a></li>        
        <li><a href="inform_dates.php"><img src="images/inform_dates.png" width="168"  height="119" /></a></li>
        <li><a href="send_circuler.php"><img src="images/Send_Circular.png" width="168"  height="119" /></a></li>
        <li><a href="settings.php"><img src="images/settings.png" width="168"  height="119" /></a></li>
        </ul>
        <div id="logout"><?php
			
		 print('You are Currently Logged in as : '.$_SESSION['username']); ?> &nbsp;|&nbsp;<a href="logout.php">Logout</a></div>
        </div>
        
        
    
    </div>
</div>

<?php
}else{
	print('Yoy are not authorized for this page');
}
?>
</body>
</html>