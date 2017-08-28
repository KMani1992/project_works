
<?php

$host="localhost:3306";
$username="root";
$password="";
$dbname="acabala";

$con=mysql_connect($host,$username,$password);
if(!$con){
	die('Could Not Connect'.mysql_error());
}else{
	
$rno=$_GET['rno'];

$qry="delete from student where sturegno='$rno';";
	
	 mysql_select_db($dbname);
	$result=mysql_query($qry,$con);
?>

<?php
}

mysql_free_result($result);
mysql_close($con);

?>
