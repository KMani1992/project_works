package com.Drauworksdbinstall;

public class bookregistration {
	public int bookregistrationdet(){		
		int res=0;
		int ordmajid=0;
		int ordsbbid =0;
		
		CommonGetSet cgs =new CommonGetSet();
		CommonVariable cv=new CommonVariable();
		try{	
		System.out.println(cgs.getBookProblemId() + ":;" + cgs.getcuregmotorBikeNo() + ":;" + cgs.getcuregemailAddr());	
		cv.connection=ConnectionManager.getInstace().getConnnection(cv.gmasterdb, cv.gdbUsername, cv.gdbPassword);		
		System.out.println("Outside First");
		if (cv.connection!=null){
		System.out.println("Inside First");
		cv.sqlqry="select max(OrderMajorId) As MajId from CustRegistrationSumry";
		System.out.println("Inside First 1");
		cv.st=cv.connection.createStatement();
		cv.rs=cv.st.executeQuery(cv.sqlqry);
		System.out.println("Inside First 2" + cv.rs.first());
		if (cv.rs.first()){
			ordmajid =cv.rs.getInt(1) + 1 ;		
			System.out.println("Inside First id gen" + ordmajid);
		}else{
			ordmajid +=1;
			System.out.println("Inside First" + ordmajid);
		}
		System.out.println("Qry Preparing st" + ordmajid);
		
		// for summary table insertion
		cv.sqlqry="INSERT INTO `CustRegistrationSumry` ("; 
		cv.sqlqry +="`emailaddr`, `motorbikeno`, `OrderMajorId`, `ordersubject`,`orddetsmry`)"; 
		cv.sqlqry +=" VALUES(?,?,?,?,?); ";
		System.out.println(cv.sqlqry);		
		cv.ps=cv.connection.prepareStatement(cv.sqlqry);
		System.out.println("cv.sqlqry inside sql");		
		if (cgs.getBookProblemId().length()>=45){
		cv.sqlqry=cgs.getBookProblemId().substring(1, 45).concat("...");
		}else{
			cv.sqlqry=cgs.getBookProblemId().concat("...");
		}
		cv.ps.setString(1, cgs.getcuregemailAddr());
		cv.ps.setString(2, cgs.getcuregmotorBikeNo());
		cv.ps.setInt(3, ordmajid);		
		cv.ps.setString(4,"Problem Registration");
		cv.ps.setString(5,cv.sqlqry);
		cv.ps.executeUpdate();
		
		// for detailed table insertion
		
		cv.sqlqry="INSERT INTO `CustRegistration` ("; 
		cv.sqlqry +="`emailaddr`, `motorbikeno`, `OrderMajorId`, `OrderSubId`, `ordersubject`,"; 
		cv.sqlqry +="`orderdetail`) VALUES(?,?,?,?,?,?); ";
		System.out.println(cv.sqlqry);
		cv.ps=cv.connection.prepareStatement(cv.sqlqry);
		System.out.println("cv.sqlqry inside sql");
		for(String pblems:cgs.getBookProblemId().split(",")){
			ordsbbid += 1;
			cv.ps.setString(1, cgs.getcuregemailAddr());
			cv.ps.setString(2, cgs.getcuregmotorBikeNo());
			cv.ps.setInt(3, ordmajid);
			cv.ps.setInt(4, ordsbbid);
			cv.ps.setString(5,"Problem Registration");
			cv.ps.setString(6, pblems);
			cv.ps.executeUpdate();		
			System.out.println("Qry Preparing end" + ordmajid);
		}
		res=ordmajid;
		}
		}catch(Exception e){
			e.printStackTrace();			
			return res;
		}finally{
			ConnectionManager.getInstace().closeConnection();	
		}
		return res;
		
	}

}
