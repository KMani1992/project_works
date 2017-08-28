<%@page import="java.util.*"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@include file="pageheader.jsp"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="shortcut icon" href="favicon.ico">
<link rel="stylesheet" type="text/css" href="style/DBInstallMaster.css">
<script type="text/javascript" src="ajaxaction.js"></script>

<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title> :: DRAUWorksDBinstall :: </title>
</head>
<body onload="getCompany();">
 <div id="wrapper">
     <div id="inner">
         <div id="head">
            <h3>Welcometo :: DBIstallation</h3>  
         </div>      
<form  name="frmdbinstall">
<table id="tabdbins">
<tr>
<td>Select a CompanyName:</td><td><select id="cmbcompselectcbo" name="cmbcompselectcbo" autofocus required>
<option value="test">Test</option>
<%HashMap cmphm=(HashMap)session.getAttribute("cboCompaynames"); 
//Set se=new cmphm.entryset();
//Set set=cmphm.entrySet();
//Iterator i=set.iterator();
//String key=null;
//String val=null;
//for((Iterator i = cmphm.entrySet().iterator; i.hasNext(); ){
//Map.Entry me=(Map.Entry)i.next();
//key=(String)me.getKey();
//val=(String)me.getValue();
//out.println();
//me.getValue();
%>
<option value="<%//=me.getKey()%>"><%//=me.getKey() %></option>
<%// }%>
</select></td>
</tr>
<tr><td><input type="text" name="cmbcompselect" id="cmbcompselect"></td><td><div id="restext">...</div></td></tr>
<tr><td></td><td><input type="button" value="InstallDataBase" onclick="dbinstall();"></td></tr>
</table>
</form>
</div>
</div>
<div id="loadingscreen">
<div>
<img src="images/loading.gif" id="loadimage" align="middle">
</div>
<div>
<h3 id="waitingmsg">Loading Please Wait .... </h3>
</div>
</div>
</body>
</html>
 <%@include file="pagefooter.jsp"%>