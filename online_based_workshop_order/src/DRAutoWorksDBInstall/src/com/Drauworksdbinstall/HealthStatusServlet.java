package com.Drauworksdbinstall;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.data.JRBeanCollectionDataSource;


/**
 * Servlt implementation class HealthStatusServlet
 */
public class HealthStatusServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public HealthStatusServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {		
		// TODO Auto-generated method stub
		try{
			System.out.println(request.getParameter("mobikno") + "abcdef");
			System.out.println(request.getParameter("email") + "abcdef");
			CommonGetSet cgs=new CommonGetSet();
			cgs.setcuregmotorBikeNo(request.getParameter("mobikno"));
			cgs.setcuregemailAddr(request.getParameter("email"));
			
			
			String sourceFileName ="reports/rep_veh_health_status.jasper";

				vehHelthStatus vhs = new vehHelthStatus();
			      ArrayList<vehhelthDatabeen> dataList = vhs.getVehHelthStatus();

			      JRBeanCollectionDataSource beanColDataSource =
			      new JRBeanCollectionDataSource(dataList);
			      Map parameters = new HashMap();
			      JasperFillManager.fillReportToFile(sourceFileName, parameters, beanColDataSource);			      
			     // JasperFillManager.
			      
			      response.setContentType("text/html");
				  response.setHeader("val", "Success");
			
		}catch(JRException e){
			e.printStackTrace();
			response.setContentType("text/html");
			response.setHeader("val", "TechErr");
		}catch(Exception e){
			e.printStackTrace();
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
