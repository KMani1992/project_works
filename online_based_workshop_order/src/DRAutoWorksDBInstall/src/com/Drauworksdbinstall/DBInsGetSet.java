package com.Drauworksdbinstall;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
public class DBInsGetSet {
	private String ServerName=null;
	private String CompanyName=null;
	private String CompanyId =null;
	private String dbPath=null;
	private String serverPassword=null;
	private Date periodfrom =null;
	private Date periodeto =null;
	
	private Date d=new Date();
	DateFormat ft=new SimpleDateFormat("yyyy-MM-dd");
	public void setServerName(String ServerName){
		this.ServerName=ServerName;
	}	
	public String getServerName(){
		return ServerName;
	}
	public void setCompanyName(String CompanyName){
		this.CompanyName=CompanyName;
	}	
	public String getCompanyName(){
		return CompanyName;
	}
	public void setCompanyId(String CompanyId){
		this.CompanyId=CompanyId;
	}	
	public String getCompanyId(){
		return CompanyId;
	}
	public void setdbPath(String dbPath){
		this.dbPath=dbPath;
	}	
	public String getdbPath(){
		return dbPath;
	}
	public void setServerPassword(String serverPassword){
		this.serverPassword=serverPassword;
	}	
	public String getServerPassword(){
		return serverPassword;
	}
	public void setPeriodfrom(Date periodfrom){
		System.out.println(periodfrom);
		this.periodfrom=periodfrom;
	}	
	public Date getPeriodfrom(){
		return periodfrom;
	}
	public void setPeriodeto(Date periodeto){
		System.out.println(periodeto);
		this.periodeto=periodeto;
	}	
	public Date getPeriodeto(){
		return periodeto;
	}
	public Date getDate(){		
		//System.out.println(d);
		//ft.format(d);
		Date created=null;
		System.out.println(ft.format(d));
		try {
			 created=ft.parse(ft.format(d));
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return created;
	}
	public boolean getTrueFlag(){
		return true;
	}
	public boolean getFalseFlag(){
		return false;
	}

}
