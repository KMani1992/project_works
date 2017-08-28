package com.Drauworksdbinstall;

public class ProfUpdDet {
	
	public int ProfUpdDetdata(String curMobikNo,String curEmail){
		CommonGetSet cgs =new CommonGetSet();
		CommonVariable cv=new CommonVariable();
		cv.resstatus=0;
		try{
			cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
			if(cv.connection!=null){
			cv.sqlqry="update CustSignUp set custname=?,motbikeno=?,motbikename=?,mobieno=? where emailaddr=? and motbikeno=?;";
			cv.ps=cv.connection.prepareStatement(cv.sqlqry);
			cv.ps.setString(1, cgs.getcusregCustName());
			cv.ps.setString(2, cgs.getcuregmotorBikeNo());
			cv.ps.setString(3, cgs.getcuregMotorbkeName());
			cv.ps.setString(4, cgs.getcuregMobileNo());
			cv.ps.setString(5, curEmail);
			cv.ps.setString(6, curMobikNo);
			cv.ps.executeUpdate();
			
			cv.sqlqry="select count(*),custname,motbikeno,motbikename,mobieno from custSignUp where emailaddr=?";
			cv.ps=cv.connection.prepareStatement(cv.sqlqry);
			cv.ps.setString(1, curEmail);
			
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
				cgs.setcuregMobileNo(cv.rs.getString(5));
			}
			
			}
			
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			ConnectionManager.getInstace().closeConnection();
		}
		return cv.resstatus;
	}

}
