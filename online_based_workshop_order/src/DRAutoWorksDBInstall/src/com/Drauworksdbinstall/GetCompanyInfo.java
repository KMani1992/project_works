package com.Drauworksdbinstall;

import java.sql.SQLException;
import java.util.HashMap;



public class GetCompanyInfo extends CommonVariable {
	public GetCompanyInfo cv=new GetCompanyInfo();
	HashMap<String, String> hmcmpinfo= new HashMap<String, String>();	
	
	public HashMap<String, String> companyname(String dbnametmp, String Usernametmp, String Passwordtmp){
		cv.flagresult=false;		
		if (cv.connection!=null){		
			ConnectionManager.getInstace().closeConnection();			
		}
		if (cv.connection==null){
		cv.connection=ConnectionManager.getInstace().getConnnection(dbnametmp, Usernametmp, Passwordtmp);
		cv.flagresult =true;
		}
		if(cv.flagresult){
			try {
				cv.sqlqry="";
				cv.sqlqry="select companyid,companyname,companycode,dbpath,servername,password,periodto,created from company;";
				cv.stmt=cv.connection.createStatement();				
				cv.resset=cv.stmt.executeQuery(cv.sqlqry);
				while(cv.resset.next()){
					hmcmpinfo.put(cv.resset.getString(1),cv.resset.getString(2));	
				}
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}finally{
				if(cv.connection!=null){
					
					ConnectionManager.getInstace().closeConnection();	
				}
				
			}
			
		}
		return hmcmpinfo;
	}
	}
