package com.Drauworksdbinstall;
import java.io.IOException;
import java.sql.Connection;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletResponse;


public class DBManager extends HttpServlet {
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	public static Connection con=null;
	private static Statement st=null;
	private static ResultSet rs=null;
	private static String sqlqry;
	private static String dbname;
	private static String username;
	private static String password;
	private static  boolean flag=false;
	private static HttpServletResponse response = null;
	private static String drivername="com.mysql.jdbc.Driver";
	private static boolean resultflag =false;
	public static  boolean compcreate(DBInsGetSet gs,String dbnametmp,String usernametmp,String passwordtmp) throws IOException{
	dbname=dbnametmp;
	username=usernametmp;
	password=passwordtmp;
	System.out.println("Company Successfully Created dbm");
	System.out.println(dbname + password + username);
	
	try {				
		Class.forName("com.mysql.jdbc.Driver");
		con=ConnectionManager.getInstace().getConnnection("",username,password);
		System.out.println("Success on class.forname");
	} catch (ClassNotFoundException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
	
	
	try{
		System.out.println("Success on top st");
		st=con.createStatement();
		System.out.println("Success on st");
		sqlqry="show databases LIKE 'company';";
		rs=st.executeQuery(sqlqry);
		System.out.println(rs.getRow());
		
			if(rs.getRow()==0){
				setFlag(true);				
			}
			else{
				setFlag(false);
			}
		
		if(isFlag()){
		sqlqry="create database IF NOT EXISTS company";		
		st.executeUpdate(sqlqry);	
		}
		System.out.println("Success on cmp dbcr");
		ConnectionManager.getInstace().closeConnection();	
		con=ConnectionManager.getInstace().getConnnection(dbname,username,password);		
		sqlqry="show tables where Tables_in_company like 'company';";
		st=con.createStatement();
		rs=st.executeQuery(sqlqry);
		
			if(rs.getRow()==0){
				setFlag(true);				
			}
			else{
				setFlag(false);
			}
		
		System.out.println("new con ");
		st=con.createStatement();
		System.out.println("new con af");
		if(isFlag()){
			System.out.println("new con af int");
		sqlqry="";
	    sqlqry="create table IF NOT EXISTS company (companyid int not null auto_increment,";	
		sqlqry  =  sqlqry + "\r\n" + "companyname varchar(50),";			
		sqlqry  = sqlqry + "\r\n" + "companycode varchar(4),";
		sqlqry  = sqlqry + "\r\n" + "dbpath varchar(30),servername varchar(40),";
		sqlqry  = sqlqry + "\r\n" + "password varchar(20),";
		sqlqry  = sqlqry + "\r\n" + "periodfrom datetime,";
		sqlqry  = sqlqry + "\r\n" + "periodto datetime,";
		sqlqry  = sqlqry + "\r\n" + "created datetime,PRIMARY KEY(companyid));";
		System.out.println("new con af inb");
		st.executeUpdate(sqlqry);
		
		}
		System.out.println("new con qt");
		
		ConnectionManager.getInstace().closeConnection();	
		con=ConnectionManager.getInstace().getConnnection(dbname,username,password);		
		sqlqry="select * from company where companyname like '" + gs.getCompanyName() + "' and companycode='" + gs.getCompanyId() + "';";
		st=con.createStatement();
		rs=st.executeQuery(sqlqry);
		
			if(rs.getRow()==0){
				setFlag(true);				
			}
			else{
				setFlag(false);
				ConnectionManager.getInstace().closeConnection();
				response.sendRedirect("errorpage.jsp?status=" + "CompanyNameAlreadyExists Please Enter AnotherName");
			}
	if (isFlag()){
	String sqlqry="";
	sqlqry="insert into company (companyname,companycode,dbpath,";
	sqlqry=sqlqry + "servername,password,periodfrom,periodto,created) ";
	sqlqry=sqlqry + "values(?,?,?,?,?,?,?,?)";
	System.out.println("new con qb");
	//periodfrom,periodto,created
	System.out.println("new con qb ps as");
	if(con!=null){
	System.out.println("new con qb nt");
	final PreparedStatement ps =con.prepareStatement(sqlqry);
	System.out.println("new con qb nb");
	
	System.out.println("new con psb");
	ps.setString(1, gs.getCompanyName());	
	ps.setString(2, gs.getCompanyId());
	ps.setString(3, gs.getdbPath());
	ps.setString(4, gs.getServerName());
	ps.setString(5, gs.getServerPassword());
	System.out.println("new con psb1");
	java.sql.Date sdtf = new java.sql.Date(gs.getPeriodfrom().getTime());	
	ps.setDate(6, sdtf);
	System.out.println(sdtf);
	java.sql.Date sdtt = new java.sql.Date(gs.getPeriodeto().getTime());
	ps.setDate(7, sdtt);
	java.sql.Date sdtc = new java.sql.Date(gs.getDate().getTime());
	System.out.println(sdtt);
	System.out.println(sdtc);
	System.out.println("new con psb3");
	ps.setDate(8, sdtc);
	ps.executeUpdate();
	}
	else if(isFlag()==false){		
		try {			
			ConnectionManager.getInstace().closeConnection();
			response.sendRedirect("errorpage.jsp?status=" + "CompanyNameAlreadyExists Please Enter AnotherName");
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	setFlag(true);
	}
	}catch(SQLException e){
		e.printStackTrace();	
		setFlag(false);
	}finally{
		ConnectionManager.getInstace().closeConnection();
	}
	return  isFlag();
	}
	public static boolean setFlag(boolean flag) {
		DBManager.flag = flag;
		return flag;
	}
	public static boolean isFlag() {
		return flag;
	}
	public void dbInstall(){
		
	}
	public static boolean dbinstalation(String dbNAme,String password) throws SQLException {
		sqlqry="select companyid,companyname,companycode,dbpath,servername,password,periodto,created from company;";
		try {
			Class.forName(drivername);
			con=ConnectionManager.getInstace().getConnnection(dbNAme, "root", password);
			if (con!=null){
			st=con.createStatement();
			rs=st.executeQuery(sqlqry);
			resultflag=true;
			}
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			resultflag=false;
		}
		catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			resultflag=false;
		}		
		
		return resultflag;
	}
}
