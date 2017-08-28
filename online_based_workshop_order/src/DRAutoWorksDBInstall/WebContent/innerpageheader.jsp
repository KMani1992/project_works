<div id="welcomeheader">
	<div id="welcomeheaderleft"></div>
	<div id="welcomeheaderright">
	    <% out.print("Welcome : " + session.getAttribute("Username")+ "   ");%>
	    <a href="logout.jsp" title="Logout" id="logout" name="logout" class="logoutbtn">Logout</a>
	</div> 
</div>
