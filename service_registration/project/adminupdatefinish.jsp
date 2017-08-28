<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" %>
<%
String erro=request.getParameter("error");
if(erro==null || erro=="null"){
 erro="";
}
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>duraiRaj Auto Admin page</title>
<link href="bikes.css" rel="stylesheet" type="text/css">
<link href="booking-service_files/shailey.css" rel="stylesheet" type="text/css">
 <script src="booking-service_files/swfobject.js" type="text/javascript"></script>
 <link href="WebResource.css" rel="stylesheet" type="text/css" media="all"><link href="main.css" rel="stylesheet" type="text/css">
 <link href="../../../../../Users/mani/AppData/Local/Temp/style.css" rel="stylesheet" type="text/css" />
<style>

body{
font-family:Verdana, Geneva, sans-serif;
font-size:14px;}

.slidingDiv {
	height:200px;
	background-color: #99CCFF;
	padding:20px;
	margin-top:10px;
	border-bottom:5px solid #3399FF;
}

.show_hide {
	
	display:none;
}
.show_hid {
	
	display:none;
}

.slidingDi {
	height:300px;
	background-color: #99CCFF;
	padding:20px;
	margin-top:10px;
	border-bottom:5px solid #3399FF;
}

.error
{
	color:#C00;
	text-align:right;
}
.reginf {
	
	display:none;
}

</style>
<body>


<%
String dname=null;
String vehicle=null;
String dcity=null;
String dphone=null;
String demail=null;
String daddress=null;
String dproblem=null;
String dremark=null;
String ddate=null;
String dmonth=null;
String dyear=null;
//String pword=null;
String message;
String vno=request.getParameter("keysearch");
//String pass=request.getParameter("password");
out.println(vno);
//out.println(pass);
try
{
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection connection=DriverManager.getConnection(ss);
//Statement st=con.createStatement();
Statement statement = connection.createStatement();

ResultSet re=statement.executeQuery("select * from details where vehiclenumber='"+vno+"'");
while(re.next())
{
dname=re.getString("fullname");	
vehicle=re.getString("vehiclenumber");
dcity=re.getString("city");
dphone=re.getString("phone");
demail=re.getString("email");
daddress=re.getString("address");
dproblem=re.getString("problem");
dremark=re.getString("remark");
ddate=re.getString("dd");
dmonth=re.getString("mm");
dyear=re.getString("yy");








//pword=re.getString("password");
out.println(vehicle);
//out.println(pword);
}

	if(vno.equals(vehicle))
	{
		out.println("success");





%>

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


<div class="search-bar">
                
       <div class="spacer">
            </div>
        </div>
        
            <div class="body">
                <div class="search-container">
                    <div style="display: block;" id="ctl00_pnlSearch" class="search hide-me">
	
                        <div class="seperator">
                            <div id="ctl00_pnlAdvSearch" class="adv-search left" onkeypress="javascript:return WebForm_FireDefaultButton(event, 'ctl00_btnAdv')">
		
                               
                                <div id="ctl00_upSearch">
			
                                        <ul class="criteria">
                                            <li>
                                                
                                                
                                            </li>
                                            
                                        </ul>
                                        
			</div>
                                    
		</div>
                                                        
	</div>
                            <div id="ctl00_pnlBasicSearch" class="basic-search left" onkeypress="javascript:return WebForm_FireDefaultButton(event, 'ctl00_btnBasic')">
                                <form action="adminsearch.jsp" method="get">
                                <table><tr><td>
		
                                <h4>
                                    Keyword Search </h4>
                           </td></tr></table><table>
                      
                               <tr><td><input name="keysearch" class="bike-basic-search-tb tb keyword-search ac_input" type="text">
                                </td><td><input name="ctl00$btnBasic" id="ctl00_btnBasic" class="basic-search-btn" text="Search" src="new/go.png" style="border-width: 0px;" type="image"></td></tr><tr><td>
                                 <input type="reset" value="Reset Search" />&nbsp;&nbsp;&nbsp;<span class="error"></span></td></tr></table>
                                
 </form>                       
                            
	</div>
                            <div class="clear-me">
                            </div>
                        </div>
                        </div>
                        </div>
                        </div>







                        <center>
                       <table border="0" cellpadding="0" cellspacing="0" width="600px">
  <tbody><tr valign="top">
    <td align="center" width="10"></td>
    <td class="topbg">
      <table border="0" cellpadding="0" cellspacing="0">
        <tbody><tr>
          <td class="title" height="27" width="400"><br>
         Customer Registration Information </td>
        </tr>
      </tbody></table>
    <form action="adminupdate.jsp" name="frmFilldetails" id="idFilldetails" method="POST">
            <table align="center" border="0" cellpadding="0" cellspacing="0" width="90%">
              <tbody><tr>
                <td align="left" background="booking-service_files/left.gif" bgcolor="#F7F7F7" valign="top" width="6"><img src="booking-service_files/1.jpg" height="6" width="6"></td>
                <td colspan="2" rowspan="2" class="bg" bgcolor="#F7F7F7"><br>
                  <table class="bike" border="0" cellpadding="2" cellspacing="2" width="100%">
                  <tbody><tr align="left" valign="top">
                                     </tr>
                  <tr align="left">
                    <td colspan="3" align="center"></td>
                    </tr>
                       <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Full Name </strong></td>
                    <td class="brdr"><input name="name" class="txtfield" type="text" value="<%=dname%>" /></td>
                  </tr>
                   <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Vehicle No </strong></td>
                    <td class="brdr"><input name="vehno" class="txtfield" type="text" value="<%=vehicle%>" /></td>
                  </tr>
                  
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>City </strong></td>
                    <td class="brdr"><input name="city" class="txtfield" type="text" value="<%=dcity%>" /></td>
                  </tr>
                                 
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong> Phone </strong></td>
                    <td class="brdr"><input name="phone" class="txtfield" type="text" value="<%=dphone%>"></td>
                  </tr>
                 
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>eMail </strong></td>
                    <td class="brdr"><input name="mail" class="txtfield" type="text" value="<%=demail%>"></td>
                  </tr>
                  
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Address </strong></td>
                    <td class="brdr"><textarea name="address" cols="40" class="txtfield"><%=daddress%></textarea></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Problem </strong></td>
                    <td class="brdr"><textarea name="address" cols="40" class="txtfield"><%=dproblem%></textarea></td>
                  </tr>
                  <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Remarks </strong></td>
                    <td class="brdr"><textarea name="address" cols="40" class="txtfield"><%=dremark%></textarea></td>
                  </tr>
                   <tr>
                <tr align="left">
                    <td align="center" bgcolor="#EFEFEF"><span class="red">*</span></td>
                    <td bgcolor="#EFEFEF" height="30"><strong>Booking Date </strong></td>
                    <td class="brdr"><input name="dd" class="txtfield" value="dd" size="1" type="text" value="<%=ddate%>">
                     <input name="dd" class="txtfield" value="mm" size="1" type="text" value="<%=dmonth%>">
                     <input name="yy" class="txtfield" value="yy" size="2" type="text" value="<%=dyear%>">
                    </td>
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
   </td>
  </tr>
  
  <tr>
    <td align="center">&nbsp;</td>
    <td align="center" valign="top"></td>
  </tr>
</tbody></table>
<br />



<script type="text/javascript">

$(document).ready(function(){


    $(".slidingDi").hide();
	$(".show_hid").show();
	
	$('.show_hid').click(function(){
	$(".slidingDi").slideToggle();
	});

});
</script>


<table align="center"><tr><td>
   <a id="ctl00_hlSearch" class=" show_hid" href="#"><img src="new/update-button.png" style="border-width: 0px;" onclick="vie()"></a>
 </td></tr></table>

     <div class="slidingDi">
     
     
     
       <table align="center"><tr><td>
<div class="breadcrumbwrap" id="cen">
<div class="contentBoxRed"><!--contentBoxRed -->

	<div class="stepNosDisplayDiv"><!--stepNosDisplayDiv -->
       <div class="nodisplayTab"><!--nodisplayTab-->
        <div class="no_left"><!--no_left -->
        
        
         <div class="displayNoDiv">&nbsp;</div>
        </div><!--no_left END-->
        <div class="title_right"><div><h4 style="color:rgb(248, 42, 36)">
                 FILL IN THE DETAILS OF BIKE NO <span style="color:#FFF"><%=vehicle%>&nbsp;,&nbsp;<%=dname%></span></h4>
                 </div>
           
<%=erro%>
                 </div><!--title_right END-->
       </div><!--nodisplayTab END-->
      
        
      </div><!--stepNosDisplayDiv ENDS-->
	<!-- form start --> 
	
		

					<div class="bikeConditionDiv"><!--bikeConditionDiv -->
						<h2>BIKE CONDITION</h2>		
						<div style="width:287px;">
						<table border="0" cellpadding="0" cellspacing="0" width="287">
						                           
                          <tbody><tr>
                          
                          
							<td width="117">Battery</td>
							<td width="170">
								<select name="selBattery" id="idBattery" class="selectStep2">
									<option value="99" selected="selected">Excellent</option>
									<option value="90">Good</option>
									<option value="79">Medium</option>
									<option value="55">Bad</option>
								</select>
							</td>
						  </tr>
						  <tr>
							<td>Engine</td>
							<td><select name="selEngine" id="idEngine" class="selectStep2">
								<option value="99" selected="selected">Excellent</option>
									<option value="80">Good</option>
									<option value="75">Medium</option>
									<option value="50">Bad</option>
							  </select>
							 </td>
						  </tr>
						  <tr>
							<td>Suspensions</td>
							<td><select name="selSuspension" id="idSuspension" class="selectStep2">
								<option value="100" selected="selected">Excellent</option>
								<option value="90">Good</option>
								<option value="70">Medium</option>
								<option value="60">Bad</option>
							  </select>
							</td>
						  </tr>
						</tbody></table>
						</div>
						<div style="width:252px;">
						<table border="0" cellpadding="0" cellspacing="0" width="252">
						  <tbody><tr>
							<td width="90">Brakes</td>
							<td width="162">
								<select name="selBrakes" id="idBrakes" class="selectStep2">
									<option value="99" selected="selected">Excellent</option>
									<option value="80">Good</option>
									<option value="65">Medium</option>
									<option value="50">Bad</option>
									</select>
							</td>
						  </tr>
						  <tr>
							<td>Exterior</td>
							<td><select name="selExterior" id="idExterior" class="selectStep2">
								<option value="99" selected="selected">Excellent</option>
								<option value="80">Good</option>
								<option value="70">Medium</option>
								<option value="65">Bad</option>
							  </select>
							 </td>
						  </tr>
						  <tr>
							<td>Tyres</td>
							<td><select name="selTyres" id="idTyres" class="selectStep2">
									<option value="97" selected="selected">Excellent</option>
								<option value="78">Good</option>
								<option value="66">Medium</option>
								<option value="42">Bad</option>
							  </select>
							</td>
						  </tr>
						</tbody></table>
						</div>
						<div style="width:278px;">
						<table border="0" cellpadding="0" cellspacing="0" width="278">
						  <tbody><tr>
							<td width="96">Electricals</td>
							<td width="182">
								<select name="selElectricals" id="idElectricals" class="selectStep2">
									<option value="97" selected="selected">Excellent</option>
								<option value="80">Good</option>
								<option value="70">Medium</option>
								<option value="40">Bad</option>
								</select>
							</td>
						  </tr>
						  <tr>
							<td>Seats</td>
							<td><select name="selSeats" id="idSeats" class="selectStep2">
								<option value="89" selected="selected">Excellent</option>
								<option value="80">Good</option>
								<option value="65">Medium</option>
								<option value="40">Bad</option>
							  </select>
							 </td>
						  </tr>
						  <tr>
							<td>Overall</td>
							<td><select name="selOverall" id="idOverall" class="selectStep2">
									<option value="92" selected="selected">Excellent</option>
									<option value="70">Good</option>
									<option value="60">Medium</option>
									<option value="40">Bad</option>
							  </select>
							</td>
						  </tr>
                          
						</tbody></table>
						</div></div>
                         <table align="center">
                         <tr><td> 
                         <br />
                 
                                 <input name="Submit" class="" value="update status" type="image" src="new/update.png">
                </td></tr></table>
                        
                        
                        </div>	
                        </form>						
				  </div><!--bikeConditionDiv END-->
				</div>
                <!--formDataMid END-->
              </td></tr></table>  

        
        
        
        
        
        
        
        
        
        
         <a href="#" class="show_hid">hide</a>
        
        
        
        
    </div>


</div>



</center>
 <%}
   else
    {
      message="No results found" ;
      response.sendRedirect("adminpage.jsp?error="+message);
    }
    }
    catch(Exception e)
    {
        out.println(e);
    }

    
    /// close object and connection
  
%>         



</body>
</html>