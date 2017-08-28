<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@include file="pageheader.jsp"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="shortcut icon" href="favicon.ico">
<link rel="stylesheet" type="text/css" href="style/DBInstallMaster.css">
<script type="text/javascript" src="action.js"></script>

<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title> :: DRAUWorksCompanyCreation :: </title>
</head>
<body>
    <div id="wrapper">
     <div id="inner">
         <div id="head">
            <h3>Welcometo :: CompanyCreation</h3>  
         </div> 
         <form action="DBInsServlet" method="post" name="frmcompanycr" onsubmit="return(compvalidate());" autocomplete="off"> 
         <table align="left" id ="tabdbins">
          <tr>
         	<td>CompanyName :</td><td><input id="companyname" class="text" name="companyname" autofocus required></td>         	
         </tr>
          <tr>
         	<td>Companyid :</td><td><input id="companyid" class="text" name="companyid" required></td>         	
         </tr>
         <tr>
         	<td>ServerName :</td><td><input id="servername" class="text" name="servername" required></td>         	
         </tr>
          <tr>
         	<td>ServerPassword :</td><td><input type="password" id="serverpassword" class="text" name="serverpassword"></td>         	
         </tr>
         <tr>
         	<td>DBPath :</td><td><input id="dbpath" class="text" title="Ex:D:\Data" name="dbpath" required></td>
         </tr>
         <tr>
         	<td>Period From :</td><td><input type="date" id="periodfrom" class="datetime" name="periodfrom" required></td>
         	<td>To :</td><td><input type="date" id="periodto" class="datetime" name="periodto" required></td>
         </tr>
         <tr>
         	<td></td><td><input type="submit" value="Save" class="btn"> <input type="reset" value="Cancel" id="Cancel" class="btn" onclick="setfocus();"></td>
         </tr>
         <tr>
         </tr>
         
         </table>
         </form>
     </div>
    </div>

</body>
</html>
 <%@include file="pagefooter.jsp"%>