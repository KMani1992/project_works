package com.example.twistersday;

public class GetSet {
	private static String name=null;
	private static String dob=null;
	private static String active=null;
	private static String id=null;
	
	public static String getActive() {
		return active;
	}
	public static void setActive(String active) {
		GetSet.active = active;
	}	
	
	public static String getName() {
		return name;
	}
	public static void setName(String name) {
		GetSet.name = name;
	}
	public static String getDob() {
		return dob;
	}
	public static void setDob(String dob) {
		GetSet.dob = dob;
	}
	public static String getId() {
		return id;
	}
	public static void setId(String id) {
		GetSet.id = id;
	}
	
}
