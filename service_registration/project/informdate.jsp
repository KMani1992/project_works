
<%//@page language="java" import="java.net.*,java.io.*,java.net.URLEncoder;" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
<%@ page contentType="text/html; charset=utf-8" language="java" import="java.sql.*" errorPage="" pageEncoding="ISO-8859-1"%>
<%@ page import="java.io.*,java.util.Date" %>
<%@ page import="javax.servlet.*,java.text.*" %>
<%@ page import="java.util.*" %>
<%@ page import="javax.mail.*" %>
<%@ page import="javax.mail.internet.*" %>
<%@ page import="javax.activation.*" %>
<%@ page import="javax.net.ssl.*" %>
<%@ page import="java.net.*" %>
<%@ page import="java.net.URLEncoder;" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>

<body>



<%/*
String dname=null;
String ddate=null;
String dmonth=null;
String dyear=null;
String dphone=null;
String demail=null;
String message=null;
int datep=0,monthp=0,yearp=0;
int res,result=0,udd;
int i=0;
String vnum=request.getParameter("vnumber");
//String pass=request.getParameter("password");




Date df=new Date();
SimpleDateFormat ft=new SimpleDateFormat("d");
SimpleDateFormat ftm=new SimpleDateFormat("M");
SimpleDateFormat fty=new SimpleDateFormat("y");

String s= ft.format(df);
int a=Integer.parseInt(s);
String sm= ftm.format(df);
int am=Integer.parseInt(sm);
String sy= fty.format(df);
int ay=Integer.parseInt(sy);



try
{
	
	//out.println("inside try");
Class.forName("sun.jdbc.odbc.JdbcOdbcDriver");
String ss="jdbc:odbc:Driver={Microsoft Access Driver (*.mdb)};DBQ=C:\\Program Files\\Apache Software Foundation\\Tomcat 6.0\\webapps\\project\\Database.mdb";
Connection connection=DriverManager.getConnection(ss);
//Statement st=con.createStatement();
Statement statement = connection.createStatement();

ResultSet re=statement.executeQuery("select * from details");
while(re.next())
{
	dname=re.getString("fullname");
	dphone=re.getString("phone");
	demail=re.getString("email");
	ddate=re.getString("dd");
	dmonth=re.getString("mm");
 	dyear=re.getString("yy");
	

	if(ddate!=null&&dmonth!=null&&dyear!=null)
	
	{		
		
		
	//out.println("inside if");
		datep=Integer.parseInt(ddate);
		monthp=Integer.parseInt(dmonth);
		yearp=Integer.parseInt(dyear);
		
						
	
int udtem=datep;
udtem=udtem+30;
udd=udtem-30;		
			

if(a>=datep&&am==monthp&&ay==yearp)
{
	out.println("con 1");
	 res=a-datep;
	 result=30-res;
	
	message="Hello "+dname+" you have "+result+" days Remaining For Next Check Up.";
	out.println(message);
	
	i=1;
}
else if(a<=datep&&am>monthp&&ay==yearp)
{
	out.println("con 2");
	result=udd-a;
	message="Hello "+dname+" you have "+result+" days Remaining For Next Check Up.";
	out.println(message);
	i=2;
}

else if(a<=datep&&(monthp-am==11)&&ay>yearp)
{
	out.println("con 3");
	result=udd-a;
	
	message="Hello "+dname+" you have "+result+" days Remaining For Next Check Up.";
	out.println(message);
	
	//out.println("\n");
	
	i=3;
}
else if(a<=datep&&am<monthp&&ay>yearp)
{
	i=4;
out.println("con 4");	
message="Hello "+dname+" You Have Out of Date, Please Check Your Bike Status.";
out.println(message);
}
else if(a<=datep&&am>monthp&&ay>yearp)
{
	i=5;
out.println("con 5");	
message="Hello "+dname+" You Have Out of Date, Please Check Your Bike Status.";
out.println(message);
}

//email program

if(demail!=null)
{*/
out.println("inside mail");
String host = "smtp.gmail.com";
String to ="kmanikandangce@gmail.com";
String from="manikandancse2013@gmail.com";  // write your email address means from email address.
String subject = request.getParameter("subject");
String messageText = request.getParameter("body");
boolean sessionDebug = true;
// Create some properties and get the default Session.
//System.setProperty("smtp.protocols", "SSLv3");
Properties props = System.getProperties();
props.put("mail.smtp.starttls.enable","true");
props.setProperty("mail.transport.protocol","smtp");
props.setProperty("mail.host",host);
props.put("mail.smtp.auth", "true");
props.put("mail.smtp.port", "587");    //port is 587 for TLS  if you use SSL then port is 465
props.put("mail.smtp.debug", "true");
//props.put("mail.smtp.starttls.enable", "true")
props.put("mail.smtp.socketFactory.port", "465");
props.put("mail.smtp.socketFactory.fallback", "false");
props.put("mail.smtp.socketFactory.class", "javax.net.ssl.SSLSocketFactory");

Session mailSession = Session.getInstance(props, new javax.mail.Authenticator() {protected PasswordAuthentication getPasswordAuthentication() {return new PasswordAuthentication("manikandancse2013", "ayusha jenufa fathima");
}
});




 /*
 
 mailSession = Session.getDefaultInstance(emailProperties, null);
    emailMessage = new MimeMessage(mailSession);
 
 
 
 */
 
 
// Set debug on the Session
// Passing false will not echo debug info, and passing True will.
 
mailSession.setDebug(sessionDebug);
 
// Instantiate a new MimeMessage and fill it with the
// required information.
 
Message msg = new MimeMessage(mailSession);
msg.setFrom(new InternetAddress(from));
InternetAddress[] address = {new InternetAddress(to)};
msg.setRecipients(Message.RecipientType.TO, address);
msg.setSubject(subject);
msg.setSentDate(new Date());
msg.setText(messageText);
 
// Hand the message to the default transport service
// for delivery.
 try
 {
 Transport transport = mailSession.getTransport("smtp");
transport.connect(host,"manikandancse2013","ayusha jenufa fathima");
transport.sendMessage(msg,msg.getAllRecipients());
//transport.send(msg);
out.println("Mail was sent to "+to);
out.println(" from "+from);
out.println(" using host "+host+".");
 }
 catch(Exception e)
 {
	 out.println(e);
 }

}


//sms program
/*
if(dphone!=null)
{

String email="manikandancse2013@gmail.com"; 
String user="manigcesms";
String pass="gmailsms";
String number=dphone;
String msg=message+" from DuraiRaj Auto Works ph 9442906489"; 
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
    if (reader != null) try { reader.close(); } catch (IOException ignore) {out.println(ignore);}
}



}




			
				
	
	
	
	
	
	
	
		out.println(datep);
		out.println(monthp);
		out.println(yearp);
		
		
	}

}







out.println("success");

}
catch(Exception e)
{
	out.println(e);
}
*/
%>




</body>
</html>