var ajaxRequest;//this variable makes ajex as posible
var flagRes=false;
function ajaxFunction(){
	//alert ("load1");
	try{
		ajaxRequest=new XMLHttpRequest();	
		//alert("test");
	}catch(e){
		try{
			ajaxRequest=new ActiveXObject("Msxml2.HTTPRequest");
			//alert("test");
			}catch(e){
				try{
					ajaxRequest=new ActiveXObject("Microsoft.XMLHTTP");
					}catch(e){
						alert("Your Browser Doesnot Support With AJAX");
					}
			}
		
	}
}
function dbinstall(){	
	//document.getElementById("loadingscreen").style.display="block";
	$("#loadingscreen").fadeIn("slow");
	ajaxFunction();	
	ajaxRequest.onreadystatechange=function(){		
		if(ajaxRequest.readyState==4){
			if(ajaxRequest.status==200){
				//alert("Success");
				//document.getElementById("loadingscreen").style.display="none";
				//document.userlogin.logresult =ajaxRequest.responseText;
				$("#loadingscreen").fadeOut("slow");
				
			//var ajaxDisplay=document.frmdbinstall.getElementById("restext");			
			}}};	
	var target=document.getElementById("cmbcompselect");	
	var url="DataBaseInsServlet?cmpName="+ escape(target.value);	
	ajaxRequest.open("get", url, true);	
	ajaxRequest.send(null);	
}
function getCompany(){
	//document.getElementsByName("");	
	alert ("load");
	
	//$("#loadingscreen").fadeIn("slow");
	ajaxFunction();
	ajaxRequest.onreadystatechange=function(){		
		if(ajaxRequest.readyState==4){
			if(ajaxRequest.status==200){
				
				$("#loadingscreen").fadeOut("slow");				
						
			}}};	
	
	var url="DataBaseInsServlet?loadcmpName=getcmp";	
	ajaxRequest.open("get", url, true);	
	ajaxRequest.send(null);
	
}
function userlogin(){
	//alert("Success");
	
	$("#loginback").fadeOut("fast");
	$("#logininner").fadeOut("fast");
	//document.getElementById("loadingscreen").style.display="block";	
	$("#loadingscreen").fadeIn("slow");	
	
	ajaxFunction();	
	ajaxRequest.onreadystatechange=function(){		
		if(ajaxRequest.readyState==4){
			
			if(ajaxRequest.status==200){
				//alert("Success");
				//document.getElementById("loadingscreen").style.display="none";
				$("#loadingscreen").fadeOut("slow");
				if (ajaxRequest.getResponseHeader("val")=="Success"){
					window.location.href = "\welcome.jsp";
				}else if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\errorpage.jsp?status=" + "Login Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\errorpage.jsp?status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}		
				
				//window.location.href = "\welcome.jsp";
				//alert("Success");
			//var ajaxDisplay=document.frmdbinstall.getElementById("restext");			
			}}};	
			
	
	var username=document.getElementById("logusername").value;
	var password=document.getElementById("logpassword").value;
	//alert(username+password);
	var url="UserLogin?loguser=" + username + "&logpass=" + password;
	
	ajaxRequest.open("GET", url, true);	
	//alert(username+password);
	ajaxRequest.send(null);
	
	//alert(username+password);
	
}
function custregistration(){
	//alert (document.frmcustreg.custname.value.length);
	if(document.frmcustreg.custname.value.length>30){
		alert ("Please Enter Name Within 30 Character");
		document.frmcustreg.custname.focus();
		return false;
	}else if(document.frmcustreg.motbikeno.value.length>10 ){
		alert ("Please Enter MotorBikeNumber Within 10 Character");
		document.frmcustreg.motbikeno.focus();
		return false;
	}else if(document.frmcustreg.motbikename.value.length>20){
		alert ("Please Enter BikeName Within 20 Character");
		document.frmcustreg.motbikename.focus();
		return false;
	}else if(document.frmcustreg.mobileno.value.length>10 || document.frmcustreg.mobileno.value.length<10){
		alert ("Please Enter Your Mobile Number Within 10 Character");
		document.frmcustreg.mobileno.focus();
		return false;
	}else if(document.frmcustreg.custregpassword.value.length>10){
		alert ("Please Enter Your Password Within 10 Character");
		document.frmcustreg.custregpassword.focus();
		return false;
	}else if(document.frmcustreg.custregpassword.value != document.frmcustreg.custregconfirmpassword.value){
		alert ("You Entered Your Password and ConfirmPassword NotMatching");
		document.frmcustreg.custregconfirmpassword.focus();
		return false;
	}else {			
	return  ( true );
	
	}
	}


function validateuserlogin(){
	//alert("hello");
	if(document.getElementById("logusername").value=="" && document.getElementById("logpassword").value==""){
		alert ("Please Enter Your Correct E-Mail Address and Password");
		document.getElementById("logusername").focus();	
		return false;
	}
	
	if(document.getElementById("logusername").value!=""){
		var emailid=document.getElementById("logusername").value;
		var atpos=emailid.indexOf("@");
		var dotpos=emailid.lastIndexOf(".");
		if(atpos<2 || (dotpos-atpos)<2){
			alert ("Please Enter Your Correct E-Mail Address");
			document.getElementById("logusername").focus();	
			return false;
		}
		
	}
	
	if(document.getElementById("logusername").value!=""  && document.getElementById("logpassword").value=="" ){
		alert ("Please Enter Your Password");
		document.getElementById("logpassword").focus();	
		return false;
	}
	//return ( true );
	userlogin();
	//return ( true );
	
}
function pbmbookregistration(){
	//alert("insidepbm");	
	$("#loadingscreen").fadeIn("slow");	
	
	ajaxFunction();	
	//alert("insidepbm1");
	ajaxRequest.onreadystatechange=function(){		
		if(ajaxRequest.readyState==4){			
			if(ajaxRequest.status==200){
				$("#loadingscreen"). fadeOut("slow");
				if (ajaxRequest.getResponseHeader("val")=="Success"){			
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Book My Registration&status="+ "You Have Successfully Registered, Your Registeration Id is : " + ajaxRequest.getResponseHeader("regid");				
				}else if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Book My Registration&status=" + "Registration Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Book My Registration&status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}						
			}}};				
	
	var pbval=document.getElementById("pbid").value;
	var motbikno =document.getElementById("hidmobikno").value;
	var emailaddr =document.getElementById("hidemailaddr").value;
	var url="servletbookregistration?pbid=" + pbval + "&mobikno=" + motbikno + "&email=" + emailaddr;	
	ajaxRequest.open("GET", url, true);
	ajaxRequest.send(null);	
}
function pbmbookingvalidate(){
	var pbval=document.getElementById("pbid").value;
	//alert(pbval);
	if (pbval!=""){		
		pbmbookregistration();		
		
	}else if (pbval==""){
		alert("Please Enter Your Problems");
		document.getElementById("pbid").focus();
		return false;
	}
}

//registration status view
function regstatusview(){
$("#loadingscreen").fadeIn("slow");
	ajaxFunction();	
	//alert("insidepbm1");
	ajaxRequest.onreadystatechange=function(){		
		if(ajaxRequest.readyState==4){			
			if(ajaxRequest.status==200){
				$("#loadingscreen"). fadeOut("slow");	
				var jsonobj=JSON.parse(ajaxRequest.responseText);
				$("#regstatustb").find("tr:gt(0)").remove();
         	   var table1 = $("#regstatustb");
         	   var inhtmlstr;
         	   var cnt=0;
         	 
				$.each(jsonobj, function(key,value) {
					 //document.getElementById("tstdiv").innerHTML=value['RSOrderMajorId'];
					cnt=cnt+1;
					var rowNew = $("<tr><td></td></tr>");
					inhtmlstr="";					
					inhtmlstr ="<div class='regstsmryct' title='Click To Detailed Status View' onclick='regstsexpandviw(" + value['RSOrderMajorId'] + ")'>";
					inhtmlstr += "  <div class='clsrerstctop'>";
					inhtmlstr += "    <strong>" + value['RSordersubject'] + "</strong> - " + value['RSorddetsmry'];
					inhtmlstr += "  </div>";					
					inhtmlstr += "  <div class='clsrerstcbtm'>";		
					inhtmlstr += "    <div class='clsrerstcbtmlft'><big class='rgstbt'>Finished/UnFinished Problems :</big>";
					inhtmlstr += "      <small class='rgstst'>" + value['RSFinished'] + "<big class='rgstbt'>/</big>" + value['RSUnFinished'] + "</small>";					
					inhtmlstr += "    </div>";					
					inhtmlstr += "    <div class='clsrerstcbtmrgt'><big class='rgstbt'>DateOfBooking/Delivery : </big>";
					inhtmlstr += "      <small class='rgstst'>" + value['RSupdated'] + "</small> <big class='rgstbt'>/</big>";
					inhtmlstr += "      <small class='rgstst'>" + value['RSupdated'] + "</small>";					
					inhtmlstr += "    </div>";				
					inhtmlstr += "  </div>";
					inhtmlstr += "</div>";					
                    rowNew.children().eq(0).html(inhtmlstr);
                    rowNew.appendTo(table1);
					
				 });	
				 $("#regstatustb").attr("height",cnt * 40);
				 document.getElementById("rgstttr").innerHTML=cnt;
				if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "RegistrationStatus&status=" + "Registration Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "RegistrationStatus&status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}						
			}}};		
	
	var motbikno =document.getElementById("hidmobikno").value;
	var emailaddr =document.getElementById("hidemailaddr").value;
	var url="RegistrationStatus?mobikno=" + motbikno + "&email=" + emailaddr;	
	ajaxRequest.open("GET", url, true);
	ajaxRequest.send(null);		
}
function regstsexpandviw(ordmajid){
	//alert("regstsexpandviw : " + ordmajid);	
	$("#loginback").fadeIn("slow");
	$("#logininner").fadeIn("slow");
	document.getElementById("sbtregid").innerHTML=ordmajid;
	$("#loadiner").fadeIn("slow");
	ajaxFunction();	
	//alert("Test");
	ajaxRequest.onreadystatechange=function(){		
		if(ajaxRequest.readyState==4){			
			if(ajaxRequest.status==200){				
				var jsonobj=JSON.parse(ajaxRequest.responseText);
				
				$("#pbregstdetviw").find("tr:gt(0)").remove();
         	   var table1 = $("#pbregstdetviw");
         	   var inhtmlstr;
         	   var cnt=0;
         	 
				$.each(jsonobj, function(key,value) {
					 //document.getElementById("tstdiv").innerHTML=value['RSOrderMajorId'];
					cnt=cnt+1;
		
					rowdt="<tr>";
					rowdt +="<td class='ppwtr' width='38px'></td>";
					rowdt +="<td class='ppwtr' width='238px'></td>";
					rowdt +="<td class='ppwtr' width='88px'></td>";
					rowdt +="<td class='ppwtr' width='238px'></td>";
					rowdt +="</tr>";
					var rowNew = $(rowdt);
									
                    //rowNew.children().eq(0).html(inhtmlstr);
                    rowNew.children().eq(0).text(cnt); 
                    rowNew.children().eq(1).text(value['pbid']); 
                    rowNew.children().eq(2).text(value['pbfinunfin']);                    
                    rowNew.children().eq(3).text(value['pbidrem']);
                    rowNew.appendTo(table1);
					
				 });	
				 $("#pbregstdetviw").attr("height",cnt * 40);
				 document.getElementById("rgsdvnp").innerHTML=cnt;
				 $("#loadiner").fadeOut("slow");
					$("#ppwincnt").fadeIn("slow");
				if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "RegistrationStatusDetailedView&status=" + "Registration Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "RegistrationStatusDetailedView&status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}						
			}}};		
	
	var motbikno =document.getElementById("hidmobikno").value;
	var emailaddr =document.getElementById("hidemailaddr").value;	
	var url="RegistrationStatusdetviwServlet?mobikno=" + motbikno + "&email=" + emailaddr + "&pbmajid=" + ordmajid;	
	ajaxRequest.open("GET", url, true);
	ajaxRequest.send(null);
	
		
	
	
}
function popupclose(){
	$("#loadiner").fadeOut("slow");
	$("#loginback").fadeOut("fast");
	$("#logininner").fadeOut("fast");
}


//profile updation
function pwordupd(){				
	document.getElementById("pwordchng").style.display="none";				
	//$("#pwordchng").fadeOut("fast");
	$("#profupd").fadeIn("slow");	
	
}
function chngpwdscr(){			
	$("#profupd").fadeOut("fast");
	$("#pwordchng").fadeIn("slow");
	document.frmpwdchng.custregoldpassword.focus();
}
function goback(){				
	document.getElementById("pwordchng").style.display="none";
	//$("#pwordchng").fadeOut("fast");
	$("#profupd").fadeIn("slow");
}
function profupdtvalidate(){
	//alert("tst");
	if(document.frmproupd.custname.value.length>30 || document.frmproupd.custname.value.length==0){
		alert ("Please Enter Name Within 30 Character");
		document.frmproupd.custname.focus();
		return false;
	}else if(document.frmproupd.motbikeno.value.length>10 || document.frmproupd.motbikeno.value.length==0){
		alert ("Please Enter MotorBikeNumber Within 10 Character");
		document.frmproupd.motbikeno.focus();
		return false;
	}else if(document.frmproupd.motbikename.value.length>20 || document.frmproupd.motbikename.value.length==0){
		alert ("Please Enter BikeName Within 20 Character");
		document.frmproupd.motbikename.focus();
		return false;
	}else if(document.frmproupd.mobileno.value.length>10 || document.frmproupd.mobileno.value.length<10){
		alert ("Please Enter Your Mobile Number Within 10 Character");
		document.frmproupd.mobileno.focus();
		return false;
	}else{
		profupdsndpro();
		//return ( true );
	}
		
}

function profupdsndpro(){
	$("#loadingscreen"). fadeIn("slow");
	ajaxFunction();	
	//alert("Test");	
	
	
	//alert(motbikno + ":" + emailaddr + ":" + ucustname + ":" + umobikno + ":" + umobikname + ":" + umobno );
	ajaxRequest.onreadystatechange=function(){
		//alert("Testlosc");
		
		if(ajaxRequest.readyState==4){			
			if(ajaxRequest.status==200){
				$("#loadingscreen"). fadeOut("slow");
				if (ajaxRequest.getResponseHeader("val")=="Success"){			
					window.location.href = "\profile.jsp";
					alert("Profile Has Been Successfully Updated");
				}else if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Profile Status Updation Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}						
			}}};		
	
	
			var motbikno =document.getElementById("hidmobikno").value;
			var emailaddr =document.getElementById("hidemailaddr").value;
			var ucustname=document.frmproupd.custname.value;
			var umobikno=document.frmproupd.motbikeno.value;
			var umobikname=document.frmproupd.motbikename.value;
			var umobno=document.frmproupd.mobileno.value;
			
			//alert(motbikno + ":" + emailaddr + ":" + ucustname + ":" + umobikno + ":" + umobikname + ":" + umobno );
			
	var url="ProfupdServlet?proc=updprofdet&mobiknop=" + motbikno + "&email=" + emailaddr + "&ucustname=" + ucustname + "&umobikno=" + umobikno + "&umobikname=" + umobikname + "&umobno=" + umobno;	
	ajaxRequest.open("GET", url, true);
	ajaxRequest.send(null);
}


function chngpwdvalidate(){
	//alert("tst");	
	
	if(document.frmpwdchng.custregoldpassword.value.length>10 || document.frmpwdchng.custregoldpassword.value.length==0){
		alert ("Please Enter Your Old Password Within 10 Character");
		document.frmpwdchng.custregoldpassword.focus();
		return false;
	}else if(document.frmpwdchng.custregpassword.value.length>10 || document.frmpwdchng.custregpassword.value.length==0){
		alert ("Please Enter Your Password Within 10 Character");
		document.frmpwdchng.custregpassword.focus();
		return false;
	}else if(document.frmpwdchng.custregpassword.value != document.frmpwdchng.custregconfirmpassword.value || document.frmpwdchng.custregconfirmpassword.value.length==0){
		alert ("You Entered Your Password and ConfirmPassword NotMatching");
		document.frmpwdchng.custregconfirmpassword.focus();
		return false;
	}else {			
	
		//return ( true );
		 profpwdchgajx();
	
	}
}


function profpwdchgajx(){
	
	$("#loadingscreen"). fadeIn("slow");
	ajaxFunction();	
	//alert("Test");	
	
	var motbikno =document.getElementById("hidmobikno").value;
	var emailaddr =document.getElementById("hidemailaddr").value;
	var custregoldpwd=document.frmpwdchng.custregoldpassword.value;
	var custregpwd=document.frmpwdchng.custregpassword.value;
	var confirmpwd=document.frmpwdchng.custregconfirmpassword.value;
	
	
	//alert(motbikno + ":" + emailaddr + ":" + custregoldpwd + ":" + custregpwd + ":" + confirmpwd);
	
	
	//alert(motbikno + ":" + emailaddr + ":" + ucustname + ":" + umobikno + ":" + umobikname + ":" + umobno );
	ajaxRequest.onreadystatechange=function(){
		//alert("Testlosc");
		
		if(ajaxRequest.readyState==4){			
			if(ajaxRequest.status==200){
				$("#loadingscreen"). fadeOut("slow");
				if (ajaxRequest.getResponseHeader("val")=="Success"){			
					window.location.href = "\profile.jsp";
					alert("Password Has Been Successfully Updated");
				}else if(ajaxRequest.getResponseHeader("val")=="PWFail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Password Updation Failed, Please Verify You Entered Your Old Password ...";
				}else if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Password Updation Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}						
			}}};		
	
			
	var url="ProfupdServlet?proc=updprofpwdchg&mobiknop=" + motbikno + "&email=" + emailaddr + "&updolpw=" + custregoldpwd + "&updcurpw=" + custregpwd + "&cnfrmpwd=" + confirmpwd;	
	ajaxRequest.open("GET", url, true);
	ajaxRequest.send(null);
	
}
function vehhelstatus(){

	$("#loadingscreen"). fadeIn("slow");
	ajaxFunction();	
	//alert("Test");	
	
	var motbikno =document.getElementById("hidmobikno").value;
	var emailaddr =document.getElementById("hidemailaddr").value;
	
	ajaxRequest.onreadystatechange=function(){
		//alert("Testlosc");
		
		if(ajaxRequest.readyState==4){			
			if(ajaxRequest.status==200){
				$("#loadingscreen"). fadeOut("slow");
				if (ajaxRequest.getResponseHeader("val")=="Success"){			
					//window.location.href = "\profile.jsp";
					
				}else if(ajaxRequest.getResponseHeader("val")=="PWFail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Password Updation Failed, Please Verify You Entered Your Old Password ...";
				}else if (ajaxRequest.getResponseHeader("val")=="Fail"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Password Updation Failed, GoBack and TryAgain ...";
				}else if (ajaxRequest.getResponseHeader("val")=="TechErr"){
					window.location.href = "\rresponsemessage.jsp?pgtitle=" + "Profile Status&status=" + "Sorry !!! Some Technical Errors Occurred, Please Contact SystemAdmin ...";
				}						
			}}};		
	
			
	var url="HealthStatusServlet?proc=updprofpwdchg&mobiknop=" + motbikno + "&email=" + emailaddr;	
	ajaxRequest.open("GET", url, true);
	ajaxRequest.send(null);
}
