package com.Drauworksdbinstall;

public class userprofileGetSet {
	private String userName;
	private String mobileNo;
	private String motorbikeName;
	private String motorbikeNo;
	private String emailAddr;
	public userprofileGetSet(String userName,String motorbikeNo,String motorbikeName,String mobileNo,String emailAddr){
		this.setUserName(userName);
		this.setMobileNo(mobileNo);
		this.setMotorbikeName(motorbikeName);
		this.setMotorbikeNo(motorbikeNo);
		this.setEmailAddr(emailAddr);
	}
	public void setUserName(String userName) {
		this.userName = userName;
	}
	public String getUserName() {
		return userName;
	}
	public void setMobileNo(String mobileNo) {
		this.mobileNo = mobileNo;
	}
	public String getMobileNo() {
		return mobileNo;
	}
	public void setMotorbikeName(String motorbikeName) {
		this.motorbikeName = motorbikeName;
	}
	public String getMotorbikeName() {
		return motorbikeName;
	}
	public void setMotorbikeNo(String motorbikeNo) {
		this.motorbikeNo = motorbikeNo;
	}
	public String getMotorbikeNo() {
		return motorbikeNo;
	}
	public void setEmailAddr(String emailAddr) {
		this.emailAddr = emailAddr;
	}
	public String getEmailAddr() {
		return emailAddr;
	}

}
