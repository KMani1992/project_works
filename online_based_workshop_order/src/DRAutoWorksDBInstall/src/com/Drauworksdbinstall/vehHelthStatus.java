package com.Drauworksdbinstall;

import java.util.ArrayList;

public class vehHelthStatus {
	
	CommonGetSet cgs=new CommonGetSet();	
	private static CommonVariable cv=new CommonVariable();	
	public ArrayList<vehhelthDatabeen> getVehHelthStatus(){		
		cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
		ArrayList<vehhelthDatabeen> vehhelthDatabeen = null;
	try{	
			cv.sqlqry="select battery,engine,suspension,breaks,exterior,tyres,electrical,seats,overal from CustRegStatus crs";
			cv.sqlqry += " where crs.emailaddr='" + cgs.getcuregemailAddr() + "'  and crs.motorbikeno='" + cgs.getcuregmotorBikeNo() + "'";
			System.out.println(cgs.getcuregmotorBikeNo() +"::::::" + cgs.getcuregemailAddr());
			
			cv.st=cv.connection.createStatement();
			cv.rs=cv.st.executeQuery(cv.sqlqry);
			
			while(cv.rs.next()){
				vehhelthDatabeen=new ArrayList<vehhelthDatabeen>();
				vehhelthDatabeen.add(produce("battery", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("engine", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("suspension", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("breaks", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("exterior", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("tyres", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("electrical", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("seats", cv.rs.getInt(1)));
				vehhelthDatabeen.add(produce("overal", cv.rs.getInt(1)));				
			}
		
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			ConnectionManager.getInstace().closeConnection();			
		}
		
		return vehhelthDatabeen; 
	}
	private vehhelthDatabeen produce(String partName, Integer partValue) {
		vehhelthDatabeen dataBean = new vehhelthDatabeen();

	      dataBean.setPartName(partName);
	      dataBean.setPartValue(partValue);

	      return dataBean;
	   }

}
