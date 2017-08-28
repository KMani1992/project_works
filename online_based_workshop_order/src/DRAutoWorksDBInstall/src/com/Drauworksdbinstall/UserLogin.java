package com.Drauworksdbinstall;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


/**
 * Servlet implementation class UserLogin
 */
public class UserLogin extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public UserLogin() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//System.out.println(request.getParameter("loguser"));
		try{
		String UsName=request.getParameter("loguser");
		String Pass=request.getParameter("logpass");
		System.out.println(UsName + Pass);
		CommonGetSet cgs =new CommonGetSet();
		CommonVariable cv=new CommonVariable();
		CommonMethods cm=new CommonMethods();
		cgs.setlogUserName(UsName);
		cgs.setlogPass(Pass);	
		System.out.println(cgs.getlogUserName() + cgs.getlogPass());
		CustLogin cl=new CustLogin();		
		int res=cl.userlogin(cgs.getlogUserName(),cgs.getlogPass());
		System.out.println(cgs.getUserName());
		System.out.println("hello inside try"+res);
		cv.ses=request.getSession(true);
		if (res>0){
			System.out.println("hello inside try fnb"+res);
			if (cv.ses.isNew()){
				cv.ses.setAttribute("Username", cgs.getUserName());
				cv.ses.setAttribute("MoBikeNo", cgs.getcuregmotorBikeNo());
				cv.ses.setAttribute("MoBikeName", cgs.getcuregMotorbkeName());	
				cv.ses.setAttribute("EmailAddr", cgs.getcuregemailAddr());
				cv.ses.setAttribute("MobieNo", cgs.getcuregMobileNo());
				System.out.println( cgs.getcuregMobileNo() + "txttst");
			}else{
				cv.ses.removeAttribute("Username");
				cv.ses.removeAttribute("MoBikeNo");
				cv.ses.removeAttribute("MoBikeName");
				cv.ses.removeAttribute("EmailAddr");
				cv.ses.removeAttribute("MobieNo");
				
				cv.ses.setAttribute("Username", cgs.getUserName());
				cv.ses.setAttribute("MoBikeNo", cgs.getcuregmotorBikeNo());
				cv.ses.setAttribute("MoBikeName", cgs.getcuregMotorbkeName());
				cv.ses.setAttribute("EmailAddr", cgs.getcuregemailAddr());
				cv.ses.setAttribute("MobieNo", cgs.getcuregMobileNo());
				System.out.println( cgs.getcuregMobileNo() + "txttstelse");
			}
			response.setContentType("text/html");
			response.setHeader("val", "Success");
			System.out.println(cgs.getUserName() + "fites");
			
				
		}else{
			if (cv.ses.getAttribute("Username")!=null){
				cv.ses.removeAttribute("Username");
				cv.ses.removeAttribute("MoBikeNo");
				cv.ses.removeAttribute("MoBikeName");
				cv.ses.removeAttribute("EmailAddr");
				cv.ses.removeAttribute("MobieNo");
				//System.out.println(cgs.getUserName() + "falses");
			}			
			response.setHeader("val", "Fail");
			response.setContentType("text/html");
			//response.sendRedirect("errorpage.jsp?status=" + "Login Failed, GoBack and TryAgain ...");
		}}catch(Exception e){
			e.printStackTrace();
			response.setHeader("val", "TechErr");
			response.setContentType("text/html");
		}
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		//System.out.println(request.getParameter("logpassword"));
	}

}
