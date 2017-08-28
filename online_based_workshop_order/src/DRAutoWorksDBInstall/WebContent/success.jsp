<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@include file="pageheader.jsp"%>
    <%
     final String status = request.getParameter("status");    
    %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" type="text/css" href="style/DBInstallMaster.css">
<script type="text/javascript" src="action.js"></script>

<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title> :: DRAUWorksDBinstall :: </title>
</head>
<body>
 <div id="wrapper">
     <div id="inner">
         <div id="head">
            <h3><%=status + "" %></h3>  
         </div>      
</div>
</div>
</body>
</html>
 <%@include file="pagefooter.jsp"%>