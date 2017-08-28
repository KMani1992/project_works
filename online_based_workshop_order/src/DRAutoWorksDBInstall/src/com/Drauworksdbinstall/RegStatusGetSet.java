package com.Drauworksdbinstall;

public class RegStatusGetSet {
	public RegStatusGetSet(String ordersubject,String orddetsmry,String OrderMajorId,String updated,String orddeliverydate,String Finished,String UnFinished){
		this.setRSordersubject(ordersubject);
		this.setRSorddetsmry(orddetsmry);
		this.setRSOrderMajorId(OrderMajorId);
		this.setRSupdated(updated);
		this.setRSorddeliverydate(orddeliverydate);
		this.setRSFinished(Finished);
		this.setRSUnFinished(UnFinished);
	}
	public RegStatusGetSet(){
		
	}
	
	private String RSordersubject;
	private  String RSorddetsmry;
	private  String RSOrderMajorId;
	private  String RSupdated;
	private  String RSorddeliverydate;
	private  String RSFinished;
	private  String RSUnFinished;
	public String getRSorddetsmry() {
		return RSorddetsmry;
	}
	public void setRSorddetsmry(String rSorddetsmry) {
		RSorddetsmry = rSorddetsmry;
	}
	public String getRSOrderMajorId() {
		return RSOrderMajorId;
	}
	public void setRSOrderMajorId(String rSOrderMajorId) {
		RSOrderMajorId = rSOrderMajorId;
	}
	public String getRSupdated() {
		return RSupdated;
	}
	public void setRSupdated(String rSupdated) {
		RSupdated = rSupdated;
	}
	public String getRSorddeliverydate() {
		return RSorddeliverydate;
	}
	public void setRSorddeliverydate(String rSorddeliverydate) {
		RSorddeliverydate = rSorddeliverydate;
	}
	public String getRSFinished() {
		return RSFinished;
	}
	public void setRSFinished(String rSFinished) {
		RSFinished = rSFinished;
	}
	public String getRSUnFinished() {
		return RSUnFinished;
	}
	public void setRSUnFinished(String rSUnFinished) {
		RSUnFinished = rSUnFinished;
	}
	public String getRSordersubject() {
		return RSordersubject;
	}
	public void setRSordersubject(String rSordersubject) {
		RSordersubject = rSordersubject;
	}	
}
