package com.Drauworksdbinstall;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class servletbookregistration
 */
public class servletbookregistration extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public servletbookregistration() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		try{
		bookregistration bkr = new bookregistration();	
		CommonGetSet cgs =new CommonGetSet();
		String Pbid;
		int bookingid;
		Pbid=request.getParameter("pbid").trim();
		/*if (Pbid.startsWith(",")){
			Pbid=Pbid.substring(1,Pbid.length());			
		}*/
		if (Pbid.endsWith(",")){
			Pbid=Pbid.substring(1,Pbid.length()-1);			
		}
		System.out.println(Pbid);
		cgs.setBookProblemId(Pbid);
		cgs.setcuregmotorBikeNo(request.getParameter("mobikno"));
		cgs.setcuregemailAddr(request.getParameter("email"));
		System.out.println(Pbid + ":" + request.getParameter("mobikno") + ":" + request.getParameter("email"));
		bookingid=bkr.bookregistrationdet();
		System.out.println(Pbid + ":" + request.getParameter("mobikno") + ":" + request.getParameter("email"));
		if (bookingid!=0){
			response.setContentType("text/html");
			response.setHeader("val", "Success");
			response.setIntHeader("regid", bookingid);
		}else{
			response.setContentType("text/html");
			response.setHeader("val", "Fail");				
		}
		
		}catch(Exception e){
			System.out.println(e);
			response.setContentType("text/html");
			response.setHeader("val", "TechErr");
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
	}

}
