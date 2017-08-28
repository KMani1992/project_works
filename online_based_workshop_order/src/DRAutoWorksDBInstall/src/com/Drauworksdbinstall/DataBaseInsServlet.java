package com.Drauworksdbinstall;

import java.io.DataInputStream;
import java.io.File;
import java.io.FileInputStream;

import java.io.IOException;


import java.util.ArrayList;
import java.util.HashMap;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;


/**
 * Servlet implementation class DataBaseInsServlet
 */
public class DataBaseInsServlet extends HttpServlet implements Runnable {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public DataBaseInsServlet() {
        super();
        // TODO Auto-generated constructor stub
    }
    CommonVariable cv =new CommonVariable();
	DBInsGetSet gs=new DBInsGetSet();
	HashMap<String, String> hmv=new HashMap<String, String>();
	ArrayList<String> cmpal=new ArrayList<String>();
	
	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		String info=null;
		info=request.getParameter("loadcmpName");
		/*String compName=request.getParameter("cmpName");	
		
		System.out.println(compName);
		try {
			
			Thread.sleep(2000);			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		finally{
		response.setContentType("text/xml");
		response.setHeader("Cache-Control", "no-Cache");
		response.getWriter().write("true");
		}*/
		
		if (info!=null){
			int ct=0;
			//cv.CompFileName="c:\\DuraiRajAutoWorks.ini";
			File f=new File("c:\\DuraiRajAutoWorks.ini");
			DataInputStream dis =new DataInputStream(new FileInputStream(f));
			String data=null;
			while((data=dis.readLine())!=null){
				ct=ct+1;
				switch (ct){
				case 1:
					gs.setCompanyName(data);
					//continue;
				case 2:
					gs.setCompanyId(data);
					//continue;
				case 5:
					gs.setServerPassword(data);	
					System.out.println(data);
				}
				
			}
			GetCompanyInfo gcf =new GetCompanyInfo();
			hmv=gcf.companyname(gs.getCompanyId(), "root", gs.getServerPassword());
			HttpSession hs=request.getSession(true);
			if(hs.isNew()){
			hs.setAttribute("cboCompaynames", hmv);
			}else{
				hs.removeAttribute("cboCompaynames");
			}
			response.setContentType("text/html");
			response.sendRedirect("dbinstall.jsp");
			
		}
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void run() {
		// TODO Auto-generated method stub
		
	}

}
