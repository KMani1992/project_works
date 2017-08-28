
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<%@page language="java" import="java.net.*,java.io.*,java.net.URLEncoder;" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>

<html>
<head>
<title>index</title>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
</head>
<body>
<%
/* This api is only for developemnt purpose, if you missuse the api i will remove it so make sure you wont misuse it
author : Abhimanyu singh rathore
email : abhirathore2006@gmail.com
website: www.how2labs.info


info : make sure to use valid email otherwise it won't work,message char limit is 110

**/
String email="manikandancse2013@gmail.com"; 
String user="manigcesms";
String pass="gmailsms";
String number="9578781891";
String msg="hello manikandan" ; 
String mURL="http://www.onl9class.com/smsapi/smsir.php?email="+email+"&user="+user+"&pass="+pass+"&number="+number+"&msg="+URLEncoder.encode(msg, "UTF-8");;
URL url = new URL(mURL);
BufferedReader reader = null;

try {
    reader = new BufferedReader(new InputStreamReader(url.openStream(), "UTF-8"));

  
        out.println("message sent"+number);
    
} 
catch(Exception e)
{
out.println(e);
}



finally
 {
    if (reader != null) try { reader.close(); } catch (IOException ignore) {}
}
 %>
</body>
</html>


