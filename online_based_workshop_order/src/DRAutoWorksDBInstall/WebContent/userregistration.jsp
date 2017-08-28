<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<%@include file="pageheader.jsp"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="shortcut icon" href="favicon.ico">
<link rel="stylesheet" type="text/css" href="style/DBInstallMaster.css">
<script type="text/javascript" src="action.js"></script>
<script type="text/javascript" src="ajaxaction.js"></script>
<script type="text/javascript" src="jquery-1.8.2.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title> :: Customer Registration - DuraiRajAutoWorks :: </title>
</head>
<body>
    <div id="wrapper">
     <div id="inner">
         <div id="head">
            <h3>:: Welcome To Customer Registration ::</h3>  
         </div>   
         <form action="CustomerSignUp" method="post" onsubmit="return custregistration();" autocomplete="off" name="frmcustreg" >
         <table >
         <tr>
         <td>Name :</td><td class="imp">*</td><td><input type="text" id="custname" class ="txt" name="custname" placeholder="Enter Your Name" autofocus required ></td>
         </tr>
         <tr>
         <td>MotorBike Number :</td><td class="imp">*</td><td><input type="text" id="motbikeno" class ="txt" name="motbikeno" placeholder="Enter Your MotorBike Number" required ></td>
         </tr>
         <tr>
         <td>MotorBike Name :</td><td class="imp"></td><td><input type="text" id="motbikename" class ="txt" name="motbikename" placeholder="Enter Your MotorBike Name"></td>
         </tr>
         <tr>
         <td>Mobile Number :</td><td class="imp">*</td><td><input type="number" id="mobileno"  class ="txt" name="mobieno" placeholder="Enter Your Mobile Number" required ></td>
         </tr>
         <tr>
         <td>E-Mail Address :</td><td class="imp">*</td><td><input title="Your E-Mail Address is your UserName" type="email" id="emailaddr" class ="txt" name="emailaddr" placeholder="Enter Your E-Mail Address" required onblur="validateEmail()"></td>
         </tr>
         <tr>
         <td>Password :</td><td class="imp">*</td><td><input title="Password" type="password" id="custregpassword" class ="txt" name="custregpassword" placeholder="Enter Your Password" required></td>
         </tr>
         <tr>
         <td>Confirm Password :</td><td class="imp">*</td><td><input title="Confirm Password" type="password" id="custregconfirmpassword" class ="txt" name="custregconfirmpassword" placeholder="Confirm Password" required></td>
         </tr>
         <tr>
         <td></td><td ><input type="submit"  name ="custregsubmit" value ="register" class="btn"></td><td><input type="reset" value="Cancel" id="custregcancel" class="btn" onclick="custregsetfocus();"></td>
         </tr>
         </table>         
         </form>   
         
     </div>
    </div>   
<%@include file="loadingscreen.jsp" %>
</body>
</html>
 <%@include file="pagefooter.jsp"%>