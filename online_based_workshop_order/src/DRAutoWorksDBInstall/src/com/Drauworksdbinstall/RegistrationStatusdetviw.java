package com.Drauworksdbinstall;

import java.util.ArrayList;

public class RegistrationStatusdetviw {
	CommonGetSet cgs=new CommonGetSet();	
	private static CommonVariable cv=new CommonVariable();
	public static ArrayList<RegStatusDetviwGetSet> RegistrationStatusdetviwdata(String email,String mobikno,String majid){
		ArrayList<RegStatusDetviwGetSet> RegistrationStatusdetviwlist=new ArrayList<RegStatusDetviwGetSet>();
		try{
			cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
			if (cv.connection !=null){
				cv.sqlqry="";
				cv.sqlqry = "select cr.orderdetail,cr.pbfinunfinflag,cr.pbstatus from "; 
				cv.sqlqry += " CustRegistrationSumry crs left join CustRegistration cr on "; 
				cv.sqlqry += " crs.emailaddr=cr.emailaddr and crs.ordermajorid=cr.ordermajorid ";
				cv.sqlqry += " where crs.emailaddr='" + email + "' and crs.ordermajorid=" + majid + " and crs.motorbikeno='" + mobikno + "'";
				cv.sqlqry += " order by cr.ordersubid";
				//System.out.println(cv.sqlqry);
				cv.st=cv.connection.createStatement();
				cv.rs=cv.st.executeQuery(cv.sqlqry);
				while(cv.rs.next()){
					RegStatusDetviwGetSet rsgs=new RegStatusDetviwGetSet();
					rsgs.setPbid(cv.rs.getString(1));
					rsgs.setPbfinunfin(cv.rs.getString(2));
					rsgs.setPbidrem(cv.rs.getString(3));					
					RegistrationStatusdetviwlist.add(rsgs);
				}
			}
			
		}catch(Exception e){
			e.printStackTrace();
		}
		return RegistrationStatusdetviwlist;
		
	}

}
