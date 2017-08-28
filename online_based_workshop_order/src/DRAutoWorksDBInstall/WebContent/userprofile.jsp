<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>AJAX JsonArray Example</title>
<script type="text/javascript" src="jquery-latest.min.js"></script>
<link rel="stylesheet" type="text/css" href="DBInstallMaster.css">
<style type="text/css">
table, td, th
{
border:1px solid green;
font-family: 'Oxygen', sans-serif;
}
th
{
background-color:green;
color:white;
}
body
{
	text-align: center;
}
.container
{
	margin-left: auto;
	margin-right: auto;
	width: 40em;
}
h4
{
	font-family: 'Oxygen', sans-serif;
	color:#1E90FF;
}
#updatecol{
	cursor:pointer;
	}
</style>
<script type="text/javascript" src="jquery-1.8.2.js"></script>
<script type="text/javascript">

$(document).ready(function(){

	$("#showTable").click(function(event){
		//alert("Test");
		$.get('UserProfileServlet',function(responseJSON){
			//alert(responseJSON);
			if(responseJSON!=null){
				//alert(responseJSON);
				$("#countrytable").find("tr:gt(0)").remove();
				//alert(responseJSON);
				var table1=$("#countrytable");
				$.each(responseJSON,function(key,value){					
					var NewRow=$("<tr><td></td><td></td><td></td><td id='updatecol' onclick='add(" + value['mobileNo'] + ");'></td><td></td></tr>");
					NewRow.children().eq(0).text(value['userName']);
					NewRow.children().eq(1).text(value['mobileNo']);
					NewRow.children().eq(2).text(value['motorbikeName']);
					NewRow.children().eq(3).text(value['motorbikeNo']);
					NewRow.children().eq(4).text(value['emailAddr']);
					NewRow.appendTo(table1);
					});						
			}
			});			
	});
});
function add(a){
	alert(a);
}
</script>
</head>
<body class="container">
<input type="button" value="Show Table" id="showTable"/>
<br/>
<br/>
<div id="tablediv">
<table cellspacing="0" id="countrytable"> 
    <tr> 
        <th scope="col">UserName</th> 
        <th scope="col">MobilNo</th> 
        <th scope="col">MotorBikeName</th> 
        <th scope="col">MotorBikeNo</th>
        <th scope="col">E - MailAddress</th> 
                          
    </tr> 
</table>
</div>
</body>
</html>