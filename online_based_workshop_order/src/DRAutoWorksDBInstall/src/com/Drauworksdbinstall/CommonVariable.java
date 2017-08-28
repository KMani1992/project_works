package com.Drauworksdbinstall;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;


public class CommonVariable {
	public Connection connection=null;
	public ResultSet resset=null;
	public Statement stmt =null;
	public String sqlqry =null;
	public long inc=0;
	public boolean flagresult=false;
	public String CompFileName=null;
	public String gmasterdb="drawmaster";
	public String gdbUsername="root";
	public String gdbPassword="root";
	public Statement st=null;
	public ResultSet rs=null;
	public PreparedStatement ps =null;
	public boolean flag;
	public String drivername="com.mysql.jdbc.Driver";
	public HttpServletResponse response = null;
	public String cnttype="text/html";
	public int resstatus;
	public HttpSession ses;
	public boolean setFlag(boolean flag) {
		this.flag = flag;
		return flag;
	}
	public boolean isFlag() {
		return flag;
	}

}
