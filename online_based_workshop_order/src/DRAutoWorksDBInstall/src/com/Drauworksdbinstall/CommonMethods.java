package com.Drauworksdbinstall;
import javax.servlet.http.HttpServlet;
public class CommonMethods {
	CommonGetSet cgs =new CommonGetSet();
	CommonVariable cv=new CommonVariable();
	
	//Remove a Session attName
	public void removeSesAtt(String attName){		
		if (cv.ses.getAttribute(attName)!=null){
			cv.ses.removeAttribute(attName);			
		}
	}
	
	//Add a Session attName
	public void addSesAtt(String attName,String attVal){
		try{
			
		System.out.println(attName + " :: " + attVal);
		//if (cv.ses.getAttribute(attName)!=null){
		cv.ses.setAttribute("Username", "Mani");
		//}
		//cv.ses.setAttribute(attName, attVal);
		//System.out.println(attName + " : " + attVal);
		}catch(Exception e){
			System.out.println(e);
		}
	}

}
