<%@ page contentType="text/html; charset=iso-8859-1" language="java" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<title>Email send Example for project </title>
</head>
<body>
<%@ page import="java.io.*" %>
 
<%@ page import="java.net.InetAddress" %>
 
<%@ page import="java.util.Properties" %>
 
<%@ page import="java.util.Date" %>
 
<%@ page import="javax.mail.*" %>
 
<%@ page import="javax.mail.internet.*" %>
 
<%@ page import="javax.activation.*" %>
<%
public class SMTPSend {
 
public SMTPSend() {
 
}
 

 
public void msgsend() {
 
String username = "9578781891";
 
String password = "gmailsms";
 
String smtphost = "way2sms.com";
 
String compression = "hai";
 
String from = "9578781891@site4.way2sms.com";
 
String to = "9578781891";
 
String body = "Hai...!";
 
Transport myTransport = null;
try {
 
Properties props = System.getProperties();
 
props.put("mail.smtp.auth", "true");
 
Session mailSession = Session.getDefaultInstance(props, null);
 
Message msg = new MimeMessage(mailSession);
 
msg.setFrom(new InternetAddress(from));
 
InternetAddress[] address = {new InternetAddress(to)};
 
msg.setRecipients(Message.RecipientType.TO, address);
 
msg.setSubject(compression);
 
msg.setText(body);
 
msg.setSentDate(new Date());
myTransport = mailSession.getTransport("smtp");
 
myTransport.connect(smtphost, username, password);
 
msg.saveChanges();
 
myTransport.sendMessage(msg, msg.getAllRecipients());

myTransport.close();
out.print("success"+to); 

 
} catch (Exception e) {
 
e.printStackTrace();
 
}

}
%>
</table>
</body>
</html>