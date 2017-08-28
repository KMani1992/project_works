<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Durairaj auto works</title>

<link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 <script src="booking-service_files/swfobject.js" type="text/javascript"></script>
 
  <script type="text/javascript">
function check(form)
{
	var v1=document.forms[0].name.value;
	var v10=document.forms[0].vnumber.value;
	var v2=document.forms[0].password.value;
    var v3=document.forms[0].confirmpassword.value;
	var v4=document.forms[0].address.value;
	var v5=document.forms[0].city.value;
    var v6=document.forms[0].zip.value;
	var v7=document.forms[0].country.value;
    var v8=document.forms[0].phone.value;
	var v9=document.forms[0].mail.value;
	
   
	
	var z1=v1.length
	var z2=v2.length
	var z3=v4.length
	
    var z5=v6.length
	var z6=v8.length
	var z7=v9.length
	var z8=v9.indexOf("@")
	var z9=v9.indexOf(".")
	var z10=v11.length
	
		
	var z16=v10.length
	
	  
   
  
   if(v1==""||v2==""||v3==""||v4==""||v5==""||v6==""||v7==""||v8==""||v9==""||v10=="")
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
	
	
		
			return true;
	

}
</script>

 
 
 
 
</head>
<body bgcolor="#ffffff">

<table border="0" cellpadding="0" cellspacing="0" width="600px">
  <tbody><tr valign="top">
    <td align="center" width="10"></td>
    <td class="topbg"><br>
      <br>      
      <table border="0" cellpadding="0" cellspacing="0">
        <tbody><tr>
          <td class="title" height="67" width="400"><br>
         Customer Registration </td>
        </tr>
      </tbody></table>
       <form name="RMA" onsubmit="return check(this);" action="userreg.jsp" method="POST">
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
                    <td class="brdr"><input name="vnumber" class="txtfield" type="text"></td>
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
                    <td class="brdr"><textarea name="address" cols="40" class="txtfield"></textarea></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>City </strong></td>
                    <td class="brdr"><select name="city" class="txtfield">
                        <option selected="selected">Select City</option>
                         <option selected="selected">Nagercoil</option>
                          <option selected="selected">Madurai</option>
                           <option selected="selected">Trichy</option>
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
                        <option selected="selected">Tamil nadu</option>
                         <option selected="selected">Kerala</option>
                          <option selected="selected">Ap</option>
                           <option selected="selected">mp</option>
                    </select></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong> Phone </strong></td>
                    <td class="brdr"><input name="phone" class="txtfield" type="text"></td>
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
                    <td><input name="Register" class="button" value="Submit" type="submit">
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
</body>
</html>
