function compvalidate(){	
	var periodefrom=document.frmcompanycr.periodfrom.value;
	var periodeto=document.frmcompanycr.periodto.value;
	var dbpath =document.frmcompanycr.dbpath.value;
	var colpos =dbpath.indexOf(":");	
	if(colpos != 1){
		alert("Please Enter Valid Path");
		document.frmcompanycr.dbpath.focus();
		return false;
	}
	if (periodefrom >= periodeto ){
		alert("Please Enter Valid Period From To Date");
		document.frmcompanycr.periodfrom.focus();
		return false;
	}
	return ( true );
}
function setfocus(){
	document.frmcompanycr.companyname.focus();
}
function load(){
	alert("hello");	
	return false;
}
function loadcompany(){
	document.frmdbinstall.cmbcompselect.focus();
	document.frmdbinstall.cmbcompselect.value="hello";
	
}

function validateEmail(){
	if(document.frmcustreg.emailaddr.value!=""){
		var emailid=document.frmcustreg.emailaddr.value;
		var atpos=emailid.indexOf("@");
		var dotpos=emailid.lastIndexOf(".");
		if(atpos<2 || (dotpos-atpos)<2){
			alert ("Please Enter Your Correct E-Mail Address");
			document.frmcustreg.emailaddr.focus();			
		}		
	}	
		
}
function instxtbox(){
	var val1=document.frmregbpm.pbid1.value;
	document.getElementById("pbid1").toString();
	//alert(val1);
	 //$("div").click(function () {
	     //  $(this).remove( );
	       $(this).insertAfter( '<div class="div"></div>'  )
	   // });
}
