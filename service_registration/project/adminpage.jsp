<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<%@ page import="java.io.*,java.util.Date" %>
<%@ page import="javax.servlet.*,java.text.*" %>
<%
String error=request.getParameter("error");
if(error==null || error=="null"){
 error="";
}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>duraiRaj Auto Admin page</title>

<link href="style.css" rel="stylesheet" type="text/css" /><link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 <script src="booking-service_files/swfobject.js" type="text/javascript"></script>
 <link href="WebResource.css" rel="stylesheet" type="text/css" media="all"><link href="main.css" rel="stylesheet" type="text/css">

<style>

body{
font-family:Verdana, Geneva, sans-serif;
font-size:14px;}

.slidingDiv {
	height:200px;
	width:965px;
	margin:0 auto;
	background-color: #99CCFF;
	padding:20px;
	
	border-bottom:5px solid #3399FF;
}
.userwelcome
{
	background-color:#001842;
	
	font-family:Arial, Helvetica, sans-serif;
	font-size:13px;
	font-weight:100;
	font-variant:normal;
	text-decoration:none;
	text-align:center;
	color:#FFF;
}

.userelcome
{

	
	font-family:Arial, Helvetica, sans-serif;
	font-size:13px;
	font-weight:100;
	font-variant:normal;
	text-decoration:none;
	text-align:center;
	color:rgb(247, 56, 50);
}

.show_hide {
	
	display:none;
}
.error
{
	color:#C00;
	text-align:right;
	font-size:14px;
}
.reginf {
	
	display:none;
}

</style>

</head>

<body>
<div class="align">
<table align="right" cellpadding="2px" cellspacing="2px" style="margin-right:180px" >
<tr><td class="userelcome">DuraiRaj Auto Admin</td>



<td>|</td><td><a href="index.html" style="color:#000">Logout</a></td>

</tr>
</table></div>
<br /><br />
<center>
<div id="banner">
</div>
<%


Date df=new Date();
SimpleDateFormat ft=new SimpleDateFormat("d");

String s= ft.format(df);
int aa=Integer.parseInt(s);
int tem=0,tem1=0;
int a=aa;

if(a<=7)
{
	tem=7-a;
}

else if(a<=14&&a>7)
{
	tem=14-a;
}
else if(a<=21&&a>14)
{
	tem=21-a;
}
else if(a<=28&&a>21)
{
	tem=28-a;
}
else if(a<=30&&a>28)
{
	tem=30-a;
}


%>



<%

if(tem>=2)
{

%>
<table cellpadding="2px" cellspacing="0px" align="center" width="1000px" height="40px">
<tr class="userwelcome"><td>
<marquee direction="left" align="middle" onmouseout="this.start()" onmouseover="this.stop()" scrolldelay="10">
<font style="text-decoration:none; font-size:14px" face="Verdana, Geneva, sans-serif" >
Welcome to Admin Page, Admin Have <%=tem%> days Remaining for Next Check Up Date Alert.</font></marquee>
</td>

<td>

<form action="informdate1.jsp" method="post"><input style="display:none" size="1" type="text" value="<%=aa%>" name="adcheckupd" />
<input type="submit" value="Check Up Date Alert" class="buttoncda"/>
</form>


</td>

</tr>
</table>

<%
}
else if(tem<2)
{

%>
<table cellpadding="2px" cellspacing="0px" align="center" width="1000px" height="40px">
<tr class="userwelcome"><td>
<marquee direction="left" align="middle" onmouseout="this.start()" onmouseover="this.stop()" scrolldelay="10">
<font style="text-decoration:none; font-size:14px" face="Verdana, Geneva, sans-serif" >
Welcome to Admin Page, Admin Have <%=tem%> days Remaining for Next Check Up Date Alert, Please Click Check Up date Alert Button Imidiately.</font></marquee>
</td>

<td>

<form action="informdate1.jsp" method="post"><input size="1" style="display:none" type="text" value="<%=aa%>" name="adcheckupd" />
<input type="submit" value="Check Up Date Alert" class="buttoncda"/>
</form>


</td>

</tr>
</table>


<%
}
%>

</center>



<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.3.2/jquery.js" type="text/javascript"></script>
<script type="text/javascript">

$(document).ready(function(){


    $(".slidingDiv").hide();
	$(".show_hide").show();
	
	$('.show_hide').click(function(){
	$(".slidingDiv").slideToggle();
	});

});

</script>

<table align="center"><tr><td>
   <a id="ctl00_hlSearch" class=" show_hide" href="#"><img src="new/search-button.png" style="border-width: 0px;"></a>
 </td></tr></table>
    <div class="slidingDiv">


            <div class="body">
                <div class="search-container">
                    <div style="display: block;" id="ctl00_pnlSearch" class="search hide-me">
	
                            <div id="" class="" style="margin:0 auto"><center>
                                <form action="adminsearch.jsp" method="get">
                                <table align="center"><tr><td>
		
                                <h4 align="center">
                                    Keyword Search </h4>
                           </td></tr></table>
                           <table>
                                                     <tr><td height="30"><input style="width:350px; height:35px; font-size:24px" name="keysearch" class="bike-basic-search-tb tb keyword-search ac_input" type="text">
                                </td><td><input name="ctl00$btnBasic" id="ctl00_btnBasic" class="basic-search-btn" text="Search" src="new/go.png" style="border-width: 0px;" type="image"></td></tr><tr><td>
                                &nbsp;&nbsp;&nbsp;<span class="error"><%=error%></span></td></tr></table>
                                
 </form>    </center>                   
                            
	</div>
                            <div class="clear-me">
                   
                     </div></div></div></div></div>
                       
                        
                        
                        
                        
                        <div class="reginf">
                        <center>
                        <table border="0" cellpadding="0" cellspacing="0" width="600px">
  <tbody><tr valign="top">
    <td align="center" width="10"></td>
    <td class="topbg"><br>
      <br>      
      <table border="0" cellpadding="0" cellspacing="0">
        <tbody><tr>
          <td class="title" height="67" width="400"><br>
         Customer Registration Information </td>
        </tr>
      </tbody></table>
       <form name="RMA" action="userreg.jsp" method="POST">
            <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
              <tbody><tr>
                <td align="left" background="booking-service_files/left.gif" bgcolor="#F7F7F7" valign="top" width="6"><img src="booking-service_files/1.jpg" height="6" width="6"></td>
                <td colspan="2" rowspan="2" class="bg" bgcolor="#F7F7F7"><br>
                  <table class="bike" border="0" cellpadding="2" cellspacing="2" width="100%">
                  <tbody><tr align="left" valign="top">
                    <td colspan="3" align="right">(<span class="red">*</span> represents compulsory fields )&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                  </tr>
                  <tr align="left">
                    <td colspan="3" align="center"></td>
                    </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Full Name </strong></td>
                    <td class="brdr"><input name="name" class="txtfield" type="text"></td>
                  </tr>
                   <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Vehicle No </strong></td>
                    <td class="brdr"><input name="name" class="txtfield" type="text"></td>
                  </tr>
                   <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Password </strong></td>
                    <td class="brdr"><input name="name" class="txtfield" type="password"></td>
                  </tr>
                   <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Confirm Password </strong></td>
                    <td class="brdr"><input name="name" class="txtfield" type="password"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Address </strong></td>
                    <td class="brdr"><textarea name="address" cols="40" class="txtfield"></textarea></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>City </strong></td>
                    <td class="brdr"><select name="city" class="txtfield">
                        <option selected="selected">Select City</option>
                    </select></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF">&nbsp;</td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Zip Code </strong></td>
                    <td class="brdr"><input name="zip" class="txtfield" type="text"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>State </strong></td>
                    <td class="brdr"><select name="country" class="txtfield">
                        <option selected="selected">Select State</option>
                    </select></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong> Phone </strong></td>
                    <td class="brdr"><input name="phone" class="txtfield" type="text"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red"></span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Fax </strong></td>
                    <td class="brdr"><input name="fax" class="txtfield" type="text"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>eMail </strong></td>
                    <td class="brdr"><input name="mail" class="txtfield" type="text"></td>
                  </tr>
                    <tr align="left">
                    <td colspan="3" height="30"><table border="0" cellpadding="0" cellspacing="0" width="100%">
                      <tbody><tr>
                        <td><br>
                          <table align="center" border="0" cellpadding="0" cellspacing="0" width="95%">
                            <tbody>
                            <tr>
                              <td><strong>
                              </strong></td>
                            </tr>
                          
                        </tbody></table></td>
                      </tr>
                                                            </tbody></table></td>
                    </tr>
                  <tr align="left">
                    <td>&nbsp;</td>
                    <td height="30">&nbsp;</td>
                    <td><input name="Submit" class="button" value="Submit" type="submit">
                      <input name="Reset" class="button" value="Reset" type="reset"></td>
                  </tr>
                </tbody></table></td>
              </tr>
              <tr>
                <td background="booking-service_files/left.gif" bgcolor="#F7F7F7" width="6"></td>
              </tr>
              <tr>
                <td align="left" bgcolor="#F7F7F7" valign="bottom" width="6"><img src="booking-service_files/2.jpg" height="6" width="6"></td>
                <td background="booking-service_files/bottom.gif" bgcolor="#F7F7F7"></td>
                <td align="right" background="booking-service_files/bottom.gif" bgcolor="#F7F7F7" valign="bottom"><img src="booking-service_files/3.jpg" height="6" width="6"></td>
              </tr>
            </tbody></table>
    </form></td>
  </tr>
  <tr>
    <td align="center">&nbsp;</td>
    <td align="center" valign="top"></td>
  </tr>
</tbody></table>
</center>
                        
                        
                        </div>
                        
                        
                     
                        
                        
                        
           
                        
                        
                        
                        

</body>
</html>