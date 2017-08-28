package com.Drauworksdbinstall;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


/**
 * Servlet implementation class DBInsServlet
 */
public class DBInsServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public DBInsServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
		 
		String companyname=request.getParameter("companyname");
		String Companyid=request.getParameter("companyid");
		String Servername=request.getParameter("servername");
		String sqlPassword=request.getParameter("serverpassword");
		String dbpath=request.getParameter("dbpath");
		String periodfrom = request.getParameter("periodfrom");
		String periodto =request.getParameter("periodto");
		
		DBInsGetSet gs=new DBInsGetSet();
		gs.setCompanyId(Companyid);
		gs.setCompanyName(companyname);
		gs.setServerName(Servername);
		gs.setServerPassword(sqlPassword);
		gs.setdbPath(dbpath);
		//DBManager cc=new DBManager();
		SimpleDateFormat dft = new SimpleDateFormat("yyyy-MM-dd");
		Date periodefrom;
		try {
			periodefrom = dft.parse(periodfrom);
			Date periodeto=dft.parse(periodto);
			gs.setPeriodfrom(periodefrom);
			System.out.println(periodefrom);
			gs.setPeriodeto(periodeto);
			System.out.println(periodeto);
		} catch (ParseException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		
		
		System.out.println("Company Successfully Created top");
		try{
		DBManager.compcreate(gs, "company", "root", gs.getServerPassword());
		}catch(Exception e){
			e.printStackTrace();
		}
		System.out.println("Company Successfully Created bot");
		String pathname="c:\\" + gs.getCompanyName() + ".ini";
		
		try{
			
			File file=new File(pathname);
			file.createNewFile();			
			FileWriter os=new FileWriter(file);
			os.write(gs.getCompanyName());			
			os.write("\r\n");
			os.write(gs.getCompanyId());
			os.write("\r\n");
			os.write(gs.getdbPath());
			os.write("\r\n");		
			os.write(gs.getServerName());
			os.write("\r\n");
			os.write(gs.getServerPassword());
			os.write("\r\n");
			os.flush();
			os.close();	
			System.out.println("Company Successfully Created");
			final String message= "Company Creation Successfully Completed";
			response.sendRedirect("success.jsp?status=" + message);
			
		}catch(Exception e){
				e.printStackTrace();
			}
	}
			
	

}
