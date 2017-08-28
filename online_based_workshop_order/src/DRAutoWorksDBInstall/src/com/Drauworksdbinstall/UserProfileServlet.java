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
 * Servlet implementation class UserProfileServlet
 */

public class UserProfileServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public UserProfileServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
    
   
    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
    	System.out.println("inside get");
		//String action = request.getParameter("action");
		
		//if (action.equals("list")){
			System.out.println("inside list action");
			try{
				System.out.println("inside list try action");
				List<userprofileGetSet>  listcust=new ArrayList<userprofileGetSet>();
				listcust=UserProfile.geyAllUsers();
				Gson json =new Gson();
				JsonElement element=json.toJsonTree(listcust, new TypeToken<List<userprofileGetSet>>(){}.getType());				
				JsonArray jsonary =element.getAsJsonArray();
				String listData=jsonary.toString();
				listData="{\"Result\":OK\",\"Records\":" + listData + "}";
				response.setContentType("application/json");
				response.getWriter().print(jsonary);
				//System.out.println(listData);
			}catch(Exception e){
				String error="{\"Result\":\"ERROR\",\"Message\":" + e.getStackTrace() + "}";
				response.getWriter().print(error);				
			}
			
		//}	
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		
	}

}
