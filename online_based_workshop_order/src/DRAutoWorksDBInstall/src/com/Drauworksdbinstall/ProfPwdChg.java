package com.Drauworksdbinstall;

public class ProfPwdChg {
	
	public int ProfPwdChgDet(String curemail,String curmobikno){
		
		CommonGetSet cgs =new CommonGetSet();
		CommonVariable cv=new CommonVariable();
		cv.resstatus=0;		
		cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
		try{
			if(cv.connection!=null){
				cv.flagresult=false;
				cv.sqlqry="select count(*) from custSignUp where emailaddr=? and cregpwd=?";
				cv.ps=cv.connection.prepareStatement(cv.sqlqry);
				cv.ps.setString(1, curemail);
				cv.ps.setString(2, cgs.getcusPuOldPwd());
				
				cv.rs=cv.ps.executeQuery();				
				while (cv.rs.next()){					
					cv.resstatus=cv.rs.getInt(1);					
				}
				if(cv.resstatus!=0){
					cv.sqlqry="update CustSignUp set cregpwd=?,cregcpwd=? where emailaddr=? and motbikeno=?;";
					cv.ps=cv.connection.prepareStatement(cv.sqlqry);
					cv.ps.setString(1, cgs.getcuregPassword());
					cv.ps.setString(2, cgs.getcuregconfirmPassword());
					cv.ps.setString(3, curemail);
					cv.ps.setString(4, curmobikno);
					cv.ps.executeUpdate();
					cv.flagresult=true;					
				}
				if (cv.flagresult!=true){
					cv.resstatus=-1;
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
