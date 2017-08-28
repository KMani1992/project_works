// JavaScript Document
var ajaxRequest;
function checkadminlog()
{
	var a=document.frmloginin.usname.value;
	var b=document.frmloginin.pass.value;
	if(a==""&&b=="")
	{
		alert("please Enter User name and Password.");
		return false;
	}
	if(a=="")
	{
		alert("please Enter User name.");
		return false;
	}
	if(b=="")
	{
		alert("please Enter and Password.");
		return false;
	}
	
	//alert("hello");
	return true;
}

function stuaddchk(){
	
	var stu_regno=document.frm_stuadd.stu_regno.value;
	var stu_mobno=document.frm_stuadd.stu_mobile.value;
	var stu_name=document.frm_stuadd.stu_name.value;	
	var stu_acyfrom=document.frm_stuadd.stu_acyfrom.value;
	var stu_acyto=document.frm_stuadd.stu_acyto.value;
	if(stu_name.length<3 ){
		alert("Please Enter Valid Student Name");
		document.frm_stuadd.stu_name.focus();
		return false;
	}
	if(stu_regno.length<10 ){
		alert("Please Enter Valid Register No");
		document.frm_stuadd.stu_regno.focus();
		return false;
	}
	if(stu_mobno.length < 10 || stu_mobno.length > 10 ){
		alert("Please Enter Valid Mobile Number");
		document.frm_stuadd.stu_mobile.focus();
		return false;
	}	
	if(stu_acyfrom>=stu_acyto){
		alert("Please Enter Valid Acadamic Year");
		document.frm_stuadd.stu_acyfrom.focus();
		return false;
	}
	return true;

}
function popupShow(){
	$("#outeroverlap").fadeIn("slow");
	$("#inneroverlap").fadeIn("slow");

}
function popupClose(){
	
	$("#outeroverlap").fadeOut("fast");
	$("#inneroverlap").fadeOut("fast");
}

function activate(){
	//alert("ts");
	document.getElementById("outeroverlap").style.display="none";
	document.getElementById("inneroverlap").style.display="none";
}
function editrow(id){
			
	var name=document.getElementById(id+'n').value;		
	var course=document.getElementById(id+'c').value;	
	var branch=document.getElementById(id+'b').value;	
	var email=document.getElementById(id+"e").value;	
	var mobile=document.getElementById(id+"m").value;
	var active=document.getElementById(id+"a").value;	
	active=active.toLocaleUpperCase();	
	
	$("#outeroverlap").fadeIn("slow");
	$("#inneroverlap").fadeIn("slow");
	document.getElementById("stu_name").value=name;
	document.getElementById("stu_course").value=course;
	document.getElementById("stu_branch").value=branch;
	document.getElementById("stu_email").value=email;
	document.getElementById("stu_mobile").value=mobile;
	document.getElementById("stu_active").value=active;
	document.getElementById("stu_regno").value=id;
}



function ajaxFunction(){
	
	try{
	ajaxRequest=new XMLHttpRequest();
	
	}catch(e){
		try{
			ajaxRequest=new XMLHttpRequest("Msxml2.XMLHTTP");
			
		}catch(e){
			try{
				ajaxRequest=new XMLHttpRequest("Microsoft.HTTPRequest");
		}catch(e){
			alert("Your Browser NOt Suporting With AJAX");
			return false;
		}
		}
	}
	
	}

function deleterow(rid){
	//alert(rid)
	var retVal=confirm("Do You Want To Delete Reg No:"+rid);
	
	if(retVal==true){		
		ajaxFunction();	
		ajaxRequest.onreadystatechange=function(){
		if(ajaxRequest.readyState==4){
			alert("Successfully Deleted");			
			}			
		}		
		var url="studel.php?rno=" + rid;
		ajaxRequest.open("GET",url,true);
		ajaxRequest.send(null);
	}
}
	
function staffedit(sid){	
	var name=document.getElementById(sid+"n").value;
	var active=document.getElementById(sid+"a").value;
	var pwd=document.getElementById(sid+"p").value;
	var staffid=document.getElementById(sid+"i").value;	
	active=active.toLocaleUpperCase( );	
	//document.getElementById("outeroverlap").style.display="block";
	//document.getElementById("inneroverlap").style.display="block";
	$("#outeroverlap").fadeIn("slow");
	$("#inneroverlap").fadeIn("slow");
	document.getElementById("staff_no").value=sid;
	document.getElementById("staff_name").value=name;
	document.getElementById("staff_pwd").value=pwd;
	document.getElementById("staff_id").value=staffid;
	document.getElementById("staff_active").value=active;
}


function addstaff(){
	$("#outeroverlapadd").fadeIn("slow");
	$("#inneroverlapadd").fadeIn("slow");
	
}


function staffadddpopupClose(){
	
	$("#outeroverlapadd").fadeOut("fast");
	$("#inneroverlapadd").fadeOut("fast");
}

function sendcircularemail(length){
	alert(length);
	// ajaxFunction();
	 alert("wel");
	 ajaxRequest.onreadystatechange=function(){
		 alert("wel2");
		 if(ajaxRequest.readyState==4){
			 alert("Circular sending has been Successfully Completed !!!");
		 }
		 alert();
		 var url="sendemailcircul.php?len=" + length;
		 ajaxRequest.open("GET",url,true);
		 ajaxRequest.send(null);
		 alert(length);
	 }
	
}
	function setemailvalue(){
	var leng=document.sendcircul.len.value;
	var res=false;
		var num=new Array();
		for(count=1;count<leng;count++){
		var v=document.getElementById(count).checked;
		var val=document.getElementById(count).value;
		if (v){
			var len=num.push(val);		
		}
		}			
		var sv=document.getElementById("emails");
		sv.value=num.toString();		
		if(num.toString().length != 0){			
			res=true;
		}else{
			alert("Please Select Any Student and Try Again !!!.");
		res=false;
		}
		return res;
	}