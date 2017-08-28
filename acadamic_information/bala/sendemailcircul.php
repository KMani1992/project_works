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
 mysql_select_db($dbname);	
if(isset($_POST['emails'])){	
	$val=$_POST['emails'];
	$array= array();
	$array=explode(',',$val);		
	foreach($array as $tmp){
		$qry="select stuname,sturegno,stucorse,stubranch,stuemail,".	 
		 "staffid from student where sturegno=$tmp and stuactive='Y' order by sturegno;";	
		$result=mysql_query($qry,$con);
		while($row=mysql_fetch_array($result,MYSQL_ASSOC)){				
				$idval=$row['stuemail'];
				echo "$idval <br/>";
		}
		mysql_free_result($result);
	}
}	

	
	mysql_close($con);
}

}else{
	print('Yoy are not authorized for this page');
}
?>