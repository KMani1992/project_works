package com.Drauworksdbinstall;

import java.util.ArrayList;



public class RegistrationStatusModule {
	int resval=0;
	CommonGetSet cgs=new CommonGetSet();	
	private static CommonVariable cv=new CommonVariable();
	private static String orddeliverydate="NA";
	
	public static ArrayList<RegStatusGetSet> RegistrationStatusModuleData(String email,String Mobikno){
		ArrayList<RegStatusGetSet> RegStatusGetSetlist=new ArrayList<RegStatusGetSet>();
		
		try{
			cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
			if (cv.connection !=null){
				cv.sqlqry="";
				cv.sqlqry="select crs.ordersubject,crs.orddetsmry,crs.OrderMajorId,";
				cv.sqlqry += "crs.updated,crs.orddeliverydate,";
				cv.sqlqry += "count(case pbfinunfinflag when 'Y' then pbfinunfinflag end) as `Finished`,"; 
				cv.sqlqry += "count(case pbfinunfinflag when 'N' then pbfinunfinflag end) as `UnFinished`";
				cv.sqlqry += " from CustRegistrationSumry as  crs ";
				cv.sqlqry += " left join CustRegistration cr on crs.emailaddr=cr.emailaddr and  crs.OrderMajorId=cr.OrderMajorId ";
				cv.sqlqry += " left join custSignUp as cs ";
				cv.sqlqry += " on cr.emailaddr=cs.emailaddr";
				cv.sqlqry += " where cs.emailaddr='" + email + "' and cs.motbikeno='" + Mobikno + "'";
				cv.sqlqry += " group by crs.OrderMajorId ";
				cv.sqlqry += " order by crs.OrderMajorId desc;";
				//System.out.println(cv.sqlqry);
				cv.st=cv.connection.createStatement();
				cv.rs=cv.st.executeQuery(cv.sqlqry);
				while(cv.rs.next()){
					RegStatusGetSet rsgs=new RegStatusGetSet();
					rsgs.setRSordersubject(cv.rs.getString(1));
					rsgs.setRSorddetsmry(cv.rs.getString(2));
					rsgs.setRSOrderMajorId(cv.rs.getString(3));
					rsgs.setRSupdated(cv.rs.getString(4).substring(0, cv.rs.getString(4).indexOf(" ")));
					//System.out.println(cv.rs.getString(4).substring(0, cv.rs.getString(4).indexOf(" ")));
					//System.out.println(cv.rs.getString(5) + "tstout");					
					if(cv.rs.getString(5)!=null){	
						//System.out.println(cv.rs.getString(5) + "test");
							orddeliverydate=cv.rs.getString(5);
						}
					rsgs.setRSorddeliverydate(orddeliverydate);
					rsgs.setRSFinished(cv.rs.getString(6));					
					rsgs.setRSUnFinished(cv.rs.getString(7));
					RegStatusGetSetlist.add(rsgs);
				}
			}
		}catch(Exception e){
			e.printStackTrace();
			
		}
		
	return RegStatusGetSetlist;	
	}

}
