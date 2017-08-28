package com.Drauworksdbinstall;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CustomerSignUp
 */
public class CustomerSignUp extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CustomerSignUp() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//System.out.println(request.getParameter("custname"));
		//CustsupGetSet crgs=new CustsupGetSet();
		//crgs.setcusregCustName(request.getParameter("custname"));
		/*crgs.setcuregmotorBikeNo(request.getParameter("motbikeno"));
		crgs.setcuregMotorbkeName(request.getParameter("motbikename"));
		crgs.setcuregMobileNo(request.getParameter("mobieno"));
		crgs.setcuregemailAddr(request.getParameter("emailaddr"));
		crgs.setcuregPassword(request.getParameter("custregpassword"));
		crgs.setcuregconfirmPassword(request.getParameter("custregconfirmpassword"));
		UserRegistratrion ur=new UserRegistratrion();		
		System.out.println(crgs.getcusregCustName());
		System.out.println(crgs.getcuregmotorBikeNo());
		System.out.println(crgs.getcuregMotorbkeName());
		System.out.println(crgs.getcuregMobileNo());
		System.out.println(crgs.getcuregemailAddr());
		System.out.println(crgs.getcuregPassword());
		System.out.println(crgs.getcuregconfirmPassword());*/
		//System.out.println(request.getParameter("custname"));
		//boolean flag=ur.userRegistration(crgs.getcusregCustName(),crgs.getcuregmotorBikeNo(),crgs.getcuregMotorbkeName(),crgs.getcuregMobileNo(),crgs.getcuregemailAddr(),crgs.getcuregPassword(),crgs.getcuregconfirmPassword());
		/*if(true){
			System.out.println("hello Success");
		}else{
			System.out.println("hello Error");
		}*/
		//System.out.println("hello Success");
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		System.out.println(request.getParameter("custname"));
		CustsupGetSet crgs=new CustsupGetSet();
		crgs.setcusregCustName(request.getParameter("custname"));
		crgs.setcuregmotorBikeNo(request.getParameter("motbikeno"));
		crgs.setcuregMotorbkeName(request.getParameter("motbikename"));
		crgs.setcuregMobileNo(request.getParameter("mobieno"));
		crgs.setcuregemailAddr(request.getParameter("emailaddr"));
		crgs.setcuregPassword(request.getParameter("custregpassword"));
		crgs.setcuregconfirmPassword(request.getParameter("custregconfirmpassword"));
		UserRegistratrion ur=new UserRegistratrion();		
		/*System.out.println(crgs.getcusregCustName());
		System.out.println(crgs.getcuregmotorBikeNo());
		System.out.println(crgs.getcuregMotorbkeName());
		System.out.println(crgs.getcuregMobileNo());
		System.out.println(crgs.getcuregemailAddr());
		System.out.println(crgs.getcuregPassword());
		System.out.println(crgs.getcuregconfirmPassword());
		System.out.println(request.getParameter("custname"));*/
		boolean flag=ur.userRegistration(crgs.getcusregCustName(),crgs.getcuregmotorBikeNo(),crgs.getcuregMotorbkeName(),crgs.getcuregMobileNo(),crgs.getcuregemailAddr(),crgs.getcuregPassword(),crgs.getcuregconfirmPassword());
		if(flag){
			System.out.println("hello Success");
			response.sendRedirect("success.jsp?status=" + "Congratulation!!! You Have Successfully Registered ...");
		}else{
			System.out.println("hello Error");
			response.sendRedirect("errorpage.jsp?status=" + "You are Altready Registered, GoBack and TryAgain With AnotherEmailAddress ...");
		}
		//System.out.println("hello Success");
		
	}

}
