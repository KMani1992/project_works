package com.Drauworksdbinstall;

import java.sql.SQLException;


public class CustLogin  {
	private static CommonVariable cv=new CommonVariable();	
	CommonGetSet cgs=new CommonGetSet();
	public int userlogin(String usName,String Pass){
		
		cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
		System.out.println("hello inside fun");
		if(cv.connection!=null){
			System.out.println("hello inside");
			try {
				System.out.println("hello inside try" + usName + Pass );
				//cv.st=cv.connection.createStatement();
				
				cv.sqlqry="select count(*),custname,motbikeno,motbikename,emailaddr,mobieno from custSignUp where emailaddr=? and cregpwd=?";
				cv.ps=cv.connection.prepareStatement(cv.sqlqry);
				cv.ps.setString(1, usName);
				cv.ps.setString(2, Pass);
				cv.rs=cv.ps.executeQuery();				
				while (cv.rs.next()){					
					cv.resstatus=cv.rs.getInt(1);
					cgs.setUserName(cv.rs.getString(2));
					//System.out.println("hello inside try exis");
					//System.out.println(cv.rs.getString(2));	
					//System.out.println(cv.rs.getString(3));
					//System.out.println(cv.rs.getString(4));
					cgs.setcuregmotorBikeNo(cv.rs.getString(3));
					cgs.setcuregMotorbkeName(cv.rs.getString(4));
					cgs.setcuregemailAddr(cv.rs.getString(5));
					cgs.setcuregMobileNo(cv.rs.getString(6));
				}
				
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				cv.resstatus=0;
				e.printStackTrace();
			}finally{
				ConnectionManager.getInstace().closeConnection();				
			}
			
		}
		return cv.resstatus;
	}
	

}
