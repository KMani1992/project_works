<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>User Registration</title>
<link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 <script src="booking-service_files/swfobject.js" type="text/javascript"></script>
<script type="text/javascript">
function view()
{
 document.getElementById("ft").style.display="block";
 
}
function call()
{
	
	document.getElementById("tab").style.display="block";
	document.getElementById("ft").style.display="none";
}
function call1()
{
	//alert("You Have Successfylly Registered");
	document.getElementById("tab1").style.display="block";
	document.getElementById("ft").style.display="none";
}


function check(form)
{
	var v1=document.forms[0].name.value;
	
	var v2=document.forms[0].password.value;
    var v3=document.forms[0].confirmpassword.value;
	var v4=document.forms[0].address.value;
	var v5=document.forms[0].city.value;
    var v6=document.forms[0].zip.value;
	var v7=document.forms[0].country.value;
    var v8=document.forms[0].phone.value;
	var v9=document.forms[0].mail.value;
	var v10=document.forms[0].vnumber.value;
    var v11=document.forms[0].product.value;
	var v12=document.forms[0].dd.value;
    var v13=document.forms[0].mm.value;
	var v14=document.forms[0].yy.value;
    var v15=document.forms[0].tt.value;
	var v16=document.forms[0].problem.value;
	
	var z1=v1.length
	var z2=v2.length
	var z3=v4.length
	var z4=v5.length
    var z5=v6.length
	var z6=v8.length
	var z7=v9.length
	var z8=v9.indexOf("@")
	var z9=v9.indexOf(".")
	var z10=v11.length
	
	//var z14=parseFloat(v15)
	
	
	var z16=v10.length
	
	var z15=v16.length
	
	
	
    
   
  
   if(v1==""||v2==""||v3==""||v4==""||v5==""||v6==""||v7==""||v8==""||v9==""||v10==""||v11==""||v12==""||v13==""||v14==""||v15==""||v16=="")
   {
   
   
   alert("Please Enter All The Field");
   return false;
   
   }
	
	
	 if(z1<=3)
		{
		alert("Please Enter the Name more than 3 letters");
		return false;
		}
	
	
	 if(z2<=6)
	{
		alert("Please Enter the password more than 6 digits");
		return false;
	}
		
	if(z3<=10)
	{
		alert("Please Enter the Address more than 10 letters");
		return false;
	}
	 if(z4<=3)
	{
		alert("Please Enter the City Name more than 3 letters");
		return false;
	}
	 if(z5<5)
	{
		alert("Please Enter the Zip code currectly");
		return false;
	}
	 if(z6<10)
	{
		alert("Please Enter the 10 digit Phone Number");
		return false;
	}
	 if(z7<10)
	{
		alert("Please Enter the currect E-mail Id");
		return false;
	}
	 if(z8<4||z9<2)
	{
		alert("Invalid E-mail Id Please Enter the currect E-mail Id");
		return false;
	}
	
 	/*if(v12>31)
	{
		alert("Please Enter the Currect Date");
		return false;
	}
	 if(v13>12)
	{
		alert("Please Enter the Currect Month");
		return false;
	}
	 if(v14<2013)
	{
		alert("Please Enter the Currect Year");
		return false;
	}
		 if(z14>12.0)
	{
		alert("Please Enter the Currect Time");
		return false;
	}*/
	
	
	 if(z16<6)
	{
		alert("Please Enter the Correct Vehicle Number");
		return false;
	}
	 if(z10<2)
	{
		alert("Please Enter the Correct Product Name");
		return false;
	}
	
	 if(z15<10)
	{
		alert("Please Enter the Problem more Than 10 Letters");
		return false;
	}
	
	
			return true;
	

}





</script>
<style type="text/css">
#ft
	{
		float:center;
		padding-left:inherit;
	
	left:inherit;	
	}
	#tab
	{
		float:center;
		padding-left:inherit;
	
	left:inherit;	
	}

</style>
</head>

<body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0" onload="view()">
<%
String rname=request.getParameter("name");
String rpassword=request.getParameter("password");
String rconfirmpassword=request.getParameter("confirmpassword");
String raddress=request.getParameter("address");
String fcity=request.getParameter("city");
String fzip=request.getParameter("zip");
String fcountry=request.getParameter("country");
String fphone=request.getParameter("phone");

String fmail=request.getParameter("mail");
//String fpassword=request.getParameter("password");
//String fconfirmpassword=request.getParameter("confirmpassword");
String fvnumber=request.getParameter("vnumber");
String fproduct=request.getParameter("product");

String fdd=request.getParameter("dd");
String fmm=request.getParameter("mm");
String fyy=request.getParameter("yy");
String ftt=request.getParameter("tt");
String fproblem=request.getParameter("problem");

//out.println(rname);
/*if(rname==""||raddress==""||fcity==""||fzip==""||fcountry==""||fphone==""||ffax==""||fmail==""||fvnumber==""||fproduct==""||fother==""||fdd==""||fmm==""||fyy==""||ftt==""||fproblem==""||fremark=="")
{*/%>

<%//}
//else
{

try
{
Connection conn = null;
Class.forName( "sun.jdbc.odbc.JdbcOdbcDriver" );
String db = "jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";

conn = DriverManager.getConnection( db );
Statement st=conn.createStatement();

int i=st.executeUpdate("insert into details(fullname,address,city,zipcode,state,phone,email,vehiclenumber,product,dd,mm,yy,tt,problem,password,confirmpassword) values('"+rname+"','"+raddress+"','"+fcity+"','"+fzip+"','"+fcountry+"','"+fphone+"','"+fmail+"','"+fvnumber+"','"+fproduct+"','"+fdd+"','"+fmm+"','"+fyy+"','"+ftt+"','"+fproblem+"','"+rpassword+"','"+rconfirmpassword+"')");
//out.println("Data is inserted successfully");
%>
<div id="ft" style="display:none">
<table border="0" cellpadding="0" cellspacing="0" width="600px">
  <tbody><tr valign="top">
    <td align="center" width="10px"></td>
    <td class="topbg"><br>
      <br>      
      <table border="0" cellpadding="0" cellspacing="0">
        <tbody><tr>
          <td class="title" height="67" valign="middle" width="400"><br>
          Booking for Service </td>
        </tr>
      </tbody></table>
       <form name="RMA" action="editregister.jsp" method="POST">
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
                    <td class="brdr"><%=request.getParameter("name")%></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Address </strong></td>
                    <td class="brdr"><%=request.getParameter("address")%></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>City </strong></td>
                    <td class="brdr"><%=request.getParameter("city")%></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF">&nbsp;</td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Zip Code </strong></td>
                    <td class="brdr"><%=request.getParameter("zip")%></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>State </strong></td>
                    <td class="brdr"><%=request.getParameter("country")%></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong> Phone </strong></td>
                    <td class="brdr"><%=request.getParameter("phone")%></td>
                  </tr>
                                <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>eMail </strong></td>
                    <td class="brdr"><%=request.getParameter("mail")%></td>
                  </tr>
                  
                  <tr align="left">
                    <td colspan="3" height="30"><table border="0" cellpadding="0" cellspacing="0" width="100%">
                      <tbody><tr>
                        <td><br>
                          <table align="center" border="0" cellpadding="0" cellspacing="0" width="95%">
                            <tbody><tr>
                              <td bgcolor="#EFEFEF" height="30"><strong><span class="red">&nbsp;*</span> Booking for Service </strong></td>
                            </tr>
                            <tr>
                              <td><strong>
                              </strong></td>
                            </tr>
                            <tr>
                              <td s="">                                <table border="0" cellpadding="2" cellspacing="2" width="100%">
            <tbody><tr>
              <td class="brdr">Vehicle Number </td>
              <td class="brdr"><%=request.getParameter("vnumber")%></td>
            </tr>
            <tr>
              <td class="brdr">Product you own</td>
              <td class="brdr"><%=request.getParameter("product")%>
                <br></td>
            </tr>
            <tr>
              <td class="brdr">Booking <br>
                Preferred date and time</td>
              <td class="brdr"><table border="0" cellpadding="0" cellspacing="0" width="100%">
                  <tbody><tr align="left">
                    <td height="30">
                      <%=request.getParameter("dd")%>&nbsp;-&nbsp;<%=request.getParameter("mm")%>&nbsp;-&nbsp;<%=request.getParameter("yy")%>
                      </td>
                    <td nowrap="nowrap">       <%=request.getParameter("tt")%>&nbsp;&nbsp;
                      <%=request.getParameter("ap")%></td>
                  </tr>
                </tbody></table></td>
            </tr>
            <tr>
              <td class="brdr" height="5">Problems you are facing</td>
              <td class="brdr"><%=request.getParameter("problem")%></td>
            </tr>
          
                                </tbody></table> </td>
                            </tr>
                        </tbody></table></td>
                      </tr>
                                                            </tbody></table></td>
                    </tr>
                  <tr align="left">
                    <td>&nbsp;</td>
                    <td height="30">&nbsp;</td>
                    <td>
                      <input name="Reset" class="button" onclick="call()" value="Edit" type="button">
                       
                      <input name="ok" class="button" onclick="call1()" value="OK" type="button"></td>
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
    <td></td>
  </tr>
  <tr>
    <td align="center">&nbsp;</td>
    <td align="center" valign="top"></td>
  </tr>
</tbody></table>

<center>
 </center>

</div>






<div id="tab" style="display:none">
<table align="center" border="0" cellpadding="0" cellspacing="0" width="600px">
  <tbody><tr valign="top">
    <td width="10px"></td>
    <td class="topbg"><br>
      <br>      
      <table border="0" cellpadding="0" cellspacing="0">
        <tbody><tr>
          <td class="title" height="67" valign="middle" width="400"><br>
          Booking for Service </td>
        </tr>
      </tbody></table>
       <form name="RMA" onsubmit="return check(this);" action="registrationupdate.jsp" method="POST">
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
                    <td class="brdr"><input name="name" class="txtfield" type="text" value="<%=request.getParameter("name")%>" /></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Password </strong></td>
                    <td class="brdr"><input name="password" class="txtfield" type="password"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Confirm Password </strong></td>
                    <td class="brdr"><input name="confirmpassword" class="txtfield" type="password"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Address </strong></td>
                    <td class="brdr"><textarea name="address" cols="40" class="txtfield"><%=request.getParameter("address")%></textarea></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>City </strong></td>
                    <td class="brdr"><select name="city" class="txtfield">
                        <option selected="selected" value="<%=request.getParameter("city")%>">Select City</option>
                    </select></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF">&nbsp;</td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Zip Code </strong></td>
                    <td class="brdr"><input name="zip" class="txtfield" type="text" value="<%=request.getParameter("zip")%>"></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>State </strong></td>
                    <td class="brdr"><select name="country" class="txtfield">
                        <option selected="selected" value="<%=request.getParameter("country")%>">Select State</option>
                    </select></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong> Phone </strong></td>
                    <td class="brdr"><input name="phone" class="txtfield" type="text" value="<%=request.getParameter("phone")%>"></td>
                  </tr>
                
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>eMail </strong></td>
                    <td class="brdr"><input name="mail" class="txtfield" type="text" value="<%=request.getParameter("mail")%>"></td>
                  </tr>
                  
                  <tr align="left">
                    <td colspan="3" height="30"><table border="0" cellpadding="0" cellspacing="0" width="100%">
                      <tbody><tr>
                        <td><br>
                          <table align="center" border="0" cellpadding="0" cellspacing="0" width="95%">
                            <tbody><tr>
                              <td bgcolor="#EFEFEF" height="30"><strong><span class="red">&nbsp;*</span> Booking for Service </strong></td>
                            </tr>
                            <tr>
                              <td><strong>
                              </strong></td>
                            </tr>
                            <tr>
                              <td s="">                                <table border="0" cellpadding="2" cellspacing="2" width="100%">
            <tbody><tr>
              <td class="brdr">Vehicle Number </td>
              <td class="brdr"><input name="vnumber" class="txtfield" type="text" value="<%=request.getParameter("vnumber")%>"></td>
            </tr>
            <tr>
              <td class="brdr">Product you own</td>
              <td class="brdr">
                <input type="text" name="product" class="txtfield" value="<%=request.getParameter("product")%>">
               </td>
            </tr>
            <tr>
              <td class="brdr">Booking <br>
                Preferred date and time</td>
              <td class="brdr"><table border="0" cellpadding="0" cellspacing="0" width="100%">
                  <tbody><tr align="left">
                    <td height="30"><input name="dd" class="txtfield" size="1" type="text" value="<%=request.getParameter("dd")%>">
                      <input name="mm" class="txtfield" size="1" type="text" value="<%=request.getParameter("mm")%>">
                      <input name="yy" class="txtfield" size="2" type="text" value="<%=request.getParameter("yy")%>"></td>
                    <td nowrap="nowrap">                    <input name="tt" class="txtfield" size="2" type="text" value="<%=request.getParameter("tt")%>"> <select name="ap" class="txtfield">
                      <option selected="selected" value="<%=request.getParameter("ap")%>">AM</option>
                      <option>PM</option>
                    </select></td>
                  </tr>
                </tbody></table></td>
            </tr>
            <tr>
              <td class="brdr" height="5">Problems you are facing</td>
              <td class="brdr"><textarea name="problem" cols="35" rows="6" class="txtfield"><%=request.getParameter("problem")%></textarea></td>
            </tr>
      
                                </tbody></table> </td>
                            </tr>
                        </tbody></table></td>
                      </tr>
                                                            </tbody></table></td>
                    </tr>
                  <tr align="left">
                    <td>&nbsp;</td>
                    <td height="30">&nbsp;</td>
                    <td><input name="Submit" class="button" value="submit" type="submit">
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
<center>
 </center>
 
</div>

<div id="tab1"  style="display:none; background-color:#0CF; border-bottom-style:solid; border-bottom-color:#30F; color:#FFF; width:600px; height:200px" align="center">
<br />
<br />
<br />
<font face="Trebuchet MS, Arial, Helvetica, sans-serif" size="+2">
Thank You For Your Registration</font>
<br />
<br />
<br />
<font face="Verdana, Geneva, sans-serif" size="+1">
You Have Successfully Registered.</font>
<br />
<br />
<br />
<br />
<a href="general.html"><input align="middle" type="button" class="button"  value="Back To Home" onclick="general.html"/></a>&nbsp;&nbsp;
<a href="login.jsp"><input align="middle" type="button" class="button"  value="Login" onclick="login.jsp"/></a>
</div>
 


 

<%


}
catch(Exception e)
{
	out.println(e);
}

}

%>


</body>
</html>