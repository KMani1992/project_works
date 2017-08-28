package com.Drauworksdbinstall;


import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

public class UserProfile {
   // userprofileGetSet gs=new userprofileGetSet(userName, mobileNo, motorbikeName, motorbikeNo, emailAddr)
	
	public static List<userprofileGetSet> geyAllUsers() {
		List<userprofileGetSet> listUser=new ArrayList<userprofileGetSet>();
		CommonVariable cv=new CommonVariable();
		try {
		cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);
		if(cv.connection!=null){
			cv.sqlqry="select custname,motbikeno,motbikename,mobieno,emailaddr from custSignUp;";			
				cv.st=cv.connection.createStatement();
				cv.rs=cv.st.executeQuery(cv.sqlqry);
				while(cv.rs.next()){
					listUser.add(new userprofileGetSet(cv.rs.getString(1) , cv.rs.getString(2), cv.rs.getString(3), cv.rs.getString(4), cv.rs.getString(5)));
				}
		}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return listUser;
	}
	
}
