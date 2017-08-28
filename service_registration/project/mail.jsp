<HTML> 
<BODY> 
<FORM METHOD=POST ACTION="DemoSendMail.jsp"> 
Receiver name: <INPUT TYPE=TEXT NAME=username SIZE=20><BR> 
Receiver email address: <INPUT TYPE=TEXT NAME=email SIZE=20><BR> 
<P><INPUT TYPE=SUBMIT> 
</FORM> 
</BODY> 
</HTML>

DemoSendMail.jsp
<%@ taglib prefix="blx" uri="/blx.tld" %> 
<HTML> 
<BODY> 
<% 
  // Get username. 
  String email = request.getParameter( "email" ); 
%> 
<% if ( email == null || email.equals( "" )) { %> 
Please enter an email address again. 
<% } else { %> 
<blx:email host="smtp.gmail.com" from=" mohitparnami@yahoo.com">  
<blx:emailTo><%= email %></blx:emailTo>  
Thank you for registering with us.  You registered the 
following name: <%= request.getParameter( "username" ) %> 
You are registered<%= new java.util.Date() %> 

<!--  Also write out some HTML --> 
Thank you.  A confirmation email has been sent to <%= email %> 
<% } %> 
</BODY> 
</HTML> 