package com.Document;
import javax.swing.JFrame;

public class DocumentReader {
	
	 
	static Document jfr;
	 
	public static void main(String args[]) 
	{

	jfr=new Document();
	jfr.setTitle("DocumentReader - EasyReader");
	jfr.setBounds(250, 5, 900, 670);
	jfr.setVisible(true);
	jfr.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	
	}
	
	public static void filename(String file) 
	{
					
	jfr.setTitle(file+" - EasyReader");
	}

}
