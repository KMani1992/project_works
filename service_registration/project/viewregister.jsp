<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html><head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Durairaj Auto Works Pvt Ltd</title>
  <link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 <script src="booking-service_files/swfobject.js" type="text/javascript"></script>
</head>
 <body leftmargin="0" topmargin="0" marginheight="0" marginwidth="0"><table align="center" border="0" cellpadding="0" cellspacing="0" width="778">
  <tbody><tr valign="top">
    <td align="center" width="222"></td>
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
                    <td bgcolor="#EFEFEF" height="30"><strong>Fax </strong></td>
                    <td class="brdr"><%=request.getParameter("fax")%></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>eMail </strong></td>
                    <td class="brdr"><%=request.getParameter("mail")%></td>
                  </tr>
                   <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>password </strong></td>
                    <td class="brdr"><%=request.getParameter("password")%></td>
                  </tr>
                   <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>confirm password </strong></td>
                    <td class="brdr"><%=request.getParameter("confirmpassword")%></td>
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
                    <td height="30"><%=request.getParameter("other")%><br>
                      <%=request.getParameter("dd")%><%=request.getParameter("mm")%><%=request.getParameter("yy")%>
                      </td>
                    <td nowrap="nowrap">       <%=request.getParameter("tt")%>&nbsp;
                      <%=request.getParameter("ap")%></td>
                  </tr>
                </tbody></table></td>
            </tr>
            <tr>
              <td class="brdr" height="5">Problems you are facing</td>
              <td class="brdr"><%=request.getParameter("problem")%></td>
            </tr>
            <tr>
              <td class="brdr" height="5">Remarks</td>
              <td class="brdr"><%=request.getParameter("remark")%></td>
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
                      <input name="Reset" class="button" value="Save" type="submit"></td>
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
 

</body></html>