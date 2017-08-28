<!-- Top Navigation -->



<%@page import="java.text.SimpleDateFormat"%>
<%@page import="java.text.DateFormat"%>
<%@page import="java.util.Date"%>
<div id="welcomeheader">
			    <div id="welcomeheaderleft">
			    	<a href="welcome.jsp" title=""><img src="images/draw_inrpg_logo.png" id="wel_logo" alt="DuraiRajAutoWorks_Logo"></a>
			    	
			    </div>
			    <div id="welcomeheaderright">
			    <%Date d=new Date();
			    DateFormat ft =new SimpleDateFormat("dd.MMM.yy");%>
			        <small> <%  out.print(ft.format(d) + " | " + session.getAttribute("Username").toString().toUpperCase()  + "   ");%> | </small>
			        <a href="logout.jsp" title="Logout" id="logout" name="logout" class="logoutbtn"><small>Logout</small></a>
			    </div> 
			</div>