package com.Drauworksdbinstall;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.google.gson.Gson;
import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.reflect.TypeToken;


/**
 * Servlet implementation class RegistrationStatus
 */
public class RegistrationStatus extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public RegistrationStatus() {
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
		//RegistrationStatusModule rsm =new RegistrationStatusModule();
		ArrayList<RegStatusGetSet> RegStatusGetSetlist =new ArrayList<RegStatusGetSet>();
		RegStatusGetSetlist= RegistrationStatusModule.RegistrationStatusModuleData(cgs.getcuregemailAddr(),cgs.getcuregmotorBikeNo());		
		Gson gson =new Gson();
	    JsonElement element=gson.toJsonTree(RegStatusGetSetlist,new TypeToken<List<RegStatusGetSet>>(){}.getType());
	    JsonArray jsonarry=element.getAsJsonArray();
	    response.setContentType("application/json");
	    response.getWriter().print(jsonarry);
	    //System.out.println(jsonarry);
		//response.setContentType("text/html");
		//response.setHeader("val", jsonarry.toString());
		}catch(Exception e){
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
