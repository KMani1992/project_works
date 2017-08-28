package com.Drauworksdbinstall;

import java.sql.SQLException;

import javax.servlet.http.HttpServlet;
public class UserRegistratrion extends HttpServlet {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private static String custname1=null;
	private static String motbikeno1=null;
	private static String motbikename1=null;
	private static String mobieno1=null;
	private static String emailaddr1=null;
	private static String cregpwd=null;
	private static String  cregcpwd=null;	
	private static CommonVariable cr =new CommonVariable();
	public  boolean userRegistration(String custname,String motbikeno,String motbikename,String mobieno,String emailaddr,String custregpassword,String custregconfirmpassword){		
		custname1=custname;
		mobieno1=mobieno;
		motbikename1=motbikename;
		motbikeno1=motbikeno;
		emailaddr1=emailaddr;
		cregpwd=custregpassword;
		cregcpwd=custregconfirmpassword;
		 try {
				Class.forName(cr.drivername);
				cr.connection=ConnectionManager.getInstace().getConnnection(cr.gmasterdb, cr.gdbUsername,cr.gdbPassword);
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}		
		if(cr.connection!=null){
			try {				
				cr.st=cr.connection.createStatement();
				cr.sqlqry="select emailaddr from custSignUp where emailaddr='" + emailaddr1 + "'";
				cr.rs=cr.st.executeQuery(cr.sqlqry);
				
				System.out.println(cr.rs.first());
				if (cr.rs.first()){
				cr.setFlag(false);	
				}else{
					cr.setFlag(true);
				}
				if(cr.isFlag()){
					cr.sqlqry="insert into custSignUp(custname,motbikeno,motbikename,mobieno,emailaddr,cregpwd,cregcpwd) values(?,?,?,?,?,?,?);";
					cr.ps=cr.connection.prepareStatement(cr.sqlqry);
					System.out.println(custname1 + motbikeno1+motbikename1+mobieno1+emailaddr1+cregpwd+cregcpwd);
					cr.ps.setString(1, custname1);
					cr.ps.setString(2, motbikeno1);
					cr.ps.setString(3, motbikename1);
					cr.ps.setString(4, mobieno1);
					cr.ps.setString(5, emailaddr1);
					cr.ps.setString(6, cregpwd);
					cr.ps.setString(7, cregcpwd);
					cr.ps.executeUpdate();
					cr.flagresult=true;
				}else if(cr.isFlag()==false){		
					try {			
						ConnectionManager.getInstace().closeConnection();
						cr.flagresult=false;
						//cr.response.setContentType(cr.cnttype);
						//cr.response.sendRedirect("errorpage.jsp?status=" + "You Have Altready Registered, Please Enter AnotherEmailAddress");
					} catch (Exception e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
				
			} catch (SQLException e){ 
				// TODO Auto-generated catch block
				e.printStackTrace();
				cr.flagresult=false;
			}finally{
				try {
					cr.st.close();
					cr.rs.close();
					ConnectionManager.getInstace().closeConnection();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
								
			}			
			
				
		}
		else{
			cr.flagresult=false;
		}		
	return cr.flagresult;
	}

}
