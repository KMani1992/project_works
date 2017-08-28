package com.Drauworksdbinstall;

public class RegStatusDetviwGetSet {
	
	public RegStatusDetviwGetSet(String pbmid,String pbfinunfin,String pbidrem){
		this.setPbid(pbmid);
		this.setPbfinunfin(pbfinunfin);
		this.setPbidrem(pbidrem);
	}
	public RegStatusDetviwGetSet(){
		
	}
	private String pbid;
	private String pbfinunfin;
	private String pbidrem;
	public String getPbid() {
		return pbid;
	}
	public void setPbid(String pbid) {
		this.pbid = pbid;
	}
	public String getPbfinunfin() {
		return pbfinunfin;
	}
	public void setPbfinunfin(String pbfinunfin) {
		this.pbfinunfin = pbfinunfin;
	}
	public String getPbidrem() {
		return pbidrem;
	}
	public void setPbidrem(String pbidrem) {
		this.pbidrem = pbidrem;
	}
}
