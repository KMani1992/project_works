package com.Drauworksdbinstall;

import java.sql.*;

public class ConnectionManager {
private static ConnectionManager instance=null;
private String Username;
private String Password;
private String Con_url="jdbc:mysql://localhost:3306/";
public  Connection con=null;
private  String dbname; 
private ConnectionManager(){
	
}
public static ConnectionManager getInstace(){
	if(instance==null){
		instance=new ConnectionManager();
	}
	return instance;
}
public  Connection getConnnection(String dbnametmp,String Usernametmp,String Passwordtmp){
	dbname=dbnametmp;
	Username=Usernametmp;
	Password=Passwordtmp;
	System.out.println(Username+Password+dbname);
	if(con==null){		
		if(openConnection()){
			System.out.println("Connection Opened");
			return con;
		}else{
			return null;
		}	
	}
	return con;
}
public boolean openConnection(){
	try{
	con=DriverManager.getConnection(Con_url+dbname, Username,Password);
	}catch(Exception e){
			e.printStackTrace();
		}
	
	return true;
}
public void closeConnection(){
	try {
		if(con!=null){
			con.close();
			System.out.println("Connection Closed");	
		}		
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
	con=null;
  }
}
