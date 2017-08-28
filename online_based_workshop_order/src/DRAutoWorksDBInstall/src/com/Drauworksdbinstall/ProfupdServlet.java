package com.Drauworksdbinstall;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class ProfupdServlet
 */
public class ProfupdServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ProfupdServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		if(request.getParameter("proc").equals("updprofdet")){
			String mobikno=request.getParameter("mobiknop");
			String email=request.getParameter("email");			
			try{
				CommonGetSet cgs =new CommonGetSet();
				CommonVariable cv=new CommonVariable();
				CommonMethods cm=new CommonMethods();
				
				System.out.println(request.getParameter("ucustname") + ":tests" + request.getParameter("umobikno") + "::" + request.getParameter("umobikname") + "::" + request.getParameter("umobno"));
				
				
				cgs.setcusregCustName(request.getParameter("ucustname"));
				cgs.setcuregmotorBikeNo(request.getParameter("umobikno"));
				cgs.setcuregMotorbkeName(request.getParameter("umobikname"));
				cgs.setcuregMobileNo(request.getParameter("umobno"));
				
				//System.out.println(request.getParameter("ucustname") + ":tests" + request.getParameter("umobikno") + ":s" + request.getParameter("umobikname") + "::" + request.getParameter("umobno") );
				
				
				//System.out.println(cgs.getlogUserName() + cgs.getlogPass());
				ProfUpdDet pu=new ProfUpdDet();		
				int res=pu.ProfUpdDetdata(mobikno,email);
				//System.out.println(cgs.getUserName());
				//System.out.println("hello inside try"+res);
				cv.ses=request.getSession(true);
				if (res>0){
					System.out.println("hello inside try fnb"+res);
					if (cv.ses.isNew()){
						cv.ses.setAttribute("Username", cgs.getUserName());
						cv.ses.setAttribute("MoBikeNo", cgs.getcuregmotorBikeNo());
						cv.ses.setAttribute("MoBikeName", cgs.getcuregMotorbkeName());							
						cv.ses.setAttribute("MobieNo", cgs.getcuregMobileNo());
						System.out.println( cgs.getcuregMobileNo() + "txttst");
					}else{
						cv.ses.removeAttribute("Username");
						cv.ses.removeAttribute("MoBikeNo");
						cv.ses.removeAttribute("MoBikeName");						
						cv.ses.removeAttribute("MobieNo");
						
						cv.ses.setAttribute("Username", cgs.getUserName());
						cv.ses.setAttribute("MoBikeNo", cgs.getcuregmotorBikeNo());
						cv.ses.setAttribute("MoBikeName", cgs.getcuregMotorbkeName());						
						cv.ses.setAttribute("MobieNo", cgs.getcuregMobileNo());
						System.out.println( cgs.getcuregMobileNo() + "txttstelse");
					}
					response.setContentType("text/html");
					response.setHeader("val", "Success");
				}else{
					if (cv.ses.getAttribute("Username")!=null){
						//cv.ses.removeAttribute("Username");
						//cv.ses.removeAttribute("MoBikeNo");
						//cv.ses.removeAttribute("MoBikeName");
						//cv.ses.removeAttribute("EmailAddr");
						//cv.ses.removeAttribute("MobieNo");
						//System.out.println(cgs.getUserName() + "falses");
					}			
					response.setHeader("val", "Fail");
					response.setContentType("text/html");
					//response.sendRedirect("errorpage.jsp?status=" + "Login Failed, GoBack and TryAgain ...");
				}
			}catch(Exception e){
				response.setContentType("text/html");
				response.setHeader("val", "TechErr");				
			}
		}//Prof Updation End
		else if(request.getParameter("proc").equals("updprofpwdchg")){
			String mobikno=request.getParameter("mobiknop");
			String email=request.getParameter("email");			
			try{
				CommonGetSet cgs =new CommonGetSet();
				CommonVariable cv=new CommonVariable();
				
				
				System.out.println(request.getParameter("mobiknop") + ":tests" + request.getParameter("email") + "::" + request.getParameter("updolpw") + "::" + request.getParameter("updcurpw") + "::" + request.getParameter("cnfrmpwd"));
				
				
				cgs.setcusPuOldPwd(request.getParameter("updolpw"));
				cgs.setcuregPassword(request.getParameter("updcurpw"));
				cgs.setcuregconfirmPassword(request.getParameter("cnfrmpwd"));
				
				
				//System.out.println(request.getParameter("ucustname") + ":tests" + request.getParameter("umobikno") + ":s" + request.getParameter("umobikname") + "::" + request.getParameter("umobno") );
				
				
				//System.out.println(cgs.getlogUserName() + cgs.getlogPass());
				ProfPwdChg pw=new ProfPwdChg();		
				int res=pw.ProfPwdChgDet(email, mobikno);
				//System.out.println(cgs.getUserName());
				System.out.println("hello inside try Ed::::::::::::::"+res);
				cv.ses=request.getSession(true);
				if (res>0){
					response.setContentType("text/html");
					response.setHeader("val", "Success");
				}else if(res<0){
					response.setContentType("text/html");
					response.setHeader("val", "PWFail");
				}else if(res==0){
					response.setContentType("text/html");
					response.setHeader("val", "Fail");
				}
					
			}catch(Exception e){
				e.printStackTrace();
				response.setContentType("text/html");
				response.setHeader("val", "TechErr");				
			}
		}
	}
	

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
