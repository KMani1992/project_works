package com.Drauworksdbinstall;

public class CommonGetSet  extends CustsupGetSet {
	private String logUsername=null;
	private String loguserPass=null;
	private static String Username=null;
	private static String BookProblemId=null;
	private static String PbmMajId=null;
	
	public void setlogUserName(String logUserName){
		this.logUsername=logUserName;		
	}
	public String getlogUserName(){
		return logUsername;		
	}
	public void setlogPass(String loguserPass){		
		this.loguserPass=loguserPass;
	}
	public String getlogPass(){		
		return loguserPass;
	}
	public void setUserName(String UserName){
		this.Username=UserName;
		
	}
	public String getUserName(){
		return Username;
		
	}
	public void setBookProblemId(String BookProblemId){
		this.BookProblemId=BookProblemId;
		
	}
	public String getBookProblemId(){
		return BookProblemId;
		
	}
	public String getPbmMajId() {
		return PbmMajId;
	}
	public void setPbmMajId(String pbmMajId) {
		PbmMajId = pbmMajId;
	}


}
